USE [master]
GO
/****** Object:  Database [QuanLyBanHang]    Script Date: 11/9/2018 9:57:45 AM ******/
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
/****** Object:  Table [dbo].[orders]    Script Date: 11/9/2018 9:57:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[orders](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[customer] [nvarchar](30) NOT NULL,
	[created_by] [int] NULL,
	[created_at] [timestamp] NULL,
 CONSTRAINT [PK_orders] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[product_cats]    Script Date: 11/9/2018 9:57:45 AM ******/
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
/****** Object:  Table [dbo].[product_items]    Script Date: 11/9/2018 9:57:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product_items](
	[order_id] [int] NOT NULL,
	[product_id] [int] NOT NULL,
	[quantity] [int] NULL,
 CONSTRAINT [PK_product_items] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[products]    Script Date: 11/9/2018 9:57:45 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[id] [nvarchar](11) NOT NULL,
	[name] [nvarchar](50) NULL,
	[cat_id] [int] NULL,
	[count] [int] NULL,
	[price] [int] NULL,
	[unit] [nvarchar](10) NULL,
	[status] [int] NULL,
	[created_at] [timestamp] NULL,
	[promo_price] [int] NULL,
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[users]    Script Date: 11/9/2018 9:57:45 AM ******/
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
	[created_at] [timestamp] NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[products] ([id], [name], [cat_id], [count], [price], [unit], [status], [promo_price]) VALUES (N'3236323', N'Trứng gà', 2, 10, 2500, N'quả', 1, NULL)
INSERT [dbo].[products] ([id], [name], [cat_id], [count], [price], [unit], [status], [promo_price]) VALUES (N'8091817', N'Mì tôm hảo hảo', 1, 4, 3000, N'gói', 1, NULL)
SET IDENTITY_INSERT [dbo].[users] ON 

INSERT [dbo].[users] ([id], [username], [fullname], [password], [phone], [email], [role], [gender], [date_of_birth]) VALUES (1, N'thienson98', N'Triệu Tài Niêm', N'1234', NULL, N'thienson.a1@gmail.com', 1, 0, NULL)
SET IDENTITY_INSERT [dbo].[users] OFF
USE [master]
GO
ALTER DATABASE [QuanLyBanHang] SET  READ_WRITE 
GO
