USE [master]
GO
/****** Object:  Database [DeliveryService]    Script Date: 08.07.2021 19:58:41 ******/
CREATE DATABASE [DeliveryService]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DeliveryService', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DeliveryService.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DeliveryService_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\DeliveryService_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [DeliveryService] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DeliveryService].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DeliveryService] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DeliveryService] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DeliveryService] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DeliveryService] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DeliveryService] SET ARITHABORT OFF 
GO
ALTER DATABASE [DeliveryService] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DeliveryService] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DeliveryService] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DeliveryService] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DeliveryService] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DeliveryService] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DeliveryService] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DeliveryService] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DeliveryService] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DeliveryService] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DeliveryService] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DeliveryService] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DeliveryService] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DeliveryService] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DeliveryService] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DeliveryService] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DeliveryService] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DeliveryService] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DeliveryService] SET  MULTI_USER 
GO
ALTER DATABASE [DeliveryService] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DeliveryService] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DeliveryService] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DeliveryService] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DeliveryService] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DeliveryService] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [DeliveryService] SET QUERY_STORE = OFF
GO
USE [DeliveryService]
GO
/****** Object:  Table [dbo].[Company]    Script Date: 08.07.2021 19:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[CompanyID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[DishesID] [int] NOT NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[CompanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 08.07.2021 19:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustomerID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Dish]    Script Date: 08.07.2021 19:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dish](
	[DishID] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Price] [float] NOT NULL,
	[Composition] [nvarchar](50) NULL,
	[Weight] [int] NOT NULL,
	[Calories] [int] NOT NULL,
 CONSTRAINT [PK_Dish] PRIMARY KEY CLUSTERED 
(
	[DishID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 08.07.2021 19:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[OrderID] [int] NOT NULL,
	[CustomerID] [int] NOT NULL,
	[CompanyID] [int] NOT NULL,
	[FullPrice] [float] NOT NULL,
	[DishesID] [int] NOT NULL,
	[Phone] [nvarchar](15) NOT NULL,
	[Address] [nvarchar](50) NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderCompany]    Script Date: 08.07.2021 19:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderCompany](
	[OrderID] [int] NOT NULL,
	[CompanyID] [int] NOT NULL,
 CONSTRAINT [PK_OrderCompany] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[CompanyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDish]    Script Date: 08.07.2021 19:58:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDish](
	[OrderID] [int] NOT NULL,
	[DishID] [int] NOT NULL,
 CONSTRAINT [PK_OrderDish] PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[DishID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Index [IX_OrderDish]    Script Date: 08.07.2021 19:58:41 ******/
CREATE NONCLUSTERED INDEX [IX_OrderDish] ON [dbo].[OrderDish]
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Company]  WITH CHECK ADD  CONSTRAINT [FK_Company_Dish1] FOREIGN KEY([CompanyID])
REFERENCES [dbo].[Dish] ([DishID])
GO
ALTER TABLE [dbo].[Company] CHECK CONSTRAINT [FK_Company_Dish1]
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customer] FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customer] ([CustomerID])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Customer]
GO
ALTER TABLE [dbo].[OrderCompany]  WITH CHECK ADD  CONSTRAINT [FK_OrderCompany_Company] FOREIGN KEY([CompanyID])
REFERENCES [dbo].[Company] ([CompanyID])
GO
ALTER TABLE [dbo].[OrderCompany] CHECK CONSTRAINT [FK_OrderCompany_Company]
GO
ALTER TABLE [dbo].[OrderCompany]  WITH CHECK ADD  CONSTRAINT [FK_OrderCompany_Order] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
GO
ALTER TABLE [dbo].[OrderCompany] CHECK CONSTRAINT [FK_OrderCompany_Order]
GO
ALTER TABLE [dbo].[OrderDish]  WITH CHECK ADD  CONSTRAINT [FK_OrderDish_Dish] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Dish] ([DishID])
GO
ALTER TABLE [dbo].[OrderDish] CHECK CONSTRAINT [FK_OrderDish_Dish]
GO
ALTER TABLE [dbo].[OrderDish]  WITH CHECK ADD  CONSTRAINT [FK_OrderDish_Order] FOREIGN KEY([OrderID])
REFERENCES [dbo].[Order] ([OrderID])
GO
ALTER TABLE [dbo].[OrderDish] CHECK CONSTRAINT [FK_OrderDish_Order]
GO
USE [master]
GO
ALTER DATABASE [DeliveryService] SET  READ_WRITE 
GO
