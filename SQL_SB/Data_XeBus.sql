------------------------------------------THÊM DỮ LIỆU-------------------------------------

-- Bảng LoaiTaiKhoan
INSERT INTO LoaiTaiKhoan (LoaiTK_ID, TenLoaiTK)
VALUES 
	('LTK01', N'Phụ Huynh'),
	('LTK02', N'Tài Xế'),
	('LTK03', N'Quản Trị Viên'),
	('LTK0', N'Admin')
------------------------====================================================
-- Bảng TaiKhoan
INSERT INTO TaiKhoan (TaiKhoan_ID, MatKhau, LoaiTK_ID) VALUES
('phuynh01', 'pass1234', 'LTK01'), ('phuynh02', 'pass5678', 'LTK01'),
('phuynh03', 'phuynh7890', 'LTK01'), ('phuynh04', 'abc12345', 'LTK01'),
('phuynh05', 'def45678', 'LTK01'), ('phuynh06', 'ghi98765', 'LTK01'),
('phuynh07', 'jkl54321', 'LTK01'), ('phuynh08', 'mno67890', 'LTK01'),
('phuynh09', 'pqr13579', 'LTK01'), ('phuynh10', 'stu24680', 'LTK01'),
--
('taixe01', 'driver001', 'LTK02'), ('taixe02', 'driver002', 'LTK02'),
('taixe03', 'driver003', 'LTK02'), ('taixe04', 'driver004', 'LTK02'),
('taixe05', 'driver005', 'LTK02'), ('taixe06', 'driver006', 'LTK02'),
('taixe07', 'driver007', 'LTK02'), ('taixe08', 'driver008', 'LTK02'),
('taixe09', 'driver009', 'LTK02'), ('taixe10', 'driver010', 'LTK02'),
('taixe11', 'driver1111', 'LTK02'),('taixe12', 'driver2222', 'LTK02'),
('taixe13', 'driver3333', 'LTK02'),('taixe14', 'driver4444', 'LTK02'),
('taixe15', 'driver5555', 'LTK02'),
--
('qtv01', 'adminpass1', 'LTK03'), ('qtv02', 'adminpass2', 'LTK03'),
('qtv03', 'adminpass3', 'LTK03'), ('qtv04', 'adminpass4', 'LTK03'),
('qtv05', 'adminpass5', 'LTK03'), ('qtv06', 'adminpass6', 'LTK03'),
('qtv07', 'adminpass7', 'LTK03'), ('qtv08', 'adminpass8', 'LTK03'),
('qtv09', 'adminpass9', 'LTK03'), ('qtv10', 'adminpass10', 'LTK03');
INSERT INTO TaiKhoan (TaiKhoan_ID, MatKhau, LoaiTK_ID) VALUES
('phuynh11', 'pass1111', 'LTK01'), 
('phuynh12', 'pass2222', 'LTK01'),
('phuynh13', 'phuynh3333', 'LTK01'), 
('phuynh14', 'abca4444', 'LTK01'),
('phuynh15', 'defa5555', 'LTK01'), 
('phuynh16', 'ghia6666', 'LTK01'),
('phuynh17', 'jkal7777', 'LTK01'), 
('phuynh18', 'mnoa8888', 'LTK01'),
('phuynh19', 'pqra9999', 'LTK01'), 
('phuynh20', 'stua0000', 'LTK01');
INSERT INTO TaiKhoan (TaiKhoan_ID, MatKhau, LoaiTK_ID) VALUES
('phuynh21', 'pass11111', 'LTK01'), 
('phuynh22', 'pass22222', 'LTK01'),
('phuynh23', 'pass33333', 'LTK01'), 
('phuynh24', 'pass44444', 'LTK01'),
('phuynh25', 'pass55555', 'LTK01'), 
('phuynh26', 'pass66666', 'LTK01'),
('phuynh27', 'pass77777', 'LTK01'), 
('phuynh28', 'pass88888', 'LTK01'),
('phuynh29', 'pass99999', 'LTK01'), 
('phuynh30', 'pass00000', 'LTK01'),
('phuynh31', 'pass54321', 'LTK01'), 
('phuynh32', 'pass12345', 'LTK01'),
('phuynh33', 'pass13579', 'LTK01'), 
('phuynh34', 'pass24680', 'LTK01'),
('phuynh35', 'pass11223', 'LTK01'), 
('phuynh36', 'pass33445', 'LTK01'),
('phuynh37', 'pass55667', 'LTK01'), 
('phuynh38', 'pass77889', 'LTK01'),
('phuynh39', 'pass99001', 'LTK01'), 
('phuynh40', 'pass22334', 'LTK01'),
('phuynh41', 'pass66778', 'LTK01'), 
('phuynh42', 'pass88990', 'LTK01'),
('phuynh43', 'pass10001', 'LTK01'), 
('phuynh44', 'pass11112', 'LTK01'),
('phuynh45', 'pass22223', 'LTK01'), 
('phuynh46', 'pass33334', 'LTK01'),
('phuynh47', 'pass44445', 'LTK01'), 
('phuynh48', 'pass55556', 'LTK01'),
('phuynh49', 'pass66667', 'LTK01'), 
('phuynh50', 'pass77778', 'LTK01');

INSERT INTO TaiKhoan (TaiKhoan_ID, MatKhau, LoaiTK_ID)
VALUES 
	('tphuoc', '123aa123', 'LTK01'),
	('vananpro', 'vanan132', 'LTK01'),
	('hieupham', 'hieupham11', 'LTK02'),
	('quandoan', 'quandoan41', 'LTK02'),
	('admin.thanh', 'admin09123', 'LTK03'),
	('admin.kiet', 'admin2481', 'LTK03'),
	('lebichh', '1743201', 'LTK01'),
	('khoaminh88', 'khoa1111', 'LTK01'),
	('lanhoang', 'lanhoang12', 'LTK02'),
	('baolam', 'baro6771', 'LTK02'),
	('admin.hong', 'admin6734', 'LTK03');

