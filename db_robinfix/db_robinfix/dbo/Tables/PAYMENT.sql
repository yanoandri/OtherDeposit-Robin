CREATE TABLE [dbo].[PAYMENT] (
    [Id_Bank]        VARCHAR (MAX) NULL,
    [Nama_bank]      VARCHAR (MAX) NULL,
    [No_Akun]        VARCHAR (MAX) NULL,
    [Nama_Akun]      VARCHAR (MAX) NULL,
    [Voucher_Number] VARCHAR (50)  NULL,
    [Cheque_Number]  VARCHAR (50)  NULL,
    [Void_Cheque]    VARCHAR (50)  NULL,
    [Amount]         BIGINT        NULL,
    [Memo]           VARCHAR (MAX) NULL,
    [Payee]          VARCHAR (MAX) NULL,
    [Date]           SMALLDATETIME NULL
);

