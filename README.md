# HackatonChallenge6

DataBase Structure

```sql

USE [master]
GO

CREATE DATABASE [Hackaton]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hackaton', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Hackaton.mdf' , SIZE = 466944KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hackaton_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Hackaton_log.ldf' , SIZE = 925696KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Hackaton] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hackaton].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hackaton] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hackaton] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hackaton] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hackaton] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hackaton] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hackaton] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hackaton] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hackaton] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hackaton] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hackaton] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hackaton] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hackaton] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hackaton] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hackaton] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hackaton] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Hackaton] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hackaton] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hackaton] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hackaton] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hackaton] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hackaton] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Hackaton] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hackaton] SET RECOVERY FULL 
GO
ALTER DATABASE [Hackaton] SET  MULTI_USER 
GO
ALTER DATABASE [Hackaton] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hackaton] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hackaton] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hackaton] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hackaton] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Hackaton', N'ON'
GO
ALTER DATABASE [Hackaton] SET QUERY_STORE = OFF
GO
USE [Hackaton]
GO
/****** Object:  Table [dbo].[datos]    Script Date: 8/5/2022 02:54:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[datos](
	[id_datos] [int] NOT NULL,
	[pais] [nvarchar](50) NOT NULL,
	[region] [nvarchar](50) NOT NULL,
	[ano] [nvarchar](50) NOT NULL,
	[area] [nvarchar](50) NOT NULL,
	[sexo] [nvarchar](50) NOT NULL,
	[grupo_edad] [nvarchar](50) NOT NULL,
	[clima_educativo] [nvarchar](50) NOT NULL,
	[nivel_ingresos] [nvarchar](50) NULL,
	[indicador] [nvarchar](50) NOT NULL,
	[valor_indicador] [nvarchar](50) NOT NULL,
	[factor] [nvarchar](50) NOT NULL,
	[muestra] [nvarchar](50) NULL,
 CONSTRAINT [PK_datos] PRIMARY KEY CLUSTERED 
(
	[id_datos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[fuentes]    Script Date: 8/5/2022 02:54:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[fuentes](
	[id_pais] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_fuentes] PRIMARY KEY CLUSTERED 
(
	[id_pais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[labels_anos_estudio]    Script Date: 8/5/2022 02:54:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[labels_anos_estudio](
	[id_indicador] [int] NOT NULL,
	[id_grupo_edad] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[labels_area]    Script Date: 8/5/2022 02:54:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[labels_area](
	[id_area] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_labels_area] PRIMARY KEY CLUSTERED 
(
	[id_area] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[labels_cat_indicador]    Script Date: 8/5/2022 02:54:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[labels_cat_indicador](
	[id_catIndicador] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_labels_cat_indicador] PRIMARY KEY CLUSTERED 
(
	[id_catIndicador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[labels_clima_educativo]    Script Date: 8/5/2022 02:54:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[labels_clima_educativo](
	[id_clima_educativo] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_labels_clima_educativo] PRIMARY KEY CLUSTERED 
(
	[id_clima_educativo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[labels_grupo_edad]    Script Date: 8/5/2022 02:54:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[labels_grupo_edad](
	[id_indicador] [int] NOT NULL,
	[id_grupo_edad] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[labels_indicador]    Script Date: 8/5/2022 02:54:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[labels_indicador](
	[id_indicador] [nvarchar](50) NOT NULL,
	[cap] [nvarchar](50) NOT NULL,
	[id_catIndicador] [nvarchar](50) NOT NULL,
	[name] [nvarchar](150) NOT NULL,
	[description] [nvarchar](300) NOT NULL,
	[url_glosario] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_labels_indicador] PRIMARY KEY CLUSTERED 
(
	[id_indicador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[labels_nivel_ingresos]    Script Date: 8/5/2022 02:54:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[labels_nivel_ingresos](
	[id_nivel_ingresos] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_labels_nivel_ingresos] PRIMARY KEY CLUSTERED 
(
	[id_nivel_ingresos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[labels_pais]    Script Date: 8/5/2022 02:54:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[labels_pais](
	[id_pais] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_labels_pais] PRIMARY KEY CLUSTERED 
(
	[id_pais] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[labels_region]    Script Date: 8/5/2022 02:54:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[labels_region](
	[id_pais] [nvarchar](50) NOT NULL,
	[id_region] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[labels_sexo]    Script Date: 8/5/2022 02:54:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[labels_sexo](
	[id_sexo] [nvarchar](50) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_labels_sexo] PRIMARY KEY CLUSTERED 
(
	[id_sexo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pais_ano]    Script Date: 8/5/2022 02:54:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pais_ano](
	[id_pais] [int] NOT NULL,
	[ano] [nvarchar](50) NOT NULL,
	[cap] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[datos]  WITH CHECK ADD  CONSTRAINT [FK_datos_labels_area] FOREIGN KEY([area])
REFERENCES [dbo].[labels_area] ([id_area])
GO
ALTER TABLE [dbo].[datos] CHECK CONSTRAINT [FK_datos_labels_area]
GO
ALTER TABLE [dbo].[datos]  WITH CHECK ADD  CONSTRAINT [FK_datos_labels_indicador] FOREIGN KEY([indicador])
REFERENCES [dbo].[labels_indicador] ([id_indicador])
GO
ALTER TABLE [dbo].[datos] CHECK CONSTRAINT [FK_datos_labels_indicador]
GO
ALTER TABLE [dbo].[datos]  WITH CHECK ADD  CONSTRAINT [FK_datos_labels_pais] FOREIGN KEY([pais])
REFERENCES [dbo].[labels_pais] ([id_pais])
GO
ALTER TABLE [dbo].[datos] CHECK CONSTRAINT [FK_datos_labels_pais]
GO
ALTER TABLE [dbo].[datos]  WITH CHECK ADD  CONSTRAINT [FK_datos_labels_sexo] FOREIGN KEY([sexo])
REFERENCES [dbo].[labels_sexo] ([id_sexo])
GO
ALTER TABLE [dbo].[datos] CHECK CONSTRAINT [FK_datos_labels_sexo]
GO
ALTER TABLE [dbo].[fuentes]  WITH CHECK ADD  CONSTRAINT [FK_fuentes_labels_pais] FOREIGN KEY([id_pais])
REFERENCES [dbo].[labels_pais] ([id_pais])
GO
ALTER TABLE [dbo].[fuentes] CHECK CONSTRAINT [FK_fuentes_labels_pais]
GO
ALTER TABLE [dbo].[labels_indicador]  WITH CHECK ADD  CONSTRAINT [FK_labels_indicador_labels_cat_indicador1] FOREIGN KEY([id_catIndicador])
REFERENCES [dbo].[labels_cat_indicador] ([id_catIndicador])
GO
ALTER TABLE [dbo].[labels_indicador] CHECK CONSTRAINT [FK_labels_indicador_labels_cat_indicador1]
GO
USE [master]
GO
ALTER DATABASE [Hackaton] SET  READ_WRITE 
GO

```