-------------------------------------==========================================
-- Bảng PhuHuynh
INSERT INTO PhuHuynh (TaiKhoan_ID, HoTenPH, Email, SoDT) VALUES
('phuynh01', N'Nguyễn Văn An', 'an01@gmail.com', '0901234567'),
('phuynh02', N'Trần Thị Bình', 'binh02@gmail.com', '0902345678'),
('phuynh03', N'Lê Quốc Cường', 'cuong03@gmail.com', '0903456789'),
('phuynh04', N'Phạm Thị Dung', 'dung04@gmail.com', '0904567890'),
('phuynh05', N'Hồ Văn Em', 'em05@gmail.com', '0905678901'),
('phuynh06', N'Bùi Thị Gấm', 'gam06@gmail.com', '0906789012'),
('phuynh07', N'Đặng Văn Hải', 'hai07@gmail.com', '0907890123'),
('phuynh08', N'Ngô Thị Kim', 'kim08@gmail.com', '0908901234'),
('phuynh09', N'Vũ Văn Long', 'long09@gmail.com', '0909012345'),
('phuynh10', N'Hoàng Thị Mỹ', 'my10@gmail.com', '0910123456');
INSERT INTO PhuHuynh (TaiKhoan_ID, HoTenPH, Email, SoDT) VALUES
('phuynh11', N'Lê Minh Phong', 'phong11@gmail.com', '0911234561'),
('phuynh12', N'Nguyễn Thị Hà', 'ha12@gmail.com', '0912345672'),
('phuynh13', N'Phạm Quốc Bảo', 'bao13@gmail.com', '0913456783'),
('phuynh14', N'Trần Thị Thanh', 'thanh14@gmail.com', '0914567894'),
('phuynh15', N'Ngô Văn Hưng', 'hung15@gmail.com', '0915678905'),
('phuynh16', N'Bùi Thị Xuân', 'xuan16@gmail.com', '0916789016'),
('phuynh17', N'Vũ Văn Nam', 'nam17@gmail.com', '0917890127'),
('phuynh18', N'Hoàng Thị Lan', 'lan18@gmail.com', '0918901238'),
('phuynh19', N'Đặng Minh Tài', 'tai19@gmail.com', '0919012349'),
('phuynh20', N'Phan Thị Mai', 'mai20@gmail.com', '0920123450');
INSERT INTO PhuHuynh (TaiKhoan_ID, HoTenPH, Email, SoDT) VALUES
('phuynh21', N'Nguyễn Thị Hạnh', 'hanh21@gmail.com', '0921234561'),
('phuynh22', N'Trần Văn Khánh', 'khanh22@gmail.com', '0922345672'),
('phuynh23', N'Phạm Thị Tươi', 'tuoi23@gmail.com', '0923456783'),
('phuynh24', N'Lê Minh Hùng', 'hung24@gmail.com', '0924567894'),
('phuynh25', N'Đỗ Thị Hoa', 'hoa25@gmail.com', '0925678905'),
('phuynh26', N'Hoàng Văn Sơn', 'son26@gmail.com', '0926789016'),
('phuynh27', N'Nguyễn Thị Loan', 'loan27@gmail.com', '0927890127'),
('phuynh28', N'Vũ Minh Khang', 'khang28@gmail.com', '0928901238'),
('phuynh29', N'Trần Văn Đạt', 'dat29@gmail.com', '0929012349'),
('phuynh30', N'Phạm Thị Thủy', 'thuy30@gmail.com', '0930123450'),
('phuynh31', N'Nguyễn Thị Lý', 'ly31@gmail.com', '0931234561'),
('phuynh32', N'Lê Văn Minh', 'minh32@gmail.com', '0932345672'),
('phuynh33', N'Trần Thị Hà', 'ha33@gmail.com', '0933456783'),
('phuynh34', N'Nguyễn Văn Thịnh', 'thinh34@gmail.com', '0934567894'),
('phuynh35', N'Đặng Thị Hương', 'huong35@gmail.com', '0935678905'),
('phuynh36', N'Hoàng Văn Tài', 'tai36@gmail.com', '0936789016'),
('phuynh37', N'Nguyễn Thị Lan', 'lan37@gmail.com', '0937890127'),
('phuynh38', N'Trần Văn Lộc', 'loc38@gmail.com', '0938901238'),
('phuynh39', N'Phạm Minh Châu', 'chau39@gmail.com', '0939012349'),
('phuynh40', N'Lê Thị Phương', 'phuong40@gmail.com', '0940123450'),
('phuynh41', N'Nguyễn Văn Hoàng', 'hoang41@gmail.com', '0941234561'),
('phuynh42', N'Trần Thị Yến', 'yen42@gmail.com', '0942345672'),
('phuynh43', N'Phạm Văn Cường', 'cuong43@gmail.com', '0943456783'),
('phuynh44', N'Lê Thị Thúy', 'thuy44@gmail.com', '0944567894'),
('phuynh45', N'Ngô Minh Hải', 'hai45@gmail.com', '0945678905'),
('phuynh46', N'Bùi Văn Hiếu', 'hieu46@gmail.com', '0946789016'),
('phuynh47', N'Phạm Thị Ngọc', 'ngoc47@gmail.com', '0947890127'),
('phuynh48', N'Nguyễn Thị Mai', 'mai48@gmail.com', '0948901238'),
('phuynh49', N'Hoàng Văn Bình', 'binh49@gmail.com', '0949012349'),
('phuynh50', N'Trần Thị Hậu', 'hau50@gmail.com', '0950123450');

select * from PhuHuynh

INSERT INTO PhuHuynh (TaiKhoan_ID, HoTenPH, Email, SoDT)
VALUES 
	('vananpro', N'Nguyễn Văn An', 'an.nguyen@gmail.com', '0909123456'),
	('lebichh', N'Lê Thị Bích', 'bich.le@gmail.com', '0909876543'),
	('khoaminh88', N'Trần Minh Khoa', 'khoa.tran@gmail.com', '0909345678');

-------------------------------------==========================================
-- Bảng TaiXe
INSERT INTO TaiXe (TaiKhoan_ID, HoTenTX, SoDT, GiayPhepLaiXe, TrangThai)
VALUES 
	('hieupham', N'Phạm Văn Hiếu', '0909333444', 'GPLX123456', N'Hoạt động'),
	('quandoan', N'Đoàn Minh Quan', '0909555666', 'GPLX654321', N'Hoạt động'),
	('lanhoang', N'Hoàng Thị Lan', '0909888999', 'GPLX112233', N'Hoạt động'),
	('baolam', N'Lâm Chí Bảo', '0909888239', 'GPLX619821', N'Không hoạt động');

