CREATE DATABASE QUAN_LY_KHACH_SAN
ON
PRIMARY ( NAME = ALTP_data,
      FILENAME = 'D:\QUAN_LY_KHACH_SAN.mdf',
      SIZE = 100MB,
      MAXSIZE = 500,
      FILEGROWTH = 50%)
LOG ON 
( NAME = ALTP_log,
   FILENAME = 'D:\QUAN_LY_KHACH_SAN.ldf',
   SIZE = 50MB,
   MAXSIZE = 100,
   FILEGROWTH = 20
)

GO 
USE QUAN_LY_KHACH_SAN;

GO
--1.Table LOAI_KHACH_HANG
CREATE TABLE LOAI_KHACH_HANG (
	MaLoaiKhach NVARCHAR(10) NOT NULL,
	TenLoaiKhach NVARCHAR(50) NOT NULL,
	GhiChu NTEXT DEFAULT '',
)

--2.Table KHACH_HANG
CREATE TABLE KHACH_HANG (
	MaKhachHang INT NOT NULL,
	TenKhachHang NVARCHAR(50) NOT NULL,
	CMND NVARCHAR(15) NOT NULL,
	DiaChi NVARCHAR(50) NOT NULL,
	MaLoaiKhach NVARCHAR(10) NOT NULL,
)

GO
--3.BANG LOAI_PHONG
CREATE TABLE LOAI_PHONG (
	MaLoaiPhong NVARCHAR(10) NOT NULL,
	TenLoaiPhong NVARCHAR(50) NOT NULL,
	DonGia MONEY DEFAULT 0,
)

GO
--4.Table PHONG
CREATE TABLE PHONG (
	MaPhong INT NOT NULL,
	TinhTrang NVARCHAR(10) NOT NULL,
	MaLoaiPhong NVARCHAR(10) NOT NULL,
	GhiChu NTEXT DEFAULT '',
)

GO
--5.BANG PHIEU_THUE_PHONG
CREATE TABLE PHIEU_THUE_PHONG (
	MaPhieuThue INT NOT NULL,
	NgayBatDauThue DATE NOT NULL,
	MaPhong INT NOT NULL,
)

GO
--6.BANG CHI_TIET_PHIEU_THUE
CREATE TABLE CHI_TIET_PHIEU_THUE (
	MaChiTietPT INT NOT NULL,
	MaKhachHang INT NOT NULL,
	MaPhieuThue INT NOT NULL,
)

GO
--7.BANG HOA_DON
CREATE TABLE HOA_DON (
	MaHoaDon INT NOT NULL,
	TenKhachHang NVARCHAR(50) NOT NULL,
	TriGia MONEY DEFAULT 0,
)

GO
--8.BANG CHI_TIET_HOA_DON
CREATE TABLE CHI_TIET_HOA_DON (
	MaChiTietHD INT NOT NULL,
	MaHoaDon INT NOT NULL,
	SoNgayThue INT NOT NULL,
	DonGia MONEY DEFAULT 0,
	ThanhTien MONEY DEFAULT 0,
	NgayThanhToan DATE,
	MaPhong INT NOT NULL,
)
GO
--9.BANG THAM_SO
CREATE TABLE THAM_SO (
	SoKhachToiDa INT NOT NULL,
	PhuThu FLOAT NOT NULL,
	HeSo FLOAT NOT NULL,
	SoNgayThue INT,
	PhuThuKhachThu INT,
	SLKhachNuocNgoai INT
)
GO
--10.BANG BAOCAO_DOANHTHUTHEOLOAIPHONG
CREATE TABLE BAOCAO_DOANHTHUTHEOLOAIPHONG (
	MaBCDoanhThu INT NOT NULL,
	ThangBaoCao INT NOT NULL,
)
GO
--11. BANG CHITIET_BAOCAODOANHTHU
CREATE TABLE CHITIET_BAOCAODOANHTHU (
	MaBCCTDoanhThu INT NOT NULL,
	MaLoaiPhong NVARCHAR(10) NOT NULL,
	MaBCDoanhThu INT NOT NULL,
	DoanhThuThang MONEY,
	TiLe CHAR(10),
)
GO
--12. BANG BAOCAO_MATDOSUDUNGPHONG
CREATE TABLE BAOCAO_MATDOSUDUNGPHONG (
	MaBCMatDoSuDung INT NOT NULL,
	ThangBaoCao INT NOT NULL,
)
GO
--13. BANG CHITIET_BAOCAOMATDOSUDUNG
CREATE TABLE CHITIET_BAOCAOMATDOSUDUNG (
	MaBCCTMatDoSuDung INT NOT NULL,
	MaPhong INT NOT NULL,
	MaBCMatDoSuDung INT NOT NULL,
	SoNgayThue INT,
	TiLe CHAR(10),
)
GO
--14. BANG NGUOI_DUNG
CREATE TABLE NGUOI_DUNG (
	MaTaiKhoan INT NOT NULL,
	TenTaiKhoan CHAR(50) NOT NULL,
	MatKhau CHAR(20) NOT NULL,
)
GO
--15. BANG DANH_MUC
CREATE TABLE DANH_MUC (
	DMLoaiPhong NVARCHAR(50)
)

