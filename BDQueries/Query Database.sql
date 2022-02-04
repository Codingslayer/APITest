CREATE DATABASE PruebaMVC

CREATE TABLE dbo.Tblpersona(
	ID int IDENTITY(1,1) NOT NULL,
	Nombre varchar (30) NOT NULL,
	Apellido nvarchar(30) NOT NULL,
	IdCiudad int NOT NULL,
	Telefono nchar(20) NULL,
	Edad nchar(4) NOT NULL,
	Activo bit NOT NULL
) ON PRIMARY

CREATE TABLE dbo.Tblciudad(
	ID int IDENTITY(1,1) NOT NULL,
	Nombre varchar (30) NOT NULL) ON [PRIMARY]