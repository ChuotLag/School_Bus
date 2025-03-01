USE QLXEBUS01
GO
------------------
CREATE PROCEDURE LayDanhSachHSTheoDD
    @DiemDung_ID VARCHAR(20)
AS
BEGIN
    SELECT HocSinh.HoTenHS, HocSinh.HocSinh_ID
    FROM ChiTietHocSinhDiemDung
    JOIN HocSinh ON ChiTietHocSinhDiemDung.HocSinh_ID = HocSinh.HocSinh_ID
    WHERE ChiTietHocSinhDiemDung.DiemDung_ID = @DiemDung_ID
END


-----------------------------------------------------------------------------------------------
CREATE PROCEDURE GetAllHocSinhByTaiXe
    @TaiKhoan_ID VARCHAR(20)
AS
BEGIN
    DECLARE @Bus_ID VARCHAR(20);
    SELECT @Bus_ID = Bus_ID
    FROM XeBus
    WHERE TaiXe_ID = @TaiKhoan_ID;
    IF @Bus_ID IS NULL
    BEGIN
        PRINT 'Không tìm thấy chuyến xe của tài xế này.';
        RETURN;
    END
    SELECT DISTINCT 
        hs.HocSinh_ID,
        hs.HoTenHS,
        hs.NgaySinh,
        hs.DiaChi,
        lop.TenLop AS LopHoc
    FROM 
        ChiTietDanhSachHocSinh ctds
    JOIN 
        HocSinh hs ON ctds.HocSinh_ID = hs.HocSinh_ID
    JOIN 
        Lop lop ON hs.Lop_ID = lop.Lop_ID
    WHERE 
        ctds.Bus_ID = @Bus_ID;
END;

-----------------------------------------------------------------------------------------------
CREATE PROCEDURE GetHocSinhByDiemDungAndTaiXe
@TaiKhoan_ID VARCHAR(20),
@DiemDung_ID VARCHAR(20)   
AS
BEGIN
    DECLARE @Bus_ID VARCHAR(20);
    SELECT @Bus_ID = Bus_ID
    FROM XeBus
    WHERE TaiXe_ID = @TaiKhoan_ID;
    SELECT DISTINCT 
        hs.HocSinh_ID,
        hs.HoTenHS,
        dd.ViTri AS DiemDung
    FROM 
        ChiTietHocSinhDiemDung ct_hsdd
    JOIN 
        HocSinh hs ON ct_hsdd.HocSinh_ID = hs.HocSinh_ID
    JOIN 
        DiemDung dd ON ct_hsdd.DiemDung_ID = dd.DiemDung_ID
    JOIN 
        ChiTietDanhSachHocSinh ctds ON hs.HocSinh_ID = ctds.HocSinh_ID
    WHERE 
        ctds.Bus_ID = @Bus_ID AND ct_hsdd.DiemDung_ID = @DiemDung_ID;
END;

EXEC GetHocSinhByDiemDungAndTaiXe 
    @TaiKhoan_ID = 'vananpro', 
    @DiemDung_ID = 'DD002';

-----------------------------------------------------------------------------------------------
CREATE PROCEDURE InsertDiemDanh
    @DiemDanh_ID VARCHAR(20),
    @Bus_ID VARCHAR(20),
    @NgayDiemDanh DATE,
    @TrangThai NVARCHAR(50)
AS
BEGIN
    INSERT INTO DiemDanh (DiemDanh_ID, Bus_ID, NgayDiemDanh, TrangThai)
    VALUES (@DiemDanh_ID, @Bus_ID, @NgayDiemDanh, @TrangThai)
END
-----------------------------------------------------------------------------------------------
CREATE PROCEDURE UpdateDiemDanhTrangThai
    @DiemDanh_ID VARCHAR(20),
    @TrangThai NVARCHAR(50)
AS
BEGIN
    UPDATE DiemDanh
    SET TrangThai = @TrangThai
    WHERE DiemDanh_ID = @DiemDanh_ID
END
-----------------------------------------------------------------------------------------------

CREATE PROCEDURE DeleteDiemDanh
    @DiemDanh_ID VARCHAR(20)
AS
BEGIN
    DELETE FROM DiemDanh
    WHERE DiemDanh_ID = @DiemDanh_ID;
END

-----------------------------------------------------------------------------------------------
CREATE PROCEDURE InsertChiTietDiemDanhDi
    @CTDDD_ID VARCHAR(20),
    @DiemDanh_ID VARCHAR(20),
    @HocSinh_ID VARCHAR(20),
    @DiemLenXe NVARCHAR(100),
    @DiemXuongXe NVARCHAR(100),
    @GioLenXe TIME,
    @GioXuongXe TIME,
    @TrangThai NVARCHAR(50)
AS
BEGIN
    INSERT INTO ChiTietDiemDanhDi (CTDDD_ID, DiemDanh_ID, HocSinh_ID, DiemLenXe, DiemXuongXe, GioLenXe, GioXuongXe, TrangThai)
    VALUES (@CTDDD_ID, @DiemDanh_ID, @HocSinh_ID, @DiemLenXe, @DiemXuongXe, @GioLenXe, @GioXuongXe, @TrangThai)
END
-----------------------------------------------------------------------------------------------
CREATE PROCEDURE UpdateChiTietDiemDanhDi
    @CTDDD_ID VARCHAR(20),
    @DiemXuongXe NVARCHAR(100),
    @GioXuongXe TIME
AS
BEGIN
    UPDATE ChiTietDiemDanhDi
    SET
        DiemXuongXe = @DiemXuongXe,
        GioXuongXe = @GioXuongXe
    WHERE CTDDD_ID = @CTDDD_ID;
    IF @@ROWCOUNT = 0
    BEGIN
        RAISERROR('Không tìm thấy bản ghi với CTDDD_ID = %s', 16, 1, @CTDDD_ID);
    END
END
-----------------------------------------------------------------------------------------------
CREATE PROCEDURE InsertChiTietDiemDanhVe
    @CTDDV_ID VARCHAR(20),
    @DiemDanh_ID VARCHAR(20),
    @HocSinh_ID VARCHAR(20),
    @DiemLenXe NVARCHAR(100),
    @DiemXuongXe NVARCHAR(100),
    @GioLenXe TIME,
    @GioXuongXe TIME,
    @TrangThai NVARCHAR(50)
