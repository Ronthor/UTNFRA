using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTN.SistemaAlumnos.Entidades
{
    public class CorrelatividaRendir
    {
        public int id { get; set; }
        public int idCarrera { get; set; }
        public int idMateria { get; set; }
        public int Rendir { get; set; }

        public CorrelatividaRendir(int id, int carrera, int materia, int rendir)
        {
            this.id = id;
            this.idCarrera = carrera;
            this.idMateria = materia;
            this.Rendir = rendir;

        }
    }
}
