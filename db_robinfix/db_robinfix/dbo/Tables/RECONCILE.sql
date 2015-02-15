CREATE TABLE [dbo].[RECONCILE] (
    [Id_Bank]     VARCHAR (MAX) NULL,
    [Nama_bank]   VARCHAR (MAX) NULL,
    [Deskripsi]   VARCHAR (MAX) NULL,
    [Currency]    VARCHAR (MAX) NULL,
    [New_Balance] BIGINT        NULL,
    [Rate]        BIGINT        NULL,
    [Amount]      BIGINT        NULL,
    [Date]        SMALLDATETIME NULL
);