AS
BEGIN
    INSERT INTO ChiTietDiemDanhVe (CTDDV_ID, DiemDanh_ID, HocSinh_ID, DiemLenXe, DiemXuongXe, GioLenXe, GioXuongXe, TrangThai)
    VALUES (@CTDDV_ID, @DiemDanh_ID, @HocSinh_ID, @DiemLenXe, @DiemXuongXe, @GioLenXe, @GioXuongXe, @TrangThai)
END
-----------------------------------------------------------------------------------------------
CREATE PROCEDURE UpdateChiTietDiemDanhVe
    @CTDDV_ID VARCHAR(20),
    @DiemXuongXe NVARCHAR(100),
    @GioXuongXe TIME
AS
BEGIN
    UPDATE ChiTietDiemDanhVe
    SET
        DiemXuongXe = @DiemXuongXe,
        GioXuongXe = @GioXuongXe
    WHERE CTDDV_ID = @CTDDV_ID;
    IF @@ROWCOUNT = 0
    BEGIN
        RAISERROR('Không tìm thấy bản ghi với CTDDD_ID = %s', 16, 1, @CTDDV_ID);
    END
END
-----------------------------------------------------------------------------------------------
CREATE PROCEDURE DeleteChiTietDiemDanhDi
    @CTDDD_ID VARCHAR(20)
AS
BEGIN
    DELETE FROM ChiTietDiemDanhDi
    WHERE CTDDD_ID = @CTDDD_ID
END
-----------------------------------------------------------------------------------------------
CREATE PROCEDURE DeleteChiTietDiemDanhVe
    @CTDDV_ID VARCHAR(20)
AS
BEGIN
    DELETE FROM ChiTietDiemDanhVe
    WHERE CTDDV_ID = @CTDDV_ID
END
-----------------------------------------------------------------------------------------------
CREATE PROCEDURE XuLyVangDi
    @CTDDD_ID VARCHAR(20),
    @DiemDanh_ID VARCHAR(20),
    @HocSinh_ID VARCHAR(20),
    @TrangThai NVARCHAR(50)
AS
BEGIN
    INSERT INTO ChiTietDiemDanhDi (CTDDD_ID, DiemDanh_ID, HocSinh_ID, DiemLenXe, DiemXuongXe, GioLenXe, GioXuongXe, TrangThai)
    VALUES (@CTDDD_ID, @DiemDanh_ID, @HocSinh_ID, NULL, NULL, NULL, NULL, @TrangThai)
END
-----------------------------------------------------------------------------------------------
CREATE PROCEDURE XuLyVangVe
    @CTDDV_ID VARCHAR(20),
    @DiemDanh_ID VARCHAR(20),
    @HocSinh_ID VARCHAR(20),
    @TrangThai NVARCHAR(50)
AS
BEGIN
    INSERT INTO ChiTietDiemDanhVe (CTDDV_ID, DiemDanh_ID, HocSinh_ID, DiemLenXe, DiemXuongXe, GioLenXe, GioXuongXe, TrangThai)
    VALUES (@CTDDV_ID, @DiemDanh_ID, @HocSinh_ID, NULL, NULL, NULL, NULL, @TrangThai)
END
-----------------------------------------------------------------------------------------------
CREATE PROCEDURE GetHocSinhByTaiXe
    @TaiXe_ID VARCHAR(20)
AS
BEGIN
    SELECT hs.HocSinh_ID, hs.HoTenHS
    FROM ChiTietDanhSachHocSinh ctdshs
    JOIN XeBus xb ON ctdshs.Bus_ID = xb.Bus_ID
    JOIN HocSinh hs ON ctdshs.HocSinh_ID = hs.HocSinh_ID
    WHERE xb.TaiXe_ID = @TaiXe_ID
END
-----------------------------------------------------------------------------------------------
CREATE PROCEDURE GetChiTietDiemDanhVe
    @DiemDanh_ID VARCHAR(20)
AS
BEGIN
    SELECT 
        cdv.DiemDanh_ID,
		cdv.CTDDV_ID,
        cdv.HocSinh_ID,
        cdv.DiemLenXe,
        cdv.DiemXuongXe,
        cdv.GioLenXe,
        cdv.GioXuongXe,
		cdv.TrangThai
    FROM 
        ChiTietDiemDanhVe cdv
    INNER JOIN 
        DiemDanh dd ON cdv.DiemDanh_ID = dd.DiemDanh_ID
    WHERE 
        dd.DiemDanh_ID = @DiemDanh_ID
END
-----------------------------------------------------------------------------------------------
CREATE PROCEDURE GetChiTietDiemDanhDi
    @DiemDanh_ID VARCHAR(20)
AS
BEGIN
    SELECT 
        cdd.DiemDanh_ID,
		cdd.CTDDD_ID,
        cdd.HocSinh_ID,
        cdd.DiemLenXe,
        cdd.DiemXuongXe,
        cdd.GioLenXe,
        cdd.GioXuongXe,
		cdd.TrangThai
    FROM 
        ChiTietDiemDanhDi cdd
    INNER JOIN 
        DiemDanh dd ON cdd.DiemDanh_ID = dd.DiemDanh_ID
    WHERE 
        dd.DiemDanh_ID = @DiemDanh_ID
END

-----------------------------------------------------------------------------------------------
CREATE PROCEDURE GetLoTrinhByTaiXeID
    @TaiXe_ID VARCHAR(20)
AS
BEGIN
    -- Lấy Bus_ID từ XeBus dựa trên TaiXe_ID
    DECLARE @Bus_ID VARCHAR(20);
    
    SELECT @Bus_ID = Bus_ID
    FROM XeBus
    WHERE TaiXe_ID = @TaiXe_ID;

    -- Lấy LoTrinh_ID từ LoTrinh dựa trên Bus_ID
    DECLARE @LoTrinh_ID VARCHAR(20);
    
    SELECT @LoTrinh_ID = LoTrinh_ID
    FROM LoTrinh
    WHERE Bus_ID = @Bus_ID;

    -- Lấy các vị trí của lộ trình từ ChiTietLoTrinhXe và DiemDung
    SELECT STRING_AGG(dd.ViTri, ' - ') AS LoTrinhDuongDi
    FROM ChiTietLoTrinhXe ctl
    JOIN DiemDung dd ON ctl.DiemDung_ID = dd.DiemDung_ID
    WHERE ctl.LoTrinh_ID = @LoTrinh_ID;
