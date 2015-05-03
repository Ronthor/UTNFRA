using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using UTN.Framework.Data;
using UTN.SistemaAlumnos.Entidades;


namespace UTN.SistemaAlumnos.Datos
{
   public  class DatosTurnosCursar
    {
          static Database _db = DatabaseFactory.CreateDataBase ();

          public static List<Materia> TraerTodas ()
          {
                List<Materia>materias = new List<Materia>();
                try
                {
                      using (IDataReader dr = _db.ExecuteReader ("Materias_TT"))
                      {
                            while (dr.Read ())
                            {
                                  materias.Add (new Materia() { idMateria = (int)dr["idMateria"], idCarrera = (int)dr["idCarrera"], descripcion = dr["descripcion"].ToString() });
                            }
                      }
                }
                catch (Exception ex)
                {
                      throw ex;
                }
                return materias;
          }



          public static void Existe (int idCarrera)
          {
                // Verifica si existe una carrera con el Id dado
          }
    }
}
