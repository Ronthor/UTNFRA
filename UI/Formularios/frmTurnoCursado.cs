using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UTN.SistemaAlumnos.Entidades;

namespace UTN.SistemaAlumnos.UI.Formularios
{
      public partial class frmTurnoCursado : Form
      {
            private Carrera _carrera;

            public frmTurnoCursado ()
            {
                  InitializeComponent ();
                  this.CenterToScreen ();

            }

            private void frmTurnoCursado_Load (object sender, EventArgs e)
            {

                  Llenarcombo<Carrera> (this.cboCarreras, Datos.DatosCarreras.TraerTodas (), "id", "descripcion");
                  this._carrera = (Carrera)cboCarreras.SelectedItem;
                  if (this._carrera != null)
                        Llenarcombo<Materia> (this.cboMaterias, Datos.DatosTurnosCursar.TraerTodas ().Where (unaMateria => unaMateria.idCarrera == this._carrera.Id).ToList (), "idMateria", "descripcion");

            }


            private void Llenarcombo<tipoEntidad> (ComboBox combo, List<tipoEntidad> listadatos, string valueMember, string displayMember)
            {
                  try
                  {
                        combo.DataSource = listadatos.ToList ();
                        combo.ValueMember = valueMember;
                        combo.DisplayMember = displayMember;

                  }
                  catch (Exception ex)
                  {
                        MessageBox.Show (ex.Message);
                  }

            }

            private void cboCarreras_SelectedIndexChanged (object sender, EventArgs e)
            {
                  this._carrera = (Carrera)cboCarreras.SelectedItem;
                  if (this._carrera != null)
                        Llenarcombo<Materia> (this.cboMaterias, Datos.DatosTurnosCursar.TraerTodas ().Where (unaMateria => unaMateria.idCarrera == this._carrera.Id).ToList (), "idMateria", "descripcion");
            }

      }
}
