namespace Timer
{
    partial class Timer
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
            this.tmr1 = new System.Windows.Forms.Timer(this.components);
            this.lbl1 = new System.Windows.Forms.Label();
            this.tmr2 = new System.Windows.Forms.Timer(this.components);
            this.tmr3 = new System.Windows.Forms.Timer(this.components);
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.cmdiniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tmr1
            // 
            this.tmr1.Tick += new System.EventHandler(this.tmr1_Tick);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(53, 24);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Time";
            // 
            // tmr2
            // 
            this.tmr2.Tick += new System.EventHandler(this.tmr2_Tick);
            // 
            // tmr3
            // 
            this.tmr3.Tick += new System.EventHandler(this.tmr3_Tick);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(12, 47);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(53, 24);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Time";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(12, 87);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(53, 24);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Time";
            // 
            // cmdiniciar
            // 
            this.cmdiniciar.Location = new System.Drawing.Point(271, 37);
            this.cmdiniciar.Name = "cmdiniciar";
            this.cmdiniciar.Size = new System.Drawing.Size(75, 23);
            this.cmdiniciar.TabIndex = 3;
            this.cmdiniciar.Text = "iniciar";
            this.cmdiniciar.UseVisualStyleBackColor = true;
            this.cmdiniciar.Click += new System.EventHandler(this.cmdiniciar_Click);
            // 
            // Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 166);
            this.Controls.Add(this.cmdiniciar);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "Timer";
            this.Load += new System.EventHandler(this.Timer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmr1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Timer tmr2;
        private System.Windows.Forms.Timer tmr3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button cmdiniciar;
    }
}

