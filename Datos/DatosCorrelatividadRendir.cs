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
    public class DatosCorrelatividadRendir
    {
        public static List<CorrelatividaRendir> traerTodas()
        {
            string comando = "select * from Correlatividades_Rendir;";
            List<CorrelatividaRendir> correlatividades = new List<CorrelatividaRendir>();
            try
            {
                Database _db = DatabaseFactory.CreateDataBase();
                DataTable tabla = _db.ExecuteDataTable(CommandType.Text, comando);
                int id;
                int idCarrera;
                int idMateria;
                int Rendir;
                foreach (DataRow fila in tabla.Rows)
                {
                    id = (int)fila[0];
                    idCarrera = (int)fila[1];
                    idMateria = (int)fila[2];
                    Rendir = (int)fila[3];
                    correlatividades.Add(new CorrelatividaRendir(id,idCarrera,idMateria,Rendir));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }


            return correlatividades;
        }
    }
}
