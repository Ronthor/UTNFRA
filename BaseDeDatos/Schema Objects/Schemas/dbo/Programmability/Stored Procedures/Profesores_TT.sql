CREATE PROCEDURE Profesores_TT
AS

BEGIN
	SELECT  idProfesor, 
			Apellido, 
			Nombre, 
			isnull(FechaNacim, '19000101')  as 'FechaNacim', 
			isnull(domCalle, '')			as 'domCalle',
			isnull(domNro, '')				as 'domNro', 
			isnull(domPiso, '')				as 'domPiso',
			isnull(domDepto,'')				as 'domDepto',
			isnull(domCodPostal,'')			as 'domCodPostal',
			isnull(domProv,'')				as 'domProv',
			isnull(domLocalid ,'')			as 'domLocalid',
			isnull(Telefono,'')				as 'Telefono',
			isnull(Mail,'') 				as 'Mail',
			isnull(estado,'')				as 'estado'
	FROM profesores
END