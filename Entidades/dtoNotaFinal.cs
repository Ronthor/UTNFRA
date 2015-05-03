using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTN.SistemaAlumnos.Entidades
{
    public class dtoNotaFinal
    {

//        -Obtener todas las notas de los finales
//select F.idlegajo, F.nota, M.idcarrera, M.idmateria, M.descripcion 
//from dbo.AcademicoPorExamen as F, dbo.Actas as A, dbo.Materias as M
//where (F.idfolio=A.idfolio) and (F.idtomo=A.idtomo)
//and (A.idcarrera=M.idcarrera) and (A.idmateria=M.idcarrera);
        public string idLegajo { get; set; }
        public int nota { get; set; }
        public int idMateria { get; set; }
        public int idCarrera { get; set; }
        public string descripcion { get; set; }

        public dtoNotaFinal(string leg, int nota, int materia, int carrera, string descripcion)
        {
            this.idLegajo = leg;
            this.nota = nota;
            this.idMateria = materia;
            this.idCarrera = carrera;
            this.descripcion = descripcion;
        }


    }
}
