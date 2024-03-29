USE [QUANLYKHO]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 1/4/2022 10:12:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[TaiKhoan] [varchar](50) NOT NULL,
	[MatKhau] [varchar](50) NULL,
	[LoaiTaiKhoan] [nvarchar](50) NULL,
	[TenNhanVien] [nvarchar](255) NULL,
	[SoDienThoai] [nchar](10) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[Email] [nvarchar](50) NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[TaiKhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DatHang]    Script Date: 1/4/2022 10:12:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DatHang](
	[MaDatHang] [nvarchar](50) NULL,
	[TenDaiLy] [nvarchar](255) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[SoDienThoai] [nvarchar](255) NULL,
	[ThanhToan] [nvarchar](255) NULL,
	[NgayDatHang] [date] NULL,
	[MaSanPham] [nvarchar](50) NULL,
	[TenSanPham] [nvarchar](255) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
	[TongTien] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhapKho]    Script Date: 1/4/2022 10:12:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhapKho](
	[STTSanPham] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuNhap] [nvarchar](50) NULL,
	[TenNhanVien] [nvarchar](255) NULL,
	[NgayNhapkho] [date] NULL,
	[MaSanPham] [nvarchar](50) NULL,
	[TenSanPham] [nvarchar](255) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
	[TongTien] [int] NULL,
 CONSTRAINT [PK_PhieuNhapKho] PRIMARY KEY CLUSTERED 
