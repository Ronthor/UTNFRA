CREATE PROCEDURE AcademicoPorParcial_TxIdLegajo (@IdLegajo CHAR(10))
AS
BEGIN

SELECT		APP.idLegajo
			,C.descripcion
			,M.descripcion
			,APP.fecha
			,APP.aniolectivo
			,APP.cuatrimestre
			,ISNULL(APP.primerparcial, '') AS primerparcial
			,ISNULL(APP.segundoparcial, '') AS segundoparcial
			,ISNULL(APP.notaprimerrecup, '') AS notaprimerrecup
			,ISNULL(APP.notasegundorecup, '') AS notasegundorecup
			,ISNULL(APP.notatercerrecup, '') AS notatercerrecup
FROM		AcademicoPorParcial APP
JOIN		Carreras C ON APP.idcarrera = C.idCarrera
JOIN		Materias M ON APP.idmateria = M.idmateria
WHERE		APP.idLegajo = @IdLegajo

END