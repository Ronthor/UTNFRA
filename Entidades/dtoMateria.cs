using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTN.SistemaAlumnos.Entidades
{
      public class dtoMateria
      {
            public int idMateria { get; set; }
            public int idCarrera { get; set; }
            public string descripcionMateria { get; set; }

            public dtoMateria (int materia, int carrera, string descripcion)
            {
                  this.idMateria = materia;
                  this.idCarrera=carrera;
                  this.descripcionMateria = descripcion;
            }
      }
}
