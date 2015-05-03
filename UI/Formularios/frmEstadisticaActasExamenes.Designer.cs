namespace UTN.SistemaAlumnos.UI.Formularios
{
      partial class frmEstadisticaActasExamenes
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
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.txtDesde = new System.Windows.Forms.TextBox();
            this.txtxHasta = new System.Windows.Forms.TextBox();
            this.gbxBusqueda = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtPeriodo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtUnActa = new System.Windows.Forms.RadioButton();
            this.txtActa = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.gbxResultadosBusqueda = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTomo = new System.Windows.Forms.TextBox();
            this.dgvResultadoBusqueda = new System.Windows.Forms.DataGridView();
            this.gbxBusqueda.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxResultadosBusqueda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(3, 55);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(41, 13);
            this.lblDesde.TabIndex = 1;
            this.lblDesde.Text = "Desde:";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(285, 55);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(38, 13);
            this.lblHasta.TabIndex = 2;
            this.lblHasta.Text = "Hasta:";
            // 
            // txtDesde
            // 
            this.txtDesde.Location = new System.Drawing.Point(87, 51);
            this.txtDesde.Name = "txtDesde";
            this.txtDesde.Size = new System.Drawing.Size(137, 20);
            this.txtDesde.TabIndex = 4;
            // 
            // txtxHasta
            // 
            this.txtxHasta.Location = new System.Drawing.Point(346, 51);
            this.txtxHasta.Name = "txtxHasta";
            this.txtxHasta.Size = new System.Drawing.Size(137, 20);
            this.txtxHasta.TabIndex = 5;
            // 
            // gbxBusqueda
            // 
            this.gbxBusqueda.Controls.Add(this.groupBox2);
            this.gbxBusqueda.Controls.Add(this.groupBox1);
            this.gbxBusqueda.Controls.Add(this.btnBuscar);
            this.gbxBusqueda.Location = new System.Drawing.Point(18, 12);
            this.gbxBusqueda.Name = "gbxBusqueda";
            this.gbxBusqueda.Size = new System.Drawing.Size(517, 247);
            this.gbxBusqueda.TabIndex = 6;
            this.gbxBusqueda.TabStop = false;
            this.gbxBusqueda.Text = "Criterios de búsqueda";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtPeriodo);
            this.groupBox2.Controls.Add(this.lblDesde);
            this.groupBox2.Controls.Add(this.txtxHasta);
            this.groupBox2.Controls.Add(this.lblHasta);
            this.groupBox2.Controls.Add(this.txtDesde);
            this.groupBox2.Location = new System.Drawing.Point(6, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(502, 92);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acta Exámen por Período";
            // 
            // rbtPeriodo
            // 
            this.rbtPeriodo.AutoSize = true;
            this.rbtPeriodo.Location = new System.Drawing.Point(6, 19);
            this.rbtPeriodo.Name = "rbtPeriodo";
            this.rbtPeriodo.Size = new System.Drawing.Size(104, 17);
            this.rbtPeriodo.TabIndex = 2;
            this.rbtPeriodo.TabStop = true;
            this.rbtPeriodo.Text = "Acta por Periodo";
            this.rbtPeriodo.UseVisualStyleBackColor = true;
            this.rbtPeriodo.CheckedChanged += new System.EventHandler(this.rbtPeriodo_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTomo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbtUnActa);
            this.groupBox1.Controls.Add(this.txtActa);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 89);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acta Exámen";
            // 
            // rbtUnActa
            // 
            this.rbtUnActa.AutoSize = true;
            this.rbtUnActa.Location = new System.Drawing.Point(6, 22);
            this.rbtUnActa.Name = "rbtUnActa";
            this.rbtUnActa.Size = new System.Drawing.Size(85, 17);
            this.rbtUnActa.TabIndex = 1;
            this.rbtUnActa.TabStop = true;
            this.rbtUnActa.Text = "Acta y Tomo";
            this.rbtUnActa.UseVisualStyleBackColor = true;
            this.rbtUnActa.CheckedChanged += new System.EventHandler(this.rbtUnActa_CheckedChanged);
            // 
            // txtActa
            // 
            this.txtActa.Location = new System.Drawing.Point(87, 55);
            this.txtActa.Name = "txtActa";
            this.txtActa.Size = new System.Drawing.Size(137, 20);
            this.txtActa.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(226, 218);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // gbxResultadosBusqueda
            // 
            this.gbxResultadosBusqueda.Controls.Add(this.dgvResultadoBusqueda);
            this.gbxResultadosBusqueda.Location = new System.Drawing.Point(18, 265);
            this.gbxResultadosBusqueda.Name = "gbxResultadosBusqueda";
            this.gbxResultadosBusqueda.Size = new System.Drawing.Size(517, 127);
            this.gbxResultadosBusqueda.TabIndex = 8;
            this.gbxResultadosBusqueda.TabStop = false;
            this.gbxResultadosBusqueda.Text = "Resultados de la búsqueda";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nº Acta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nº Tomo";
            // 
            // txtTomo
            // 
            this.txtTomo.Location = new System.Drawing.Point(346, 55);
            this.txtTomo.Name = "txtTomo";
            this.txtTomo.Size = new System.Drawing.Size(137, 20);
            this.txtTomo.TabIndex = 3;
            // 
            // dgvResultadoBusqueda
            // 
            this.dgvResultadoBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadoBusqueda.Location = new System.Drawing.Point(12, 19);
            this.dgvResultadoBusqueda.Name = "dgvResultadoBusqueda";
            this.dgvResultadoBusqueda.Size = new System.Drawing.Size(496, 91);
            this.dgvResultadoBusqueda.TabIndex = 0;
            // 
            // frmEstadisticaActasExamenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 404);
            this.Controls.Add(this.gbxResultadosBusqueda);
            this.Controls.Add(this.gbxBusqueda);
            this.Name = "frmEstadisticaActasExamenes";
            this.Text = "frmEstadisticaActasExamenes";
            this.Load += new System.EventHandler(this.frmEstadisticaActasExamenes_Load);
            this.gbxBusqueda.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxResultadosBusqueda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoBusqueda)).EndInit();
            this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.Label lblDesde;
            private System.Windows.Forms.Label lblHasta;
            private System.Windows.Forms.TextBox txtDesde;
            private System.Windows.Forms.TextBox txtxHasta;
            private System.Windows.Forms.GroupBox gbxBusqueda;
            private System.Windows.Forms.TextBox txtActa;
            private System.Windows.Forms.Button btnBuscar;
            private System.Windows.Forms.RadioButton rbtPeriodo;
            private System.Windows.Forms.RadioButton rbtUnActa;
            private System.Windows.Forms.GroupBox gbxResultadosBusqueda;
            private System.Windows.Forms.GroupBox groupBox2;
            private System.Windows.Forms.GroupBox groupBox1;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.TextBox txtTomo;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.DataGridView dgvResultadoBusqueda;
      }
}