namespace Jubilacion
{
    partial class FrmJubilacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.chkFemenino = new System.Windows.Forms.CheckBox();
            this.chkMasculino = new System.Windows.Forms.CheckBox();
            this.lblInformacion = new System.Windows.Forms.Label();
            this.cmdCalcular = new System.Windows.Forms.Button();
            this.erpInfo = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.erpInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 32);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(77, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(162, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(77, 70);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(162, 20);
            this.txtEdad.TabIndex = 2;
            this.txtEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEdad_KeyPress);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(24, 70);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(35, 13);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(24, 115);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 4;
            this.lblSexo.Text = "Sexo:";
            // 
            // chkFemenino
            // 
            this.chkFemenino.AutoSize = true;
            this.chkFemenino.Location = new System.Drawing.Point(77, 114);
            this.chkFemenino.Name = "chkFemenino";
            this.chkFemenino.Size = new System.Drawing.Size(72, 17);
            this.chkFemenino.TabIndex = 3;
            this.chkFemenino.Text = "Femenino";
            this.chkFemenino.UseVisualStyleBackColor = true;
            this.chkFemenino.Click += new System.EventHandler(this.chkFemenino_Click);
            // 
            // chkMasculino
            // 
            this.chkMasculino.AutoSize = true;
            this.chkMasculino.Location = new System.Drawing.Point(165, 115);
            this.chkMasculino.Name = "chkMasculino";
            this.chkMasculino.Size = new System.Drawing.Size(74, 17);
            this.chkMasculino.TabIndex = 4;
            this.chkMasculino.Text = "Masculino";
            this.chkMasculino.UseVisualStyleBackColor = true;
            this.chkMasculino.Click += new System.EventHandler(this.chkMasculino_Click);
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Location = new System.Drawing.Point(24, 152);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(0, 13);
            this.lblInformacion.TabIndex = 7;
            // 
            // cmdCalcular
            // 
            this.cmdCalcular.Location = new System.Drawing.Point(12, 415);
            this.cmdCalcular.Name = "cmdCalcular";
            this.cmdCalcular.Size = new System.Drawing.Size(268, 23);
            this.cmdCalcular.TabIndex = 8;
            this.cmdCalcular.Text = "Calcular";
            this.cmdCalcular.UseVisualStyleBackColor = true;
            this.cmdCalcular.Click += new System.EventHandler(this.cmdCalcular_Click);
            // 
            // erpInfo
            // 
            this.erpInfo.ContainerControl = this;
            // 
            // FrmJubilacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 450);
            this.Controls.Add(this.cmdCalcular);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.chkMasculino);
            this.Controls.Add(this.chkFemenino);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmJubilacion";
            this.Text = "frmInicial";
            ((System.ComponentModel.ISupportInitialize)(this.erpInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.CheckBox chkFemenino;
        private System.Windows.Forms.CheckBox chkMasculino;
        private System.Windows.Forms.Label lblInformacion;
        private System.Windows.Forms.Button cmdCalcular;
        private System.Windows.Forms.ErrorProvider erpInfo;
    }
}

