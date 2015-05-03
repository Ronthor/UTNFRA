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
    public partial class FrmEsperaListado_BIS : Form
    {
        public FrmEsperaListado_BIS()
        {
            InitializeComponent();
        }

        private void FrmEsperaListado_BIS_Load(object sender, EventArgs e)
        {
            this.BarraProgresoEspera.Value = 0;
            this.BarraProgresoEspera.MarqueeAnimationSpeed = 20;
            this.BarraProgresoEspera.Style = ProgressBarStyle.Marquee;
        }
    }
}
