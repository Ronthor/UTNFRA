namespace UTN.SistemaAlumnos.UI.Formularios
{
    partial class TurnosRendir
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
            this.lblMateriaSeleccionada = new System.Windows.Forms.Label();
            this.txtMateriaSeleccionada = new System.Windows.Forms.TextBox();
            this.rdbtnTurnoMañana = new System.Windows.Forms.RadioButton();
            this.rdbtnTurnoNoche = new System.Windows.Forms.RadioButton();
            this.dtmPrimerLlamado = new System.Windows.Forms.DateTimePicker();
            this.dtmSegundoLLamado = new System.Windows.Forms.DateTimePicker();
            this.lblPrimerLlamado = new System.Windows.Forms.Label();
            this.lblSegundoLlamado = new System.Windows.Forms.Label();
            this.groupBoxFechas = new System.Windows.Forms.GroupBox();
            this.checkSegundoLlamado = new System.Windows.Forms.CheckBox();
            this.groupBoxTurnos = new System.Windows.Forms.GroupBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBoxFechas.SuspendLayout();
            this.groupBoxTurnos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMateriaSeleccionada
            // 
            this.lblMateriaSeleccionada.AutoSize = true;
            this.lblMateriaSeleccionada.Location = new System.Drawing.Point(19, 21);
            this.lblMateriaSeleccionada.Name = "lblMateriaSeleccionada";
            this.lblMateriaSeleccionada.Size = new System.Drawing.Size(114, 13);
            this.lblMateriaSeleccionada.TabIndex = 0;
            this.lblMateriaSeleccionada.Text = "Materia seleccionada: ";
            // 
            // txtMateriaSeleccionada
            // 
            this.txtMateriaSeleccionada.Location = new System.Drawing.Point(143, 18);
            this.txtMateriaSeleccionada.Name = "txtMateriaSeleccionada";
            this.txtMateriaSeleccionada.Size = new System.Drawing.Size(161, 20);
            this.txtMateriaSeleccionada.TabIndex = 1;
            // 
            // rdbtnTurnoMañana
            // 
            this.rdbtnTurnoMañana.AutoSize = true;
            this.rdbtnTurnoMañana.Location = new System.Drawing.Point(10, 19);
            this.rdbtnTurnoMañana.Name = "rdbtnTurnoMañana";
            this.rdbtnTurnoMañana.Size = new System.Drawing.Size(64, 17);
            this.rdbtnTurnoMañana.TabIndex = 2;
            this.rdbtnTurnoMañana.TabStop = true;
            this.rdbtnTurnoMañana.Text = "Mañana";
            this.rdbtnTurnoMañana.UseVisualStyleBackColor = true;
            // 
            // rdbtnTurnoNoche
            // 
            this.rdbtnTurnoNoche.AutoSize = true;
            this.rdbtnTurnoNoche.Location = new System.Drawing.Point(158, 19);
            this.rdbtnTurnoNoche.Name = "rdbtnTurnoNoche";
            this.rdbtnTurnoNoche.Size = new System.Drawing.Size(57, 17);
            this.rdbtnTurnoNoche.TabIndex = 3;
            this.rdbtnTurnoNoche.TabStop = true;
            this.rdbtnTurnoNoche.Text = "Noche";
            this.rdbtnTurnoNoche.UseVisualStyleBackColor = true;
            // 
            // dtmPrimerLlamado
            // 
            this.dtmPrimerLlamado.Location = new System.Drawing.Point(10, 58);
            this.dtmPrimerLlamado.Name = "dtmPrimerLlamado";
            this.dtmPrimerLlamado.Size = new System.Drawing.Size(262, 20);
            this.dtmPrimerLlamado.TabIndex = 4;
            // 
            // dtmSegundoLLamado
            // 
            this.dtmSegundoLLamado.Location = new System.Drawing.Point(10, 189);
            this.dtmSegundoLLamado.Name = "dtmSegundoLLamado";
            this.dtmSegundoLLamado.Size = new System.Drawing.Size(258, 20);
            this.dtmSegundoLLamado.TabIndex = 5;
            // 
            // lblPrimerLlamado
            // 
            this.lblPrimerLlamado.AutoSize = true;
            this.lblPrimerLlamado.Location = new System.Drawing.Point(11, 32);
            this.lblPrimerLlamado.Name = "lblPrimerLlamado";
            this.lblPrimerLlamado.Size = new System.Drawing.Size(78, 13);
            this.lblPrimerLlamado.TabIndex = 6;
            this.lblPrimerLlamado.Text = "Primer llamado:";
            // 
            // lblSegundoLlamado
            // 
            this.lblSegundoLlamado.AutoSize = true;
            this.lblSegundoLlamado.Location = new System.Drawing.Point(7, 159);
            this.lblSegundoLlamado.Name = "lblSegundoLlamado";
            this.lblSegundoLlamado.Size = new System.Drawing.Size(92, 13);
            this.lblSegundoLlamado.TabIndex = 7;
            this.lblSegundoLlamado.Text = "Segundo llamado:";
            // 
            // groupBoxFechas
            // 
            this.groupBoxFechas.Controls.Add(this.checkSegundoLlamado);
            this.groupBoxFechas.Controls.Add(this.lblSegundoLlamado);
            this.groupBoxFechas.Controls.Add(this.lblPrimerLlamado);
            this.groupBoxFechas.Controls.Add(this.dtmSegundoLLamado);
            this.groupBoxFechas.Controls.Add(this.dtmPrimerLlamado);
            this.groupBoxFechas.Location = new System.Drawing.Point(22, 140);
            this.groupBoxFechas.Name = "groupBoxFechas";
            this.groupBoxFechas.Size = new System.Drawing.Size(282, 224);
            this.groupBoxFechas.TabIndex = 8;
            this.groupBoxFechas.TabStop = false;
            this.groupBoxFechas.Text = "Fechas";
            // 
            // checkSegundoLlamado
            // 
            this.checkSegundoLlamado.AutoSize = true;
            this.checkSegundoLlamado.Location = new System.Drawing.Point(10, 127);
            this.checkSegundoLlamado.Name = "checkSegundoLlamado";
            this.checkSegundoLlamado.Size = new System.Drawing.Size(156, 17);
            this.checkSegundoLlamado.TabIndex = 8;
            this.checkSegundoLlamado.Text = "Ingresar Segundo Llamado:";
            this.checkSegundoLlamado.UseVisualStyleBackColor = true;
            this.checkSegundoLlamado.CheckedChanged += new System.EventHandler(this.checkSegundoLlamado_CheckedChanged);
            // 
            // groupBoxTurnos
            // 
            this.groupBoxTurnos.Controls.Add(this.rdbtnTurnoMañana);
            this.groupBoxTurnos.Controls.Add(this.rdbtnTurnoNoche);
            this.groupBoxTurnos.Location = new System.Drawing.Point(22, 79);
            this.groupBoxTurnos.Name = "groupBoxTurnos";
            this.groupBoxTurnos.Size = new System.Drawing.Size(282, 55);
            this.groupBoxTurnos.TabIndex = 9;
            this.groupBoxTurnos.TabStop = false;
            this.groupBoxTurnos.Text = "Turnos";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(22, 388);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(119, 35);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(180, 388);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 35);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // TurnosRendir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 452);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBoxTurnos);
            this.Controls.Add(this.groupBoxFechas);
            this.Controls.Add(this.txtMateriaSeleccionada);
            this.Controls.Add(this.lblMateriaSeleccionada);
            this.Name = "TurnosRendir";
            this.Text = "TurnosRendir";
            this.Load += new System.EventHandler(this.TurnosRendir_Load);
            this.groupBoxFechas.ResumeLayout(false);
            this.groupBoxFechas.PerformLayout();
            this.groupBoxTurnos.ResumeLayout(false);
            this.groupBoxTurnos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMateriaSeleccionada;
        private System.Windows.Forms.TextBox txtMateriaSeleccionada;
        private System.Windows.Forms.RadioButton rdbtnTurnoMañana;
        private System.Windows.Forms.RadioButton rdbtnTurnoNoche;
        private System.Windows.Forms.DateTimePicker dtmPrimerLlamado;
        private System.Windows.Forms.DateTimePicker dtmSegundoLLamado;
        private System.Windows.Forms.Label lblPrimerLlamado;
        private System.Windows.Forms.Label lblSegundoLlamado;
        private System.Windows.Forms.GroupBox groupBoxFechas;
        private System.Windows.Forms.GroupBox groupBoxTurnos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox checkSegundoLlamado;
    }
}