-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE spx_reconcile 
	-- Add the parameters for the stored procedure here
	@namabank AS VARCHAR(max)	
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM dbo.DEPOSIT d LEFT JOIN dbo.PAYMENT p ON d.Id_Bank = p.Id_Bank WHERE d.Nama_bank = @namabank and p.Nama_bank = @namabank 
END
