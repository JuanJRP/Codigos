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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBackI_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio();
            inicio.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnEntrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96 ) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                error1.SetError(textUser, "Numbers are not allowed as a user.");
                textUser.Focus();
                e.Handled = true;
                return;
            }

        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            //Validar Texto

            if (textUser.Text == "")
            {
                error1.SetError(textUser, "You must enter a user.");
                textUser.Focus();
                return;
            }
            error1.SetError(textUser, "");

            if (textPass.Text == "")
            {
                error1.SetError(textPass, "You must enter a Pass.");
                textPass.Focus();
                return;
            }
            error1.SetError(textPass, "");

            //Validar Numeros
            if (User.userR == textUser.Text && User.passwdR == int.Parse(textPass.Text))
            {
                this.Hide();
                Difficulty difficulty = new Difficulty();
                difficulty.Show();
            }
            else
            {
                MessageBox.Show("puto programa");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
    }
}
