USE [master]
GO
/****** Object:  Database [SchoolDB]    Script Date: 10.4.2022 11:09:08 ******/
CREATE DATABASE [SchoolDB] 
GO
ALTER DATABASE [SchoolDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SchoolDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SchoolDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SchoolDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SchoolDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [SchoolDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SchoolDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SchoolDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SchoolDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SchoolDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SchoolDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SchoolDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SchoolDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SchoolDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SchoolDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SchoolDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SchoolDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SchoolDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SchoolDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SchoolDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SchoolDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SchoolDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SchoolDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [SchoolDB] SET  MULTI_USER 
GO
ALTER DATABASE [SchoolDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SchoolDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SchoolDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SchoolDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [SchoolDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SchoolDB] SET QUERY_STORE = OFF
GO
USE [SchoolDB]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [SchoolDB]
GO
/****** Object:  Table [dbo].[Class]    Script Date: 10.4.2022 11:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Class](
	[IdClass] [int] IDENTITY(1,1) NOT NULL,
	[DateAndTime] [datetime] NOT NULL,
	[IdTeacher] [int] NOT NULL,
	[IdClassGroup] [int] NOT NULL,
 CONSTRAINT [PK_Class] PRIMARY KEY CLUSTERED 
(
	[IdClass] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClassGroup]    Script Date: 10.4.2022 11:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClassGroup](
	[IdClassGroup] [int] NOT NULL,
	[ClassGroupName] [varchar](50) NOT NULL,
	[Stream] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdClassGroup] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mark]    Script Date: 10.4.2022 11:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mark](
	[IdStudent] [int] NOT NULL,
	[IdClass] [int] NOT NULL,
	[Value] [int] NOT NULL,
	[ExaminationType] [int] NOT NULL,
	[DateOfExamination] [datetime] NOT NULL,
	[FinalValue] [int] NULL,
 CONSTRAINT [PK_Mark] PRIMARY KEY CLUSTERED 
(
	[IdStudent] ASC,
	[IdClass] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 10.4.2022 11:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[IdStudent] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[BirthDate] [datetime] NOT NULL,
	[Address] [varchar](max) NOT NULL,
	[PhoneNumber] [varchar](50) NOT NULL,
	[IdClassGroup] [int] NOT NULL,
	[JMBG] [varchar](50) NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[IdStudent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 10.4.2022 11:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[IdSubject] [int] IDENTITY(1,1) NOT NULL,
	[SubjectName] [varchar](50) NOT NULL,
	[Description] [varchar](max) NOT NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[IdSubject] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 10.4.2022 11:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[IdTeacher] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[BirthDate] [date] NOT NULL,
	[Address] [varchar](max) NOT NULL,
	[PhoneNumber] [varchar](50) NOT NULL,
	[AcademicLevel] [int] NOT NULL,
	[IdSubject] [int] NOT NULL,
	[IdClassHomeroomTeacher] [int] NULL,
 CONSTRAINT [PK_Teacher] PRIMARY KEY CLUSTERED 
(
	[IdTeacher] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10.4.2022 11:09:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[IdUser] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[IdUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Class] ON 

INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (5007, CAST(N'2022-03-10T18:52:27.000' AS DateTime), 21486, 21)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (5008, CAST(N'2022-03-10T18:55:29.000' AS DateTime), 3462, 32)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (5009, CAST(N'2022-03-10T19:32:19.000' AS DateTime), 3462, 21)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (5010, CAST(N'2022-03-10T19:34:37.000' AS DateTime), 3482, 21)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (5011, CAST(N'2022-03-10T19:34:58.000' AS DateTime), 3471, 21)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (5013, CAST(N'2022-03-10T21:54:56.000' AS DateTime), 19484, 21)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (5023, CAST(N'2022-03-10T23:53:00.000' AS DateTime), 3462, 21)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (5024, CAST(N'2022-03-10T23:54:00.000' AS DateTime), 19484, 21)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (6003, CAST(N'2022-03-11T11:51:35.000' AS DateTime), 21490, 45)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (6004, CAST(N'2022-03-11T11:54:55.000' AS DateTime), 3462, 11)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (7003, CAST(N'2022-03-11T13:15:47.000' AS DateTime), 3462, 21)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (8003, CAST(N'2022-03-11T14:32:38.000' AS DateTime), 3462, 41)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (8004, CAST(N'2022-03-11T14:34:00.000' AS DateTime), 3482, 21)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (8005, CAST(N'2022-03-11T14:35:00.000' AS DateTime), 3471, 21)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (8006, CAST(N'2022-03-11T14:50:10.000' AS DateTime), 3457, 21)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (9003, CAST(N'2022-03-24T18:35:46.000' AS DateTime), 3462, 12)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (9004, CAST(N'2022-03-24T18:43:14.000' AS DateTime), 3462, 11)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (9005, CAST(N'2022-03-24T18:49:16.000' AS DateTime), 3473, 13)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (9008, CAST(N'2022-03-24T19:00:03.000' AS DateTime), 3464, 13)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (9009, CAST(N'2022-03-24T19:03:59.000' AS DateTime), 3462, 22)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (9010, CAST(N'2022-03-24T19:05:45.000' AS DateTime), 3462, 15)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (9012, CAST(N'2022-03-24T19:21:52.000' AS DateTime), 3462, 35)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (9014, CAST(N'2022-03-24T19:31:04.000' AS DateTime), 3462, 36)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (9015, CAST(N'2022-03-24T19:32:39.000' AS DateTime), 3479, 32)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (9016, CAST(N'2022-03-24T19:36:17.000' AS DateTime), 3470, 33)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (10003, CAST(N'2022-03-25T18:36:31.000' AS DateTime), 3462, 12)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (10010, CAST(N'2022-03-25T19:17:17.000' AS DateTime), 3462, 34)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (10011, CAST(N'2022-03-25T19:21:38.000' AS DateTime), 3462, 35)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (10012, CAST(N'2022-03-25T19:25:22.000' AS DateTime), 3462, 36)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (10013, CAST(N'2022-03-25T19:29:58.000' AS DateTime), 3482, 12)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (10014, CAST(N'2022-03-25T19:31:33.000' AS DateTime), 19484, 35)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (10015, CAST(N'2022-03-25T19:33:09.000' AS DateTime), 3470, 32)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (10016, CAST(N'2022-03-25T19:35:32.000' AS DateTime), 3462, 41)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (10017, CAST(N'2022-03-25T19:35:59.000' AS DateTime), 3459, 41)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (10018, CAST(N'2022-03-25T19:37:17.000' AS DateTime), 3479, 42)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (10019, CAST(N'2022-03-25T19:38:50.000' AS DateTime), 3479, 12)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (10020, CAST(N'2022-03-25T19:41:32.000' AS DateTime), 3470, 33)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (10021, CAST(N'2022-03-25T19:47:34.000' AS DateTime), 3462, 13)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (10022, CAST(N'2022-03-25T19:48:39.000' AS DateTime), 3462, 44)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (10023, CAST(N'2022-03-25T19:49:20.000' AS DateTime), 21489, 42)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (10024, CAST(N'2022-03-25T19:49:55.000' AS DateTime), 3463, 12)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (10025, CAST(N'2022-03-25T19:52:12.000' AS DateTime), 3462, 110)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (11003, CAST(N'2022-03-26T11:17:49.000' AS DateTime), 3462, 12)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (12003, CAST(N'2022-03-26T11:45:10.000' AS DateTime), 3462, 27)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (13003, CAST(N'2022-03-26T12:45:00.000' AS DateTime), 3462, 27)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (13004, CAST(N'2022-03-26T13:13:00.000' AS DateTime), 3462, 27)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (13005, CAST(N'2022-03-26T15:03:39.000' AS DateTime), 3462, 13)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (13006, CAST(N'2022-03-26T15:18:00.000' AS DateTime), 3462, 27)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (13007, CAST(N'2022-03-26T15:27:00.000' AS DateTime), 3462, 27)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (13008, CAST(N'2022-03-26T17:05:11.000' AS DateTime), 3462, 28)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (13009, CAST(N'2022-03-26T17:19:29.000' AS DateTime), 3462, 11)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (13010, CAST(N'2022-03-26T17:20:51.000' AS DateTime), 3482, 11)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (13011, CAST(N'2022-03-26T17:21:54.000' AS DateTime), 21486, 11)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (13012, CAST(N'2022-03-26T17:22:56.000' AS DateTime), 3471, 11)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (13020, CAST(N'2022-03-26T18:02:00.000' AS DateTime), 3462, 11)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (14008, CAST(N'2022-03-26T22:28:00.000' AS DateTime), 3462, 11)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (15008, CAST(N'2022-04-02T18:14:00.000' AS DateTime), 3462, 12)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (16008, CAST(N'2022-04-04T19:03:41.000' AS DateTime), 3462, 11)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (16010, CAST(N'2022-04-04T19:07:18.000' AS DateTime), 3462, 12)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (16012, CAST(N'2022-04-04T19:10:31.000' AS DateTime), 3462, 34)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (16013, CAST(N'2022-04-04T19:11:08.000' AS DateTime), 3482, 34)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (18011, CAST(N'2022-04-09T13:37:15.000' AS DateTime), 3482, 11)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (19008, CAST(N'2022-04-10T11:01:55.000' AS DateTime), 3462, 23)
INSERT [dbo].[Class] ([IdClass], [DateAndTime], [IdTeacher], [IdClassGroup]) VALUES (19010, CAST(N'2022-04-10T11:06:02.000' AS DateTime), 3482, 11)
SET IDENTITY_INSERT [dbo].[Class] OFF
GO
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (11, N'I-1', 2)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (12, N'I-2', 2)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (13, N'I-3', 2)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (14, N'I-4', 2)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (15, N'I-5', 1)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (16, N'I-6', 1)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (18, N'I-8', 1)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (19, N'I-9', 1)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (21, N'II-1', 2)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (22, N'II-2', 2)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (23, N'II-3', 2)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (24, N'II-4', 1)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (25, N'II-5', 1)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (26, N'II-6', 1)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (27, N'II-7', 1)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (28, N'II-8', 1)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (31, N'III-1', 2)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (32, N'III-2', 2)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (33, N'III-3', 2)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (34, N'III-4', 1)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (35, N'III-5', 1)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (36, N'III-6', 1)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (41, N'IV-1', 2)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (42, N'IV-2', 2)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (43, N'IV-3', 2)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (44, N'IV-4', 2)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (45, N'IV-5', 1)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (46, N'IV-6', 2)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (47, N'IV-7', 1)
INSERT [dbo].[ClassGroup] ([IdClassGroup], [ClassGroupName], [Stream]) VALUES (110, N'I-10', 2)
GO
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1101, 6004, 3, 0, CAST(N'2022-11-03T11:54:00.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1101, 13009, 4, 2, CAST(N'2022-03-26T17:18:56.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1101, 13012, 3, 1, CAST(N'2022-03-26T17:22:37.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1101, 16010, 4, 1, CAST(N'2022-04-04T19:07:04.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1101, 18011, 5, 0, CAST(N'2022-04-09T13:37:06.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1101, 19010, 4, 0, CAST(N'2022-04-10T11:05:52.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1102, 16012, 5, 1, CAST(N'2022-04-04T19:10:24.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1102, 16013, 4, 1, CAST(N'2022-04-04T19:10:57.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1103, 19008, 4, 0, CAST(N'2022-04-10T11:01:22.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1106, 10020, 5, 0, CAST(N'2022-03-25T19:41:20.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1108, 16010, 5, 2, CAST(N'2022-04-04T19:07:12.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1109, 6003, 5, 2, CAST(N'2022-11-03T11:51:00.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1111, 13005, 5, 0, CAST(N'2022-03-26T15:03:38.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1115, 10011, 5, 0, CAST(N'2022-03-25T19:21:37.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1118, 10020, 5, 0, CAST(N'2022-03-25T19:40:56.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1119, 10012, 4, 0, CAST(N'2022-03-25T19:24:59.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1120, 8003, 4, 0, CAST(N'2022-11-03T02:32:00.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1120, 10017, 1, 0, CAST(N'2022-03-25T19:35:52.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1122, 8006, 2, 0, CAST(N'2022-11-03T02:50:00.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1123, 6004, 5, 0, CAST(N'2022-11-03T11:54:00.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1123, 13009, 4, 1, CAST(N'2022-03-26T17:19:25.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1123, 13010, 5, 0, CAST(N'2022-03-26T17:20:50.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1123, 13011, 5, 1, CAST(N'2022-03-26T17:21:52.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1123, 16008, 2, 1, CAST(N'2022-04-04T19:03:15.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1128, 9012, 1, 0, CAST(N'2022-03-24T19:21:44.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1128, 10011, 5, 0, CAST(N'2022-03-25T19:21:30.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1130, 19008, 5, 0, CAST(N'2022-04-10T11:01:53.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1132, 13010, 5, 0, CAST(N'2022-03-26T17:20:30.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1132, 18011, 4, 0, CAST(N'2022-04-09T13:37:09.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1132, 19010, 5, 0, CAST(N'2022-04-10T11:05:55.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1133, 9012, 4, 0, CAST(N'2022-03-22T07:12:00.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1133, 10010, 5, 0, CAST(N'2022-03-25T19:17:13.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1133, 16012, 5, 0, CAST(N'2022-04-04T19:10:27.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1133, 16013, 3, 0, CAST(N'2022-04-04T19:11:01.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1134, 19008, 5, 2, CAST(N'2022-04-10T11:01:34.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1135, 10010, 5, 0, CAST(N'2022-03-25T19:17:16.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1135, 16012, 3, 0, CAST(N'2022-04-04T19:10:30.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1136, 16013, 5, 0, CAST(N'2022-04-04T19:11:06.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1141, 9012, 1, 0, CAST(N'2022-03-24T19:21:48.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1141, 10011, 5, 0, CAST(N'2022-03-25T19:21:34.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1142, 10012, 2, 0, CAST(N'2022-03-25T19:25:16.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1143, 10024, 3, 0, CAST(N'2022-03-25T19:49:50.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1143, 11003, 5, 0, CAST(N'2022-03-26T11:17:49.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1149, 8006, 4, 2, CAST(N'2022-11-03T02:49:00.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1150, 16008, 4, 0, CAST(N'2022-04-04T19:03:02.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1153, 10015, 1, 0, CAST(N'2022-03-25T19:33:08.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1154, 6004, 5, 0, CAST(N'2022-11-03T11:54:00.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1154, 13009, 5, 2, CAST(N'2022-03-26T17:19:19.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1154, 13010, 4, 1, CAST(N'2022-03-26T17:20:44.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1154, 13011, 5, 0, CAST(N'2022-03-26T17:21:45.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1154, 13012, 2, 1, CAST(N'2022-03-26T17:22:54.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1156, 10024, 3, 0, CAST(N'2022-03-25T19:49:53.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1156, 16010, 3, 0, CAST(N'2022-04-04T19:07:16.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1157, 13009, 3, 0, CAST(N'2022-03-26T17:19:28.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1157, 16008, 5, 0, CAST(N'2022-04-04T19:03:06.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1159, 8006, 4, 0, CAST(N'2022-11-03T02:50:00.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1164, 10018, 2, 0, CAST(N'2022-03-25T19:37:12.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1165, 8003, 4, 2, CAST(N'2022-11-03T02:32:00.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1165, 10017, 2, 0, CAST(N'2022-03-25T19:35:55.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1166, 6003, 5, 2, CAST(N'2022-11-03T11:51:00.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1169, 5009, 4, 0, CAST(N'2022-10-03T07:32:00.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1169, 5010, 3, 0, CAST(N'2022-10-03T07:34:00.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1169, 5011, 2, 0, CAST(N'2022-10-03T07:34:00.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1169, 5013, 5, 2, CAST(N'2022-10-03T09:54:00.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1169, 5024, 5, 0, CAST(N'2022-03-10T23:54:00.000' AS DateTime), 1)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1169, 7003, 3, 1, CAST(N'2022-11-03T01:15:00.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1169, 8004, 3, 0, CAST(N'2022-03-11T14:34:00.000' AS DateTime), 1)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1169, 8005, 2, 0, CAST(N'2022-03-11T14:35:00.000' AS DateTime), 1)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1169, 8006, 5, 2, CAST(N'2022-11-03T02:49:00.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1169, 12003, 4, 0, CAST(N'2022-03-26T11:45:08.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (1169, 13007, 5, 0, CAST(N'2022-03-26T15:27:00.000' AS DateTime), 1)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (8167, 6004, 4, 0, CAST(N'2022-11-03T11:54:00.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (8167, 13010, 5, 2, CAST(N'2022-03-26T17:20:34.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (8167, 13011, 3, 1, CAST(N'2022-03-26T17:21:42.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (8167, 13012, 3, 0, CAST(N'2022-03-26T17:22:45.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (8167, 16008, 5, 0, CAST(N'2022-04-04T19:03:27.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (8167, 18011, 3, 0, CAST(N'2022-04-09T13:37:12.000' AS DateTime), NULL)
INSERT [dbo].[Mark] ([IdStudent], [IdClass], [Value], [ExaminationType], [DateOfExamination], [FinalValue]) VALUES (8167, 19010, 3, 0, CAST(N'2022-04-10T11:06:01.000' AS DateTime), NULL)
GO
SET IDENTITY_INSERT [dbo].[Student] ON 

INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1101, N'Ana', N'Abramovic', CAST(N'2006-05-05T00:00:00.000' AS DateTime), N'Djusina 75', N'0113122322', 11, N'0505006715223')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1102, N'Petar', N'Aksentijevic', CAST(N'2004-08-04T00:00:00.000' AS DateTime), N'Bratstva i jedinstva 11', N'0113243556', 34, N'0408004710099')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1103, N'Vuk', N'Albijanic', CAST(N'2005-07-02T00:00:00.000' AS DateTime), N'Sajkaska 23', N'0116578933', 23, N'0702005710067')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1104, N'Irina', N'Aleksic', CAST(N'2006-11-23T00:00:00.000' AS DateTime), N'Zorza Klemansoa 45', N'0119943225', 14, N'2311006715023')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1105, N'Aleksandar', N'Alicic', CAST(N'2004-12-30T00:00:00.000' AS DateTime), N'Dimitrija Tucovica 47', N'0119985431', 33, N'3012004710039')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1106, N'Ivana', N'Andric', CAST(N'2004-09-09T00:00:00.000' AS DateTime), N'Sarajevska 99', N'0111738299', 33, N'0909004715662')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1107, N'Jana', N'Antic', CAST(N'2003-08-27T00:00:00.000' AS DateTime), N'Maksima Gorkog 13', N'0119766633', 46, N'2708003715023')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1108, N'Milica', N'Babic', CAST(N'2006-04-29T00:00:00.000' AS DateTime), N'Starine Novaka 96', N'0114302892', 12, N'2904006715099')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1109, N'Lazar', N'Bajic', CAST(N'2003-02-28T00:00:00.000' AS DateTime), N'Molerova 5', N'0119388924', 45, N'2802003710087')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1110, N'Lena', N'Bakic', CAST(N'2006-12-23T00:00:00.000' AS DateTime), N'Masarikova 45', N'0118393392', 13, N'2312006715881')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1111, N'Ana', N'Banic', CAST(N'2006-08-30T00:00:00.000' AS DateTime), N'Njegoseva 79', N'0113329293', 13, N'3008006715255')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1112, N'Strahinja', N'Banovic', CAST(N'2006-03-27T00:00:00.000' AS DateTime), N'Carigradska 24', N'0119833992', 13, N'2703006710098')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1114, N'Bojana', N'Baric', CAST(N'2003-06-06T00:00:00.000' AS DateTime), N'Mihajla Pupina 43', N'0119329922', 44, N'0606003715066')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1115, N'Ivona', N'Belic', CAST(N'2004-03-03T00:00:00.000' AS DateTime), N'Juzni Bulevar 78', N'0119733929', 35, N'0303004715233')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1116, N'Lena', N'Boskovic', CAST(N'2004-07-23T00:00:00.000' AS DateTime), N'Sindjeliceva 10', N'0110303032', 32, N'2307004715009')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1117, N'Iva', N'Brajic', CAST(N'2004-06-22T00:00:00.000' AS DateTime), N'Narodnog fronta', N'0119393939', 31, N'2206004715203')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1118, N'Nada', N'Brkic', CAST(N'2004-02-28T00:00:00.000' AS DateTime), N'Baba Visnjina 32', N'0110229292', 33, N'2802004715241')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1119, N'Elena', N'Bukumirovic', CAST(N'2004-05-30T00:00:00.000' AS DateTime), N'Ilije Graasanina 24', N'0119372292', 36, N'3005004715423')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1120, N'Nastasja', N'Vasic', CAST(N'2003-02-22T00:00:00.000' AS DateTime), N'Cika Ljubina 23', N'0119937132', 41, N'2202003715006')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1121, N'Marko', N'Vesic', CAST(N'2004-11-22T00:00:00.000' AS DateTime), N'Ruzveltova 11', N'0113224256', 31, N'2211004710432')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1122, N'Ana', N'Vlajic', CAST(N'2005-07-04T00:00:00.000' AS DateTime), N'Crnotravska 13', N'0119322234', 21, N'0407005715466')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1123, N'Nevena', N'Vukovic', CAST(N'2006-06-06T00:00:00.000' AS DateTime), N'Solunska 113', N'0114252251', 11, N'0606006715222')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1124, N'Filip', N'Vukosavljevic', CAST(N'2006-09-02T00:00:00.000' AS DateTime), N'Cvijiceva 87', N'0111484919', 15, N'0209006710072')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1125, N'Milan', N'Gagic', CAST(N'2006-03-20T00:00:00.000' AS DateTime), N'Zaplanjska 6', N'0112239020', 14, N'2003006710123')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1126, N'Jovan', N'Glisic', CAST(N'2004-05-22T00:00:00.000' AS DateTime), N'Hilandarska 91', N'0118323342', 33, N'2205004710087')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1127, N'Goran', N'Grujic', CAST(N'2004-09-30T00:00:00.000' AS DateTime), N'Nusiceva 21', N'0113292921', 32, N'3009004710217')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1128, N'Milica', N'Dabovic', CAST(N'2004-05-02T00:00:00.000' AS DateTime), N'Kraljice Marije 34', N'0111491098', 35, N'0205004715092')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1129, N'Dimitrije', N'Davidovic', CAST(N'2005-04-02T00:00:00.000' AS DateTime), N'Kralja Petra 2', N'0119282234', 22, N'0204005710023')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1130, N'Dejana', N'Dedic', CAST(N'2005-01-03T00:00:00.000' AS DateTime), N'Dositejeva 48', N'0119292256', 23, N'0301005715028')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1131, N'Luka', N'Doncic', CAST(N'2005-02-25T00:00:00.000' AS DateTime), N'Francuska 77', N'0119293037', 26, N'2502005710077')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1132, N'Goran', N'Dragic', CAST(N'2006-05-08T00:00:00.000' AS DateTime), N'Bulevar oslobodjenja 34', N'0117418949', 11, N'0805006710701')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1133, N'Petar', N'Ivanovic', CAST(N'2004-06-23T00:00:00.000' AS DateTime), N'Santiceva 29', N'0113425464', 34, N'2306004710092')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1134, N'Ivana', N'Ivanovic', CAST(N'2005-01-07T00:00:00.000' AS DateTime), N'Bulevar kralja Aleksandra 18', N'0119824342', 23, N'0701005715233')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1135, N'Teodora', N'Jovanovic', CAST(N'2004-07-03T00:00:00.000' AS DateTime), N'Dzordza Vasingtona 91', N'0112993821', 34, N'0307004715277')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1136, N'Jovana', N'Jovanovic', CAST(N'2004-09-30T00:00:00.000' AS DateTime), N'Vojvode Stepe 67', N'0118439393', 34, N'3009004715621')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1137, N'Isidora', N'Jovanovic', CAST(N'2005-11-11T00:00:00.000' AS DateTime), N'Kumodraska 11', N'0119823921', 23, N'1111005715432')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1138, N'Milutin', N'Kostic', CAST(N'2005-10-19T00:00:00.000' AS DateTime), N'Admirala Geprata 23', N'0113134412', 22, N'1910005710002')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1139, N'Jelena', N'Krasic', CAST(N'2004-09-01T00:00:00.000' AS DateTime), N'Balkanska 13', N'0113920203', 44, N'0109004715261')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1140, N'Nemanja', N'Krstic', CAST(N'2005-12-18T00:00:00.000' AS DateTime), N'Palmoticeva 28', N'0113992021', 23, N'1812005710002')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1141, N'Ljiljana', N'Lazic', CAST(N'2004-10-23T00:00:00.000' AS DateTime), N'Jahorinska 89', N'0112929327', 35, N'2310004715412')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1142, N'Tatjana', N'Lazovic', CAST(N'2004-04-29T00:00:00.000' AS DateTime), N'Kaleniceva 37', N'0119392920', 36, N'2904005715163')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1143, N'Andrea', N'Lekic', CAST(N'2006-11-24T00:00:00.000' AS DateTime), N'Beranska 17', N'0118211931', 12, N'2411006715184')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1144, N'Marija', N'Maksimovic', CAST(N'2006-10-30T00:00:00.000' AS DateTime), N'Palmoticeva 62', N'0113729296', 14, N'3010006715621')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1145, N'Petra', N'Maric', CAST(N'2006-05-20T00:00:00.000' AS DateTime), N'Nade Dimic 29', N'0113672242', 15, N'2005006715241')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1146, N'Sara', N'Nenadic', CAST(N'2006-04-02T00:00:00.000' AS DateTime), N'Tetovska 12', N'0113828920', 16, N'0204006715912')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1147, N'Stefan', N'Nikolic', CAST(N'2005-06-29T00:00:00.000' AS DateTime), N'Velizara Kosanovica 57', N'0119392022', 25, N'2906005710256')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1148, N'Ana', N'Nikolic', CAST(N'2005-08-02T00:00:00.000' AS DateTime), N'Lole Ribara 8', N'0118199211', 26, N'0208005715023')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1149, N'Marija', N'Nikolic', CAST(N'2005-04-30T00:00:00.000' AS DateTime), N'Karadjordjeva 14', N'0117282929', 21, N'3004005715412')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1150, N'Milos', N'Obrenovic', CAST(N'2006-11-06T00:00:00.000' AS DateTime), N'Jovana Rajica 33', N'0119329292', 11, N'0611006710822')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1151, N'Vuk', N'Ostojic', CAST(N'2005-07-28T00:00:00.000' AS DateTime), N'Nevesinjska 76', N'0117839308', 25, N'2807005710027')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1152, N'Svetlana', N'Pavlovic', CAST(N'2004-12-30T00:00:00.000' AS DateTime), N'Cerska 92', N'0119392039', 33, N'3012004715261')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1153, N'Dragutin', N'Pavlovic', CAST(N'2004-08-26T00:00:00.000' AS DateTime), N'Goce Delceva 64', N'0118392020', 32, N'2608004710073')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1154, N'Lena', N'Popovic', CAST(N'2006-07-19T00:00:00.000' AS DateTime), N'Andricev venac 3', N'0113291110', 11, N'1907006715271')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1155, N'Petar', N'Popovic', CAST(N'2006-09-23T00:00:00.000' AS DateTime), N'Bore Stankovica 58', N'0113920023', 14, N'2309006710023')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1156, N'Anja', N'Protic', CAST(N'2006-04-08T00:00:00.000' AS DateTime), N'Tadeusa Koscuska 92', N'0113829232', 12, N'0804006715712')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1157, N'Tara', N'Radic', CAST(N'2006-07-31T00:00:00.000' AS DateTime), N'Homoljska 49', N'0118482034', 11, N'3107006715262')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1158, N'Masa', N'Radovic', CAST(N'2004-04-27T00:00:00.000' AS DateTime), N'Igmanska 57', N'0111392901', 33, N'2704004715243')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1159, N'Bora', N'Stankovic', CAST(N'2005-12-04T00:00:00.000' AS DateTime), N'Humska 93', N'0119222923', 21, N'0412005710001')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1160, N'Irena', N'Stankovic', CAST(N'2005-06-29T00:00:00.000' AS DateTime), N'Ibarska 8', N'0111882932', 26, N'2906005715662')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1161, N'Matea', N'Stevic', CAST(N'2005-11-30T00:00:00.000' AS DateTime), N'Pasterova 6', N'0116679217', 25, N'3011005715431')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1162, N'Natasa', N'Stevanovic', CAST(N'2005-06-23T00:00:00.000' AS DateTime), N'Ruvarceva 44', N'0119923829', 22, N'2306005715171')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1163, N'Violeta', N'Tasic', CAST(N'2005-10-21T00:00:00.000' AS DateTime), N'Senjanina Ive 92', N'0112849003', 23, N'2110005715210')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1164, N'Bojan', N'Todorovic', CAST(N'2003-11-05T00:00:00.000' AS DateTime), N'Spanskih boraca 2', N'0119287482', 42, N'0511003710009')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1165, N'Gordana', N'Todorovic', CAST(N'2003-01-30T00:00:00.000' AS DateTime), N'Joakima Vujica 31', N'0119203921', 41, N'3001003715412')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1166, N'Una', N'Todorovic', CAST(N'2003-11-11T00:00:00.000' AS DateTime), N'Kneza Milosa 74', N'0113929108', 45, N'1111003715223')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1168, N'Tina', N'Trajkovic', CAST(N'2003-04-12T00:00:00.000' AS DateTime), N'Visegradska 1', N'0113432323', 44, N'1204003715299')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (1169, N'Ana', N'Janic', CAST(N'2005-11-25T13:21:41.000' AS DateTime), N'Nehruova 35', N'0113333333', 27, N'2511005715273')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (8167, N'Leonora', N'Lelic', CAST(N'2006-04-03T00:00:00.000' AS DateTime), N'Venizelosova 3', N'0117827888', 11, N'0304006715362')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (17172, N'Vesna', N'Ivanovic', CAST(N'2006-02-11T00:00:00.000' AS DateTime), N'Dzordza Vasingtona 2', N'0115436324', 18, N'1102006715029')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (17173, N'Dimitrije', N'Davidovic', CAST(N'2006-01-15T00:00:00.000' AS DateTime), N'Mihajla Pupina 38', N'0115436999', 110, N'1501006710098')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (17174, N'Jovana', N'Jankovic', CAST(N'2006-04-16T00:00:00.000' AS DateTime), N'Djusina 88', N'0113223256', 19, N'1604006715172')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (17175, N'Jelena', N'Jovanovic', CAST(N'2006-03-05T00:00:00.000' AS DateTime), N'Djusina 88', N'0113223256', 110, N'0503006715266')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (17176, N'Jana', N'Dimitrijevic', CAST(N'2005-01-12T00:00:00.000' AS DateTime), N'Dalmatinska 18', N'0119982234', 24, N'1201005715281')
INSERT [dbo].[Student] ([IdStudent], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [IdClassGroup], [JMBG]) VALUES (17177, N'Aleksandar', N'Karadjordjevic', CAST(N'2005-01-01T00:00:00.000' AS DateTime), N'Solunska 24', N'0112232454', 28, N'0101005710023')
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
SET IDENTITY_INSERT [dbo].[Subject] ON 

INSERT [dbo].[Subject] ([IdSubject], [SubjectName], [Description]) VALUES (666, N'Maths', N'Septembar
1. Izrada godisnjih i mesecnih operativnih planova.
2. Usvajanje udzbenika i zbirki zadataka.
3. Usaglasavanje kriterijuma ocenjivanja
Oktobar
1. Planiranje dodatne i dopunske nastave.
2. Planiranje pripreme ucenika za takmicenje.
3. Planiranje testiranja ucenika.
Novembar
1. Analiza realizacije plana i programa na kraju prvog klasifikacionog perioda.
2. Analiza uspeha ucenika na kraju prvog klasifikacionog perioda.
3. Priprema ucenika za takmicenja.
Decembar
1. Priprema i podela maturskih tema.
2. Pripreme ucenika za takmicenje.
Januar
1. Usaglašavanje kriterijuma ocenjivanja
2. Priprema za školsko takmicenje.
Februar
1. Analiza uspeha ucenika na kraju prvog poligodišta.
2. Izveštaj sa zimskih seminara.
3. Priprema ucenika za Opštinsko i Gradsko takmicenje.
Mart
1. Mere za poboljšanje uspeha ucenika.
2. Organizacija ucešca na Republickom takmicenju
3. Organizacija takmicenja Kengur.
April
1. Analiza realizacije plana i programa i uspeha ucenika na kraju treceg klasifikacionog perioda.
2. Analiza uspeha ucenika na takmicenjima kao i na takmicenju Kengur.
Maj
1. Obeležavanje meseca maja kao meseca matematike.
2. Matematicki turnir.
Jun i Juli
1. Priprema i realizacija maturskih ispita
2. Podela casova za narednu školsku godinu
3. Usvajanje izveštaja o radu u protekloj godini
4. Izveštaj sa održanih prijemnih ispita na fakultetima.
Avgust
1. Realizacija popravnih ispita
2. Podela zaduženja u okviru 40-to casovne nedelje
3. Usvajanje udžbenika i zbirki sa list')
INSERT [dbo].[Subject] ([IdSubject], [SubjectName], [Description]) VALUES (667, N'Serbian', N'Septembar: Dogovor o nacinu rada. Priprema inicijalnih testova i testiranje
ucenika. Analiza inicijalnih testova.Prvi pismeni zadatak u 2. i 3. razredu
planiran je od 24. do 28. septembra 2018.
Oktobar: Prvi pismeni zadatak u 1. i 4. razredu planiran je od 8. do 12. oktobra
2018. Pokušaj ujednacavanja kriterijuma ocenjivanja pismenih zadataka. Analiza
i pretres iznesenih iskustava, pristupa.
Novembar: Analiza uspeha u prvom klasifikacionom periodu.
Decembar: Izbor i usvajanje tema za maturski rad iz srpskog jezika i
književnosti. Drugi pismeni zadatak od 10. do 14. decembra 2018. Sagledati kako
tece realizacija nastave za prvo polutodište.
Januar: Obeležavanje Savindana. Razmena iskustava u vezi sa projektnom
nastavom i izbornim paketom.
Feruar: Analiza rezultata rada prvog polugodišta. Seminar prosvetnih
radnika na Filološkom fakultetu. Priprema za školsko takmicenje.
Organizacija školskog takmicenja.
Mart: Priprema opštinskog i gradskog takmicenja. Treci pismeni zadatak od 04.
03. do 8.03.2019.
April: Gradska takmicenja iz Srpskog jezika i jezicke kulture i Književne
olimpijade. Recitatorska takmicenja, debatni klub i besedništvo.
Maj: Konsultacije za polaganje maturskog ispita (priprema tema za pismene
zadatke na maturskom ispitu.) Razgovor o kandidatima za najboljeg literatu u
školi. Republicka takmicenja. Cetvrti pismeni zadatak od 7. do 14.maja 2019.
godine.
Juni: Sagledavanje realizacije školske godine. Analiza rada sekcija. Podela
casova. ')
INSERT [dbo].[Subject] ([IdSubject], [SubjectName], [Description]) VALUES (668, N'Geography', N'Septembar:
- Utvrdivanje zaduženja profesora u okviru cetrdestetocasovne radne
nedelje
- Izrada planova i programa za sve razrede i smerove
- Uredenje kabineta
- Dogovor u vezi nove reforme gimnazija i izborne nastave
- Nabavka novih nastavnih sredstava
Oktobar:
- Priprema za ekskurzije
- Saradnja sa Srpskim geografskim društvom
- Planiranje posete casovima kolega
- Dogovor o prisustvu seminarima
Novembar:
- Analiza izvedenih ekskurzija
- Izrada predloga maturskih tema
- Aktuelni problemi u nastavi
- Dogovor o poseti sajmu knjiga
- Analiza uspeha na prvom tromesecju
Decembar:
- Kriterijum ocenjivanja u aktivu
- Mere za poboljšanje uspeha ucenika
 Dogovor u vezi prisustva zimskom seminaru
Januar:
- Analiza uspeha na kraju prvog polugodišta
- Analiza realizovane nastave
- Ucestvovanje na seminarima
- Usvajanje maturskih tema i anketiranje ucenika
Februar:
- Izveštaj sa zimskog seminara
- Pomoc maturantima u vezi izrade maturskih tema
- Potreba za dopunskom nastavom
Mart:
- Medusobna poseta casovima
- Saradnja sa profesorima srodnih predmeta
- Pomoc maturantima u vezi izrade maturskih radova
April:
- Analiza uspeha nakraju treceg tromesecja
- Poseta profesora i ucenika muzeju ,, Jovan Cvijic “
- Prisustvo seminaru
Maj:
- Testiranje ucenika
- Pomoc maturantima
- Izrada programa ekskurzija
Jun:
- Realizacija nastavnih programa
- Realizacija maturskih ispita i izrada izveštaja
- Usvajanje izveštaja o radu aktiva u tekucoj godini
Avgust:
- Izrada godišnjih planova
- Predlog udžbenika i ucila
- Podela zaduženja casova redovne nastave
- Poseta seminaru')
INSERT [dbo].[Subject] ([IdSubject], [SubjectName], [Description]) VALUES (669, N'History', N'Avgust
-sastanak Strucnog veca
-usvajanje Izveštaja rada Aktiva
- usvajanje plana rada za novu školsku godinu
- utvrdivanje 40-casovne radne nedelje
- planiranje strucnog usavršavanja; izbor seminara i održavanja uglednih
casova
Septembar
- izrada globalnih i operativnih radova redovne nastave; planovi rada sekcija
-zaduženja vezana za vannastavne aktivnosti
- mere za poboljšanje uslova rada
- pregled i iskazivanje potrebe za nabavku nastavnih sredstava
Oktobar
- organizovanje dopunskog i dodatnog rada, kao i rada sekcija
- priprema za takmicenja, podela zaduženja
- prisustvo na uglednim casovima
Novembar
- analiza uspeha u prvom klasifikacionom periodu
- analiza realizacije planova predvidenih za prvo tromesecje
- razgovor o kriterijumu ocenjivanja
- razgovor o održavanju uglednih casova i medusobne posete uglednim casovima
Decembar
- izbor i usvajanje tema za maturske ispite
- ujednacavanje kriterijuma ocenjivanja
Januar
- analiza realizacije planova redovne nastave, kao i dopunske, dodatne nastave i
sekcija
- obeležavanje dana Svetog Save
Februar
- konsultacije sa maturantima u vezi izrade maturskih radova
- školsko takmicenje iz istorije
- održavanje i prisustvo na uglednim casovima
Mart
- opštinsko takmicenje iz istorije
- konsultacije sa maturantima u vezi izrade maturskih radova
April
- gradsko takmicenje iz istorije
- analiza treceg klasifikacionog perioda
- uzajamne posete uglednim casovima
- konsultacije sa maturantima u vezi izrade maturskih radova
- izbor udžbenika za sledecu školsku godinu
Maj
- republicko takmicenje iz istorije
- pregledanje i odbrana maturskih radova
- organizovanje pripremne nastave za polaganje prijemnih ispita na fakultetima
Jun
- analiza uspeha na kraju školske godine
- analiza uspeha na maturskim ispitima
Jul
- raspodela casova za sledecu školsku godinu
- izrada Izveštaja o radu Aktiva društvenih nauka i filozofije u protekloj
školskoj godini
- izveštaji sa posecenih seminara')
INSERT [dbo].[Subject] ([IdSubject], [SubjectName], [Description]) VALUES (670, N'English', N'Septembar
- Organizaciona pitanja ( raspored casova, vannastavne aktivnosti,
raspored korišcenja kabineta za strane jezike, plan pismenih zadataka,
izbor materijala za pismene zadatke)
- Priprema ucenika cetvrtog razreda za ekskurziju sa kulturno-jezickog
stanovišta
- Ukljucivanje ucenika u rad sekcija
- Projekat DSD ispit iz nemackog jezika- realizator Leonora Rakicevic
- Projekat DELF- realizator Marina Carapic
Oktobar
- Evidentiranje ucenika za dopunsku nastavu
Novembar
- Analiza uspeha u prvom klasifikacionom periodu, uporedivanje i
usaglašavanje kriterijuma ocenjivanja
Decembar
- Priprema tema za maturske radove
- Prilagodavanje uslovima školovanja u gimnaziji (ucenici prvog razreda)
Januar
- Proslava Svetog Save
- Konsultacije za izradu maturskih radova
Februar
- Analiza uspeha u prvom polugodištu
- Realizacija gradiva
- Organizacija školskog takmicenja
- Izveštaj sa zimskih seminara
Mart
- Priprema za gradsko takmicenje
- Školsko takmicenje iz latinskog jezika
- Frankofonija- realizator Marina Carapic
April
- Analiza uspeha u trecem klasifikacionom periodu
- Pripreme za republicko takmicenje
Maj
- Priprema tekstova za maturski ispit iz stranih jezika
- Pregled maturskih radova
Jun
- Uspeh ucenika na kraju nastavne godine
- Realizacija plana i programa
- Realizacija dopunske, dodatne nastave, sekcija
- Uspeh ucenika na takmicenjima
- Podela casova
Avgust
- Odbrana maturskih radova za vanredne ucenike i maturante koji su
imali popravni ispit.
- Usvajanje plana rada za školsku godinu
- Utvrdivanje 40-to casovne sedmice
- Plan strucnog usavršavanja')
INSERT [dbo].[Subject] ([IdSubject], [SubjectName], [Description]) VALUES (671, N'Music', N'Septembar
 - opremanje kabineta, nabavka i izrada nastavnih sredstava i ucila
 - formiranje sekcija, audicije za mizicke sekcije i hor
 - usaglašavanje kalendara aktivno
Oktobar
 - planiranje strucnog usavršavanja profesora
 - Koncipiranje programa za nastupe, plan školskih izložbi, takmicenja i
 ucešca u projektima
 - Korišcenje školskig kluba
Novembar
 - analiza uspeha ucenika na kraju prvog tromesecja školske
 - analiza rada klubova
 - docek, radionice i koncert ucenika gimnazije iz Cacka
Decembar
- priprema i izvodenje novogodišnje priredbe
- odabir i postavka novogodišnje izložbe ucenickih radova
- priprema i izvodenje programa Talentovani ucenici Prve
Januar
-priprema i izvodenje priredbe za školasku slavu Sv Sava
-odabir radova i postavka izložbe ucenickih radova za školsku slavu Sv
Sava
- analiza uspeha ucenika na kraju prvog polugodišta
- analiza rada sekcija na kraju prvog polugodišta
-konsultacije vezane za mentorske poslove u okviru izrade maturskih radova
ucenika
Februar
- strucno usavršavanje profesora
- saradnja sa fakultetima likovne i muzicke umetnosti (mentorski poslovi
vezani za rad sa studentima umetnosti)
Mart
- priprema nastupa školskih bendova
 - pripreme za ucešce na BEOKULIS-u i Republickoj smotri likovnih radova
April
-Priprema i nastup ucenika na takmicenju horova u Novom Sadu
- poseta gimnaziji sa kojom ostvarimo kontakt u okviru Art karavana
Maj
- ucešce ucenika na takmicenjima (Beokulis, Vukov sabor)
- ucešce na smotri Regonalnog centra za talente Beograd 2
-analiza uspeha maturanata
- pripreme za Dan škole
Juni
- proslava Dana škole ( nastup hora, talentovanih solista, godišnja izložba
likovnih radova)
-evaluacija uspeha ucenika na takmicenjima
-analiza uspeha ucenika na kraju školske godine
 -analiza rada klubova
')
INSERT [dbo].[Subject] ([IdSubject], [SubjectName], [Description]) VALUES (672, N'PE', N'Septembar
- dogovor oko realizacije programa po ciklusima:
- podela zaduženja i termina za vannastavne aktivnosti
- dogovor u vezi sa oslobadanjem ucenika od prakticne
nastave
- razgovor o nacinu i vremenu korišcenja veštacke stene
- planiranje nabavke novih nastavnih sredstava sredstva
(sprava i rekvizita)
- rešavanje problema sa higijenom u objektu radi
smanjenja broja obolelih (sala, svlacionice i sanitarni
cvor)
- priprema ucenika za opštinska takmicenja
- priprema i popravka rekvizita za pocetak školske godine
- Planiranje strucnog usavršavanja
- Uclanjivanje ucenika u Crveni krst
Oktobar
 usaglašavanje kriterijuma ocenjivanja
- mere i predlozi za poboljšanje nastavnog procesa
- planiranje medusobne posete casovima u novembru i
aprilu
- priprema jesenjeg krosa opštine Stari grad
- prijava i selekcija ucenika koji ce ucestvovati na
Beogradskom i Praškom maratonu - Jesenji kros škole
(predkvalifikacije)
- razgovor o izvodenju seminara i izveštaj sa istih pred
oblasnom komisijom
- dogovor o poseti studenata Fakulteta za sport i fizicko
vaspitanje, casovima fizickog vaspitanja, radi
realizovanja prakticnog dela ispita iz metodike
nastave
- priprema ucenika za opštinska takmicenja
Novembar
- analiza realizovanog i savladanog programa
- analiza uspeha na kraju prvog klasifikacionog perioda
- otklanjanje problema u nastavi (dve nastavne jedinice
na jednom casu, homogenost grupa i intenzitet rada na
casu)
- medusobno posecivanje casova
- priprema ucenika za opštinska takmicenja
Decembar
- dogovor i priprema predstojeceg kursa skijanja
(poštovanje kriterijuma ucešca - primerno vladanje,
pozitivan uspeh na polugodištu), izbor termina i
lokacije
- analiza realizovanog programa
Januar
- analiza broja slabih ocena, oslobadanje ucenika,
potrebe za novim nastavnim sredstvima
- izrada strucnog programa rada na skijaškom
sedmodnevnom kursu
- priprema ucenika za opštinska takmicenja
Februar
- analiza rada sekcije
- pripreme školskih sportskih ekipa za opštinsko i
gradsko takmicenje
- tribina Crvenog krsta
Mart
- mere i predlozi za poboljšanje nastavnog procesa
- rešavanje problema higijene na casovima
- priprema ucenika za opštinska takmicenja
- analiza realizovanog skijaškog kursa
- tribina Crvenog krsta
April
- analiza uspeha i realizacije nastavnog plana i programa
na trecoj klasifikaciji
- tribina Crvenog krsta
- pripreme i ucešce na Beogradskom maratonu
- kurs Prve pomoci
- trka beogradskih maturanata u veslanju
- priprema, izbor i ucešce školske ekipe na Praškom
maratonu
- završetak razrednog prvenstva u košarci i odbojci
(finalni susret)
- odbojka, memorijal Dragoslav Miladinovic
Maj
- analiza takmicenja u odbojci i košarci po razredima
- Pripreme i dogovor o predstojecem testiranju fizickog razvoja
i sposobnosti
- Usaglašavanje kriterijuma ocenjivanja.
- Turnir u malom fudbalu – memorijal Aleksandar
Radovic
Jun
- analiza uspeha i realizacija i savladavanje nastavnih
planova i programa na kraju nastavne godine
- priprema godišnjih izveštaja
- sredivanje pedagoške dokumentacije, podela zaduženja ')
INSERT [dbo].[Subject] ([IdSubject], [SubjectName], [Description]) VALUES (673, N'Informatics', N'- Izrada godišnjih globalnih i mesecnih operativnih planova rada
- Usvajanje udžbenika
- Planiranje pismenih zadataka za treci razred
- Ujednacavanje kriterijuma ocenjivanja i definisanje minimuma zahteva za
pozitivnu ocenu
- Analiza ostvarenja plana i programa i uspeha ucenika na kraju
klasifikacionih perioda
- Realizacija dopunske i dodatne nastave
- Nastavak rada na formiranju racunarskog Studija sa odgovarajucim
sekcijama
- Planiranje testiranja ucenika
- Izrada testova za testiranje ucenika
- Izbor i predlog maturskih tema
- Podela casova za narednu školsku godinu kao i podela zaduženja u okviru
40. casovne radne nedelje
- Dopuniti projekat elektronske nastave
- Strucno usavršavanje (seminari, tribine)
- Ostali poslovi koji se obavljaju u toku školske godine
- Ugledni cas')
INSERT [dbo].[Subject] ([IdSubject], [SubjectName], [Description]) VALUES (674, N'Arts', N'Septembar
 - opremanje kabineta, nabavka i izrada nastavnih sredstava i ucila
 - formiranje sekcija, audicije za mizicke sekcije i hor
 - usaglašavanje kalendara aktivno
Oktobar
 - planiranje strucnog usavršavanja profesora
 - Koncipiranje programa za nastupe, plan školskih izložbi, takmicenja i
 ucešca u projektima
 - Korišcenje školskig kluba
Novembar
 - analiza uspeha ucenika na kraju prvog tromesecja školske
 - analiza rada klubova
 - docek, radionice i koncert ucenika gimnazije iz Cacka
Decembar
- priprema i izvodenje novogodišnje priredbe
- odabir i postavka novogodišnje izložbe ucenickih radova
- priprema i izvodenje programa Talentovani ucenici Prve
Januar
-priprema i izvodenje priredbe za školasku slavu Sv Sava
-odabir radova i postavka izložbe ucenickih radova za školsku slavu Sv
Sava
- analiza uspeha ucenika na kraju prvog polugodišta
- analiza rada sekcija na kraju prvog polugodišta
-konsultacije vezane za mentorske poslove u okviru izrade maturskih radova
ucenika
Februar
- strucno usavršavanje profesora
- saradnja sa fakultetima likovne i muzicke umetnosti (mentorski poslovi
vezani za rad sa studentima umetnosti)
Mart
- priprema nastupa školskih bendova
 - pripreme za ucešce na BEOKULIS-u i Republickoj smotri likovnih radova
April
-Priprema i nastup ucenika na takmicenju horova u Novom Sadu
- poseta gimnaziji sa kojom ostvarimo kontakt u okviru Art karavana
Maj
- ucešce ucenika na takmicenjima (Beokulis, Vukov sabor)
- ucešce na smotri Regonalnog centra za talente Beograd 2
-analiza uspeha maturanata
- pripreme za Dan škole
Juni
- proslava Dana škole ( nastup hora, talentovanih solista, godišnja izložba
likovnih radova)
-evaluacija uspeha ucenika na takmicenjima
-analiza uspeha ucenika na kraju školske godine
 -analiza rada klubova')
INSERT [dbo].[Subject] ([IdSubject], [SubjectName], [Description]) VALUES (675, N'Latin', N'Septembar
- Organizaciona pitanja ( raspored casova, vannastavne aktivnosti,
raspored korišcenja kabineta za strane jezike, plan pismenih zadataka,
izbor materijala za pismene zadatke)
- Priprema ucenika cetvrtog razreda za ekskurziju sa kulturno-jezickog
stanovišta
- Ukljucivanje ucenika u rad sekcija
- Projekat DSD ispit iz nemackog jezika- realizator Leonora Rakicevic
- Projekat DELF- realizator Marina Carapic
Oktobar
- Evidentiranje ucenika za dopunsku nastavu
Novembar
- Analiza uspeha u prvom klasifikacionom periodu, uporedivanje i
usaglašavanje kriterijuma ocenjivanja
Decembar
- Priprema tema za maturske radove
- Prilagodavanje uslovima školovanja u gimnaziji (ucenici prvog razreda)
Januar
- Proslava Svetog Save
- Konsultacije za izradu maturskih radova
Februar
- Analiza uspeha u prvom polugodištu
- Realizacija gradiva
- Organizacija školskog takmicenja
- Izveštaj sa zimskih seminara
Mart
- Priprema za gradsko takmicenje
- Školsko takmicenje iz latinskog jezika
- Frankofonija- realizator Marina Carapic
April
- Analiza uspeha u trecem klasifikacionom periodu
- Pripreme za republicko takmicenje
Maj
- Priprema tekstova za maturski ispit iz stranih jezika
- Pregled maturskih radova
Jun
- Uspeh ucenika na kraju nastavne godine
- Realizacija plana i programa
- Realizacija dopunske, dodatne nastave, sekcija
- Uspeh ucenika na takmicenjima
- Podela casova
Avgust
- Odbrana maturskih radova za vanredne ucenike i maturante koji su
imali popravni ispit.
- Usvajanje plana rada za školsku godinu
- Utvrdivanje 40-to casovne sedmice
- Plan strucnog usavršavanja
')
INSERT [dbo].[Subject] ([IdSubject], [SubjectName], [Description]) VALUES (676, N'Biology', N'AVGUST-SEPTEMBAR
1. izrada planova za sve razrede i smerove
2. planiranje potreba za izvodenje kabinetske nastave
3. planiranje aktivnosti vezanih za strucno usavršavanje
4. planiranje održavanja uglednih casova
5. planiranje aktivnosti školske Biološke sekcije ``Vrabac``
6. izrada plana rada Aktiva za školsku 2018/2019 godinu
7. razmatranje plana rada nastavnika za prvi razred po novom reformisanom
planu i programu
8. izrada testa i inicijalno testiranje ucenika prvog razreda
OKTOBAR
1. planiranje dodatne i dopunske nastave
2. izrada prezentacija nastavnih jedinica
NOVEMBAR
1. evidentiranje ucenika za maturske radove
2. analiza uspeha prvog klasifikacionog perioda
DECEMBAR
1. predlaganje tema za maturske radove
2. konsultacije vezane za izradu maturskih radova
JANUAR
1. analiza mentorskog rada sa maturantima
2. završne aktivnosti vezane za kraj prvog polugodišta
FEBRUAR
1. problemi u realizaciji redovne nastave
2. problemi u realizaciji kabinetske nastave
3. analiza uspeha na kraju prvog polugodišta
4. izrada testova za školsko takmicenje
5. evidentiranje ucenika za školsko takmicenje
6. izrada izveštaja o radu Aktiva za prvo polugodište školske 2018/2019
godine
MART
1. organizacija školskog takmicenja
2. prijava i priprema ucenika za gradsko takmicenje
3. gradsko takmicenje
4. mentorski rad ca maturantima
APRIL
1. analiza uspeha treceg klasifikacionog perioda
2. mentorski rad ca maturantima
3. priprema ucenika za republicko takmicenje
MAJ I JUN
1. izvodenje i analiza uspeha na maturskim ispitima
2. priprema ucenika za republicko takmicenje
3. republicko takmicenje
4. analiza uspeha na takmicenjima
5. realizacija plana i programa
6. analiza uspeha na kraju drugog polugodišta
7. izrada izveštaja o radu Aktiva za školsku 2018/2019 godinu
8. izbor udžbenika i literature
9. diskusija o realizovanim seminarima
10. analiza aktivnosti školske Biološke sekcije ``Vrabac``
11. analiza rada nastavnika prvog razreda (usled novog reformisanog
programa rada).a školsko takmicenje')
INSERT [dbo].[Subject] ([IdSubject], [SubjectName], [Description]) VALUES (677, N'Chemistry', N'Septembar: - planiranje redovne, dodatne, dopunske i pripremne nastave za takmicenje - sredivanje kabineta i nabavka ucila i hemikalija - upoznavanje sa planom rada aktiva za hemiju i dogovor o radu - strucno usavršavanje nastavnika- seminar za tehnike ucenja - inicijalno testiranje ucenika prvog razreda, analiza i prikaz rezultata oktobar: - organizovanje dodatne i dopunske nastave - organizovanje vežbi i rada u kabinetu - medusobne posete profesora casovima - korelacija sa drugim predmetima - planirati ugledne casove, koji ce za cilj imati osvešcivanje procesa ucenja novembar: - analiza rada nastavnika i aktiva - analiza realizacije dopunske i dodatne nastave - analiza uspeha u prvom klasifikacionom periodu - podsticanje vršnjacke interakcije, organizovanje rada u paru i grupi tokom casa decembar: - dogovor o usaglašavanju kriterijuma ocenjivanja - izveštaj o uspehu na kraju prvog polugodišta - usvajanje maturskih tema januar: - analiza uspešnosti nastave - ucešce nastavnika na seminarima - realizacija casova- prezentacija, istraživanje februar: - organizacija rada kabineta u drugom polugodištu - priprema ucenika za takmicenje - konsultacije sa maturantima mart: - utvrdivanje mera za poboljšanje uspeha ucenika - medusobne posete profesora casovima - analiza rad dopunske i dodatne nastave - priprema za takmicenje april: - pracenje realizacije redovne, dopunske i dodatne nastave - ra zmatranje eventualnih teškoca u radu - dopunska nabavka hemikalija - prijavljivanje ucenika za Petnicu - poseta naucne ustanove ,,Vinca,, maj: - analiza rezultata sa takmicenja - analiza uspeha i znanja maturanata - saradnja se Hemijskim fakultetom (predavanja i seminari) jun: - realizacija maturskih ispita - analiza rada Aktiva - izveštaj o radu Aktiva - podela casova za sledecu školsku godinu avgust: - izrada i usvajanje godišnjih planova rada - usvajanje plana rada Aktiva - planiranje nabavke potrošnog materijala za kabinet - predlozi mera za poboljšanje uspešnosti nastave - analiza mera za povecanje saradnje sa aktivima predmeta prirodnih nauka i realizacija nastavnih jedinica koje su u korelaciji')
INSERT [dbo].[Subject] ([IdSubject], [SubjectName], [Description]) VALUES (678, N'German', N'Septembar
- Organizaciona pitanja ( raspored casova, vannastavne aktivnosti,
raspored korišcenja kabineta za strane jezike, plan pismenih zadataka,
izbor materijala za pismene zadatke)
- Priprema ucenika cetvrtog razreda za ekskurziju sa kulturno-jezickog
stanovišta
- Ukljucivanje ucenika u rad sekcija
- Projekat DSD ispit iz nemackog jezika- realizator Leonora Rakicevic
- Projekat DELF- realizator Marina Carapic
Oktobar
- Evidentiranje ucenika za dopunsku nastavu
Novembar
- Analiza uspeha u prvom klasifikacionom periodu, uporedivanje i
usaglašavanje kriterijuma ocenjivanja
Decembar
- Priprema tema za maturske radove
- Prilagodavanje uslovima školovanja u gimnaziji (ucenici prvog razreda)
Januar
- Proslava Svetog Save
- Konsultacije za izradu maturskih radova
Februar
- Analiza uspeha u prvom polugodištu
- Realizacija gradiva
- Organizacija školskog takmicenja
- Izveštaj sa zimskih seminara
Mart
- Priprema za gradsko takmicenje
- Školsko takmicenje iz latinskog jezika
- Frankofonija- realizator Marina Carapic
April
- Analiza uspeha u trecem klasifikacionom periodu
- Pripreme za republicko takmicenje
Maj
- Priprema tekstova za maturski ispit iz stranih jezika
- Pregled maturskih radova
Jun
- Uspeh ucenika na kraju nastavne godine
- Realizacija plana i programa
- Realizacija dopunske, dodatne nastave, sekcija
- Uspeh ucenika na takmicenjima
- Podela casova
Avgust
- Odbrana maturskih radova za vanredne ucenike i maturante koji su
imali popravni ispit.
- Usvajanje plana rada za školsku godinu
- Utvrdivanje 40-to casovne sedmice
- Plan strucnog usavršavanja')
INSERT [dbo].[Subject] ([IdSubject], [SubjectName], [Description]) VALUES (679, N'Physics', N'Septembar
- izrada globalnih i operativnih planova redovne nastave za tekucu
školsku godinu.
- usaglašavanje kriterijuma
- pripreme za nastavu i kvalitetno vodenje casova
- primena savremenih metoda u izvodenju nastave
- mere za poboljšanje uslova rada
- pregled i iskazivanje potrebe za nabavku nastavnih sredstava
- sredivanje i cišcenje kabineta
Oktobar
- organizovanje dodatnog i dopunskog rada
- organizovanje novih eksperimentalnih vežbi
- pisanje priprema za laboratorijske vežbe
- organizovanje predavanja iz fizike i astronomije
- usaglašavanje izbora zadataka za kontrolne vežbe
- usaglašavanje kriterijuma za ocenjivanje vežbi
- analiza postignutog znanja ucenika na osnovu rezultata prvih kontrolnih
vežbi.
Novembar
- analiza uspeha na prvom klasifikacionom periodu
- predlog mera za poboljšanje uspeha
- analiza realizacije planova predvidenih za prvo tromesecje
- razgovor o kriterijumu ocenjivanja
Decembar
- izbor tema za maturski ispit
- uzajamne posete casovima i diskusije u vezi sa tim
- ujednacavanje kriterijuma ocenjivanja
Januar
- analiza realizacije planova redovne, dopunske i dodatne nastave u
prvom polugodištu
- analiza uspeha ucenika iz fizike na kraju prvog polugodišta
- preduzimanje mera za povecanje zainteresovanosti za nastavu fizike
- nabavka novih nastavnih sredstava i ucila kao i potrošnog materijala
za kabinet
- popravka starih instrumenata i sredivanje kabineta
- priprema ucenika za školsko takmicenje iz fizike
- konsultacije sa maturantima koji rade maturske radove iz fizike.
Februar
- priprema ucenika za Opštinsko takmicenje iz fizike.
- realizacija Opštinskog takmicenja.,analiza postignutih rezultata sa
tamicenja
- opremanje i sredivanje kabineta.
predlog inovacija u teorijskoj nastavi.
- ugledni cas iz fizike, razgovor o uglednom casu
Mart
- priprema ucenika za gradsko takmicenje iz fizike.
- realizacija gradskog takmicenja,analiza postignutih rezultata sa
takmicenja.
- analiza realizacije eksperimentalnih vežbi.
- analiza postignutih rezultata i ocena posle treceg klasifikacionog
perioda.
- preduzimanje adekvatnih mera za poboljšanje uspeha i motivacije
ucenika.
- konsultacije sa maturantima koji rade maturske radove iz fizike.
April
- priprema ucenika za Državno takmicenje iz fizike.
- analiza postignutih rezultata sa takmicenja.
- organizovanje novih eksperimentalnih vežbi.
- popravka starih instrumenata i sredivanje kabineta.
- slanje ucenika na Fizicki fakultet u okviru “Otvorenih vrata”.
- planirano je da svi clanovi aktiva prisustvuju Republickom seminaru o
nastavi fizike kao i seminaru koji ce organizovati naša škola za svoje
nastavnike.
Maj
- organizovanje komisija za odbranu maturskih radova i relizacija
odbrane radova.U odbrani i realizaciji ucestvuju profesori koji
predaju maturantima.
Jun
- organizacija i realizacija popravnih ispita za maturante.
- analiza uspeha ucenika iz fizike na kraju školske godine.
- predlog mera za poboljšanje uspeha u narednoj godini
Jul
- podela casova za narednu školsku godinu
- pisanje izveštaja aktiva za tekucu školsku godinu.
- usvajanje izveštaja o radu u protekloj godini
Avgust
- organizacija i realizacija popravnih ispita za ucenike prvih, drugih i
trecih razreda.
- odbrana maturskih radova za vanredne ucenike i maturante koji su imali
popravni ispit.
- usvajanje plana rada za školsku godinu
- utvrdivanje 40-to casovne sedmice
- plan strucnog usavršavanja i izbor tema za seminare
- usvajanje udžbenika i zbirki ')
INSERT [dbo].[Subject] ([IdSubject], [SubjectName], [Description]) VALUES (16679, N'Logics', N'Avgust
-sastanak Strucnog veca
-usvajanje Izveštaja rada Aktiva
- usvajanje plana rada za 2018/2019.godinu
- utvrdivanje 40-casovne radne nedelje
- planiranje strucnog usavršavanja; izbor seminara i održavanja uglednih
casova
Septembar
- izrada globalnih i operativnih radova redovne nastave; planovi rada sekcija
-zaduženja vezana za vannastavne aktivnosti
- mere za poboljšanje uslova rada
- pregled i iskazivanje potrebe za nabavku nastavnih sredstava
Oktobar
- organizovanje dopunskog i dodatnog rada, kao i rada sekcija
- priprema za takmicenja, podela zaduženja
- prisustvo na uglednim casovima
Novembar
- analiza uspeha u prvom klasifikacionom periodu
- analiza realizacije planova predvidenih za prvo tromesecje
- razgovor o kriterijumu ocenjivanja
- razgovor o održavanju uglednih casova i medusobne posete uglednim casovima
Decembar
- izbor i usvajanje tema za maturske ispite
- ujednacavanje kriterijuma ocenjivanja
Januar
- analiza realizacije planova redovne nastave, kao i dopunske, dodatne nastave i
sekcija
- obeležavanje dana Svetog Save
Februar
- konsultacije sa maturantima u vezi izrade maturskih radova
- školsko takmicenje iz istorije
- održavanje i prisustvo na uglednim casovima
Mart
- opštinsko takmicenje iz istorije
- konsultacije sa maturantima u vezi izrade maturskih radova
April
- gradsko takmicenje iz istorije
- analiza treceg klasifikacionog perioda
- uzajamne posete uglednim casovima
- konsultacije sa maturantima u vezi izrade maturskih radova
- izbor udžbenika za sledecu školsku godinu
Maj
- republicko takmicenje iz istorije
- pregledanje i odbrana maturskih radova
- organizovanje pripremne nastave za polaganje prijemnih ispita na fakultetima
Jun
- analiza uspeha na kraju školske godine
- analiza uspeha na maturskim ispitima
Jul
- raspodela casova za sledecu školsku godinu
- izrada Izveštaja o radu Aktiva društvenih nauka i filozofije u protekloj školskoj godini
- izveštaji sa posecenih seminara
')
INSERT [dbo].[Subject] ([IdSubject], [SubjectName], [Description]) VALUES (16680, N'Philosophy', N'Avgust
-sastanak Strucnog veca
-usvajanje Izveštaja rada Aktiva
- usvajanje plana rada za 2018/2019.godinu
- utvrdivanje 40-casovne radne nedelje
- planiranje strucnog usavršavanja; izbor seminara i održavanja uglednih
casova
Septembar
- izrada globalnih i operativnih radova redovne nastave; planovi rada sekcija
-zaduženja vezana za vannastavne aktivnosti
- mere za poboljšanje uslova rada
- pregled i iskazivanje potrebe za nabavku nastavnih sredstava
Oktobar
- organizovanje dopunskog i dodatnog rada, kao i rada sekcija
- priprema za takmicenja, podela zaduženja
- prisustvo na uglednim casovima
Novembar
- analiza uspeha u prvom klasifikacionom periodu
- analiza realizacije planova predvidenih za prvo tromesecje
- razgovor o kriterijumu ocenjivanja
- razgovor o održavanju uglednih casova i medusobne posete uglednim casovima
Decembar
- izbor i usvajanje tema za maturske ispite
- ujednacavanje kriterijuma ocenjivanja
Januar
- analiza realizacije planova redovne nastave, kao i dopunske, dodatne nastave i
sekcija
- obeležavanje dana Svetog Save
Februar
- konsultacije sa maturantima u vezi izrade maturskih radova
- školsko takmicenje iz istorije
- održavanje i prisustvo na uglednim casovima
Mart
- opštinsko takmicenje iz istorije
- konsultacije sa maturantima u vezi izrade maturskih radova
April
- gradsko takmicenje iz istorije
- analiza treceg klasifikacionog perioda
- uzajamne posete uglednim casovima
- konsultacije sa maturantima u vezi izrade maturskih radova
- izbor udžbenika za sledecu školsku godinu
Maj
- republicko takmicenje iz istorije
- pregledanje i odbrana maturskih radova
- organizovanje pripremne nastave za polaganje prijemnih ispita na fakultetima
Jun
- analiza uspeha na kraju školske godine
- analiza uspeha na maturskim ispitima
Jul
- raspodela casova za sledecu školsku godinu
- izrada Izveštaja o radu Aktiva društvenih nauka i filozofije u protekloj školskoj godini
- izveštaji sa posecenih seminara')
INSERT [dbo].[Subject] ([IdSubject], [SubjectName], [Description]) VALUES (16681, N'Sociology', N'Avgust
-sastanak Strucnog veca
-usvajanje Izveštaja rada Aktiva
- usvajanje plana rada za 2018/2019.godinu
- utvrdivanje 40-casovne radne nedelje
- planiranje strucnog usavršavanja; izbor seminara i održavanja uglednih
casova
Septembar
- izrada globalnih i operativnih radova redovne nastave; planovi rada sekcija
-zaduženja vezana za vannastavne aktivnosti
- mere za poboljšanje uslova rada
- pregled i iskazivanje potrebe za nabavku nastavnih sredstava
Oktobar
- organizovanje dopunskog i dodatnog rada, kao i rada sekcija
- priprema za takmicenja, podela zaduženja
- prisustvo na uglednim casovima
Novembar
- analiza uspeha u prvom klasifikacionom periodu
- analiza realizacije planova predvidenih za prvo tromesecje
- razgovor o kriterijumu ocenjivanja
- razgovor o održavanju uglednih casova i medusobne posete uglednim casovima
Decembar
- izbor i usvajanje tema za maturske ispite
- ujednacavanje kriterijuma ocenjivanja
Januar
- analiza realizacije planova redovne nastave, kao i dopunske, dodatne nastave i
sekcija
- obeležavanje dana Svetog Save
Februar
- konsultacije sa maturantima u vezi izrade maturskih radova
- školsko takmicenje iz istorije
- održavanje i prisustvo na uglednim casovima
Mart
- opštinsko takmicenje iz istorije
- konsultacije sa maturantima u vezi izrade maturskih radova
April
- gradsko takmicenje iz istorije
- analiza treceg klasifikacionog perioda
- uzajamne posete uglednim casovima
- konsultacije sa maturantima u vezi izrade maturskih radova
- izbor udžbenika za sledecu školsku godinu
Maj
- republicko takmicenje iz istorije
- pregledanje i odbrana maturskih radova
- organizovanje pripremne nastave za polaganje prijemnih ispita na fakultetima
Jun
- analiza uspeha na kraju školske godine
- analiza uspeha na maturskim ispitima
Jul
- raspodela casova za sledecu školsku godinu
- izrada Izveštaja o radu Aktiva društvenih nauka i filozofije u protekloj školskoj godini
- izveštaji sa posecenih seminara
')
INSERT [dbo].[Subject] ([IdSubject], [SubjectName], [Description]) VALUES (16682, N'Psychology', N'Avgust
-sastanak Strucnog veca
-usvajanje Izveštaja rada Aktiva
- usvajanje plana rada za 2018/2019.godinu
- utvrdivanje 40-casovne radne nedelje
- planiranje strucnog usavršavanja; izbor seminara i održavanja uglednih
casova
Septembar
- izrada globalnih i operativnih radova redovne nastave; planovi rada sekcija
-zaduženja vezana za vannastavne aktivnosti
- mere za poboljšanje uslova rada
- pregled i iskazivanje potrebe za nabavku nastavnih sredstava
Oktobar
- organizovanje dopunskog i dodatnog rada, kao i rada sekcija
- priprema za takmicenja, podela zaduženja
- prisustvo na uglednim casovima
Novembar
- analiza uspeha u prvom klasifikacionom periodu
- analiza realizacije planova predvidenih za prvo tromesecje
- razgovor o kriterijumu ocenjivanja
- razgovor o održavanju uglednih casova i medusobne posete uglednim casovima
Decembar
- izbor i usvajanje tema za maturske ispite
- ujednacavanje kriterijuma ocenjivanja
Januar
- analiza realizacije planova redovne nastave, kao i dopunske, dodatne nastave i
sekcija
- obeležavanje dana Svetog Save
Februar
- konsultacije sa maturantima u vezi izrade maturskih radova
- školsko takmicenje iz istorije
- održavanje i prisustvo na uglednim casovima
Mart
- opštinsko takmicenje iz istorije
- konsultacije sa maturantima u vezi izrade maturskih radova
April
- gradsko takmicenje iz istorije
- analiza treceg klasifikacionog perioda
- uzajamne posete uglednim casovima
- konsultacije sa maturantima u vezi izrade maturskih radova
- izbor udžbenika za sledecu školsku godinu
Maj
- republicko takmicenje iz istorije
- pregledanje i odbrana maturskih radova
- organizovanje pripremne nastave za polaganje prijemnih ispita na fakultetima
Jun
- analiza uspeha na kraju školske godine
- analiza uspeha na maturskim ispitima
Jul
- raspodela casova za sledecu školsku godinu
- izrada Izveštaja o radu Aktiva društvenih nauka i filozofije u protekloj školskoj godini
- izveštaji sa posecenih seminara
')
SET IDENTITY_INSERT [dbo].[Subject] OFF
GO
SET IDENTITY_INSERT [dbo].[Teacher] ON 

INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (3456, N'Nevenka', N'Grabundzija', CAST(N'1968-08-05' AS Date), N'Molerova 13', N'0113291475', 3, 668, 11)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (3457, N'Svetlana', N'Jovanovic', CAST(N'1977-12-11' AS Date), N'Njegoseva 3', N'0113239548', 2, 667, 12)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (3458, N'Vera', N'Vuksan', CAST(N'1966-04-05' AS Date), N'Kralja Petra 88', N'0112029382', 2, 669, 13)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (3459, N'Marina', N'Samardzija', CAST(N'1967-04-14' AS Date), N'Francuska 2', N'0113423849', 3, 670, 14)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (3460, N'Snezana', N'Filipovic', CAST(N'1972-09-02' AS Date), N'Vojvode Stepe 224', N'0117734391', 1, 671, 15)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (3461, N'Zorica', N'Jovanovic', CAST(N'1974-08-09' AS Date), N'Zaplanjska 99', N'0113823212', 1, 672, 16)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (3462, N'Marina', N'Cudanov', CAST(N'1977-03-29' AS Date), N'Ruzveltova 67', N'0114235233', 1, 674, 21)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (3463, N'Radana', N'Kizic', CAST(N'1988-06-30' AS Date), N'Mihajla Pupina 238', N'0114983743', 1, 673, 22)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (3464, N'Vera', N'Cvetkovic', CAST(N'1982-01-05' AS Date), N'Kraljice Marije 8', N'0119434931', 1, 675, 23)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (3465, N'Tanja', N'Kilibarda', CAST(N'1983-09-28' AS Date), N'Masarikova 45', N'0117493914', 2, 676, 24)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (3466, N'Slobodanka', N'Prijic', CAST(N'1962-01-19' AS Date), N'Dositejeva 78', N'0113497311', 2, 677, 25)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (3467, N'Leonora', N'Rakicevic', CAST(N'1959-02-28' AS Date), N'Sindjeliceva 84', N'0119272207', 3, 678, 26)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (3468, N'Ruzica', N'Bogdanovic', CAST(N'1981-03-28' AS Date), N'Nusiceva 27', N'0116662193', 3, 666, 31)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (3469, N'Aleksandra', N'Popovic', CAST(N'1983-07-08' AS Date), N'Ilije Garasanina 8', N'0119183190', 1, 666, 32)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (3470, N'Mihajlo', N'Culum', CAST(N'1958-08-05' AS Date), N'Hilandarska 4', N'0113743949', 2, 669, 33)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (3471, N'Risto', N'Dilparic', CAST(N'1960-11-12' AS Date), N'Kraljice Marije 29', N'0118944390', 1, 668, 34)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (3473, N'Jovan', N'Mrdjenovacki', CAST(N'1961-09-10' AS Date), N'Nehruova 78', N'0112384531', 3, 674, 35)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (3475, N'Ljiljana', N'Majkic', CAST(N'1966-06-08' AS Date), N'Mihajla Pupina 3', N'0114973194', 3, 666, 36)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (3476, N'Biljana', N'Kovacevic', CAST(N'1984-06-13' AS Date), N'Omladinskih brigada 24', N'0118493941', 2, 667, 41)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (3477, N'Katarina', N'Krnetic', CAST(N'1981-10-13' AS Date), N'Visegradska 19', N'0113297530', 2, 667, 42)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (3479, N'Vesna', N'Lukic', CAST(N'1972-11-07' AS Date), N'Kneza Milosa 2', N'0113431908', 1, 678, 43)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (3480, N'Vera', N'Vujcic', CAST(N'1981-07-06' AS Date), N'Zorza Klemansoa 41', N'0118923123', 1, 673, 44)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (3482, N'Dragana', N'Domazetovic', CAST(N'1970-12-08' AS Date), N'Spanskih boraca 190', N'0119932314', 2, 676, 45)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (3483, N'Cedo', N'Skoric', CAST(N'1988-05-05' AS Date), N'Kralja Petra 93', N'0118725662', 1, 679, 46)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (19484, N'Jelisavka', N'Eric', CAST(N'1959-01-01' AS Date), N'Solunska 12', N'0113232768', 1, 670, 28)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (21484, N'Nemanja', N'Kanacki', CAST(N'1973-06-09' AS Date), N'Nusiceva 72', N'011872903', 1, 16679, 110)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (21485, N'Iris', N'Jankovic', CAST(N'1968-02-01' AS Date), N'Mihajla Pupina 13', N'0117262392', 2, 16680, NULL)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (21486, N'Katarina', N'Mitric', CAST(N'1982-01-11' AS Date), N'Omladinskih brigada 12', N'0113292333', 1, 677, NULL)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (21487, N'Milan', N'Prokic', CAST(N'1959-09-03' AS Date), N'Starine Novaka 43', N'0118928311', 2, 679, NULL)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (21488, N'Biljana', N'Krstic', CAST(N'1967-09-03' AS Date), N'Carigradska 83', N'0119287274', 2, 669, NULL)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (21489, N'Dragan', N'Cingelic', CAST(N'1979-12-12' AS Date), N'Hilandarska 5', N'0119282901', 1, 672, NULL)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (21490, N'Snezana', N'Kuzmanovic', CAST(N'1973-03-11' AS Date), N'Kneza Milosa 7', N'0113233492', 1, 16681, NULL)
INSERT [dbo].[Teacher] ([IdTeacher], [FirstName], [LastName], [BirthDate], [Address], [PhoneNumber], [AcademicLevel], [IdSubject], [IdClassHomeroomTeacher]) VALUES (21491, N'Aleksandra', N'Spasojevic', CAST(N'1978-05-03' AS Date), N'Kralja Milana 93', N'011982444', 1, 16682, NULL)
SET IDENTITY_INSERT [dbo].[Teacher] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([IdUser], [FirstName], [LastName], [Username], [Password]) VALUES (1, N'Pera', N'Peric', N'pera', N'pera')
INSERT [dbo].[Users] ([IdUser], [FirstName], [LastName], [Username], [Password]) VALUES (2, N'Zika', N'Zikic', N'zika', N'zika')
INSERT [dbo].[Users] ([IdUser], [FirstName], [LastName], [Username], [Password]) VALUES (3, N'Laza', N'Lazic', N'laza', N'laza')
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[Class]  WITH CHECK ADD  CONSTRAINT [FK_Class_ClassGroup] FOREIGN KEY([IdClassGroup])
REFERENCES [dbo].[ClassGroup] ([IdClassGroup])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Class] CHECK CONSTRAINT [FK_Class_ClassGroup]
GO
ALTER TABLE [dbo].[Class]  WITH CHECK ADD  CONSTRAINT [FK_Class_Teacher] FOREIGN KEY([IdTeacher])
REFERENCES [dbo].[Teacher] ([IdTeacher])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Class] CHECK CONSTRAINT [FK_Class_Teacher]
GO
ALTER TABLE [dbo].[Mark]  WITH CHECK ADD  CONSTRAINT [FK_Mark_Class] FOREIGN KEY([IdClass])
REFERENCES [dbo].[Class] ([IdClass])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Mark] CHECK CONSTRAINT [FK_Mark_Class]
GO
ALTER TABLE [dbo].[Mark]  WITH CHECK ADD  CONSTRAINT [FK_Mark_Student] FOREIGN KEY([IdStudent])
REFERENCES [dbo].[Student] ([IdStudent])
GO
ALTER TABLE [dbo].[Mark] CHECK CONSTRAINT [FK_Mark_Student]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_ClassGroup] FOREIGN KEY([IdClassGroup])
REFERENCES [dbo].[ClassGroup] ([IdClassGroup])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_ClassGroup]
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_ClassGroup] FOREIGN KEY([IdClassHomeroomTeacher])
REFERENCES [dbo].[ClassGroup] ([IdClassGroup])
GO
ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_ClassGroup]
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_Subject] FOREIGN KEY([IdSubject])
REFERENCES [dbo].[Subject] ([IdSubject])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_Subject]
GO
USE [master]
GO
ALTER DATABASE [SchoolDB] SET  READ_WRITE 
GO
