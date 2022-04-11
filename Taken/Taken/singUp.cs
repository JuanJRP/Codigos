using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taken
{
    public partial class singUp : Form
    {
        Login login = new Login();
        public singUp()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnBackI_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio();
            inicio.Show();
        }

        private void textPassRR_TextChanged(object sender, EventArgs e)
        {

        }

        private void textUserR_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnUserR_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        public void btnSinUp_Click(object sender, EventArgs e)
        {

            if (textUserR.Text == "")
            {
                error1.SetError(textUserR, "You must enter a user.");
                textUserR.Focus();
                return;
            }
            error1.SetError(textUserR, "");

            if (textPassR.Text == "")
            {
                error1.SetError(textPassR, "You must enter a Pass.");
                textPassR.Focus();
                return;
            }
            error1.SetError(textPassR, "");

            if (textPassRR.Text == "")
            {
                error1.SetError(textPassRR, "You must enter a Pass.");
                textPassRR.Focus();
                return;
            }
            error1.SetError(textPassRR, "");

            if (textPassRR.Text != textPassR.Text)
            {
                error1.SetError(textPassRR, "The passwords do not match");
                textPassRR.Focus();
                return;
            }
            error1.SetError(textPassRR, "");

            User.userR = textUserR.Text;
            User.passwdR = textPassRR.Text;
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void textPassR_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnPassR_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void btnPassRR_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
