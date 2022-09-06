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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.dtgInfo = new System.Windows.Forms.DataGridView();
            this.lblLogo = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.tsmArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNuevo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNuevo_txt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNuevo_rtf = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNuevo_csv = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNuevo_xml = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBorrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBorrar_txt = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBorrar_rtf = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBorrar_csv = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBorrar_xml = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmModificar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFuente = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmColor = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdCrear = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblColumnas = new System.Windows.Forms.Label();
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.rtbInfo = new System.Windows.Forms.RichTextBox();
            this.fuente = new System.Windows.Forms.FontDialog();
            this.color = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfo)).BeginInit();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.Location = new System.Drawing.Point(12, 39);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInfo.Size = new System.Drawing.Size(750, 446);
            this.txtInfo.TabIndex = 10;
            this.txtInfo.Visible = false;
            // 
            // dtgInfo
            // 
            this.dtgInfo.AllowDrop = true;
            this.dtgInfo.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgInfo.Location = new System.Drawing.Point(12, 39);
            this.dtgInfo.Name = "dtgInfo";
            this.dtgInfo.ReadOnly = true;
            this.dtgInfo.Size = new System.Drawing.Size(750, 446);
            this.dtgInfo.TabIndex = 11;
            this.dtgInfo.Visible = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogo.Font = new System.Drawing.Font("Lucida Handwriting", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLogo.Location = new System.Drawing.Point(107, 211);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(559, 104);
            this.lblLogo.TabIndex = 12;
            this.lblLogo.Text = "ReadLater!";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmArchivo,
            this.modificarToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(774, 24);
            this.menu.TabIndex = 17;
            this.menu.Text = "menuStrip1";
            // 
            // tsmArchivo
            // 
            this.tsmArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAbrir,
            this.tsmGuardar,
            this.tsmNuevo,
            this.tsmBorrar,
            this.tsmSalir});
            this.tsmArchivo.Name = "tsmArchivo";
            this.tsmArchivo.Size = new System.Drawing.Size(60, 20);
            this.tsmArchivo.Text = "Archivo";
            // 
            // tsmAbrir
            // 
            this.tsmAbrir.Name = "tsmAbrir";
            this.tsmAbrir.Size = new System.Drawing.Size(116, 22);
            this.tsmAbrir.Text = "Abrir";
            this.tsmAbrir.Click += new System.EventHandler(this.tsmAbrir_Click);
            // 
            // tsmGuardar
            // 
            this.tsmGuardar.Name = "tsmGuardar";
            this.tsmGuardar.Size = new System.Drawing.Size(116, 22);
            this.tsmGuardar.Text = "Guardar";
            this.tsmGuardar.Click += new System.EventHandler(this.tsmGuardar_Click);
            // 
            // tsmNuevo
            // 
            this.tsmNuevo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmNuevo_txt,
            this.tsmNuevo_rtf,
            this.tsmNuevo_csv,
            this.tsmNuevo_xml});
            this.tsmNuevo.Name = "tsmNuevo";
            this.tsmNuevo.Size = new System.Drawing.Size(116, 22);
            this.tsmNuevo.Text = "Nuevo";
            // 
            // tsmNuevo_txt
            // 
            this.tsmNuevo_txt.Name = "tsmNuevo_txt";
            this.tsmNuevo_txt.Size = new System.Drawing.Size(98, 22);
            this.tsmNuevo_txt.Text = "TXT";
            this.tsmNuevo_txt.Click += new System.EventHandler(this.tsmNuevo_txt_Click);
            // 
            // tsmNuevo_rtf
            // 
            this.tsmNuevo_rtf.Name = "tsmNuevo_rtf";
            this.tsmNuevo_rtf.Size = new System.Drawing.Size(98, 22);
            this.tsmNuevo_rtf.Text = "RTF";
            this.tsmNuevo_rtf.Click += new System.EventHandler(this.tsmNuevo_rtf_Click);
            // 
            // tsmNuevo_csv
            // 
            this.tsmNuevo_csv.Name = "tsmNuevo_csv";
            this.tsmNuevo_csv.Size = new System.Drawing.Size(98, 22);
            this.tsmNuevo_csv.Text = "CSV";
            this.tsmNuevo_csv.Click += new System.EventHandler(this.tsmNuevo_csv_Click);
            // 
            // tsmNuevo_xml
            // 
            this.tsmNuevo_xml.Name = "tsmNuevo_xml";
            this.tsmNuevo_xml.Size = new System.Drawing.Size(98, 22);
            this.tsmNuevo_xml.Text = "XML";
            this.tsmNuevo_xml.Click += new System.EventHandler(this.tsmNuevo_xml_Click);
            // 
            // tsmBorrar
            // 
            this.tsmBorrar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBorrar_txt,
            this.tsmBorrar_rtf,
            this.tsmBorrar_csv,
            this.tsmBorrar_xml});
            this.tsmBorrar.Name = "tsmBorrar";
            this.tsmBorrar.Size = new System.Drawing.Size(116, 22);
            this.tsmBorrar.Text = "Borrar";
            // 
            // tsmBorrar_txt
            // 
            this.tsmBorrar_txt.Name = "tsmBorrar_txt";
            this.tsmBorrar_txt.Size = new System.Drawing.Size(133, 22);
            this.tsmBorrar_txt.Text = "Borrar TXT";
            this.tsmBorrar_txt.Click += new System.EventHandler(this.tsmBorrar_txt_Click);
            // 
            // tsmBorrar_rtf
            // 
            this.tsmBorrar_rtf.Name = "tsmBorrar_rtf";
            this.tsmBorrar_rtf.Size = new System.Drawing.Size(133, 22);
            this.tsmBorrar_rtf.Text = "Borrar RTF";
            this.tsmBorrar_rtf.Click += new System.EventHandler(this.tsmBorrar_rtf_Click);
            // 
            // tsmBorrar_csv
            // 
            this.tsmBorrar_csv.Name = "tsmBorrar_csv";
            this.tsmBorrar_csv.Size = new System.Drawing.Size(133, 22);
            this.tsmBorrar_csv.Text = "Borrar CSV";
            this.tsmBorrar_csv.Click += new System.EventHandler(this.tsmBorrar_csv_Click);
            // 
            // tsmBorrar_xml
            // 
            this.tsmBorrar_xml.Name = "tsmBorrar_xml";
            this.tsmBorrar_xml.Size = new System.Drawing.Size(133, 22);
            this.tsmBorrar_xml.Text = "Borrar XML";
            this.tsmBorrar_xml.Click += new System.EventHandler(this.tsmBorrar_xml_Click);
            // 
            // tsmSalir
            // 
            this.tsmSalir.Name = "tsmSalir";
            this.tsmSalir.Size = new System.Drawing.Size(116, 22);
            this.tsmSalir.Text = "Salir";
            this.tsmSalir.Click += new System.EventHandler(this.tsmSalir_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmModificar,
            this.tsmFuente,
            this.tsmColor});
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.modificarToolStripMenuItem.Text = "Edicion";
            // 
            // tsmModificar
            // 
            this.tsmModificar.Enabled = false;
            this.tsmModificar.Name = "tsmModificar";
            this.tsmModificar.Size = new System.Drawing.Size(180, 22);
            this.tsmModificar.Text = "Modificar";
            this.tsmModificar.Click += new System.EventHandler(this.tsmModificar_Click);
            // 
            // tsmFuente
            // 
            this.tsmFuente.Enabled = false;
            this.tsmFuente.Name = "tsmFuente";
            this.tsmFuente.Size = new System.Drawing.Size(180, 22);
            this.tsmFuente.Text = "Fuente";
            this.tsmFuente.Click += new System.EventHandler(this.tsmFuente_Click);
            // 
            // tsmColor
            // 
            this.tsmColor.Enabled = false;
            this.tsmColor.Name = "tsmColor";
            this.tsmColor.Size = new System.Drawing.Size(180, 22);
            this.tsmColor.Text = "Color";
            this.tsmColor.Click += new System.EventHandler(this.tsmColor_Click);
            // 
            // cmdCrear
            // 
            this.cmdCrear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmdCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdCrear.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCrear.Location = new System.Drawing.Point(319, 339);
            this.cmdCrear.Name = "cmdCrear";
            this.cmdCrear.Size = new System.Drawing.Size(127, 35);
            this.cmdCrear.TabIndex = 3;
            this.cmdCrear.Text = "Crear";
            this.cmdCrear.UseVisualStyleBackColor = false;
            this.cmdCrear.Visible = false;
            this.cmdCrear.Click += new System.EventHandler(this.cmdCrear_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.Color.Transparent;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblNombre.Location = new System.Drawing.Point(319, 210);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(132, 16);
            this.lblNombre.TabIndex = 27;
            this.lblNombre.Text = "Ingrese el nombre";
            this.lblNombre.Visible = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.Location = new System.Drawing.Point(319, 239);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(128, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Visible = false;
            // 
            // lblColumnas
            // 
            this.lblColumnas.AutoSize = true;
            this.lblColumnas.BackColor = System.Drawing.Color.Transparent;
            this.lblColumnas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumnas.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblColumnas.Location = new System.Drawing.Point(307, 274);
            this.lblColumnas.Name = "lblColumnas";
            this.lblColumnas.Size = new System.Drawing.Size(154, 16);
            this.lblColumnas.TabIndex = 30;
            this.lblColumnas.Text = "Numero de colomnas";
            this.lblColumnas.Visible = false;
            // 
            // txtColumnas
            // 
            this.txtColumnas.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtColumnas.Location = new System.Drawing.Point(356, 305);
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.Size = new System.Drawing.Size(60, 20);
            this.txtColumnas.TabIndex = 2;
            this.txtColumnas.Visible = false;
            // 
            // rtbInfo
            // 
            this.rtbInfo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rtbInfo.Location = new System.Drawing.Point(12, 39);
            this.rtbInfo.Name = "rtbInfo";
            this.rtbInfo.ReadOnly = true;
            this.rtbInfo.Size = new System.Drawing.Size(750, 446);
            this.rtbInfo.TabIndex = 31;
            this.rtbInfo.Text = "";
            this.rtbInfo.Visible = false;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(774, 497);
            this.Controls.Add(this.lblColumnas);
            this.Controls.Add(this.txtColumnas);
            this.Controls.Add(this.cmdCrear);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.rtbInfo);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.dtgInfo);
            this.Controls.Add(this.lblLogo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Editor";
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfo)).EndInit();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem tsmArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmNuevo;
        private System.Windows.Forms.ToolStripMenuItem tsmAbrir;
        private System.Windows.Forms.ToolStripMenuItem tsmGuardar;
        private System.Windows.Forms.ToolStripMenuItem tsmSalir;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmBorrar;
        private System.Windows.Forms.ToolStripMenuItem tsmNuevo_txt;
        private System.Windows.Forms.ToolStripMenuItem tsmNuevo_rtf;
        private System.Windows.Forms.ToolStripMenuItem tsmNuevo_csv;
        private System.Windows.Forms.ToolStripMenuItem tsmNuevo_xml;
        public System.Windows.Forms.TextBox txtInfo;
        public System.Windows.Forms.DataGridView dtgInfo;
        private System.Windows.Forms.Button cmdCrear;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ToolStripMenuItem tsmBorrar_txt;
        private System.Windows.Forms.ToolStripMenuItem tsmBorrar_rtf;
        private System.Windows.Forms.ToolStripMenuItem tsmBorrar_csv;
        private System.Windows.Forms.ToolStripMenuItem tsmBorrar_xml;
        private System.Windows.Forms.Label lblColumnas;
        private System.Windows.Forms.TextBox txtColumnas;
        private System.Windows.Forms.ToolStripMenuItem tsmModificar;
        private System.Windows.Forms.ToolStripMenuItem tsmFuente;
        private System.Windows.Forms.ToolStripMenuItem tsmColor;
        private System.Windows.Forms.RichTextBox rtbInfo;
        private System.Windows.Forms.FontDialog fuente;
        private System.Windows.Forms.ColorDialog color;
    }
}

