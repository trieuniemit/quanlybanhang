USE [master]
GO
/****** Object:  Database [QuanLyBanHang]    Script Date: 12/3/2018 8:28:26 PM ******/
CREATE DATABASE [QuanLyBanHang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyBanHang', FILENAME = N'D:\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QuanLyBanHang.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyBanHang_log', FILENAME = N'D:\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\QuanLyBanHang_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyBanHang] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyBanHang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyBanHang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyBanHang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyBanHang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET RECOVERY FULL 
GO
ALTER DATABASE [QuanLyBanHang] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyBanHang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyBanHang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyBanHang] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyBanHang] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'QuanLyBanHang', N'ON'
GO
USE [QuanLyBanHang]
GO
/****** Object:  Table [dbo].[order_items]    Script Date: 12/3/2018 8:28:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[order_items](
	[order_id] [int] NOT NULL,
	[product_id] [varchar](15) NOT NULL,
	[quantity] [int] NOT NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[orders]    Script Date: 12/3/2018 8:28:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[customer] [nvarchar](30) NOT NULL,
	[customer_phone] [nchar](15) NULL,
	[deposits] [int] NULL,
	[created_by] [int] NULL,
	[created_at] [datetime] NULL,
	[total] [int] NULL,
 CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[product_cats]    Script Date: 12/3/2018 8:28:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product_cats](
	[cat_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
 CONSTRAINT [PK_product_cats] PRIMARY KEY CLUSTERED 
(
	[cat_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[products]    Script Date: 12/3/2018 8:28:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[products](
	[id] [varchar](15) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[cat_id] [int] NOT NULL,
	[count] [int] NOT NULL,
	[price] [int] NOT NULL,
	[unit] [nvarchar](10) NULL,
	[status] [int] NOT NULL,
	[created_at] [datetime] NULL,
	[promo_price] [int] NOT NULL CONSTRAINT [DF_products_promo_price]  DEFAULT ((0)),
	[updated_at] [datetime] NULL,
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[users]    Script Date: 12/3/2018 8:28:27 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nchar](10) NULL,
	[fullname] [nvarchar](30) NULL,
	[password] [nvarchar](100) NULL,
	[phone] [nvarchar](12) NULL,
	[email] [nvarchar](50) NULL,
	[role] [int] NOT NULL CONSTRAINT [DF_users_role]  DEFAULT ((1)),
	[gender] [int] NULL,
	[date_of_birth] [date] NULL,
	[created_at] [datetime] NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[order_items] ([order_id], [product_id], [quantity]) VALUES (2045, N'3236323', 1)
INSERT [dbo].[order_items] ([order_id], [product_id], [quantity]) VALUES (2047, N'8091817', 2)
INSERT [dbo].[order_items] ([order_id], [product_id], [quantity]) VALUES (2047, N'3236323', 1)
INSERT [dbo].[order_items] ([order_id], [product_id], [quantity]) VALUES (2046, N'8091817', 1)
INSERT [dbo].[order_items] ([order_id], [product_id], [quantity]) VALUES (2046, N'3236323', 1)
INSERT [dbo].[order_items] ([order_id], [product_id], [quantity]) VALUES (2048, N'4651213', 3)
SET IDENTITY_INSERT [dbo].[orders] ON 

INSERT [dbo].[orders] ([id], [customer], [customer_phone], [deposits], [created_by], [created_at], [total]) VALUES (2045, N'Triệu Tài Niêm', N'0395710844     ', 10000, 1, CAST(N'2017-11-23 02:29:04.000' AS DateTime), 2500)
INSERT [dbo].[orders] ([id], [customer], [customer_phone], [deposits], [created_by], [created_at], [total]) VALUES (2046, N'Triệu Thiên Sơn', N'123456789      ', 10000, 1, CAST(N'2018-11-24 02:32:17.000' AS DateTime), 5500)
INSERT [dbo].[orders] ([id], [customer], [customer_phone], [deposits], [created_by], [created_at], [total]) VALUES (2047, N'Niêm Triệu', N'23456789       ', 10000, 1, CAST(N'2018-11-24 15:27:11.000' AS DateTime), 8500)
INSERT [dbo].[orders] ([id], [customer], [customer_phone], [deposits], [created_by], [created_at], [total]) VALUES (2048, N'Huy Hồ', N'               ', 40000, 1, CAST(N'2018-11-26 09:37:39.000' AS DateTime), 36000)
SET IDENTITY_INSERT [dbo].[orders] OFF
SET IDENTITY_INSERT [dbo].[product_cats] ON 

INSERT [dbo].[product_cats] ([cat_id], [name]) VALUES (1, N'Hoa Quả')
INSERT [dbo].[product_cats] ([cat_id], [name]) VALUES (2, N'Mì')
INSERT [dbo].[product_cats] ([cat_id], [name]) VALUES (4, N'Văn phòng phẩm')
INSERT [dbo].[product_cats] ([cat_id], [name]) VALUES (5, N'Bánh kẹo')
INSERT [dbo].[product_cats] ([cat_id], [name]) VALUES (6, N'Trứng ')
SET IDENTITY_INSERT [dbo].[product_cats] OFF
INSERT [dbo].[products] ([id], [name], [cat_id], [count], [price], [unit], [status], [created_at], [promo_price], [updated_at]) VALUES (N'3236323', N'Trứng gà', 2, 10, 2500, N'quả', 1, CAST(N'1900-01-01 00:00:46.703' AS DateTime), 2000, CAST(N'2018-11-25 23:21:42.000' AS DateTime))
INSERT [dbo].[products] ([id], [name], [cat_id], [count], [price], [unit], [status], [created_at], [promo_price], [updated_at]) VALUES (N'4651213', N'Bút vẽ 12 màu', 4, 100, 12000, N'hộp', 1, CAST(N'2018-11-26 08:31:13.000' AS DateTime), 0, CAST(N'2018-11-26 08:31:13.000' AS DateTime))
INSERT [dbo].[products] ([id], [name], [cat_id], [count], [price], [unit], [status], [created_at], [promo_price], [updated_at]) VALUES (N'8091817', N'Mì tôm hảo hảo', 1, 4, 3000, N'gói', 1, CAST(N'1900-01-01 00:00:46.707' AS DateTime), 0, CAST(N'2018-11-25 23:21:48.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([id], [username], [fullname], [password], [phone], [email], [role], [gender], [date_of_birth], [created_at]) VALUES (1, N'thienson98', N'Nguyễn Huỳnh Đức', N'e10adc3949ba59abbe56e057f20f883e', N'0394194343', N'huynhduc@gmail.com', 1, 0, CAST(N'1998-02-27' AS Date), CAST(N'2018-11-25 22:57:53.000' AS DateTime))
INSERT [dbo].[users] ([id], [username], [fullname], [password], [phone], [email], [role], [gender], [date_of_birth], [created_at]) VALUES (7, N'huyho     ', N'Hồ Sỹ Huy', N'827ccb0eea8a706c4c34a16891f84e7b', N'01238236213', N'huy@gmail.com', 2, 0, CAST(N'1998-03-26' AS Date), CAST(N'2018-11-26 09:20:44.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[users] OFF
ALTER TABLE [dbo].[order_items]  WITH CHECK ADD  CONSTRAINT [FK_order_items_orders] FOREIGN KEY([order_id])
REFERENCES [dbo].[orders] ([id])
GO
ALTER TABLE [dbo].[order_items] CHECK CONSTRAINT [FK_order_items_orders]
GO
ALTER TABLE [dbo].[order_items]  WITH CHECK ADD  CONSTRAINT [FK_order_items_products] FOREIGN KEY([product_id])
REFERENCES [dbo].[products] ([id])
GO
ALTER TABLE [dbo].[order_items] CHECK CONSTRAINT [FK_order_items_products]
GO
ALTER TABLE [dbo].[orders]  WITH NOCHECK ADD  CONSTRAINT [FK_orders_users1] FOREIGN KEY([created_by])
REFERENCES [dbo].[users] ([id])
GO
ALTER TABLE [dbo].[orders] NOCHECK CONSTRAINT [FK_orders_users1]
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [FK_products_product_cats] FOREIGN KEY([cat_id])
REFERENCES [dbo].[product_cats] ([cat_id])
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [FK_products_product_cats]
GO
USE [master]
GO
ALTER DATABASE [QuanLyBanHang] SET  READ_WRITE 
GO
