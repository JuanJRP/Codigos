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
        List<string> userList = new List<string>();
        List<string> passwordList = new List<string>();
        int aux = 0;
        bool log = false;
        bool visible = false;
        int score;
        public Login(List<string> user, List<string> passwd, int aux2,int _score , int bandera = 0)
        {
            if (bandera == 1)
            {
                this.userList = user;
                this.passwordList = passwd;
                this.aux = aux2;
                this.score = _score;
            }
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBackI_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio(userList,passwordList,aux,score,1);
            inicio.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnEntrar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        public void btnEntrar_Click(object sender, EventArgs e)
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

            
            //Validar usuario y contraseña
            for (int i = 0; i < userList.Count; i++)
            {
                if (userList[i] == textUser.Text && passwordList[i] == textPass.Text)
                {
                    visible = true;
                    log = true;
                    string userL = userList[i];
                    this.Hide();
                    Difficulty difficulty = new Difficulty(userList,passwordList,userL,aux,score,1,visible);
                    difficulty.Show();
                }
            }
            if (log != true)
            {
                MessageBox.Show("usuario o contraseña incorrecta");
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
