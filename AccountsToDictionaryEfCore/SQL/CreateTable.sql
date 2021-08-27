USE [ForumExample]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 8/27/2021 4:04:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AccountName] [nvarchar](max) NULL,
	[Location] [nvarchar](max) NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Account] ON 
GO
INSERT [dbo].[Account] ([Id], [AccountName], [Location]) VALUES (1, N'A100', N'USA')
GO
INSERT [dbo].[Account] ([Id], [AccountName], [Location]) VALUES (2, N'A010', N'Germany')
GO
INSERT [dbo].[Account] ([Id], [AccountName], [Location]) VALUES (3, N'B001', N'Inda')
GO
INSERT [dbo].[Account] ([Id], [AccountName], [Location]) VALUES (4, N'B100', N'Brazil')
GO
INSERT [dbo].[Account] ([Id], [AccountName], [Location]) VALUES (5, N'B102', N'USA')
GO
INSERT [dbo].[Account] ([Id], [AccountName], [Location]) VALUES (6, N'C100', N'Canada')
GO
INSERT [dbo].[Account] ([Id], [AccountName], [Location]) VALUES (7, N'A300', N'Japan')
GO
INSERT [dbo].[Account] ([Id], [AccountName], [Location]) VALUES (8, N'B010', N'USA')
GO
SET IDENTITY_INSERT [dbo].[Account] OFF
GO
