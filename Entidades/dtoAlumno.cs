using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTN.SistemaAlumnos.Entidades
{
    public class dtoAlumno
    {
        public string idLegajo { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        
          public dtoAlumno (string idlegajo, string apellido, string nombre)
        {
            this.idLegajo=idLegajo;
            this.apellido=apellido;
            this.nombre=nombre;
        }
    }
}
