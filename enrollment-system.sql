USE [master]
GO
/****** Object:  Database [EnrollmentSystem]    Script Date: 11/6/2021 11:03:46 AM ******/
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
ALTER DATABASE [EnrollmentSystem] SET AUTO_CLOSE ON 
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
ALTER DATABASE [EnrollmentSystem] SET  ENABLE_BROKER 
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
/****** Object:  Table [dbo].[Courses]    Script Date: 11/6/2021 11:03:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Courses](
	[courseID] [int] IDENTITY(1,1) NOT NULL,
	[courseName] [nvarchar](max) NOT NULL,
	[subjectID] [int] NOT NULL,
	[lecturerID] [varchar](50) NOT NULL,
	[studentQuantity] [int] NULL,
	[startDate] [date] NOT NULL,
	[endDate] [date] NOT NULL,
	[statusID] [int] NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[courseID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Feedbacks]    Script Date: 11/6/2021 11:03:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Feedbacks](
	[feedbackID] [int] IDENTITY(1,1) NOT NULL,
	[courseID] [int] NOT NULL,
	[studentID] [varchar](50) NOT NULL,
	[feedbackContent] [nvarchar](max) NULL,
 CONSTRAINT [PK_Feedbacks] PRIMARY KEY CLUSTERED 
(
	[feedbackID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Grades]    Script Date: 11/6/2021 11:03:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grades](
	[gradeID] [int] IDENTITY(1,1) NOT NULL,
	[courseID] [int] NOT NULL,
	[studentID] [varchar](50) NOT NULL,
	[progressTest] [float] NULL,
	[midTermTest] [float] NULL,
	[practicalTest] [float] NULL,
	[finalTest] [float] NULL,
 CONSTRAINT [PK_Grades] PRIMARY KEY CLUSTERED 
(
	[gradeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 11/6/2021 11:03:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[roleID] [int] NOT NULL,
	[roleName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[roleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusCourses]    Script Date: 11/6/2021 11:03:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusCourses](
	[statusID] [int] NOT NULL,
	[statusName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_StatusCourses] PRIMARY KEY CLUSTERED 
(
	[statusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusUsers]    Script Date: 11/6/2021 11:03:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusUsers](
	[statusID] [int] NOT NULL,
	[statusName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_StatusUsers] PRIMARY KEY CLUSTERED 
(
	[statusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subject]    Script Date: 11/6/2021 11:03:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subject](
	[subjectID] [int] IDENTITY(1,1) NOT NULL,
	[subjectName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Subject] PRIMARY KEY CLUSTERED 
(
	[subjectID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/6/2021 11:03:47 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[userID] [varchar](50) NOT NULL,
	[userName] [nvarchar](100) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[phone] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[roleID] [int] NOT NULL,
	[statusID] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[userID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Courses] ON 

INSERT [dbo].[Courses] ([courseID], [courseName], [subjectID], [lecturerID], [studentQuantity], [startDate], [endDate], [statusID]) VALUES (1, N'Accounting principles', 1, N'lecturer3', 20, CAST(N'2021-10-01' AS Date), CAST(N'2021-10-31' AS Date), 2)
INSERT [dbo].[Courses] ([courseID], [courseName], [subjectID], [lecturerID], [studentQuantity], [startDate], [endDate], [statusID]) VALUES (2, N'Business Strategy', 1, N'lecturer2', 30, CAST(N'2021-11-19' AS Date), CAST(N'2021-12-11' AS Date), 3)
INSERT [dbo].[Courses] ([courseID], [courseName], [subjectID], [lecturerID], [studentQuantity], [startDate], [endDate], [statusID]) VALUES (3, N'Introduction to programming', 3, N'lecturer2', 10, CAST(N'2021-09-01' AS Date), CAST(N'2021-09-30' AS Date), 2)
INSERT [dbo].[Courses] ([courseID], [courseName], [subjectID], [lecturerID], [studentQuantity], [startDate], [endDate], [statusID]) VALUES (4, N'Software Testing', 3, N'lecturer2', 25, CAST(N'2021-11-03' AS Date), CAST(N'2021-11-30' AS Date), 1)
INSERT [dbo].[Courses] ([courseID], [courseName], [subjectID], [lecturerID], [studentQuantity], [startDate], [endDate], [statusID]) VALUES (5, N'Business Strategy', 1, N'lecturer1', 30, CAST(N'2021-11-03' AS Date), CAST(N'2021-11-30' AS Date), 1)
INSERT [dbo].[Courses] ([courseID], [courseName], [subjectID], [lecturerID], [studentQuantity], [startDate], [endDate], [statusID]) VALUES (6, N'Software Requirement', 3, N'lecturer1', 25, CAST(N'2021-11-11' AS Date), CAST(N'2021-12-10' AS Date), 3)
INSERT [dbo].[Courses] ([courseID], [courseName], [subjectID], [lecturerID], [studentQuantity], [startDate], [endDate], [statusID]) VALUES (7, N'Business Strategy', 1, N'lecturer1', 35, CAST(N'2021-10-31' AS Date), CAST(N'2021-12-11' AS Date), 1)
INSERT [dbo].[Courses] ([courseID], [courseName], [subjectID], [lecturerID], [studentQuantity], [startDate], [endDate], [statusID]) VALUES (8, N'Software Requirements', 7, N'lecturer1', 25, CAST(N'2021-11-07' AS Date), CAST(N'2021-11-30' AS Date), 3)
INSERT [dbo].[Courses] ([courseID], [courseName], [subjectID], [lecturerID], [studentQuantity], [startDate], [endDate], [statusID]) VALUES (9, N'Software Testing', 6, N'lecturer3', 23, CAST(N'2021-11-07' AS Date), CAST(N'2021-11-27' AS Date), 3)
INSERT [dbo].[Courses] ([courseID], [courseName], [subjectID], [lecturerID], [studentQuantity], [startDate], [endDate], [statusID]) VALUES (10, N'Software development project', 9, N'lecturer3', 30, CAST(N'2021-11-12' AS Date), CAST(N'2021-11-20' AS Date), 3)
INSERT [dbo].[Courses] ([courseID], [courseName], [subjectID], [lecturerID], [studentQuantity], [startDate], [endDate], [statusID]) VALUES (11, N'Software Requirements', 6, N'lecturer3', 24, CAST(N'2021-11-17' AS Date), CAST(N'2021-11-20' AS Date), 3)
INSERT [dbo].[Courses] ([courseID], [courseName], [subjectID], [lecturerID], [studentQuantity], [startDate], [endDate], [statusID]) VALUES (12, N'Ethics in IT', 10, N'lecturer3', 20, CAST(N'2021-11-16' AS Date), CAST(N'2021-11-30' AS Date), 3)
INSERT [dbo].[Courses] ([courseID], [courseName], [subjectID], [lecturerID], [studentQuantity], [startDate], [endDate], [statusID]) VALUES (13, N'Probability & statistics', 1, N'lect4', 20, CAST(N'2021-11-16' AS Date), CAST(N'2021-11-27' AS Date), 3)
INSERT [dbo].[Courses] ([courseID], [courseName], [subjectID], [lecturerID], [studentQuantity], [startDate], [endDate], [statusID]) VALUES (14, N'Java Web application development', 3, N'lect5', 5, CAST(N'2021-11-23' AS Date), CAST(N'2021-11-27' AS Date), 3)
SET IDENTITY_INSERT [dbo].[Courses] OFF
GO
SET IDENTITY_INSERT [dbo].[Feedbacks] ON 

INSERT [dbo].[Feedbacks] ([feedbackID], [courseID], [studentID], [feedbackContent]) VALUES (1, 1, N'student1', N'Nice Nice')
INSERT [dbo].[Feedbacks] ([feedbackID], [courseID], [studentID], [feedbackContent]) VALUES (2, 3, N'student2', N'I love it')
INSERT [dbo].[Feedbacks] ([feedbackID], [courseID], [studentID], [feedbackContent]) VALUES (4, 6, N'student1', N'')
INSERT [dbo].[Feedbacks] ([feedbackID], [courseID], [studentID], [feedbackContent]) VALUES (6, 2, N'student1', N'OK')
INSERT [dbo].[Feedbacks] ([feedbackID], [courseID], [studentID], [feedbackContent]) VALUES (9, 14, N'student1', NULL)
INSERT [dbo].[Feedbacks] ([feedbackID], [courseID], [studentID], [feedbackContent]) VALUES (10, 14, N'duongn', NULL)
INSERT [dbo].[Feedbacks] ([feedbackID], [courseID], [studentID], [feedbackContent]) VALUES (11, 14, N'khoala', NULL)
INSERT [dbo].[Feedbacks] ([feedbackID], [courseID], [studentID], [feedbackContent]) VALUES (12, 14, N'khoalb', NULL)
INSERT [dbo].[Feedbacks] ([feedbackID], [courseID], [studentID], [feedbackContent]) VALUES (13, 14, N'student2', NULL)
INSERT [dbo].[Feedbacks] ([feedbackID], [courseID], [studentID], [feedbackContent]) VALUES (14, 13, N'quangnt', NULL)
INSERT [dbo].[Feedbacks] ([feedbackID], [courseID], [studentID], [feedbackContent]) VALUES (15, 12, N'quangnt', NULL)
INSERT [dbo].[Feedbacks] ([feedbackID], [courseID], [studentID], [feedbackContent]) VALUES (16, 11, N'quangnt', NULL)
INSERT [dbo].[Feedbacks] ([feedbackID], [courseID], [studentID], [feedbackContent]) VALUES (17, 10, N'quangnt', NULL)
INSERT [dbo].[Feedbacks] ([feedbackID], [courseID], [studentID], [feedbackContent]) VALUES (18, 9, N'quangnt', NULL)
SET IDENTITY_INSERT [dbo].[Feedbacks] OFF
GO
SET IDENTITY_INSERT [dbo].[Grades] ON 

INSERT [dbo].[Grades] ([gradeID], [courseID], [studentID], [progressTest], [midTermTest], [practicalTest], [finalTest]) VALUES (1, 1, N'student1', 3, 3, 3, 3)
INSERT [dbo].[Grades] ([gradeID], [courseID], [studentID], [progressTest], [midTermTest], [practicalTest], [finalTest]) VALUES (5, 2, N'student1', 7, 8, 9, 7)
INSERT [dbo].[Grades] ([gradeID], [courseID], [studentID], [progressTest], [midTermTest], [practicalTest], [finalTest]) VALUES (13, 6, N'student1', 1, 3, 3, 2)
INSERT [dbo].[Grades] ([gradeID], [courseID], [studentID], [progressTest], [midTermTest], [practicalTest], [finalTest]) VALUES (16, 14, N'student1', NULL, NULL, NULL, NULL)
INSERT [dbo].[Grades] ([gradeID], [courseID], [studentID], [progressTest], [midTermTest], [practicalTest], [finalTest]) VALUES (17, 14, N'duongn', NULL, NULL, NULL, NULL)
INSERT [dbo].[Grades] ([gradeID], [courseID], [studentID], [progressTest], [midTermTest], [practicalTest], [finalTest]) VALUES (18, 14, N'khoala', NULL, NULL, NULL, NULL)
INSERT [dbo].[Grades] ([gradeID], [courseID], [studentID], [progressTest], [midTermTest], [practicalTest], [finalTest]) VALUES (19, 14, N'khoalb', NULL, NULL, NULL, NULL)
INSERT [dbo].[Grades] ([gradeID], [courseID], [studentID], [progressTest], [midTermTest], [practicalTest], [finalTest]) VALUES (20, 14, N'student2', NULL, NULL, NULL, NULL)
INSERT [dbo].[Grades] ([gradeID], [courseID], [studentID], [progressTest], [midTermTest], [practicalTest], [finalTest]) VALUES (21, 13, N'quangnt', NULL, NULL, NULL, NULL)
INSERT [dbo].[Grades] ([gradeID], [courseID], [studentID], [progressTest], [midTermTest], [practicalTest], [finalTest]) VALUES (22, 12, N'quangnt', NULL, NULL, NULL, NULL)
INSERT [dbo].[Grades] ([gradeID], [courseID], [studentID], [progressTest], [midTermTest], [practicalTest], [finalTest]) VALUES (23, 11, N'quangnt', NULL, NULL, NULL, NULL)
INSERT [dbo].[Grades] ([gradeID], [courseID], [studentID], [progressTest], [midTermTest], [practicalTest], [finalTest]) VALUES (24, 10, N'quangnt', NULL, NULL, NULL, NULL)
INSERT [dbo].[Grades] ([gradeID], [courseID], [studentID], [progressTest], [midTermTest], [practicalTest], [finalTest]) VALUES (25, 9, N'quangnt', 6, 6, 5, 6)
SET IDENTITY_INSERT [dbo].[Grades] OFF
GO
INSERT [dbo].[Roles] ([roleID], [roleName]) VALUES (1, N'Admin')
INSERT [dbo].[Roles] ([roleID], [roleName]) VALUES (2, N'Lecturer')
INSERT [dbo].[Roles] ([roleID], [roleName]) VALUES (3, N'Student')
GO
INSERT [dbo].[StatusCourses] ([statusID], [statusName]) VALUES (1, N'Start')
INSERT [dbo].[StatusCourses] ([statusID], [statusName]) VALUES (2, N'End')
INSERT [dbo].[StatusCourses] ([statusID], [statusName]) VALUES (3, N'Waiting')
GO
INSERT [dbo].[StatusUsers] ([statusID], [statusName]) VALUES (1, N'Approve')
INSERT [dbo].[StatusUsers] ([statusID], [statusName]) VALUES (2, N'Ban')
GO
SET IDENTITY_INSERT [dbo].[Subject] ON 

INSERT [dbo].[Subject] ([subjectID], [subjectName]) VALUES (1, N'Accounting')
INSERT [dbo].[Subject] ([subjectID], [subjectName]) VALUES (2, N'Biomedical Engineering')
INSERT [dbo].[Subject] ([subjectID], [subjectName]) VALUES (3, N'Technology')
INSERT [dbo].[Subject] ([subjectID], [subjectName]) VALUES (4, N'Business English')
INSERT [dbo].[Subject] ([subjectID], [subjectName]) VALUES (5, N'Economics')
INSERT [dbo].[Subject] ([subjectID], [subjectName]) VALUES (6, N'Software Testing')
INSERT [dbo].[Subject] ([subjectID], [subjectName]) VALUES (7, N'Software Requirement')
INSERT [dbo].[Subject] ([subjectID], [subjectName]) VALUES (8, N'Basic Cross-Platform Application Programming With .NET')
INSERT [dbo].[Subject] ([subjectID], [subjectName]) VALUES (9, N'Software development project')
INSERT [dbo].[Subject] ([subjectID], [subjectName]) VALUES (10, N'Ethics in IT')
SET IDENTITY_INSERT [dbo].[Subject] OFF
GO
INSERT [dbo].[Users] ([userID], [userName], [password], [phone], [email], [roleID], [statusID]) VALUES (N'admin', N'Admin', N'123', N'000', N'admin@gmail.com', 1, 1)
INSERT [dbo].[Users] ([userID], [userName], [password], [phone], [email], [roleID], [statusID]) VALUES (N'duongn', N'Nguyen Duong', N'123', N'123', N'duongn@gmail.com', 3, 1)
INSERT [dbo].[Users] ([userID], [userName], [password], [phone], [email], [roleID], [statusID]) VALUES (N'khoala', N'Le Anh Khoa', N'123', N'123123', N'khoala@gmail.com', 3, 1)
INSERT [dbo].[Users] ([userID], [userName], [password], [phone], [email], [roleID], [statusID]) VALUES (N'khoalb', N'Le Anh A', N'123', N'123', N'khoalb@gmail.com', 3, 1)
INSERT [dbo].[Users] ([userID], [userName], [password], [phone], [email], [roleID], [statusID]) VALUES (N'lect4', N'TienNV', N'123', N'123', N'tien@gmail.com', 2, 1)
INSERT [dbo].[Users] ([userID], [userName], [password], [phone], [email], [roleID], [statusID]) VALUES (N'lect5', N'LoiND', N'123', N'12123', N'loi@gmail.com', 2, 1)
INSERT [dbo].[Users] ([userID], [userName], [password], [phone], [email], [roleID], [statusID]) VALUES (N'lecturer1', N'VanVTTT', N'123', N'123', N'van@gmail.com', 2, 1)
INSERT [dbo].[Users] ([userID], [userName], [password], [phone], [email], [roleID], [statusID]) VALUES (N'lecturer2', N'KieuTA', N'123', N'000', N'lecturer2@gmail.com', 2, 1)
INSERT [dbo].[Users] ([userID], [userName], [password], [phone], [email], [roleID], [statusID]) VALUES (N'lecturer3', N'Hoang NT', N'123', N'123', N'hoang@gmail.com', 2, 1)
INSERT [dbo].[Users] ([userID], [userName], [password], [phone], [email], [roleID], [statusID]) VALUES (N'quangnt', N'Nguyen Thien Quang', N'2', N'123231', N'quangnt@gmail.com', 3, 1)
INSERT [dbo].[Users] ([userID], [userName], [password], [phone], [email], [roleID], [statusID]) VALUES (N'student1', N'Nguyen Van B', N'1', N'08686190', N'1', 3, 1)
INSERT [dbo].[Users] ([userID], [userName], [password], [phone], [email], [roleID], [statusID]) VALUES (N'student2', N'Nguyen Van A', N'123', N'000', N'student2@gmail.com', 3, 1)
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_StatusCourses] FOREIGN KEY([statusID])
REFERENCES [dbo].[StatusCourses] ([statusID])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_StatusCourses]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Subject] FOREIGN KEY([subjectID])
REFERENCES [dbo].[Subject] ([subjectID])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Subject]
GO
ALTER TABLE [dbo].[Courses]  WITH CHECK ADD  CONSTRAINT [FK_Courses_Users] FOREIGN KEY([lecturerID])
REFERENCES [dbo].[Users] ([userID])
GO
ALTER TABLE [dbo].[Courses] CHECK CONSTRAINT [FK_Courses_Users]
GO
ALTER TABLE [dbo].[Feedbacks]  WITH CHECK ADD  CONSTRAINT [FK_Feedbacks_Courses] FOREIGN KEY([courseID])
REFERENCES [dbo].[Courses] ([courseID])
GO
ALTER TABLE [dbo].[Feedbacks] CHECK CONSTRAINT [FK_Feedbacks_Courses]
GO
ALTER TABLE [dbo].[Feedbacks]  WITH CHECK ADD  CONSTRAINT [FK_Feedbacks_Users] FOREIGN KEY([studentID])
REFERENCES [dbo].[Users] ([userID])
GO
ALTER TABLE [dbo].[Feedbacks] CHECK CONSTRAINT [FK_Feedbacks_Users]
GO
ALTER TABLE [dbo].[Grades]  WITH CHECK ADD  CONSTRAINT [FK_Grades_Courses] FOREIGN KEY([courseID])
REFERENCES [dbo].[Courses] ([courseID])
GO
ALTER TABLE [dbo].[Grades] CHECK CONSTRAINT [FK_Grades_Courses]
GO
ALTER TABLE [dbo].[Grades]  WITH CHECK ADD  CONSTRAINT [FK_Grades_Users] FOREIGN KEY([studentID])
REFERENCES [dbo].[Users] ([userID])
GO
ALTER TABLE [dbo].[Grades] CHECK CONSTRAINT [FK_Grades_Users]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles] FOREIGN KEY([roleID])
REFERENCES [dbo].[Roles] ([roleID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_StatusUsers] FOREIGN KEY([statusID])
REFERENCES [dbo].[StatusUsers] ([statusID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_StatusUsers]
GO
USE [master]
GO
ALTER DATABASE [EnrollmentSystem] SET  READ_WRITE 
GO
