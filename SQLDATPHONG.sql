USE [QLKS_Demo]
GO


CREATE OR ALTER proc [dbo].[nhapdulieu](@mathe nvarchar(10),
    @maphong nvarchar (10),
    @manv nvarchar(10),
    @ten nvarchar(50),
    @cmt nvarchar(20),
    @dat date,
    @tra date)
as
begin
    if(select count(*)
    from ThePhongThue
    where mathe=@mathe)=0
begin
        if(select DATEDIFF(day, @dat, @tra))>=0
begin
            begin
                if(select count(*)
                from Phong
                where maphong=@maphong)!=0
begin
                    if(select count(*)
                    from NhanVien
                    where manv=@manv)!=0
begin
                        if(select trangthai
                        from Phong
                        where maphong=@maphong)= 'false'
begin
                            insert into ThePhongThue
                                (mathe, maphong, manv, tenkhachhang, socmt, ngaythue, ngaydukientra)
                            values
                                (@mathe, @maphong, @manv, @ten, @cmt, @dat, @tra)
                            update Phong set trangthai= 'True' where maphong=@maphong
                            print(N'Thêm thẻ thành công');
                        end
else
begin
                            print(N'Phòng đã được đặt mời chọn phòng khác')
                        end
                    end
else
print(N'Không tồn tại phòng có mã này')
                end
            end
        end
else
begin
            print(N'Ngày đặt muộn hơn ngày trả, thao tác tác bị hủy')
        end
    end
else
begin
        print(N'Đã có mã thẻ này, mời chọn mã khác')
    end
end
GO

CREATE OR ALTER proc [dbo].[suathe]
    (@macu nvarchar(10),
    @mathe nvarchar(10),
    @maphong nvarchar (10),
    @manv nvarchar(10),
    @ten nvarchar(50),
    @cmt nvarchar(20),
    @dat date,
    @tra date)
as
update ThePhongThue set mathe=@mathe, maphong=@maphong, manv=@manv, tenkhachhang=@ten,socmt=@cmt, ngaythue=@dat, ngaydukientra=@tra
go


CREATE OR ALTER proc [dbo].[checktofix]
    (@macu nvarchar(10),
    @maphongcu nvarchar (10),
    @mathe nvarchar(10),
    @maphong nvarchar (10),
    @manv nvarchar(10),
    @ten nvarchar(50),
    @cmt nvarchar(20),
    @dat date,
    @tra date)
as
begin
    if(select DATEDIFF(day, @dat, @tra))>=0
begin
        IF(@maphongcu=@maphong)
        IF(@mathe=@macu)
            execute suathe @macu, @mathe, @maphong, @manv, @ten, @cmt, @dat, @tra
            ELSE
            IF(select COUNT(*)
        FROM ThePhongThue
        where @mathe= mathe)>0
            execute suathe @macu, @mathe, @maphong, @manv, @ten, @cmt, @dat, @tra
            ELSE
            PRINT(N'Mã thẻ đã bị trùng')
            ELSE
            IF(select COUNT(*)
        FROM ThePhongThue
        where maphong= @maphong)>0
            IF(@mathe=@macu)
            execute suathe @macu, @mathe, @maphong, @manv, @ten, @cmt, @dat, @tra
            ELSE
            IF(select COUNT(*)
        FROM ThePhongThue
        where @mathe= mathe)>0
            execute suathe @macu, @mathe, @maphong, @manv, @ten, @cmt, @dat, @tra
            ELSE
            PRINT(N'Mã thẻ đã bị trùng')
    end
else
print(N'Ngày đặt muộn hơn ngày trả')
end
go


create or alter proc xoathe
    (@mathe nvarchar(10))
as
begin
    declare @maphong nvarchar (10)
    select @maphong = maphong
    from ThePhongThue
    where mathe=@mathe
    if(select count(*)
    from Phong
    where maphong=@maphong)!=0
begin
        update Phong set trangthai= 'False' where maphong=@maphong
        delete ThePhongThue where mathe=@mathe;
        print(N'Xóa thẻ thành công');
    end
else
print(N'Không tồn tại phòng có mã phòng này, thao tác đã bị hủy')
end
go

create or alter trigger trangthai on thephongthue after update
as
begin
    update Phong set trangthai='True' where maphong in (select maphong
    from ThePhongThue)
    update Phong set trangthai='False' where maphong not in (select maphong
    from ThePhongThue)
end
go


create or alter trigger themtrangthai on thephongthue for insert
as
begin
    update Phong set trangthai='True' where maphong in (select maphong
    from ThePhongThue)
    update Phong set trangthai='False' where maphong not in (select maphong
    from ThePhongThue)
end
go

create or alter trigger xoatrangthai on thephongthue for delete
as
begin
    update Phong set trangthai='True' where maphong in (select maphong
    from ThePhongThue)
    update Phong set trangthai='False' where maphong not in (select maphong
    from ThePhongThue)
end
go
