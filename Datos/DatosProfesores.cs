using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UTN.SistemaAlumnos.Entidades;
using System.Data;
using System.Data.SqlClient;
using UTN.Framework.Data;


namespace UTN.SistemaAlumnos.Datos
{
    public class ProfesoresDatos
    {

        // en memo
        public static Database _db = DatabaseFactory.CreateDataBase();



        public DataTable TraerProfesores()
        {
            DataTable ds = new DataTable();

            try
            {
                ds = _db.ExecuteDataTable(CommandType.StoredProcedure, "Profesores_TT");
                return ds;
            }

            catch (Exception)
            {
                throw new Exception("Error al traer Profesores");
            }
        }

        public static void AltaProfesor(EntProfesores profesor)
        {
            try
            {
                _db.ExecuteNonQuery("Profesores_A", new object[] { profesor.Nombre, profesor.Apellido, profesor.DomCalle, profesor.DomNro, profesor.DomPiso, profesor.DomDepto, profesor.Telefono, profesor.Mail, profesor.Estado });

            }
            catch (Exception aux)
            {
                throw new Exception("Error al agregar Profesores\n"+ aux.Message );
            }
        }

        public DataTable ObtenerMayorId()
        {
            DataTable dt = new DataTable();

            try
            {
                dt = _db.ExecuteDataTable(CommandType.StoredProcedure, "Profesores_GiD");
                return dt;
            }

            catch (Exception)
            {
                throw new Exception("Error al obtener ID");
            }
        }
    }
}