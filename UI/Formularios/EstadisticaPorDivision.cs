using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UTN.SistemaAlumnos.Negocio;
using UTN.SistemaAlumnos.Entidades;

namespace UTN.SistemaAlumnos.UI
{
    public partial class EstadisticaPorDivision : Form
    {
        public EstadisticaPorDivision()
        {
            InitializeComponent();
        }

        private void EstadisticaPorDivision_Load(object sender, EventArgs e)
        {
            this.CargarCombos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDivision.Text))
                MessageBox.Show("Debe Informar Division");
            else
            {
                int _anioLectivo = Convert.ToInt32(txtALectivo.Text );
                int _idMateria = Convert.ToInt32(cmbMateria.SelectedValue);
                string _turno = Convert.ToString(cmbTurno.SelectedValue.ToString());
                if (!OperacionesDivisiones.BuscarXDivision(_anioLectivo, _idMateria, _turno, txtDivision.Text ))
                {
                    MessageBox.Show("Ingrese Division Correcta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }


        // Verifica que sean numeros 
        private void txtALectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidarDatoNumerico(e);
        }

        //Tiene lugar cuando el control se está validando
        private void txtALectivo_Validating(object sender, CancelEventArgs e)
        {
            if (txtALectivo.Text.Length == 0)
            {
                epAnioLectivo.SetError(txtALectivo, "Ingresar Año Lectivo");
                MessageBox.Show("DEBE INFORMAR AÑO LECTIVO");
                e.Cancel = true;
            }
            else
                e.Cancel = false;
        }

        //Se produce cuando el control finaliza la validación.
        private void txtALectivo_Validated(object sender, EventArgs e)
        {
            if (txtALectivo.Text.Length == 4)
            {
                if (txtALectivo.Text != Convert.ToString(DateTime.Now.Year))

                    epAnioLectivo.SetError(txtALectivo, "Ingrese Nuevamente Año Lectivo Corriente");
                else
                    epAnioLectivo.SetError(txtALectivo, "");
            }
            else
                epAnioLectivo.SetError(txtALectivo, "Ingrese Nuevamente Año Lectivo Corriente");
        }

        private void cmbCarrera_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int carrera = Convert.ToInt32(cmbCarrera.SelectedValue.ToString());
            int cuatrimestre = Convert.ToInt32(cmbCuatrimestre.SelectedValue.ToString());
            CargarComboConMaterias(carrera, cuatrimestre);
        }


        #region "Medodos"

        // Metodos que permiten validar el ingreso de datos numericos  
        public void ValidarDatoNumerico(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void CargarCombos()
        {
            /// <summary>
            /// Se carga el combobox Cuatrimestre
            /// SE MODIFICA: el el valor de la primer variable string por int para obtener el idCuatrimestre
            /// </summary>
            BindingList<KeyValuePair<int, string>> listaCuatrimestre = new BindingList<KeyValuePair<int, string>>();

            listaCuatrimestre.Add(new KeyValuePair<int, string>(1, "Primer cuatrimestre"));
            listaCuatrimestre.Add(new KeyValuePair<int, string>(2, "Segundo cuatrimestre"));

            this.cmbCuatrimestre.DataSource = listaCuatrimestre;
            this.cmbCuatrimestre.ValueMember = "Key";
            this.cmbCuatrimestre.DisplayMember = "Value";
            //seleccion del posicion index 
            this.cmbCuatrimestre.SelectedIndex = -1;

            /// <summary>
            /// Se carga el combobox Turno
            /// </summary>
            BindingList<KeyValuePair<string, string>> listaTurno = new BindingList<KeyValuePair<string, string>>();

            listaTurno.Add(new KeyValuePair<string, string>("M", "Mañana"));
            listaTurno.Add(new KeyValuePair<string, string>("N", "Noche"));

            this.cmbTurno.DataSource = listaTurno;
            this.cmbTurno.ValueMember = "Key";
            this.cmbTurno.DisplayMember = "Value";
            //seleccion del posicion index 
            this.cmbTurno.SelectedIndex = -1;

            /// <summary>
            /// Se carga el combobox Carrera
            /// </summary>
            //cmbCarrera.DataSource = DatosCarrerasEstadXDiv.TraerTodas();
            cmbCarrera.DataSource = OperacionesCarreras.TraerTodas();
            cmbCarrera.ValueMember = "idCarrera";
            cmbCarrera.DisplayMember = "descripcion";
            cmbCarrera.SelectedIndex = -1;
        }

        private void CargarComboConMaterias(int carrera, int cuatrimestre)
        {
            //cmbMateria.DataSource = DatosMateriasEstadXDiv.TraerTodas(carrera, cuatrimestre);
            cmbMateria.DataSource = OperacionesMaterias.TraerTodas(carrera,cuatrimestre);
            cmbMateria.ValueMember = "idmateria";
            cmbMateria.DisplayMember = "descripcion";
            cmbMateria.SelectedIndex = -1;

        }

        #endregion

        
    }
}
