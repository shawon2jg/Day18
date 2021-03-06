USE [master]
GO
/****** Object:  Database [EmployeeInformationDB]    Script Date: 1/10/2015 9:26:59 PM ******/
CREATE DATABASE [EmployeeInformationDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EmployeeInformationDB', FILENAME = N'E:\FTFL Class Lecture\BITM course\07-Jan-2015\EmployeeInformationApp\EmployeeInformationDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'EmployeeInformationDB_log', FILENAME = N'E:\FTFL Class Lecture\BITM course\07-Jan-2015\EmployeeInformationApp\EmployeeInformationDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [EmployeeInformationDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EmployeeInformationDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EmployeeInformationDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EmployeeInformationDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EmployeeInformationDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EmployeeInformationDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EmployeeInformationDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [EmployeeInformationDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EmployeeInformationDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [EmployeeInformationDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EmployeeInformationDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EmployeeInformationDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EmployeeInformationDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EmployeeInformationDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EmployeeInformationDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EmployeeInformationDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EmployeeInformationDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EmployeeInformationDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EmployeeInformationDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EmployeeInformationDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EmployeeInformationDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EmployeeInformationDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EmployeeInformationDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EmployeeInformationDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EmployeeInformationDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EmployeeInformationDB] SET RECOVERY FULL 
GO
ALTER DATABASE [EmployeeInformationDB] SET  MULTI_USER 
GO
ALTER DATABASE [EmployeeInformationDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EmployeeInformationDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EmployeeInformationDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EmployeeInformationDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [EmployeeInformationDB]
GO
/****** Object:  Table [dbo].[tbl_designation]    Script Date: 1/10/2015 9:26:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_designation](
	[des_id] [int] IDENTITY(1,1) NOT NULL,
	[code] [varchar](15) NOT NULL,
	[title] [varchar](100) NOT NULL,
 CONSTRAINT [PK_tbl_designation] PRIMARY KEY CLUSTERED 
(
	[des_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tbl_employee]    Script Date: 1/10/2015 9:26:59 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tbl_employee](
	[emp_id] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[address] [varchar](200) NOT NULL,
	[des_id] [int] NOT NULL,
 CONSTRAINT [PK_tbl_employee] PRIMARY KEY CLUSTERED 
(
	[emp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_designation] ON 

INSERT [dbo].[tbl_designation] ([des_id], [code], [title]) VALUES (1, N'TE', N'Trainee Engineer')
INSERT [dbo].[tbl_designation] ([des_id], [code], [title]) VALUES (2, N'SE', N'Software Engineer')
INSERT [dbo].[tbl_designation] ([des_id], [code], [title]) VALUES (3, N'PA', N'Programmer Analyst')
INSERT [dbo].[tbl_designation] ([des_id], [code], [title]) VALUES (4, N'SSE', N'Senior Software Engineer')
INSERT [dbo].[tbl_designation] ([des_id], [code], [title]) VALUES (5, N'SA', N'System Analyst')
INSERT [dbo].[tbl_designation] ([des_id], [code], [title]) VALUES (6, N'PL', N'Project Lead')
INSERT [dbo].[tbl_designation] ([des_id], [code], [title]) VALUES (7, N'PM', N'Project Manager')
INSERT [dbo].[tbl_designation] ([des_id], [code], [title]) VALUES (8, N'CTO', N'Chief Technical Officer')
INSERT [dbo].[tbl_designation] ([des_id], [code], [title]) VALUES (9, N'AVP', N'Assistant Vice President')
INSERT [dbo].[tbl_designation] ([des_id], [code], [title]) VALUES (10, N'VP', N'Vice President')
INSERT [dbo].[tbl_designation] ([des_id], [code], [title]) VALUES (11, N'BOD', N'Board Of Directors')
SET IDENTITY_INSERT [dbo].[tbl_designation] OFF
SET IDENTITY_INSERT [dbo].[tbl_employee] ON 

INSERT [dbo].[tbl_employee] ([emp_id], [name], [email], [address], [des_id]) VALUES (1, N'saida alam', N'saidaalam@yahoo.com', N'66/1/B, North Mugdapara, 1st Floor, Basabo, Mugda Thana, Dhaka-1214.', 10)
INSERT [dbo].[tbl_employee] ([emp_id], [name], [email], [address], [des_id]) VALUES (2, N'sabbir ahmed', N'sabbirahmed@yahoo.com', N'66/1/B, North Mugdapara, 1st Floor, Basabo, Mugda Thana, Dhaka-1214.', 9)
INSERT [dbo].[tbl_employee] ([emp_id], [name], [email], [address], [des_id]) VALUES (3, N's m shawon', N'shawon2jg@yahoo.com', N'139/2, North Mugdapara, Modinabag,
Sohel Manjil, 3rd Floor, Basabo, Mugda Thana,
Dhaka-1214', 8)
INSERT [dbo].[tbl_employee] ([emp_id], [name], [email], [address], [des_id]) VALUES (4, N's m sharon', N'sharon.fide@yahoo.com', N'139/2, North Mugdapara, Modinabag,
Sohel Manjil, 3rd Floor, Basabo, Mugda Thana,
Dhaka-1214', 11)
SET IDENTITY_INSERT [dbo].[tbl_employee] OFF
/****** Object:  Index [unique_tbl_designation]    Script Date: 1/10/2015 9:26:59 PM ******/
CREATE UNIQUE NONCLUSTERED INDEX [unique_tbl_designation] ON [dbo].[tbl_designation]
(
	[des_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_employee]  WITH CHECK ADD  CONSTRAINT [FK_tbl_employee_tbl_designation] FOREIGN KEY([des_id])
REFERENCES [dbo].[tbl_designation] ([des_id])
GO
ALTER TABLE [dbo].[tbl_employee] CHECK CONSTRAINT [FK_tbl_employee_tbl_designation]
GO
USE [master]
GO
ALTER DATABASE [EmployeeInformationDB] SET  READ_WRITE 
GO
