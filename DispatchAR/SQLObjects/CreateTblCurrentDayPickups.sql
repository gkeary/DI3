USE [Dispatch]
GO

/****** Object:  Table [dbo].[CurrentDayPickups]    Script Date: 09/20/2009 04:13:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CurrentDayPickups](
	[CurrentDayPickupID] [int] IDENTITY(1,1) NOT NULL,
	[CDPDefaultRouteID] [nvarchar](2) NULL,
	[CDPPreviousRouteID] [nvarchar](2) NULL,
	[CDPPickupDate] [datetime] NULL,
	[CDPCustomerID] [nvarchar](5) NULL,
	[CDPDriverName] [nvarchar](30) NULL,
	[CDPDriverMessage] [nvarchar](100) NULL,
	[CDPRouteName] [nvarchar](20) NULL,
	[CDPCustomerName] [nvarchar](30) NULL,
	[CDPComment] [nvarchar](30) NULL,
	[CDPDispatched] [bit] NOT NULL,
	[CDPDispatchTime] [datetime] NULL,
	[CDPNotes] [nvarchar](3) NULL,
	[CDPStation] [nvarchar](50) NULL,
	[CDPDeleted] [bit] NOT NULL,
	[Terminal] [nchar](30) NOT NULL,
 CONSTRAINT [PK_CurrentDayPickups] PRIMARY KEY CLUSTERED 
(
	[CurrentDayPickupID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[CurrentDayPickups] ADD  DEFAULT (0) FOR [CDPDispatched]
GO

ALTER TABLE [dbo].[CurrentDayPickups] ADD  DEFAULT (0) FOR [CDPDeleted]
GO

ALTER TABLE [dbo].[CurrentDayPickups] ADD  CONSTRAINT [DF_CDP_Terminal]  DEFAULT ('NH') FOR [Terminal]
GO

