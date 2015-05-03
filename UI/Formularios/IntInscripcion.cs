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
    public partial class IntInscripcion : Form
    {
        //private bool _alumnoEncontrado = false;
        public IntInscripcion()
        {
            InitializeComponent();
        }

        private void IntInscripcion_Load(object sender, EventArgs e)
        {
            //traer las carreras
            List<Entidades.Carrera> carreras = new List<Entidades.Carrera>();
            carreras = Datos.DatosCarreras.TraerTodas();
            cmbCarrera.DataSource = carreras;
            cmbCarrera.ValueMember = "Id";
            cmbCarrera.DisplayMember = "Descripcion";
            
            
        }

        private void cmbCarrera_LostFocus(object sender, EventArgs e)
        {

            if (this.cmbCarrera.FindString(this.cmbCarrera.Text) >= 0)
            {
                cmbCarrera.BackColor = Color.White;
                //cargo las materias
              
            }
            else
            {
                cmbCarrera.BackColor = Color.Red;
            }
        }


    }
}
