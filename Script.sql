USE [master]
GO
/****** Object:  Database [GestionAgilDeProyectos]    Script Date: 28-06-2023 20:42:41 ******/
CREATE DATABASE [GestionAgilDeProyectos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'aspnet-GestionAgilDeProyectos-53bc9b9d-9d6a-45d4-8429-2a2761773502', FILENAME = N'C:\Users\ibane\aspnet-GestionAgilDeProyectos-53bc9b9d-9d6a-45d4-8429-2a2761773502.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'aspnet-GestionAgilDeProyectos-53bc9b9d-9d6a-45d4-8429-2a2761773502_log', FILENAME = N'C:\Users\ibane\aspnet-GestionAgilDeProyectos-53bc9b9d-9d6a-45d4-8429-2a2761773502_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GestionAgilDeProyectos] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GestionAgilDeProyectos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GestionAgilDeProyectos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET ARITHABORT OFF 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET  ENABLE_BROKER 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET  MULTI_USER 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GestionAgilDeProyectos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GestionAgilDeProyectos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [GestionAgilDeProyectos] SET QUERY_STORE = OFF
GO
USE [GestionAgilDeProyectos]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 28-06-2023 20:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 28-06-2023 20:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 28-06-2023 20:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 28-06-2023 20:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 28-06-2023 20:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 28-06-2023 20:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[Nombre] [varchar](100) NULL,
	[Apellido] [varchar](100) NULL,
	[Rut] [varchar](9) NULL,
	[FechaNacimiento] [varchar](50) NULL,
	[Terms] [bit] NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 28-06-2023 20:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Comuna]    Script Date: 28-06-2023 20:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comuna](
	[Id] [uniqueidentifier] NOT NULL,
	[ProvinciaID] [uniqueidentifier] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[FechaIngreso] [datetime2](7) NOT NULL,
	[FechaActualizacion] [datetime2](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cursos]    Script Date: 28-06-2023 20:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cursos](
	[Id] [uniqueidentifier] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Direccion] [varchar](max) NOT NULL,
	[Descripcion] [varchar](max) NOT NULL,
	[Logo] [varchar](max) NOT NULL,
	[Portada] [varchar](max) NOT NULL,
	[FechaCurso] [datetime2](7) NOT NULL,
	[FechaIngreso] [datetime2](7) NOT NULL,
	[FechaActualizacion] [datetime2](7) NULL,
	[Estado] [varchar](50) NULL,
	[ComunaID] [uniqueidentifier] NULL,
	[ValorPeso] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inscripcion]    Script Date: 28-06-2023 20:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inscripcion](
	[Id] [uniqueidentifier] NOT NULL,
	[UserID] [varchar](max) NOT NULL,
	[UserMail] [varchar](100) NOT NULL,
	[UserNombre] [varchar](50) NOT NULL,
	[UserTelefono] [varchar](12) NOT NULL,
	[UserRut] [varchar](10) NOT NULL,
	[CursosID] [uniqueidentifier] NOT NULL,
	[Fecha] [datetime2](7) NOT NULL,
	[Estado] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 28-06-2023 20:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincia](
	[Id] [uniqueidentifier] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[FechaIngreso] [datetime2](7) NOT NULL,
	[FechaActualizacion] [datetime2](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Region]    Script Date: 28-06-2023 20:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Region](
	[Id] [uniqueidentifier] NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[FechaIngreso] [datetime2](7) NOT NULL,
	[FechaActualizacion] [datetime2](7) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Nombre], [Apellido], [Rut], [FechaNacimiento], [Terms]) VALUES (N'0cb3514d-4dc5-4838-aa63-a438262250ee', N'eve.orta@test.cl', N'EVE.ORTA@TEST.CL', N'eve.orta@test.cl', N'EVE.ORTA@TEST.CL', 1, N'AQAAAAEAACcQAAAAEOqPe5I+FmtnlZmz3qZ86wNxB6/ZXISPS3MogNYLz21mR7giTmFxnzFearcN6A8ZuA==', N'MM6YHXEH2HW4N2JB54VZZVRJN5MMDLKW', N'4b1f49d3-8317-489b-b0d3-0cb7f2462f29', N'+56984189394', 1, 0, NULL, 1, 0, N'Evelyn', N'Orta', N'123456789', N'1993-03-03', 1)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Nombre], [Apellido], [Rut], [FechaNacimiento], [Terms]) VALUES (N'954144ed-b8c0-433c-b3ad-3fb83fcf166f', N'felipe.villa@duocuc.cl', N'FELIPE.VILLA@DUOCUC.CL', N'felipe.villa@duocuc.cl', N'FELIPE.VILLA@DUOCUC.CL', 1, N'AQAAAAEAACcQAAAAEK5UaYCV98SmYmsiNNVwxkzoyBavKWVjjVP4J31AKWWj8bgArcJA8+qoDNonK/2kAg==', N'TBTVAOH3EDYUKHN4WI7IC5ZH3NP2JDLS', N'48779cf0-5d1d-4227-b92c-4f5a75886c91', N'+56984189394', 1, 0, NULL, 1, 0, N'Felipe', N'Villa Rojas', N'167513042', N'1988-03-03', 1)
