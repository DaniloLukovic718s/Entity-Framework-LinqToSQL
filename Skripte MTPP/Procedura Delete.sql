use TSQL2012;
GO

CREATE OR ALTER PROC dbo.DeleteKlijenti
@KlijentId int
as
set lock_timeout 3000
BEGIN TRY
Delete from dbo.Klijenti where KlijentId = @KlijentId;
RETURN 0;
END TRY
BEGIN CATCH
RETURN ERROR_NUMBER();
END CATCH