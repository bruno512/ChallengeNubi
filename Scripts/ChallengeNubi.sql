USE [ChallengeNubi]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Email] [varchar](30) NOT NULL,
	[Password] [varchar](10) NOT NULL
 ) 
GO
SET IDENTITY_INSERT [dbo].[User] ON 
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password]) VALUES (1, N'Martin', N'Palermo', N'martin@example.com', 'Password01')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password]) VALUES (2, N'Juan Roman', N'Riquelme', N'roman@example.com', 'Password01')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password]) VALUES (3, N'Diego', N'Maradona', N'pelusa@example.com', 'Password01')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password]) VALUES (4, N'Carlos', N'Tevez', N'apache@example.com', 'Password01')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password]) VALUES (5, N'Rolando', N'Schiavi', N'elflaco@example.com', 'Password01')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password]) VALUES (6, N'Chicho', N'Serna', N'chicho@example.co', 'Password01')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password]) VALUES (7, N'Hugo', N'Ibarra', N'elnegro@example.com', 'Password01')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password]) VALUES (8, N'Oscar', N'Cordoba', N'cba@example.com', 'Password01')
SET IDENTITY_INSERT [dbo].[User] OFF
