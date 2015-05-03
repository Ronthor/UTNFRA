namespace UTN.SistemaAlumnos.UI
{
    partial class EstadisticaPorDivision
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
            this.components = new System.ComponentModel.Container();
            this.lblALectivo = new System.Windows.Forms.Label();
            this.txtALectivo = new System.Windows.Forms.TextBox();
            this.lblCuatrimestre = new System.Windows.Forms.Label();
            this.cmbCuatrimestre = new System.Windows.Forms.ComboBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.lblCarerra = new System.Windows.Forms.Label();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.lblMateria = new System.Windows.Forms.Label();
            this.cmbMateria = new System.Windows.Forms.ComboBox();
            this.lblDivision = new System.Windows.Forms.Label();
            this.txtDivision = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.epAnioLectivo = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epAnioLectivo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblALectivo
            // 
            this.lblALectivo.AutoSize = true;
            this.lblALectivo.Location = new System.Drawing.Point(12, 9);
            this.lblALectivo.Name = "lblALectivo";
            this.lblALectivo.Size = new System.Drawing.Size(60, 13);
            this.lblALectivo.TabIndex = 0;
            this.lblALectivo.Text = "Año lectivo";
            // 
            // txtALectivo
            // 
            this.txtALectivo.Location = new System.Drawing.Point(15, 25);
            this.txtALectivo.Name = "txtALectivo";
            this.txtALectivo.Size = new System.Drawing.Size(62, 20);
            this.txtALectivo.TabIndex = 1;
            this.txtALectivo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtALectivo_KeyPress);
            this.txtALectivo.Validating += new System.ComponentModel.CancelEventHandler(this.txtALectivo_Validating);
            this.txtALectivo.Validated += new System.EventHandler(this.txtALectivo_Validated);
            // 
            // lblCuatrimestre
            // 
            this.lblCuatrimestre.AutoSize = true;
            this.lblCuatrimestre.Location = new System.Drawing.Point(12, 88);
            this.lblCuatrimestre.Name = "lblCuatrimestre";
            this.lblCuatrimestre.Size = new System.Drawing.Size(65, 13);
            this.lblCuatrimestre.TabIndex = 2;
            this.lblCuatrimestre.Text = "Cuatrimestre";
            // 
            // cmbCuatrimestre
            // 
            this.cmbCuatrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCuatrimestre.FormattingEnabled = true;
            this.cmbCuatrimestre.Location = new System.Drawing.Point(15, 104);
            this.cmbCuatrimestre.Name = "cmbCuatrimestre";
            this.cmbCuatrimestre.Size = new System.Drawing.Size(137, 21);
            this.cmbCuatrimestre.TabIndex = 3;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(170, 88);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(35, 13);
            this.lblTurno.TabIndex = 4;
            this.lblTurno.Text = "Turno";
            // 
            // cmbTurno
            // 
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(173, 104);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(135, 21);
            this.cmbTurno.TabIndex = 5;
            // 
            // lblCarerra
            // 
            this.lblCarerra.AutoSize = true;
            this.lblCarerra.Location = new System.Drawing.Point(12, 168);
            this.lblCarerra.Name = "lblCarerra";
            this.lblCarerra.Size = new System.Drawing.Size(41, 13);
            this.lblCarerra.TabIndex = 6;
            this.lblCarerra.Text = "Carrera";
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Location = new System.Drawing.Point(15, 184);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(137, 21);
            this.cmbCarrera.TabIndex = 7;
            this.cmbCarrera.SelectionChangeCommitted += new System.EventHandler(this.cmbCarrera_SelectionChangeCommitted);
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(170, 168);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(42, 13);
            this.lblMateria.TabIndex = 8;
            this.lblMateria.Text = "Materia";
            // 
            // cmbMateria
            // 
            this.cmbMateria.FormattingEnabled = true;
            this.cmbMateria.Location = new System.Drawing.Point(173, 184);
            this.cmbMateria.Name = "cmbMateria";
            this.cmbMateria.Size = new System.Drawing.Size(135, 21);
            this.cmbMateria.TabIndex = 9;
            // 
            // lblDivision
            // 
            this.lblDivision.AutoSize = true;
            this.lblDivision.Location = new System.Drawing.Point(170, 9);
            this.lblDivision.Name = "lblDivision";
            this.lblDivision.Size = new System.Drawing.Size(44, 13);
            this.lblDivision.TabIndex = 10;
            this.lblDivision.Text = "Division";
            // 
            // txtDivision
            // 
            this.txtDivision.Location = new System.Drawing.Point(173, 25);
            this.txtDivision.Name = "txtDivision";
            this.txtDivision.Size = new System.Drawing.Size(62, 20);
            this.txtDivision.TabIndex = 11;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(190, 266);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(96, 38);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // epAnioLectivo
            // 
            this.epAnioLectivo.ContainerControl = this;
            // 
            // EstadisticaPorDivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 316);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtDivision);
            this.Controls.Add(this.lblDivision);
            this.Controls.Add(this.cmbMateria);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.lblCarerra);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.cmbCuatrimestre);
            this.Controls.Add(this.lblCuatrimestre);
            this.Controls.Add(this.txtALectivo);
            this.Controls.Add(this.lblALectivo);
            this.Name = "EstadisticaPorDivision";
            this.Text = "EstadisticaPorDivision";
            this.Load += new System.EventHandler(this.EstadisticaPorDivision_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epAnioLectivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblALectivo;
        private System.Windows.Forms.TextBox txtALectivo;
        private System.Windows.Forms.Label lblCuatrimestre;
        private System.Windows.Forms.ComboBox cmbCuatrimestre;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label lblCarerra;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox cmbMateria;
        private System.Windows.Forms.Label lblDivision;
        private System.Windows.Forms.TextBox txtDivision;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.ErrorProvider epAnioLectivo;
    }
}