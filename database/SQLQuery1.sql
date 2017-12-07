use QLNV
go
set dateformat dmy


create table nhanvien
(
	[MaNhanVien] int Identity(1,1),
	[HoTenNhanVien] [nvarchar](50) NULL,
	[NgaySinh] [datetime] NULL,
	[GioiTinh]	[nvarchar](10) NULL,
	[DienThoai] [nvarchar](15) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[Email]	[nvarchar](50) NULL,
	[MaPhongBan] [int] NULL,
	CONSTRAINT [PK_NHANVIEN] PRIMARY KEY (MaNhanVien)
)
create table phongban
(
	[MaPhongBan]	int identity(1,1),
	[TenPhongBan]	[nvarchar](20) NULL,
	CONSTRAINT [PK_PHONGBAN] PRIMARY KEY (MaPhongBan)
)

ALTER TABLE [NHANVIEN] WITH NOCHECK ADD CONSTRAINT [FK_NHANVIEN_PHONGBAN]
FOREIGN KEY([MaPhongBan])
REFERENCES [PHONGBAN] ([MaPhongBan])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_PHONGBAN]
GO

insert into phongban values(N'Marketing')
insert into phongban values(N'Kế Toán')
insert into phongban values(N'Kinh Doanh')
insert into phongban values(N'Dịch Vụ')

insert into nhanvien values(N'PHẠM MINH VŨ','24/01/1980',N'Nam','0905646162',N'163/30 THÀNH THÁI
F.14 Q.10 TPHCM','minhvu123@gmail.com',1)
insert into nhanvien values(N'NGUYỄN MINH THÀNH','04/05/1983',N'Nam','0908373612',N'41/4 CALMETTE
Q1 TPHCM','minhthanh0405@yahoo.com',1)
insert into nhanvien values(N'NGUYỄN HÀ MY','13/04/1985',N'Nữ','0908783274',N'178 NAM KỲ KHỞI
NGHĨA Q4 TPHCM','mynguyen@gmail.com',1)
insert into nhanvien values(N'NGUYỄN QUỲNH NHƯ','14/07/1987',N'Nữ','0903578356',N'235 NGUYỄNTHỊ MINH KHAI 
Q1 TPHCM','nhunguyenquynh@gmail.com',1)

insert into nhanvien values(N'NGUYỄN HOÀNG MINH','02/09/1988',N'Nam','0905646121',N'234 THÀNH THÁI
F.14 Q.10 TPHCM','minhnguyuen123@gmail.com',2)
insert into nhanvien values(N'TRẦN THỊ VĂN CHÂU','19/04/1983',N'Nữ','0908373444',N'127 TRẦN HƯNG ĐẠO Q1
TPHCM','chautranthi@yahoo.com',2)
insert into nhanvien values(N'NGUYỄN HOÀNG NAM','21/10/1988',N'Nam','0908783213',N'4 TRẦN ĐÌNH HƯNG
Q1 TPHCM','namhoang@gmail.com',2)
insert into nhanvien values(N'LÊ THỊ DIỆU HẰNG','12/06/1986',N'Nữ','0907462378',N'332 ĐINH TIÊN HOÀNG Q1
TPHCM','hangle1206@yahoo.com',2)

insert into nhanvien values(N'TRẦN THANH PHÚC','02/09/1983',N'Nam','091646141',N'33 TRƯƠNG ĐỊNH Q.TB
TPHCM','tranphuc123@gmail.com',3)
insert into nhanvien values(N'VŨ ĐÌNH ÁI','19/06/1989',N'Nam','0908254984',N'311 TRẦN HƯNG ĐẠO Q1
TPHCM','vudinhai@gmail.com',3)
insert into nhanvien values(N'TRẦN THÁI ÂN','21/01/1992',N'Nam','0908748415',N'167 THÀNH THÁI
F.14 Q.10 TPHCM','antran123@gmail.com',3)
insert into nhanvien values(N'NGUYỄN KIM OANH','24/07/1989',N'Nữ','0938463722',N'332 VÕ THỊ SÁU Q1
TPHCM','kimoanh@yahoo.com',3)

insert into nhanvien values(N'ĐINH THỊ THÙY DUNG','02/04/1987',N'Nữ','091644874',N'33 LÊ LAI Q.GV
TPHCM','thuydung0204@gmail.com',4)
insert into nhanvien values(N'TRẦN THANH THỊNH','19/12/1981',N'Nam','0988254984',N'311 CÂY TRÂM Q.GV
TPHCM','orcthinh@gmail.com',4)
insert into nhanvien values(N'TRẦN HỒNG HẢI','20/11/1991',N'Nam','0908741412',N'167 UNG VĂN KHIÊM
Q.BÌNH THẠNH TPHCM','synztran@gmail.com',4)
insert into nhanvien values(N'DƯƠNG YẾN LINH','14/04/1990',N'Nữ','0938476218',N'322 NGUYỄN THÁI BÌNH Q.TB 
TPHCM','yenlinh@yahoo.com',4)



