using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using UTN.SistemaAlumnos.Datos;

namespace UTN.SistemaAlumnos.Negocio
{
    public class OperacionesMaterias
    {
        public static DataTable TraerTodas(int carrera, int cuatrimestre)
        {
            return DatosMateriasEstadXDiv.TraerTodas(carrera, cuatrimestre);
        }
    }
}
