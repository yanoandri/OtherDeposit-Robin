USE [db_robin]
GO

/****** Object:  Table [dbo].[BANK]    Script Date: 11/18/2014 11:33:13 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[BANK](
	[Id_Bank] [uniqueidentifier] NOT NULL,
	[Nama_bank] [varchar](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


