USE PruebaMVC

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Sebastian Herrera
-- Create date: 04/02/2022
-- Description:	Stored procedure to search a person in tblpersona
-- =============================================
CREATE PROCEDURE SpconsultaPersona 
	
	@nombre Varchar(20)
AS
BEGIN
	
	SELECT Nombre, Apellido, Idciudad,Telefono, Edad, Activo 
	FROM Tblpersona
	WHERE Nombre LIKE '%' + @nombre + '%'
END
GO
