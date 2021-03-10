create database QLKS_Demo
go

use QLKS_Demo
go

create table DichVu
(
madv nvarchar(10) primary key,
tendv nvarchar(50) default 'chưa đặt tên',
dongia money not null,

)
go

create table NhanVien
(
manv nvarchar(10) primary key,
tennv nvarchar(50) default 'Chưa có tên',
ngaysinh date ,
quequan nvarchar(50),
luong money default 0
)
go

create table LoaiPhong
(
maloaiphong nvarchar(10) primary key,
dongia money,
mota nvarchar(100) 
)
go

create table UserTable
(
taikhoan nvarchar(50) primary key,
matkhau nvarchar(50) not null default 0,
manv nvarchar(10) references nhanvien(manv)
)
go


create table Phong
(
maphong nvarchar(10) primary key,
tenphong nvarchar(20) default 'Chưa đặt tên',
maloaiphong nvarchar(10) references loaiphong(maloaiphong),
trangthai bit default 0             --0 trống, 1 đã thuê

)
go


create table ThePhongThue
(
mathe nvarchar(10) primary key,
maphong nvarchar(10) references phong(maphong),
manv nvarchar(10) references nhanvien(manv),
tenkhachhang nvarchar(50) default 'Khánh hàng ẩn tên',
socmt nvarchar(20) not null,

ngaythue date default getdate(),
ngaydukientra date 
)
go


create table TheDichVu
(
madv nvarchar(10) references dichvu(madv),
mathe nvarchar(10) references thephongthue(mathe),
soluong int default 1,
primary key (madv, mathe)
)
go

create table HoaDon
(
mahd nvarchar(10) primary key,
ngayxuathoadon date default getdate(),
mathe nvarchar(10) references thephongthue(mathe),
tongtien money default 0
)
go


--tính tiền từng dịch vụ
create or alter function tinhTienDV(@mathe nvarchar(10), @madv nvarchar(10))
returns money
as
begin
declare @tongTien money, @soLuong int, @donGia money
select @soLuong=soluong, @donGia=dongia
from TheDichVu tdv, DichVu dv
where tdv.madv=@madv and tdv.mathe=@mathe
set @tongTien=@donGia*@soLuong
return @tongTien
end
go

--tính tổng tiền hóa đơn
create or alter function tinhTienHD(@mathe nvarchar(10))
returns money
as
begin
declare @tongTienHD money, @soNgayThuePhong int, @tongTienDV money
declare @donGiaPhong money, @ngayBD date, @ngayKT date
select  @donGiaPhong= lp.dongia, @ngayBD=ngaythue, @ngayKT=ngaydukientra
from ThePhongThue tpt, Phong p, LoaiPhong lp
where tpt.maphong=p.maphong and p.maloaiphong=lp.maloaiphong and tpt.mathe=@mathe
select @soNgayThuePhong=DATEDIFF(DAY,@ngayKT,@ngayBD)
select @tongTienDV=sum (dbo.tinhTienDV(tdv.mathe, madv))
from TheDichVu tdv, ThePhongThue tpt
where tpt.mathe=tdv.mathe and tpt.mathe=@mathe
set @tongTienHD=@soNgayThuePhong*@donGiaPhong+@tongTienDV
return @tongTienHD
end
go

--7/3/2021
--kiểm tra thông tin mã phòng
create proc kiemtrathongtin(@ma_phong nvarchar(10), @ten_phong nvarchar(20), @ma_loai_phong nvarchar(10))

as
begin
	
	select count(*) from Phong where maphong = @ma_phong and tenphong = @ten_phong and maloaiphong=@ma_loai_phong
	
end
go


--kiểm tra thông tin mã phòng
create proc thongtin_the(@ma_phong nvarchar(10))
as
select count(mathe) from ThePhongThue where maphong = @ma_phong
go


--kiểm tra thông tin mã thẻ
create proc kiemtramathe(@ma_the nvarchar(10))
as
begin
select count(mathe) from ThePhongThue where mathe =@ma_the
end
go

--nhập dữ liệu
create proc nhapdulieu(@mathe nvarchar(10), @maphong nvarchar (10), @manv nvarchar(10), @ten nvarchar(50), @cmt nvarchar(20), @dat date, @tra date)
as
insert into ThePhongThue(mathe, maphong, manv, tenkhachhang, socmt, ngaythue, ngaydukientra) values (@mathe, @maphong,@manv,@ten,@cmt,@dat,@tra)

--kiểm tra và nhập dữ liệu
create proc checktofix(@mathe nvarchar(10), @maphong nvarchar (10), @manv nvarchar(10), @ten nvarchar(50), @cmt nvarchar(20), @dat date, @tra date)
as
begin
declare @temp int
select @temp=count(*) from ThePhongThue where mathe = @mathe
if(@temp=1)
	begin
	delete ThePhongThue where mathe=@mathe;
	execute nhapdulieu @mathe , @maphong , @manv , @ten , @cmt , @dat , @tra;
	end
end
------Danh sách khách --------
CREATE OR ALTER PROC Customer_List
AS
BEGIN
SELECT tenkhachhang as N'Tên khách hàng', socmt as 'Số CMT', max(ngaythue) as N'Ngày thuê' ,count(socmt) as N'Số lần thuê' 
FROM thephongthue
group by tenkhachhang,socmt
END
------Danh sách khách đang thuê----------
CREATE OR ALTER PROC Customer_List_On
AS
BEGIN
SELECT tenkhachhang as N'Tên khách hàng', socmt as 'Số CMT', max(ngaythue) as N'Ngày thuê' ,count(socmt) as N'Số lần thuê' 
FROM thephongthue,Phong
WHERE ThePhongThue.maphong = PHONG.maphong
AND PHONG.trangthai = 'True'
GROUP BY tenkhachhang,socmt
HAVING DAY(GETDATE()) - DAY(MAX(ngaydukientra))>=0
END