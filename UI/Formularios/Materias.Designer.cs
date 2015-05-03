namespace UTN.SistemaAlumnos.UI.Formularios
{
    partial class Materias
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
            this.groupBoxTurnos = new System.Windows.Forms.GroupBox();
            this.radioButtonNoche = new System.Windows.Forms.RadioButton();
            this.radioButtonMañana = new System.Windows.Forms.RadioButton();
            this.groupBoxFechas = new System.Windows.Forms.GroupBox();
            this.dtmSegundoLlamado = new System.Windows.Forms.DateTimePicker();
            this.lblSegundoLlamado = new System.Windows.Forms.Label();
            this.checkSegundoLlamado = new System.Windows.Forms.CheckBox();
            this.dtmPrimerLlamado = new System.Windows.Forms.DateTimePicker();
            this.lblPrimerLlamado = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBoxTurnos.SuspendLayout();
            this.groupBoxFechas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMateriaSeleccionada
            // 
            this.lblMateriaSeleccionada.AutoSize = true;
            this.lblMateriaSeleccionada.Location = new System.Drawing.Point(21, 23);
            this.lblMateriaSeleccionada.Name = "lblMateriaSeleccionada";
            this.lblMateriaSeleccionada.Size = new System.Drawing.Size(113, 13);
            this.lblMateriaSeleccionada.TabIndex = 0;
            this.lblMateriaSeleccionada.Text = "Materia Seleccionada:";
            // 
            // txtMateriaSeleccionada
            // 
            this.txtMateriaSeleccionada.Location = new System.Drawing.Point(143, 20);
            this.txtMateriaSeleccionada.Name = "txtMateriaSeleccionada";
            this.txtMateriaSeleccionada.Size = new System.Drawing.Size(192, 20);
            this.txtMateriaSeleccionada.TabIndex = 1;
            // 
            // groupBoxTurnos
            // 
            this.groupBoxTurnos.Controls.Add(this.radioButtonNoche);
            this.groupBoxTurnos.Controls.Add(this.radioButtonMañana);
            this.groupBoxTurnos.Location = new System.Drawing.Point(24, 71);
            this.groupBoxTurnos.Name = "groupBoxTurnos";
            this.groupBoxTurnos.Size = new System.Drawing.Size(311, 66);
            this.groupBoxTurnos.TabIndex = 2;
            this.groupBoxTurnos.TabStop = false;
            this.groupBoxTurnos.Text = "Turnos";
            // 
            // radioButtonNoche
            // 
            this.radioButtonNoche.AutoSize = true;
            this.radioButtonNoche.Location = new System.Drawing.Point(204, 29);
            this.radioButtonNoche.Name = "radioButtonNoche";
            this.radioButtonNoche.Size = new System.Drawing.Size(57, 17);
            this.radioButtonNoche.TabIndex = 1;
            this.radioButtonNoche.TabStop = true;
            this.radioButtonNoche.Text = "Noche";
            this.radioButtonNoche.UseVisualStyleBackColor = true;
            // 
            // radioButtonMañana
            // 
            this.radioButtonMañana.AutoSize = true;
            this.radioButtonMañana.Location = new System.Drawing.Point(28, 29);
            this.radioButtonMañana.Name = "radioButtonMañana";
            this.radioButtonMañana.Size = new System.Drawing.Size(64, 17);
            this.radioButtonMañana.TabIndex = 0;
            this.radioButtonMañana.TabStop = true;
            this.radioButtonMañana.Text = "Mañana";
            this.radioButtonMañana.UseVisualStyleBackColor = true;
            // 
            // groupBoxFechas
            // 
            this.groupBoxFechas.Controls.Add(this.dtmSegundoLlamado);
            this.groupBoxFechas.Controls.Add(this.lblSegundoLlamado);
            this.groupBoxFechas.Controls.Add(this.checkSegundoLlamado);
            this.groupBoxFechas.Controls.Add(this.dtmPrimerLlamado);
            this.groupBoxFechas.Controls.Add(this.lblPrimerLlamado);
            this.groupBoxFechas.Location = new System.Drawing.Point(24, 160);
            this.groupBoxFechas.Name = "groupBoxFechas";
            this.groupBoxFechas.Size = new System.Drawing.Size(311, 241);
            this.groupBoxFechas.TabIndex = 3;
            this.groupBoxFechas.TabStop = false;
            this.groupBoxFechas.Text = "Fechas";
            //2015-04-26 No compila el proyecto. Esta linea genera el error. Se comenta para poder trabajar
           // this.groupBoxFechas.Enter += new System.EventHandler(this.groupBoxFechas_Enter);
            // 
            // dtmSegundoLlamado
            // 
            this.dtmSegundoLlamado.Location = new System.Drawing.Point(14, 199);
            this.dtmSegundoLlamado.Name = "dtmSegundoLlamado";
            this.dtmSegundoLlamado.Size = new System.Drawing.Size(263, 20);
            this.dtmSegundoLlamado.TabIndex = 4;
            // 
            // lblSegundoLlamado
            // 
            this.lblSegundoLlamado.AutoSize = true;
            this.lblSegundoLlamado.Location = new System.Drawing.Point(11, 165);
            this.lblSegundoLlamado.Name = "lblSegundoLlamado";
            this.lblSegundoLlamado.Size = new System.Drawing.Size(96, 13);
            this.lblSegundoLlamado.TabIndex = 3;
            this.lblSegundoLlamado.Text = "Segundo Llamado:";
            // 
            // checkSegundoLlamado
            // 
            this.checkSegundoLlamado.AutoSize = true;
            this.checkSegundoLlamado.Location = new System.Drawing.Point(14, 126);
            this.checkSegundoLlamado.Name = "checkSegundoLlamado";
            this.checkSegundoLlamado.Size = new System.Drawing.Size(153, 17);
            this.checkSegundoLlamado.TabIndex = 2;
            this.checkSegundoLlamado.Text = "Ingresar Segundo Llamado";
            this.checkSegundoLlamado.UseVisualStyleBackColor = true;
            this.checkSegundoLlamado.CheckedChanged += new System.EventHandler(this.checkSegundoLlamado_CheckedChanged);
            // 
            // dtmPrimerLlamado
            // 
            this.dtmPrimerLlamado.Location = new System.Drawing.Point(14, 67);
            this.dtmPrimerLlamado.Name = "dtmPrimerLlamado";
            this.dtmPrimerLlamado.Size = new System.Drawing.Size(263, 20);
            this.dtmPrimerLlamado.TabIndex = 1;
            // 
            // lblPrimerLlamado
            // 
            this.lblPrimerLlamado.AutoSize = true;
            this.lblPrimerLlamado.Location = new System.Drawing.Point(11, 29);
            this.lblPrimerLlamado.Name = "lblPrimerLlamado";
            this.lblPrimerLlamado.Size = new System.Drawing.Size(85, 13);
            this.lblPrimerLlamado.TabIndex = 0;
            this.lblPrimerLlamado.Text = "Primer Llamado: ";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(24, 462);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(127, 24);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(208, 462);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 24);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Materias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 514);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.groupBoxFechas);
            this.Controls.Add(this.groupBoxTurnos);
            this.Controls.Add(this.txtMateriaSeleccionada);
            this.Controls.Add(this.lblMateriaSeleccionada);
            this.Name = "Materias";
            this.Text = "Materias";
            this.groupBoxTurnos.ResumeLayout(false);
            this.groupBoxTurnos.PerformLayout();
            this.groupBoxFechas.ResumeLayout(false);
            this.groupBoxFechas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMateriaSeleccionada;
        private System.Windows.Forms.TextBox txtMateriaSeleccionada;
        private System.Windows.Forms.GroupBox groupBoxTurnos;
        private System.Windows.Forms.RadioButton radioButtonNoche;
        private System.Windows.Forms.RadioButton radioButtonMañana;
        private System.Windows.Forms.GroupBox groupBoxFechas;
        private System.Windows.Forms.DateTimePicker dtmSegundoLlamado;
        private System.Windows.Forms.Label lblSegundoLlamado;
        private System.Windows.Forms.CheckBox checkSegundoLlamado;
        private System.Windows.Forms.DateTimePicker dtmPrimerLlamado;
        private System.Windows.Forms.Label lblPrimerLlamado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
    }
}