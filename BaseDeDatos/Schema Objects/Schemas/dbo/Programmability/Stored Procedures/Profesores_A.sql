CREATE PROCEDURE [dbo].[Profesores_A]
	@Apellido varchar(50),
	@Nombre varchar(50),
	@FechaNacim smalldatetime = null,
	@domCalle varchar(50),
	@domNro int,
	@domPiso int,
	@domDepto char(4),
	@domCodPostal char(8),
	@domProv int,
	@domLocalid varchar(50),
	@Telefono varchar(50),
	@Mail varchar(50),
	@Estado char(1)
	as

	insert into Profesores 
	(
	Apellido,
	Nombre,
	FechaNacim,
	domCalle,
	domNro,
	domPiso,
	domDepto,
	domCodPostal,
	domProv,
	domLocalid,
	Telefono,
	Mail,
	Estado
    )	

	values (
	@Apellido,
	@Nombre,
	@FechaNacim,
	@domCalle,
	@domNro,
	@domPiso,
	@domDepto,
	@domCodPostal,
	@domProv,
	@domLocalid,
	@Telefono,
	@Mail,
	@Estado
	)
