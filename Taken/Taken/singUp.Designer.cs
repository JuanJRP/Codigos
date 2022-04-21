namespace Taken
{
    partial class singUp
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBackI = new System.Windows.Forms.Button();
            this.btnSinUp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textPassRR = new System.Windows.Forms.TextBox();
            this.textPassR = new System.Windows.Forms.TextBox();
            this.textUserR = new System.Windows.Forms.TextBox();
            this.error1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnplay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Taken.Properties.Resources._6191107;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnBackI
            // 
            this.btnBackI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnBackI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackI.Font = new System.Drawing.Font("Engravers MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBackI.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnBackI.Location = new System.Drawing.Point(313, 350);
            this.btnBackI.Name = "btnBackI";
            this.btnBackI.Size = new System.Drawing.Size(175, 46);
            this.btnBackI.TabIndex = 18;
            this.btnBackI.Text = "BACK";
            this.btnBackI.UseVisualStyleBackColor = false;
            this.btnBackI.Click += new System.EventHandler(this.btnBackI_Click);
            // 
            // btnSinUp
            // 
            this.btnSinUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.btnSinUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinUp.Font = new System.Drawing.Font("Engravers MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSinUp.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnSinUp.Location = new System.Drawing.Point(313, 298);
            this.btnSinUp.Name = "btnSinUp";
            this.btnSinUp.Size = new System.Drawing.Size(175, 46);
            this.btnSinUp.TabIndex = 17;
            this.btnSinUp.Text = "Register";
            this.btnSinUp.UseVisualStyleBackColor = false;
            this.btnSinUp.Click += new System.EventHandler(this.btnSinUp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label5.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Goldenrod;
            this.label5.Location = new System.Drawing.Point(320, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "PASSWORD";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.label1.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Goldenrod;
            this.label1.Location = new System.Drawing.Point(359, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "USER";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.label2.Font = new System.Drawing.Font("Engravers MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Goldenrod;
            this.label2.Location = new System.Drawing.Point(259, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "RE-TYPE PASSWORD";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textPassRR
            // 
            this.textPassRR.Location = new System.Drawing.Point(313, 253);
            this.textPassRR.Name = "textPassRR";
            this.textPassRR.ShortcutsEnabled = false;
            this.textPassRR.Size = new System.Drawing.Size(175, 23);
            this.textPassRR.TabIndex = 16;
            this.textPassRR.UseSystemPasswordChar = true;
            this.textPassRR.TextChanged += new System.EventHandler(this.textPassRR_TextChanged);
            this.textPassRR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnPassRR_KeyPress);
            // 
            // textPassR
            // 
            this.textPassR.Location = new System.Drawing.Point(313, 181);
            this.textPassR.Name = "textPassR";
            this.textPassR.ShortcutsEnabled = false;
            this.textPassR.Size = new System.Drawing.Size(175, 23);
            this.textPassR.TabIndex = 15;
            this.textPassR.UseSystemPasswordChar = true;
            this.textPassR.TextChanged += new System.EventHandler(this.textPassR_TextChanged);
            this.textPassR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnPassR_KeyPress);
            // 
            // textUserR
            // 
            this.textUserR.Location = new System.Drawing.Point(313, 109);
            this.textUserR.Name = "textUserR";
            this.textUserR.Size = new System.Drawing.Size(175, 23);
            this.textUserR.TabIndex = 14;
            this.textUserR.TextChanged += new System.EventHandler(this.textUserR_TextChanged);
            this.textUserR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnUserR_KeyPress);
            // 
            // error1
            // 
            this.error1.ContainerControl = this;
            // 
            // btnplay
            // 
            this.btnplay.Location = new System.Drawing.Point(713, 373);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(75, 23);
            this.btnplay.TabIndex = 19;
            this.btnplay.Text = "button1";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Visible = false;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // singUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textUserR);
            this.Controls.Add(this.textPassR);
            this.Controls.Add(this.textPassRR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSinUp);
            this.Controls.Add(this.btnBackI);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnplay);
            this.Name = "singUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "singUp";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnBackI;
        private Button btnSinUp;
        private Label label5;
        private Label label1;
        private Label label2;
        private TextBox textPassRR;
        private TextBox textPassR;
        private TextBox textUserR;
        private ErrorProvider error1;
        private Button btnplay;
    }
}