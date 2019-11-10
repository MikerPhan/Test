create database BanTraSua
go

use  BanTraSua
go

drop table NhanVien
create table NhanVien
(
	MaNV varchar(30) not null primary key,
	TenNV nvarchar(50) not null,
	GioiTinh nvarchar(10),
	NamSinh int
	
	);
go
 --them du lieu
insert into Nhanvien values ('nv01',N'Trở Nguyễn',N'Nam',1996);
insert into Nhanvien values ('nv02',N'Lan Bình',N'Nữ',1998);
insert into Nhanvien values ('nv03',N'Huỳnh Trần',N'Nữ',1997);
insert into Nhanvien values ('nv04',N'Lý Trần',N'Nữ',1995);
insert into Nhanvien values ('nv05',N'Hoà Nguyễn',N'Nam',1996);
go


---cap nhap du lieu--
update Nhanvien set TenNV=N'Văn Bảy',Gioitinh=N'Nam',NamSinh=1999 where MaNV='nv05'
---xoa du lieu
delete Nhanvien where MaNV='nv05'


select* from Nhanvien
--BANG HANG HOA
create table HangHoa
(  
	MaHH nvarchar(10) not null primary key,
   TenHH nvarchar(50) not null,
   Soluong int,
   Gia float,
   );
go

   insert into Hanghoa values ('ts01',N'Trà sữa trân châu trắng',20,20000);
   insert into Hanghoa values ('ts02',N'Trà sữa bạc hà',30,25000);
   insert into Hanghoa values ('ts03',N'Trà sữa thái xanh',20,25000);
   insert into Hanghoa values ('ts04',N'Hồng trà ',15,22000);
   insert into Hanghoa values ('ts05',N'Lục trà',25,32000);
   insert into HangHoa values ('ts06',N'Trà sữa đặc biệt',50, 45000);

   select* From HangHoa
   ---BANG KHACH HANG
create table KhachHang
(
	MaKH nvarchar(30) not null primary key,
	TenKH nvarchar(50) not null,
	Diachi nvarchar(50) not null,
	SDT nvarchar(10)
	);
go
	insert into KhachHang values('kh01',N'Trần Thị Trang',N'351 Lạc Long Quân,p5,q11','0165433241');
	insert into KhachHang values('kh02',N'Trần Thị Lý',N'56 Lê Văn Quới,p3,q10','0989700675');
	insert into KhachHang values('kh03',N'Nguyễn Anh Nam',N'50 Lê Văn Sỹ,p3,q3','0164321142');
	insert into KhachHang values('kh04',N'Đỗ Ngọc Nhi',N'241 Hiệp Thành,p7,q10','0934567876');


	select* From KhachHang
--- BANG NHA CUNG CAP
create table NhaCungCap
(
	MaNCC nvarchar(10) not null primary key,
	TenNCC nvarchar(30) not null,
	HangHoaCC nvarchar(30) not null,
	Chatluong nvarchar(10)
	);
go
	insert into NhaCungCap values('ncc01',N'Hoa Sen',N'trân châu trắng',N'tốt');
	insert into NhaCungCap values('ncc02',N'Ngọc Mến',N'hạt thủy tinh',N'tốt');
	insert into NhaCungCap values('ncc03',N'Bòn Bon',N'thạch củ năng',N'trung bình');
	insert into NhaCungCap values('ncc04',N'Thiên Kỳ',N'trà túi lọc',N'tốt');

	select* From NhaCungCap
--- BANG HOA DON

drop table HoaDon
Create table HoaDon
(
	MaHD nvarchar(10) not null primary key,
	MaKH nvarchar(10) not null,
	MaNV nvarchar(10) not null,
	NgaylapHD date default getdate()
	);
go
delete from HoaDon

	insert into HoaDon values('hd01','kh01','nv01', getdate());


	insert into HoaDon values('hd02','kh02','nv01',getdate());


	insert into HoaDon values('hd03','kh03','nv02',getdate());
	insert into HoaDon values('hd04','kh04','nv03',getdate());
	insert into HoaDon values('hd05', 'kh05', 'nv03', '2014-4-6');
	
	select* From HoaDon

	---don hang
	create table DonHang
	(
	MaDH nvarchar(10) not null primary key,
	MaHH nvarchar(10) not null,
	MaNCC nvarchar(10) not null,
	SoLuong int,
	Gia float
	)
	go

	insert into DonHang values ('dh01','hh01','ncc01',10,20000);
	insert into DonHang values ('dh02','hh04','ncc05',2,20000);
    insert into DonHang values ('dh03','hh05','ncc06',4,20000);
    insert into DonHang values ('dh04','hh06','ncc07',5,20000);
    insert into DonHang values ('dh05','hh07','ncc04',20,20000);
	select *from DonHang
	select * from DonHang
