using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTN.SistemaAlumnos.Entidades
{
      public class Materia
      {
            public int idMateria { get; set; }
            public int idCarrera { get; set; }
            public string descripcion { get; set; }

            public Materia ()
            { }

            public Materia (int mat, int car, string desc)
            {
                  this.idMateria = mat;
                  this.idCarrera = car;
                  this.descripcion = desc;

            }
      }
}