GO
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'01abdacd-7b57-4f1e-a1a4-03e52436e238', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'Pudahuel', CAST(N'2023-06-24T18:19:53.8727062' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'bde6e3b3-094c-4235-a821-05f35ce88c0d', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'Cerrillos', CAST(N'2023-06-24T18:19:26.8762248' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'ae21a0db-529f-4db1-bd9e-07cf9bc691f7', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'Independencia', CAST(N'2023-06-24T18:17:15.9391739' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'1702672a-a614-4f33-b490-0b6fd3ad656a', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'Maipú', CAST(N'2023-06-24T18:19:38.1810299' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'8288ecbd-1d27-4963-bf2d-0e0df201a7e2', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'La Florida', CAST(N'2023-06-24T18:18:30.0183944' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'94bc3b68-d4dc-4f9e-9cbc-1496a8f2d188', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'Las Condes', CAST(N'2023-06-24T18:17:39.2363136' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'c27b1c74-bdfb-4614-96b7-28743558cdd8', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'Vitacura', CAST(N'2023-06-24T18:17:57.1575957' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'6cb9f375-182c-4563-bed9-2987e8b12a0a', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'Cerro Navia', CAST(N'2023-06-24T18:19:43.4043820' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'8e1a0e94-7ad1-41ca-9130-319dc6f431ea', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'La Reina', CAST(N'2023-06-24T18:18:02.9389190' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'267fb664-ec22-4230-ae31-3b68425262de', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'Renca', CAST(N'2023-06-24T18:17:31.9797042' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'9467ec4c-6e8b-4d4a-a326-45bd743ee127', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'Peñalolén', CAST(N'2023-06-24T18:18:19.4553795' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'98efff4d-b1c7-4f03-9a52-47b8f30a0a05', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'San Joaquín', CAST(N'2023-06-24T18:19:16.9467312' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'f0f20ce2-b97a-40f1-a906-4f847dcebc72', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'Huechuraba', CAST(N'2023-06-24T18:17:09.9490952' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'1d464afa-2cdc-4351-99c5-58059db50aa6', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'Santiago', CAST(N'2023-06-24T18:16:57.6254222' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'2e84ed97-cf0b-4b5e-94a5-75a9e58799eb', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'El Bosque', CAST(N'2023-06-24T18:18:42.5781818' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'adb314ec-3e5e-4129-8af5-76c0ab73c8b2', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'La Pintana', CAST(N'2023-06-24T18:18:53.9377985' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'1d72b931-5e34-4f78-9cb1-7db45633de6c', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'Quilicura', CAST(N'2023-06-24T18:17:21.4529333' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'356cc9f8-a2c5-4a88-b0a0-8706bdd01730', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'Lo Barnechea', CAST(N'2023-06-24T18:17:46.1214448' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'ddd138d6-9154-49d0-b3de-9459ce623be0', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'Quinta Normal', CAST(N'2023-06-24T18:19:58.9078071' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'c89f3c54-d007-4ca7-bb14-979f04129c3e', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'Pedro Aguirre Cerda', CAST(N'2023-06-24T18:19:10.2501688' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'8d4ec749-c4bf-4429-80fc-aa787f42f77c', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'Macul', CAST(N'2023-06-24T18:18:08.1374221' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'fe2a5181-beae-46dd-9cfe-b22cef5dd4b5', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'Providencia', CAST(N'2023-06-24T18:17:51.4586044' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'944d80af-6ccf-438b-b733-b8e60f794e57', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'La Granja', CAST(N'2023-06-24T18:18:36.7055805' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'aef98f38-9f62-4ac4-b5e4-bc44499d9a83', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'San Miguel', CAST(N'2023-06-24T18:19:21.8416891' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'cdf0f3d4-aa10-433d-929a-c4bd3de30943', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'La Cisterna', CAST(N'2023-06-24T18:18:48.6812988' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'228a990d-9a21-4d59-8638-c6577f307504', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'Lo Prado', CAST(N'2023-06-24T18:19:49.3749002' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'b4816d10-e7ca-4993-b485-c8bed21c95db', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'Estación Central', CAST(N'2023-06-24T18:19:32.8646788' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'ae737e39-04c3-48b9-986e-ca4aa8297e60', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'Conchalí', CAST(N'2023-06-24T18:17:04.3551732' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'61ee7345-04c3-421e-826a-d5c442d39881', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'Ñuñoa', CAST(N'2023-06-24T18:18:13.8030522' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'6d83f070-fd7b-46b7-8041-df8a3ec383a7', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'Recoleta', CAST(N'2023-06-24T18:17:26.8379005' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'b7113197-9f9e-449d-bdc6-e2d2d8b3bffa', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'San Ramón', CAST(N'2023-06-24T18:18:59.1863633' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
INSERT [dbo].[Comuna] ([Id], [ProvinciaID], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'0e86c87a-f923-4d1a-a4db-f6db820d7664', N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'Lo Espejo', CAST(N'2023-06-24T18:19:04.9002868' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
INSERT [dbo].[Cursos] ([Id], [Nombre], [Direccion], [Descripcion], [Logo], [Portada], [FechaCurso], [FechaIngreso], [FechaActualizacion], [Estado], [ComunaID], [ValorPeso]) VALUES (N'f3f9947f-d289-4415-a802-66db193034ec', N'Curso 1', N'direccion #1234', N'Descripcion Curso 1', N'https://localhost:44334/images/Curso 1/Logo/f376447d-01e3-4f57-8cab-068656e3ca2b.webp', N'https://localhost:44334/images/Curso 1/Portada/f376447d-01e3-4f57-8cab-068656e3ca2b.webp', CAST(N'2023-06-24T18:30:00.0000000' AS DateTime2), CAST(N'2023-06-24T18:21:07.6683510' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'Disponible', N'98efff4d-b1c7-4f03-9a52-47b8f30a0a05', 20000)
INSERT [dbo].[Cursos] ([Id], [Nombre], [Direccion], [Descripcion], [Logo], [Portada], [FechaCurso], [FechaIngreso], [FechaActualizacion], [Estado], [ComunaID], [ValorPeso]) VALUES (N'dc19c32c-8db3-4a76-bf41-6db2916e7aeb', N'Curso 2', N'direccion #1234', N'Descripcion Curso 2', N'https://localhost:44334/images/Curso 2/Logo/f376447d-01e3-4f57-8cab-068656e3ca2b.webp', N'https://localhost:44334/images/Curso 2/Portada/f376447d-01e3-4f57-8cab-068656e3ca2b.webp', CAST(N'2023-06-24T18:30:00.0000000' AS DateTime2), CAST(N'2023-06-24T18:27:18.4998228' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'Disponible', N'1702672a-a614-4f33-b490-0b6fd3ad656a', 30000)
INSERT [dbo].[Cursos] ([Id], [Nombre], [Direccion], [Descripcion], [Logo], [Portada], [FechaCurso], [FechaIngreso], [FechaActualizacion], [Estado], [ComunaID], [ValorPeso]) VALUES (N'1a795ec1-61e4-461a-9a12-c3b47ac2f5d6', N'Curso 3', N'direccion #1234', N'Descripcion Curso 3', N'https://localhost:44334/images/Curso 3/Logo/f376447d-01e3-4f57-8cab-068656e3ca2b.webp', N'https://localhost:44334/images/Curso 3/Portada/f376447d-01e3-4f57-8cab-068656e3ca2b.webp', CAST(N'2023-06-24T18:30:00.0000000' AS DateTime2), CAST(N'2023-06-24T18:30:52.0242658' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2), N'Disponible', N'bde6e3b3-094c-4235-a821-05f35ce88c0d', 50000)
GO
INSERT [dbo].[Inscripcion] ([Id], [UserID], [UserMail], [UserNombre], [UserTelefono], [UserRut], [CursosID], [Fecha], [Estado]) VALUES (N'6d04203e-32f9-47f3-bd65-d2a39ece95cf', N'0cb3514d-4dc5-4838-aa63-a438262250ee', N'eve.orta@test.cl', N'Evelyn Orta', N'+56984189394', N'123456789', N'f3f9947f-d289-4415-a802-66db193034ec', CAST(N'2023-06-24T18:44:29.4159585' AS DateTime2), 1)
GO
INSERT [dbo].[Provincia] ([Id], [Nombre], [FechaIngreso], [FechaActualizacion]) VALUES (N'48e4d7bf-6e5e-4759-8d2a-1700f35caf0a', N'Provincia de Santiago', CAST(N'2023-06-24T18:15:57.3008487' AS DateTime2), CAST(N'0001-01-01T00:00:00.0000000' AS DateTime2))
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 28-06-2023 20:42:41 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 28-06-2023 20:42:41 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 28-06-2023 20:42:41 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 28-06-2023 20:42:41 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 28-06-2023 20:42:41 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 28-06-2023 20:42:41 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 28-06-2023 20:42:41 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
/****** Object:  StoredProcedure [dbo].[CancelarArriendo]    Script Date: 28-06-2023 20:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CancelarArriendo]
(
       @ArriendoID uniqueidentifier
)
AS 
BEGIN 
     SET NOCOUNT ON 

     UPDATE Arrendado SET 
      Estado = 'false'    
	  where ArriendoID = @ArriendoID
END 

GO
/****** Object:  StoredProcedure [dbo].[InsertarArriendoInicio]    Script Date: 28-06-2023 20:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarArriendoInicio]
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM Inicio where Tipo = 'Arriendo'
	DECLARE @Tipo AS VARCHAR(50)= 'Arriendo'
	INSERT INTO Inicio(Id,CategoriaID,Nombre,Apellido,RUT,Direccion,Descripcion,Logo,Portada,FechaArriendo,FechaIngreso,FechaActualizacion,ValorPeso,ValorUF,Habitacion,Bannio,Estado,Tamannio,ComunaID,Telefono,Tipo) 
	SELECT TOP 6 Id,CategoriaID,Nombre,Apellido,RUT,Direccion,Descripcion,Logo,Portada,FechaArriendo,FechaIngreso,FechaActualizacion,ValorPeso,ValorUF,Habitacion,Bannio,Estado,Tamannio,ComunaID,Telefono,@Tipo
	FROM Arriendo where Estado = 'Disponible'
	ORDER BY FechaArriendo DESC
END
GO
/****** Object:  StoredProcedure [dbo].[InsertarVentaInicio]    Script Date: 28-06-2023 20:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarVentaInicio]
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM Inicio where Tipo = 'Venta'
	DECLARE @Tipo AS VARCHAR(50)='Venta'
	INSERT INTO Inicio(Id,CategoriaID,Nombre,Apellido,RUT,Direccion,Descripcion,Logo,Portada,FechaArriendo,FechaIngreso,FechaActualizacion,ValorPeso,ValorUF,Habitacion,Bannio,Estado,Tamannio,ComunaID,Telefono,Tipo)
	SELECT TOP 6 Id,CategoriaID,Nombre,Apellido,RUT,Direccion,Descripcion,Logo,Portada,FechaVenta,FechaIngreso,FechaActualizacion,ValorPeso,ValorUF,Habitacion,Bannio,Estado,Tamannio,ComunaID,Telefono,@Tipo
	FROM Venta
	ORDER BY FechaVenta DESC
END
GO
/****** Object:  StoredProcedure [dbo].[LimpiaSolicitudesArriendo]    Script Date: 28-06-2023 20:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LimpiaSolicitudesArriendo]
AS
BEGIN
	SET NOCOUNT ON;

		IF EXISTS ((select ArriendoID from SolicitudArriendo where Estado = 'true' AND ArriendoID in (select ArriendoID from Arrendado where Estado = 'true')))
		BEGIN
          UPDATE SolicitudArriendo SET Estado = 'false' where Estado = 'true' AND ArriendoID in (select ArriendoID from Arrendado where Estado = 'true' );

		  UPDATE Arriendo SET Estado = 'Arrendado' where Estado = 'Disponible' AND Id in (select ArriendoID from Arrendado where Estado = 'true' );
		END
END
GO
/****** Object:  StoredProcedure [dbo].[LimpiaSolicitudesVenta]    Script Date: 28-06-2023 20:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LimpiaSolicitudesVenta]
AS
BEGIN
	SET NOCOUNT ON;

		IF EXISTS ((select VentaID from SolicitudVenta where Estado = 'true' AND VentaID in (select VentaID from Vendido where Estado = 'true')))
		BEGIN
          UPDATE SolicitudVenta SET Estado = 'false' where Estado = 'true' AND VentaID in (select VentaID from Vendido where Estado = 'true' );

		  UPDATE Venta SET Estado = 'Vendido' where Estado = 'Disponible' AND Id in (select VentaID from Vendido where Estado = 'true' );
		END
END
GO
USE [master]
GO
ALTER DATABASE [GestionAgilDeProyectos] SET  READ_WRITE 
GO
