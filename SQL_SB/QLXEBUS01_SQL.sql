CREATE DATABASE QLXEBUS01
GO
USE QLXEBUS01
GO
-- Bảng LoaiTaiKhoan
CREATE TABLE LoaiTaiKhoan (
    LoaiTK_ID VARCHAR(20) PRIMARY KEY,
    TenLoaiTK NVARCHAR(50)
);

-- Bảng TaiKhoan
CREATE TABLE TaiKhoan (
    TaiKhoan_ID VARCHAR(20) PRIMARY KEY,
    MatKhau VARCHAR(50),
    LoaiTK_ID VARCHAR(20),
    FOREIGN KEY (LoaiTK_ID) REFERENCES LoaiTaiKhoan(LoaiTK_ID)
);
select * from TaiKhoan
-- Bảng PhuHuynh
CREATE TABLE PhuHuynh (
    TaiKhoan_ID VARCHAR(20) PRIMARY KEY,
    HoTenPH NVARCHAR(100),
    Email VARCHAR(100),
    SoDT VARCHAR(12),
    FOREIGN KEY (TaiKhoan_ID) REFERENCES TaiKhoan(TaiKhoan_ID)
);

-- Bảng TaiXe
CREATE TABLE TaiXe (
    TaiKhoan_ID VARCHAR(20) PRIMARY KEY,
    HoTenTX NVARCHAR(100),
    SoDT VARCHAR(12),
    GiayPhepLaiXe VARCHAR(20),
    TrangThai NVARCHAR(50),
    FOREIGN KEY (TaiKhoan_ID) REFERENCES TaiKhoan(TaiKhoan_ID)
);
ALTER TABLE TaiXe
ADD Email VARCHAR(100);


-- Bảng ChucVu
CREATE TABLE ChucVu (
    ChucVu_ID VARCHAR(20) PRIMARY KEY,
    TenChucVu NVARCHAR(50)
);

-- Bảng QuanTriVien
CREATE TABLE QuanTriVien (
    TaiKhoan_ID VARCHAR(20) PRIMARY KEY,
    ChucVu_ID VARCHAR(20),
    HoTenQTV NVARCHAR(100),
    Email VARCHAR(100),
	FOREIGN KEY (ChucVu_ID) REFERENCES ChucVu(ChucVu_ID),
    FOREIGN KEY (TaiKhoan_ID) REFERENCES TaiKhoan(TaiKhoan_ID)
);

-- Bảng Lop
CREATE TABLE Lop (
    Lop_ID VARCHAR(20) PRIMARY KEY,
    TenLop NVARCHAR(50)
);

-- Bảng HocSinh
CREATE TABLE HocSinh (
    HocSinh_ID VARCHAR(20) PRIMARY KEY,
    HoTenHS NVARCHAR(100),
    NgaySinh DATE,
    DiaChi NVARCHAR(255),
    PhuHuynh_ID VARCHAR(20),
    Lop_ID VARCHAR(20),
    FOREIGN KEY (PhuHuynh_ID) REFERENCES PhuHuynh(TaiKhoan_ID),
    FOREIGN KEY (Lop_ID) REFERENCES Lop(Lop_ID)
);


-- Bảng XeBus
CREATE TABLE XeBus (
    Bus_ID VARCHAR(20) PRIMARY KEY,
    SoXeBus VARCHAR(20),
    SoGhe INT,
    TaiXe_ID VARCHAR(20),
    TrangThai NVARCHAR(50),
    FOREIGN KEY (TaiXe_ID) REFERENCES TaiXe(TaiKhoan_ID)
);

-- Bảng DiemDanh
CREATE TABLE DiemDanh (
    DiemDanh_ID VARCHAR(20) PRIMARY KEY,
    Bus_ID VARCHAR(20),
    NgayDiemDanh DATE,
    TrangThai NVARCHAR(50),
    FOREIGN KEY (Bus_ID) REFERENCES XeBus(Bus_ID)
);

