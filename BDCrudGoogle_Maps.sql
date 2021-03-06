USE [master]
GO
/****** Object:  Database [Crud_GoogleMaps]    Script Date: 11/07/2017 23:50:00 ******/
CREATE DATABASE [Crud_GoogleMaps]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Crud_GoogleMaps', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Crud_GoogleMaps.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Crud_GoogleMaps_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\Crud_GoogleMaps_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Crud_GoogleMaps] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Crud_GoogleMaps].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Crud_GoogleMaps] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Crud_GoogleMaps] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Crud_GoogleMaps] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Crud_GoogleMaps] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Crud_GoogleMaps] SET ARITHABORT OFF 
GO
ALTER DATABASE [Crud_GoogleMaps] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [Crud_GoogleMaps] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Crud_GoogleMaps] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Crud_GoogleMaps] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Crud_GoogleMaps] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Crud_GoogleMaps] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Crud_GoogleMaps] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Crud_GoogleMaps] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Crud_GoogleMaps] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Crud_GoogleMaps] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Crud_GoogleMaps] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Crud_GoogleMaps] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Crud_GoogleMaps] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Crud_GoogleMaps] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Crud_GoogleMaps] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Crud_GoogleMaps] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Crud_GoogleMaps] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Crud_GoogleMaps] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Crud_GoogleMaps] SET  MULTI_USER 
GO
ALTER DATABASE [Crud_GoogleMaps] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Crud_GoogleMaps] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Crud_GoogleMaps] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Crud_GoogleMaps] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Crud_GoogleMaps] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Crud_GoogleMaps]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 11/07/2017 23:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 11/07/2017 23:50:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](30) NOT NULL,
	[Apellido] [nvarchar](30) NOT NULL,
	[FechaNacimiento] [datetime] NOT NULL,
	[CX] [nvarchar](100) NOT NULL,
	[CY] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_dbo.Persona] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [Crud_GoogleMaps] SET  READ_WRITE 
GO
