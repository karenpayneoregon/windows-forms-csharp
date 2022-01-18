USE [master]
GO
/****** Object:  Database [SchoolDB]    Script Date: 1/18/2022 7:37:47 AM ******/
CREATE DATABASE [SchoolDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SchoolDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\SchoolDB.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SchoolDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\SchoolDB_log.ldf' , SIZE = 1792KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
GO
ALTER DATABASE [SchoolDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SchoolDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
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
ALTER DATABASE [SchoolDB] SET AUTO_CLOSE ON 
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
ALTER DATABASE [SchoolDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SchoolDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [SchoolDB] SET QUERY_STORE = OFF
GO
USE [SchoolDB]
GO
/****** Object:  Table [dbo].[Course]    Script Date: 1/18/2022 7:37:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course](
	[CourseId] [int] IDENTITY(1,1) NOT NULL,
	[CourseName] [varchar](50) NULL,
	[Location] [geography] NULL,
	[TeacherId] [int] NULL,
 CONSTRAINT [PK_Course_1] PRIMARY KEY CLUSTERED 
(
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 1/18/2022 7:37:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentID] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [varchar](50) NULL,
	[StandardId] [int] NULL,
	[RowVersion] [timestamp] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentCourse]    Script Date: 1/18/2022 7:37:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentCourse](
	[StudentId] [int] NOT NULL,
	[CourseId] [int] NOT NULL,
 CONSTRAINT [PK_StudentCourse] PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC,
	[CourseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[View_StudentCourse]    Script Date: 1/18/2022 7:37:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[View_StudentCourse]
AS
SELECT     dbo.Student.StudentID, dbo.Student.StudentName, dbo.Course.CourseId, dbo.Course.CourseName
FROM         dbo.Student INNER JOIN
                      dbo.StudentCourse ON dbo.Student.StudentID = dbo.StudentCourse.StudentId INNER JOIN
                      dbo.Course ON dbo.StudentCourse.CourseId = dbo.Course.CourseId

GO
/****** Object:  Table [dbo].[Standard]    Script Date: 1/18/2022 7:37:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Standard](
	[StandardId] [int] IDENTITY(1,1) NOT NULL,
	[StandardName] [varchar](50) NULL,
	[Description] [varchar](50) NULL,
 CONSTRAINT [PK_Standard] PRIMARY KEY CLUSTERED 
(
	[StandardId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentAddress]    Script Date: 1/18/2022 7:37:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentAddress](
	[StudentID] [int] NOT NULL,
	[Address1] [varchar](50) NOT NULL,
	[Address2] [varchar](50) NULL,
	[City] [varchar](50) NOT NULL,
	[State] [varchar](50) NOT NULL,
 CONSTRAINT [PK_StudentAddress] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Teacher]    Script Date: 1/18/2022 7:37:48 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Teacher](
	[TeacherId] [int] IDENTITY(1,1) NOT NULL,
	[TeacherName] [varchar](50) NULL,
	[StandardId] [int] NULL,
	[TeacherType] [int] NULL,
 CONSTRAINT [PK_Teacher_1] PRIMARY KEY CLUSTERED 
(
	[TeacherId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Course] ON 
GO
INSERT [dbo].[Course] ([CourseId], [CourseName], [Location], [TeacherId]) VALUES (1, N'Maths', NULL, 1)
GO
INSERT [dbo].[Course] ([CourseId], [CourseName], [Location], [TeacherId]) VALUES (2, N'Science', NULL, 2)
GO
INSERT [dbo].[Course] ([CourseId], [CourseName], [Location], [TeacherId]) VALUES (3, N'History', NULL, 3)
GO
INSERT [dbo].[Course] ([CourseId], [CourseName], [Location], [TeacherId]) VALUES (4, N'English', NULL, 4)
GO
INSERT [dbo].[Course] ([CourseId], [CourseName], [Location], [TeacherId]) VALUES (5, N'Spanish', NULL, 5)
GO
INSERT [dbo].[Course] ([CourseId], [CourseName], [Location], [TeacherId]) VALUES (6, N'Computer Science', NULL, 6)
GO
SET IDENTITY_INSERT [dbo].[Course] OFF
GO
SET IDENTITY_INSERT [dbo].[Standard] ON 
GO
INSERT [dbo].[Standard] ([StandardId], [StandardName], [Description]) VALUES (1, N'Standard1', N'Standard 1\Grade1')
GO
INSERT [dbo].[Standard] ([StandardId], [StandardName], [Description]) VALUES (2, N'Standard2', N'Grade2')
GO
INSERT [dbo].[Standard] ([StandardId], [StandardName], [Description]) VALUES (3, N'Standard3', N'Grade3')
GO
INSERT [dbo].[Standard] ([StandardId], [StandardName], [Description]) VALUES (4, N'Standard4', N'Grade4')
GO
INSERT [dbo].[Standard] ([StandardId], [StandardName], [Description]) VALUES (5, N'Standard5', N'Grade5')
GO
INSERT [dbo].[Standard] ([StandardId], [StandardName], [Description]) VALUES (6, N'Standard6', N'Grade6')
GO
INSERT [dbo].[Standard] ([StandardId], [StandardName], [Description]) VALUES (7, N'Standard7', N'Grade7')
GO
INSERT [dbo].[Standard] ([StandardId], [StandardName], [Description]) VALUES (8, N'Standard8', N'Grade8')
GO
INSERT [dbo].[Standard] ([StandardId], [StandardName], [Description]) VALUES (9, N'Standard9', N'Grade9')
GO
SET IDENTITY_INSERT [dbo].[Standard] OFF
GO
SET IDENTITY_INSERT [dbo].[Student] ON 
GO
INSERT [dbo].[Student] ([StudentID], [StudentName], [StandardId]) VALUES (1, N'Bill', 2)
GO
INSERT [dbo].[Student] ([StudentID], [StudentName], [StandardId]) VALUES (2, N'Steve', 2)
GO
INSERT [dbo].[Student] ([StudentID], [StudentName], [StandardId]) VALUES (3, N'James', 4)
GO
INSERT [dbo].[Student] ([StudentID], [StudentName], [StandardId]) VALUES (4, N'Tim', 1)
GO
INSERT [dbo].[Student] ([StudentID], [StudentName], [StandardId]) VALUES (5, N'Rama', 3)
GO
INSERT [dbo].[Student] ([StudentID], [StudentName], [StandardId]) VALUES (6, N'Mohan', 5)
GO
INSERT [dbo].[Student] ([StudentID], [StudentName], [StandardId]) VALUES (7, N'Merry', 6)
GO
INSERT [dbo].[Student] ([StudentID], [StudentName], [StandardId]) VALUES (8, N'Kapil', 7)
GO
INSERT [dbo].[Student] ([StudentID], [StudentName], [StandardId]) VALUES (9, N'Imran', 8)
GO
INSERT [dbo].[Student] ([StudentID], [StudentName], [StandardId]) VALUES (10, N'Don', 9)
GO
SET IDENTITY_INSERT [dbo].[Student] OFF
GO
INSERT [dbo].[StudentAddress] ([StudentID], [Address1], [Address2], [City], [State]) VALUES (1, N'Parkview', NULL, N'Seattle', N'Washington ')
GO
INSERT [dbo].[StudentAddress] ([StudentID], [Address1], [Address2], [City], [State]) VALUES (4, N'Sepulveda', N'TSquare', N'Culver', N'California')
GO
SET IDENTITY_INSERT [dbo].[Teacher] ON 
GO
INSERT [dbo].[Teacher] ([TeacherId], [TeacherName], [StandardId], [TeacherType]) VALUES (1, N'Newton', 9, 1)
GO
INSERT [dbo].[Teacher] ([TeacherId], [TeacherName], [StandardId], [TeacherType]) VALUES (2, N'Kalidas', 8, 2)
GO
INSERT [dbo].[Teacher] ([TeacherId], [TeacherName], [StandardId], [TeacherType]) VALUES (3, N'John', 7, 1)
GO
INSERT [dbo].[Teacher] ([TeacherId], [TeacherName], [StandardId], [TeacherType]) VALUES (4, N'James', 3, 3)
GO
INSERT [dbo].[Teacher] ([TeacherId], [TeacherName], [StandardId], [TeacherType]) VALUES (5, N'Ravi', 4, 2)
GO
INSERT [dbo].[Teacher] ([TeacherId], [TeacherName], [StandardId], [TeacherType]) VALUES (6, N'Amir', 5, 1)
GO
INSERT [dbo].[Teacher] ([TeacherId], [TeacherName], [StandardId], [TeacherType]) VALUES (7, N'Bjarne', 6, 2)
GO
INSERT [dbo].[Teacher] ([TeacherId], [TeacherName], [StandardId], [TeacherType]) VALUES (8, N'Tomy', 1, 2)
GO
INSERT [dbo].[Teacher] ([TeacherId], [TeacherName], [StandardId], [TeacherType]) VALUES (9, N'Chris', 2, 1)
GO
INSERT [dbo].[Teacher] ([TeacherId], [TeacherName], [StandardId], [TeacherType]) VALUES (10, N'Brian', 2, 2)
GO
SET IDENTITY_INSERT [dbo].[Teacher] OFF
GO
ALTER TABLE [dbo].[Teacher] ADD  CONSTRAINT [DF_Teacher_StandardId]  DEFAULT ((0)) FOR [StandardId]
GO
ALTER TABLE [dbo].[Course]  WITH NOCHECK ADD  CONSTRAINT [FK_Course_Teacher] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Teacher] ([TeacherId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Course] NOCHECK CONSTRAINT [FK_Course_Teacher]
GO
ALTER TABLE [dbo].[Student]  WITH NOCHECK ADD  CONSTRAINT [FK_Student_Standard] FOREIGN KEY([StandardId])
REFERENCES [dbo].[Standard] ([StandardId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Student] NOCHECK CONSTRAINT [FK_Student_Standard]
GO
ALTER TABLE [dbo].[StudentAddress]  WITH CHECK ADD  CONSTRAINT [FK_StudentAddress_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([StudentID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StudentAddress] CHECK CONSTRAINT [FK_StudentAddress_Student]
GO
ALTER TABLE [dbo].[StudentCourse]  WITH CHECK ADD  CONSTRAINT [FK_StudentCourse_Course] FOREIGN KEY([CourseId])
REFERENCES [dbo].[Course] ([CourseId])
GO
ALTER TABLE [dbo].[StudentCourse] CHECK CONSTRAINT [FK_StudentCourse_Course]
GO
ALTER TABLE [dbo].[StudentCourse]  WITH CHECK ADD  CONSTRAINT [FK_StudentCourse_Student] FOREIGN KEY([StudentId])
REFERENCES [dbo].[Student] ([StudentID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StudentCourse] CHECK CONSTRAINT [FK_StudentCourse_Student]
GO
ALTER TABLE [dbo].[Teacher]  WITH CHECK ADD  CONSTRAINT [FK_Teacher_Standard] FOREIGN KEY([StandardId])
REFERENCES [dbo].[Standard] ([StandardId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Teacher] CHECK CONSTRAINT [FK_Teacher_Standard]
GO
/****** Object:  StoredProcedure [dbo].[GetCoursesByStudentId]    Script Date: 1/18/2022 7:37:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetCoursesByStudentId]
	-- Add the parameters for the stored procedure here
	@StudentId int = null
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
select c.courseid, c.coursename,c.Location, c.TeacherId
from student s left outer join studentcourse sc on sc.studentid = s.studentid left outer join course c on c.courseid = sc.courseid
where s.studentid = @StudentId
END

GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteStudent]    Script Date: 1/18/2022 7:37:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_DeleteStudent]
	-- Add the parameters for the stored procedure here
	@StudentId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    DELETE FROM [dbo].[Student]
	where StudentID = @StudentId

END

GO
/****** Object:  StoredProcedure [dbo].[sp_InsertStudentInfo]    Script Date: 1/18/2022 7:37:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_InsertStudentInfo]
	-- Add the parameters for the stored procedure here
	@StandardId int = null,
	@StudentName varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

     INSERT INTO [SchoolDB].[dbo].[Student]
           ([StudentName]
           ,[StandardId])
     VALUES
           (
           @StudentName,
@StandardId
)
SELECT SCOPE_IDENTITY() AS StudentId

END

GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateStudent]    Script Date: 1/18/2022 7:37:49 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[sp_UpdateStudent]
	-- Add the parameters for the stored procedure here
	@StudentId int,
	@StandardId int = null,
	@StudentName varchar(50)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    Update [SchoolDB].[dbo].[Student] 
	set StudentName = @StudentName,
	StandardId = @StandardId
	where StudentID = @StudentId;

END

GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Student"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 106
               Right = 190
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "StudentCourse"
            Begin Extent = 
               Top = 6
               Left = 228
               Bottom = 91
               Right = 380
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Course"
            Begin Extent = 
               Top = 6
               Left = 418
               Bottom = 121
               Right = 570
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_StudentCourse'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'View_StudentCourse'
GO
USE [master]
GO
ALTER DATABASE [SchoolDB] SET  READ_WRITE 
GO
