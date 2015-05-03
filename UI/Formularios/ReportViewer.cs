using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using UTN.SistemaAlumnos.Datos;
using UTN.SistemaAlumnos.Entidades;

namespace UTN.SistemaAlumnos.UI
{
    public partial class ReportViewer : Form
    {
        public ReportViewer(String ReportName, Object listaEntidades, String WindowTitle = "Reporte")
        {
            InitializeComponent();
            if (!string.IsNullOrEmpty(WindowTitle))
                this.Text = WindowTitle;
            this.modificarOrigenesDeDatos(listaEntidades);
            this.modificarDefinicionDeReporte(ReportName);

            this.Text = WindowTitle;
        }

        private void modificarDefinicionDeReporte(string rutaReporte)
        {
            Stream archivosCorrectos = new FileStream(rutaReporte, FileMode.Open);
            archivosCorrectos.Position = 0;
            this.rptViewer.LocalReport.LoadReportDefinition(archivosCorrectos);
            this.rptViewer.RefreshReport();
            archivosCorrectos.Close();

        }

        private void modificarOrigenesDeDatos(Object origenDeDatos)
        {
            this.rptViewer.Reset();
            this.rptViewer.LocalReport.EnableExternalImages = true;
            this.rptViewer.LocalReport.DataSources.Add(new ReportDataSource("DSCarreras", origenDeDatos));
            this.rptViewer.RefreshReport();

        }


    }
}