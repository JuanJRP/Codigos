namespace Banco_de_Sangre
{
    partial class Blood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Blood));
            this.picWhite = new System.Windows.Forms.PictureBox();
            this.cmdInicio = new System.Windows.Forms.Button();
            this.cmdDonantes = new System.Windows.Forms.Button();
            this.cmdDonaciones = new System.Windows.Forms.Button();
            this.cmdPeticiones = new System.Windows.Forms.Button();
            this.cmdEntregados = new System.Windows.Forms.Button();
            this.cmdUsuarios = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.lblAp = new System.Windows.Forms.Label();
            this.lblBp = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.lblABp = new System.Windows.Forms.Label();
            this.lblAn = new System.Windows.Forms.Label();
            this.lblBn = new System.Windows.Forms.Label();
            this.lblOn = new System.Windows.Forms.Label();
            this.lblABn = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.dgrivTablas = new System.Windows.Forms.DataGridView();
            this.cmdAñadir = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.cmdBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrivTablas)).BeginInit();
            this.SuspendLayout();
            // 
            // picWhite
            // 
            this.picWhite.BackColor = System.Drawing.SystemColors.Window;
            this.picWhite.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picWhite.BackgroundImage")));
            this.picWhite.Location = new System.Drawing.Point(205, 12);
            this.picWhite.Name = "picWhite";
            this.picWhite.Size = new System.Drawing.Size(583, 426);
            this.picWhite.TabIndex = 0;
            this.picWhite.TabStop = false;
            // 
            // cmdInicio
            // 
            this.cmdInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdInicio.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdInicio.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdInicio.Location = new System.Drawing.Point(12, 12);
            this.cmdInicio.Name = "cmdInicio";
            this.cmdInicio.Size = new System.Drawing.Size(179, 32);
            this.cmdInicio.TabIndex = 1;
            this.cmdInicio.Text = "Inicio";
            this.cmdInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdInicio.UseVisualStyleBackColor = false;
            this.cmdInicio.Click += new System.EventHandler(this.cmdInicio_Click);
            // 
            // cmdDonantes
            // 
            this.cmdDonantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdDonantes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdDonantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDonantes.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmdDonantes.Location = new System.Drawing.Point(12, 44);
            this.cmdDonantes.Name = "cmdDonantes";
            this.cmdDonantes.Size = new System.Drawing.Size(179, 32);
            this.cmdDonantes.TabIndex = 2;
            this.cmdDonantes.Text = "Donantes";
            this.cmdDonantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdDonantes.UseVisualStyleBackColor = false;
            this.cmdDonantes.Click += new System.EventHandler(this.cmdDonantes_Click);
            // 
            // cmdDonaciones
            // 
            this.cmdDonaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdDonaciones.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdDonaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDonaciones.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmdDonaciones.Location = new System.Drawing.Point(12, 76);
            this.cmdDonaciones.Name = "cmdDonaciones";
            this.cmdDonaciones.Size = new System.Drawing.Size(179, 32);
            this.cmdDonaciones.TabIndex = 3;
            this.cmdDonaciones.Text = "Donaciones de sangre";
            this.cmdDonaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdDonaciones.UseVisualStyleBackColor = false;
            this.cmdDonaciones.Click += new System.EventHandler(this.cmdDonaciones_Click);
            // 
            // cmdPeticiones
            // 
            this.cmdPeticiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdPeticiones.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdPeticiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdPeticiones.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmdPeticiones.Location = new System.Drawing.Point(12, 108);
            this.cmdPeticiones.Name = "cmdPeticiones";
            this.cmdPeticiones.Size = new System.Drawing.Size(179, 32);
            this.cmdPeticiones.TabIndex = 4;
            this.cmdPeticiones.Text = "Peticiones";
            this.cmdPeticiones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdPeticiones.UseVisualStyleBackColor = false;
            this.cmdPeticiones.Click += new System.EventHandler(this.cmdPeticiones_Click);
            // 
            // cmdEntregados
            // 
            this.cmdEntregados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdEntregados.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdEntregados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdEntregados.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmdEntregados.Location = new System.Drawing.Point(12, 140);
            this.cmdEntregados.Name = "cmdEntregados";
            this.cmdEntregados.Size = new System.Drawing.Size(179, 32);
            this.cmdEntregados.TabIndex = 5;
            this.cmdEntregados.Text = "Entregas";
            this.cmdEntregados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdEntregados.UseVisualStyleBackColor = false;
            this.cmdEntregados.Click += new System.EventHandler(this.cmdEntregados_Click);
            // 
            // cmdUsuarios
            // 
            this.cmdUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdUsuarios.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmdUsuarios.Location = new System.Drawing.Point(12, 172);
            this.cmdUsuarios.Name = "cmdUsuarios";
            this.cmdUsuarios.Size = new System.Drawing.Size(179, 32);
            this.cmdUsuarios.TabIndex = 6;
            this.cmdUsuarios.Text = "Usuarios";
            this.cmdUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdUsuarios.UseVisualStyleBackColor = false;
            this.cmdUsuarios.Click += new System.EventHandler(this.cmdUsuarios_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSalir.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.cmdSalir.Location = new System.Drawing.Point(12, 409);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(179, 29);
            this.cmdSalir.TabIndex = 11;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // lblAp
            // 
            this.lblAp.AutoSize = true;
            this.lblAp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lblAp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAp.Location = new System.Drawing.Point(232, 108);
            this.lblAp.Name = "lblAp";
            this.lblAp.Size = new System.Drawing.Size(18, 19);
            this.lblAp.TabIndex = 8;
            this.lblAp.Text = "0";
            // 
            // lblBp
            // 
            this.lblBp.AutoSize = true;
            this.lblBp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lblBp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBp.Location = new System.Drawing.Point(375, 108);
            this.lblBp.Name = "lblBp";
            this.lblBp.Size = new System.Drawing.Size(18, 19);
            this.lblBp.TabIndex = 9;
            this.lblBp.Text = "0";
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lblOp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.Location = new System.Drawing.Point(516, 108);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(18, 19);
            this.lblOp.TabIndex = 10;
            this.lblOp.Text = "0";
            // 
            // lblABp
            // 
            this.lblABp.AutoSize = true;
            this.lblABp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lblABp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABp.Location = new System.Drawing.Point(662, 108);
            this.lblABp.Name = "lblABp";
            this.lblABp.Size = new System.Drawing.Size(18, 19);
            this.lblABp.TabIndex = 11;
            this.lblABp.Text = "0";
            // 
            // lblAn
            // 
            this.lblAn.AutoSize = true;
            this.lblAn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lblAn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAn.Location = new System.Drawing.Point(232, 200);
            this.lblAn.Name = "lblAn";
            this.lblAn.Size = new System.Drawing.Size(18, 19);
            this.lblAn.TabIndex = 12;
            this.lblAn.Text = "0";
            // 
            // lblBn
            // 
            this.lblBn.AutoSize = true;
            this.lblBn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lblBn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBn.Location = new System.Drawing.Point(375, 200);
            this.lblBn.Name = "lblBn";
            this.lblBn.Size = new System.Drawing.Size(18, 19);
            this.lblBn.TabIndex = 13;
            this.lblBn.Text = "0";
            // 
            // lblOn
            // 
            this.lblOn.AutoSize = true;
            this.lblOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lblOn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOn.Location = new System.Drawing.Point(516, 200);
            this.lblOn.Name = "lblOn";
            this.lblOn.Size = new System.Drawing.Size(18, 19);
            this.lblOn.TabIndex = 14;
            this.lblOn.Text = "0";
            // 
            // lblABn
            // 
            this.lblABn.AutoSize = true;
            this.lblABn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.lblABn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblABn.Location = new System.Drawing.Point(662, 200);
            this.lblABn.Name = "lblABn";
            this.lblABn.Size = new System.Drawing.Size(18, 19);
            this.lblABn.TabIndex = 15;
            this.lblABn.Text = "0";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.SystemColors.Window;
            this.lblInfo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(222, 29);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(157, 22);
            this.lblInfo.TabIndex = 16;
            this.lblInfo.Text = "Sangre en litros";
            // 
            // dgrivTablas
            // 
            this.dgrivTablas.AllowUserToAddRows = false;
            this.dgrivTablas.AllowUserToDeleteRows = false;
            this.dgrivTablas.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgrivTablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrivTablas.Location = new System.Drawing.Point(205, 12);
            this.dgrivTablas.Name = "dgrivTablas";
            this.dgrivTablas.ReadOnly = true;
            this.dgrivTablas.Size = new System.Drawing.Size(583, 426);
            this.dgrivTablas.TabIndex = 20;
            this.dgrivTablas.Visible = false;
            // 
            // cmdAñadir
            // 
            this.cmdAñadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdAñadir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAñadir.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAñadir.Location = new System.Drawing.Point(12, 230);
            this.cmdAñadir.Name = "cmdAñadir";
            this.cmdAñadir.Size = new System.Drawing.Size(179, 32);
            this.cmdAñadir.TabIndex = 7;
            this.cmdAñadir.Text = "Añadir";
            this.cmdAñadir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAñadir.UseVisualStyleBackColor = false;
            this.cmdAñadir.Visible = false;
            this.cmdAñadir.Click += new System.EventHandler(this.cmdAñadir_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdModificar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdModificar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificar.Location = new System.Drawing.Point(12, 268);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(179, 32);
            this.cmdModificar.TabIndex = 8;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdModificar.UseVisualStyleBackColor = false;
            this.cmdModificar.Visible = false;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdBorrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBorrar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBorrar.Location = new System.Drawing.Point(12, 306);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(179, 32);
            this.cmdBorrar.TabIndex = 9;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdBorrar.UseVisualStyleBackColor = false;
            this.cmdBorrar.Visible = false;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // cmdBuscar
            // 
            this.cmdBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmdBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdBuscar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBuscar.Location = new System.Drawing.Point(12, 344);
            this.cmdBuscar.Name = "cmdBuscar";
            this.cmdBuscar.Size = new System.Drawing.Size(179, 32);
            this.cmdBuscar.TabIndex = 10;
            this.cmdBuscar.Text = "Buscar";
            this.cmdBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdBuscar.UseVisualStyleBackColor = false;
            this.cmdBuscar.Visible = false;
            this.cmdBuscar.Click += new System.EventHandler(this.cmdBuscar_Click);
            // 
            // Blood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdBuscar);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdAñadir);
            this.Controls.Add(this.dgrivTablas);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblABn);
            this.Controls.Add(this.lblOn);
            this.Controls.Add(this.lblBn);
            this.Controls.Add(this.lblAn);
            this.Controls.Add(this.lblABp);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.lblBp);
            this.Controls.Add(this.lblAp);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdUsuarios);
            this.Controls.Add(this.cmdEntregados);
            this.Controls.Add(this.cmdPeticiones);
            this.Controls.Add(this.cmdDonaciones);
            this.Controls.Add(this.cmdDonantes);
            this.Controls.Add(this.cmdInicio);
            this.Controls.Add(this.picWhite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Blood";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrivTablas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picWhite;
        private System.Windows.Forms.Button cmdInicio;
        private System.Windows.Forms.Button cmdDonantes;
        private System.Windows.Forms.Button cmdDonaciones;
        private System.Windows.Forms.Button cmdPeticiones;
        private System.Windows.Forms.Button cmdEntregados;
        private System.Windows.Forms.Button cmdUsuarios;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Label lblAp;
        private System.Windows.Forms.Label lblBp;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label lblABp;
        private System.Windows.Forms.Label lblAn;
        private System.Windows.Forms.Label lblBn;
        private System.Windows.Forms.Label lblOn;
        private System.Windows.Forms.Label lblABn;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.DataGridView dgrivTablas;
        private System.Windows.Forms.Button cmdAñadir;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.Button cmdBuscar;
    }
}