-------------------------------------------KHOA CHINH--------------------------------------------
--1 KHOA CHINH CHO BANG KHACH_HANG
ALTER TABLE KHACH_HANG ADD CONSTRAINT P_KHACH_HANG PRIMARY KEY (MaKhachHang)

--2 KHOA CHINH CHO BANG LOAI_KHACH_HANG
ALTER TABLE LOAI_KHACH_HANG ADD CONSTRAINT P_LOAI_KHACH_HANG PRIMARY KEY (MaLoaiKhach)

--3 KHOA CHINH CHO BANG PHONG
ALTER TABLE PHONG ADD CONSTRAINT P_PHONG PRIMARY KEY (MaPhong)

--4 KHOA CHINH CHO BANG LOAI_PHONG
ALTER TABLE LOAI_PHONG ADD CONSTRAINT P_LOAI_PHONG PRIMARY KEY (MaLoaiPhong)

--5 KHOA CHINH CHO BANG PHIEU_THUE_PHONG
ALTER TABLE PHIEU_THUE_PHONG ADD CONSTRAINT P_PHIEU_THUE_PHONG PRIMARY KEY (MaPhieuThue)

--6 KHOA CHINH CHO BANG CHI_TIET_PHIEU_THUE
ALTER TABLE CHI_TIET_PHIEU_THUE ADD CONSTRAINT P_CHI_TIET_PHIEU_THUE PRIMARY KEY (MaChiTietPT, MaKhachHang)

--7 KHOA CHINH CHO BANG HOA_DON
ALTER TABLE HOA_DON ADD CONSTRAINT P_HOA_DON PRIMARY KEY (MaHoaDon)

--8 KHOA CHINH CHO BANG CHI_TIET_HOA_DON
ALTER TABLE CHI_TIET_HOA_DON ADD CONSTRAINT P_CHI_TIET_HOA_DON PRIMARY KEY (MaChiTietHD)

--10 KHOA CHINH CHO BANG BAOCAO_DOANHTHUTHEOLOAIPHONG
ALTER TABLE BAOCAO_DOANHTHUTHEOLOAIPHONG ADD CONSTRAINT P_BAOCAO_DOANHTHUTHEOLOAIPHONG PRIMARY KEY (MaBCDoanhThu)

--11 KHOA CHINH CHO BANG CHITIET_BAOCAODOANHTHU
ALTER TABLE CHITIET_BAOCAODOANHTHU ADD CONSTRAINT P_CHITIET_BAOCAODOANHTHU PRIMARY KEY (MaBCCTDoanhThu, MaLoaiPhong)

--12 KHOA CHINH CHO BANG BAOCAO_MATDOSUDUNGPHONG
ALTER TABLE BAOCAO_MATDOSUDUNGPHONG ADD CONSTRAINT P_BAOCAO_MATDOSUDUNGPHONG PRIMARY KEY (MaBCMatDoSuDung)

--13 KHOA CHINH CHO BANG CHITIET_BAOCAOMATDOSUDUNG
ALTER TABLE CHITIET_BAOCAOMATDOSUDUNG ADD CONSTRAINT P_CHITIET_BAOCAOMATDOSUDUNG PRIMARY KEY (MaBCCTMatDoSuDung, MaPhong)

--14 KHOA CHINH CHO BANG NGUOI_DUNG
ALTER TABLE NGUOI_DUNG ADD CONSTRAINT P_NGUOI_DUNG PRIMARY KEY (MaTaiKhoan)

