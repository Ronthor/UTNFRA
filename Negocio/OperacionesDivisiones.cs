using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UTN.SistemaAlumnos.Datos;
using UTN.SistemaAlumnos.Entidades;

namespace UTN.SistemaAlumnos.Negocio
{
    public class OperacionesDivisiones
    {
        /// <summary>
        /// Determina si existe la Division ingresada, teniendo en cuenta los datos ya evaluados.
        /// </summary>
        /// <param name="_anioLectivo"></param>
        /// <param name="_idMateria"></param>
        /// <param name="_turno"></param>
        /// <param name="_division"></param>
        /// <returns></returns>
        public static bool BuscarXDivision(int _anioLectivo, int _idMateria, string _turno, string _division)
        {
            if (DatosDivision.Existe(_anioLectivo, _idMateria, _turno, _division))
            {
                return true;
            }
            return false;
        }
    }
}
