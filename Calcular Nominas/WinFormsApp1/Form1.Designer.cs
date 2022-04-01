namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textNomb = new System.Windows.Forms.TextBox();
            this.textDia = new System.Windows.Forms.TextBox();
            this.textSal = new System.Windows.Forms.TextBox();
            this.textIdent = new System.Windows.Forms.TextBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnSal = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textTotalDeven = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(177, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculo Nomina Trabajador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Identificacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Asignacion Salario Dia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(177, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dias Laborados";
            // 
            // textNomb
            // 
            this.textNomb.Location = new System.Drawing.Point(328, 102);
            this.textNomb.Name = "textNomb";
            this.textNomb.Size = new System.Drawing.Size(186, 23);
            this.textNomb.TabIndex = 5;
            this.textNomb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textDia
            // 
            this.textDia.Location = new System.Drawing.Point(328, 225);
            this.textDia.Name = "textDia";
            this.textDia.Size = new System.Drawing.Size(186, 23);
            this.textDia.TabIndex = 8;
            this.textDia.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textSal
            // 
            this.textSal.Location = new System.Drawing.Point(328, 185);
            this.textSal.Name = "textSal";
            this.textSal.Size = new System.Drawing.Size(186, 23);
            this.textSal.TabIndex = 7;
            this.textSal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textIdent
            // 
            this.textIdent.Location = new System.Drawing.Point(328, 140);
            this.textIdent.Name = "textIdent";
            this.textIdent.Size = new System.Drawing.Size(186, 23);
            this.textIdent.TabIndex = 6;
            this.textIdent.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Location = new System.Drawing.Point(171, 269);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(343, 28);
            this.btnRegistro.TabIndex = 9;
            this.btnRegistro.Text = "Guardar Registro Empleado";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnSal
            // 
            this.btnSal.Location = new System.Drawing.Point(171, 298);
            this.btnSal.Name = "btnSal";
            this.btnSal.Size = new System.Drawing.Size(343, 28);
            this.btnSal.TabIndex = 10;
            this.btnSal.Text = "Calcular Salario";
            this.btnSal.UseVisualStyleBackColor = true;
            this.btnSal.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Valor Total Devengado";
            // 
            // textTotalDeven
            // 
            this.textTotalDeven.Location = new System.Drawing.Point(328, 349);
            this.textTotalDeven.Name = "textTotalDeven";
            this.textTotalDeven.Size = new System.Drawing.Size(186, 23);
            this.textTotalDeven.TabIndex = 12;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(348, 389);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(166, 28);
            this.btnSalir.TabIndex = 16;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(171, 389);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(166, 28);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.textTotalDeven);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSal);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.textIdent);
            this.Controls.Add(this.textSal);
            this.Controls.Add(this.textDia);
            this.Controls.Add(this.textNomb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textNomb;
        private TextBox textDia;
        private TextBox textSal;
        private TextBox textIdent;
        private Button btnRegistro;
        private Button btnSal;
        private Label label6;
        private TextBox textTotalDeven;
        private Button btnSalir;
        private Button btnNuevo;
        private ErrorProvider error1;
    }
}