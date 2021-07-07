use TSQL2012;
GO

CREATE OR ALTER PROC dbo.UpdateKlijentiInfo
@KlijentId int, @Naziv nvarchar (40) output, @Kontakt nvarchar (30) output, @Grad nvarchar(15) output, @Zemlja nvarchar(15) output
AS
set lock_timeout 3000
BEGIN TRY
SELECT @Naziv = Naziv, @Kontakt = Kontakt, @Grad = Grad, @Zemlja = Zemlja from dbo.Klijenti WHERE KlijentId = @KlijentId
RETURN 0;
END TRY
BEGIN CATCH
 RETURN ERROR_NUMBER();
END CATCH