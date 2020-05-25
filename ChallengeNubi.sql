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
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password]) VALUES (1, N'Hademar', N'Coleman', N'Ligon@example.com', 'Password01')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password]) VALUES (2, N'Reginalda', N'Fife', N'Burrows865@example.com', 'Password01')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password]) VALUES (3, N'Lovelle', N'Severson', N'GeorgannSamples457@example.com', 'Password01')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password]) VALUES (4, N'Maex', N'Turney', N'Cedric.CSotelo@example.com', 'Password01')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password]) VALUES (5, N'Volbrecht', N'Mattox', N'Loftis@example.com', 'Password01')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password]) VALUES (6, N'Dietlinde', N'Seward', N'Francene.E.Acker869@example.co', 'Password01')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password]) VALUES (7, N'Helmgard', N'Turpin', N'ssmxzviy.qout@example.com', 'Password01')
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password]) VALUES (8, N'Heloise', N'Kelsey', N'Abreu222@example.com', 'Password01')
SET IDENTITY_INSERT [dbo].[User] OFF