INSERT INTO TaiXe (TaiKhoan_ID, HoTenTX, SoDT, GiayPhepLaiXe, TrangThai, Email) VALUES
('taixe01', N'Nguyễn Văn Hưng', '0911234567', 'GPLX12345678', N'Đang hoạt động', 'hung.nguyen@gmail.com'),
('taixe02', N'Lê Quốc Bảo', '0912345678', 'GPLX23456789', N'Đang hoạt động', 'bao.le@gmail.com'),
('taixe03', N'Trần Thị Hiền', '0913456789', 'GPLX34567890', N'Đang hoạt động', 'hien.tran@gmail.com'),
('taixe04', N'Phạm Minh Khoa', '0914567890', 'GPLX45678901', N'Đang hoạt động', 'khoa.pham@gmail.com'),
('taixe05', N'Hồ Văn Hậu', '0915678901', 'GPLX56789012', N'Đang hoạt động', 'hau.ho@gmail.com'),
('taixe06', N'Bùi Thị Ngọc', '0916789012', 'GPLX67890123', N'Đang hoạt động', 'ngoc.bui@gmail.com'),
('taixe07', N'Ngô Minh Tâm', '0917890123', 'GPLX78901234', N'Đang hoạt động', 'tam.ngo@gmail.com'),
('taixe08', N'Đặng Thị Vân', '0918901234', 'GPLX89012345', N'Đang hoạt động', 'van.dang@gmail.com'),
('taixe09', N'Vũ Văn Hùng', '0919012345', 'GPLX90123456', N'Đang hoạt động', 'hung.vu@gmail.com'),
('taixe10', N'Hoàng Minh Phúc', '0920123456', 'GPLX01234567', N'Đang hoạt động', 'phuc.hoang@gmail.com'),
('taixe11', N'Nguyễn Văn Tuấn', '0921123456', 'GPLX12345611', N'Đang hoạt động', 'tuan.nguyen@gmail.com'),
('taixe12', N'Trần Thị Thu', '0922234567', 'GPLX12345612', N'Đang tạm vắng', 'thu.tran@gmail.com'),
('taixe13', N'Phạm Văn Hải', '0923345678', 'GPLX12345613', N'Đang hoạt động', 'hai.pham@gmail.com'),
('taixe14', N'Lê Minh Hoàng', '0924456789', 'GPLX12345614', N'Đang hoạt động', 'hoang.le@gmail.com'),
('taixe15', N'Hồ Thị Lan', '0925567890', 'GPLX12345615', N'Đang tạm vắng', 'lan.ho@gmail.com');

select * from taixe

-------------------------------------==========================================

-- Bảng ChucVu
INSERT INTO ChucVu (ChucVu_ID, TenChucVu)
VALUES 
	('CV001', N'Quản lý hệ thống'),
	('CV002', N'Nhân viên hỗ trợ kỹ thuật'),
	('CV003', N'Nhân viên điều hành');
	
-------------------------------------==========================================
-- Bảng QuanTriVien
INSERT INTO QuanTriVien (TaiKhoan_ID, ChucVu_ID, HoTenQTV, Email)
VALUES 
	('admin.thanh', 'CV001', N'Nguyễn Thị Thanh', 'thanh@gmail.com'),
	('admin.kiet', 'CV002', N'Phạm Tuấn Kiệt', 'kiet@gmail.com'),
	('admin.hong', 'CV003', N'Lê Thị Hồng', 'hong@gmail.com');

	INSERT INTO QuanTriVien (TaiKhoan_ID, ChucVu_ID, HoTenQTV, Email) VALUES
('qtv01', 'CV001', N'Nguyễn Văn An', 'a.qtv@gmail.com'),
('qtv02', 'CV002', N'Trần Thị Bích', 'b.qtv@gmail.com'),
('qtv03', 'CV003', N'Lê Văn Cao', 'c.qtv@gmail.com'),
('qtv04', 'CV001', N'Phạm Thị Danh', 'd.qtv@gmail.com'),
('qtv05', 'CV002', N'Hồ Văn Em', 'e.qtv@gmail.com'),
('qtv06', 'CV003', N'Bùi Thị Hậu', 'h.qtv@gmail.com'),
('qtv07', 'CV001', N'Đặng Văn Giang', 'g.qtv@gmail.com'),
('qtv08', 'CV002', N'Ngô Thị Hiền', 'hien.qtv@gmail.com'),
('qtv09', 'CV003', N'Vũ Văn Inh', 'i.qtv@gmail.com'),
('qtv10', 'CV001', N'Hoàng Minh Kha', 'k.qtv@gmail.com');

select * from QuanTriVien
-------------------------------------==========================================

-- Bảng XeBus
INSERT INTO XeBus (Bus_ID, SoXeBus, SoGhe, TaiXe_ID, TrangThai)
VALUES 
	('BUS001', '51B12345', 10, 'hieupham', N'Đang hoạt động'),
	('BUS002', '51B23456', 10, 'quandoan', N'Đang hoạt động'),
	('BUS003', '51B34567', 10, 'lanhoang', N'Đang hoạt động'),
    ('BUS004', '52C45678', 10, 'taixe01', N'Đang hoạt động'),
    ('BUS005', '53D56789', 10, 'taixe02', N'Đang hoạt động'),
    ('BUS006', '54E67890', 10, 'taixe03', N'Đang hoạt động'),
    ('BUS007', '55F78901', 10, 'taixe04', N'Đang hoạt động'),
    ('BUS008', '56G89012', 10, 'taixe05', N'Đang hoạt động'),
    ('BUS009', '57H90123', 10, 'taixe06', N'Đang hoạt động'),
    ('BUS010', '58K01234', 10, 'taixe07', N'Đang hoạt động');
	select * from XeBus
	select * from TaiKhoan where LoaiTK_ID = 'LTK02'

-------------------------------------==========================================

-- Bảng Lop
INSERT INTO Lop (Lop_ID, TenLop)
VALUES 
	('L101', N'Lớp 1A'),
	('L102', N'Lớp 1B'),
	('L201', N'Lớp 2A'),
	('L301', N'Lớp 3A'),
	('L401', N'Lớp 4A'),
	('L103', N'Lớp 1C'),
	('L202', N'Lớp 2B'),
	('L302', N'Lớp 3B'),
	('L402', N'Lớp 4B')


	-------------------------------------==========================================

-- Bảng HocSinh
INSERT INTO HocSinh (HocSinh_ID, HoTenHS, NgaySinh, DiaChi, PhuHuynh_ID, TrangThai, Lop_ID)
VALUES 
	('HS001', N'Trần Minh Quang', '2010-05-15', N'123 Lũy Bán Bích', 'vananpro', 'Có mặt', 'L101'),
	('HS002', N'Nguyễn Thị Lan', '2011-08-22', N'300 Lũy Bán Bích', 'vananpro', 'Có mặt', 'L102'),
	('HS003', N'Lê Thanh Sơn', '2012-03-17', N'700 Lũy Bán Bích', 'lebichh', 'Có mặt', 'L201'),
	('HS004', N'Võ Hoàng Nam', '2010-10-10', N'30 Nguyễn Văn Săng', 'khoaminh88', 'Có mặt', 'L102'),
	('HS005', N'Phan Quốc Đạt', '2011-02-28', N'202 Hòa Bình', 'khoaminh88', 'Có mặt', 'L101');


