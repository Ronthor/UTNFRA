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
    public static class DatosDtoNotaFinal
    {
        public static List<dtoNotaFinal> traerTodas()
        {
            string comando = "select F.idlegajo, F.nota, M.idcarrera, M.idmateria, M.descripcion from dbo.AcademicoPorExamen as F, dbo.Actas as A, dbo.Materias as M where (F.idfolio=A.idfolio) and (F.idtomo=A.idtomo) and (A.idcarrera=M.idcarrera) and (A.idmateria=M.idcarrera);";
            List<dtoNotaFinal> finales = new List<dtoNotaFinal>();
            try
            {
                Database _db = DatabaseFactory.CreateDataBase();
                DataTable tabla = _db.ExecuteDataTable(CommandType.Text, comando);
                string legajo;
                int nota;
                int carrera;
                int materia;
                string descripcion;
                foreach(DataRow fila in tabla.Rows)
                {
                    legajo = (string)fila[0];
                    nota = (int)fila[1];
                    carrera = (int)fila[2];
                    materia = (int)fila[3];
                    descripcion = (string)fila[4];
                    finales.Add(new dtoNotaFinal(legajo,nota,carrera,materia,descripcion));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            
            return finales;
        }
    }
}