--------------------------------------------KHOA NGOAI-----------------------------------------
--1 KHOA NGOAI CHO BANG KHACH_HANG
ALTER TABLE KHACH_HANG ADD CONSTRAINT F_KHACH_HANG FOREIGN KEY (MaLoaiKhach) REFERENCES LOAI_KHACH_HANG

--2 KHOA NGOAI CHO BANG PHONG
ALTER TABLE PHONG ADD CONSTRAINT F_PHONG FOREIGN KEY (MaLoaiPhong) REFERENCES LOAI_PHONG

--3 KHOA NGOAI CHO BANG PHIEU_THUE_PHONG
ALTER TABLE PHIEU_THUE_PHONG ADD CONSTRAINT F_PHIEU_THUE_PHONG FOREIGN KEY (MaPhong) REFERENCES PHONG

--4 KHOA NGOAI CHO BANG CHI_TIET_PHIEU_THUE
ALTER TABLE CHI_TIET_PHIEU_THUE ADD CONSTRAINT F_CHI_TIET_PHIEU_THUE_1 FOREIGN KEY (MaKhachHang) REFERENCES KHACH_HANG

ALTER TABLE CHI_TIET_PHIEU_THUE ADD CONSTRAINT F_CHI_TIET_PHIEU_THUE_2 FOREIGN KEY (MaPhieuThue) REFERENCES PHIEU_THUE_PHONG

--5 KHOA NGOAI CHO BANG CHI_TIET_HOA_DON
ALTER TABLE CHI_TIET_HOA_DON ADD CONSTRAINT F_CHI_TIET_HOA_DON_1 FOREIGN KEY (MaHoaDon) REFERENCES HOA_DON

ALTER TABLE CHI_TIET_HOA_DON ADD CONSTRAINT F_CHI_TIET_HOA_DON_2 FOREIGN KEY (MaPhong) REFERENCES PHONG

--6 KHOA NGOAI CHO BANG CHITIET_BAOCAODOANHTHU
ALTER TABLE CHITIET_BAOCAODOANHTHU ADD CONSTRAINT F_CHITIET_BAOCAODOANHTHU FOREIGN KEY (MaBCDoanhThu) REFERENCES BAOCAO_DOANHTHUTHEOLOAIPHONG

--7 KHOA NGOAI CHO BANG CHITIET_BAOCAOMATDOSUDUNG
ALTER TABLE CHITIET_BAOCAOMATDOSUDUNG ADD CONSTRAINT F_CHITIET_BAOCAOMATDOSUDUNG FOREIGN KEY (MaBCMatDoSuDung) REFERENCES BAOCAO_MATDOSUDUNGPHONG

GO
SET DATEFORMAT dmy;





GO
--THEM DU LIEU CHO BANG LOAI_KHACH_HANG
INSERT INTO LOAI_KHACH_HANG VALUES ('LK001', N'Nội địa', N'')
INSERT INTO LOAI_KHACH_HANG VALUES ('LK002', N'Nước ngoài', N'')

GO
--THEM DU LIEU CHO BANG KHACH_HANG
INSERT INTO KHACH_HANG VALUES (1, N'Phan Văn A', '275649386', N'Đồng Nai', 'LK001')
INSERT INTO KHACH_HANG VALUES (2, N'Lý Thị B', '234154687', N'Lâm Đồng', 'LK002')
INSERT INTO KHACH_HANG VALUES (3, N'Đào Văn C', '234987896', N'An Giang', 'LK001')

--INSERT INTO KHACH_HANG VALUES ('KH004', N'Trần Thị D', '214376778', N'Vũng Tàu', 'LK001')
--INSERT INTO KHACH_HANG VALUES ('KH005', N'Nguyễn Ngọc E', '212132435', N'Huế', 'LK002')
--INSERT INTO KHACH_HANG VALUES ('KH006', N'Phan Thị F', '277665876', N'Bình Dương', 'LK001')
--INSERT INTO KHACH_HANG VALUES ('KH007', N'Nguyễn Tiến G', '298445673', N'Long An', 'LK001')
--INSERT INTO KHACH_HANG VALUES ('KH008', N'Đoàn Huy H', '254365547', N'Bạc Liêu', 'LK002')

GO
--THEM DU LIEU CHO BANG LOAI_PHONG
INSERT INTO LOAI_PHONG VALUES ('LP001', N'A', 150000)
INSERT INTO LOAI_PHONG VALUES ('LP002', N'B', 170000)
INSERT INTO LOAI_PHONG VALUES ('LP003', N'C', 200000)