END;

DROP PROC GetLoTrinhByTaiXeID

EXEC GetLoTrinhByTaiXeID 'hieupham'



-----------------------------------------------------------------------------------------------

CREATE PROCEDURE GetTTLoTrinhByTaiXeID
    @TaiXe_ID VARCHAR(20)
AS
BEGIN
    -- Lấy Bus_ID từ XeBus dựa trên TaiXe_ID
    DECLARE @Bus_ID VARCHAR(20);
    
    SELECT @Bus_ID = Bus_ID
    FROM XeBus
    WHERE TaiXe_ID = @TaiXe_ID;

    -- Lấy LoTrinh_ID từ LoTrinh dựa trên Bus_ID
    DECLARE @LoTrinh_ID VARCHAR(20);
    
    SELECT @LoTrinh_ID = LoTrinh_ID
    FROM LoTrinh
    WHERE Bus_ID = @Bus_ID;

    -- Lấy các vị trí của lộ trình từ ChiTietLoTrinhXe và DiemDung
    SELECT dd.ViTri
    FROM ChiTietLoTrinhXe ctl
    JOIN DiemDung dd ON ctl.DiemDung_ID = dd.DiemDung_ID
    WHERE ctl.LoTrinh_ID = @LoTrinh_ID
    ORDER BY ctl.ThuTu;
END;
EXEC GetTTLoTrinhByTaiXeID 'hieupham'
---------------------------------------------------------
CREATE PROCEDURE GetDiemDungByTaiKhoanID
    @TaiKhoan_ID VARCHAR(20)
AS
BEGIN
    SET NOCOUNT ON;
    DECLARE @Bus_ID VARCHAR(20);

    SELECT @Bus_ID = Bus_ID
    FROM XeBus
    WHERE TaiXe_ID = @TaiKhoan_ID;
    IF @Bus_ID IS NULL
    BEGIN
        RAISERROR('Không tìm thấy xe bus cho tài xế này.', 16, 1);
        RETURN;
    END
    DECLARE @LoTrinh_ID VARCHAR(20);
    SELECT @LoTrinh_ID = LoTrinh_ID
    FROM LoTrinh
    WHERE Bus_ID = @Bus_ID;
    IF @LoTrinh_ID IS NULL
    BEGIN
        RAISERROR('Không tìm thấy lộ trình cho xe bus này.', 16, 1);
        RETURN;
    END
    SELECT 
        dd.DiemDung_ID,
        dd.ViTri AS TenDiemDung
    FROM 
        ChiTietLoTrinhXe ctl
    JOIN 
        DiemDung dd ON ctl.DiemDung_ID = dd.DiemDung_ID
    WHERE 
        ctl.LoTrinh_ID = @LoTrinh_ID
    ORDER BY 
        ctl.ThuTu;
END;

EXEC GetDiemDungByTaiKhoanID @TaiKhoan_ID = 'hieupham';


-----------------------------------------------------------------


CREATE PROCEDURE AddLoTrinh
    @LoTrinh_ID VARCHAR(20),
    @Bus_ID VARCHAR(20),
    @GioKhoiHanh TIME,
    @GioKetThuc TIME
AS
BEGIN
    INSERT INTO LoTrinh (LoTrinh_ID, Bus_ID, GioKhoiHanh, GioKetThuc)
    VALUES (@LoTrinh_ID, @Bus_ID, @GioKhoiHanh, @GioKetThuc);
END;


CREATE PROCEDURE UpdateLoTrinh
    @LoTrinh_ID VARCHAR(20),
    @Bus_ID VARCHAR(20),
    @GioKhoiHanh TIME,
    @GioKetThuc TIME
AS
BEGIN
    UPDATE LoTrinh
    SET Bus_ID = @Bus_ID, GioKhoiHanh = @GioKhoiHanh, GioKetThuc = @GioKetThuc
    WHERE LoTrinh_ID = @LoTrinh_ID;
END;

CREATE PROCEDURE DeleteLoTrinh
    @LoTrinh_ID VARCHAR(20)
AS
BEGIN
    DELETE FROM LoTrinh WHERE LoTrinh_ID = @LoTrinh_ID;
END;


CREATE PROCEDURE AddChiTietLoTrinhXe
    @CTLT_ID VARCHAR(20),
    @LoTrinh_ID VARCHAR(20),
    @DiemDung_ID VARCHAR(20),
    @ThuTu INT,
    @ThoiGianDung TIME
AS
BEGIN
    INSERT INTO ChiTietLoTrinhXe (CTLT_ID, LoTrinh_ID, DiemDung_ID, ThuTu, ThoiGianDung)
    VALUES (@CTLT_ID, @LoTrinh_ID, @DiemDung_ID, @ThuTu, @ThoiGianDung);
END;


CREATE PROCEDURE UpdateChiTietLoTrinhXe
    @CTLT_ID VARCHAR(20),
    @LoTrinh_ID VARCHAR(20),
    @DiemDung_ID VARCHAR(20),
    @ThuTu INT,
    @ThoiGianDung TIME
AS
BEGIN
    UPDATE ChiTietLoTrinhXe
    SET 
        LoTrinh_ID = @LoTrinh_ID,
        DiemDung_ID = @DiemDung_ID,
        ThuTu = @ThuTu,
        ThoiGianDung = @ThoiGianDung
    WHERE CTLT_ID = @CTLT_ID;
END;

CREATE PROCEDURE DeleteChiTietLoTrinhXe
    @CTLT_ID VARCHAR(20)
AS
BEGIN
    DELETE FROM ChiTietLoTrinhXe
    WHERE CTLT_ID = @CTLT_ID;
END;

CREATE PROCEDURE [dbo].[GetDiemDanhByTaiKhoanID]
    @TaiKhoan_ID VARCHAR(20)
