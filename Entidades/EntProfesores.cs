using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTN.SistemaAlumnos.Entidades
{
   public class EntProfesores
    {
        public Int64 Id { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacim { get; set; }
        public string DomCalle { get; set; }
        public int DomNro { get; set; }
        public int DomPiso { get; set; }
        public char DomDepto { get; set; }
        public char DomCodPostal { get; set; }
        public int DomProv { get; set; }
        public string DomLocalid { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public char Estado { get; set; }

        public EntProfesores() { }

        public EntProfesores(Int64 id,string apellido, string nombre, string domcalle, int domnro, int dompiso, char domdepto, int domprov, string telefono, string mail, char estado)
            :this()
        {
            this.Id = id;
            this.Apellido = apellido;
            this.Nombre = nombre;
            //this.FechaNacim = fechanacim;
            this.DomCalle = domcalle;
            this.DomNro = domnro;
            this.DomPiso = dompiso;
            this.DomDepto = domdepto;
            //this.DomCodPostal = domcodpostal;
            //this.DomProv = domprov;
            //this.DomLocalid = domlocalid;
            this.Telefono = telefono;
            this.Mail = mail;
            this.Estado = estado;
        }



    }
}