INSERT INTO HocSinh (HocSinh_ID, HoTenHS, NgaySinh, DiaChi, PhuHuynh_ID, Lop_ID)
VALUES
-- Phường Tân Sơn Nhì
('HS001', N'Nguyễn Minh Khang', '2016-01-05', N'3 Tân Sơn Nhì', 'phuynh01', 'L101'),
('HS002', N'Lê Thị Thuỳ Dương', '2016-02-10', N'30 Tân Sơn Nhì', 'phuynh02', 'L101'),
('HS003', N'Phạm Văn Hùng', '2016-03-15', N'100 Tân Sơn Nhì', 'phuynh03', 'L102'),
('HS004', N'Ngô Thị Bích Ngọc', '2016-04-20', N'170 Tân Sơn Nhì', 'phuynh04', 'L102'),
('HS005', N'Hoàng Minh Tú', '2016-05-25', N'203 Tân Sơn Nhì', 'phuynh05', 'L103'),
('HS006', N'Bùi Thanh Phương', '2016-06-30', N'243 Tân Sơn Nhì', 'phuynh06', 'L103'),
('HS007', N'Trần Quốc Bảo', '2016-07-05', N'267 Tân Sơn Nhì', 'phuynh07', 'L201'),
('HS008', N'Nguyễn Hoàng Anh', '2016-08-10', N'355 Tân Sơn Nhì', 'phuynh08', 'L201'),
('HS009', N'Phan Thị Mỹ Linh', '2016-09-15', N'378 Tân Sơn Nhì', 'phuynh09', 'L202'),
('HS010', N'Vũ Thị Thanh', '2016-10-20', N'433 Tân Sơn Nhì', 'phuynh10', 'L202'),

-- Phường Phú Thọ Hoà
('HS011', N'Lê Minh Quân', '2016-01-05', N'9 Phú Thọ Hoà', 'phuynh11', 'L301'),
('HS012', N'Nguyễn Hải Đăng', '2016-02-10', N'70 Phú Thọ Hoà', 'phuynh12', 'L301'),
('HS013', N'Trần Nhật Minh', '2016-03-15', N'120 Phú Thọ Hoà', 'phuynh13', 'L302'),
('HS014', N'Bùi Thuỳ Linh', '2016-04-20', N'150 Phú Thọ Hoà', 'phuynh14', 'L302'),
('HS015', N'Phan Quốc Đạt', '2016-05-25', N'156 Phú Thọ Hoà', 'phuynh15', 'L302'),
('HS016', N'Hoàng Anh Thư', '2016-06-30', N'168 Phú Thọ Hoà', 'phuynh16', 'L401'),
('HS017', N'Đặng Minh Hiếu', '2016-07-05', N'223 Phú Thọ Hoà', 'phuynh17', 'L401'),
('HS018', N'Trần Quốc Tuấn', '2016-08-10', N'252 Phú Thọ Hoà', 'phuynh18', 'L401'),
('HS019', N'Lê Thị Thanh Hà', '2016-09-15', N'356 Phú Thọ Hoà', 'phuynh19', 'L402'),
('HS020', N'Nguyễn Thị Thanh Trúc', '2016-10-20', N'400 Phú Thọ Hoà', 'phuynh20', 'L402'),

-- Phường Hiệp Tân
('HS021', N'Nguyễn Quốc Cường', '2016-01-05', N'15 Hiệp Tân', 'phuynh21', 'L101'),
('HS022', N'Phạm Minh Tú', '2016-02-10', N'45 Hiệp Tân', 'phuynh22', 'L101'),
('HS023', N'Lê Hoàng Minh', '2016-03-15', N'79 Hiệp Tân', 'phuynh23', 'L102'),
('HS024', N'Trần Thị Kim Anh', '2016-04-20', N'205 Hiệp Tân', 'phuynh24', 'L102'),
('HS025', N'Nguyễn Minh Quân', '2016-05-25', N'269 Hiệp Tân', 'phuynh25', 'L103'),
('HS026', N'Lê Thị Bảo Ngọc', '2016-06-30', N'366 Hiệp Tân', 'phuynh26', 'L103'),
('HS027', N'Hoàng Anh Khoa', '2016-07-05', N'378 Hiệp Tân', 'phuynh27', 'L201'),
('HS028', N'Phạm Thị Lan', '2016-08-10', N'444 Hiệp Tân', 'phuynh28', 'L201'),
('HS029', N'Trần Nhật Hào', '2016-09-15', N'446 Hiệp Tân', 'phuynh29', 'L202'),
('HS030', N'Ngô Minh Tuấn', '2016-10-20', N'489 Hiệp Tân', 'phuynh30', 'L202'),

-- Phường Tây Thạnh
('HS031', N'Lê Hoàng Quân', '2016-01-05', N'1 Tây Thạnh', 'phuynh31', 'L301'),
('HS032', N'Nguyễn Minh Duy', '2016-02-10', N'50 Tây Thạnh', 'phuynh32', 'L301'),
('HS033', N'Hoàng Quốc Đạt', '2016-03-15', N'60 Tây Thạnh', 'phuynh33', 'L302'),
('HS034', N'Trần Minh Khoa', '2016-04-20', N'120 Tây Thạnh', 'phuynh34', 'L302'),
('HS035', N'Phạm Thị Quỳnh', '2016-05-25', N'166 Tây Thạnh', 'phuynh35', 'L302'),
('HS036', N'Nguyễn Bảo Long', '2016-06-30', N'259 Tây Thạnh', 'phuynh36', 'L401'),
('HS037', N'Lê Quốc Hưng', '2016-07-05', N'299 Tây Thạnh', 'phuynh37', 'L401'),
('HS038', N'Ngô Thị Thu', '2016-08-10', N'355 Tây Thạnh', 'phuynh38', 'L401'),
('HS039', N'Phan Minh Hoàng', '2016-09-15', N'397 Tây Thạnh', 'phuynh39', 'L402'),
('HS040', N'Bùi Quốc Anh', '2016-10-20', N'420 Tây Thạnh', 'phuynh40', 'L402'),
-- Phường Tân Quý
('HS041', N'Nguyễn Văn Tài', '2016-11-05', N'10 Tân Quý', 'phuynh41', 'L101'),
('HS042', N'Lê Thị Thanh Hà', '2016-12-10', N'45 Tân Quý', 'phuynh42', 'L102'),
('HS043', N'Trần Minh Hoàng', '2016-11-15', N'155 Tân Quý', 'phuynh43', 'L103'),
('HS044', N'Phạm Thị Lan Anh', '2016-12-20', N'199 Tân Quý', 'phuynh44', 'L201'),
('HS045', N'Nguyễn Bảo Nam', '2016-11-25', N'256 Tân Quý', 'phuynh45', 'L202'),
('HS046', N'Lê Minh Tuấn', '2016-10-30', N'278 Tân Quý', 'phuynh46', 'L301'),
('HS047', N'Phạm Quốc Hùng', '2016-11-05', N'299 Tân Quý', 'phuynh47', 'L302'),
('HS048', N'Ngô Thị Mỹ Linh', '2016-12-10', N'366 Tân Quý', 'phuynh48', 'L401'),
('HS049', N'Trần Bảo Hân', '2016-12-15', N'369 Tân Quý', 'phuynh49', 'L402'),
('HS050', N'Vũ Hoàng Minh', '2016-11-20', N'400 Tân Quý', 'phuynh50', 'L402');


	-------------------------------------==========================================
