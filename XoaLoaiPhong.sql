use QLKS_Demo
go
create or alter  proc xoa1Phong
	@ma nvarchar(10)
as begin
	declare curNV cursor 
	for select mathe
	from ThePhongThue
	where maphong=@ma
	declare @a nvarchar(10)
	open curNV
	fetch next from curNV into @a
	while (@@FETCH_STATUS=0)
	begin
		delete from TheDichVu where mathe=@a
		delete from HoaDon where mathe=@a
		fetch next from curNV into @a
	end
	close curNV
	deallocate curNV
	delete from ThePhongThue where maphong=@ma
	delete from Phong where maphong=@ma
end
-----------------------------
go
create or alter  proc xoa1LoaiPhong
	@ma nvarchar(10)
as begin
	declare curLP cursor 
	for select maphong
	from Phong
	where Phong.maloaiphong=@ma
	declare @maphong nvarchar(10)
	open curLP
	fetch next from curLP into @maphong
	while (@@FETCH_STATUS=0)
	begin
		exec xoa1Phong @maphong
		fetch next from curLP into @maphong
	end
	close curLP
	deallocate curLP
	delete from LoaiPhong where maloaiphong = @ma
end
go 