AS
BEGIN
    SELECT 
        DiemDanhTX_ID, 
        TaiXe.TaiKhoan_ID, 
        TaiXe.HoTenTX,         -- Tên của tài xế
        SoXeBus, 
        Ngay, 
        CaLamTaiXe.CaLam, 
        DiemDanhTaiXe.TrangThai
    FROM 
        DiemDanhTaiXe
    JOIN 
        TaiXe ON DiemDanhTaiXe.TaiKhoan_ID = TaiXe.TaiKhoan_ID
    JOIN 
        CaLamTaiXe ON DiemDanhTaiXe.CaLam_ID = CaLamTaiXe.CaLam_ID
    WHERE 
        TaiXe.TaiKhoan_ID = @TaiKhoan_ID;
END
-------------------------------------------------
CREATE PROCEDURE [dbo].[LuuDiemDanhTaiXe]
    @DiemDanhTX_ID VARCHAR(20),  -- Mã điểm danh tài xế
    @TaiKhoan_ID VARCHAR(20),
    @SoXeBus VARCHAR(20),
    @Ngay DATE,
    @CaLam_ID VARCHAR(20),
    @TrangThai NVARCHAR(50)
AS
BEGIN
    -- Chèn dữ liệu vào bảng DiemDanhTaiXe với việc bao gồm mã điểm danh
    INSERT INTO DiemDanhTaiXe (DiemDanhTX_ID, TaiKhoan_ID, SoXeBus, Ngay, CaLam_ID, TrangThai)
    VALUES (@DiemDanhTX_ID, @TaiKhoan_ID, @SoXeBus, @Ngay, @CaLam_ID, @TrangThai);
END
---------------------------------------------

CREATE PROCEDURE [dbo].[TaiXe_TinhTongCaLamTrongThang]
    @Thang INT, -- Tháng cần xem
    @Nam INT,   -- Năm cần xem
    @TaiKhoan_ID NVARCHAR(50) -- Mã tài khoản tài xế
AS
BEGIN
    SET NOCOUNT ON;

    WITH TongCaLam AS (
        SELECT 
            t.TaiKhoan_ID,
            t.HoTenTX,
            SUM(
                CASE
                    WHEN d.CaLam_ID IN ('CL001', 'CL002') THEN 1
                    WHEN d.CaLam_ID = 'CL003' THEN 2
                    ELSE 0
                END
            ) AS TongSoCaLamThang,
            CASE 
                WHEN SUM(
                         CASE
                             WHEN d.CaLam_ID IN ('CL001', 'CL002') THEN 1
                             WHEN d.CaLam_ID = 'CL003' THEN 2
                             ELSE 0
                         END
                     ) < 22 
                THEN CONCAT(N'Đi làm thiếu ', 
                            22 - SUM(
                                      CASE
                                          WHEN d.CaLam_ID IN ('CL001', 'CL002') THEN 1
                                          WHEN d.CaLam_ID = 'CL003' THEN 2
                                          ELSE 0
                                      END
                                  ), ' ngày.')
                WHEN SUM(
                         CASE
                             WHEN d.CaLam_ID IN ('CL001', 'CL002') THEN 1
                             WHEN d.CaLam_ID = 'CL003' THEN 2
                             ELSE 0
                         END
                     ) = 22 
                THEN N'Đi làm đủ.'
                ELSE CONCAT(N'Đã làm 22 ca và dư ', 
                            SUM(
                                CASE
                                    WHEN d.CaLam_ID IN ('CL001', 'CL002') THEN 1
                                    WHEN d.CaLam_ID = 'CL003' THEN 2
                                    ELSE 0
                                END
                            ) - 22, ' ca.')
            END AS GhiChu
        FROM 
            DiemDanhTaiXe d
        JOIN 
            TaiXe t ON d.TaiKhoan_ID = t.TaiKhoan_ID
        WHERE 
            d.TaiKhoan_ID = @TaiKhoan_ID
            AND MONTH(d.Ngay) = @Thang
            AND YEAR(d.Ngay) = @Nam
        GROUP BY 
            t.TaiKhoan_ID, t.HoTenTX
    )
    SELECT * FROM TongCaLam;
END;
--------------------------

CREATE PROCEDURE [dbo].[ThongKeHocSinhLeXuongTramTheoNgay]
    @HoTenHS NVARCHAR(100) -- Tham số đầu vào là họ tên học sinh
AS
BEGIN
    -- Bắt đầu khối xử lý
    SET NOCOUNT ON;

    SELECT 
        HS.HoTenHS AS 'Họ Tên Học Sinh',
        DD.NgayDiemDanh AS 'Ngày Đi Xe',
        XB.SoXeBus AS 'Số Xe',
       CTDDD.DiemLenXe AS 'Điểm Lên (ĐI)',
        -- Kiểm tra NULL và chuyển đổi nếu có dữ liệu, nếu không trả về giá trị mặc định
        CONVERT(VARCHAR(5), ISNULL(CTDDD.GioLenXe, '1900-01-01'), 108) AS 'Thời Gian Lên (ĐI)', 
        CTDDD.DiemXuongXe AS 'Điểm Xuống (ĐI)',
        CONVERT(VARCHAR(5), ISNULL(CTDDD.GioXuongXe, '1900-01-01'), 108) AS 'Thời Gian Xuống (ĐI)', 
        CTDDV.DiemLenXe AS 'Điểm Lên (VỀ)',
        CONVERT(VARCHAR(5), ISNULL(CTDDV.GioLenXe, '1900-01-01'), 108) AS 'Thời Gian Lên (VỀ)', 
        CTDDV.DiemXuongXe AS 'Điểm Xuống (VỀ)',
        CONVERT(VARCHAR(5), ISNULL(CTDDV.GioXuongXe, '1900-01-01'), 108) AS 'Thời Gian Xuống (VỀ)' 
    FROM 
        HocSinh HS
    INNER JOIN 
        ChiTietDiemDanhDi CTDDD ON HS.HocSinh_ID = CTDDD.HocSinh_ID
    INNER JOIN 
        DiemDanh DD ON CTDDD.DiemDanh_ID = DD.DiemDanh_ID
    INNER JOIN 
        XeBus XB ON DD.Bus_ID = XB.Bus_ID
    LEFT JOIN 
        ChiTietDiemDanhVe CTDDV ON HS.HocSinh_ID = CTDDV.HocSinh_ID AND CTDDV.DiemDanh_ID = DD.DiemDanh_ID
    WHERE 
        HS.HoTenHS = @HoTenHS;
