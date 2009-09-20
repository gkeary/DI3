USE [Dispatch]
GO

/****** Object:  Table [dbo].[Pickups]    Script Date: 09/20/2009 04:02:00 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Pickups](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[DefaultRouteID] [nvarchar](2) NULL,
	[PickupDate] [datetime] NULL,
	[CustomerID] [nvarchar](5) NULL,
	[DriverName] [nvarchar](30) NULL,
	[RouteName] [nvarchar](20) NULL,
	[CustomerName] [nvarchar](30) NULL,
	[Comment] [nvarchar](30) NULL,
	[Monday] [bit] NULL,
	[Tuesday] [bit] NULL,
	[Wednesday] [bit] NULL,
	[Thursday] [bit] NULL,
	[Friday] [bit] NULL,
	[Dispatched] [bit] NULL,
	[DispatchTime] [datetime] NULL,
	[Notes] [nvarchar](3) NULL,
	[PickupSyncID] [nvarchar](50) NULL,
	[PickupCreatedBy] [nvarchar](50) NULL,
	[PickupCreatedTime] [datetime] NULL,
	[PickupEditedBy] [nvarchar](50) NULL,
	[PickupEditedTime] [datetime] NULL,
	[PickupSent] [bit] NULL,
	[PickupSentTime] [datetime] NULL,
	[PickupSendConfirmed] [bit] NULL,
	[PickupReceivedTime] [datetime] NULL,
	[Terminal] [nchar](30) NOT NULL,
 CONSTRAINT [PK_Pickup] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Pickups] ADD  CONSTRAINT [DF_Pickup_Terminal]  DEFAULT ('NH') FOR [Terminal]
GO

