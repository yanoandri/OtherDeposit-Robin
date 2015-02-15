USE [db_robin]
GO

/****** Object:  Table [dbo].[RECONCILE]    Script Date: 11/20/2014 8:15:48 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[RECONCILE](
	[Id_Bank] [varchar](max) NULL,
	[Nama_bank] [varchar](max) NULL,
	[Deskripsi] [varchar](max) NULL,
	[Currency] [varchar](max) NULL,
	[New_Balance] [bigint] NULL,
	[Rate] [bigint] NULL,
	[Amount] [bigint] NULL,
	[Date] [smalldatetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