(
	[STTSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuXuatKho]    Script Date: 1/4/2022 10:12:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuXuatKho](
	[STTSanPhamXuat] [int] IDENTITY(1,1) NOT NULL,
	[MaPhieuXuat] [nvarchar](50) NULL,
	[TenNguoiNhan] [nvarchar](255) NULL,
	[SoDienThoai] [nvarchar](50) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[NgayXuatKho] [date] NULL,
	[MaSanPham] [nvarchar](50) NULL,
	[TenSanPham] [nvarchar](255) NULL,
	[SoLuong] [int] NULL,
	[DonGia] [int] NULL,
	[TongTien] [int] NULL,
	[TTThanhToan] [nvarchar](255) NULL,
	[TTGiaoHang] [nvarchar](255) NULL,
 CONSTRAINT [PK_PhieuXuatKho] PRIMARY KEY CLUSTERED 
(
	[STTSanPhamXuat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Web_SanPham]    Script Date: 1/4/2022 10:12:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Web_SanPham](
	[MaSanPham] [nvarchar](255) NOT NULL,
	[TenSanPham] [nvarchar](255) NULL,
	[GiaBan] [int] NULL,
	[HinhAnhSP] [nvarchar](255) NULL,
	[MoTa] [nvarchar](max) NULL,
	[ThuongHieu] [nvarchar](255) NULL,
	[XuatXu] [nvarchar](255) NULL,
 CONSTRAINT [PK_Web_SanPham] PRIMARY KEY CLUSTERED 
(
	[MaSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[Account] ([TaiKhoan], [MatKhau], [LoaiTaiKhoan], [TenNhanVien], [SoDienThoai], [DiaChi], [Email]) VALUES (N'dl1', N'123', N'Đại lý', N'Trần Minh', N'03256789  ', N'Quận 1, TPHCM', N'dl1@gmail.com')
INSERT [dbo].[Account] ([TaiKhoan], [MatKhau], [LoaiTaiKhoan], [TenNhanVien], [SoDienThoai], [DiaChi], [Email]) VALUES (N'nvkho1', N'123', N'Kế toán', N'Trần Quốc Nam', N'012345698 ', N'Thống Nhất,Đồng Nai', N'kho1@gmail.com')
INSERT [dbo].[Account] ([TaiKhoan], [MatKhau], [LoaiTaiKhoan], [TenNhanVien], [SoDienThoai], [DiaChi], [Email]) VALUES (N'nvkho2', N'123', N'Kế toán', N'Nguyễn Thắng', N'02345671  ', N'Dĩ An,Bình Dương', N'kho2@gmail.com')
GO
INSERT [dbo].[DatHang] ([MaDatHang], [TenDaiLy], [DiaChi], [SoDienThoai], [ThanhToan], [NgayDatHang], [MaSanPham], [TenSanPham], [SoLuong], [DonGia], [TongTien]) VALUES (N'dGAVXypKB', N'Trần Minh', N'Quận 1, TPHCM', N'03256789', N'InternetBanking', CAST(N'2022-01-03' AS Date), N'SP1', N'Thực phẩm bảo vệ sức khỏe KIRKLAND Signature Glucosamine With MSM', 1, 600000, 600000)
INSERT [dbo].[DatHang] ([MaDatHang], [TenDaiLy], [DiaChi], [SoDienThoai], [ThanhToan], [NgayDatHang], [MaSanPham], [TenSanPham], [SoLuong], [DonGia], [TongTien]) VALUES (N'nX6--xD8T', N'Trần Minh', N'Quận 1, TPHCM', N'03256789', N'Thanh toán bằng tiền mặt', CAST(N'2022-01-04' AS Date), N'SP4', N'Viên Chống Tai Biến Orihiro Nattokinase 2000FU Nhật (60Viên)
', 1, 500000, 500000)
INSERT [dbo].[DatHang] ([MaDatHang], [TenDaiLy], [DiaChi], [SoDienThoai], [ThanhToan], [NgayDatHang], [MaSanPham], [TenSanPham], [SoLuong], [DonGia], [TongTien]) VALUES (N'CR_Qn-kFa', N'Trần Minh', N'Quận 1, TPHCM', N'03256789', N'InternetBanking', CAST(N'2022-01-04' AS Date), N'SP4', N'Viên Chống Tai Biến Orihiro Nattokinase 2000FU Nhật (60Viên)
', 1, 500000, 500000)
INSERT [dbo].[DatHang] ([MaDatHang], [TenDaiLy], [DiaChi], [SoDienThoai], [ThanhToan], [NgayDatHang], [MaSanPham], [TenSanPham], [SoLuong], [DonGia], [TongTien]) VALUES (N'CR_Qn-kFa', N'Trần Minh', N'Quận 1, TPHCM', N'03256789', N'InternetBanking', CAST(N'2022-01-04' AS Date), N'SP1', N'Thực phẩm bảo vệ sức khỏe KIRKLAND Signature Glucosamine With MSM', 1, 600000, 600000)
INSERT [dbo].[DatHang] ([MaDatHang], [TenDaiLy], [DiaChi], [SoDienThoai], [ThanhToan], [NgayDatHang], [MaSanPham], [TenSanPham], [SoLuong], [DonGia], [TongTien]) VALUES (N'iFLJEhpXl', N'Trần Minh', N'Quận 1, TPHCM', N'03256789', N'Thanh toán bằng tiền mặt', CAST(N'2022-01-04' AS Date), N'SP5', N'Viên Uống Đẹp Da ESENY 400 BEAUTIFUL - Hỗ Trợ Giảm Lão Hóa, Bổ Sung Vitamin E Giúp Tăng Độ Đàn Hồi (Hộp 30 Viên)
', 1, 400000, 400000)
GO
SET IDENTITY_INSERT [dbo].[PhieuNhapKho] ON 

INSERT [dbo].[PhieuNhapKho] ([STTSanPham], [MaPhieuNhap], [TenNhanVien], [NgayNhapkho], [MaSanPham], [TenSanPham], [SoLuong], [DonGia], [TongTien]) VALUES (90, N'NH1', N'Trần Quốc Nam', CAST(N'2021-12-12' AS Date), N'SP1', N'Thực phẩm bảo vệ sức khỏe KIRKLAND Signature Glucosamine With MSM', 500, 579000, 289500000)
INSERT [dbo].[PhieuNhapKho] ([STTSanPham], [MaPhieuNhap], [TenNhanVien], [NgayNhapkho], [MaSanPham], [TenSanPham], [SoLuong], [DonGia], [TongTien]) VALUES (91, N'NH1', N'Trần Quốc Nam', CAST(N'2021-12-12' AS Date), N'SP2', N'Thực phẩm chức năng Viên uống bổ sung Canxi 600mg và Vitamin D3 cho xương và răng - Kirkland Calcium 600mg With Vitamin D3 (500 Viên)', 200, 385000, 77000000)
INSERT [dbo].[PhieuNhapKho] ([STTSanPham], [MaPhieuNhap], [TenNhanVien], [NgayNhapkho], [MaSanPham], [TenSanPham], [SoLuong], [DonGia], [TongTien]) VALUES (92, N'NH2', N'Nguyễn Thắng', CAST(N'2021-12-20' AS Date), N'SP3', N'Viên Uống Bổ Sung Canxi, Ngăn Ngừa Loãng Xương Calcium Magnesium Zinc Nature''s Bounty - 100 Viên', 300, 230000, 69000000)
INSERT [dbo].[PhieuNhapKho] ([STTSanPham], [MaPhieuNhap], [TenNhanVien], [NgayNhapkho], [MaSanPham], [TenSanPham], [SoLuong], [DonGia], [TongTien]) VALUES (93, N'NH3', N'Trần Quốc Nam', CAST(N'2021-12-25' AS Date), N'SP1', N'Thực phẩm bảo vệ sức khỏe KIRKLAND Signature Glucosamine With MSM', 400, 579000, 289500000)
INSERT [dbo].[PhieuNhapKho] ([STTSanPham], [MaPhieuNhap], [TenNhanVien], [NgayNhapkho], [MaSanPham], [TenSanPham], [SoLuong], [DonGia], [TongTien]) VALUES (97, N'NH001', N'Trần Quốc Nam', CAST(N'2021-11-10' AS Date), N'SP1', N'Thực phẩm bảo vệ sức khỏe KIRKLAND Signature Glucosamine With MSM', 200, 579000, 115800000)
INSERT [dbo].[PhieuNhapKho] ([STTSanPham], [MaPhieuNhap], [TenNhanVien], [NgayNhapkho], [MaSanPham], [TenSanPham], [SoLuong], [DonGia], [TongTien]) VALUES (98, N'NH18', N'Trần Quốc Nam', CAST(N'2021-12-29' AS Date), N'SP8', N'Thực phẩm chức năng Viên uống bổ sung Collagen Youtheory (Collagen Type 1-2-3) 390 Viên', 500, 550000, 275000000)
INSERT [dbo].[PhieuNhapKho] ([STTSanPham], [MaPhieuNhap], [TenNhanVien], [NgayNhapkho], [MaSanPham], [TenSanPham], [SoLuong], [DonGia], [TongTien]) VALUES (99, N'NH18', N'Trần Quốc Nam', CAST(N'2021-12-29' AS Date), N'SP9', N'Thực Phẩm Chức Năng Bảo Vệ Sức Khỏe Rohto V5 (30 Viên)', 300, 419000, 125700000)
INSERT [dbo].[PhieuNhapKho] ([STTSanPham], [MaPhieuNhap], [TenNhanVien], [NgayNhapkho], [MaSanPham], [TenSanPham], [SoLuong], [DonGia], [TongTien]) VALUES (105, N'NH4', N'Trần Quốc Nam', CAST(N'2021-12-29' AS Date), N'SP4', N'Viên Chống Tai Biến Orihiro Nattokinase 2000FU Nhật (60Viên)
', 500, 470000, 235000000)
INSERT [dbo].[PhieuNhapKho] ([STTSanPham], [MaPhieuNhap], [TenNhanVien], [NgayNhapkho], [MaSanPham], [TenSanPham], [SoLuong], [DonGia], [TongTien]) VALUES (106, N'NH5', N'Trần Quốc Nam', CAST(N'2021-12-29' AS Date), N'SP5', N'Viên Uống Đẹp Da ESENY 400 BEAUTIFUL - Hỗ Trợ Giảm Lão Hóa, Bổ Sung Vitamin E Giúp Tăng Độ Đàn Hồi (Hộp 30 Viên)
', 300, 350000, 105000000)
INSERT [dbo].[PhieuNhapKho] ([STTSanPham], [MaPhieuNhap], [TenNhanVien], [NgayNhapkho], [MaSanPham], [TenSanPham], [SoLuong], [DonGia], [TongTien]) VALUES (107, N'NH6', N'Trần Quốc Nam', CAST(N'2021-12-29' AS Date), N'SP6', N'{COMBO5TUYP}Viên sủi Plusssz Calcium vị Đào không đường, bổ sung Canxi dạng hòa tan, dễ hấp thu (Tuýp 20 viên sủi)
', 500, 350000, 175000000)
INSERT [dbo].[PhieuNhapKho] ([STTSanPham], [MaPhieuNhap], [TenNhanVien], [NgayNhapkho], [MaSanPham], [TenSanPham], [SoLuong], [DonGia], [TongTien]) VALUES (108, N'NH7', N'Trần Quốc Nam', CAST(N'2021-12-29' AS Date), N'SP7', N'Viên uống Vitamin E Paris - Bổ sung Vitamin E chống lão hóa- giúp làm đẹp da - Hộp 30 viên Chuẩn GMP
', 500, 75000, 37500000)
INSERT [dbo].[PhieuNhapKho] ([STTSanPham], [MaPhieuNhap], [TenNhanVien], [NgayNhapkho], [MaSanPham], [TenSanPham], [SoLuong], [DonGia], [TongTien]) VALUES (140, N'NH111', N'Trần Quốc Nam', CAST(N'2022-01-04' AS Date), N'SP100', N'Thuốc bổ sung Vitamin', 100, 20000, 2000000)
SET IDENTITY_INSERT [dbo].[PhieuNhapKho] OFF
GO
SET IDENTITY_INSERT [dbo].[PhieuXuatKho] ON 

INSERT [dbo].[PhieuXuatKho] ([STTSanPhamXuat], [MaPhieuXuat], [TenNguoiNhan], [SoDienThoai], [DiaChi], [NgayXuatKho], [MaSanPham], [TenSanPham], [SoLuong], [DonGia], [TongTien], [TTThanhToan], [TTGiaoHang]) VALUES (62, N'5SeA8jP31', N'Trần Minh', N'03256789', N'Quận 1, TPHCM', CAST(N'2022-01-03' AS Date), N'SP1', N'Thực phẩm bảo vệ sức khỏe KIRKLAND Signature Glucosamine With MSM', 1, 600000, 600000, N'Chua thanh toán', N'Đang xử lý')
INSERT [dbo].[PhieuXuatKho] ([STTSanPhamXuat], [MaPhieuXuat], [TenNguoiNhan], [SoDienThoai], [DiaChi], [NgayXuatKho], [MaSanPham], [TenSanPham], [SoLuong], [DonGia], [TongTien], [TTThanhToan], [TTGiaoHang]) VALUES (74, N'Sg_DS2qNc', N'Trần Minh', N'03256789', N'Quận 1, TPHCM', CAST(N'2022-01-03' AS Date), N'SP1', N'Thực phẩm bảo vệ sức khỏe KIRKLAND Signature Glucosamine With MSM', 1, 600000, 600000, N'Đã thanh toán', N'Giao thành công')
INSERT [dbo].[PhieuXuatKho] ([STTSanPhamXuat], [MaPhieuXuat], [TenNguoiNhan], [SoDienThoai], [DiaChi], [NgayXuatKho], [MaSanPham], [TenSanPham], [SoLuong], [DonGia], [TongTien], [TTThanhToan], [TTGiaoHang]) VALUES (78, N'ZseFleMLD', N'Trần Minh', N'03256789', N'Quận 1, TPHCM', CAST(N'2022-01-03' AS Date), N'SP1', N'Thực phẩm bảo vệ sức khỏe KIRKLAND Signature Glucosamine With MSM', 2, 600000, 1200000, N'Chưa thanh toán', N'Đang xử lý')
INSERT [dbo].[PhieuXuatKho] ([STTSanPhamXuat], [MaPhieuXuat], [TenNguoiNhan], [SoDienThoai], [DiaChi], [NgayXuatKho], [MaSanPham], [TenSanPham], [SoLuong], [DonGia], [TongTien], [TTThanhToan], [TTGiaoHang]) VALUES (79, N'AuxGKf-NJ', N'Trần Minh', N'03256789', N'Quận 1, TPHCM', CAST(N'2022-01-03' AS Date), N'SP1', N'Thực phẩm bảo vệ sức khỏe KIRKLAND Signature Glucosamine With MSM', 2, 600000, 1200000, N'Chưa thanh toán', N'Đang xử lý')
INSERT [dbo].[PhieuXuatKho] ([STTSanPhamXuat], [MaPhieuXuat], [TenNguoiNhan], [SoDienThoai], [DiaChi], [NgayXuatKho], [MaSanPham], [TenSanPham], [SoLuong], [DonGia], [TongTien], [TTThanhToan], [TTGiaoHang]) VALUES (80, N'AuxGKf-NJ', N'Trần Minh', N'03256789', N'Quận 1, TPHCM', CAST(N'2022-01-03' AS Date), N'SP5', N'Viên Uống Đẹp Da ESENY 400 BEAUTIFUL - Hỗ Trợ Giảm Lão Hóa, Bổ Sung Vitamin E Giúp Tăng Độ Đàn Hồi (Hộp 30 Viên)
', 1, 400000, 400000, N'Chưa thanh toán', N'Đang xử lý')
INSERT [dbo].[PhieuXuatKho] ([STTSanPhamXuat], [MaPhieuXuat], [TenNguoiNhan], [SoDienThoai], [DiaChi], [NgayXuatKho], [MaSanPham], [TenSanPham], [SoLuong], [DonGia], [TongTien], [TTThanhToan], [TTGiaoHang]) VALUES (92, N'PXK11', N'Trần Bảo Trâm', N'01234785', N'Quận 7, TPHCM', CAST(N'2021-12-15' AS Date), N'SP1', N'Thực phẩm bảo vệ sức khỏe KIRKLAND Signature Glucosamine With MSM', 5, 600000, 3000000, N'Chưa thanh toán', N'Đang xử lý')
INSERT [dbo].[PhieuXuatKho] ([STTSanPhamXuat], [MaPhieuXuat], [TenNguoiNhan], [SoDienThoai], [DiaChi], [NgayXuatKho], [MaSanPham], [TenSanPham], [SoLuong], [DonGia], [TongTien], [TTThanhToan], [TTGiaoHang]) VALUES (99, N'T9xuB_GIf', N'Trần Minh', N'03256789', N'Quận 1, TPHCM', CAST(N'2022-01-04' AS Date), N'SP4', N'Viên Chống Tai Biến Orihiro Nattokinase 2000FU Nhật (60Viên)
', 10, 500000, 5000000, N'Chưa thanh toán', N'Đang xử lý')
INSERT [dbo].[PhieuXuatKho] ([STTSanPhamXuat], [MaPhieuXuat], [TenNguoiNhan], [SoDienThoai], [DiaChi], [NgayXuatKho], [MaSanPham], [TenSanPham], [SoLuong], [DonGia], [TongTien], [TTThanhToan], [TTGiaoHang]) VALUES (100, N'T9xuB_GIf', N'Trần Minh', N'03256789', N'Quận 1, TPHCM', CAST(N'2022-01-04' AS Date), N'SP6', N'{COMBO5TUYP}Viên sủi Plusssz Calcium vị Đào không đường, bổ sung Canxi dạng hòa tan, dễ hấp thu (Tuýp 20 viên sủi)
', 5, 400000, 2000000, N'Chưa thanh toán', N'Đang xử lý')
SET IDENTITY_INSERT [dbo].[PhieuXuatKho] OFF
GO
INSERT [dbo].[Web_SanPham] ([MaSanPham], [TenSanPham], [GiaBan], [HinhAnhSP], [MoTa], [ThuongHieu], [XuatXu]) VALUES (N'SP1', N'Thực phẩm bảo vệ sức khỏe KIRKLAND Signature Glucosamine With MSM', 600000, N'sp1.jpg', N'Hiện nay, trên thị trường đã có khá nhiều sản phẩm bổ sung Glucosamine, tuy nhiên sản phẩm Kirkland Glucosamine HCl 1500mg MSM của Mỹ vẫn được nhiều người lựa chọn. Sản phẩm bổ sung hàm lượng Glucosamine HCl 1500mg nguyên chất chỉ trong 1 viên nhỏ, rất tiện lợi khi sử dụng.', N'Kirkland', N'Mỹ')
INSERT [dbo].[Web_SanPham] ([MaSanPham], [TenSanPham], [GiaBan], [HinhAnhSP], [MoTa], [ThuongHieu], [XuatXu]) VALUES (N'SP2', N'Thực phẩm chức năng Viên uống bổ sung Canxi 600mg và Vitamin D3 cho xương và răng - Kirkland Calcium 600mg With Vitamin D3 (500 Viên)', 400000, N'sp2.jpg', N'Viên uống bổ sung Canxi 600mg và Vitamin D3 cho xương và răng chắc khỏe', N'Kirkland', N'Mỹ')
INSERT [dbo].[Web_SanPham] ([MaSanPham], [TenSanPham], [GiaBan], [HinhAnhSP], [MoTa], [ThuongHieu], [XuatXu]) VALUES (N'SP3', N'Viên Uống Bổ Sung Canxi, Ngăn Ngừa Loãng Xương Calcium Magnesium Zinc Nature''s Bounty - 100 Viên', 250000, N'sp3.jpg', N'Calcium Magnesium Zinc là  gì? Canxi (Calcium) là khoáng chất có vai trò quan trọng làm xương chắc khoẻ. Magiê (Magnesium) cần thiết cho sự phát triển của xương, bảo vệ xương chống lại quá trình lão hoá. Kẽm (Zinc) giúp tăng chiều cao, phát triển xương. Vitamin D3 có chức năng hỗ trợ hấp thụ canxi vào cơ thể, chống còi xương. Để có một hệ xương chắc khoẻ, nên bổ sung đầy đủ Canxi, Magiê, Kẽm, Vitamin D3 mỗi ngày.
Tác dụng của Calcium Magnesium Zinc Nature’s Bounty Giúp xương chắc khỏe, phát triền chiều cao, răng chắc khỏe. Phòng ngừa loãng xương
Đối tượng nên dùng Calcium Magnesium Zinc Trẻ vị thành niên, phụ nữ sau thời kì mãn kinh, phụ nữ có thai có nguy cơ dễ thiếu hụt canxi
Lưu ý khi sử dụng viên uống Calcium Magnesium Zinc Để viên uống Calcium Magnesium Zinc đạt hiệu quả tốt nhất, bên cạnh đó bạn cần bổ sung canxi từ các nguồn dinh dưỡng khác. Mách bạn siêu thực phẩm dồi dào canxi Các món hải sản (tôm, cua, sò, cá) Các loại rau màu xanh đậm (rau diếp, bắp cải, cải xoăn, cần tâ) là những thực phẩm tốt cho sức khỏe xương. Vitamin K trong rau xanh là yếu tố hình thành của osteocalcin, giúp tích tụ canxi vào xương. Đừng bỏ qua nguồn canxi quý giá từ sữa và các chế phẩm của sữa như sữa chua, phô mai
Liệu trình sử dụng viên uống Calcium Magnesium Zinc để đạt hiệu quả tốt nhất bao lâu Duy trì đều đặn trong vòng 3 tháng để đạt hiệu quả mong muốn. Đối với người thiếu hụt canxi nên uống 3 viên/ ngày. Sau đó có thể duy trì sử dụng  1 viên/ ngày', N'Nature''s Bounty
', N'Mỹ')
INSERT [dbo].[Web_SanPham] ([MaSanPham], [TenSanPham], [GiaBan], [HinhAnhSP], [MoTa], [ThuongHieu], [XuatXu]) VALUES (N'SP4', N'Viên Chống Tai Biến Orihiro Nattokinase 2000FU Nhật (60Viên)
', 500000, N'sp4.jpg', N'Phòng, tránh nguy cơ bị mắc các bệnh tim mạch hiện đang có xu hướng tăng cao do áp lực cuộc sống hoặc các vấn đề do dinh dưỡng, vận động.
Hỗ trợ điều_tri bệnh tai biến hoặc hậu tai biến
Tăng cường lưu thông máu lên não
Cải thiện trí nhớ', N'Nhật Bản
', N'Orihiro')
INSERT [dbo].[Web_SanPham] ([MaSanPham], [TenSanPham], [GiaBan], [HinhAnhSP], [MoTa], [ThuongHieu], [XuatXu]) VALUES (N'SP5', N'Viên Uống Đẹp Da ESENY 400 BEAUTIFUL - Hỗ Trợ Giảm Lão Hóa, Bổ Sung Vitamin E Giúp Tăng Độ Đàn Hồi (Hộp 30 Viên)
', 400000, N'sp5.jpg', N'Viên Uống Đẹp Da ESENY 400 BEAUTIFUL - Hỗ Trợ Giảm Lão Hóa, Bổ Sung Vitamin E Giúp Tăng Độ Đàn Hồi (Hộp 30 Viên)
', N'Việt Nam', N'Australia pharma.,jsc
')
INSERT [dbo].[Web_SanPham] ([MaSanPham], [TenSanPham], [GiaBan], [HinhAnhSP], [MoTa], [ThuongHieu], [XuatXu]) VALUES (N'SP6', N'{COMBO5TUYP}Viên sủi Plusssz Calcium vị Đào không đường, bổ sung Canxi dạng hòa tan, dễ hấp thu (Tuýp 20 viên sủi)
', 400000, N'sp6.jpg', N'Bổ sung 1000mg Canxi hữu cơ cần thiết cho cơ thể mỗi ngày ,hỗ trợ tăng cường sức khỏe xương khớp , phòng ngừa loãng xương và thoái hóa xương khớp. hoặc người có nhu cầu bổ sung Canxi do chế độ dinh dưỡng không đủ, do bệnh lý, trẻ em trong thời kỳ phát triển, phụ nữ có thai, đang cho con bú.Dùng được cho bệnh nhân tiểu đường', N'Ba Lan', N'Plusssz')
INSERT [dbo].[Web_SanPham] ([MaSanPham], [TenSanPham], [GiaBan], [HinhAnhSP], [MoTa], [ThuongHieu], [XuatXu]) VALUES (N'SP7', N'Viên uống Vitamin E Paris - Bổ sung Vitamin E chống lão hóa- giúp làm đẹp da - Hộp 30 viên Chuẩn GMP
', 80000, N'sp7.jpg', N'Vitamin E giúp bảo vệ các mô của tế bào khỏi quá trình oxy hóa, làm chậm quá trình lão hóa của cơ thể. Đặc biệt loại thần dược này còn giúp da không bị khô, duy trì sự tươi mới, làm giảm nếp nhăn nếu dùng đúng, đủ liều lượng.

Vitamin E giúp bảo vệ các mô của tế bào khỏi quá trình oxy hóa, làm chậm quá trình lão hóa của cơ thể. Đặc biệt loại thần dược này còn giúp da không bị khô, duy trì sự tươi mới, làm giảm nếp nhăn nếu dùng đúng, đủ liều lượng.

', N'Việt Nam', N'Paris Pharma
')
INSERT [dbo].[Web_SanPham] ([MaSanPham], [TenSanPham], [GiaBan], [HinhAnhSP], [MoTa], [ThuongHieu], [XuatXu]) VALUES (N'SP8', N'Thực phẩm chức năng Viên uống bổ sung Collagen Youtheory (Collagen Type 1-2-3) 390 Viên
', 600000, N'sp8.jpg', N'Đó là protein chính của cơ thể người, là thành phần chính của các mô liên kết, có khả năng đàn hồi và chịu lực rất cao, là thành phần chính của gân, xương, dây chằng, sụn và răng trong cơ thể. Collagen đảm nhận tính co giãn của da vì thế khi bị thoái hoá do quá trình lão hoá của cơ thể thì các dấu hiệu “già” trên da và cơ thể cũng đồng thời xuất hiện: cơ thể nhão, kém săn chắc. Theo phân tích của khoa học thì collagen có ở khắp nơi trong cơ thể và có tới 29 loại collagen trong đó tập trung chủ yếu ở các nhóm collagen type I, II, III, IV, V
', N'Youtheory
', N'Mỹ')
INSERT [dbo].[Web_SanPham] ([MaSanPham], [TenSanPham], [GiaBan], [HinhAnhSP], [MoTa], [ThuongHieu], [XuatXu]) VALUES (N'SP9', N'Thực Phẩm Chức Năng Bảo Vệ Sức Khỏe Rohto V5 (30 Viên)', 500000, N'sp9.jpg', N'1. Thành phần: Gelatin, dầu cá tinh luyện có chứa DHA, dầu cây Rum, bột chiết xuất từ thịt gà, dầu thực vật có chứa Vitamin E, nước ép quả Lonicera Caerulea, chiết xuất quả việt quất đen, bột chiết xuất nụ nho, bột chiết xuất gừng màu hoa cúc vạn thọ, Glycerin, Ester của Axit béo và Glycerin, màu Caramel, tinh bột biến tính, Guar thủy phân (chất làm dầy), Cellulose, Vitamin E (chất chống oxy hóa)
', N'Rohto', N'Nhật Bản')
GO
