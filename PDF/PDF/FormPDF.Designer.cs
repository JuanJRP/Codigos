namespace PDF
{
    partial class FormPDF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPDF));
            this.AcroPDF = new AxAcroPDFLib.AxAcroPDF();
            this.tsm = new System.Windows.Forms.MenuStrip();
            this.tsmAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.openF = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.AcroPDF)).BeginInit();
            this.tsm.SuspendLayout();
            this.SuspendLayout();
            // 
            // AcroPDF
            // 
            this.AcroPDF.Enabled = true;
            this.AcroPDF.Location = new System.Drawing.Point(1, 27);
            this.AcroPDF.Name = "AcroPDF";
            this.AcroPDF.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AcroPDF.OcxState")));
            this.AcroPDF.Size = new System.Drawing.Size(797, 423);
            this.AcroPDF.TabIndex = 0;
            // 
            // tsm
            // 
            this.tsm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmAbrir});
            this.tsm.Location = new System.Drawing.Point(0, 0);
            this.tsm.Name = "tsm";
            this.tsm.Size = new System.Drawing.Size(800, 24);
            this.tsm.TabIndex = 1;
            this.tsm.Text = "tsm";
            // 
            // tsmAbrir
            // 
            this.tsmAbrir.Name = "tsmAbrir";
            this.tsmAbrir.Size = new System.Drawing.Size(45, 20);
            this.tsmAbrir.Text = "Abrir";
            this.tsmAbrir.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // openF
            // 
            this.openF.FileName = "openF";
            // 
            // FormPDF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AcroPDF);
            this.Controls.Add(this.tsm);
            this.MainMenuStrip = this.tsm;
            this.Name = "FormPDF";
            ((System.ComponentModel.ISupportInitialize)(this.AcroPDF)).EndInit();
            this.tsm.ResumeLayout(false);
            this.tsm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAcroPDFLib.AxAcroPDF AcroPDF;
        private System.Windows.Forms.MenuStrip tsm;
        private System.Windows.Forms.ToolStripMenuItem tsmAbrir;
        private System.Windows.Forms.OpenFileDialog openF;
    }
}

