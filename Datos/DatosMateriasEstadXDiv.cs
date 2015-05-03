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
    public class DatosMateriasEstadXDiv
    {
        static Database _db = DatabaseFactory.CreateDataBase();

        //Trae todas las materias segun el cuatrimestre y carrera pasadas por parametros.

        public static DataTable TraerTodas(int idCarrera,int idCuatrimestre)
        {
            DbCommand cmd = _db.GetStoredProcCommand("Materias_TXIdCarrerayCuatrimestre");
            _db.AddInParameter(cmd, "@idcarrera",DbType.Int32 ,idCarrera );
            _db.AddInParameter(cmd, "@cuatrimestre",DbType .Int32 ,idCuatrimestre);
            DataTable dt = _db.ExecuteDataTable(cmd);
            return dt;

        }
    }
}
