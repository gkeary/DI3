USE [Dispatch]
GO

/****** Object:  Table [dbo].[Routes]    Script Date: 09/20/2009 05:19:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Routes](
	[Route2TableID] [int] IDENTITY(1,1) NOT NULL,
	[RouteID] [nvarchar](2) NULL,
	[RouteName] [nvarchar](20) NULL,
	[DefaultDriverID] [nvarchar](4) NULL,
	[DriverMessage] [nvarchar](100) NULL,
	[Screen] [smallint] NULL,
	[RouteSyncID] [nvarchar](50) NULL,
	[Terminal] [nchar](30) NOT NULL,
 CONSTRAINT [PK_ROUTE2] PRIMARY KEY CLUSTERED 
(
	[Route2TableID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[Routes] ADD  CONSTRAINT [DF_ROUTE2_Terminal]  DEFAULT ('NH') FOR [Terminal]
GO

