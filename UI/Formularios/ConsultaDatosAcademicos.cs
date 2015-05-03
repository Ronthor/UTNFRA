using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UTN.SistemaAlumnos.UI.Formularios;
using UTN.SistemaAlumnos.Datos;


namespace UTN.SistemaAlumnos.UI
{
    public partial class ConsultaDatosAcademicos : Form
    {
        public ConsultaDatosAcademicos()
        {
            InitializeComponent();
        }

        private void ConsultaDatosAcademicos_Load (object sender, EventArgs e)
        {
              btnVer.Enabled = false;
              rbtLegajo.Checked = true;
        }
          
        private void txtBusqueda_KeyPress (object sender, KeyPressEventArgs e)
        {
              if (rbtLegajo.Checked && !char.IsDigit(e.KeyChar)) //revisar lógica
              { e.Handled = true; }
        }

        private void btnBuscar_Click (object sender, EventArgs e)
        {

              // Si existen resultados previos en el DGV, borrarlos.
              if (dgvResultadosBusqueda.Rows.Count > 0)
                    dgvResultadosBusqueda.Rows.Clear();

              if (txtBusqueda.Text.Length > 0)
              {
                    if (rbtLegajo.Checked)
                    { 
                          // Traer datos por legajo.
                    }
                    else
                    {
                          // Traer datos por apellido.
                    }

                    // Si devolvió resultados, habilitar el botón "Ver".

              }
              else
              {
                    MessageBox.Show ("Debe ingresar el legajo o el apellido en base al criterio de búsqueda.", "Campo de búsqueda vacío", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
        }

        private void btnVolver_Click (object sender, EventArgs e)
        {
              this.Close();
        }

        private void btnVer_Click (object sender, EventArgs e)
        {
            
              /*
               * - Si el resultado es único, seleccionar el primero automáticamente
               * - Si hay múltiples resultados, el usuario debe elegir.
               * 
               * - Independientemente del caso, al momento de hacer click sobre "Ver",
               *   pasar el parámetro legajo desde el DGV.
               */  
              
              //  AntecedentesAcademicos aa = new AntecedentesAcademicos(legajo);
        }

    }
}
