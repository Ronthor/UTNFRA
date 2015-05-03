using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTN.SistemaAlumnos.Entidades
{
    /// <summary>
    /// Código de Ejemplo simplemente para que se tome como punto de partida 
    /// al escribir las entidades que se persistirán en la BBDD utilizando el UTN Framework
    /// ultimas materias en la unt -fra.
    /// </summary>

    public class AcademicoPorParcial
    {
        public int Id { get; set; }
        public string IdLegajo { get; set; }
        public int IdCarrera { get; set; }
        public int IdMateria { get; set; }
        public DateTime Fecha { get; set; }
        public int AnioLectivo { get; set; }
        public int Cuatrimmestre { get; set; }
        public int PrimerParcial { get; set; }
        public int SegundoParcial { get; set; }
        public int PrimerRecuTipo { get; set; }
        public int NotaPrimerRecup { get; set; }
        public int SegundoRecuTipo { get; set; }
        public int NotaSegundoRecup { get; set; }
        public int TercerRecuTipo { get; set; }
        public int NotaTercerRecup { get; set; }
        public char Estado { get; set; }

        public AcademicoPorParcial(int id, string legajo, int carrera, int materia, DateTime fecha, int aniolectivo, int cuatrimestre, int primerparcial, int segundoparcial, int PrimerRecuTipo, int NotaPrimerRecup, int SegundoRecuTipo, int NotaSegundoRecup, int TercerRecuTipo, int NotaTercerRecup, char Estado)
        {
            this.Id = id;
            this.IdLegajo = IdLegajo;
            this.IdMateria = IdMateria;
            this.IdCarrera = IdCarrera;
            this.Fecha = fecha;
            this.AnioLectivo = aniolectivo;
            this.Cuatrimmestre = cuatrimestre;
            this.PrimerParcial = primerparcial;
            this.SegundoParcial = segundoparcial;
            this.PrimerRecuTipo = PrimerRecuTipo;
            this.NotaPrimerRecup = NotaPrimerRecup;
            this.SegundoRecuTipo = SegundoRecuTipo;
            this.NotaSegundoRecup = NotaSegundoRecup;
            this.TercerRecuTipo = TercerRecuTipo;
            this.NotaTercerRecup = NotaTercerRecup;
            this.Estado = Estado;
        }
    }
}
