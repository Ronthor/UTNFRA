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
    public partial class Materias : Form
    {
        //private impl.Conector conex = new impl.Conector();
        private EntTurnosRendir turnoNuevo;
        private int idMateria;
        private int idCarrera;
        private string descripcion;
        private char turno;

        public Materias(int idmat, int idcar, string desc)
        {
            InitializeComponent();

            dtmPrimerLlamado.MinDate = DateTime.Today;
            dtmSegundoLlamado.MinDate = DateTime.Today;

            txtMateriaSeleccionada.Text = desc;
            txtMateriaSeleccionada.ReadOnly = true;
            idMateria = idmat;
            idCarrera = idcar;
            descripcion = desc;
            checkSegundoLlamado.Checked = false;
            dtmSegundoLlamado.Enabled = false;
        }

        public EntTurnosRendir TurnoNuevo
        {
            get { return turnoNuevo; }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            DateTime dateDefault = new DateTime(1901, 1, 1); //fecha por default

            if (radioButtonMañana.Checked)
            {
                turno = 'M';
            }
            else if (radioButtonNoche.Checked)
            {
                turno = 'N';
            }

            if (!radioButtonMañana.Checked && !radioButtonNoche.Checked)
            {
                MessageBox.Show("Seleccione un turno");
            }
            else if (checkSegundoLlamado.Checked && dtmSegundoLlamado.Value <= dtmPrimerLlamado.Value)
            {
                MessageBox.Show("La segunda fecha no puede ser igual o menor a la primer fecha");

            }
            else
            {

                if (MessageBox.Show("¿Desea ingresar el turno de final?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    if (checkSegundoLlamado.Checked)
                    {

                        turnoNuevo = new EntTurnosRendir(idCarrera, idMateria, turno, dtmPrimerLlamado.Value.Date, dtmSegundoLlamado.Value.Date);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        turnoNuevo = new EntTurnosRendir(idCarrera, idMateria, turno, dtmPrimerLlamado.Value.Date, dateDefault);
                        this.DialogResult = DialogResult.OK;

                    }
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void checkSegundoLlamado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSegundoLlamado.Checked)
            {
                dtmSegundoLlamado.Enabled = true;
            }
            else
            {
                dtmSegundoLlamado.Enabled = false;
            }
        }


    }
}
