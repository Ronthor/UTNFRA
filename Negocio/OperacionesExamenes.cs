using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UTN.SistemaAlumnos.Datos;
using UTN.SistemaAlumnos.Entidades;

namespace UTN.SistemaAlumnos.Negocio
{
    /// <summary>
    /// Código de Ejemplo simplemente para que se tome como punto de partida 
    /// al escribir Operaciones de Negocio
    /// </summary>
    public class OperacionesExamenes
    {
        public static void VerificarCarrera(Carrera carrera)
        {
            // Verificaciones
            DatosCarreras.Existe(carrera.Id);

            // Proceso

            // Grabación

            // Listo, ahora si ...
        }
    }
}
