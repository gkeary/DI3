USE [Dispatch]
GO

/****** Object:  Table [dbo].[Postings]    Script Date: 09/20/2009 04:02:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Postings](
	[PostingID] [int] IDENTITY(1,1) NOT NULL,
	[DataType] [varchar](50) NULL,
	[key] [int] NULL,
	[DefaultRouteId] [varchar](50) NULL,
	[PreviousRouteID] [varchar](50) NULL,
	[NumberOfPendingUpdates] [int] NULL,
	[Originator] [varchar](50) NULL,
	[IsDragNDrop] [bit] NULL,
 CONSTRAINT [PK_Posting] PRIMARY KEY CLUSTERED 
(
	[PostingID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