-- Bảng ChiTietDiemDanh
CREATE TABLE ChiTietDiemDanhDi (
    CTDDD_ID VARCHAR(20) PRIMARY KEY,
    DiemDanh_ID VARCHAR(20),
    HocSinh_ID VARCHAR(20),
	DiemLenXe NVARCHAR(100),
	DiemXuongXe NVARCHAR(100),
    GioLenXe TIME,
    GioXuongXe TIME,
    TrangThai NVARCHAR(50),
    FOREIGN KEY (DiemDanh_ID) REFERENCES DiemDanh(DiemDanh_ID),
    FOREIGN KEY (HocSinh_ID) REFERENCES HocSinh(HocSinh_ID)
);

-- Bảng LoTrinh
CREATE TABLE LoTrinh (
    LoTrinh_ID VARCHAR(20) PRIMARY KEY,
    Bus_ID VARCHAR(20), 
    GioKhoiHanh TIME,
    GioKetThuc TIME,
    FOREIGN KEY (Bus_ID) REFERENCES XeBus(Bus_ID)
);

-- Bảng DiemDung
CREATE TABLE DiemDung (
    DiemDung_ID VARCHAR(20) PRIMARY KEY,
    ViTri NVARCHAR(100)
);

-- Bảng ChiTietLoTrinhXe
CREATE TABLE ChiTietLoTrinhXe (
    CTLT_ID VARCHAR(20) PRIMARY KEY,
    LoTrinh_ID VARCHAR(20),
    DiemDung_ID VARCHAR(20),
    ThuTu INT, 
    ThoiGianDung TIME,
    FOREIGN KEY (LoTrinh_ID) REFERENCES LoTrinh(LoTrinh_ID),
    FOREIGN KEY (DiemDung_ID) REFERENCES DiemDung(DiemDung_ID)
);


-- Bảng HopDongXeBus
CREATE TABLE HopDongXeBus (
	HD_ID VARCHAR(20) PRIMARY KEY,
	PhuHuynh_ID VARCHAR(20),
	ChiPhi INT,
	ThoiGianBatDau DATE,
	ThoiGianKetThuc DATE,
	TrangThai NVARCHAR(50),
	FOREIGN KEY (PhuHuynh_ID) REFERENCES PhuHuynh(TaiKhoan_ID)
);

-- Bảng ChiTietDanhSachHocSinh
CREATE TABLE ChiTietDanhSachHocSinh (
	CT_DSHS_ID VARCHAR(20)	PRIMARY KEY,
	Bus_ID VARCHAR(20),
	HocSinh_ID VARCHAR(20), 
	FOREIGN KEY (Bus_ID) REFERENCES XeBus(Bus_ID),
	FOREIGN KEY (HocSinh_ID) REFERENCES HocSinh(HocSinh_ID)
);

CREATE TABLE ChiTietHocSinhDiemDung (
	CT_HSDD_ID VARCHAR(20)	PRIMARY KEY,
	DiemDung_ID VARCHAR(20),
	HocSinh_ID VARCHAR(20), 
	FOREIGN KEY (DiemDung_ID) REFERENCES DiemDung(DiemDung_ID),
	FOREIGN KEY (HocSinh_ID) REFERENCES HocSinh(HocSinh_ID)
);

-- Bảng ChiTietDiemDanhVe
CREATE TABLE ChiTietDiemDanhVe (
    CTDDV_ID VARCHAR(20) PRIMARY KEY,
    DiemDanh_ID VARCHAR(20),
    HocSinh_ID VARCHAR(20),
	DiemLenXe NVARCHAR(100),
	DiemXuongXe NVARCHAR(100),
    GioLenXe TIME,
    GioXuongXe TIME,
    TrangThai NVARCHAR(50),
    FOREIGN KEY (DiemDanh_ID) REFERENCES DiemDanh(DiemDanh_ID),
    FOREIGN KEY (HocSinh_ID) REFERENCES HocSinh(HocSinh_ID)
);

