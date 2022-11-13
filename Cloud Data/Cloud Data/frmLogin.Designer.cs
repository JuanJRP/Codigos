namespace Login_Bases_de_datos
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.plLogin = new System.Windows.Forms.Panel();
            this.cmdRegistrarse = new System.Windows.Forms.Button();
            this.cmdEntrar = new System.Windows.Forms.Button();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.plRegisto = new System.Windows.Forms.Panel();
            this.cmdResgistrar = new System.Windows.Forms.Button();
            this.cmdAtras = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.txtContraseña_r = new System.Windows.Forms.TextBox();
            this.lblContraseña_r = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.txtUsuario_r = new System.Windows.Forms.TextBox();
            this.lblUsuario_r = new System.Windows.Forms.Label();
            this.plLogin.SuspendLayout();
            this.plRegisto.SuspendLayout();
            this.SuspendLayout();
            // 
            // plLogin
            // 
            this.plLogin.BackColor = System.Drawing.Color.Snow;
            this.plLogin.Controls.Add(this.cmdRegistrarse);
            this.plLogin.Controls.Add(this.cmdEntrar);
            this.plLogin.Controls.Add(this.lblLogin);
            this.plLogin.Controls.Add(this.lblContraseña);
            this.plLogin.Controls.Add(this.txtUsuario);
            this.plLogin.Controls.Add(this.txtContraseña);
            this.plLogin.Controls.Add(this.lblUsuario);
            this.plLogin.Location = new System.Drawing.Point(249, 74);
            this.plLogin.Name = "plLogin";
            this.plLogin.Size = new System.Drawing.Size(302, 302);
            this.plLogin.TabIndex = 9;
            // 
            // cmdRegistrarse
            // 
            this.cmdRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdRegistrarse.Location = new System.Drawing.Point(161, 230);
            this.cmdRegistrarse.Name = "cmdRegistrarse";
            this.cmdRegistrarse.Size = new System.Drawing.Size(118, 23);
            this.cmdRegistrarse.TabIndex = 7;
            this.cmdRegistrarse.Text = "Registrarse";
            this.cmdRegistrarse.UseVisualStyleBackColor = true;
            this.cmdRegistrarse.Click += new System.EventHandler(this.cmdRegistrarse_Click);
            // 
            // cmdEntrar
            // 
            this.cmdEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdEntrar.Location = new System.Drawing.Point(21, 230);
            this.cmdEntrar.Name = "cmdEntrar";
            this.cmdEntrar.Size = new System.Drawing.Size(118, 23);
            this.cmdEntrar.TabIndex = 6;
            this.cmdEntrar.Text = "Entrar";
            this.cmdEntrar.UseVisualStyleBackColor = true;
            this.cmdEntrar.Click += new System.EventHandler(this.cmdEntrar_Click);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.BackColor = System.Drawing.Color.Snow;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(121, 30);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(62, 24);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Snow;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(18, 152);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(71, 13);
            this.lblContraseña.TabIndex = 5;
            this.lblContraseña.Text = "Contraseña";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.Snow;
            this.txtUsuario.Location = new System.Drawing.Point(21, 105);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(258, 20);
            this.txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.Snow;
            this.txtContraseña.Location = new System.Drawing.Point(21, 168);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(258, 20);
            this.txtContraseña.TabIndex = 4;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Snow;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(18, 89);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // plRegisto
            // 
            this.plRegisto.BackColor = System.Drawing.Color.Snow;
            this.plRegisto.Controls.Add(this.cmdResgistrar);
            this.plRegisto.Controls.Add(this.cmdAtras);
            this.plRegisto.Controls.Add(this.txtTelefono);
            this.plRegisto.Controls.Add(this.lblTelefono);
            this.plRegisto.Controls.Add(this.txtCorreo);
            this.plRegisto.Controls.Add(this.lblCorreo);
            this.plRegisto.Controls.Add(this.txtContraseña_r);
            this.plRegisto.Controls.Add(this.lblContraseña_r);
            this.plRegisto.Controls.Add(this.lblRegistro);
            this.plRegisto.Controls.Add(this.txtUsuario_r);
            this.plRegisto.Controls.Add(this.lblUsuario_r);
            this.plRegisto.Location = new System.Drawing.Point(150, 39);
            this.plRegisto.Name = "plRegisto";
            this.plRegisto.Size = new System.Drawing.Size(501, 373);
            this.plRegisto.TabIndex = 10;
            this.plRegisto.Visible = false;
            // 
            // cmdResgistrar
            // 
            this.cmdResgistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdResgistrar.Location = new System.Drawing.Point(292, 268);
            this.cmdResgistrar.Name = "cmdResgistrar";
            this.cmdResgistrar.Size = new System.Drawing.Size(164, 23);
            this.cmdResgistrar.TabIndex = 10;
            this.cmdResgistrar.Text = "Registrar";
            this.cmdResgistrar.UseVisualStyleBackColor = true;
            this.cmdResgistrar.Click += new System.EventHandler(this.cmdResgistrar_Click);
            // 
            // cmdAtras
            // 
            this.cmdAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAtras.Location = new System.Drawing.Point(53, 268);
            this.cmdAtras.Name = "cmdAtras";
            this.cmdAtras.Size = new System.Drawing.Size(164, 23);
            this.cmdAtras.TabIndex = 9;
            this.cmdAtras.Text = "Atrás";
            this.cmdAtras.UseVisualStyleBackColor = true;
            this.cmdAtras.Click += new System.EventHandler(this.cmdAtras_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.BackColor = System.Drawing.Color.Snow;
            this.txtTelefono.Location = new System.Drawing.Point(292, 192);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(164, 20);
            this.txtTelefono.TabIndex = 8;
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(289, 169);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(57, 13);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Telefono";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.Snow;
            this.txtCorreo.Location = new System.Drawing.Point(292, 124);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(164, 20);
            this.txtCorreo.TabIndex = 6;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(289, 101);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(44, 13);
            this.lblCorreo.TabIndex = 5;
            this.lblCorreo.Text = "Correo";
            // 
            // txtContraseña_r
            // 
            this.txtContraseña_r.BackColor = System.Drawing.Color.Snow;
            this.txtContraseña_r.Location = new System.Drawing.Point(53, 192);
            this.txtContraseña_r.Name = "txtContraseña_r";
            this.txtContraseña_r.Size = new System.Drawing.Size(164, 20);
            this.txtContraseña_r.TabIndex = 4;
            // 
            // lblContraseña_r
            // 
            this.lblContraseña_r.AutoSize = true;
            this.lblContraseña_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña_r.Location = new System.Drawing.Point(50, 169);
            this.lblContraseña_r.Name = "lblContraseña_r";
            this.lblContraseña_r.Size = new System.Drawing.Size(71, 13);
            this.lblContraseña_r.TabIndex = 3;
            this.lblContraseña_r.Text = "Contraseña";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(205, 26);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(87, 24);
            this.lblRegistro.TabIndex = 2;
            this.lblRegistro.Text = "Registro";
            // 
            // txtUsuario_r
            // 
            this.txtUsuario_r.BackColor = System.Drawing.Color.Snow;
            this.txtUsuario_r.Location = new System.Drawing.Point(53, 124);
            this.txtUsuario_r.Name = "txtUsuario_r";
            this.txtUsuario_r.Size = new System.Drawing.Size(164, 20);
            this.txtUsuario_r.TabIndex = 1;
            // 
            // lblUsuario_r
            // 
            this.lblUsuario_r.AutoSize = true;
            this.lblUsuario_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario_r.Location = new System.Drawing.Point(50, 101);
            this.lblUsuario_r.Name = "lblUsuario_r";
            this.lblUsuario_r.Size = new System.Drawing.Size(50, 13);
            this.lblUsuario_r.TabIndex = 0;
            this.lblUsuario_r.Text = "Usuario";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cloud_Data.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.plRegisto);
            this.Controls.Add(this.plLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmLogin_FormClosed);
            this.plLogin.ResumeLayout(false);
            this.plLogin.PerformLayout();
            this.plRegisto.ResumeLayout(false);
            this.plRegisto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel plLogin;
        private System.Windows.Forms.Button cmdRegistrarse;
        private System.Windows.Forms.Button cmdEntrar;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Panel plRegisto;
        private System.Windows.Forms.Button cmdResgistrar;
        private System.Windows.Forms.Button cmdAtras;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.TextBox txtContraseña_r;
        private System.Windows.Forms.Label lblContraseña_r;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.TextBox txtUsuario_r;
        private System.Windows.Forms.Label lblUsuario_r;
    }
}

