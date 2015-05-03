using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UTN.Framework.Data;
using UTN.SistemaAlumnos.Entidades;
using UTN.Framework.ExceptionManagement;
using System.Data;
using UTN.SistemaAlumnos.Entidades;

namespace UTN.SistemaAlumnos.Datos
{
      class DatosMaterias
      {

        public static List<DatosMaterias> traerIdDescripcion()
        {
            string comando = "select * from Materias;";
            List<DatosMaterias> materia = new List<DatosMaterias>();
            try
            {
                Database _db = DatabaseFactory.CreateDataBase();
                DataTable tabla = _db.ExecuteDataTable(CommandType.Text, comando);
                foreach (DataRow fila in tabla.Rows)
                {
                    //materia.Add(new dtoMateria((int)fila[0],(int)fila[1], (string)fila[2])); TIRA UN ERROR REVISAR
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return materia;
        }
    }
}




