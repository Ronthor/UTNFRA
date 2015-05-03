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
    public class DatosDivision
    {
        static Database _db = DatabaseFactory.CreateDataBase();

        //Devuelve True en caso de encontrar la Division, caso contrario devuelve False.
        public static bool Existe(int _anioLectivo, int _idMateria, string _turno, string _division)
        {
        
            string query = "SELECT COUNT(*) FROM TurnosCursar WHERE ((Division=UPPER(@Division) )AND (IdMateria=@IdMateria) AND(Turno=@Turno))";
            DbCommand cmd = _db.GetSqlStringCommand(query);
            _db.AddInParameter(cmd, "Division", DbType.String, _division );
            _db.AddInParameter(cmd,"IdMateria",DbType.Int32 ,_idMateria );
            _db.AddInParameter(cmd,"Turno",DbType.String ,_turno );
           
            int count = Convert .ToInt32( _db.ExecuteScalar(cmd));
            if (count == 0)
                return false;
            else
                return true;



        }
    }
}
