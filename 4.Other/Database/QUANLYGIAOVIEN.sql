﻿CREATE DATABASE QUANLYGIAOVIEN

CREATE TABLE GIAOVIEN
(
	MAGV char(5),
	HOTEN nvarchar(40),
	PHAI nchar(3),
	DIACHI nvarchar(100),
	MABM nchar(5)
	PRIMARY KEY (MAGV)
)
CREATE TABLE BOMON
(
	MABM nchar(5),
	TENBM nvarchar(40),
	DIENTHOAI char(12), 
	TRUONGBM char(5),
	PRIMARY KEY (MABM)
)

INSERT INTO GIAOVIEN VALUES('001',N'Nguyễn Hoài An','Nam',N'25/3 Lạc Long Quân, Q.10, TP HCM','009')
INSERT INTO GIAOVIEN VALUES('002',N'Trần Trà Hương',N'Nữ',N'125 Trần Hưng Đạo, Q.1, TP HCM','008')
INSERT INTO GIAOVIEN VALUES('003',N'Nguyễn Ngọc Ánh',N'Nữ',N'12/21 Võ Văn Ngân, Thủ Đức, TP HCM','002')
INSERT INTO GIAOVIEN VALUES('004',N'Trương Nam Sơn','Nam',N'215 Lý Thường Kiệt, TP Biên Hòa','004')
INSERT INTO GIAOVIEN VALUES('005',N'Lý Hoàng Hà','Nam',N'22/5, Nguyễn Xí, Q.Bình Thạnh,TP HCM','007')
INSERT INTO GIAOVIEN VALUES('006',N'Trần Bạch Tuyết',N'Nữ',N'127 Hùng Vương, TP Mỹ Tho','004')
INSERT INTO GIAOVIEN VALUES('007',N'Nguyễn An Trung','Nam',N'234 3/2, TP Biên Hòa','003')
INSERT INTO GIAOVIEN VALUES('008',N'Trần Trung Hiếu','Nam',N'22/11 Lý Thường Kiệt, TP Mỹ Tho','006')
INSERT INTO GIAOVIEN VALUES('009',N'Trần Hoàng Nam','Nam',N'234 Trần Não, An Phú, TP HCM','001')
INSERT INTO GIAOVIEN VALUES('010',N'Phạm Thành Nam','Nam',N'221 Hùng Vương, Q.5, TP HCM','007')

INSERT INTO BOMON VALUES('001',N'Công nghệ tri thức','0838126126','003')
INSERT INTO BOMON VALUES('002',N'Hóa hữu cơ','0838222222','001')
INSERT INTO BOMON VALUES('003',N'Hóa lý','0838878787','004')
INSERT INTO BOMON VALUES('004',N'Hóa phân tích','0838777777','007')
INSERT INTO BOMON VALUES('005',N'Hệ thống thông tin','0838125125','006')
INSERT INTO BOMON VALUES('006',N'Mạng máy tính','0838676767','007')
INSERT INTO BOMON VALUES('007',N'Sinh hóa','0838898989','009')
INSERT INTO BOMON VALUES('008',N'Vật lý điện tử','0838234234','002')
INSERT INTO BOMON VALUES('009',N'Vật lý ứng dụng','0838454545','005')
INSERT INTO BOMON VALUES('010',N'Vi sinh','0838909090','004')