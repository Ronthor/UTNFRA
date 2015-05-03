using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTN.SistemaAlumnos.Entidades
{
    public class EntTurnosRendir
    {
        private int _idCarrera;
        private int _idMateria;
        private char _turno;
        private DateTime _fechaPrimerTurno;
        private DateTime _fechaSegundoTurno;

        public EntTurnosRendir() { }

        public EntTurnosRendir(int idCarrera, int idMateria, char turno, DateTime fechaPrimer, DateTime fechaSegundo)
        {
            this.IdCarrera = idCarrera;
            this.IdMateria = idMateria;
            this.Turno = turno;
            this.FechaPrimerTurno = fechaPrimer;
            this.FechaSegundoTurno = fechaSegundo;
        }

        public int IdCarrera
        {
            get { return _idCarrera; }
            set { _idCarrera = value; }
        }

        public int IdMateria
        {
            get { return _idMateria; }
            set { _idMateria = value; }
        }

        public char Turno
        {
            get { return _turno; }
            set { _turno = value; }
        }

        public DateTime FechaPrimerTurno
        {
            get { return _fechaPrimerTurno; }
            set { _fechaPrimerTurno = value; }
        }

        public DateTime FechaSegundoTurno
        {
            get { return _fechaSegundoTurno; }
            set { _fechaSegundoTurno = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("IdCarrera: " + IdCarrera);
            sb.AppendLine(" - IdMateria: " + IdMateria);
            sb.AppendLine(" - Turno: " + Turno.ToString());
            sb.AppendLine(" - FechaPrimerTurno: " + FechaPrimerTurno.ToString());
            sb.AppendLine(" - FechaSegundoTurno: " + FechaSegundoTurno.ToString());
            return sb.ToString();
        }
    }
}