CREATE TABLE CaLamTaiXe (
    CaLam_ID VARCHAR(20) PRIMARY KEY, -- Mã của ca làm
    CaLam NVARCHAR(100) NOT NULL      -- Tên hoặc mô tả ca làm
);
CREATE TABLE DiemDanhTaiXe (
    DiemDanhTX_ID VARCHAR(20) PRIMARY KEY, -- Mã điểm danh tài xế
    TaiKhoan_ID VARCHAR(20),               -- Liên kết tài khoản tài xế
    SoXeBus VARCHAR(20),                  -- Số xe buýt tài xế lái
    Ngay DATE NOT NULL,                    -- Ngày làm việc
    CaLam_ID VARCHAR(20),                  -- Liên kết ca làm
    TrangThai NVARCHAR(50),                -- Trạng thái làm việc (ví dụ: "Đúng giờ", "Vắng")
    FOREIGN KEY (TaiKhoan_ID) REFERENCES TaiXe(TaiKhoan_ID), -- Khóa ngoại từ TaiXe
    FOREIGN KEY (CaLam_ID) REFERENCES CaLamTaiXe(CaLam_ID),
);

---------------------------------------------------------------------------
CREATE TRIGGER TR_CheckChiTietDiemDanhVe 
ON ChiTietDiemDanhVe 
FOR INSERT, UPDATE 
AS 
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE DiemLenXe = DiemXuongXe
           OR GioLenXe >= GioXuongXe
           OR TrangThai NOT IN (N'Có mặt', N'Vắng')
    )
    BEGIN
        RAISERROR (
            'Dữ liệu không hợp lệ: Điểm lên xe khác điểm xuống xe, giờ lên xe phải trước giờ xuống xe, và trạng thái phải là "Có mặt" hoặc "Vắng".', 
            16, 
            1
        );
        ROLLBACK TRANSACTION;
    END
END;
--------------------------------------------------------------------------------------------------
CREATE TRIGGER TRG_Check_TenLoaiTK 
ON LoaiTaiKhoan 
AFTER INSERT, UPDATE 
AS 
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE TenLoaiTK NOT IN (N'Admin', N'Quản trị viên', N'Tài xế', N'Phụ huynh')
    )
    BEGIN
        RAISERROR (
            N'TenLoaiTK chỉ được phép là Admin, Quản trị viên, Tài xế hoặc Phụ huynh.', 
            16, 
            1
        );
        ROLLBACK TRANSACTION;
    END
END;
-------------------------------------------------------------------------------------------
CREATE TRIGGER Trigger_ChiTietDiemDanhDi 
ON ChiTietDiemDanhDi 
FOR INSERT, UPDATE 
AS 
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE DiemLenXe = DiemXuongXe
           OR GioLenXe >= GioXuongXe
           OR TrangThai NOT IN (N'Có mặt', N'Vắng')
    )
    BEGIN
        RAISERROR (
            'Dữ liệu không hợp lệ: Điểm lên xe khác điểm xuống xe, giờ lên xe phải trước giờ xuống xe, và trạng thái phải là "Có mặt" hoặc "Vắng".', 
            16, 
            1
        );
        ROLLBACK TRANSACTION;
    END
END;
-------------------------------------------------------------------------
CREATE TRIGGER Trigger_KiemTraDoDaiMatKhau 
ON TaiKhoan 
FOR INSERT, UPDATE 
AS 
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE LEN(MatKhau) < 8
    )
    BEGIN
        RAISERROR (
            'Mật khẩu phải chứa ít nhất 8 ký tự.', 
            16, 
            1
        );
        ROLLBACK TRANSACTION;
    END
END;
----------------------------------------------------------------------
CREATE TRIGGER Trigger_KiemTraDoDaiSDT 
ON PhuHuynh 
FOR INSERT, UPDATE 
AS 
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE LEN(SoDT) <> 10
    )
    BEGIN
        RAISERROR (
            'Số điện thoại phải có độ dài chính xác là 10 ký tự.', 
            16, 
            1
        );
        ROLLBACK TRANSACTION;
    END
