namespace UTN.SistemaAlumnos.UI
{
    partial class ConsultaDatosAcademicos
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
                  this.txtBusqueda = new System.Windows.Forms.TextBox();
                  this.rbtLegajo = new System.Windows.Forms.RadioButton();
                  this.rbtApellido = new System.Windows.Forms.RadioButton();
                  this.gbxBusqueda = new System.Windows.Forms.GroupBox();
                  this.btnBuscar = new System.Windows.Forms.Button();
                  this.btnVolver = new System.Windows.Forms.Button();
                  this.dgvResultadosBusqueda = new System.Windows.Forms.DataGridView();
                  this.gbxResultadosBusqueda = new System.Windows.Forms.GroupBox();
                  this.btnVer = new System.Windows.Forms.Button();
                  this.gbxBusqueda.SuspendLayout();
                  ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosBusqueda)).BeginInit();
                  this.gbxResultadosBusqueda.SuspendLayout();
                  this.SuspendLayout();
                  // 
                  // txtBusqueda
                  // 
                  this.txtBusqueda.Location = new System.Drawing.Point(6, 19);
                  this.txtBusqueda.Name = "txtBusqueda";
                  this.txtBusqueda.Size = new System.Drawing.Size(171, 20);
                  this.txtBusqueda.TabIndex = 0;
                  this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBusqueda_KeyPress);
                  // 
                  // rbtLegajo
                  // 
                  this.rbtLegajo.AutoSize = true;
                  this.rbtLegajo.Location = new System.Drawing.Point(6, 45);
                  this.rbtLegajo.Name = "rbtLegajo";
                  this.rbtLegajo.Size = new System.Drawing.Size(57, 17);
                  this.rbtLegajo.TabIndex = 1;
                  this.rbtLegajo.TabStop = true;
                  this.rbtLegajo.Text = "Legajo";
                  this.rbtLegajo.UseVisualStyleBackColor = true;
                  // 
                  // rbtApellido
                  // 
                  this.rbtApellido.AutoSize = true;
                  this.rbtApellido.Location = new System.Drawing.Point(115, 45);
                  this.rbtApellido.Name = "rbtApellido";
                  this.rbtApellido.Size = new System.Drawing.Size(62, 17);
                  this.rbtApellido.TabIndex = 2;
                  this.rbtApellido.TabStop = true;
                  this.rbtApellido.Text = "Apellido";
                  this.rbtApellido.UseVisualStyleBackColor = true;
                  // 
                  // gbxBusqueda
                  // 
                  this.gbxBusqueda.Controls.Add(this.txtBusqueda);
                  this.gbxBusqueda.Controls.Add(this.btnBuscar);
                  this.gbxBusqueda.Controls.Add(this.rbtApellido);
                  this.gbxBusqueda.Controls.Add(this.rbtLegajo);
                  this.gbxBusqueda.Location = new System.Drawing.Point(25, 22);
                  this.gbxBusqueda.Name = "gbxBusqueda";
                  this.gbxBusqueda.Size = new System.Drawing.Size(266, 71);
                  this.gbxBusqueda.TabIndex = 3;
                  this.gbxBusqueda.TabStop = false;
                  this.gbxBusqueda.Text = "Criterios de búsqueda";
                  // 
                  // btnBuscar
                  // 
                  this.btnBuscar.Location = new System.Drawing.Point(183, 17);
                  this.btnBuscar.Name = "btnBuscar";
                  this.btnBuscar.Size = new System.Drawing.Size(75, 23);
                  this.btnBuscar.TabIndex = 4;
                  this.btnBuscar.Text = "Buscar";
                  this.btnBuscar.UseVisualStyleBackColor = true;
                  this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
                  // 
                  // btnVolver
                  // 
                  this.btnVolver.Location = new System.Drawing.Point(216, 234);
                  this.btnVolver.Name = "btnVolver";
                  this.btnVolver.Size = new System.Drawing.Size(75, 23);
                  this.btnVolver.TabIndex = 5;
                  this.btnVolver.Text = "Volver";
                  this.btnVolver.UseVisualStyleBackColor = true;
                  this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
                  // 
                  // dgvResultadosBusqueda
                  // 
                  this.dgvResultadosBusqueda.AllowUserToAddRows = false;
                  this.dgvResultadosBusqueda.AllowUserToDeleteRows = false;
                  this.dgvResultadosBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                  this.dgvResultadosBusqueda.Location = new System.Drawing.Point(10, 19);
                  this.dgvResultadosBusqueda.Name = "dgvResultadosBusqueda";
                  this.dgvResultadosBusqueda.ReadOnly = true;
                  this.dgvResultadosBusqueda.Size = new System.Drawing.Size(247, 99);
                  this.dgvResultadosBusqueda.TabIndex = 6;
                  // 
                  // gbxResultadosBusqueda
                  // 
                  this.gbxResultadosBusqueda.Controls.Add(this.dgvResultadosBusqueda);
                  this.gbxResultadosBusqueda.Location = new System.Drawing.Point(25, 99);
                  this.gbxResultadosBusqueda.Name = "gbxResultadosBusqueda";
                  this.gbxResultadosBusqueda.Size = new System.Drawing.Size(266, 129);
                  this.gbxResultadosBusqueda.TabIndex = 7;
                  this.gbxResultadosBusqueda.TabStop = false;
                  this.gbxResultadosBusqueda.Text = "Resultados de la búsqueda";
                  // 
                  // btnVer
                  // 
                  this.btnVer.Location = new System.Drawing.Point(135, 234);
                  this.btnVer.Name = "btnVer";
                  this.btnVer.Size = new System.Drawing.Size(75, 23);
                  this.btnVer.TabIndex = 8;
                  this.btnVer.Text = "Ver";
                  this.btnVer.UseVisualStyleBackColor = true;
                  this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
                  // 
                  // ConsultaDatosAcademicos
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.ClientSize = new System.Drawing.Size(318, 273);
                  this.Controls.Add(this.btnVer);
                  this.Controls.Add(this.gbxResultadosBusqueda);
                  this.Controls.Add(this.btnVolver);
                  this.Controls.Add(this.gbxBusqueda);
                  this.Name = "ConsultaDatosAcademicos";
                  this.Text = "Consulta académica de alumno";
                  this.Load += new System.EventHandler(this.ConsultaDatosAcademicos_Load);
                  this.gbxBusqueda.ResumeLayout(false);
                  this.gbxBusqueda.PerformLayout();
                  ((System.ComponentModel.ISupportInitialize)(this.dgvResultadosBusqueda)).EndInit();
                  this.gbxResultadosBusqueda.ResumeLayout(false);
                  this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.RadioButton rbtLegajo;
        private System.Windows.Forms.RadioButton rbtApellido;
        private System.Windows.Forms.GroupBox gbxBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DataGridView dgvResultadosBusqueda;
        private System.Windows.Forms.GroupBox gbxResultadosBusqueda;
        private System.Windows.Forms.Button btnVer;
    }
}