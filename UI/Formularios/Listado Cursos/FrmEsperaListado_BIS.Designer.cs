namespace UTN.SistemaAlumnos.UI
{
    partial class FrmEsperaListado_BIS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelEspera = new System.Windows.Forms.Label();
            this.BarraProgresoEspera = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // LabelEspera
            // 
            this.LabelEspera.AutoSize = true;
            this.LabelEspera.Location = new System.Drawing.Point(40, 9);
            this.LabelEspera.Name = "LabelEspera";
            this.LabelEspera.Size = new System.Drawing.Size(251, 13);
            this.LabelEspera.TabIndex = 0;
            this.LabelEspera.Text = "Aguarde mientras se genera el listado de asistencia.";
            // 
            // BarraProgresoEspera
            // 
            this.BarraProgresoEspera.Location = new System.Drawing.Point(29, 41);
            this.BarraProgresoEspera.Name = "BarraProgresoEspera";
            this.BarraProgresoEspera.Size = new System.Drawing.Size(270, 22);
            this.BarraProgresoEspera.TabIndex = 1;
            // 
            // FrmEsperaListado_BIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 87);
            this.Controls.Add(this.BarraProgresoEspera);
            this.Controls.Add(this.LabelEspera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEsperaListado_BIS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cargando...";
            this.Load += new System.EventHandler(this.FrmEsperaListado_BIS_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelEspera;
        private System.Windows.Forms.ProgressBar BarraProgresoEspera;
    }
}