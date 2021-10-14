USE [master]
GO
/****** Object:  Database [EnrollmentSystem]    Script Date: 10/14/2021 4:58:30 PM ******/
CREATE DATABASE [EnrollmentSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EnrollmentSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\EnrollmentSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EnrollmentSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\EnrollmentSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [EnrollmentSystem] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EnrollmentSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EnrollmentSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EnrollmentSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EnrollmentSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EnrollmentSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EnrollmentSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [EnrollmentSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EnrollmentSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EnrollmentSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EnrollmentSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EnrollmentSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EnrollmentSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EnrollmentSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EnrollmentSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EnrollmentSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EnrollmentSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EnrollmentSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EnrollmentSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EnrollmentSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EnrollmentSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EnrollmentSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EnrollmentSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EnrollmentSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EnrollmentSystem] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EnrollmentSystem] SET  MULTI_USER 
GO
ALTER DATABASE [EnrollmentSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EnrollmentSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EnrollmentSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EnrollmentSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EnrollmentSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EnrollmentSystem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [EnrollmentSystem] SET QUERY_STORE = OFF
GO
USE [EnrollmentSystem]
GO
/****** Object:  Table [dbo].[tblCourses]    Script Date: 10/14/2021 4:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblCourses](
	[courseID] [varchar](20) NOT NULL,
	[coursetName] [nvarchar](100) NOT NULL,
	[subjectID] [varchar](20) NOT NULL,
	[lecturerID] [varchar](20) NOT NULL,
	[startDate] [date] NOT NULL,
	[studentQuantity] [int] NULL,
	[endDate] [date] NOT NULL,
	[feedbackID] [int] NOT NULL,
	[statusID] [varchar](20) NOT NULL,
 CONSTRAINT [PK_tblCourses] PRIMARY KEY CLUSTERED 
(
	[courseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblFeedback]    Script Date: 10/14/2021 4:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblFeedback](
	[feedbackID] [int] NOT NULL,
	[courseID] [varchar](20) NOT NULL,
	[studentID] [varchar](20) NOT NULL,
	[feedbackContent] [ntext] NULL,
 CONSTRAINT [PK_tblFeedback_1] PRIMARY KEY CLUSTERED 
(
	[feedbackID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblGrades]    Script Date: 10/14/2021 4:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblGrades](
	[gradeID] [varchar](20) NOT NULL,
	[courseID] [varchar](20) NOT NULL,
	[studentID] [varchar](20) NOT NULL,
	[progressTest] [float] NULL,
	[midTermTest] [float] NULL,
	[practicalTest] [nchar](10) NULL,
	[finalTest] [float] NULL,
 CONSTRAINT [PK_tblGradeList] PRIMARY KEY CLUSTERED 
(
	[gradeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblRoles]    Script Date: 10/14/2021 4:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRoles](
	[roleID] [varchar](20) NOT NULL,
	[roleName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_tblRoles] PRIMARY KEY CLUSTERED 
(
	[roleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblStatusCourses]    Script Date: 10/14/2021 4:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStatusCourses](
	[statusID] [varchar](20) NOT NULL,
	[statusName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblStatusCourses] PRIMARY KEY CLUSTERED 
(
	[statusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblStatusUsers]    Script Date: 10/14/2021 4:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStatusUsers](
	[statusID] [varchar](20) NOT NULL,
	[statusName] [nvarchar](50) NULL,
 CONSTRAINT [PK_tblStatusUsers] PRIMARY KEY CLUSTERED 
(
	[statusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblSubject]    Script Date: 10/14/2021 4:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblSubject](
	[subjectID] [varchar](20) NOT NULL,
	[subjectName] [nvarchar](100) NULL,
 CONSTRAINT [PK_tblSubject] PRIMARY KEY CLUSTERED 
(
	[subjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUsers]    Script Date: 10/14/2021 4:58:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUsers](
	[userID] [varchar](20) NOT NULL,
	[userName] [nvarchar](100) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[phone] [varchar](20) NULL,
	[email] [varchar](50) NULL,
	[roleID] [varchar](20) NOT NULL,
	[statusID] [varchar](20) NOT NULL,
 CONSTRAINT [PK_tblUsers] PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblRoles] ([roleID], [roleName]) VALUES (N'AD', N'Admin')
INSERT [dbo].[tblRoles] ([roleID], [roleName]) VALUES (N'LC', N'Lecturer')
INSERT [dbo].[tblRoles] ([roleID], [roleName]) VALUES (N'ST', N'Student')
GO
ALTER TABLE [dbo].[tblCourses]  WITH CHECK ADD  CONSTRAINT [FK_tblCourses_tblSubject] FOREIGN KEY([subjectID])
REFERENCES [dbo].[tblSubject] ([subjectID])
GO
ALTER TABLE [dbo].[tblCourses] CHECK CONSTRAINT [FK_tblCourses_tblSubject]
GO
ALTER TABLE [dbo].[tblCourses]  WITH CHECK ADD  CONSTRAINT [FK_tblSubjects_tblStatusSubjects] FOREIGN KEY([statusID])
REFERENCES [dbo].[tblStatusCourses] ([statusID])
GO
ALTER TABLE [dbo].[tblCourses] CHECK CONSTRAINT [FK_tblSubjects_tblStatusSubjects]
GO
ALTER TABLE [dbo].[tblCourses]  WITH CHECK ADD  CONSTRAINT [FK_tblSubjects_tblUsers1] FOREIGN KEY([lecturerID])
REFERENCES [dbo].[tblUsers] ([userID])
GO
ALTER TABLE [dbo].[tblCourses] CHECK CONSTRAINT [FK_tblSubjects_tblUsers1]
GO
ALTER TABLE [dbo].[tblFeedback]  WITH CHECK ADD  CONSTRAINT [FK_tblFeedback_tblCourses] FOREIGN KEY([courseID])
REFERENCES [dbo].[tblCourses] ([courseID])
GO
ALTER TABLE [dbo].[tblFeedback] CHECK CONSTRAINT [FK_tblFeedback_tblCourses]
GO
ALTER TABLE [dbo].[tblFeedback]  WITH CHECK ADD  CONSTRAINT [FK_tblFeedback_tblUsers] FOREIGN KEY([studentID])
REFERENCES [dbo].[tblUsers] ([userID])
GO
ALTER TABLE [dbo].[tblFeedback] CHECK CONSTRAINT [FK_tblFeedback_tblUsers]
GO
ALTER TABLE [dbo].[tblGrades]  WITH CHECK ADD  CONSTRAINT [FK_tblGrades_tblSubjects] FOREIGN KEY([courseID])
REFERENCES [dbo].[tblCourses] ([courseID])
GO
ALTER TABLE [dbo].[tblGrades] CHECK CONSTRAINT [FK_tblGrades_tblSubjects]
GO
ALTER TABLE [dbo].[tblGrades]  WITH CHECK ADD  CONSTRAINT [FK_tblGrades_tblUsers] FOREIGN KEY([studentID])
REFERENCES [dbo].[tblUsers] ([userID])
GO
ALTER TABLE [dbo].[tblGrades] CHECK CONSTRAINT [FK_tblGrades_tblUsers]
GO
ALTER TABLE [dbo].[tblUsers]  WITH CHECK ADD  CONSTRAINT [FK_tblUsers_tblRoles] FOREIGN KEY([roleID])
REFERENCES [dbo].[tblRoles] ([roleID])
GO
ALTER TABLE [dbo].[tblUsers] CHECK CONSTRAINT [FK_tblUsers_tblRoles]
GO
ALTER TABLE [dbo].[tblUsers]  WITH CHECK ADD  CONSTRAINT [FK_tblUsers_tblStatusUsers] FOREIGN KEY([statusID])
REFERENCES [dbo].[tblStatusUsers] ([statusID])
GO
ALTER TABLE [dbo].[tblUsers] CHECK CONSTRAINT [FK_tblUsers_tblStatusUsers]
GO
USE [master]
GO
ALTER DATABASE [EnrollmentSystem] SET  READ_WRITE 
GO
