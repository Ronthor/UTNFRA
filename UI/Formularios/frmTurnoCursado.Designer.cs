namespace UTN.SistemaAlumnos.UI.Formularios
{
      partial class frmTurnoCursado
      {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private System.ComponentModel.IContainer components = null;

            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose (bool disposing)
            {
                  if (disposing && (components != null))
                  {
                        components.Dispose ();
                  }
                  base.Dispose (disposing);
            }

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent ()
            {
                  this.lblCarreras = new System.Windows.Forms.Label();
                  this.groupBox1 = new System.Windows.Forms.GroupBox();
                  this.txtDuracion = new System.Windows.Forms.TextBox();
                  this.gboDias = new System.Windows.Forms.GroupBox();
                  this.chkSabado = new System.Windows.Forms.CheckBox();
                  this.chkMartes = new System.Windows.Forms.CheckBox();
                  this.chkJueves = new System.Windows.Forms.CheckBox();
                  this.chkViernes = new System.Windows.Forms.CheckBox();
                  this.chkMiercoles = new System.Windows.Forms.CheckBox();
                  this.chkLun = new System.Windows.Forms.CheckBox();
                  this.cboTurno = new System.Windows.Forms.ComboBox();
                  this.cboMaterias = new System.Windows.Forms.ComboBox();
                  this.cboCarreras = new System.Windows.Forms.ComboBox();
                  this.lblDuracion = new System.Windows.Forms.Label();
                  this.lblDia = new System.Windows.Forms.Label();
                  this.lblMateria = new System.Windows.Forms.Label();
                  this.lblTurno = new System.Windows.Forms.Label();
                  this.btnGuardar = new System.Windows.Forms.Button();
                  this.groupBox1.SuspendLayout();
                  this.gboDias.SuspendLayout();
                  this.SuspendLayout();
                  // 
                  // lblCarreras
                  // 
                  this.lblCarreras.AutoSize = true;
                  this.lblCarreras.Location = new System.Drawing.Point(22, 31);
                  this.lblCarreras.Name = "lblCarreras";
                  this.lblCarreras.Size = new System.Drawing.Size(49, 13);
                  this.lblCarreras.TabIndex = 0;
                  this.lblCarreras.Text = "Carreras:";
                  // 
                  // groupBox1
                  // 
                  this.groupBox1.Controls.Add(this.txtDuracion);
                  this.groupBox1.Controls.Add(this.gboDias);
                  this.groupBox1.Controls.Add(this.cboTurno);
                  this.groupBox1.Controls.Add(this.cboMaterias);
                  this.groupBox1.Controls.Add(this.cboCarreras);
                  this.groupBox1.Controls.Add(this.lblDuracion);
                  this.groupBox1.Controls.Add(this.lblDia);
                  this.groupBox1.Controls.Add(this.lblMateria);
                  this.groupBox1.Controls.Add(this.lblTurno);
                  this.groupBox1.Controls.Add(this.lblCarreras);
                  this.groupBox1.Location = new System.Drawing.Point(12, 12);
                  this.groupBox1.Name = "groupBox1";
                  this.groupBox1.Size = new System.Drawing.Size(609, 274);
                  this.groupBox1.TabIndex = 1;
                  this.groupBox1.TabStop = false;
                  this.groupBox1.Text = "groupBox1";
                  // 
                  // txtDuracion
                  // 
                  this.txtDuracion.Location = new System.Drawing.Point(81, 208);
                  this.txtDuracion.Name = "txtDuracion";
                  this.txtDuracion.Size = new System.Drawing.Size(100, 20);
                  this.txtDuracion.TabIndex = 9;
                  // 
                  // gboDias
                  // 
                  this.gboDias.Controls.Add(this.chkSabado);
                  this.gboDias.Controls.Add(this.chkMartes);
                  this.gboDias.Controls.Add(this.chkJueves);
                  this.gboDias.Controls.Add(this.chkViernes);
                  this.gboDias.Controls.Add(this.chkMiercoles);
                  this.gboDias.Controls.Add(this.chkLun);
                  this.gboDias.Location = new System.Drawing.Point(81, 136);
                  this.gboDias.Name = "gboDias";
                  this.gboDias.Size = new System.Drawing.Size(522, 54);
                  this.gboDias.TabIndex = 8;
                  this.gboDias.TabStop = false;
                  this.gboDias.Text = "Dias de la semana";
                  // 
                  // chkSabado
                  // 
                  this.chkSabado.AutoSize = true;
                  this.chkSabado.Location = new System.Drawing.Point(427, 19);
                  this.chkSabado.Name = "chkSabado";
                  this.chkSabado.Size = new System.Drawing.Size(63, 17);
                  this.chkSabado.TabIndex = 5;
                  this.chkSabado.Text = "Sabado";
                  this.chkSabado.UseVisualStyleBackColor = true;
                  // 
                  // chkMartes
                  // 
                  this.chkMartes.AutoSize = true;
                  this.chkMartes.Location = new System.Drawing.Point(92, 19);
                  this.chkMartes.Name = "chkMartes";
                  this.chkMartes.Size = new System.Drawing.Size(58, 17);
                  this.chkMartes.TabIndex = 4;
                  this.chkMartes.Text = "Martes";
                  this.chkMartes.UseVisualStyleBackColor = true;
                  // 
                  // chkJueves
                  // 
                  this.chkJueves.AutoSize = true;
                  this.chkJueves.Location = new System.Drawing.Point(264, 19);
                  this.chkJueves.Name = "chkJueves";
                  this.chkJueves.Size = new System.Drawing.Size(60, 17);
                  this.chkJueves.TabIndex = 3;
                  this.chkJueves.Text = "Jueves";
                  this.chkJueves.UseVisualStyleBackColor = true;
                  // 
                  // chkViernes
                  // 
                  this.chkViernes.AutoSize = true;
                  this.chkViernes.Location = new System.Drawing.Point(341, 19);
                  this.chkViernes.Name = "chkViernes";
                  this.chkViernes.Size = new System.Drawing.Size(61, 17);
                  this.chkViernes.TabIndex = 2;
                  this.chkViernes.Text = "Viernes";
                  this.chkViernes.UseVisualStyleBackColor = true;
                  // 
                  // chkMiercoles
                  // 
                  this.chkMiercoles.AutoSize = true;
                  this.chkMiercoles.Location = new System.Drawing.Point(178, 19);
                  this.chkMiercoles.Name = "chkMiercoles";
                  this.chkMiercoles.Size = new System.Drawing.Size(71, 17);
                  this.chkMiercoles.TabIndex = 1;
                  this.chkMiercoles.Text = "Miercoles";
                  this.chkMiercoles.UseVisualStyleBackColor = true;
                  // 
                  // chkLun
                  // 
                  this.chkLun.AutoSize = true;
                  this.chkLun.Location = new System.Drawing.Point(6, 19);
                  this.chkLun.Name = "chkLun";
                  this.chkLun.Size = new System.Drawing.Size(55, 17);
                  this.chkLun.TabIndex = 0;
                  this.chkLun.Text = "Lunes";
                  this.chkLun.UseVisualStyleBackColor = true;
                  // 
                  // cboTurno
                  // 
                  this.cboTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                  this.cboTurno.FormattingEnabled = true;
                  this.cboTurno.Location = new System.Drawing.Point(78, 98);
                  this.cboTurno.Name = "cboTurno";
                  this.cboTurno.Size = new System.Drawing.Size(150, 21);
                  this.cboTurno.TabIndex = 7;
                  // 
                  // cboMaterias
                  // 
                  this.cboMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                  this.cboMaterias.FormattingEnabled = true;
                  this.cboMaterias.Location = new System.Drawing.Point(78, 59);
                  this.cboMaterias.Name = "cboMaterias";
                  this.cboMaterias.Size = new System.Drawing.Size(150, 21);
                  this.cboMaterias.TabIndex = 6;
                  // 
                  // cboCarreras
                  // 
                  this.cboCarreras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                  this.cboCarreras.FormattingEnabled = true;
                  this.cboCarreras.Location = new System.Drawing.Point(77, 28);
                  this.cboCarreras.Name = "cboCarreras";
                  this.cboCarreras.Size = new System.Drawing.Size(151, 21);
                  this.cboCarreras.TabIndex = 5;
                  this.cboCarreras.SelectedIndexChanged += new System.EventHandler(this.cboCarreras_SelectedIndexChanged);
                  // 
                  // lblDuracion
                  // 
                  this.lblDuracion.AutoSize = true;
                  this.lblDuracion.Location = new System.Drawing.Point(22, 211);
                  this.lblDuracion.Name = "lblDuracion";
                  this.lblDuracion.Size = new System.Drawing.Size(53, 13);
                  this.lblDuracion.TabIndex = 4;
                  this.lblDuracion.Text = "Duracion:";
                  // 
                  // lblDia
                  // 
                  this.lblDia.AutoSize = true;
                  this.lblDia.Location = new System.Drawing.Point(22, 145);
                  this.lblDia.Name = "lblDia";
                  this.lblDia.Size = new System.Drawing.Size(31, 13);
                  this.lblDia.TabIndex = 3;
                  this.lblDia.Text = "Dias:";
                  // 
                  // lblMateria
                  // 
                  this.lblMateria.AutoSize = true;
                  this.lblMateria.Location = new System.Drawing.Point(22, 62);
                  this.lblMateria.Name = "lblMateria";
                  this.lblMateria.Size = new System.Drawing.Size(50, 13);
                  this.lblMateria.TabIndex = 2;
                  this.lblMateria.Text = "Materias:";
                  // 
                  // lblTurno
                  // 
                  this.lblTurno.AutoSize = true;
                  this.lblTurno.Location = new System.Drawing.Point(22, 101);
                  this.lblTurno.Name = "lblTurno";
                  this.lblTurno.Size = new System.Drawing.Size(38, 13);
                  this.lblTurno.TabIndex = 1;
                  this.lblTurno.Text = "Turno:";
                  // 
                  // btnGuardar
                  // 
                  this.btnGuardar.Location = new System.Drawing.Point(546, 312);
                  this.btnGuardar.Name = "btnGuardar";
                  this.btnGuardar.Size = new System.Drawing.Size(75, 23);
                  this.btnGuardar.TabIndex = 2;
                  this.btnGuardar.Text = "Guardar";
                  this.btnGuardar.UseVisualStyleBackColor = true;
                  // 
                  // frmTurnoCursado
                  // 
                  this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                  this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                  this.ClientSize = new System.Drawing.Size(672, 347);
                  this.Controls.Add(this.btnGuardar);
                  this.Controls.Add(this.groupBox1);
                  this.Name = "frmTurnoCursado";
                  this.Text = "frmTurnoCursado";
                  this.Load += new System.EventHandler(this.frmTurnoCursado_Load);
                  this.groupBox1.ResumeLayout(false);
                  this.groupBox1.PerformLayout();
                  this.gboDias.ResumeLayout(false);
                  this.gboDias.PerformLayout();
                  this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.Label lblCarreras;
            private System.Windows.Forms.GroupBox groupBox1;
            private System.Windows.Forms.TextBox txtDuracion;
            private System.Windows.Forms.GroupBox gboDias;
            private System.Windows.Forms.CheckBox chkSabado;
            private System.Windows.Forms.CheckBox chkMartes;
            private System.Windows.Forms.CheckBox chkJueves;
            private System.Windows.Forms.CheckBox chkViernes;
            private System.Windows.Forms.CheckBox chkMiercoles;
            private System.Windows.Forms.CheckBox chkLun;
            private System.Windows.Forms.ComboBox cboTurno;
            private System.Windows.Forms.ComboBox cboMaterias;
            private System.Windows.Forms.ComboBox cboCarreras;
            private System.Windows.Forms.Label lblDuracion;
            private System.Windows.Forms.Label lblDia;
            private System.Windows.Forms.Label lblMateria;
            private System.Windows.Forms.Label lblTurno;
            private System.Windows.Forms.Button btnGuardar;
      }
}