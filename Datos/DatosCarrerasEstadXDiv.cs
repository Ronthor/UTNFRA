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
    public class DatosCarrerasEstadXDiv
    {
        static Database _db = DatabaseFactory.CreateDataBase();

        public static DataTable TraerTodas()
        {
            DataTable dt = _db.ExecuteDataTable(CommandType.StoredProcedure, "Carreras_T");
            return dt;
        }
    }
}
