use TSQL2012;
GO

CREATE OR ALTER PROC dbo.InsertKlijenti
@Naziv nvarchar (40), @Kontakt nvarchar (30), @Grad nvarchar(15), @Zemlja nvarchar(15)
as
set lock_timeout 3000
BEGIN TRY
INSERT INTO dbo.Klijenti (Naziv, Kontakt, Grad, Zemlja)
VALUES (@Naziv, @Kontakt, @Grad, @Zemlja)
RETURN 0;
END TRY
BEGIN CATCH
RETURN ERROR_NUMBER();
END CATCH