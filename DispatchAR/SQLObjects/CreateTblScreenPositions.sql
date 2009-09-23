USE [Dispatch]
GO

/****** Object:  Table [dbo].[ScreenPositions]    Script Date: 09/20/2009 04:04:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ScreenPositions](
	[ScreenPositionID] [int] IDENTITY(1,1) NOT NULL,
	[Route] [nvarchar](50) NULL,
	[ScreenNumberInt] [int] NULL,
	[WindowNameStr] [nvarchar](50) NULL,
	[LeftInt] [int] NULL,
	[TopInt] [int] NULL,
	[WidthInt] [int] NULL,
	[HeightInt] [int] NULL,
 CONSTRAINT [PK_ScreenPositions] PRIMARY KEY CLUSTERED 
(
	[ScreenPositionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

