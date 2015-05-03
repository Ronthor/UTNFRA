using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UTN.SistemaAlumnos.UI.Formularios
{
      public partial class frmEstadisticaActasExamenes : Form
      {
            public frmEstadisticaActasExamenes ()
            {
                InitializeComponent ();
                this.rbtUnActa.Checked = true;
                this.txtDesde.Enabled = false;
                this.txtxHasta.Enabled = false;
                
            }

            private void frmEstadisticaActasExamenes_Load(object sender, EventArgs e)
            {

            }

            private void rbtPeriodo_CheckedChanged(object sender, EventArgs e)
            {
                if (this.rbtPeriodo.Checked)
                {
                    this.rbtUnActa.Checked = false;
                    this.txtDesde.Enabled = true;
                    this.txtxHasta.Enabled = true;
                }
                else
                {
                    this.txtDesde.Enabled = false;
                    this.txtxHasta.Enabled = false;
                    this.txtDesde.Text = "";
                    this.txtxHasta.Text = "";
                }
            }

            private void rbtUnActa_CheckedChanged(object sender, EventArgs e)
            {
                if (!this.rbtUnActa.Checked)
                {
                    this.txtActa.Enabled = false;
                    this.txtTomo.Enabled = false;
                    this.txtActa.Text = "";
                    this.txtTomo.Text = "";
                }
                else
                {
                    this.txtActa.Enabled = true;
                    this.txtTomo.Enabled = true;
                    this.rbtPeriodo.Checked = false;
                }
            }

        

      }
}
