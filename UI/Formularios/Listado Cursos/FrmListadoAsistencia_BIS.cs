using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UTN.SistemaAlumnos.UI
{
    public  partial class FrmListadoAsistencia_BIS : Form
    {
        #region "Atributos"
        public int Turno { get; set; }
        public int Materia { get; set; }
        public int Division { get; set; }
        #endregion

        #region "Constructores"
        public FrmListadoAsistencia_BIS()
        {
            InitializeComponent();
        }
        #endregion

        #region "Eventos"
        private void FrmListadoAsistencia_BIS_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.setear_epInfo();
            this.cargar_combos();
        }
        private void btnCancenlar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                this.setear_epInfo();
                if (this.validar_controles() == true)
                {
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Error al procesar datos: " + x.Message);
            }
        }
        #endregion

        #region "Metodos"
        private void cargar_combos()
        {
            try
            {
            }
            catch (Exception) { throw; }
        }
        private void setear_epInfo()
        {
            try
            {
                this.epInfo.SetError(this.cmbTurno, null);
                this.epInfo.SetError(this.cmbMateria, null);
                this.epInfo.SetError(this.cmbDivision, null);

                this.epInfo.SetError(this.cmbTurno, "Debe seleccionar un turno. \n" + "(Mañana o Noche)");
                this.epInfo.SetError(this.cmbMateria, "Debe seleccionar una materia. ");
                this.epInfo.SetError(this.cmbDivision, "Debe seleccionar una división. ");
            }
            catch (Exception) {throw;}
        }
        private bool validar_controles() 
        {
            try
            {
                bool validar = true;
                this.epError.SetError(this.cmbTurno, null);
                this.epError.SetError(this.cmbMateria, null);
                this.epError.SetError(this.cmbDivision, null);

                if (Convert.ToInt32(this.cmbTurno.SelectedValue)==0)
                {
                    this.epInfo.SetError(this.cmbTurno, null);
                    this.epError.SetError(this.cmbTurno, "No seleccionó ningún turno.");
                    validar = false;
                }

                if (Convert.ToInt32(this.cmbMateria.SelectedValue) == 0)
                {
                    this.epInfo.SetError(this.cmbMateria, null);
                    this.epError.SetError(this.cmbMateria, "No seleccionó ninguna materia.");
                    validar = false;
                }

                if (Convert.ToInt32(this.cmbDivision.SelectedValue) == 0)
                {
                    this.epInfo.SetError(this.cmbDivision, null);
                    this.epError.SetError(this.cmbDivision, "No seleccionó ninguna división.");
                    validar = false;
                }
                return validar;
            }
            catch (Exception) {throw;}
        }
        #endregion
    }
}
