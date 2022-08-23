namespace Archivos_Planos
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.cmdLeer = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdCrear = new System.Windows.Forms.Button();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdGuardar = new System.Windows.Forms.Button();
            this.cmdOpcion = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Location = new System.Drawing.Point(158, 12);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(604, 473);
            this.txtInfo.TabIndex = 10;
            // 
            // cmdLeer
            // 
            this.cmdLeer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdLeer.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cmdLeer.FlatAppearance.BorderSize = 0;
            this.cmdLeer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.cmdLeer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.cmdLeer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdLeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLeer.ForeColor = System.Drawing.Color.Black;
            this.cmdLeer.Location = new System.Drawing.Point(12, 12);
            this.cmdLeer.Name = "cmdLeer";
            this.cmdLeer.Size = new System.Drawing.Size(128, 42);
            this.cmdLeer.TabIndex = 1;
            this.cmdLeer.Text = "Leer";
            this.cmdLeer.UseVisualStyleBackColor = false;
            this.cmdLeer.Click += new System.EventHandler(this.cmdLeer_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdModificar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cmdModificar.FlatAppearance.BorderSize = 0;
            this.cmdModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificar.ForeColor = System.Drawing.Color.Black;
            this.cmdModificar.Location = new System.Drawing.Point(12, 59);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(128, 42);
            this.cmdModificar.TabIndex = 2;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = false;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdCrear
            // 
            this.cmdCrear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdCrear.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cmdCrear.FlatAppearance.BorderSize = 0;
            this.cmdCrear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCrear.ForeColor = System.Drawing.Color.Black;
            this.cmdCrear.Location = new System.Drawing.Point(12, 107);
            this.cmdCrear.Name = "cmdCrear";
            this.cmdCrear.Size = new System.Drawing.Size(128, 42);
            this.cmdCrear.TabIndex = 3;
            this.cmdCrear.Text = "Crear";
            this.cmdCrear.UseVisualStyleBackColor = false;
            this.cmdCrear.Click += new System.EventHandler(this.cmdCrear_Click);
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdBorrar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cmdBorrar.FlatAppearance.BorderSize = 0;
            this.cmdBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBorrar.ForeColor = System.Drawing.Color.Black;
            this.cmdBorrar.Location = new System.Drawing.Point(12, 153);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(128, 42);
            this.cmdBorrar.TabIndex = 4;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = false;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdSalir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cmdSalir.FlatAppearance.BorderSize = 0;
            this.cmdSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSalir.ForeColor = System.Drawing.Color.Black;
            this.cmdSalir.Location = new System.Drawing.Point(12, 443);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(128, 42);
            this.cmdSalir.TabIndex = 9;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdGuardar
            // 
            this.cmdGuardar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdGuardar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cmdGuardar.FlatAppearance.BorderSize = 0;
            this.cmdGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdGuardar.ForeColor = System.Drawing.Color.Black;
            this.cmdGuardar.Location = new System.Drawing.Point(12, 214);
            this.cmdGuardar.Name = "cmdGuardar";
            this.cmdGuardar.Size = new System.Drawing.Size(128, 42);
            this.cmdGuardar.TabIndex = 5;
            this.cmdGuardar.Text = "Guardar";
            this.cmdGuardar.UseVisualStyleBackColor = false;
            this.cmdGuardar.Visible = false;
            this.cmdGuardar.Click += new System.EventHandler(this.cmdGuardar_Click);
            // 
            // cmdOpcion
            // 
            this.cmdOpcion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdOpcion.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.cmdOpcion.FlatAppearance.BorderSize = 0;
            this.cmdOpcion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmdOpcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdOpcion.ForeColor = System.Drawing.Color.Black;
            this.cmdOpcion.Location = new System.Drawing.Point(12, 334);
            this.cmdOpcion.Name = "cmdOpcion";
            this.cmdOpcion.Size = new System.Drawing.Size(128, 42);
            this.cmdOpcion.TabIndex = 8;
            this.cmdOpcion.UseVisualStyleBackColor = false;
            this.cmdOpcion.Visible = false;
            this.cmdOpcion.Click += new System.EventHandler(this.cmdOpcion_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.Location = new System.Drawing.Point(12, 299);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 20);
            this.txtNombre.TabIndex = 7;
            this.txtNombre.Visible = false;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Location = new System.Drawing.Point(12, 270);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(132, 16);
            this.lblNombre.TabIndex = 10;
            this.lblNombre.Text = "Ingrese el nombre";
            this.lblNombre.Visible = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(774, 497);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmdOpcion);
            this.Controls.Add(this.cmdGuardar);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.cmdCrear);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdLeer);
            this.Controls.Add(this.txtInfo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button cmdLeer;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdCrear;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdGuardar;
        private System.Windows.Forms.Button cmdOpcion;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.OpenFileDialog openFile;
    }
}

