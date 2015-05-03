using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using UTN.SistemaAlumnos.Datos;


namespace UTN.SistemaAlumnos.Negocio
{
    public class OperacionesCarreras
    {
        public static DataTable TraerTodas()
        {
            return DatosCarrerasEstadXDiv.TraerTodas();
        }
    }
}