END;
--EXEC ThongKeHocSinhLeXuongTramTheoNgay @HoTenHS = N'Trần Minh Quang';

------------------------------
CREATE PROCEDURE InsertHocSinh
@HocSinh_ID VARCHAR(20),
@HoTenHS NVARCHAR(100),
@NgaySinh DATE,
@DiaChi NVARCHAR(255),
@PhuHuynh_ID VARCHAR(20),
@Lop_ID VARCHAR(20)
AS
BEGIN
    INSERT INTO HocSinh (HocSinh_ID, HoTenHS, NgaySinh, DiaChi, PhuHuynh_ID, Lop_ID)
    VALUES (@HocSinh_ID, @HoTenHS, @NgaySinh, @DiaChi, @PhuHuynh_ID, @Lop_ID);
END
GO


CREATE PROCEDURE UpdateHocSinh
@HocSinh_ID VARCHAR(20),
@HoTenHS NVARCHAR(100),
@NgaySinh DATE,
@DiaChi NVARCHAR(255),
@PhuHuynh_ID VARCHAR(20),
@Lop_ID VARCHAR(20)
AS
BEGIN
    UPDATE HocSinh
    SET HoTenHS = @HoTenHS,
        NgaySinh = @NgaySinh,
        DiaChi = @DiaChi,
        PhuHuynh_ID = @PhuHuynh_ID,
        Lop_ID = @Lop_ID
    WHERE HocSinh_ID = @HocSinh_ID;
END
GO


CREATE PROCEDURE DeleteHocSinh
@HocSinh_ID VARCHAR(20)
AS
BEGIN
    DELETE FROM HocSinh WHERE HocSinh_ID = @HocSinh_ID;
END
GO


CREATE PROCEDURE SearchHocSinh
@SearchKeyword NVARCHAR(100)
AS
BEGIN
    SELECT * FROM HocSinh WHERE HoTenHS LIKE @SearchKeyword;
END
GO

------------------Phu Huynh------------
CREATE PROCEDURE GetTaiKhoanPhuHuynh
AS
BEGIN
    SELECT TaiKhoan.TaiKhoan_ID, 
           TaiKhoan.MatKhau, 
           TaiKhoan.LoaiTK_ID, 
           PhuHuynh.HoTenPH, 
           PhuHuynh.Email, 
           PhuHuynh.SoDT
    FROM TaiKhoan
    JOIN PhuHuynh ON TaiKhoan.TaiKhoan_ID = PhuHuynh.TaiKhoan_ID;
END
GO

CREATE PROCEDURE InsertTaiKhoanPhuHuynh
    @TaiKhoanID VARCHAR(20),
    @MatKhau VARCHAR(50),
    @LoaiTK_ID VARCHAR(20),
    @HoTenPH NVARCHAR(100),
    @Email VARCHAR(100),
    @SoDT VARCHAR(12)
AS
BEGIN
    BEGIN TRY
        -- Thêm vào bảng TaiKhoan
        INSERT INTO TaiKhoan (TaiKhoan_ID, MatKhau, LoaiTK_ID) 
        VALUES (@TaiKhoanID, @MatKhau, @LoaiTK_ID);
        
        -- Thêm vào bảng PhuHuynh
        INSERT INTO PhuHuynh (TaiKhoan_ID, HoTenPH, Email, SoDT) 
        VALUES (@TaiKhoanID, @HoTenPH, @Email, @SoDT);
        
        -- Nếu thành công, trả về 1
        SELECT 1 AS Result;
    END TRY
    BEGIN CATCH
        -- Xử lý lỗi nếu có và trả về 0
        SELECT 0 AS Result;
    END CATCH
END
GO


CREATE PROCEDURE UpdateTaiKhoanPhuHuynh
    @TaiKhoanID VARCHAR(20),
    @MatKhau VARCHAR(50),
    @LoaiTK_ID VARCHAR(20),
    @HoTenPH NVARCHAR(100),
    @Email VARCHAR(100),
    @SoDT VARCHAR(12)
AS
BEGIN
    BEGIN TRY
        -- Cập nhật bảng TaiKhoan
        UPDATE TaiKhoan 
        SET MatKhau = @MatKhau, LoaiTK_ID = @LoaiTK_ID 
        WHERE TaiKhoan_ID = @TaiKhoanID;

        -- Cập nhật bảng PhuHuynh
        UPDATE PhuHuynh 
        SET HoTenPH = @HoTenPH, Email = @Email, SoDT = @SoDT 
        WHERE TaiKhoan_ID = @TaiKhoanID;

        -- Nếu thành công, trả về 1
        SELECT 1 AS Result;
    END TRY
    BEGIN CATCH
        -- Xử lý lỗi nếu có và trả về 0
        SELECT 0 AS Result;
    END CATCH
END
GO

CREATE PROCEDURE DeleteTaiKhoanPhuHuynh
    @TaiKhoanID VARCHAR(20)
AS
BEGIN
    BEGIN TRY
        -- Xóa dữ liệu trong bảng PhuHuynh
        DELETE FROM PhuHuynh WHERE TaiKhoan_ID = @TaiKhoanID;

        -- Xóa dữ liệu trong bảng TaiKhoan
        DELETE FROM TaiKhoan WHERE TaiKhoan_ID = @TaiKhoanID;

        -- Nếu thành công, trả về 1
        SELECT 1 AS Result;
    END TRY
    BEGIN CATCH
        -- Xử lý lỗi nếu có và trả về 0
        SELECT 0 AS Result;
    END CATCH
END
GO

CREATE PROCEDURE SearchTaiKhoanPhuHuynh
    @SearchTerm NVARCHAR(100)
AS
BEGIN
    SELECT tk.TaiKhoan_ID, tk.MatKhau, tk.LoaiTK_ID, ph.HoTenPH, ph.Email, ph.SoDT
    FROM TaiKhoan tk
    JOIN PhuHuynh ph ON tk.TaiKhoan_ID = ph.TaiKhoan_ID
    WHERE tk.TaiKhoan_ID LIKE '%' + @SearchTerm + '%'
    OR ph.HoTenPH LIKE '%' + @SearchTerm + '%'
    OR ph.Email LIKE '%' + @SearchTerm + '%'
    OR ph.SoDT LIKE '%' + @SearchTerm + '%'
