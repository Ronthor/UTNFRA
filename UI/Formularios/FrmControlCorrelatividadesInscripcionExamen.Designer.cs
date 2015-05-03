namespace UTN.SistemaAlumnos.UI
{
    partial class FrmControlCorrelatividadesInscripcionExamen
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
            this.btnValInscMaterias = new System.Windows.Forms.Button();
            this.btnValInscFinales = new System.Windows.Forms.Button();
            this.dgv_Alumnos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnValInscMaterias
            // 
            this.btnValInscMaterias.Location = new System.Drawing.Point(33, 59);
            this.btnValInscMaterias.Name = "btnValInscMaterias";
            this.btnValInscMaterias.Size = new System.Drawing.Size(219, 23);
            this.btnValInscMaterias.TabIndex = 0;
            this.btnValInscMaterias.Text = "Validar Inscripcion Materias";
            this.btnValInscMaterias.UseVisualStyleBackColor = true;
            // 
            // btnValInscFinales
            // 
            this.btnValInscFinales.Location = new System.Drawing.Point(298, 59);
            this.btnValInscFinales.Name = "btnValInscFinales";
            this.btnValInscFinales.Size = new System.Drawing.Size(234, 23);
            this.btnValInscFinales.TabIndex = 1;
            this.btnValInscFinales.Text = "Validar Inscripcion Finales";
            this.btnValInscFinales.UseVisualStyleBackColor = true;
            // 
            // dgv_Alumnos
            // 
            this.dgv_Alumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Alumnos.Location = new System.Drawing.Point(33, 99);
            this.dgv_Alumnos.Name = "dgv_Alumnos";
            this.dgv_Alumnos.Size = new System.Drawing.Size(499, 284);
            this.dgv_Alumnos.TabIndex = 2;
            // 
            // FrmControlCorrelatividadesInscripcionExamen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 438);
            this.Controls.Add(this.dgv_Alumnos);
            this.Controls.Add(this.btnValInscFinales);
            this.Controls.Add(this.btnValInscMaterias);
            this.Name = "FrmControlCorrelatividadesInscripcionExamen";
            this.Text = "FrmControlCorrelatividadesInscripcionExamen";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Alumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnValInscMaterias;
        private System.Windows.Forms.Button btnValInscFinales;
        private System.Windows.Forms.DataGridView dgv_Alumnos;
    }
}