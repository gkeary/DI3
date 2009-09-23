USE [Dispatch]
GO

/****** Object:  Table [dbo].[CurrentDayRoutes]    Script Date: 09/20/2009 04:41:31 ******/
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
	[Terminal] [nchar](30) NOT NULL,
 CONSTRAINT [PK_CurrentDayRoutes] PRIMARY KEY CLUSTERED 
(
	[CurrentDayRouteID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[CurrentDayRoutes] ADD  CONSTRAINT [DF_CDR_Terminal]  DEFAULT ('NH') FOR [Terminal]
GO