END
GO
-------------Tai Xe------------
CREATE PROCEDURE GetTaiKhoanTaiXe
AS
BEGIN
    SELECT 
        TaiKhoan.TaiKhoan_ID, 
        TaiKhoan.LoaiTK_ID,   
        TaiXe.HoTenTX,        
        TaiXe.GiayPhepLaiXe,   
        TaiXe.TrangThai,       
        TaiXe.SoDT,            
        TaiXe.Email           
    FROM TaiKhoan 
    JOIN TaiXe ON TaiKhoan.TaiKhoan_ID = TaiXe.TaiKhoan_ID
END
GO

--------------------------------------------
CREATE PROCEDURE InsertTaiKhoanAndTaiXe
    @TaiKhoanID VARCHAR(20),
    @MatKhau VARCHAR(50),
    @LoaiTK_ID VARCHAR(20),
    @HoTenTX NVARCHAR(100),
    @GiayPhepLaiXe VARCHAR(20),
    @TrangThai NVARCHAR(50),
    @SoDT VARCHAR(12)
AS
BEGIN
    -- Insert into TaiKhoan table
    INSERT INTO TaiKhoan (TaiKhoan_ID, MatKhau, LoaiTK_ID) 
    VALUES (@TaiKhoanID, @MatKhau, @LoaiTK_ID);
    
    -- Insert into TaiXe table
    INSERT INTO TaiXe (TaiKhoan_ID, HoTenTX, GiayPhepLaiXe, TrangThai, SoDT)
    VALUES (@TaiKhoanID, @HoTenTX, @GiayPhepLaiXe, @TrangThai, @SoDT);
END
GO
--------------------------------------------------------


CREATE PROCEDURE DeleteTaiXe
    @TaiKhoanID VARCHAR(20)
AS
BEGIN
    BEGIN TRY
        -- Xóa tài xế
        DELETE FROM TaiXe WHERE TaiKhoan_ID = @TaiKhoanID;
        
        -- Xóa tài khoản
        DELETE FROM TaiKhoan WHERE TaiKhoan_ID = @TaiKhoanID;

        -- Trả về thông báo thành công
        SELECT 'Xóa tài xế và tài khoản thành công' AS Message;
    END TRY
    BEGIN CATCH
        -- Nếu có lỗi xảy ra, trả về thông báo lỗi
        SELECT ERROR_MESSAGE() AS ErrorMessage;
    END CATCH
END
GO
---------------------------------------------
CREATE PROCEDURE UpdateTaiKhoanAndTaiXe
    @TaiKhoanID VARCHAR(20),
    @LoaiTK_ID VARCHAR(20),
    @HoTenTX NVARCHAR(100),
    @GiayPhepLaiXe VARCHAR(20),
    @TrangThai NVARCHAR(50),
    @SoDT VARCHAR(12),
    @Email VARCHAR(100)
AS
BEGIN
    BEGIN TRY
        -- Kiểm tra sự tồn tại của TaiKhoan_ID
        IF NOT EXISTS (SELECT 1 FROM TaiKhoan WHERE TaiKhoan_ID = @TaiKhoanID)
        BEGIN
            SELECT 'Tài khoản không tồn tại' AS ErrorMessage;
            RETURN;
        END

        -- Bắt đầu giao dịch
        BEGIN TRANSACTION;

        -- Cập nhật bảng TaiKhoan
        UPDATE TaiKhoan 
        SET LoaiTK_ID = @LoaiTK_ID
        WHERE TaiKhoan_ID = @TaiKhoanID;

        -- Cập nhật bảng TaiXe
        UPDATE TaiXe 
        SET HoTenTX = @HoTenTX, 
            GiayPhepLaiXe = @GiayPhepLaiXe, 
            TrangThai = @TrangThai, 
            SoDT = @SoDT, 
            Email = @Email
        WHERE TaiKhoan_ID = @TaiKhoanID;

        -- Nếu mọi thứ thành công, commit giao dịch
        COMMIT TRANSACTION;

        -- Trả về thông báo thành công
        SELECT N'Cập nhật thành công' AS Message;
    END TRY
    BEGIN CATCH
        -- Nếu có lỗi, rollback giao dịch
        ROLLBACK TRANSACTION;

        -- Trả về thông báo lỗi
        SELECT ERROR_MESSAGE() AS ErrorMessage;
    END CATCH
END
GO

EXEC UpdateTaiKhoanAndTaiXe 
    @TaiKhoanID = 'taixe15', 
    @LoaiTK_ID = 'LTK02', 
    @HoTenTX = N'Nguyễn Văn Tê', 
    @GiayPhepLaiXe = 'GPLX12345678', 
    @TrangThai = N'Đang hoạt động', 
    @SoDT = '0912345678', 
    @Email = 'nguyenvante@example.com';

------------------------------------------------

CREATE PROCEDURE SearchTaiXe
    @search NVARCHAR(255)
AS
BEGIN
    SELECT TaiKhoan.TaiKhoan_ID, TaiKhoan.MatKhau, TaiKhoan.LoaiTK_ID, 
           TaiXe.HoTenTX, TaiXe.GiayPhepLaiXe, TaiXe.TrangThai, TaiXe.SoDT 
    FROM TaiKhoan 
    JOIN TaiXe ON TaiKhoan.TaiKhoan_ID = TaiXe.TaiKhoan_ID
    WHERE TaiXe.HoTenTX LIKE @search OR TaiXe.SoDT LIKE @search;
END
GO

--------------------Xe Bus------------------------

CREATE PROCEDURE GetAllTaiXe
AS
BEGIN
    SELECT TaiXe.TaiKhoan_ID, TaiXe.HoTenTX
    FROM TaiXe
    WHERE TaiXe.TrangThai = N'Hoạt động'
    AND TaiXe.TaiKhoan_ID NOT IN (SELECT XeBus.TaiXe_ID FROM XeBus WHERE XeBus.TaiXe_ID IS NOT NULL)
END
GO

EXEC GetAllTaiXe

