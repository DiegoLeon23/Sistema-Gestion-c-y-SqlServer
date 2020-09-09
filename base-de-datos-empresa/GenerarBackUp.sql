USE [master]
GO

/****** Object:  StoredProcedure [dbo].[GenerarBackUp]    Script Date: 10/06/2015 01:41:33 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GenerarBackUp]
AS
DECLARE @NombreArchivo VARCHAR(1000)

SET @NombreArchivo = (SELECT N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\Backup\BDEmpresa_' +
REPLACE(REPLACE(CONVERT(VARCHAR(500), GETDATE(), 120),':','_'), ' ','_') + '.bak');

BACKUP DATABASE [BDEmpresa]
TO DISK = @NombreArchivo
WITH DESCRIPTION = N'Copia de Seguridad para restaurar la base de datos BDEmpresa',
NOFORMAT,
INIT,
NAME = N'BDEmpresa',
SKIP,
NOREWIND,
NOUNLOAD,
STATS = 10,
CHECKSUM;
GO


