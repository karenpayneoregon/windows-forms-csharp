USE [ForumExample]
GO
/****** Object:  Table [dbo].[Pet]    Script Date: 12/11/2021 2:34:07 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pet](
	[MakeId] [int] IDENTITY(1,1) NOT NULL,
	[PetName] [nvarchar](max) NULL,
	[Color] [nvarchar](max) NULL,
 CONSTRAINT [PK_Pet] PRIMARY KEY CLUSTERED 
(
	[MakeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Pet] ON 
GO
INSERT [dbo].[Pet] ([MakeId], [PetName], [Color]) VALUES (1, N'Zippy', N'Black')
GO
INSERT [dbo].[Pet] ([MakeId], [PetName], [Color]) VALUES (2, N'Rusty', N'Rust')
GO
INSERT [dbo].[Pet] ([MakeId], [PetName], [Color]) VALUES (3, N'Mel', N'Black')
GO
INSERT [dbo].[Pet] ([MakeId], [PetName], [Color]) VALUES (4, N'Clunker', N'Yellow')
GO
INSERT [dbo].[Pet] ([MakeId], [PetName], [Color]) VALUES (5, N'Bimmer', N'Black')
GO
INSERT [dbo].[Pet] ([MakeId], [PetName], [Color]) VALUES (6, N'Hank', N'Green')
GO
INSERT [dbo].[Pet] ([MakeId], [PetName], [Color]) VALUES (7, N'Pinky', N'Pink')
GO
INSERT [dbo].[Pet] ([MakeId], [PetName], [Color]) VALUES (8, N'Pete', N'Black')
GO
INSERT [dbo].[Pet] ([MakeId], [PetName], [Color]) VALUES (9, N'Browie', N'Brown')
GO
SET IDENTITY_INSERT [dbo].[Pet] OFF
GO
