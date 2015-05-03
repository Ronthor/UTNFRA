using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UTN.SistemaAlumnos.Datos;
using UTN.SistemaAlumnos.Entidades;

namespace UTN.SistemaAlumnos.Negocio
{
      class ValidarInscripcionMaterias
      {
            //genero las 5 listas de caso 003 HECHO
            // en base a inscriptos rendir tengo que buscar coincidencia de Idmateria y Idcarrera(puede haber una o mas),
            //si la encuentro tengo que buscar en nota final que la nota sea mayor o igual a 4 HECHO
            //Generar datos materia (DatosMAterias) genera lista de con el Id y la descripcion HECHO PERO REVISAR EL ERROR

            public List<dtoNotaFinal> _listNotaFinal = new List<dtoNotaFinal>();
            public List<dtoInscriptoRendir> _listInscriptoRendir = new List<dtoInscriptoRendir> ();
            public List<dtoAlumno> _listAlumno = new List<dtoAlumno> ();
            public List<AcademicoPorParcial> _listAcademicoPorParcial = new List<AcademicoPorParcial> ();
            public List<CorrelatividaRendir> _listCorrelatividadRendir = new List<CorrelatividaRendir> ();
            public List<dtoMateria> _listMateria = new List<dtoMateria>();
            public List<ErrorInscripcion> _listError = new List<ErrorInscripcion> ();

            public void ValidarInscripcionFinal (dtoInscriptoRendir unInscripto)
            {
                              
                  foreach (CorrelatividaRendir AuxCorrelatividad in _listCorrelatividadRendir)
                  {
                        if (unInscripto.idCarrera == AuxCorrelatividad.idCarrera && unInscripto.idMateria == AuxCorrelatividad.idMateria)
                        {
                              foreach (dtoNotaFinal AuxNotaFinal in _listNotaFinal)
                              {
                                    if (unInscripto.idCarrera == AuxNotaFinal.idCarrera && unInscripto.idMateria == AuxNotaFinal.idMateria && AuxNotaFinal.nota >= 4)
                                    {

                                    }
                                    else 
                                    {
                                          ErrorDecoincidencia (unInscripto, _listMateria);
                                           
                                    }
                              }
                        }
                  }


            }

            public static void ErrorDecoincidencia (dtoInscriptoRendir unInscripto, List<dtoMateria> _listMateria)
            {       
                  foreach (dtoMateria AuxMateria in _listMateria)
                  {
                        //if (carrera == AuxMateria.idCarrera && materia == AuxMateria.idMateria)
                        //{
                        //      //Falta CRear la instancia de error
                        //}
                  }
            }

      }
}
