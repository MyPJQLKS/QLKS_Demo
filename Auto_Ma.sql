--Auto mã hóa đơn
Create or Alter function at_ma_hd()
returns nchar(10)
as
begin
declare @id int
declare @mahd nchar(10)
if(Select Count(mahd) from HoaDon)=0
   set @id=0
ELSE
    Select @id= Count(*) from HoaDon
	Select @mahd = case
	    When @id>=0 and @id <9 then 'HD00' + Convert(CHAR, Convert(int,@id)+1)
		When @id>=9 and @id <99 then 'HD0' + Convert(CHAR, Convert(int,@id)+1)
		When @id>=99 then 'HD' + Convert(CHAR, Convert(int,@id)+1)
	end
--Kiem tra ton tai
while(exists(select mahd from HoaDon where mahd=@mahd))
begin
   set @id=@id+1
   Select @mahd = case
	    When @id>=0 and @id <9 then 'HD00' + Convert(CHAR, Convert(int,@id)+1)
		When @id>=9 and @id <99 then 'HD0' + Convert(CHAR, Convert(int,@id)+1)
		When @id>=99 then 'HD' + Convert(CHAR, Convert(int,@id)+1)
   end
end
return @mahd


end
go
--Auto mã nhân viên
Create or Alter function at_ma_nv()
returns nchar(10)
as
begin
declare @id int
declare @manv nchar(10)
if(Select Count(manv) from NhanVien)=0
   set @id=0
ELSE
    Select @id= Count(*) from NhanVien
	Select @manv = case
	    When @id>=0 and @id <9 then 'NV00' + Convert(CHAR, Convert(int,@id)+1)
		When @id>=9 and @id <99 then 'NV0' + Convert(CHAR, Convert(int,@id)+1)
		When @id>=99 then 'NV' + Convert(CHAR, Convert(int,@id)+1)
	end
--Kiem tra ton tai
while(exists(select manv from NhanVien where manv=@manv))
begin
   set @id=@id+1
   Select @manv = case
	    When @id>=0 and @id <9 then 'NV00' + Convert(CHAR, Convert(int,@id)+1)
		When @id>=9 and @id <99 then 'NV0' + Convert(CHAR, Convert(int,@id)+1)
		When @id>=99 then 'NV' + Convert(CHAR, Convert(int,@id)+1)
   end
end
return @manv
end
go
