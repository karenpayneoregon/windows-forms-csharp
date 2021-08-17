/****** Create NorthWind2020 database prior to running this script ******/

USE [NorthWind2020]
GO

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
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 
GO
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [ContactTypeIdentifier], [TitleOfCourtesy], [BirthDate], [HireDate], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [HomePhone], [Extension], [Notes], [ReportsTo]) VALUES (1, N'Davolio', N'Nancy', 12, N'Ms.', CAST(N'1968-12-08T00:00:00.000' AS DateTime), CAST(N'1992-05-01T00:00:00.000' AS DateTime), N'507 - 20th Ave. E.
Apt. 2A', N'Seattle', N'WA', N'98122', 20, N'(206) 555-9857', N'5467', N'Education includes a BA in psychology from Colorado State University.  She also completed "The Art of the Cold Call."  Nancy is a member of Toastmasters International.', 2)
GO
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [ContactTypeIdentifier], [TitleOfCourtesy], [BirthDate], [HireDate], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [HomePhone], [Extension], [Notes], [ReportsTo]) VALUES (2, N'Fuller', N'Andrew', 13, N'Dr.', CAST(N'1952-02-19T00:00:00.000' AS DateTime), CAST(N'1992-08-14T00:00:00.000' AS DateTime), N'908 W. Capital Way', N'Tacoma', N'WA', N'98401', 20, N'(206) 555-9482', N'3457', N'Andrew received his BTS commercial and a Ph.D. in international marketing from the University of Dallas.  He is fluent in French and Italian and reads German.  He joined the company as a sales representative, was promoted to sales manager and was then named vice president of sales.  Andrew is a member of the Sales Management Roundtable, the Seattle Chamber of Commerce, and the Pacific Rim Importers Association.', NULL)
GO
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [ContactTypeIdentifier], [TitleOfCourtesy], [BirthDate], [HireDate], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [HomePhone], [Extension], [Notes], [ReportsTo]) VALUES (3, N'Leverling', N'Janet', 12, N'Ms.', CAST(N'1963-08-30T00:00:00.000' AS DateTime), CAST(N'1992-04-01T00:00:00.000' AS DateTime), N'722 Moss Bay Blvd.', N'Kirkland', N'WA', N'98033', 20, N'(206) 555-3412', N'3355', N'Janet has a BS degree in chemistry from Boston College).  She has also completed a certificate program in food retailing management.  Janet was hired as a sales associate and was promoted to sales representative.', 2)
GO
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [ContactTypeIdentifier], [TitleOfCourtesy], [BirthDate], [HireDate], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [HomePhone], [Extension], [Notes], [ReportsTo]) VALUES (4, N'Peacock', N'Margaret', 12, N'Mrs.', CAST(N'1958-09-19T00:00:00.000' AS DateTime), CAST(N'1993-05-03T00:00:00.000' AS DateTime), N'4110 Old Redmond Rd.', N'Redmond', N'WA', N'98052', 20, N'(206) 555-8122', N'5176', N'Margaret holds a BA in English literature from Concordia College and an MA from the American Institute of Culinary Arts. She was temporarily assigned to the London office before returning to her permanent post in Seattle.', 2)
GO
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [ContactTypeIdentifier], [TitleOfCourtesy], [BirthDate], [HireDate], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [HomePhone], [Extension], [Notes], [ReportsTo]) VALUES (5, N'Buchanan', N'Steven', 11, N'Mr.', CAST(N'1955-03-04T00:00:00.000' AS DateTime), CAST(N'1993-10-17T00:00:00.000' AS DateTime), N'14 Garrett Hill', N'London', NULL, N'SW1 8JR', 19, N'(71) 555-4848', N'3453', N'Steven Buchanan graduated from St. Andrews University, Scotland, with a BSC degree.  Upon joining the company as a sales representative, he spent 6 months in an orientation program at the Seattle office and then returned to his permanent post in London, where he was promoted to sales manager.  Mr. Buchanan has completed the courses "Successful Telemarketing" and "International Sales Management."  He is fluent in French.', 2)
GO
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [ContactTypeIdentifier], [TitleOfCourtesy], [BirthDate], [HireDate], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [HomePhone], [Extension], [Notes], [ReportsTo]) VALUES (6, N'Suyama', N'Michael', 12, N'Mr.', CAST(N'1963-07-02T00:00:00.000' AS DateTime), CAST(N'1993-10-17T00:00:00.000' AS DateTime), N'Coventry House
Miner Rd.', N'London', NULL, N'EC2 7JR', 19, N'(71) 555-7773', N'428', N'Michael is a graduate of Sussex University (MA, economics) and the University of California at Los Angeles (MBA, marketing).  He has also taken the courses "Multi-Cultural Selling" and "Time Management for the Sales Professional."  He is fluent in Japanese and can read and write French, Portuguese, and Spanish.', 5)
GO
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [ContactTypeIdentifier], [TitleOfCourtesy], [BirthDate], [HireDate], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [HomePhone], [Extension], [Notes], [ReportsTo]) VALUES (7, N'King', N'Robert', 12, N'Mr.', CAST(N'1960-05-29T00:00:00.000' AS DateTime), CAST(N'1994-01-02T00:00:00.000' AS DateTime), N'Edgeham Hollow
Winchester Way', N'London', NULL, N'RG1 9SP', 19, N'(71) 555-5598', N'465', N'Robert King served in the Peace Corps and traveled extensively before completing his degree in English at the University of Michigan and then joining the company.  After completing a course entitled "Selling in Europe," he was transferred to the London office.', 5)
GO
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [ContactTypeIdentifier], [TitleOfCourtesy], [BirthDate], [HireDate], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [HomePhone], [Extension], [Notes], [ReportsTo]) VALUES (8, N'Callahan', N'Laura', 9, N'Ms.', CAST(N'1958-01-09T00:00:00.000' AS DateTime), CAST(N'1994-03-05T00:00:00.000' AS DateTime), N'4726 - 11th Ave. N.E.', N'Seattle', N'WA', N'98105', 20, N'(206) 555-1189', N'2344', N'Laura received a BA in psychology from the University of Washington.  She has also completed a course in business French.  She reads and writes French.', 2)
GO
INSERT [dbo].[Employees] ([EmployeeID], [LastName], [FirstName], [ContactTypeIdentifier], [TitleOfCourtesy], [BirthDate], [HireDate], [Address], [City], [Region], [PostalCode], [CountryIdentifier], [HomePhone], [Extension], [Notes], [ReportsTo]) VALUES (9, N'Dodsworth', N'Anne', 12, N'Ms.', CAST(N'1969-07-02T00:00:00.000' AS DateTime), CAST(N'1994-11-15T00:00:00.000' AS DateTime), N'7 Houndstooth Rd.', N'London', NULL, N'WG2 7LT', 19, N'(71) 555-4444', N'452', N'Anne has a BA degree in English from St. Lawrence College.  She is fluent in French and German.', 5)
GO
SET IDENTITY_INSERT [dbo].[Employees] OFF
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
