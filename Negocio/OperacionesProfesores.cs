using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UTN.SistemaAlumnos.Entidades;


namespace UTN.SistemaAlumnos.Negocio
{
    class OperacionesProfesores
    {
        public List<EntProfesores> _listProfesores = new List<EntProfesores>();
        

        public void ValidarRegistroProfesores(EntProfesores objecto)
        {
            if (!ReferenceEquals(objecto, null))
            {
                foreach (EntProfesores item in _listProfesores)
                {
                    if (item.Apellido == string.Empty)
                    {
                        //("Complete campos");
                    }
                }
            }
        }
    }
}
