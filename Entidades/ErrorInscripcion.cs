using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTN.SistemaAlumnos.Entidades
{
      public class ErrorInscripcion
      {
            private string _nombre;
            private string _apellido;
            private string _legajo;
            private string _descripcionMateria;

            public ErrorInscripcion (string nombre, string apellido, string legajo, string descripcionMateria)
            {
                  this._nombre = nombre;
                  this._apellido = apellido;
                  this._legajo = legajo;
                  this._descripcionMateria = descripcionMateria;
            }
      }
}
