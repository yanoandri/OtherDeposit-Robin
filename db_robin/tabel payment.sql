USE [db_robin]
GO

/****** Object:  Table [dbo].[PAYMENT]    Script Date: 11/20/2014 8:15:43 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[PAYMENT](
	[Id_Bank] [varchar](max) NULL,
	[Nama_bank] [varchar](max) NULL,
	[No_Akun] [varchar](max) NULL,
	[Nama_Akun] [varchar](max) NULL,
	[Voucher_Number] [varchar](50) NULL,
	[Cheque_Number] [varchar](50) NULL,
	[Void_Cheque] [varchar](50) NULL,
	[Amount] [bigint] NULL,
	[Memo] [varchar](max) NULL,
	[Payee] [varchar](max) NULL,
	[Date] [smalldatetime] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


