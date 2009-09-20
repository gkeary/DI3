USE [Dispatch]
GO

/****** Object:  Table [dbo].[CurrentDayRoutes]    Script Date: 09/20/2009 03:58:27 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CurrentDayRoutes](
	[CurrentDayRouteID] [int] IDENTITY(1,1) NOT NULL,
	[CDRRouteID] [nvarchar](2) NULL,
	[CDRRouteName] [nvarchar](20) NULL,
	[CDRDefaultDriverID] [nvarchar](4) NULL,
	[CDRDriverLastName] [nvarchar](20) NULL,
	[CDRDriverMessage] [nvarchar](100) NULL,
	[CDRStation] [nvarchar](50) NULL,
	[CDRChecked] [bit] NOT NULL,
	[CDRDate] [datetime] NULL,
	[CDRSyncID] [nvarchar](50) NULL,
	[CDRCreatedBy] [nvarchar](50) NULL,
	[CDRCreatedTime] [datetime] NULL,
	[CDREditedBy] [nvarchar](50) NULL,
	[CDREditedTime] [datetime] NULL,
	[CDRSent] [bit] NOT NULL,
	[CDRSentTime] [datetime] NULL,
	[CDRSendConfirmed] [bit] NOT NULL,
	[CDRReceivedTime] [datetime] NULL,
	[Terminal] [nchar](30) NOT NULL,
 CONSTRAINT [PK_CurrentDayRoutes] PRIMARY KEY CLUSTERED 
(
	[CurrentDayRouteID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[CurrentDayRoutes] ADD  CONSTRAINT [DF_CDR_Terminal]  DEFAULT ('NH') FOR [Terminal]
GO