-- Bảng LoTrinh
INSERT INTO LoTrinh (LoTrinh_ID, Bus_ID, GioKhoiHanh, GioKetThuc)
VALUES 
    ('LT001', 'BUS001', '06:30', '07:10'),
    ('LT002', 'BUS002', '06:30', '07:10'),
    ('LT003', 'BUS003', '06:30', '07:10'),
	('LT004', 'BUS004', '06:30', '07:10'),
    ('LT005', 'BUS005', '06:30', '07:10')
	
	
	delete  LoTrinh
	-------------------------------------==========================================

-- Bảng DiemDung
INSERT INTO DiemDung (DiemDung_ID, ViTri) VALUES
-- Phường Tân Sơn Nhì
('DD001', N'15 Tân Sơn Nhì'),
('DD002', N'140 Tân Sơn Nhì'),
('DD003', N'244 Tân Sơn Nhì'),
('DD004', N'380 Tân Sơn Nhì'),

-- Phường Phú Thọ Hoà
('DD005', N'40 Phú Thọ Hoà'),
('DD006', N'155 Phú Thọ Hoà'),
('DD007', N'235 Phú Thọ Hoà'),
('DD008', N'370 Phú Thọ Hoà'),

-- Phường Hiệp Tân
('DD009', N'50 Hiệp Tân'),
('DD010', N'230 Hiệp Tân'),
('DD011', N'370 Hiệp Tân'),
('DD012', N'455 Hiệp Tân'),

-- Phường Tây Thạnh
('DD013', N'36 Tây Thạnh'),
('DD014', N'143 Tây Thạnh'),
('DD015', N'275 Tây Thạnh'),
('DD016', N'382 Tây Thạnh'),

-- Phường Tân Quý
('DD017', N'30 Tân Quý'),
('DD018', N'170 Tân Quý'),
('DD019', N'280 Tân Quý'),
('DD020', N'378 Tân Quý');

	delete DiemDung
	-------------------------------------==========================================

-- Bảng DiemDanh
INSERT INTO DiemDanh (DiemDanh_ID, Bus_ID, NgayDiemDanh, TrangThai)
VALUES 
	('DD002', 'BUS002', '2024-10-10', N'Chưa hoàn thành'),
	('DD001', 'BUS001', '2024-10-10', N'Hoàn thành'),
	('DD003', 'BUS001', '2024-10-11', N'Hoàn thành'),
    ('DD004', 'BUS001', '2024-10-12', N'Hoàn thành'),
    ('DD005', 'BUS001', '2024-10-13', N'Hoàn thành'),
    ('DD006', 'BUS001', '2024-10-14', N'Hoàn thành'),
    ('DD007', 'BUS001', '2024-10-15', N'Hoàn thành');
	select * from XeBus
	-------------------------------------==========================================

-- Bảng ChiTietDiemDanh
INSERT INTO ChiTietDiemDanhDi (CTDDD_ID, DiemDanh_ID, HocSinh_ID, DiemLenXe, DiemXuongXe, GioLenXe, GioXuongXe, TrangThai)
VALUES 
	('DI001', 'DD001', 'HS001', N'123 Lũy Bán Bích', N'140 Lê Trọng Tấn', '06:30', '07:10', N'Có mặt'),
	('DI002', 'DD001', 'HS002', N'300 Lũy Bán Bích', N'140 Lê Trọng Tấn', '06:30', '07:10', N'Có mặt'),
	('DI003', 'DD002', 'HS003', N'700 Lũy Bán Bích', N'140 Lê Trọng Tấn', '06:45', '07:10', N'Có mặt')
INSERT INTO ChiTietDiemDanhDi (CTDDD_ID, DiemDanh_ID, HocSinh_ID, DiemLenXe, DiemXuongXe, GioLenXe, GioXuongXe, TrangThai)
VALUES 
-- Học sinh thuộc Phường Tân Sơn Nhì
('DI001', 'DD001', 'HS001', N'15 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:30', '07:10', N'Có mặt'),
('DI002', 'DD001', 'HS002', N'15 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:35', '07:10', N'Có mặt'),
('DI003', 'DD001', 'HS003', N'140 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:40', '07:10', N'Có mặt'),
('DI004', 'DD001', 'HS004', N'140 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:45', '07:10', N'Có mặt'),
('DI005', 'DD001', 'HS005', N'244 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:50', '07:10', N'Có mặt'),
('DI006', 'DD001', 'HS006', N'244 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:30', '07:10', N'Có mặt'),
('DI007', 'DD001', 'HS007', N'244 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:35', '07:10', N'Có mặt'),
('DI008', 'DD001', 'HS008', N'244 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:40', '07:10', N'Có mặt'),
('DI009', 'DD001', 'HS009', N'380 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:45', '07:10', N'Có mặt'),
('DI010', 'DD001', 'HS010', N'380 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:50', '07:10', N'Có mặt');