GO
--THEM DU LIEU CHO BANG PHONG
INSERT INTO PHONG VALUES (1, N'Trống', 'LP002', N'nhìn ra biển, giường đôi')
INSERT INTO PHONG VALUES (2, N'Đầy', 'LP003', N'giường đơn')
INSERT INTO PHONG VALUES (3, N'Trống', 'LP001', N'giường đôi')
INSERT INTO PHONG VALUES (4, N'Đầy', 'LP001', N'nhìn ra biển, giường đơn')
INSERT INTO PHONG VALUES (5, N'Đầy', 'LP003', N'nhìn ra biển, giường đơn')
INSERT INTO PHONG VALUES (6, N'Sửa chữa', 'LP002', N'giường đôi')

INSERT INTO PHONG VALUES (7, N'Trống', 'LP002', N'nhìn ra biển, giường đôi')
INSERT INTO PHONG VALUES (8, N'Trống', 'LP002', N'nhìn ra biển, giường đơn')
INSERT INTO PHONG VALUES (9, N'Trống', 'LP001', N'nhìn ra biển, giường đôi')
INSERT INTO PHONG VALUES (10, N'Trống', 'LP003', N'nhìn ra biển, giường đơn')
INSERT INTO PHONG VALUES (11, N'Trống', 'LP003', N'giường đơn')
INSERT INTO PHONG VALUES (12, N'Trống', 'LP002', N'giường đơn')
INSERT INTO PHONG VALUES (13, N'Sửa chữa', 'LP001', N'nhìn ra biển, giường đơn')
INSERT INTO PHONG VALUES (14, N'Trống', 'LP001', N'giường đôi')
INSERT INTO PHONG VALUES (15, N'Trống', 'LP002', N'nhìn ra biển, giường đôi')
INSERT INTO PHONG VALUES (16, N'Trống', 'LP003', N'nhìn ra biển, giường đơn')
INSERT INTO PHONG VALUES (17, N'Trống', 'LP002', N'giường đôi')
INSERT INTO PHONG VALUES (18, N'Trống', 'LP003', N'giường đơn')
INSERT INTO PHONG VALUES (19, N'Trống', 'LP001', N'giường đơn')
INSERT INTO PHONG VALUES (20, N'Trống', 'LP003', N'giường đơn')
INSERT INTO PHONG VALUES (21, N'Sửa chữa', 'LP003', N'giường đôi')
INSERT INTO PHONG VALUES (22, N'Trống', 'LP002', N'giường đôi')
INSERT INTO PHONG VALUES (23, N'Trống', 'LP001', N'nhìn ra biển, giường đôi')
INSERT INTO PHONG VALUES (24, N'Trống', 'LP001', N'nhìn ra biển, giường đơn')
INSERT INTO PHONG VALUES (25, N'Trống', 'LP001', N'giường đơn')
INSERT INTO PHONG VALUES (26, N'Trống', 'LP003', N'giường đơn')
INSERT INTO PHONG VALUES (27, N'Sửa chữa', 'LP003', N'giường đơn')
INSERT INTO PHONG VALUES (28, N'Trống', 'LP003', N'nhìn ra biển, giường đơn')
INSERT INTO PHONG VALUES (29, N'Trống', 'LP001', N'giường đôi')
INSERT INTO PHONG VALUES (30, N'Trống', 'LP002', N'nhìn ra biển, giường đôi')


GO
--THEM DU LIEU CHO BANG PHIEU_THUE_PHONG
INSERT INTO PHIEU_THUE_PHONG VALUES (1, '2013-12-23', 2)
INSERT INTO PHIEU_THUE_PHONG VALUES (2, '2013-12-14', 4)
INSERT INTO PHIEU_THUE_PHONG VALUES (3, '2013-12-9', 5)

GO
--THEM DU LIEU CHO BANG CHI_TIET_PHIEU_THUE
INSERT INTO CHI_TIET_PHIEU_THUE VALUES (1, 1, 1)
INSERT INTO CHI_TIET_PHIEU_THUE VALUES (2, 2, 2)
INSERT INTO CHI_TIET_PHIEU_THUE VALUES (3, 3, 3)

GO
----THEM DU LIEU CHO BANG HOA_DON
--INSERT INTO HOA_DON VALUES ('HD001', N'Phan Văn A', '')

