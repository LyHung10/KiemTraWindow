USE [DoAnWin]
GO
/****** Object:  Table [dbo].[Job]    Script Date: 4/25/2024 11:49:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Job](
	[IDNguoiThue] [nvarchar](50) NULL,
	[TenNguoiThue] [nvarchar](max) NULL,
	[IDNguoiLam] [nvarchar](50) NULL,
	[TenNguoiLam] [nvarchar](max) NULL,
	[MaCV] [nvarchar](50) NULL,
	[MoTaCV] [nvarchar](max) NULL,
	[TrangThaiCV] [nvarchar](max) NULL,
	[DanhGia] [nvarchar](50) NULL,
	[BinhLuan] [nvarchar](max) NULL,
	[NgayLam] [nvarchar](50) NULL,
	[Luong] [int] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 4/25/2024 11:49:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[ID] [nvarchar](10) NOT NULL,
	[Ten] [nvarchar](max) NULL,
	[GioiTinh] [nvarchar](max) NULL,
	[SDT] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[CCCD] [nvarchar](max) NULL,
	[NgaySinh] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[STK] [nvarchar](max) NULL,
	[SoDU] [nvarchar](max) NULL,
	[ID_nguoi_thue] [nvarchar](max) NULL,
	[TenNguoiThue] [nvarchar](max) NULL,
	[DanhGia] [nvarchar](max) NULL,
	[BinhLuan] [nvarchar](max) NULL,
	[TenTaiKhoan] [nvarchar](max) NULL,
	[MatKhau] [nvarchar](max) NULL,
	[VaiTro] [nvarchar](max) NULL,
	[Avatar] [nvarchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Worker]    Script Date: 4/25/2024 11:49:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Worker](
	[ID] [nvarchar](50) NOT NULL,
	[Ten] [nvarchar](max) NULL,
	[GioiTinh] [nvarchar](max) NULL,
	[SDT] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[CCCD] [nvarchar](max) NULL,
	[NgaySinh] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[STK] [nvarchar](max) NULL,
	[SoDU] [nvarchar](max) NULL,
	[LuotThue] [nvarchar](max) NULL,
	[TenTaiKhoan] [nvarchar](max) NOT NULL,
	[MatKhau] [nvarchar](max) NOT NULL,
	[VaiTro] [nvarchar](max) NOT NULL,
	[DanhGiaTrungBinh] [nvarchar](max) NULL,
	[TrangThai] [nvarchar](max) NULL,
	[DangThongTin] [nvarchar](3) NULL,
	[NamKinhNghiem] [nvarchar](20) NULL,
	[GiaThue] [nvarchar](100) NULL,
	[NgheNghiep] [nvarchar](max) NULL,
	[MoTa] [nvarchar](max) NULL,
	[Avatar] [nvarchar](max) NULL,
 CONSTRAINT [PK_worker] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkerUploadImage]    Script Date: 4/25/2024 11:49:53 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkerUploadImage](
	[ID] [nvarchar](50) NULL,
	[Image] [nvarchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong]) VALUES (N'100012', N'test1', N'200050', N'test2', N'300016', N'', N'Hoàn thành', N'0', NULL, N'21 4 2024', 19999999)
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong]) VALUES (N'100012', N'test1', N'200005', N'test2', N'300016', N'', N'Hoàn thành', N'0', NULL, N'22 4 2024', 19999999)
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong]) VALUES (N'100012', N'test1', N'200006', N'Nguyễn Văn A', N'300045', N'về làm cho anh đi em', N'Đang làm', N'0', NULL, N'23 4 2024', 60000)
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong]) VALUES (N'100012', N'test1', N'200050', N'test2', N'300097', N'', N'Hoàn thành', N'0', NULL, N'24 4 2024', 20000)
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong]) VALUES (N'100012', N'test1', N'200050', N'test2', N'300097', N'', N'Hoàn thành', N'0', NULL, N'25 4 2024', 20000)
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong]) VALUES (N'100083', N'lyhung', N'200008', N'Hoàng Thị H', N'300200', N'', N'Hoàn thành', N'0', NULL, N'24 4 2024', 12345)
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong]) VALUES (N'100083', N'lyhung', N'200006', N'Nguyễn Thị F', N'300092', N'', N'Hoàn thành', N'0', NULL, N'29 4 2024', 12345)
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong]) VALUES (N'100083', N'lyhung', N'200008', N'Hoàng Thị H', N'300092', N'', N'Hoàn thành', N'0', NULL, N'30 4 2024', 12345)
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong]) VALUES (N'100083', N'lyhung', N'200057', N'Chi Pheo', N'300078', N'Lam việc tốt', N'Hoàn thành', N'2', NULL, N'30 4 2024', 254669)
INSERT [dbo].[Job] ([IDNguoiThue], [TenNguoiThue], [IDNguoiLam], [TenNguoiLam], [MaCV], [MoTaCV], [TrangThaiCV], [DanhGia], [BinhLuan], [NgayLam], [Luong]) VALUES (N'100083', N'lyhung', N'200100', N'Xenxiel', N'300100', NULL, N'Hoàn thành', N'0', NULL, NULL, 265165)
GO
INSERT [dbo].[NguoiDung] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [ID_nguoi_thue], [TenNguoiThue], [DanhGia], [BinhLuan], [TenTaiKhoan], [MatKhau], [VaiTro], [Avatar]) VALUES (N'100012', N'test1', NULL, N'0123456789', NULL, NULL, NULL, N'test1@gmail.com', NULL, N'10000000000000', NULL, NULL, NULL, NULL, N'test1', N'12345', N'Người dùng', NULL)
INSERT [dbo].[NguoiDung] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [ID_nguoi_thue], [TenNguoiThue], [DanhGia], [BinhLuan], [TenTaiKhoan], [MatKhau], [VaiTro], [Avatar]) VALUES (N'100016', N'Thị Nở', NULL, N'234', NULL, NULL, NULL, N'thino@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL, N'ThiNo10', N'123', N'Người dùng', NULL)
INSERT [dbo].[NguoiDung] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [ID_nguoi_thue], [TenNguoiThue], [DanhGia], [BinhLuan], [TenTaiKhoan], [MatKhau], [VaiTro], [Avatar]) VALUES (N'100062', N'Nguyen Van A', NULL, N'123', NULL, NULL, NULL, N'qwe@gmail.com', NULL, N'0', NULL, NULL, NULL, NULL, N'lyhung11', N'123', N'Người dùng', NULL)
INSERT [dbo].[NguoiDung] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [ID_nguoi_thue], [TenNguoiThue], [DanhGia], [BinhLuan], [TenTaiKhoan], [MatKhau], [VaiTro], [Avatar]) VALUES (N'100076', N'lyhung', NULL, N'123', NULL, NULL, NULL, N'123@gmail.com', NULL, NULL, NULL, NULL, NULL, NULL, N'lyhung', N'123', N'Người dùng', NULL)
INSERT [dbo].[NguoiDung] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [ID_nguoi_thue], [TenNguoiThue], [DanhGia], [BinhLuan], [TenTaiKhoan], [MatKhau], [VaiTro], [Avatar]) VALUES (N'100083', N'lyhung', NULL, N'123', NULL, NULL, NULL, N'ABC@gmail.com', NULL, N'500000', NULL, NULL, NULL, NULL, N'lyhung', N'123', N'Người dùng', NULL)
GO
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar]) VALUES (N'200001', N'Nguyễn Văn A', N'Nam', N'0123456789', N'Hà Nội', N'123456789', N'1990-01-01', N'nguyenvana@example.com', N'1234567890', N'5000000', N'2', N'A', N'@123', N'Thợ', N'5', N'Hoạt động', N'1', N'6', N'456', N'Thợ sơn', N'tay to', NULL)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar]) VALUES (N'200002', N'Nguyễn Thị B', N'Nữ', N'45426557527', N'Hồ Chí Minh', N'987654321', N'5/5/1995 12:00:00 AM', N'nguyenthib@gmail.com', N'0987654321', N'3000000', N'3', N'B', N'@123', N'Thợ', N'4', N'Hoạt động', N'1', N'3', N'70000', N'Thợ máy', N'Kinh nghiệm đầy mình', NULL)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar]) VALUES (N'200003', N'Phạm Văn C', N'Nam', N'0123456789', N'Ninh Bình', N'123456789', N'3/15/1985 12:00:00 AM', N'phamvanc@gmail.com', N'1234567890', N'4000000', N'4', N'C', N'@123', N'Thợ', N'4.5', N'Hoạt động', N'1', N'4', N'65000', N'Thợ máy', N'Không một điểm yếu', NULL)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar]) VALUES (N'200004', N'Trần Thị D', N'Nữ', N'0123456789', N'Đà Nẵng', N'123456789', N'1993-10-20', N'trand@example.com', N'1234567890', N'6000000', N'5', N'D', N'@123', N'Thợ', N'4', N'Hoạt động', N'1', N'1', N'50000', N'Thợ máy', N'Hả', NULL)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar]) VALUES (N'200005', N'Lê Văn E', N'Nam', N'0123456789', N'Cần Thơ', N'123456789', N'1991-08-18', N'levane@example.com', N'1234567890', N'4500000', N'3', N'E', N'@123', N'Thợ', N'3.5', N'Hoạt động', N'1', N'2', N'80000', N'Thợ sơn', N'OMG', NULL)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar]) VALUES (N'200006', N'Nguyễn Thị F', N'Nữ', N'0987654321', N'Hải Dương', N'987654321', N'1994-09-25', N'nguyenthif@gmail.com', N'0987654321', N'3500000', N'3', N'F', N'@123', N'Thợ', N'4.2', N'Hoạt động', N'1', N'6', N'90000', N'Thợ máy', N'Có nhiều năm trong nghề', NULL)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar]) VALUES (N'200007', N'Trần Văn G', N'Nam', N'0123456789', N'Vũng Tàu', N'123456789', N'1992-06-30', N'tranvg@gmail.com', N'1234567890', N'5500000', N'4', N'G', N'@123', N'Thợ', N'4.6', N'Hoạt động', N'1', N'5', N'56000', N'Thợ máy', N'Có nhi?u kinh nghi?m', NULL)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar]) VALUES (N'200008', N'Hoàng Thị H', N'Nữ', N'0123456789', N'Quảng Ninh', N'123456789', N'1988-12-10', N'hoangthih@gmail.com', N'1234567890', N'4500000', N'5', N'H', N'@123', N'Thợ', N'3.8', N'Hoạt động', N'1', N'6', N'12345', N'Thợ sơn', N'huhu', NULL)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar]) VALUES (N'200009', N'Lê Văn I', N'Nam', N'0123456789', N'Bình Dương', N'123456789', N'1996-03-20', N'levani@gmail.com', N'1234567890', N'4800000', N'3', N'I', N'@123', N'Thợ', N'4.1', N'Hoạt động', N'1', N'3', N'75000', N'Thợ máy', N'', NULL)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar]) VALUES (N'200010', N'Phạm Thị K', N'Nữ', N'0123456789', N'Long An', N'123456789', N'1997-07-15', N'phamthik@gmail.com', N'1234567890', N'3200000', N'4', N'K', N'@123', N'Thợ', N'3.9', N'Hoạt động', N'1', N'2', N'57000', N'Thợ sơn', N'', NULL)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar]) VALUES (N'200044', N'lâm', N'Nam', N'4589787', NULL, NULL, N'1993-10-20', N'lam@gmail.com', NULL, NULL, N'1', N'lam6677', N'789', N'Thợ', N'4.2', N'Hoạt động', N'1', N'8', N'51355', N'Thợ máy', NULL, NULL)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar]) VALUES (N'200050', N'test2', N'Nam', N'0123456789', N'Hà Nội', N'07220400', N'8/5/2004 12:00:00 AM', N'test2@gmail.com', NULL, NULL, NULL, N'test2', N'12345', N'Thợ', N'5', N'Hoạt động', N'1', N'5', N'200000', N'Thợ sơn', N'tao có nhiều thứ lắm', N'C:\DoAnWin\DoAnWin\DoAnWin\Image\123.jpg')
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar]) VALUES (N'200057', N'Chi Pheo', N'Nam', N'123456', N'Hà Nội', N'13245646', N'1997-07-15', N'Pheo@gmail.com', N'215448646', NULL, N'2', N'ChiPheo123', N'12345', N'Thợ', N'2', N'Hoạt động', N'1', N'8', N'5165', N'Thợ máy', NULL, NULL)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar]) VALUES (N'200092', N'test3', NULL, N'0123456789', NULL, NULL, NULL, N'lam@gmail.com', NULL, NULL, NULL, N'test33', N'123', N'Thợ', N'1.5', N'Hoạt động', N'1', N'7', N'464615', N'Thợ máy', NULL, NULL)
INSERT [dbo].[Worker] ([ID], [Ten], [GioiTinh], [SDT], [DiaChi], [CCCD], [NgaySinh], [Email], [STK], [SoDU], [LuotThue], [TenTaiKhoan], [MatKhau], [VaiTro], [DanhGiaTrungBinh], [TrangThai], [DangThongTin], [NamKinhNghiem], [GiaThue], [NgheNghiep], [MoTa], [Avatar]) VALUES (N'200100', N'Xenxiel', N'Nam', N'0123456789', N'Hà Nội', N'07220400', N'8/10/2004 1:48:58 PM', N'test3@gmail.com', NULL, NULL, N'7', N'test3', N'123', N'Thợ', N'3.6', N'Hoạt động', N'1', N'4', N'565456', N'Thợ máy', NULL, NULL)
GO
ALTER TABLE [dbo].[Job] ADD  DEFAULT ('0') FOR [DanhGia]
GO