END;
---------------------------------------------------
CREATE TRIGGER Trigger_KiemTraQuyTacTaiXe 
ON TaiXe 
FOR INSERT, UPDATE 
AS 
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE LEN(SoDT) <> 10
           OR LEN(GiayPhepLaiXe) <> 12
           OR TrangThai NOT IN (N'Đang hoạt động', N'Đang tạm vắng')
    )
    BEGIN
        RAISERROR (
            'Dữ liệu không hợp lệ: Số điện thoại phải có 10 ký tự, giấy phép lái xe phải có 12 ký tự, trạng thái phải là "Đang hoạt động" hoặc "Đang tạm vắng".', 
            16, 
            1
        );
        ROLLBACK TRANSACTION;
    END
END;
-----------------------------------
CREATE TRIGGER Trigger_KiemTraQuyTacXeBus 
ON XeBus 
FOR INSERT, UPDATE 
AS 
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE 
              LEN(SoXeBus) <> 8
           OR SUBSTRING(SoXeBus, 1, 2) NOT LIKE '[0-9][0-9]'
           OR SUBSTRING(SoXeBus, 3, 1) NOT LIKE '[A-Z]'
           OR SUBSTRING(SoXeBus, 4, 5) NOT LIKE '[0-9][0-9][0-9][0-9][0-9]'
           OR SoGhe <> 10
           OR TrangThai NOT IN (N'Đang hoạt động', N'Đang bảo trì')
    )
    BEGIN
        RAISERROR (
            N'Dữ liệu không hợp lệ: 
               - Biển số xe phải có định dạng: 2 ký tự đầu là số, ký tự thứ 3 là chữ in hoa, 5 ký tự cuối là số. 
               - Số ghế phải là 10. 
               - Trạng thái chỉ có thể là "Đang hoạt động" hoặc "Đang bảo trì".', 
            16, 
            1
        );
        ROLLBACK TRANSACTION;
    END
END;
------------------------------------------------------------
CREATE TRIGGER Trigger_KiemTraThoiGianLoTrinh 
ON LoTrinh 
FOR INSERT, UPDATE 
AS 
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE GioKhoiHanh >= GioKetThuc
    )
    BEGIN
        RAISERROR (
            'Thời gian khởi hành phải sớm hơn thời gian kết thúc.', 
            16, 
            1
        );
        ROLLBACK TRANSACTION;
    END
END;
---------------------------------------------------------
CREATE TRIGGER Trigger_KiemTraTrangThaiDiemDanh 
ON DiemDanh 
FOR INSERT, UPDATE 
AS 
BEGIN
    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE TrangThai NOT IN (N'Hoàn thành', N'Chưa hoàn thành')
    )
    BEGIN
        RAISERROR (
            'Trạng thái chỉ có thể là "Hoàn thành" hoặc "Chưa hoàn thành".', 
            16, 
            1
        );
        ROLLBACK TRANSACTION;
    END
END;
--------------------------------------------------------------------------
CREATE TRIGGER trg_CheckBusCapacity
ON ChiTietDanhSachHocSinh
INSTEAD OF INSERT
AS
BEGIN
    DECLARE @Bus_ID VARCHAR(20);
    DECLARE @HocSinh_ID VARCHAR(20);
    DECLARE @Count INT;

    -- Lấy Bus_ID và HocSinh_ID từ bảng INSERTED
    SELECT @Bus_ID = Bus_ID, @HocSinh_ID = HocSinh_ID
    FROM INSERTED;

    -- Đếm số lượng học sinh hiện có trong xe bus
    SELECT @Count = COUNT(*) 
    FROM ChiTietDanhSachHocSinh
    WHERE Bus_ID = @Bus_ID;

    -- Kiểm tra nếu số lượng học sinh đã đạt giới hạn 10
    IF @Count >= 10
    BEGIN
        RAISERROR ('Xe bus đã đạt giới hạn 10 học sinh, không thể thêm học sinh mới.', 16, 1);
    END
    ELSE
    BEGIN
        -- Thêm học sinh vào bảng vì chưa đạt giới hạn
        INSERT INTO ChiTietDanhSachHocSinh (CT_DSHS_ID, Bus_ID, HocSinh_ID)
        SELECT CT_DSHS_ID, Bus_ID, HocSinh_ID 
        FROM INSERTED;
    END
END;
GO

