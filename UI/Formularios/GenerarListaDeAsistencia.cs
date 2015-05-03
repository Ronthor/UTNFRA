using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UTN.SistemaAlumnos.Entidades;
using UTN.SistemaAlumnos.Datos;

namespace UTN.SistemaAlumnos.UI.Formularios
{
    public partial class GenerarListaDeAsistencia : Form
    {
        public GenerarListaDeAsistencia()
        {
            InitializeComponent();
        }

        private void GenerarListaDeAsistencia_Load(object sender, EventArgs e)
        {
            List<Carrera> _listaCarreras = new List<Carrera>();
            
            try
            {
                _listaCarreras=DatosCarreras.TraerTodas();
                this.cboCarrera.DataSource = _listaCarreras;
                this.cboCarrera.ValueMember = "Id";
                this.cboCarrera.DisplayMember = "Descripcion";
            }

            catch
            {
                MessageBox.Show("Error al traer las carreras","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            if (_listaCarreras.Count > 0)
            {
                this.cboCarrera.SelectedIndexChanged += new System.EventHandler(this.cboCarrera_SelectedIndexChanged);
            }


            //Que todos los combos aparezcan por default deshabilitados,
            //menos el de Carreras. Al elegir una carrera habilitará el
            //siguiente combo, así sucesivamente.
            //Llenar el combo Carrera, una llamada directa a la capa de datos.
            //En los manejadores de cada combo cargar el siguiente combo.
            //O ver si conviene bajar todo en un DataTable e ir filtrando con vistas.
            //
        }
        
        private void cboCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboCarrera.SelectedIndex!=-1)
            {
                //Habilito el combo y luego tengo que cargarlo, agregar el manejador etc etc
                habilitarCombo(ref cboCarrera);
            }
        }

        private void cboTurno_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboDivision_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

        }

        private void habilitarCombo(ref ComboBox combo)
        {
            combo.Enabled = true;
        }

    }
}
