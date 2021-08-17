/****** Create NorthWind2020 database prior to running this script ******/

USE [NorthWind2020]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 8/17/2021 5:51:52 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [nvarchar](20) NOT NULL,
	[FirstName] [nvarchar](10) NOT NULL,
	[ContactTypeIdentifier] [int] NULL,
	[TitleOfCourtesy] [nvarchar](25) NULL,
	[BirthDate] [datetime] NULL,
	[HireDate] [datetime] NULL,
	[Address] [nvarchar](60) NULL,
	[City] [nvarchar](15) NULL,
	[Region] [nvarchar](15) NULL,
	[PostalCode] [nvarchar](10) NULL,
	[CountryIdentifier] [int] NULL,
	[HomePhone] [nvarchar](24) NULL,
	[Extension] [nvarchar](4) NULL,
	[Notes] [nvarchar](max) NULL,
	[ReportsTo] [int] NULL,
	[Active] [bit] NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_ContactType] FOREIGN KEY([ContactTypeIdentifier])
REFERENCES [dbo].[ContactType] ([ContactTypeIdentifier])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_ContactType]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Countries] FOREIGN KEY([CountryIdentifier])
REFERENCES [dbo].[Countries] ([CountryIdentifier])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Countries]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Id' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employees', @level2type=N'COLUMN',@level2name=N'EmployeeID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Last name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employees', @level2type=N'COLUMN',@level2name=N'LastName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'First name' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employees', @level2type=N'COLUMN',@level2name=N'FirstName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Title' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employees', @level2type=N'COLUMN',@level2name=N'TitleOfCourtesy'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Birth date' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employees', @level2type=N'COLUMN',@level2name=N'BirthDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Hiredate' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employees', @level2type=N'COLUMN',@level2name=N'HireDate'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Street' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employees', @level2type=N'COLUMN',@level2name=N'Address'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Home phone' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employees', @level2type=N'COLUMN',@level2name=N'HomePhone'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Manager' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Employees', @level2type=N'COLUMN',@level2name=N'ReportsTo'
GO
