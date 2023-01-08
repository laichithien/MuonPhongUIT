--Initialize database
create database QUANLYPHONGHOC
go
use QUANLYPHONGHOC
go
create table PHONG
(
	TENPHONG nvarchar(40),
	SUCCHUA int,
	LOAIPHONG nvarchar(40),
	TOA nvarchar(40),
	STARS int,
	LUOTXEM int
)
go
create table TKB
(
	TENPHONG nvarchar(40),
	MALOP nvarchar(40),
	THU int,
	TIETBD int,
	TIETKT int,
	NGAYBD datetime,
	NGAYKT datetime,
	TENGV nvarchar(40),
)
go
create table BAOCAOHUHAI
(
	TENPHONG nvarchar(40),
	TENGV nvarchar(40),
	NOIDUNG nvarchar(40),
	NGAYBAOCAO datetime,
	TINHTRANG bit
)
go
create table COMMENTS
(
	TENPHONG nvarchar(40),
	TENGV nvarchar(40),
	NOIDUNG nvarchar(200),
	STARS int
)
go
create table MUONPHONG
(
	TENGV nvarchar(40),
	MAGV nvarchar(40),
	MALOP nvarchar(40),
	NGAY datetime,
	TIETBD int,
	TIETKT int
)
go
--Add data
--PHONG-------------------------------------------------------------------
insert into PHONG (TENPHONG, SUCCHUA, LOAIPHONG, TOA, STARS, LUOTXEM)
values
(N'A205', 50, N'PM', N'Tòa A', 0, 0),
(N'A213', 50, N'PM', N'Tòa A', 0, 0),
(N'A215', 48, N'CLC', N'Tòa A', 0, 0),
(N'A301', 30, N'TTNN', N'Tòa A', 0, 0),
(N'A305', 30, N'TTNN', N'Tòa A', 0, 0),
(N'A307', 30, N'TTNN', N'Tòa A', 0, 0),
(N'A309', 30, N'TTNN', N'Tòa A', 0, 0),
(N'A311', 25, N'TTNN', N'Tòa A', 0, 0),
(N'A313', 25, N'TTNN', N'Tòa A', 0, 0),
(N'A315', 50, N'CLC', N'Tòa A', 0, 0),
(N'A323', 30, N'TTNN', N'Tòa A', 0, 0),
(N'A325', 48, N'CLC', N'Tòa A', 0, 0),
(N'GĐ1(A1)', 400, N'GĐ', N'Tòa A', 0, 0),
(N'GĐ2(A2)', 200, N'GĐ', N'Tòa A', 0, 0),
(N'GĐ3(A3)', 300, N'GĐ', N'Tòa A', 0, 0),
(N'B1.02', 48, N'LT', N'Tòa B', 0, 0),
(N'B1.04', 48, N'LT', N'Tòa B', 0, 0),
(N'B1.06', 48, N'LT', N'Tòa B', 0, 0),
(N'B1.08', 52, N'LT', N'Tòa B', 0, 0),
(N'B1.10', 52, N'LT', N'Tòa B', 0, 0),
(N'B1.12', 52, N'LT', N'Tòa B', 0, 0),
(N'B1.14', 136, N'LT', N'Tòa B', 0, 0),
(N'B1.16', 64, N'LT', N'Tòa B', 0, 0),
(N'B1.18', 64, N'LT', N'Tòa B', 0, 0),
(N'B1.20', 72, N'LT', N'Tòa B', 0, 0),
(N'B1.22', 72, N'LT', N'Tòa B', 0, 0),
(N'B2.16', 50, N'PM', N'Tòa B', 0, 0),
(N'B2.18', 50, N'PM', N'Tòa B', 0, 0),
(N'B2.20', 60, N'PM', N'Tòa B', 0, 0),
(N'B2.22', 60, N'PM', N'Tòa B', 0, 0),
(N'B3.02', 40, N'PM', N'Tòa B', 0, 0),
(N'B3.04', 40, N'PM', N'Tòa B', 0, 0),
(N'B3.06', 40, N'PM', N'Tòa B', 0, 0),
(N'B3.08', 40, N'PM', N'Tòa B', 0, 0),
(N'B3.10', 64, N'LT', N'Tòa B', 0, 0),
(N'B3.12', 64, N'LT', N'Tòa B', 0, 0),
(N'B3.14', 140, N'LT', N'Tòa B', 0, 0),
(N'B3.16', 72, N'LT', N'Tòa B', 0, 0),
(N'B3.18', 72, N'LT', N'Tòa B', 0, 0),
(N'B3.20', 72, N'LT', N'Tòa B', 0, 0),
(N'B3.22', 72, N'LT', N'Tòa B', 0, 0),
(N'B4.02', 40, N'PM', N'Tòa B', 0, 0),
(N'B4.04', 40, N'PM', N'Tòa B', 0, 0),
(N'B4.06', 40, N'PM', N'Tòa B', 0, 0),
(N'B4.08', 40, N'PM', N'Tòa B', 0, 0),
(N'B4.10', 56, N'LT', N'Tòa B', 0, 0),
(N'B4.12', 56, N'LT', N'Tòa B', 0, 0),
(N'B4.14', 160, N'LT', N'Tòa B', 0, 0),
(N'B4.16', 72, N'LT', N'Tòa B', 0, 0),
(N'B4.18', 72, N'LT', N'Tòa B', 0, 0),
(N'B4.20', 72, N'LT', N'Tòa B', 0, 0),
(N'B4.22', 72, N'LT', N'Tòa B', 0, 0),
(N'B5.02', 64, N'PM', N'Tòa B', 0, 0),
(N'B5.08', 140, N'LT', N'Tòa B', 0, 0),
(N'B5.10', 72, N'LT', N'Tòa B', 0, 0),
(N'B5.14', 180, N'LT', N'Tòa B', 0, 0),
(N'B6.02', 64, N'LT', N'Tòa B', 0, 0),
(N'B6.02', 64, N'LT', N'Tòa B', 0, 0),
(N'B6.04', 64, N'LT', N'Tòa B', 0, 0),
(N'B6.06', 154, N'LT', N'Tòa B', 0, 0),
(N'B6.08', 72, N'LT', N'Tòa B', 0, 0),
(N'B6.10', 72, N'LT', N'Tòa B', 0, 0),
(N'B6.12', 192, N'LT', N'Tòa B', 0, 0),
(N'B7.02', 144, N'LT', N'Tòa B', 0, 0),
(N'B7.04', 72, N'LT', N'Tòa B', 0, 0),
(N'B7.06', 72, N'LT', N'Tòa B', 0, 0),
(N'B7.08', 200, N'LT', N'Tòa B', 0, 0),
(N'B9.02', 72, N'LT', N'Tòa B', 0, 0),
(N'B9.04', 72, N'LT', N'Tòa B', 0, 0),
(N'C101', 50, N'CLC', N'Tòa C', 0, 0),
(N'C102', 32, N'CLC', N'Tòa C', 0, 0),
(N'C104', 36, N'CLC', N'Tòa C', 0, 0),
(N'C106', 56, N'CLC', N'Tòa C', 0, 0),
(N'C107', 30, N'PM học tiếng Nhật', N'Tòa C', 0, 0),
(N'C108', 64, N'CLC', N'Tòa C', 0, 0),
(N'C109', 100, N'CLC', N'Tòa C', 0, 0),
(N'C110', 30, N'PM', N'Tòa C', 0, 0),
(N'C111', 50, N'PM', N'Tòa C', 0, 0),
(N'C112', 100, N'CLC', N'Tòa C', 0, 0),
(N'C113', 140, N'LT', N'Tòa C', 0, 0),
(N'C114', 140, N'LT', N'Tòa C', 0, 0),
(N'C201', 50, N'CLC', N'Tòa C', 0, 0),
(N'C202', 30, N'PM', N'Tòa C', 0, 0),
(N'C205', 100, N'LT', N'Tòa C', 0, 0),
(N'C206', 50, N'CLC', N'Tòa C', 0, 0),
(N'C208', 50, N'CLC', N'Tòa C', 0, 0),
(N'C209', 30, N'PM', N'Tòa C', 0, 0),
(N'C210', 50, N'CLC', N'Tòa C', 0, 0),
(N'C211', 50, N'PM', N'Tòa C', 0, 0),
(N'C212', 50, N'CLC', N'Tòa C', 0, 0),
(N'C213', 50, N'LT', N'Tòa C', 0, 0),
(N'C214', 100, N'CLC', N'Tòa C', 0, 0),
(N'C215', 50, N'LT', N'Tòa C', 0, 0),
(N'C216', 50, N'CLC', N'Tòa C', 0, 0),
(N'C218', 50, N'CLC', N'Tòa C', 0, 0),
(N'C301', 50, N'CLC', N'Tòa C', 0, 0),
(N'C302', 30, N'PM', N'Tòa C', 0, 0),
(N'C305', 50, N'CLC', N'Tòa C', 0, 0),
(N'C306', 50, N'CLC', N'Tòa C', 0, 0),
(N'C307', 50, N'CLC', N'Tòa C', 0, 0),
(N'C308', 50, N'CLC', N'Tòa C', 0, 0),
(N'C309', 80, N'CLC', N'Tòa C', 0, 0),
(N'C310', 50, N'CLC', N'Tòa C', 0, 0),
(N'C311', 80, N'CLC', N'Tòa C', 0, 0),
(N'C312', 50, N'CLC', N'Tòa C', 0, 0),
(N'C313', 50, N'CLC', N'Tòa C', 0, 0),
(N'C314', 80, N'CLC', N'Tòa C', 0, 0),
(N'C315', 50, N'CLC', N'Tòa C', 0, 0),
(N'C316', 50, N'CLC', N'Tòa C', 0, 0),
(N'C318', 50, N'CLC', N'Tòa C', 0, 0),
(N'E02.3', 30, N'LT', N'Tòa E', 0, 0),
(N'E02.4', 48, N'LT', N'Tòa E', 0, 0),
(N'E03.2', 48, N'LT', N'Tòa E', 0, 0),
(N'E03.3', 30, N'LT', N'Tòa E', 0, 0),
(N'E03.4', 48, N'LT', N'Tòa E', 0, 0),
(N'E04.1', 54, N'LT', N'Tòa E', 0, 0),
(N'E04.2', 48, N'LT', N'Tòa E', 0, 0),
(N'E04.3', 30, N'LT', N'Tòa E', 0, 0),
(N'E04.4', 48, N'LT', N'Tòa E', 0, 0),
(N'E10.1', 50, N'LT', N'Tòa E', 0, 0),
(N'E11.2', 32, N'LT', N'Tòa E', 0, 0),
(N'E11.4', 32, N'LT', N'Tòa E', 0, 0),
(N'E11.5', 5, N'E-Leanring', N'Tòa E', 0, 0),
(N'E11.6', 32, N'LT', N'Tòa E', 0, 0),
(N'E11.8', 30, N'LT', N'Tòa E', 0, 0),
(N'E12.2A', 5, N'E-Leanring', N'Tòa E', 0, 0),
(N'HTE', 200, N'Hội trường E12', N'Tòa E', 0, 0),
(N'Sân Bóng Bàn', 60, N'ST', N'Sân tập', 0, 0),
(N'Sân Bóng Chuyền', 60, N'ST', N'Sân tập', 0, 0),
(N'Sân Bóng Rổ', 60, N'ST', N'Sân tập', 0, 0),
(N'Sân Bóng Đá', 60, N'ST', N'Sân tập', 0, 0),
(N'Sân Cầu Lông', 70, N'ST', N'Sân tập', 0, 0),
(N'Sân Võ Thuật', 60, N'ST', N'Sân tập', 0, 0)

--TKB
insert into TKB(TENPHONG, MALOP, THU, TIETBD, TIETKT, NGAYBD, NGAYKT, TENGV)
values



