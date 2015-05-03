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
    public partial class TurnosRendir : Form
    {

        //turnos ya registrador mostrar para modificar

        private EntTurnosRendir turnoNuevo;
        private int idMateria;
        private int idCarrera;
        private string descripcion;
        private char turno;

        public TurnosRendir(int idmat, int idcar, string desc)
        {
            InitializeComponent();

            dtmPrimerLlamado.MinDate = DateTime.Today;
            dtmSegundoLLamado.MinDate = DateTime.Today;

            txtMateriaSeleccionada.Text = desc;
            txtMateriaSeleccionada.ReadOnly = true;
            idMateria = idmat;
            idCarrera = idcar;
            descripcion = desc;
            checkSegundoLlamado.Checked = false;
            dtmSegundoLLamado.Enabled = false;
        }

        public EntTurnosRendir TurnoNuevo
        {
            get { return turnoNuevo; }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            DateTime dateDefault = new DateTime(1901, 1, 1); //fecha por default

            if (rdbtnTurnoMañana.Checked)
            {
                turno = 'M';
            }
            else if (rdbtnTurnoNoche.Checked)
            {
                turno = 'N';
            }

            if (!rdbtnTurnoMañana.Checked && !rdbtnTurnoNoche.Checked)
            {
                MessageBox.Show("Seleccione un turno");
            }
            else if (checkSegundoLlamado.Checked && dtmSegundoLLamado.Value <= dtmPrimerLlamado.Value)
            {
                MessageBox.Show("La segunda fecha no puede ser igual o menor a la primer fecha");

            }
            else
            {

                if (MessageBox.Show("¿Desea ingresar el turno de final?", "Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    if (checkSegundoLlamado.Checked)
                    {

                        turnoNuevo = new EntTurnosRendir(idCarrera, idMateria, turno, dtmPrimerLlamado.Value.Date, dtmSegundoLLamado.Value.Date);
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
                dtmSegundoLLamado.Enabled = true;
            }
            else
            {
                dtmSegundoLLamado.Enabled = false;
            }
        }

        private void TurnosRendir_Load(object sender, EventArgs e)
        {

        }

    }
}
