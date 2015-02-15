CREATE TABLE [dbo].[DEPOSIT] (
    [Id_Bank]        VARCHAR (MAX) NULL,
    [Nama_bank]      VARCHAR (MAX) NULL,
    [No_Akun]        VARCHAR (MAX) NULL,
    [Nama_Akun]      VARCHAR (MAX) NULL,
    [Voucher_Number] VARCHAR (50)  NULL,
    [Amount]         BIGINT        NULL,
    [Memo]           VARCHAR (MAX) NULL,
    [Date]           SMALLDATETIME NULL
);