-- Dữ liệu cho DiemDanh_ID = DD003
INSERT INTO ChiTietDiemDanhDi (CTDDD_ID, DiemDanh_ID, HocSinh_ID, DiemLenXe, DiemXuongXe, GioLenXe, GioXuongXe, TrangThai)
VALUES 
('DI011', 'DD003', 'HS001', N'15 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:30', '07:10', N'Có mặt'),
('DI012', 'DD003', 'HS002', N'15 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:35', '07:10', N'Có mặt'),
('DI013', 'DD003', 'HS003', N'140 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:40', '07:10', N'Có mặt'),
('DI014', 'DD003', 'HS004', N'140 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:45', '07:10', N'Có mặt'),
('DI015', 'DD003', 'HS005', N'244 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:50', '07:10', N'Có mặt'),
('DI016', 'DD003', 'HS006', N'244 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:30', '07:10', N'Có mặt'),
('DI017', 'DD003', 'HS007', N'244 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:35', '07:10', N'Có mặt'),
('DI018', 'DD003', 'HS008', N'244 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:40', '07:10', N'Có mặt'),
('DI019', 'DD003', 'HS009', N'380 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:45', '07:10', N'Có mặt'),
('DI020', 'DD003', 'HS010', N'380 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:50', '07:10', N'Có mặt');

-- Dữ liệu cho DiemDanh_ID = DD004
INSERT INTO ChiTietDiemDanhDi (CTDDD_ID, DiemDanh_ID, HocSinh_ID, DiemLenXe, DiemXuongXe, GioLenXe, GioXuongXe, TrangThai)
VALUES 
('DI021', 'DD004', 'HS001', N'15 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:30', '07:10', N'Có mặt'),
('DI022', 'DD004', 'HS002', N'15 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:35', '07:10', N'Có mặt'),
('DI023', 'DD004', 'HS003', N'140 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:40', '07:10', N'Có mặt'),
('DI024', 'DD004', 'HS004', N'140 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:45', '07:10', N'Có mặt'),
('DI025', 'DD004', 'HS005', N'244 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:50', '07:10', N'Có mặt'),
('DI026', 'DD004', 'HS006', N'244 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:30', '07:10', N'Có mặt'),
('DI027', 'DD004', 'HS007', N'244 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:35', '07:10', N'Có mặt'),
('DI028', 'DD004', 'HS008', N'244 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:40', '07:10', N'Có mặt'),
('DI029', 'DD004', 'HS009', N'380 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:45', '07:10', N'Có mặt'),
('DI030', 'DD004', 'HS010', N'380 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:50', '07:10', N'Có mặt');

-- Dữ liệu cho DiemDanh_ID = DD005
INSERT INTO ChiTietDiemDanhDi (CTDDD_ID, DiemDanh_ID, HocSinh_ID, DiemLenXe, DiemXuongXe, GioLenXe, GioXuongXe, TrangThai)
VALUES 
('DI031', 'DD005', 'HS001', N'15 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:30', '07:10', N'Có mặt'),
('DI032', 'DD005', 'HS002', N'15 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:35', '07:10', N'Có mặt'),
('DI033', 'DD005', 'HS003', N'140 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:40', '07:10', N'Có mặt'),
('DI034', 'DD005', 'HS004', N'140 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:45', '07:10', N'Có mặt'),
('DI035', 'DD005', 'HS005', N'244 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:50', '07:10', N'Có mặt'),
('DI036', 'DD005', 'HS006', N'244 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:30', '07:10', N'Có mặt'),
('DI037', 'DD005', 'HS007', N'244 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:35', '07:10', N'Có mặt'),
('DI038', 'DD005', 'HS008', N'244 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:40', '07:10', N'Có mặt'),
('DI039', 'DD005', 'HS009', N'380 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:45', '07:10', N'Có mặt'),
('DI040', 'DD005', 'HS010', N'380 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:50', '07:10', N'Có mặt');

-- Dữ liệu cho DiemDanh_ID = DD006
INSERT INTO ChiTietDiemDanhDi (CTDDD_ID, DiemDanh_ID, HocSinh_ID, DiemLenXe, DiemXuongXe, GioLenXe, GioXuongXe, TrangThai)
VALUES 
('DI041', 'DD006', 'HS001', N'15 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:30', '07:10', N'Có mặt'),
('DI042', 'DD006', 'HS002', N'15 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:35', '07:10', N'Có mặt'),
('DI043', 'DD006', 'HS003', N'140 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:40', '07:10', N'Có mặt'),
('DI044', 'DD006', 'HS004', N'140 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:45', '07:10', N'Có mặt'),
('DI045', 'DD006', 'HS005', N'244 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:50', '07:10', N'Có mặt'),
('DI046', 'DD006', 'HS006', N'244 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:30', '07:10', N'Có mặt'),
('DI047', 'DD006', 'HS007', N'244 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:35', '07:10', N'Có mặt'),
('DI048', 'DD006', 'HS008', N'244 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:40', '07:10', N'Có mặt'),
('DI049', 'DD006', 'HS009', N'380 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:45', '07:10', N'Có mặt'),
('DI050', 'DD006', 'HS010', N'380 Tân Sơn Nhì', N'140 Lê Trọng Tấn', '06:50', '07:10', N'Có mặt');


	-------------------------------------==========================================
-- Bảng ChiTietDiemDanhVe
INSERT INTO ChiTietDiemDanhVe (CTDDV_ID, DiemDanh_ID, HocSinh_ID, DiemLenXe, DiemXuongXe, GioLenXe, GioXuongXe, TrangThai)
VALUES 
	('VE001', 'DD001', 'HS001', N'140 Lê Trọng Tấn', N'123 Lũy Bán Bích', '17:00', '17:40', N'Có mặt'),
	('VE002', 'DD001', 'HS002', N'140 Lê Trọng Tấn', N'300 Lũy Bán Bích', '06:30', '17:35', N'Có mặt'),
	('VE003', 'DD002', 'HS003', N'140 Lê Trọng Tấn', N'700 Lũy Bán Bích', '06:45', '17:30', N'Có mặt')