--GO
----THEM DU LIEU CHO BANG CHI_TIET_HOA_DON
--INSERT INTO CHI_TIET_HOA_DON VALUES ('CTHD001', 'HD001', 10, '')

--THEM DU LIEU CHO BANG THAM_SO
INSERT INTO THAM_SO VALUES (3, 0.25, 1.5, 0, 3, 1)

--THEM DU LIEU CHO BANG NGUOI_DUNG
INSERT INTO NGUOI_DUNG VALUES (1, 'buiducquan', 'vVm/wmKXQdY=')
INSERT INTO NGUOI_DUNG VALUES (2, 'lequocoai', 'QuYB6ZMP4k4=')

--THEM DU LIEU CHO BANG DANH_MUC
INSERT INTO DANH_MUC VALUES ('LP001')
INSERT INTO DANH_MUC VALUES ('LP002')
INSERT INTO DANH_MUC VALUES ('LP003')

--STORED PROCEDURE
--1. Them khach hang
GO
IF OBJECT_ID ( 'dbo.spThemKhachHang', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spThemKhachHang;
GO
CREATE PROCEDURE spThemKhachHang
	@MaKH INT,
	@TenKH NVARCHAR(50),
	@CMND NVARCHAR(50),
	@DiaChi NVARCHAR(50),
	@MaLK NVARCHAR(10)
AS
	BEGIN TRAN
		BEGIN
			INSERT INTO KHACH_HANG VALUES (@MaKH, @TenKH, @CMND, @DiaChi, @MaLK)
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
--2. Them phieu thue phong
IF OBJECT_ID ( 'dbo.spThemPhieuThue', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spThemPhieuThue;
GO
CREATE PROCEDURE spThemPhieuThue
	@MaPT INT,
	@NgayThue DATE,
	@MaPhong INT
AS
	BEGIN TRAN
		BEGIN
			INSERT INTO PHIEU_THUE_PHONG VALUES (@MaPT, @NgayThue, @MaPhong)
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
--3. Them chi tiet phieu thue phong
IF OBJECT_ID ( 'dbo.spThemCTPhieuThue', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spThemCTPhieuThue;
GO
CREATE PROCEDURE spThemCTPhieuThue
	@MaCTPT INT,
	@MaKH INT,
	@MaPT INT
AS
	BEGIN TRAN
		BEGIN
			INSERT INTO CHI_TIET_PHIEU_THUE VALUES (@MaCTPT, @MaKH, @MaPT)
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
--4. Cap nhat tinh trang phong
IF OBJECT_ID ( 'dbo.spCapNhatTinhTrangPhong', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spCapNhatTinhTrangPhong;
GO
CREATE PROCEDURE spCapNhatTinhTrangPhong
	@MaPhong INT
AS
	BEGIN TRAN
		BEGIN
			UPDATE PHONG SET TinhTrang = N'Đầy' WHERE MaPhong = @MaPhong
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

--5. Them moi mot phong
IF OBJECT_ID ( 'dbo.spThemPhong', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spThemPhong;
GO
CREATE PROCEDURE spThemPhong
	@TinhTrang NVARCHAR(10),
	@MaLoaiPhong NVARCHAR(10),
	@GhiChu NTEXT
AS
	BEGIN TRAN
		BEGIN
			DECLARE @MaPhong INT
			SET @MaPhong = 1
			WHILE((SELECT COUNT(*) FROM PHONG WHERE MaPhong = @MaPhong) != 0)
			BEGIN
				SET @MaPhong = @MaPhong + 1
			END
			INSERT INTO PHONG VALUES(@MaPhong, @TinhTrang, @MaLoaiPhong, @GhiChu)
		END
	COMMIT TRAN
Error:

--execute spThemPhong N'Trống', 'LP001', N'giường đôi'
GO
--6. Sua thong tin mot phong
IF OBJECT_ID ( 'dbo.spSuaThongTinPhong', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spSuaThongTinPhong;
GO
CREATE PROCEDURE spSuaThongTinPhong
	@MaPhong INT,
	@TinhTrang NVARCHAR(10),
	@MaLoaiPhong NVARCHAR(10),
	@GhiChu NTEXT
AS
	BEGIN TRAN
		BEGIN
			UPDATE PHONG SET TinhTrang = @TinhTrang, MaLoaiPhong = @MaLoaiPhong, GhiChu = @GhiChu WHERE MaPhong = @MaPhong
		END
	COMMIT TRAN
Error:

--execute spSuaThongTinPhong 31, N'Trống', 'LP001', N'nhìn ra biển, giường đôi'

GO
--7. Sua thong tin mot phong
IF OBJECT_ID ( 'dbo.spXoaPhong', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spXoaPhong;
GO
CREATE PROCEDURE spXoaPhong
	@MaPhong INT
AS
	BEGIN TRAN
		BEGIN
			DELETE FROM PHONG WHERE MaPhong = @MaPhong
		END
	COMMIT TRAN
Error:

--execute spXoaPhong 31

--Thu cau truy van
--Lay so luong loai khach hang
select COUNT(*)
from PHIEU_THUE_PHONG as pt, CHI_TIET_PHIEU_THUE as ct, KHACH_HANG as kh
where pt.MaPhieuThue = ct.MaPhieuThue and kh.MaKhachHang = ct.MaKhachHang
		and pt.MaPhong = 29 and kh.MaLoaiKhach = 'LK001'
		
select NgayBatDauThue, DonGia
from PHIEU_THUE_PHONG as pt, PHONG as p, LOAI_PHONG as lp
where p.MaPhong = pt.MaPhong and p.MaLoaiPhong = lp.MaLoaiPhong and pt.MaPhong = 32

GO
IF OBJECT_ID ( 'dbo.spTruNgayThangNam', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spTruNgayThangNam;
GO
CREATE PROCEDURE spTruNgayThangNam
	@NgayBDThue DATE
AS
BEGIN
	DECLARE @NgayHienTai DATE
	DECLARE @SLNgayThue INT
	SET @NgayHienTai = GETDATE()
	SET @SLNgayThue = DATEDIFF (DAY, @NgayBDThue, @NgayHienTai)
	
	UPDATE THAM_SO SET SoNgayThue = @SLNgayThue
END

--EXECUTE spTruNgayThangNam '2013-12-29'

--select kh.MaKhachHang, kh.TenKhachHang, kh.CMND, kh.DiaChi, kh.MaLoaiKhach
--from KHACH_HANG as kh, PHIEU_THUE_PHONG as pt, CHI_TIET_PHIEU_THUE as ct
--where kh.MaKhachHang = ct.MaKhachHang and pt.MaPhieuThue = ct.MaPhieuThue
--		and pt.MaPhong = 29

--8. Them moi hoa don
GO
IF OBJECT_ID ( 'dbo.spThemHoaDon', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spThemHoaDon;
GO
CREATE PROCEDURE spThemHoaDon
	@MaHoaDon INT,
	@TenKhachHang NVARCHAR(50),
	@TriGia MONEY
AS
	BEGIN TRAN
		BEGIN
			INSERT INTO HOA_DON VALUES(@MaHoaDon, @TenKhachHang, @TriGia)
		END
	COMMIT TRAN
Error:

--9. Them moi chi tiet hoa don
GO
IF OBJECT_ID ( 'dbo.spThemChiTietHD', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spThemChiTietHD;
GO
CREATE PROCEDURE spThemChiTietHD
	@MaHoaDon INT,
	@SoNgayThue INT,
	@DonGia MONEY,
	@ThanhTien MONEY,
	@NgayThanhToan DATE,
	@MaPhong INT
AS
	BEGIN TRAN
		BEGIN
			DECLARE @MaChiTietHD INT
			SET @MaChiTietHD = 1
			WHILE((SELECT COUNT(*) FROM CHI_TIET_HOA_DON WHERE MaChiTietHD = @MaChiTietHD) != 0)
				BEGIN
					SET @MaChiTietHD = @MaChiTietHD + 1
				END
			INSERT INTO CHI_TIET_HOA_DON VALUES(@MaChiTietHD, @MaHoaDon, @SoNgayThue, @DonGia, @ThanhTien, @NgayThanhToan, @MaPhong)
		END
	COMMIT TRAN
Error:


--10. Xoa khach hang
GO
IF OBJECT_ID ( 'dbo.spXoaKhachHang', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spXoaKhachHang;
GO
CREATE PROCEDURE spXoaKhachHang
	@MaKhacHang INT
AS
	BEGIN TRAN
		BEGIN
			DELETE FROM KHACH_HANG WHERE MaKhachHang = @MaKhacHang
		END
	COMMIT TRAN
Error:

--execute spXoaKhachHang 15

--11. Xoa chi tiet phieu thue
GO
IF OBJECT_ID ( 'dbo.spXoaCTPhieuThue', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spXoaCTPhieuThue;
GO
CREATE PROCEDURE spXoaCTPhieuThue
	@MaPhieuThue INT
AS
	BEGIN TRAN
		BEGIN
			DELETE FROM CHI_TIET_PHIEU_THUE WHERE MaPhieuThue = @MaPhieuThue
		END
	COMMIT TRAN
Error:

--12. Xoa phieu thue
GO
IF OBJECT_ID ( 'dbo.spXoaPhieuThue', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spXoaPhieuThue;
GO
CREATE PROCEDURE spXoaPhieuThue
	@MaPhieuThue INT
AS
	BEGIN TRAN
		BEGIN
			DELETE FROM PHIEU_THUE_PHONG WHERE MaPhieuThue = @MaPhieuThue
		END
	COMMIT TRAN
Error:

GO
--13. Thiet lap lai tinh trang phong ban dau
IF OBJECT_ID ( 'dbo.spThietLapTTrangPhongBanDau', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spThietLapTTrangPhongBanDau;
GO
CREATE PROCEDURE spThietLapTTrangPhongBanDau
	@MaPhong INT
AS
	BEGIN TRAN
		BEGIN
			UPDATE PHONG SET TinhTrang = N'Trống' WHERE MaPhong = @MaPhong
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
--14. Cap nhat tham so so luong khach toi da
IF OBJECT_ID ( 'dbo.spCapNhatTSSoKhachToiDa', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spCapNhatTSSoKhachToiDa;
GO
CREATE PROCEDURE spCapNhatTSSoKhachToiDa
	@SoKhachToiDa INT
AS
	BEGIN TRAN
		BEGIN
			UPDATE THAM_SO SET SoKhachToiDa = @SoKhachToiDa
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
--15. Cap nhat tham so he so
IF OBJECT_ID ( 'dbo.spCapNhatTSHeSo', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spCapNhatTSHeSo;
GO
CREATE PROCEDURE spCapNhatTSHeSo
	@HeSo FLOAT
AS
	BEGIN TRAN
		BEGIN
			UPDATE THAM_SO SET HeSo = @HeSo
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
--16. Cap nhat tham so phu thu
IF OBJECT_ID ( 'dbo.spCapNhatTSPhuThu', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spCapNhatTSPhuThu;
GO
CREATE PROCEDURE spCapNhatTSPhuThu
	@PhuThu FLOAT
AS
	BEGIN TRAN
		BEGIN
			UPDATE THAM_SO SET PhuThu = @PhuThu
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
--17. Tong doanh thu theo loai phong cua tat ca cac thang
IF OBJECT_ID ( 'dbo.spDoanhThuTheoLoaiPhong', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spDoanhThuTheoLoaiPhong;
GO
CREATE PROCEDURE spDoanhThuTheoLoaiPhong
AS
BEGIN TRAN
		BEGIN
			SELECT p.MaLoaiPhong, SUM(hd.TriGia) AS DoanhThu
			FROM PHONG AS p, HOA_DON AS hd, CHI_TIET_HOA_DON AS ct
			WHERE p.MaPhong = ct.MaPhong and ct.MaHoaDon = hd.MaHoaDon
			GROUP BY p.MaLoaiPhong
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
--18. Tong doanh thu theo loai phong theo thang nam da chon
IF OBJECT_ID ( 'dbo.spDoanhThuTheoLoaiPhongTheoThang', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spDoanhThuTheoLoaiPhongTheoThang;
GO
CREATE PROCEDURE spDoanhThuTheoLoaiPhongTheoThang
	@Thang INT,
	@Nam INT
AS
BEGIN TRAN
		BEGIN
			SELECT p.MaLoaiPhong, SUM(hd.TriGia) AS DoanhThu
			FROM PHONG AS p, HOA_DON AS hd, CHI_TIET_HOA_DON AS ct
			WHERE p.MaPhong = ct.MaPhong AND ct.MaHoaDon = hd.MaHoaDon
			AND MONTH(ct.NgayThanhToan) = @Thang AND YEAR(ct.NgayThanhToan) = @Nam
			GROUP BY p.MaLoaiPhong
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
--19. Them bao cao doanh thu
IF OBJECT_ID ( 'dbo.spThemBCDoanhThuTheoLoaiPhongTheoThang', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spThemBCDoanhThuTheoLoaiPhongTheoThang;
GO
CREATE PROCEDURE spThemBCDoanhThuTheoLoaiPhongTheoThang
	@MaBCDoanhThu INT,
	@Thang INT
AS
BEGIN TRAN
		BEGIN
			INSERT INTO BAOCAO_DOANHTHUTHEOLOAIPHONG VALUES (@MaBCDoanhThu, @Thang)
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
--20. Them chi tiet bao cao doanh thu
IF OBJECT_ID ( 'dbo.spThemBCCTDTTheoLoaiPhongTheoThang', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spThemBCCTDTTheoLoaiPhongTheoThang;
GO
CREATE PROCEDURE spThemBCCTDTTheoLoaiPhongTheoThang
	@MaBCCTDoanhThu INT,
	@MaLoaiPhong NVARCHAR(10),
	@MaBCDoanhThu INT,
	@DoanhThuThang MONEY,
	@TiLe CHAR(10)
AS
BEGIN TRAN
		BEGIN
			INSERT INTO CHITIET_BAOCAODOANHTHU VALUES (@MaBCCTDoanhThu, @MaLoaiPhong, @MaBCDoanhThu, @DoanhThuThang, @TiLe)
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
--21. Them bao cao mat do
IF OBJECT_ID ( 'dbo.spThemBCMatDoSuDungPhongTheoThang', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spThemBCMatDoSuDungPhongTheoThang;
GO
CREATE PROCEDURE spThemBCMatDoSuDungPhongTheoThang
	@MaBCCTMatDo INT,
	@Thang INT
AS
BEGIN TRAN
		BEGIN
			INSERT INTO BAOCAO_MATDOSUDUNGPHONG VALUES (@MaBCCTMatDo, @Thang)
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
--22. Them chi tiet bao cao mat do
IF OBJECT_ID ( 'dbo.spThemBCCTMDTheoPhongTheoThang', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spThemBCCTMDTheoPhongTheoThang;
GO
CREATE PROCEDURE spThemBCCTMDTheoPhongTheoThang
	@MaBCCTMatDo INT,
	@MaPhong NVARCHAR(10),
	@MaBCMatDo INT,
	@SoNgayThue INT,
	@TiLe CHAR(10)
AS
BEGIN TRAN
		BEGIN
			INSERT INTO CHITIET_BAOCAOMATDOSUDUNG VALUES (@MaBCCTMatDo, @MaPhong, @MaBCMatDo, @SoNgayThue, @TiLe)
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
--23. Them loai phong
IF OBJECT_ID ( 'dbo.spThemLoaiPhong', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spThemLoaiPhong;
GO
CREATE PROCEDURE spThemLoaiPhong
	@MaLP NVARCHAR(10),
	@TenLP NVARCHAR(50),
	@DonGia MONEY
AS
BEGIN TRAN
		BEGIN
			INSERT INTO LOAI_PHONG VALUES (@MaLP, @TenLP, @DonGia)
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
--24. Sua thong tin loai phong
IF OBJECT_ID ( 'dbo.spSuaTTLoaiPhong', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spSuaTTLoaiPhong;
GO
CREATE PROCEDURE spSuaTTLoaiPhong
	@MaLP NVARCHAR(10),
	@TenLP NVARCHAR(50),
	@DonGia MONEY
AS
BEGIN TRAN
		BEGIN
			UPDATE LOAI_PHONG SET TenLoaiPhong = @TenLP, DonGia = @DonGia WHERE MaLoaiPhong = @MaLP
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error:

GO
--24. Xoa loai phong
IF OBJECT_ID ( 'dbo.spXoaLoaiPhong', 'P' ) IS NOT NULL 
		DROP PROCEDURE dbo.spXoaLoaiPhong;
GO
CREATE PROCEDURE spXoaLoaiPhong
	@MaLP NVARCHAR(10)
AS
BEGIN TRAN
		BEGIN
			DELETE FROM PHONG WHERE MaLoaiPhong = @MaLP
			DELETE FROM LOAI_PHONG WHERE MaLoaiPhong = @MaLP
			IF @@ERROR<>0
				BEGIN
					  IF @@TRANCOUNT<>0
						ROLLBACK TRAN
					  GOTO Error
				END
		END
	COMMIT TRAN
Error: