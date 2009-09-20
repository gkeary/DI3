USE [Dispatch]
GO

/****** Object:  Table [dbo].[CUSTOMERS]    Script Date: 09/20/2009 03:59:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[CUSTOMERS](
	[CustomerID] [nvarchar](10) NOT NULL,
	[CustomerName] [nvarchar](30) NULL,
	[Address1] [nvarchar](30) NULL,
	[Address2] [nvarchar](30) NULL,
	[City] [nvarchar](30) NULL,
	[State] [nvarchar](2) NULL,
	[Phone] [nvarchar](13) NULL,
	[Contact] [nvarchar](30) NULL,
	[ClosingTime] [nvarchar](5) NULL,
	[Comment] [nvarchar](30) NULL,
	[DefaultRouteID] [nvarchar](2) NULL,
	[CustomerSyncID] [nvarchar](50) NULL,
	[CustomerCreatedBy] [nvarchar](50) NULL,
	[CustomerCreatedTime] [datetime] NULL,
	[CustomerEditedBy] [nvarchar](50) NULL,
	[CustomerEditedTime] [datetime] NULL,
	[CustomerSent] [bit] NULL,
	[CustomerSentTime] [datetime] NULL,
	[CustomerSendConfirmed] [bit] NULL,
	[CustomerReceivedTime] [datetime] NULL,
	[Terminal] [nchar](30) NOT NULL,
	[InfoString] [nchar](255) NULL,
 CONSTRAINT [PK_CUSTOMER] PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[CUSTOMERS] ADD  CONSTRAINT [DF_CUSTOMER_Terminal]  DEFAULT ('NH') FOR [Terminal]
GO

