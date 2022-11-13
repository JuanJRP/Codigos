namespace Cloud_Data
{
    partial class frmDatos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatos));
            this.cmdCerrar_sesion = new System.Windows.Forms.Button();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.dtgArchivos = new System.Windows.Forms.DataGridView();
            this.dtgInfo = new System.Windows.Forms.DataGridView();
            this.cmdExportar = new System.Windows.Forms.Button();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.cmdAbrir = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArchivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdCerrar_sesion
            // 
            this.cmdCerrar_sesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCerrar_sesion.Location = new System.Drawing.Point(12, 415);
            this.cmdCerrar_sesion.Name = "cmdCerrar_sesion";
            this.cmdCerrar_sesion.Size = new System.Drawing.Size(143, 23);
            this.cmdCerrar_sesion.TabIndex = 10;
            this.cmdCerrar_sesion.Text = "Cerrar Sesión";
            this.cmdCerrar_sesion.UseVisualStyleBackColor = true;
            this.cmdCerrar_sesion.Click += new System.EventHandler(this.cmdCerrar_sesion_Click);
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.White;
            this.lblBienvenida.Location = new System.Drawing.Point(12, 33);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(70, 13);
            this.lblBienvenida.TabIndex = 12;
            this.lblBienvenida.Text = "Bienvenido";
            // 
            // dtgArchivos
            // 
            this.dtgArchivos.AllowUserToAddRows = false;
            this.dtgArchivos.AllowUserToDeleteRows = false;
            this.dtgArchivos.AllowUserToResizeColumns = false;
            this.dtgArchivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgArchivos.BackgroundColor = System.Drawing.Color.White;
            this.dtgArchivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgArchivos.Location = new System.Drawing.Point(12, 49);
            this.dtgArchivos.MultiSelect = false;
            this.dtgArchivos.Name = "dtgArchivos";
            this.dtgArchivos.ReadOnly = true;
            this.dtgArchivos.RowHeadersVisible = false;
            this.dtgArchivos.Size = new System.Drawing.Size(143, 360);
            this.dtgArchivos.TabIndex = 33;
            this.dtgArchivos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgArchivos_CellContentClick);
            // 
            // dtgInfo
            // 
            this.dtgInfo.AllowDrop = true;
            this.dtgInfo.AllowUserToAddRows = false;
            this.dtgInfo.AllowUserToDeleteRows = false;
            this.dtgInfo.BackgroundColor = System.Drawing.Color.White;
            this.dtgInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInfo.Location = new System.Drawing.Point(161, 49);
            this.dtgInfo.MultiSelect = false;
            this.dtgInfo.Name = "dtgInfo";
            this.dtgInfo.ReadOnly = true;
            this.dtgInfo.RowHeadersVisible = false;
            this.dtgInfo.Size = new System.Drawing.Size(627, 360);
            this.dtgInfo.TabIndex = 34;
            // 
            // cmdExportar
            // 
            this.cmdExportar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExportar.Location = new System.Drawing.Point(645, 415);
            this.cmdExportar.Name = "cmdExportar";
            this.cmdExportar.Size = new System.Drawing.Size(143, 23);
            this.cmdExportar.TabIndex = 35;
            this.cmdExportar.Text = "Importar";
            this.cmdExportar.UseVisualStyleBackColor = true;
            this.cmdExportar.Click += new System.EventHandler(this.cmdExportar_Click);
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdBorrar.Location = new System.Drawing.Point(472, 415);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(143, 23);
            this.cmdBorrar.TabIndex = 36;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // cmdAbrir
            // 
            this.cmdAbrir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAbrir.Location = new System.Drawing.Point(12, 7);
            this.cmdAbrir.Name = "cmdAbrir";
            this.cmdAbrir.Size = new System.Drawing.Size(143, 23);
            this.cmdAbrir.TabIndex = 37;
            this.cmdAbrir.Text = "Abrir";
            this.cmdAbrir.UseVisualStyleBackColor = true;
            this.cmdAbrir.Click += new System.EventHandler(this.cmdAbrir_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdModificar.Location = new System.Drawing.Point(161, 7);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(143, 23);
            this.cmdModificar.TabIndex = 38;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // frmDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cloud_Data.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.cmdAbrir);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.cmdExportar);
            this.Controls.Add(this.dtgInfo);
            this.Controls.Add(this.dtgArchivos);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.cmdCerrar_sesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Reader";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDatos_FormClosed);
            this.Load += new System.EventHandler(this.frmDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgArchivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdCerrar_sesion;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.DataGridView dtgArchivos;
        private System.Windows.Forms.DataGridView dtgInfo;
        private System.Windows.Forms.Button cmdExportar;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button cmdAbrir;
        private System.Windows.Forms.Button cmdModificar;
    }
}