CREATE PROCEDURE InsertXeBus
    @Bus_ID VARCHAR(20),
    @SoXeBus VARCHAR(20),
    @SoGhe INT,
    @TaiXe_ID VARCHAR(20) = NULL,
    @TrangThai NVARCHAR(50)
AS
BEGIN
    INSERT INTO XeBus (Bus_ID, SoXeBus, SoGhe, TaiXe_ID, TrangThai)
    VALUES (@Bus_ID, @SoXeBus, @SoGhe, @TaiXe_ID, @TrangThai)
END
GO

CREATE PROCEDURE UpdateXeBus
    @Bus_ID VARCHAR(20),
    @SoXeBus VARCHAR(20),
    @SoGhe INT,
    @TaiXe_ID VARCHAR(20) = NULL,
    @TrangThai NVARCHAR(50)
AS
BEGIN
    UPDATE XeBus
    SET SoXeBus = @SoXeBus, 
        SoGhe = @SoGhe, 
        TaiXe_ID = @TaiXe_ID, 
        TrangThai = @TrangThai
    WHERE Bus_ID = @Bus_ID
END
GO

CREATE PROCEDURE DeleteXeBus
    @Bus_ID VARCHAR(20)
AS
BEGIN
    DELETE FROM XeBus
    WHERE Bus_ID = @Bus_ID
END
GO

CREATE PROCEDURE SearchXeBus
    @Keyword NVARCHAR(100)
AS
BEGIN
    SELECT Bus_ID, SoXeBus, SoGhe, TaiXe_ID, TrangThai
    FROM XeBus
    WHERE Bus_ID LIKE '%' + @Keyword + '%' 
       OR SoXeBus LIKE '%' + @Keyword + '%'
       OR TaiXe_ID LIKE '%' + @Keyword + '%'
       OR TrangThai LIKE '%' + @Keyword + '%'
END
GO

------------------Quan Tri Vien--------------------

CREATE PROCEDURE GetTaiKhoanQuanTriVien
AS
BEGIN
    SELECT 
        TaiKhoan.TaiKhoan_ID,
        TaiKhoan.MatKhau,
        TaiKhoan.LoaiTK_ID,
        QuanTriVien.HoTenQTV,
        ChucVu.TenChucVu,
        QuanTriVien.Email
    FROM TaiKhoan
    INNER JOIN QuanTriVien ON QuanTriVien.TaiKhoan_ID = TaiKhoan.TaiKhoan_ID
    INNER JOIN ChucVu ON QuanTriVien.ChucVu_ID = ChucVu.ChucVu_ID
END
GO


CREATE PROCEDURE AddQuanTriVien
    @TaiKhoan_ID VARCHAR(20),
    @MatKhau VARCHAR(50),
    @LoaiTK_ID VARCHAR(20),
    @HoTenQTV NVARCHAR(100),
    @Email VARCHAR(100),
    @ChucVu_ID VARCHAR(20)
AS
BEGIN
    -- Thêm dữ liệu vào bảng TaiKhoan
    INSERT INTO TaiKhoan (TaiKhoan_ID, MatKhau, LoaiTK_ID)
    VALUES (@TaiKhoan_ID, @MatKhau, @LoaiTK_ID);
    
    -- Thêm dữ liệu vào bảng QuanTriVien
    INSERT INTO QuanTriVien (TaiKhoan_ID, ChucVu_ID, HoTenQTV, Email)
    VALUES (@TaiKhoan_ID, @ChucVu_ID, @HoTenQTV, @Email);
END
GO

CREATE PROCEDURE UpdateQuanTriVien
    @TaiKhoan_ID VARCHAR(20),
    @MatKhau VARCHAR(50),
    @LoaiTK_ID VARCHAR(20),
    @HoTenQTV NVARCHAR(100),
    @Email VARCHAR(100),
    @ChucVu_ID VARCHAR(20)
AS
BEGIN
    UPDATE TaiKhoan
    SET MatKhau = @MatKhau, LoaiTK_ID = @LoaiTK_ID
    WHERE TaiKhoan_ID = @TaiKhoan_ID;

    UPDATE QuanTriVien
    SET HoTenQTV = @HoTenQTV, Email = @Email, ChucVu_ID = @ChucVu_ID
    WHERE TaiKhoan_ID = @TaiKhoan_ID;
END
GO

CREATE PROCEDURE DeleteQuanTriVien
    @TaiKhoan_ID VARCHAR(20)
AS
BEGIN
    DELETE FROM QuanTriVien WHERE TaiKhoan_ID = @TaiKhoan_ID;
    DELETE FROM TaiKhoan WHERE TaiKhoan_ID = @TaiKhoan_ID;
END
GO

CREATE PROCEDURE SearchQuanTriVien
    @SearchKeyword NVARCHAR(100)
AS
BEGIN
    SELECT 
        TaiKhoan.TaiKhoan_ID,
        TaiKhoan.MatKhau,
        TaiKhoan.LoaiTK_ID,
        QuanTriVien.HoTenQTV,
        ChucVu.TenChucVu,
        QuanTriVien.Email
    FROM TaiKhoan
    INNER JOIN QuanTriVien ON QuanTriVien.TaiKhoan_ID = TaiKhoan.TaiKhoan_ID
    INNER JOIN ChucVu ON QuanTriVien.ChucVu_ID = ChucVu.ChucVu_ID
    WHERE QuanTriVien.HoTenQTV LIKE '%' + @SearchKeyword + '%'
    OR QuanTriVien.Email LIKE '%' + @SearchKeyword + '%'
END
GO



CREATE PROCEDURE UpdateMatKhau
    @TaiKhoan_ID VARCHAR(20),
    @MatKhauCu VARCHAR(50),
    @MatKhauMoi VARCHAR(50)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM TaiKhoan WHERE TaiKhoan_ID = @TaiKhoan_ID AND MatKhau = @MatKhauCu)
    BEGIN
        UPDATE TaiKhoan
        SET MatKhau = @MatKhauMoi
        WHERE TaiKhoan_ID = @TaiKhoan_ID;
    END
END;



CREATE PROCEDURE GetTaiXeByPhuHuynhID
    @TaiKhoan_ID VARCHAR(20)