INSERT INTO ChiTietDiemDanhVe (CTDDV_ID, DiemDanh_ID, HocSinh_ID, DiemLenXe, DiemXuongXe, GioLenXe, GioXuongXe, TrangThai)
VALUES 
-- Học sinh thuộc Phường Tân Sơn Nhì (Phiếu điểm danh về)
('VE001', 'DD001', 'HS001', N'140 Lê Trọng Tấn', N'15 Tân Sơn Nhì', '16:30', '16:40', N'Có mặt'),
('VE002', 'DD001', 'HS002', N'140 Lê Trọng Tấn', N'15 Tân Sơn Nhì', '16:30', '16:40', N'Có mặt'),
('VE003', 'DD001', 'HS003', N'140 Lê Trọng Tấn', N'140 Tân Sơn Nhì', '16:30', '16:50', N'Có mặt'),
('VE004', 'DD001', 'HS004', N'140 Lê Trọng Tấn', N'140 Tân Sơn Nhì', '16:30', '16:50', N'Có mặt'),
('VE005', 'DD001', 'HS005', N'140 Lê Trọng Tấn', N'244 Tân Sơn Nhì', '16:30', '17:00', N'Có mặt'),
('VE006', 'DD001', 'HS006', N'140 Lê Trọng Tấn', N'244 Tân Sơn Nhì', '16:30', '17:00', N'Có mặt'),
('VE007', 'DD001', 'HS007', N'140 Lê Trọng Tấn', N'244 Tân Sơn Nhì', '16:30', '17:00', N'Có mặt'),
('VE008', 'DD001', 'HS008', N'140 Lê Trọng Tấn', N'244 Tân Sơn Nhì', '16:30', '17:00', N'Có mặt'),
('VE009', 'DD001', 'HS009', N'140 Lê Trọng Tấn', N'380 Tân Sơn Nhì', '16:30', '17:05', N'Có mặt'),
('VE010', 'DD001', 'HS010', N'140 Lê Trọng Tấn', N'380 Tân Sơn Nhì', '16:30', '17:05', N'Có mặt');


	-------------------------------------==========================================


-- Bảng ChiTietLoTrinhXe
INSERT INTO ChiTietLoTrinhXe (CTLT_ID, LoTrinh_ID, DiemDung_ID, ThuTu, ThoiGianDung)
VALUES 
    ('CTLT001', 'LT001', 'DD001', 1, '06:30'),
    ('CTLT002', 'LT001', 'DD002', 2, '06:45'),
    ('CTLT003', 'LT001', 'DD003', 3, '07:00'),
    ('CTLT004', 'LT001', 'DD004', 4, '07:05'),
	('CTLT005', 'LT001', 'DKT', 5, '07:10')

	-- Phường Phú Thọ Hoà
INSERT INTO ChiTietLoTrinhXe (CTLT_ID, LoTrinh_ID, DiemDung_ID, ThuTu, ThoiGianDung)
VALUES 
    ('CTLT006', 'LT002', 'DD005', 1, '06:30'),
    ('CTLT007', 'LT002', 'DD006', 2, '06:45'),
    ('CTLT008', 'LT002', 'DD007', 3, '07:00'),
    ('CTLT009', 'LT002', 'DD008', 4, '07:05'),
    ('CTLT010', 'LT002', 'DKT', 5, '07:10');

-- Phường Hiệp Tân
INSERT INTO ChiTietLoTrinhXe (CTLT_ID, LoTrinh_ID, DiemDung_ID, ThuTu, ThoiGianDung)
VALUES 
    ('CTLT011', 'LT003', 'DD009', 1, '06:30'),
    ('CTLT012', 'LT003', 'DD010', 2, '06:45'),
    ('CTLT013', 'LT003', 'DD011', 3, '07:00'),
    ('CTLT014', 'LT003', 'DD012', 4, '07:05'),
    ('CTLT015', 'LT003', 'DKT', 5, '07:10');

-- Phường Tây Thạnh
INSERT INTO ChiTietLoTrinhXe (CTLT_ID, LoTrinh_ID, DiemDung_ID, ThuTu, ThoiGianDung)
VALUES 
    ('CTLT016', 'LT004', 'DD013', 1, '06:30'),
    ('CTLT017', 'LT004', 'DD014', 2, '06:45'),
    ('CTLT018', 'LT004', 'DD015', 3, '07:00'),
    ('CTLT019', 'LT004', 'DD016', 4, '07:05'),
    ('CTLT020', 'LT004', 'DKT', 5, '07:10');

-- Phường Tân Quý
INSERT INTO ChiTietLoTrinhXe (CTLT_ID, LoTrinh_ID, DiemDung_ID, ThuTu, ThoiGianDung)
VALUES 
    ('CTLT021', 'LT005', 'DD017', 1, '06:30'),
    ('CTLT022', 'LT005', 'DD018', 2, '06:45'),
    ('CTLT023', 'LT005', 'DD019', 3, '07:00'),
    ('CTLT024', 'LT005', 'DD020', 4, '07:05'),
    ('CTLT025', 'LT005', 'DKT', 5, '07:10');

	
	-------------------------------------==========================================


-- Bảng HopDongXeBus
INSERT INTO HopDongXeBus (HD_ID, PhuHuynh_ID, ChiPhi, ThoiGianBatDau, ThoiGianKetThuc, TrangThai)
VALUES 
	('HD001', 'vananpro', 500000, '2024-01-01', '2024-12-31', N'Hoạt động'),
	('HD002', 'lebichh', 450000, '2024-03-01', '2024-12-31', N'Hoạt động'),
	('HD003', 'khoaminh88', 550000, '2024-05-01', '2024-12-31', N'Hoạt động');

	-------------------------------------==========================================


-- Phường Tân Sơn Nhì - Xe BUS001
INSERT INTO ChiTietDanhSachHocSinh (CT_DSHS_ID, Bus_ID, HocSinh_ID)
VALUES
('CTDSHS001', 'BUS001', 'HS001'),
('CTDSHS002', 'BUS001', 'HS002'),
('CTDSHS003', 'BUS001', 'HS003'),
('CTDSHS004', 'BUS001', 'HS004'),
('CTDSHS005', 'BUS001', 'HS005'),
('CTDSHS006', 'BUS001', 'HS006'),
('CTDSHS007', 'BUS001', 'HS007'),
('CTDSHS008', 'BUS001', 'HS008'),
('CTDSHS009', 'BUS001', 'HS009'),
('CTDSHS010', 'BUS001', 'HS010');
select top 1 * from ChiTietDanhSachHocSinh where CT_DSHS_ID like  order by CT_DSHS_ID desc
-- Phường Phú Thọ Hoà - Xe BUS002
INSERT INTO ChiTietDanhSachHocSinh (CT_DSHS_ID, Bus_ID, HocSinh_ID)
VALUES
('CTDSHS011', 'BUS002', 'HS011'),
('CTDSHS012', 'BUS002', 'HS012'),
('CTDSHS013', 'BUS002', 'HS013'),
('CTDSHS014', 'BUS002', 'HS014'),
('CTDSHS015', 'BUS002', 'HS015'),
('CTDSHS016', 'BUS002', 'HS016'),
('CTDSHS017', 'BUS002', 'HS017'),
('CTDSHS018', 'BUS002', 'HS018'),
('CTDSHS019', 'BUS002', 'HS019'),
('CTDSHS020', 'BUS002', 'HS020');

