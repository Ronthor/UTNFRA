using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTN.SistemaAlumnos.Entidades
{
    public class dtoInscriptoRendir
    {
        public int idTurnosRendir { get; set; }
        public string idLegajo { get; set; }
        public int idCarrera { get; set; }
        public int idMateria { get; set; }
        public DateTime fechaElegida { get; set; }

        public dtoInscriptoRendir(int turno, string legajo, int car, int mat, DateTime fecha)
        {
            this.idTurnosRendir = turno;
            this.idLegajo = legajo;
            this.idCarrera = car;
            this.idMateria = mat;
            this.fechaElegida = fecha;
        }
    }
}
