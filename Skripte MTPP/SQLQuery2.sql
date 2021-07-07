use TSQL2012;
GO

CREATE or ALTER PROC dbo.SelectKlijenti
as
set lock_timeout 3000
BEGIN TRY
select * from dbo.Klijenti
ORDER BY Naziv
RETURN 0;
END TRY
BEGIN CATCH
RETURN ERROR_NUMBER();
END CATCH