-- Phường Hiệp Tân - Xe BUS003
INSERT INTO ChiTietDanhSachHocSinh (CT_DSHS_ID, Bus_ID, HocSinh_ID)
VALUES
('CTDSHS021', 'BUS003', 'HS021'),
('CTDSHS022', 'BUS003', 'HS022'),
('CTDSHS023', 'BUS003', 'HS023'),
('CTDSHS024', 'BUS003', 'HS024'),
('CTDSHS025', 'BUS003', 'HS025'),
('CTDSHS026', 'BUS003', 'HS026'),
('CTDSHS027', 'BUS003', 'HS027'),
('CTDSHS028', 'BUS003', 'HS028'),
('CTDSHS029', 'BUS003', 'HS029'),
('CTDSHS030', 'BUS003', 'HS030');

-- Phường Tây Thạnh - Xe BUS004
INSERT INTO ChiTietDanhSachHocSinh (CT_DSHS_ID, Bus_ID, HocSinh_ID)
VALUES
('CTDSHS031', 'BUS004', 'HS031'),
('CTDSHS032', 'BUS004', 'HS032'),
('CTDSHS033', 'BUS004', 'HS033'),
('CTDSHS034', 'BUS004', 'HS034'),
('CTDSHS035', 'BUS004', 'HS035'),
('CTDSHS036', 'BUS004', 'HS036'),
('CTDSHS037', 'BUS004', 'HS037'),
('CTDSHS038', 'BUS004', 'HS038'),
('CTDSHS039', 'BUS004', 'HS039'),
('CTDSHS040', 'BUS004', 'HS040');

-- Phường Tân Quý - Xe BUS005
INSERT INTO ChiTietDanhSachHocSinh (CT_DSHS_ID, Bus_ID, HocSinh_ID)
VALUES
('CTDSHS041', 'BUS005', 'HS041'),
('CTDSHS042', 'BUS005', 'HS042'),
('CTDSHS043', 'BUS005', 'HS043'),
('CTDSHS044', 'BUS005', 'HS044'),
('CTDSHS045', 'BUS005', 'HS045'),
('CTDSHS046', 'BUS005', 'HS046'),
('CTDSHS047', 'BUS005', 'HS047'),
('CTDSHS048', 'BUS005', 'HS048'),
('CTDSHS049', 'BUS005', 'HS049'),
('CTDSHS050', 'BUS005', 'HS050');

	-------------------------------------==========================================

-- Phường Tân Sơn Nhì
INSERT INTO ChiTietHocSinhDiemDung (CT_HSDD_ID, DiemDung_ID, HocSinh_ID)
VALUES 
('CTHSDD001', 'DD001', 'HS001'),
('CTHSDD002', 'DD001', 'HS002'),
('CTHSDD003', 'DD002', 'HS003'),
('CTHSDD004', 'DD002', 'HS004'),
('CTHSDD005', 'DD002', 'HS005'),
('CTHSDD006', 'DD003', 'HS006'),
('CTHSDD007', 'DD003', 'HS007'),
('CTHSDD008', 'DD004', 'HS008'),
('CTHSDD009', 'DD004', 'HS009'),
('CTHSDD010', 'DD004', 'HS010');

-- Phường Phú Thọ Hoà
INSERT INTO ChiTietHocSinhDiemDung (CT_HSDD_ID, DiemDung_ID, HocSinh_ID)
VALUES 
('CTHSDD011', 'DD005', 'HS011'),
('CTHSDD012', 'DD005', 'HS012'),
('CTHSDD013', 'DD005', 'HS013'),
('CTHSDD014', 'DD006', 'HS014'),
('CTHSDD015', 'DD006', 'HS015'),
('CTHSDD016', 'DD006', 'HS016'),
('CTHSDD017', 'DD007', 'HS017'),
('CTHSDD018', 'DD007', 'HS018'),
('CTHSDD019', 'DD008', 'HS019'),
('CTHSDD020', 'DD008', 'HS020');

-- Phường Hiệp Tân
INSERT INTO ChiTietHocSinhDiemDung (CT_HSDD_ID, DiemDung_ID, HocSinh_ID)
VALUES 
('CTHSDD021', 'DD009', 'HS021'),
('CTHSDD022', 'DD009', 'HS022'),
('CTHSDD023', 'DD009', 'HS023'),
('CTHSDD024', 'DD010', 'HS024'),
('CTHSDD025', 'DD010', 'HS025'),
('CTHSDD026', 'DD010', 'HS026'),
('CTHSDD027', 'DD011', 'HS027'),
('CTHSDD028', 'DD011', 'HS028'),
('CTHSDD029', 'DD012', 'HS029'),
('CTHSDD030', 'DD012', 'HS030');

-- Phường Tây Thạnh
INSERT INTO ChiTietHocSinhDiemDung (CT_HSDD_ID, DiemDung_ID, HocSinh_ID)
VALUES 
('CTHSDD031', 'DD013', 'HS031'),
('CTHSDD032', 'DD013', 'HS032'),
('CTHSDD033', 'DD013', 'HS033'),
('CTHSDD034', 'DD014', 'HS034'),
('CTHSDD035', 'DD014', 'HS035'),
('CTHSDD036', 'DD015', 'HS036'),
('CTHSDD037', 'DD015', 'HS037'),
('CTHSDD038', 'DD016', 'HS038'),
('CTHSDD039', 'DD016', 'HS039'),
('CTHSDD040', 'DD016', 'HS040');

-- Phường Tân Quý
INSERT INTO ChiTietHocSinhDiemDung (CT_HSDD_ID, DiemDung_ID, HocSinh_ID)
VALUES 
('CTHSDD041', 'DD017', 'HS041'),
('CTHSDD042', 'DD017', 'HS042'),
('CTHSDD043', 'DD017', 'HS043'),
('CTHSDD044', 'DD018', 'HS044'),
('CTHSDD045', 'DD018', 'HS045'),
('CTHSDD046', 'DD018', 'HS046'),
('CTHSDD047', 'DD019', 'HS047'),
('CTHSDD048', 'DD019', 'HS048'),
('CTHSDD049', 'DD020', 'HS049'),
('CTHSDD050', 'DD020', 'HS050');


	-------------------------------------==========================================

select * from taixe

	select * from TaiXe
	select * from TaiKhoan
	select * from ChiTietDanhSachHocSinh
