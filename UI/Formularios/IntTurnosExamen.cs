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
    public partial class IntTurnosExamen : Form
    {

        private DataSet ds = new DataSet();
        //private impl.Conector conex = new impl.Conector();
        private DataTable dtMateriasFiltradas = new DataTable("dtMateriasFiltradas");

        public IntTurnosExamen()
        {
            InitializeComponent();

            //conex.ConfigurarAdapter();
            //ds = conex.RetornarDataSet();
            ConfigurarDataGrid();
            cboCarrera.DataSource = ds.Tables["DtCarreras"];
            cboCarrera.DisplayMember = "descripcion";
            cboCarrera.ValueMember = "idCarrera";
            cboCarrera.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ConfigurarDataGrid()
        {
            dgvMaterias.MultiSelect = false;
            dgvMaterias.AllowUserToAddRows = false;
            dgvMaterias.AllowUserToDeleteRows = false;
            dgvMaterias.MultiSelect = false;
            dgvMaterias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMaterias.ReadOnly = true;
            dgvMaterias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            try
            {

                int idmateria = int.Parse(dgvMaterias.SelectedCells[0].Value.ToString());
                String descripcion = (dgvMaterias.SelectedCells[2].Value.ToString());
                int idcarrera = int.Parse(dgvMaterias.SelectedCells[1].Value.ToString());

                Materias frmMaterias = new Materias(idmateria, idcarrera, descripcion);
                if (frmMaterias.ShowDialog() == DialogResult.OK)
                {
                    //conex.Insertar(frmMaterias.TurnoNuevo);
                    MessageBox.Show("Turno registrado", "Confirmacion registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception e1)
            {

                MessageBox.Show(e1.Message);
            }    
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void cboCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCarrera.DisplayMember = "descripcion";
            cboCarrera.ValueMember = "idCarrera";

            dgvMaterias.Rows.Clear();
            int numero = (int)((ComboBox)sender).SelectedValue;
            DataRow[] row1 = ds.Tables["DtMaterias"].Select("idcarrera='" + numero + "'");

            foreach (DataRow item in row1)
            {
                dgvMaterias.Rows.Add(item[0], item[1], item[2], item[3], item[4]);
            }
        }

        private void IntTurnosExamen_Load(object sender, EventArgs e)
        {

        }

    }
}
