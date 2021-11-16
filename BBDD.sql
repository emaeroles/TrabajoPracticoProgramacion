USE [master]
GO
/****** Object:  Database [TRANSPORTE_CARGAS]    Script Date: 10/11/2021 0:31:50 ******/
CREATE DATABASE [TRANSPORTE_CARGAS]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TRANSPORTE_CARGAS', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TRANSPORTE_CARGAS.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TRANSPORTE_CARGAS_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\TRANSPORTE_CARGAS_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TRANSPORTE_CARGAS].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET ARITHABORT OFF 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET RECOVERY FULL 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET  MULTI_USER 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TRANSPORTE_CARGAS', N'ON'
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET QUERY_STORE = OFF
GO
USE [TRANSPORTE_CARGAS]
GO
/****** Object:  Table [dbo].[CAMIONES]    Script Date: 10/11/2021 0:31:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CAMIONES](
	[id_camion] [int] NOT NULL,
	[descripcion] [varchar](50) NULL,
	[patente] [varchar](50) NULL,
	[id_camionero] [int] NULL,
	[estado] [int] NULL,
	[peso_maximo] [decimal](10, 2) NULL,
	[situado] [varchar](50) NULL,
	[baja] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_camion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CARGAS]    Script Date: 10/11/2021 0:31:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CARGAS](
	[id_viaje] [int] NOT NULL,
	[id_carga] [int] NOT NULL,
	[peso] [decimal](8, 2) NULL,
	[id_tipo_carga] [int] NULL,
	[cargado] [bit] NULL,
 CONSTRAINT [pk_carga] PRIMARY KEY CLUSTERED 
(
	[id_viaje] ASC,
	[id_carga] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPOS_CARGAS]    Script Date: 10/11/2021 0:31:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPOS_CARGAS](
	[id_tipo_carga] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo_carga] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TIPOS_USUARIOS]    Script Date: 10/11/2021 0:31:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPOS_USUARIOS](
	[id_tipo_usuario] [int] NOT NULL,
	[tipo] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_tipo_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[USUARIOS]    Script Date: 10/11/2021 0:31:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIOS](
	[id_usuario] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[documento] [varchar](20) NULL,
	[telefono] [varchar](25) NULL,
	[id_tipo_usuario] [int] NULL,
	[username] [varchar](50) NULL,
	[pass] [varchar](70) NULL,
	[baja] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VIAJES]    Script Date: 10/11/2021 0:31:50 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VIAJES](
	[id_viaje] [int] NOT NULL,
	[id_camion] [int] NULL,
	[origen] [varchar](50) NULL,
	[destino] [varchar](50) NULL,
	[finalizado] [bit] NULL,
	[fecha_salida] [datetime] NULL,
	[fecha_llegada] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_viaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[CAMIONES] ([id_camion], [descripcion], [patente], [id_camionero], [estado], [peso_maximo], [situado], [baja]) VALUES (1, N'Mercedes Accelo (1)', N'AE452CF', 3, 2, CAST(6161.00 AS Decimal(10, 2)), N'Mendoza', 0)
GO
INSERT [dbo].[CAMIONES] ([id_camion], [descripcion], [patente], [id_camionero], [estado], [peso_maximo], [situado], [baja]) VALUES (2, N'Izuzu NPR (2)', N'AE856DF', 5, 1, CAST(4795.00 AS Decimal(10, 2)), N'Córdoba', 0)
GO
INSERT [dbo].[CAMIONES] ([id_camion], [descripcion], [patente], [id_camionero], [estado], [peso_maximo], [situado], [baja]) VALUES (3, N'Iveco Vertis (3)', N'AE863HY', 6, 1, CAST(7795.00 AS Decimal(10, 2)), N'Mendoza', 0)
GO
INSERT [dbo].[CAMIONES] ([id_camion], [descripcion], [patente], [id_camionero], [estado], [peso_maximo], [situado], [baja]) VALUES (4, N'Izuzu NPR (4)', N'AE556ED', 7, 2, CAST(4795.00 AS Decimal(10, 2)), N'Buenos Aires', 0)
GO
INSERT [dbo].[CAMIONES] ([id_camion], [descripcion], [patente], [id_camionero], [estado], [peso_maximo], [situado], [baja]) VALUES (5, N'Mercedes Accelo (5)', N'AE428FD', 8, 1, CAST(6161.00 AS Decimal(10, 2)), N'Córdoba', 0)
GO
INSERT [dbo].[CAMIONES] ([id_camion], [descripcion], [patente], [id_camionero], [estado], [peso_maximo], [situado], [baja]) VALUES (6, N'Iveco Vetis (6)', N'AE268ER', 4, 1, CAST(7755.00 AS Decimal(10, 2)), N'Mendoza', 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (1, 1, CAST(520.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (1, 2, CAST(460.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (1, 3, CAST(860.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (1, 4, CAST(650.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (1, 5, CAST(870.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (1, 6, CAST(600.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (2, 1, CAST(550.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (2, 2, CAST(860.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (2, 3, CAST(560.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (2, 4, CAST(630.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (2, 5, CAST(920.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (2, 6, CAST(460.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (2, 7, CAST(580.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (2, 8, CAST(900.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (2, 9, CAST(450.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (3, 1, CAST(860.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (3, 2, CAST(960.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (3, 3, CAST(800.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (3, 4, CAST(460.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (3, 5, CAST(590.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (3, 6, CAST(680.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (3, 7, CAST(390.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (4, 1, CAST(800.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (4, 2, CAST(600.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (4, 3, CAST(960.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (4, 4, CAST(450.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (4, 5, CAST(860.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (4, 6, CAST(700.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (4, 7, CAST(620.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (4, 8, CAST(460.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (4, 9, CAST(800.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (5, 1, CAST(650.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (5, 2, CAST(750.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (5, 3, CAST(640.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (5, 4, CAST(320.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (5, 5, CAST(940.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (5, 6, CAST(800.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (5, 7, CAST(760.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (6, 1, CAST(640.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (6, 2, CAST(500.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (6, 3, CAST(700.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (6, 4, CAST(640.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (6, 5, CAST(700.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (6, 6, CAST(670.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (6, 7, CAST(940.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (6, 8, CAST(830.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (6, 9, CAST(460.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (7, 1, CAST(460.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (7, 2, CAST(700.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (7, 3, CAST(650.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (7, 4, CAST(970.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (7, 5, CAST(450.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (7, 6, CAST(650.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (8, 1, CAST(400.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (8, 2, CAST(840.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (8, 3, CAST(640.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (8, 4, CAST(750.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (8, 5, CAST(940.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (8, 6, CAST(490.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (8, 7, CAST(490.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (8, 8, CAST(460.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (8, 9, CAST(750.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (8, 10, CAST(500.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (9, 1, CAST(460.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (9, 2, CAST(940.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (9, 3, CAST(750.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (9, 4, CAST(940.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (9, 5, CAST(750.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (9, 6, CAST(940.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (9, 7, CAST(460.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (9, 8, CAST(490.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (9, 9, CAST(560.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (10, 1, CAST(460.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (10, 2, CAST(940.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (10, 3, CAST(940.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (10, 4, CAST(640.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (10, 5, CAST(560.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (10, 6, CAST(940.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (11, 1, CAST(460.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (11, 2, CAST(940.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (11, 3, CAST(630.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (11, 4, CAST(940.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (11, 5, CAST(620.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (11, 6, CAST(460.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (12, 1, CAST(940.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (12, 2, CAST(940.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (12, 3, CAST(640.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (12, 4, CAST(780.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (12, 5, CAST(750.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (12, 6, CAST(940.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (13, 1, CAST(460.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (13, 2, CAST(720.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (13, 3, CAST(840.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (13, 4, CAST(640.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (13, 5, CAST(460.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (13, 6, CAST(460.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (13, 7, CAST(540.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (13, 8, CAST(940.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (14, 1, CAST(460.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (14, 2, CAST(940.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (14, 3, CAST(940.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (14, 4, CAST(560.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (14, 5, CAST(840.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (14, 6, CAST(760.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (15, 1, CAST(450.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (15, 2, CAST(450.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (15, 3, CAST(560.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (15, 4, CAST(940.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (15, 5, CAST(640.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (15, 6, CAST(840.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (15, 7, CAST(640.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (15, 8, CAST(940.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (15, 9, CAST(640.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (16, 1, CAST(460.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (16, 2, CAST(750.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (16, 3, CAST(640.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (16, 4, CAST(940.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (16, 5, CAST(460.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (16, 6, CAST(760.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (16, 7, CAST(460.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (16, 8, CAST(500.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (17, 1, CAST(490.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (17, 2, CAST(640.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (17, 3, CAST(760.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (17, 4, CAST(860.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (17, 5, CAST(460.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (17, 6, CAST(750.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (17, 7, CAST(460.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (17, 8, CAST(760.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (18, 1, CAST(460.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (18, 2, CAST(940.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (18, 3, CAST(760.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (18, 4, CAST(320.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (18, 5, CAST(460.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (18, 6, CAST(860.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (18, 7, CAST(560.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (19, 1, CAST(460.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (19, 2, CAST(760.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (19, 3, CAST(940.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (19, 4, CAST(640.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (19, 5, CAST(640.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (19, 6, CAST(860.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (20, 1, CAST(460.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (20, 2, CAST(760.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (20, 3, CAST(500.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (20, 4, CAST(460.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (20, 5, CAST(940.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (20, 6, CAST(460.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (20, 7, CAST(450.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (21, 1, CAST(490.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (21, 2, CAST(460.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (21, 3, CAST(940.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (21, 4, CAST(520.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (21, 5, CAST(640.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (21, 6, CAST(460.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (21, 7, CAST(940.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (21, 8, CAST(640.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (22, 1, CAST(460.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (22, 2, CAST(750.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (22, 3, CAST(640.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (22, 4, CAST(940.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (22, 5, CAST(640.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (22, 6, CAST(860.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (23, 1, CAST(460.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (23, 2, CAST(940.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (23, 3, CAST(640.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (23, 4, CAST(460.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (23, 5, CAST(760.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (23, 6, CAST(750.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (23, 7, CAST(460.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (23, 8, CAST(480.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (24, 1, CAST(640.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (24, 2, CAST(460.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (24, 3, CAST(460.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (24, 4, CAST(940.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (24, 5, CAST(940.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (24, 6, CAST(460.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (25, 1, CAST(460.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (25, 2, CAST(650.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (25, 3, CAST(970.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (25, 4, CAST(460.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (25, 5, CAST(940.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (25, 6, CAST(640.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (25, 7, CAST(940.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (25, 8, CAST(450.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (25, 9, CAST(460.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (26, 1, CAST(460.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (26, 2, CAST(940.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (26, 3, CAST(640.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (26, 4, CAST(860.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (26, 5, CAST(560.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (26, 6, CAST(350.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (27, 1, CAST(460.00 AS Decimal(8, 2)), 1, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (27, 2, CAST(940.00 AS Decimal(8, 2)), 2, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (27, 3, CAST(750.00 AS Decimal(8, 2)), 3, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (27, 4, CAST(640.00 AS Decimal(8, 2)), 3, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (27, 5, CAST(750.00 AS Decimal(8, 2)), 1, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (27, 6, CAST(800.00 AS Decimal(8, 2)), 2, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (27, 7, CAST(500.00 AS Decimal(8, 2)), 3, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (28, 1, CAST(460.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (28, 2, CAST(940.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (28, 3, CAST(640.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (28, 4, CAST(460.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (28, 5, CAST(555.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (28, 6, CAST(460.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (28, 7, CAST(840.00 AS Decimal(8, 2)), 2, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (28, 8, CAST(460.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (28, 9, CAST(760.00 AS Decimal(8, 2)), 3, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (28, 10, CAST(430.00 AS Decimal(8, 2)), 1, 0)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (29, 1, CAST(460.00 AS Decimal(8, 2)), 1, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (29, 2, CAST(940.00 AS Decimal(8, 2)), 3, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (29, 3, CAST(500.00 AS Decimal(8, 2)), 2, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (29, 4, CAST(750.00 AS Decimal(8, 2)), 3, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (29, 5, CAST(640.00 AS Decimal(8, 2)), 3, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (29, 6, CAST(860.00 AS Decimal(8, 2)), 2, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (30, 1, CAST(460.00 AS Decimal(8, 2)), 1, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (30, 2, CAST(900.00 AS Decimal(8, 2)), 2, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (30, 3, CAST(500.00 AS Decimal(8, 2)), 3, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (30, 4, CAST(620.00 AS Decimal(8, 2)), 2, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (30, 5, CAST(460.00 AS Decimal(8, 2)), 1, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (30, 6, CAST(760.00 AS Decimal(8, 2)), 2, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (30, 7, CAST(630.00 AS Decimal(8, 2)), 1, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (30, 8, CAST(800.00 AS Decimal(8, 2)), 3, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (30, 9, CAST(460.00 AS Decimal(8, 2)), 2, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (30, 10, CAST(500.00 AS Decimal(8, 2)), 1, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (31, 1, CAST(460.00 AS Decimal(8, 2)), 1, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (31, 2, CAST(450.00 AS Decimal(8, 2)), 2, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (31, 3, CAST(700.00 AS Decimal(8, 2)), 3, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (31, 4, CAST(940.00 AS Decimal(8, 2)), 2, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (31, 5, CAST(400.00 AS Decimal(8, 2)), 2, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (31, 6, CAST(600.00 AS Decimal(8, 2)), 3, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (31, 7, CAST(760.00 AS Decimal(8, 2)), 1, 1)
GO
INSERT [dbo].[CARGAS] ([id_viaje], [id_carga], [peso], [id_tipo_carga], [cargado]) VALUES (31, 8, CAST(640.00 AS Decimal(8, 2)), 2, 1)
GO
INSERT [dbo].[TIPOS_CARGAS] ([id_tipo_carga], [nombre]) VALUES (1, N'Packing')
GO
INSERT [dbo].[TIPOS_CARGAS] ([id_tipo_carga], [nombre]) VALUES (2, N'Caja')
GO
INSERT [dbo].[TIPOS_CARGAS] ([id_tipo_carga], [nombre]) VALUES (3, N'Bidon')
GO
INSERT [dbo].[TIPOS_USUARIOS] ([id_tipo_usuario], [tipo]) VALUES (1, N'Administrador')
GO
INSERT [dbo].[TIPOS_USUARIOS] ([id_tipo_usuario], [tipo]) VALUES (2, N'Camionero')
GO
INSERT [dbo].[USUARIOS] ([id_usuario], [nombre], [apellido], [documento], [telefono], [id_tipo_usuario], [username], [pass], [baja]) VALUES (1, N'admin', N'admin', N'32456789', N'3518568849', 1, N'admin', N'8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 0)
GO
INSERT [dbo].[USUARIOS] ([id_usuario], [nombre], [apellido], [documento], [telefono], [id_tipo_usuario], [username], [pass], [baja]) VALUES (2, N'Jorge', N'Garcia', N'23856854', N'3514895675', 2, N'jorge', N'8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 0)
GO
INSERT [dbo].[USUARIOS] ([id_usuario], [nombre], [apellido], [documento], [telefono], [id_tipo_usuario], [username], [pass], [baja]) VALUES (3, N'Emiliano', N'Loyola', N'36452786', N'3514527463', 2, N'emiliano', N'8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 0)
GO
INSERT [dbo].[USUARIOS] ([id_usuario], [nombre], [apellido], [documento], [telefono], [id_tipo_usuario], [username], [pass], [baja]) VALUES (4, N'Ricardo', N'Lozada', N'20365489', N'3518653274', 2, N'ricardo', N'8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 0)
GO
INSERT [dbo].[USUARIOS] ([id_usuario], [nombre], [apellido], [documento], [telefono], [id_tipo_usuario], [username], [pass], [baja]) VALUES (5, N'Humberto', N'Aguada', N'36215896', N'3512458596', 2, N'humberto', N'8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 0)
GO
INSERT [dbo].[USUARIOS] ([id_usuario], [nombre], [apellido], [documento], [telefono], [id_tipo_usuario], [username], [pass], [baja]) VALUES (6, N'Rodrigo', N'Aguirre', N'34258493', N'3514659825', 2, N'rodrigo', N'8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 0)
GO
INSERT [dbo].[USUARIOS] ([id_usuario], [nombre], [apellido], [documento], [telefono], [id_tipo_usuario], [username], [pass], [baja]) VALUES (7, N'Ignacio', N'Estevez', N'28524759', N'3514258746', 2, N'ignacio', N'8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 0)
GO
INSERT [dbo].[USUARIOS] ([id_usuario], [nombre], [apellido], [documento], [telefono], [id_tipo_usuario], [username], [pass], [baja]) VALUES (8, N'Florecia', N'Martinez', N'32856324', N'3514527963', 2, N'florencia', N'481f6cc0511143ccdd7e2d1b1b94faf0a700a8b49cd13922a70b5ae28acaa8c5', 0)
GO
INSERT [dbo].[USUARIOS] ([id_usuario], [nombre], [apellido], [documento], [telefono], [id_tipo_usuario], [username], [pass], [baja]) VALUES (9, N'Santiago', N'Suarez', N'24529436', N'3514286825', 2, N'santiago', N'8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92', 0)
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (1, 2, N'Cordoba', N'Jujuy', 1, CAST(N'2021-09-18T00:00:00.000' AS DateTime), CAST(N'2021-09-19T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (2, 3, N'Cordoba', N'Mendoza', 1, CAST(N'2021-09-20T00:00:00.000' AS DateTime), CAST(N'2021-09-21T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (3, 5, N'Cordoba', N'Buenos Aires', 1, CAST(N'2021-09-22T00:00:00.000' AS DateTime), CAST(N'2021-09-23T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (4, 6, N'Cordoba', N'Mendoza', 1, CAST(N'2021-09-24T00:00:00.000' AS DateTime), CAST(N'2021-09-25T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (5, 1, N'Cordoba', N'Mendoza', 1, CAST(N'2021-09-26T00:00:00.000' AS DateTime), CAST(N'2021-09-27T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (6, 3, N'Mendoza', N'Buenos Aires', 1, CAST(N'2021-09-28T00:00:00.000' AS DateTime), CAST(N'2021-09-29T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (7, 4, N'Cordoba', N'Jujuy', 1, CAST(N'2021-09-30T00:00:00.000' AS DateTime), CAST(N'2021-10-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (8, 6, N'Mendoza', N'Córdoba', 1, CAST(N'2021-10-02T00:00:00.000' AS DateTime), CAST(N'2021-10-03T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (9, 3, N'Buenos Aires', N'Mendoza', 1, CAST(N'2021-10-04T00:00:00.000' AS DateTime), CAST(N'2021-10-05T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (10, 2, N'Jujuy', N'Córdoba', 1, CAST(N'2021-10-06T00:00:00.000' AS DateTime), CAST(N'2021-10-07T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (11, 2, N'Córdoba', N'Jujuy', 1, CAST(N'2021-10-08T00:00:00.000' AS DateTime), CAST(N'2021-10-09T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (12, 5, N'Buenos Aires', N'Córcoba', 1, CAST(N'2021-10-10T00:00:00.000' AS DateTime), CAST(N'2021-10-11T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (13, 1, N'Mendoza', N'Córcoba', 1, CAST(N'2021-10-12T00:00:00.000' AS DateTime), CAST(N'2021-10-13T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (14, 4, N'Jujuy', N'Córdoba', 1, CAST(N'2021-10-14T00:00:00.000' AS DateTime), CAST(N'2021-10-15T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (15, 6, N'Córdoba', N'Jujuy', 1, CAST(N'2021-10-16T00:00:00.000' AS DateTime), CAST(N'2021-10-17T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (16, 5, N'Córcoba', N'Jujuy', 1, CAST(N'2021-10-18T00:00:00.000' AS DateTime), CAST(N'2021-10-19T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (17, 1, N'Buenos Aires', N'Córdoba', 1, CAST(N'2021-10-20T00:00:00.000' AS DateTime), CAST(N'2021-10-21T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (18, 2, N'Jujuy', N'Córdoba', 1, CAST(N'2021-10-22T00:00:00.000' AS DateTime), CAST(N'2021-10-23T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (19, 4, N'Córdoba', N'Jujuy', 1, CAST(N'2021-10-24T00:00:00.000' AS DateTime), CAST(N'2021-10-25T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (20, 2, N'Córdoba', N'Jujuy', 1, CAST(N'2021-10-26T00:00:00.000' AS DateTime), CAST(N'2021-10-27T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (21, 5, N'Jujuy', N'Córdoba', 1, CAST(N'2021-10-28T00:00:00.000' AS DateTime), CAST(N'2021-10-29T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (22, 4, N'Jujuy', N'Córdoba', 1, CAST(N'2021-10-30T00:00:00.000' AS DateTime), CAST(N'2021-10-31T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (23, 1, N'Córdoba', N'Mendoza', 1, CAST(N'2021-11-01T00:00:00.000' AS DateTime), CAST(N'2021-11-02T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (24, 2, N'Jujuy', N'Córdoba', 1, CAST(N'2021-11-03T00:00:00.000' AS DateTime), CAST(N'2021-11-04T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (25, 3, N'Córdoba', N'Mendoza', 1, CAST(N'2021-11-05T00:00:00.000' AS DateTime), CAST(N'2021-11-06T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (26, 4, N'Córdoba', N'Buenos Aires', 1, CAST(N'2021-11-07T00:00:00.000' AS DateTime), CAST(N'2021-11-08T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (27, 1, N'Mendoza', N'Córdoba', 0, CAST(N'2021-11-10T00:00:00.000' AS DateTime), CAST(N'2021-09-19T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (28, 6, N'Córdoba', N'Mendoza', 1, CAST(N'2021-11-09T00:00:00.000' AS DateTime), CAST(N'2021-11-10T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (29, 4, N'Buenos Aires', N'Córdoba', 0, CAST(N'2021-11-10T00:00:00.000' AS DateTime), CAST(N'1900-01-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (30, 6, N'Mendoza', N'Córdoba', 0, CAST(N'1900-01-01T00:00:00.000' AS DateTime), CAST(N'1900-01-01T00:00:00.000' AS DateTime))
GO
INSERT [dbo].[VIAJES] ([id_viaje], [id_camion], [origen], [destino], [finalizado], [fecha_salida], [fecha_llegada]) VALUES (31, 5, N'Córdoba', N'Jujuy', 0, CAST(N'1900-01-01T00:00:00.000' AS DateTime), CAST(N'1900-01-01T00:00:00.000' AS DateTime))
GO
ALTER TABLE [dbo].[CAMIONES]  WITH CHECK ADD FOREIGN KEY([id_camionero])
REFERENCES [dbo].[USUARIOS] ([id_usuario])
GO
ALTER TABLE [dbo].[CARGAS]  WITH CHECK ADD FOREIGN KEY([id_tipo_carga])
REFERENCES [dbo].[TIPOS_CARGAS] ([id_tipo_carga])
GO
ALTER TABLE [dbo].[CARGAS]  WITH CHECK ADD FOREIGN KEY([id_viaje])
REFERENCES [dbo].[VIAJES] ([id_viaje])
GO
ALTER TABLE [dbo].[USUARIOS]  WITH CHECK ADD FOREIGN KEY([id_tipo_usuario])
REFERENCES [dbo].[TIPOS_USUARIOS] ([id_tipo_usuario])
GO
ALTER TABLE [dbo].[VIAJES]  WITH CHECK ADD FOREIGN KEY([id_camion])
REFERENCES [dbo].[CAMIONES] ([id_camion])
GO
/****** Object:  StoredProcedure [dbo].[PA_BAJA_CAMION]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[PA_BAJA_CAMION]
@id int
as
update CAMIONES
set baja = 1
where id_camion = @id
GO
/****** Object:  StoredProcedure [dbo].[PA_BAJA_USUARIO]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[PA_BAJA_USUARIO]
@id int
as
update USUARIOS
set baja = 1
where id_usuario = @id

--create proc PA_DELETE_USUARIO
--@id int
--as
--delete USUARIOS
--where id_usuario = @id

----- CAMION -------------------------------------------------------------------------------------------------------------

GO
/****** Object:  StoredProcedure [dbo].[PA_CONSULTAR_CAMION_ID]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PA_CONSULTAR_CAMION_ID]
@id int
as
    select *
    from CAMIONES 
    where id_camion = @id
GO
/****** Object:  StoredProcedure [dbo].[PA_DELETE_CARGA]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PA_DELETE_CARGA]
@id_viaje int,
@id_carga int
as
delete CARGAS
where id_viaje = @id_viaje and id_carga = @id_carga
GO
/****** Object:  StoredProcedure [dbo].[PA_DESCARGAR_CAMION]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PA_DESCARGAR_CAMION]
@id_viaje int
as
update CARGAS
set cargado = 0
where id_viaje = @id_viaje
GO
/****** Object:  StoredProcedure [dbo].[PA_DESCARGAR_CARGA]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PA_DESCARGAR_CARGA]
@id_viaje int,
@id_carga int
as
update CARGAS
set cargado = 0
where id_viaje = @id_viaje and id_carga = @id_carga
GO
/****** Object:  StoredProcedure [dbo].[PA_ESTADO_SITUADO]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[PA_ESTADO_SITUADO]
@id_camion int,
@estado int,
@situado varchar(50)
as
update CAMIONES
set estado = @estado, situado = @situado
where id_camion = @id_camion

GO
/****** Object:  StoredProcedure [dbo].[PA_FINALIZAR_VIAJE]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PA_FINALIZAR_VIAJE]
@id int,
@fecha_llagada datetime
as
update VIAJES
set finalizado = 1, fecha_llegada = @fecha_llagada
where id_viaje = @id

update CARGAS
set cargado = 0
where id_viaje = @id
GO
/****** Object:  StoredProcedure [dbo].[PA_INSERT_CARGA]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PA_INSERT_CARGA]
@id_viaje int,
@id_carga int,
@peso decimal(8,2),
@id_tipo_carga int,
@cargado bit
as
insert into CARGAS
values(@id_viaje, @id_carga, @peso, @id_tipo_carga, @cargado)
GO
/****** Object:  StoredProcedure [dbo].[PA_INSERTAR_CAMION]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PA_INSERTAR_CAMION]
@id int,
@descripcion varchar(50),
@patente varchar(50),
@id_camionero int,
@estado int = 1,
@peso_maximo decimal (10,2),
@situado varchar(50) = 'Córdoba'
as	
insert into CAMIONES
values(@id, @descripcion, @patente, @id_camionero, @estado, @peso_maximo, @situado, 0)
GO
/****** Object:  StoredProcedure [dbo].[PA_INSERTAR_USUARIO]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PA_INSERTAR_USUARIO]
@id int,
@nombre varchar(50),
@apellido varchar(50),
@documento varchar(20),
@telefono varchar(100),
@id_tipo_usuario int,
@user varchar (50),
@pass varchar(70)
as
insert into USUARIOS
values(@id, @nombre, @apellido, @documento, @telefono, @id_tipo_usuario, @user, @pass, 0)
GO
/****** Object:  StoredProcedure [dbo].[PA_INSERTAR_VIAJE]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[PA_INSERTAR_VIAJE]
@id_viaje int,
@id_camion int,
@origen varchar(50),
@destino varchar(50),
@finalizado bit = 0,
@fecha_salida datetime = '01/01/1900',
@fecha_llegada datetime = '01/01/1900'
as
insert into VIAJES
values(@id_viaje, @id_camion, @origen, @destino, @finalizado, @fecha_salida, @fecha_llegada)
GO
/****** Object:  StoredProcedure [dbo].[PA_LOGIN_USUARIO]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PA_LOGIN_USUARIO]
@usuario varchar (50),
@pass varchar(70)
as
begin
if exists(select * from usuarios where username = @usuario and pass = @pass and baja = 0)
select 1
else
select 0
end
GO
/****** Object:  StoredProcedure [dbo].[PA_OBTENER_CAMIONEROS]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PA_OBTENER_CAMIONEROS]
as
select id_usuario, nombre, apellido, telefono, documento, id_tipo_usuario 
from USUARIOS u
where id_tipo_usuario = 2 and baja = 0
GO
/****** Object:  StoredProcedure [dbo].[PA_OBTENER_CAMIONEROS_SIN_CAMION]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PA_OBTENER_CAMIONEROS_SIN_CAMION]
as
select id_usuario, nombre, apellido, telefono, documento, id_tipo_usuario 
from USUARIOS u
where id_tipo_usuario = 2 and baja = 0 and not exists(select * 
										              from CAMIONES c
									                  where c.id_camionero = u.id_usuario)
GO
/****** Object:  StoredProcedure [dbo].[PA_OBTENER_CAMIONES]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PA_OBTENER_CAMIONES]
as
select id_camion, descripcion, patente, id_camionero, estado, peso_maximo, situado
from CAMIONES
where baja = 0
GO
/****** Object:  StoredProcedure [dbo].[PA_OBTENER_CAMIONES_LIBRES]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[PA_OBTENER_CAMIONES_LIBRES]
as
select ca.id_camion, descripcion, patente, id_camionero, estado, peso_maximo, situado
from CAMIONES ca
where not exists (select * 
				  from CAMIONES c join VIAJES v on c.id_camion = v.id_camion 
				  where finalizado = 0 and ca.id_camion = c.id_camion) and ca.baja = 0

GO
/****** Object:  StoredProcedure [dbo].[PA_OBTENER_CARGAS]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PA_OBTENER_CARGAS]
@id_viaje int
as
select id_carga, id_viaje, peso, id_tipo_carga, cargado
from CARGAS
where id_viaje = @id_viaje and cargado = 1
GO
/****** Object:  StoredProcedure [dbo].[PA_OBTENER_USUARIOS]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PA_OBTENER_USUARIOS]
as
select id_usuario, nombre, apellido, documento, telefono, id_tipo_usuario
from USUARIOS
where baja = 0
GO
/****** Object:  StoredProcedure [dbo].[PA_OBTENER_VIAJES]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PA_OBTENER_VIAJES]
as
select *
from VIAJES
where finalizado = 0
GO
/****** Object:  StoredProcedure [dbo].[PA_PARTIR_VIAJE]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PA_PARTIR_VIAJE]
@id int,
@fecha_salida datetime
as
update VIAJES
set fecha_salida = @fecha_salida
where id_viaje = @id
GO
/****** Object:  StoredProcedure [dbo].[PA_PROXIMO_ID_CAMION]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[PA_PROXIMO_ID_CAMION]
as
select MAX(id_camion) from CAMIONES

GO
/****** Object:  StoredProcedure [dbo].[PA_PROXIMO_ID_USUARIO]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[PA_PROXIMO_ID_USUARIO]
as
select MAX(id_usuario) from USUARIOS

GO
/****** Object:  StoredProcedure [dbo].[PA_PROXIMO_ID_VIAJE]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PA_PROXIMO_ID_VIAJE]
as
select MAX(id_viaje) from VIAJES
GO
/****** Object:  StoredProcedure [dbo].[PA_REPORTE]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create   proc [dbo].[PA_REPORTE]
@id_camion int = null,
@origen varchar(50) = null,
@destino varchar(50) = null,
@finalizado bit,
@fecha_desde datetime = null,
@fecha_hasta datetime = null
as
begin

if(@finalizado = 0)

select id_viaje, c.descripcion, origen, destino, fecha_salida, fecha_llegada
from VIAJES v join CAMIONES c on v.id_camion = c.id_camion
where
        (@id_camion is null or (v.id_camion = @id_camion))
    and (@origen is null or (origen = @origen ))
    and (@destino is null or (destino = @destino))
	and finalizado = 0

else

select id_viaje, c.descripcion, origen, destino, fecha_salida, fecha_llegada
from VIAJES v join CAMIONES c on v.id_camion = c.id_camion
where
        (@id_camion is null or (v.id_camion = @id_camion))
    and (@origen is null or (origen = @origen ))
    and (@destino is null or (destino = @destino))
	and fecha_llegada between @fecha_desde and @fecha_hasta
	and finalizado = 1

end
GO
/****** Object:  StoredProcedure [dbo].[PA_TIPOS_DE_CARGAS]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PA_TIPOS_DE_CARGAS]
as
select * from TIPOS_CARGAS
GO
/****** Object:  StoredProcedure [dbo].[PA_UPDATE_CAMION]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[PA_UPDATE_CAMION]
@id int,
@descripcion varchar(50),
@patente varchar(50),
@id_camionero int,
@estado int,
@peso_maximo decimal (10,2),
@situado varchar(50)
as
update CAMIONES
set id_camionero = @id_camionero
where id_camion = @id

GO
/****** Object:  StoredProcedure [dbo].[PA_UPDATE_USUARIO]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PA_UPDATE_USUARIO]
@id int,
@nombre varchar(50),
@apellido varchar(50),
@documento varchar(20),
@telefono varchar(100),
@id_tipo_usuario int,
@user varchar(50),
@pass varchar(70)
as
begin
if @user = '0'
select @user = username from USUARIOS where id_usuario = @id

if @pass = '0'
select @pass = pass from USUARIOS where id_usuario = @id

update USUARIOS
set nombre = @nombre, apellido = @apellido, documento = @documento, telefono = @telefono, id_tipo_usuario = @id_tipo_usuario, username = @user, pass = @pass
where id_usuario = @id
end
GO
/****** Object:  StoredProcedure [dbo].[PA_UPDATE_VIAJE]    Script Date: 10/11/2021 0:31:51 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[PA_UPDATE_VIAJE]
@id_viaje int
as
begin

delete CARGAS
where id_viaje = @id_viaje

end
GO
USE [master]
GO
ALTER DATABASE [TRANSPORTE_CARGAS] SET  READ_WRITE 
GO