AS
BEGIN
    SELECT 
        tx.HoTenTX AS TenTaiXe,
        tx.SoDT AS SoDienThoaiTaiXe,
        xb.SoXeBus AS BienSoXe
    FROM PhuHuynh ph
    JOIN HocSinh hs ON ph.TaiKhoan_ID = hs.PhuHuynh_ID
    JOIN ChiTietDanhSachHocSinh ctdshs ON hs.HocSinh_ID = ctdshs.HocSinh_ID
    JOIN XeBus xb ON ctdshs.Bus_ID = xb.Bus_ID
    JOIN TaiXe tx ON xb.TaiXe_ID = tx.TaiKhoan_ID
    WHERE ph.TaiKhoan_ID = @TaiKhoan_ID;
END;


CREATE PROCEDURE GetHocSinhByPhuHuynh
    @PhuHuynh_ID VARCHAR(20)
AS
BEGIN
    SELECT 
        hs.HocSinh_ID,
        hs.HoTenHS,
        hs.NgaySinh,
        hs.DiaChi,
        l.TenLop
    FROM 
        HocSinh hs
    LEFT JOIN 
        Lop l ON hs.Lop_ID = l.Lop_ID
    WHERE 
        hs.PhuHuynh_ID = @PhuHuynh_ID;
END;
DROP PROC GetHocSinhByPhuHuynh
-----------------------------------------------------
CREATE PROCEDURE GetLoTrinhByPhuHuynhID
    @PhuHuynh_ID VARCHAR(20)
AS
BEGIN
    -- Lấy Bus_ID từ XeBus dựa trên HocSinh thuộc PhuHuynh_ID
    DECLARE @Bus_ID VARCHAR(20);
    
    SELECT TOP 1 @Bus_ID = Bus_ID
    FROM ChiTietDanhSachHocSinh ctds
    JOIN HocSinh hs ON ctds.HocSinh_ID = hs.HocSinh_ID
    WHERE hs.PhuHuynh_ID = @PhuHuynh_ID;

    -- Lấy LoTrinh_ID từ LoTrinh dựa trên Bus_ID
    DECLARE @LoTrinh_ID VARCHAR(20);
    
    SELECT TOP 1 @LoTrinh_ID = LoTrinh_ID
    FROM LoTrinh
    WHERE Bus_ID = @Bus_ID;

    -- Lấy các vị trí của lộ trình từ ChiTietLoTrinhXe và DiemDung
    SELECT STRING_AGG(dd.ViTri, ' - ') AS LoTrinhDuongDi
    FROM ChiTietLoTrinhXe ctl
    JOIN DiemDung dd ON ctl.DiemDung_ID = dd.DiemDung_ID
    WHERE ctl.LoTrinh_ID = @LoTrinh_ID;
END;

-----------------------------------------------------
CREATE PROCEDURE GetEmailPhuHuynhByTaiXeID
    @TaiXe_ID VARCHAR(20) -- ID tài khoản của tài xế
AS
BEGIN
    SELECT DISTINCT PH.Email
    FROM PhuHuynh PH
    JOIN HocSinh HS ON PH.TaiKhoan_ID = HS.PhuHuynh_ID
    JOIN ChiTietDanhSachHocSinh CTDSHS ON HS.HocSinh_ID = CTDSHS.HocSinh_ID
    JOIN XeBus XB ON CTDSHS.Bus_ID = XB.Bus_ID
    WHERE XB.TaiXe_ID = @TaiXe_ID;
END;

EXEC GetEmailPhuHuynhByTaiXeID @TaiXe_ID = 'hieupham';


-----------------------------------------------------
CREATE PROCEDURE sp_DanhSachHocSinhTheoXe
    @SoXeBus VARCHAR(20),                        
    @NgayBatDau NVARCHAR(10),  -- Chuỗi nhập vào dd/mm/yyyy
    @NgayKetThuc NVARCHAR(10)  -- Chuỗi nhập vào dd/mm/yyyy
AS
BEGIN
    SET NOCOUNT ON;

    -- Chuyển đổi ngày từ dd/mm/yyyy sang DATE
    DECLARE @NgayBatDau_Date DATE = CONVERT(DATE, @NgayBatDau, 103);
    DECLARE @NgayKetThuc_Date DATE = CONVERT(DATE, @NgayKetThuc, 103);

    SELECT 
        HS.HocSinh_ID, 
        HS.HoTenHS, 
        CONVERT(VARCHAR(10), DD.NgayDiemDanh, 103) AS NgayDiemDanh, -- Định dạng dd/mm/yyyy
        CDDD.GioLenXe, 
        CDDD.GioXuongXe,
        XB.SoXeBus,
        DD.Bus_ID
    FROM 
        DiemDanh DD
    INNER JOIN XeBus XB ON DD.Bus_ID = XB.Bus_ID
    INNER JOIN ChiTietDiemDanhDi CDDD ON DD.DiemDanh_ID = CDDD.DiemDanh_ID
    INNER JOIN HocSinh HS ON CDDD.HocSinh_ID = HS.HocSinh_ID
    WHERE 
        XB.SoXeBus = @SoXeBus
        AND DD.NgayDiemDanh BETWEEN @NgayBatDau_Date AND @NgayKetThuc_Date

    UNION

    SELECT 
        HS.HocSinh_ID, 
        HS.HoTenHS, 
        CONVERT(VARCHAR(10), DD.NgayDiemDanh, 103) AS NgayDiemDanh, -- Định dạng dd/mm/yyyy
        CDDV.GioLenXe, 
        CDDV.GioXuongXe,
        XB.SoXeBus,
        DD.Bus_ID
    FROM 
        DiemDanh DD
    INNER JOIN XeBus XB ON DD.Bus_ID = XB.Bus_ID
    INNER JOIN ChiTietDiemDanhVe CDDV ON DD.DiemDanh_ID = CDDV.DiemDanh_ID
    INNER JOIN HocSinh HS ON CDDV.HocSinh_ID = HS.HocSinh_ID
    WHERE 
        XB.SoXeBus = @SoXeBus
        AND DD.NgayDiemDanh BETWEEN @NgayBatDau_Date AND @NgayKetThuc_Date;

END;

-----------------------------------------------------

EXEC sp_DanhSachHocSinhTheoXe '51B12345', '01/06/2024', '17/12/2024';


-----------------------------------------------------
