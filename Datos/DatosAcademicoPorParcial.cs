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
    public class DatosAcademicoPorParcial
    {
        public static List<AcademicoPorParcial> traerTodas()
        {
            string comando = "select * from Correlatividades_Rendir;";
            List<AcademicoPorParcial> parciales = new List<AcademicoPorParcial>();
            try
            {
                Database _db = DatabaseFactory.CreateDataBase();
                DataTable tabla = _db.ExecuteDataTable(CommandType.Text, comando);
                foreach (DataRow fila in tabla.Rows)
                {
                    parciales.Add(new AcademicoPorParcial((int)fila[0],(string)fila[1], (int)fila[2], (int)fila[3], (DateTime)fila[4], (int)fila[5], (int)fila[6],(int)fila[7],(int)fila[8],(int)fila[9],(int)fila[10],(int)fila[11],(int)fila[12], (int)fila[13], (int)fila[14], (char)fila[15]));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return parciales;
        }
    }
}
