use TSQL2012;
GO

CREATE OR ALTER PROC dbo.UpdateKlijenti
 @KlijentId int, @Naziv nvarchar (40), @Kontakt nvarchar (30), @Grad nvarchar(15), @Zemlja nvarchar(15)
 as
 set lock_timeout 3000
 BEGIN TRY
 Update dbo.Klijenti set Naziv = @Naziv, Kontakt = @Kontakt, Grad = @Grad, Zemlja = @Zemlja
 where KlijentId = @KlijentId
 RETURN 0;
 END TRY
 BEGIN CATCH
 RETURN ERROR_NUMBER();
 END CATCH