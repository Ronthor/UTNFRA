using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UTN.SistemaAlumnos.Datos;
using UTN.SistemaAlumnos.Entidades;
using UTN.SistemaAlumnos.UI;
using UTN.SistemaAlumnos.UI.Formularios;

namespace UI
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //comentario de prueba check in / check out
        }

        private void estadisticaPorDivisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EstadisticaPorDivision formularioEstadisticaPorDivision = new EstadisticaPorDivision();

            formularioEstadisticaPorDivision.ShowDialog();
        }

        private void eJEMPLOReporteCarrerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<Carrera> carreras = new List<Carrera>();
            carreras = DatosCarreras.TraerTodas();
            ///20150419 19:43- Se comentó ya que generaba errores y no dejaba compilar el proyecto en TFS
            //ReportViewer rptv = new ReportViewer(@"Reportes\RCarreras.rdlc", carreras.ToList()); 
           // rptv.ShowDialog();
        }

        private void turnosDeCursadaToolStripMenuItem_Click (object sender, EventArgs e)
        {
              frmTurnoCursado turnoCursada = new frmTurnoCursado ();
              turnoCursada.ShowDialog ();
        }

        private void listadosDeAsistenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void turnomateriadivisiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoAsistencia_BIS frmListadoDeAsistenciaBIS = new FrmListadoAsistencia_BIS();
            frmListadoDeAsistenciaBIS.ShowDialog();
        }

        private void porComienzoDeUnCuatrimestreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEsperaListado_BIS frmListadoDeAsistenciaComienzoCuatrimestre = new FrmEsperaListado_BIS();
            frmListadoDeAsistenciaComienzoCuatrimestre.ShowDialog();
        }

        private void registroProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistroProfesores frmRegistroProf = new frmRegistroProfesores();
            frmRegistroProf.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultaAcadémicaDeAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaDatosAcademicos formConsultaDatosAcademicos = new ConsultaDatosAcademicos();
            formConsultaDatosAcademicos.Show();
        }

        private void porTurnomateriadivisiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerarListaDeAsistencia frmGenerarListadoAsistencia = new GenerarListaDeAsistencia();
            frmGenerarListadoAsistencia.Show();
        }

        private void listadoCompletoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //GenerarListadoCompleto frmGenerarListadoCompleto = new GenerarListadoCompleto();
            //frmGenerarListadoCompleto.Show();
        }

        private void estadísticasPorActaDeExámenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticaActasExamenes frmEstadisticasExamen = new frmEstadisticaActasExamenes();
            frmEstadisticasExamen.ShowDialog();
        }

        


    }
}
