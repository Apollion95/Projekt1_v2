USE [master]
GO
/****** Object:  Database [WypozyczalniaFilmowDB]    Script Date: 06.06.2021 13:56:55 ******/
CREATE DATABASE [WypozyczalniaFilmowDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WypozyczalniaFilmowDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\WypozyczalniaFilmowDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WypozyczalniaFilmowDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\WypozyczalniaFilmowDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WypozyczalniaFilmowDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET  MULTI_USER 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET QUERY_STORE = OFF
GO
USE [WypozyczalniaFilmowDB]
GO
/****** Object:  Table [dbo].[dostepnosc]    Script Date: 06.06.2021 13:56:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[dostepnosc](
	[ID_Nosnika] [nchar](10) NOT NULL,
	[IlośćDostępnychKopii] [nchar](10) NULL,
	[TypNosnika] [nchar](40) NULL,
 CONSTRAINT [PK_dostepnosc] PRIMARY KEY CLUSTERED 
(
	[ID_Nosnika] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Film]    Script Date: 06.06.2021 13:56:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Film](
	[ID_filmu] [nchar](10) NOT NULL,
	[Nazwa] [nchar](40) NULL,
	[Gatunek] [nchar](40) NULL,
	[Wydawca] [nchar](40) NULL,
	[CenaZaDobe] [nchar](40) NULL,
	[ID_Nosnika] [nchar](10) NULL,
 CONSTRAINT [PK_Film] PRIMARY KEY CLUSTERED 
(
	[ID_filmu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kontakt_Klient]    Script Date: 06.06.2021 13:56:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kontakt_Klient](
	[id_klienta] [nchar](10) NOT NULL,
	[numer_telefonu] [nchar](10) NULL,
	[Imie] [nchar](10) NULL,
	[Nazwisko] [nchar](10) NULL,
	[Nazwa] [nchar](10) NULL,
 CONSTRAINT [PK_Kontakt_Klient] PRIMARY KEY CLUSTERED 
(
	[id_klienta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pracownik]    Script Date: 06.06.2021 13:56:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pracownik](
	[ID_Pracownik] [nchar](10) NOT NULL,
	[Nazwisko_Pracownik] [nchar](40) NULL,
	[Imie_Pracownik] [nchar](40) NULL,
	[telefon] [nchar](40) NULL,
	[Wiek] [nchar](40) NULL,
 CONSTRAINT [PK_Pracownik] PRIMARY KEY CLUSTERED 
(
	[ID_Pracownik] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Wynajem]    Script Date: 06.06.2021 13:56:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Wynajem](
	[ID_Wypozyczenia] [nchar](10) NOT NULL,
	[id_klienta] [nchar](10) NULL,
	[ID_filmu] [nchar](10) NULL,
	[DataWypozyczenia] [date] NULL,
	[DataZwrotu] [date] NULL,
 CONSTRAINT [PK_Wynajem] PRIMARY KEY CLUSTERED 
(
	[ID_Wypozyczenia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Film]  WITH CHECK ADD  CONSTRAINT [FK_Film_dostepnosc] FOREIGN KEY([ID_Nosnika])
REFERENCES [dbo].[dostepnosc] ([ID_Nosnika])
GO
ALTER TABLE [dbo].[Film] CHECK CONSTRAINT [FK_Film_dostepnosc]
GO
ALTER TABLE [dbo].[Wynajem]  WITH CHECK ADD  CONSTRAINT [FK_Wynajem_Film] FOREIGN KEY([ID_filmu])
REFERENCES [dbo].[Film] ([ID_filmu])
GO
ALTER TABLE [dbo].[Wynajem] CHECK CONSTRAINT [FK_Wynajem_Film]
GO
ALTER TABLE [dbo].[Wynajem]  WITH CHECK ADD  CONSTRAINT [FK_Wynajem_Kontakt_Klient] FOREIGN KEY([id_klienta])
REFERENCES [dbo].[Kontakt_Klient] ([id_klienta])
GO
ALTER TABLE [dbo].[Wynajem] CHECK CONSTRAINT [FK_Wynajem_Kontakt_Klient]
GO
ALTER TABLE [dbo].[Wynajem]  WITH CHECK ADD  CONSTRAINT [FK_Wynajem_Pracownik] FOREIGN KEY([ID_Wypozyczenia])
REFERENCES [dbo].[Pracownik] ([ID_Pracownik])
GO
ALTER TABLE [dbo].[Wynajem] CHECK CONSTRAINT [FK_Wynajem_Pracownik]
GO
USE [master]
GO
ALTER DATABASE [WypozyczalniaFilmowDB] SET  READ_WRITE 
GO
