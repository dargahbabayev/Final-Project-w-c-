USE [master]
GO
/****** Object:  Database [Stadium]    Script Date: 22.4.2018 15:46:42 ******/
CREATE DATABASE [Stadium]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Stadium', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Stadium.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Stadium_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Stadium_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Stadium] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Stadium].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Stadium] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Stadium] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Stadium] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Stadium] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Stadium] SET ARITHABORT OFF 
GO
ALTER DATABASE [Stadium] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Stadium] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Stadium] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Stadium] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Stadium] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Stadium] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Stadium] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Stadium] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Stadium] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Stadium] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Stadium] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Stadium] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Stadium] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Stadium] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Stadium] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Stadium] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Stadium] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Stadium] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Stadium] SET  MULTI_USER 
GO
ALTER DATABASE [Stadium] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Stadium] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Stadium] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Stadium] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Stadium] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Stadium]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 22.4.2018 15:46:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Fullname] [nvarchar](50) NULL,
	[Number] [nvarchar](20) NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reserves]    Script Date: 22.4.2018 15:46:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserves](
	[İd] [int] IDENTITY(1,1) NOT NULL,
	[SatdiumId] [int] NULL,
	[StartTime] [time](7) NULL,
	[EndTime] [time](7) NULL,
	[Date] [date] NULL,
	[Price] [money] NULL,
	[CustomerId] [int] NULL,
 CONSTRAINT [PK_Reserves] PRIMARY KEY CLUSTERED 
(
	[İd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Stadiums]    Script Date: 22.4.2018 15:46:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stadiums](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](20) NULL,
	[İsCovered] [tinyint] NULL,
 CONSTRAINT [PK_Stadiums] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([Id], [Fullname], [Number]) VALUES (1008, N'Kenan', N'485162')
INSERT [dbo].[Customers] ([Id], [Fullname], [Number]) VALUES (1010, N'Eli', N'66')
INSERT [dbo].[Customers] ([Id], [Fullname], [Number]) VALUES (1011, N'Namiq', N'8451')
INSERT [dbo].[Customers] ([Id], [Fullname], [Number]) VALUES (1013, N'Xasay', N'123456654')
INSERT [dbo].[Customers] ([Id], [Fullname], [Number]) VALUES (1017, N'fgbfdgb', N'123453')
INSERT [dbo].[Customers] ([Id], [Fullname], [Number]) VALUES (1018, N'rbg', N'1425')
INSERT [dbo].[Customers] ([Id], [Fullname], [Number]) VALUES (1019, N'Yeddinci', N'1236546123')
SET IDENTITY_INSERT [dbo].[Customers] OFF
SET IDENTITY_INSERT [dbo].[Reserves] ON 

INSERT [dbo].[Reserves] ([İd], [SatdiumId], [StartTime], [EndTime], [Date], [Price], [CustomerId]) VALUES (2126, 2, CAST(N'15:00:00' AS Time), CAST(N'16:00:00' AS Time), CAST(N'2018-04-22' AS Date), 5.0000, 1010)
SET IDENTITY_INSERT [dbo].[Reserves] OFF
SET IDENTITY_INSERT [dbo].[Stadiums] ON 

INSERT [dbo].[Stadiums] ([Id], [Name], [İsCovered]) VALUES (2, N'Buyuk Stadyum', 1)
INSERT [dbo].[Stadiums] ([Id], [Name], [İsCovered]) VALUES (3, N'Orta Stadyum', 0)
INSERT [dbo].[Stadiums] ([Id], [Name], [İsCovered]) VALUES (4, N'Kuchuk Stadyum', 1)
SET IDENTITY_INSERT [dbo].[Stadiums] OFF
ALTER TABLE [dbo].[Reserves]  WITH CHECK ADD  CONSTRAINT [FK_Reserves_Customers] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customers] ([Id])
GO
ALTER TABLE [dbo].[Reserves] CHECK CONSTRAINT [FK_Reserves_Customers]
GO
ALTER TABLE [dbo].[Reserves]  WITH CHECK ADD  CONSTRAINT [FK_Reserves_Stadiums] FOREIGN KEY([SatdiumId])
REFERENCES [dbo].[Stadiums] ([Id])
GO
ALTER TABLE [dbo].[Reserves] CHECK CONSTRAINT [FK_Reserves_Stadiums]
GO
USE [master]
GO
ALTER DATABASE [Stadium] SET  READ_WRITE 
GO
