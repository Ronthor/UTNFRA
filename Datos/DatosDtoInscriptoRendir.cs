using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UTN.Framework.Data;
using UTN.SistemaAlumnos.Entidades;
using UTN.Framework.ExceptionManagement;
using System.Data;

namespace UTN.SistemaAlumnos.Datos
{
    public static class DatosDtoInscriptoRendir
    {
        public static List<dtoInscriptoRendir> traerTodas()
        {
            string comando = "select I.idLegajo, I.FechaElegida, M.idmateria, M.idcarrera, T.idTurnosRendir from InscriptosRendir as I, TurnosRendir as T, Materias as M where (I.idTurnosRendir=T.IdTurnosRendir) and (T.IdCarrera=M.idcarrera) and (T.IdMateria=M.idmateria);";
            List<dtoInscriptoRendir> inscripciones = new List<dtoInscriptoRendir>();
            try
            {
                Database _db = DatabaseFactory.CreateDataBase();
                DataTable tabla = _db.ExecuteDataTable(CommandType.Text, comando);
                string legajo;
                DateTime fecha;
                int carrera;
                int materia;
                int idTurno;
                foreach(DataRow fila in tabla.Rows)
                {
                    legajo = (string)fila[0];
                    fecha = (DateTime)fila[1];
                    materia = (int)fila[2];
                    carrera = (int)fila[3];
                    idTurno = (int)fila[4];
                    inscripciones.Add(new dtoInscriptoRendir(idTurno,legajo,carrera,materia,fecha));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            
            return inscripciones;
        }
    }
}
