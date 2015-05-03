using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UTN.SistemaAlumnos.Entidades;
using UTN.SistemaAlumnos.Datos;

namespace UTN.SistemaAlumnos.UI.Formularios
{
    public partial class frmRegistroProfesores : Form
    {
        public frmRegistroProfesores()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
                     
             EntProfesores _profesor= new EntProfesores();
                 
                 try
                {
                         

            
            bool esvalido = false;
            if (string.IsNullOrWhiteSpace(txbNombre.Text))
            {
                MessageBox.Show("Debe completar el nombre");
                txbNombre.Focus();
                txbNombre.BackColor = Color.Red;
                esvalido= false;
            }

            //apellido
            if (string.IsNullOrWhiteSpace(txbApellido.Text))
            {
                MessageBox.Show("Debe completar el Apellido");
                txbApellido.Focus();
                txbApellido.BackColor = Color.Red;
                esvalido = false;
            }
            //Calle
            if (string.IsNullOrWhiteSpace(txbCalle.Text))
            {
                MessageBox.Show("Debe completar el Domicilio");
                txbCalle.Focus();
                txbCalle.BackColor = Color.Red;
                esvalido = false;
            }
            //Calle
            if (string.IsNullOrWhiteSpace(txbPiso.Text))
            {
                MessageBox.Show("Debe completar el Domicilio");
                txbPiso.Focus();
                txbPiso.BackColor = Color.Red;
                esvalido = false;
            }


                  //  _profesor.IdProfesor = new ProfesoresNegocio().ObtenerMayorID();
                    _profesor.Nombre = txbNombre.Text;
                    _profesor.Apellido = txbApellido.Text;
                    _profesor.DomCalle = txbCalle.Text;
                    _profesor.DomNro = Int32.Parse(txbNumero.Text);
                    _profesor.DomPiso = Int32.Parse(txbPiso.Text);
                    _profesor.DomDepto = char.Parse(txbDpto.Text);
                    _profesor.Telefono = txbTelefono.Text;
                    _profesor.Mail = txbMail.Text;
                   // _profesor.Estado = Convert.ToChar(cbEstado.SelectedValue);
                    _profesor.Estado = 'N';

                    if (esvalido==true)
                    {
                        Datos.ProfesoresDatos.AltaProfesor(_profesor);
                        MessageBox.Show("listo para transferir");
                    }
                  
                }
                catch (Exception x)
                {

                    MessageBox.Show("No se pudo dar de alta el Profesor\n\n"+x.Message);
                    
                }
                
             }







        private void grpboxRegistroProfesores_Enter(object sender, EventArgs e)
        {
        
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }

}

