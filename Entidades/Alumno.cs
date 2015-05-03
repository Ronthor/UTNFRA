using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTN.SistemaAlumnos.Entidades
{
    class Alumno
    {
        #region Atributos
        private int _idAlumno;
        private string _idLegajo;
        private string _apellido;
        private string _nombres;
        private int _sexo;
        private int _idCarrera1;
        private int _idCarrera2;
        private DateTime _fechaNacim;
        private Int64 _numeroDocumento;
        private int _tipoDocumento;
        private string _domCalle;
        private string _domNro;
        private string _domPiso;
        private string _domDepto;
        private string _domCodPostal;
        private int _domProv;
        private string _domLocalidad;
        private string _mail;
        private string _telefono;
        private DateTime _fechaIngreso1;
        private DateTime _fechaIngreso2;
        private DateTime _fechaIngreso3;
        private DateTime _fechaEgreso1;
        private DateTime _fechaEgreso2;
        private DateTime _fechaEgreso3;
        private char _estado;
        private DateTime _ultfechaestado;
        private bool _trabaja;
        private int _estadoCivil;
        private string _lugarNacimiento;
        private DateTime _fechaEgresoSecundario;
        #endregion Atributos

        #region Propiedades
        public int IDAlumno
        {
            get { return _idAlumno; }
            set { _idAlumno = value; }
        }

        public string IDLegajo
        {
            get { return _idLegajo; }
            set { _idLegajo = value; }
        }
        
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        
        public string Nombres
        {
            get { return _nombres; }
            set { _nombres = value; }
        }
        
        public int Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        public int IDCarrera1
        {
            get { return _idCarrera1; }
            set { _idCarrera1 = value; }
        }

        public int IDCarrera2
        {
            get { return _idCarrera2; }
            set { _idCarrera2 = value; }
        }
  
        public DateTime FechaNacim
        {
            get { return _fechaNacim; }
            set { _fechaNacim = value; }
        }
        
        public Int64 NumeroDocumento
        {
            get { return _numeroDocumento; }
            set { _numeroDocumento = value; }
        }
        
        public int TipoDocumento
        {
            get { return _tipoDocumento; }
            set { _tipoDocumento = value; }
        }

        public string DomCalle
        {
            get { return _domCalle; }
            set { _domCalle = value; }
        }

        public string DomNro
        {
            get { return _domNro; }
            set { _domNro = value; }
        }

        public string DomPiso
        {
            get { return _domPiso; }
            set { _domPiso = value; }
        }

        public string DomDepto
        {
            get { return _domDepto; }
            set { _domDepto = value; }
        }

        public string DomCodPostal
        {
            get { return _domCodPostal; }
            set { _domCodPostal = value; }
        }

        public int DomProv
        {
            get { return _domProv; }
            set { _domProv = value; }
        }

        public string DomLocalidad
        {
            get { return _domLocalidad; }
            set { _domLocalidad = value; }
        }
        
        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        
        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public DateTime FechaIngreso1
        {
            get { return _fechaIngreso1; }
            set { _fechaIngreso1 = value; }
        }

        public DateTime FechaIngreso2
        {
            get { return _fechaIngreso2; }
            set { _fechaIngreso2 = value; }
        }

        public DateTime FechaIngreso3
        {
            get { return _fechaIngreso3; }
            set { _fechaIngreso3 = value; }
        }

        public DateTime FechaEgreso1
        {
            get { return _fechaEgreso1; }
            set { _fechaEgreso1 = value; }
        }

        public DateTime FechaEgreso2
        {
            get { return _fechaEgreso2; }
            set { _fechaEgreso2 = value; }
        }

        public DateTime FechaEgreso3
        {
            get { return _fechaEgreso3; }
            set { _fechaEgreso3 = value; }
        }

        public char Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public DateTime Ultfechaestado
        {
            get { return _ultfechaestado; }
            set { _ultfechaestado = value; }
        }

        public bool Trabaja
        {
            get { return _trabaja; }
            set { _trabaja = value; }
        }

        public int EstadoCivil
        {
            get { return _estadoCivil; }
            set { _estadoCivil = value; }
        }

        public string LugarNacimiento
        {
            get { return _lugarNacimiento; }
            set { _lugarNacimiento = value; }
        }

        public DateTime FechaEgresoSecundario
        {
            get { return _fechaEgresoSecundario; }
            set { _fechaEgresoSecundario = value; }
        }
        #endregion Propiedades
    }
}
