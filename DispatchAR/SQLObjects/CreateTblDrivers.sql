USE [Dispatch]
GO

/****** Object:  Table [dbo].[DRIVERS]    Script Date: 09/20/2009 04:01:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[DRIVERS](
	[DriverTableID] [int] IDENTITY(1,1) NOT NULL,
	[DriverID] [nvarchar](4) NULL,
	[LastName] [nvarchar](20) NULL,
	[FirstName] [nvarchar](20) NULL,
	[MiddleInitial] [nvarchar](1) NULL,
	[DriverSyncID] [nvarchar](50) NULL,
	[DriverCreatedBy] [nvarchar](50) NULL,
	[DriverCreatedTime] [datetime] NULL,
	[DriverEditedBy] [nvarchar](50) NULL,
	[DriverEditedTime] [datetime] NULL,
	[DriverSent] [bit] NULL,
	[DriverSentTime] [datetime] NULL,
	[DriverSendConfirmed] [bit] NULL,
	[DriverReceivedTime] [datetime] NULL,
	[Terminal] [nchar](30) NOT NULL,
 CONSTRAINT [PK_DRIVER] PRIMARY KEY CLUSTERED 
(
	[DriverTableID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[DRIVERS] ADD  CONSTRAINT [DF_Driver_Terminal]  DEFAULT ('NH') FOR [Terminal]
GO

