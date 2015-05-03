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
    public static class DatosDtoAlumno
    {
        public static List<dtoAlumno> traerTodas()
        {
            string comando = "select idlegajo, apellido, nombre, from dbo.Alumnos;";
            List<dtoAlumno> alumnos = new List<dtoAlumno>();
            try
            {
                Database _db = DatabaseFactory.CreateDataBase();
                DataTable tabla = _db.ExecuteDataTable(CommandType.Text, comando);
                string legajo;
                string apellido;
                string nombre;
                foreach(DataRow fila in tabla.Rows)
                {
                    legajo = (string)fila[0];
                    apellido = (string)fila[1];
                    nombre = (string)fila[2];
                    alumnos.Add(new dtoAlumno(legajo,apellido,nombre));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
            
            return alumnos;
        }
    }
}