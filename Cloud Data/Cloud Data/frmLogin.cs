using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Conexion;
using Cloud_Data;

namespace Login_Bases_de_datos
{
    public partial class frmLogin : Form
    {
        /*------------------------------------------VARIABLES-------------------------------------------------------------*/

        /*----------------------------------------------------------------------------------------------------------------*/

        /*-------------------------------------------FUNCIONES------------------------------------------------------------*/

        public void limpiarL()
        {
            txtContraseña.Clear();
            txtUsuario.Clear();
        }
        public void limpiarR()
        {
            txtContraseña_r.Clear();
            txtUsuario_r.Clear();
            txtCorreo.Clear();
            txtTelefono.Clear();
        }
        /*----------------------------------------------------------------------------------------------------------------*/

        public frmLogin()
        {
            InitializeComponent();
        }

        /*----------------------------------------------------botones------------------------------------------------------*/
        private void cmdEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Ingrese un usuario.");
            }
            else if (txtContraseña.Text == "")
            {
                MessageBox.Show("Ingrese una contraseña.");
            }
            else if (Conexion.Tipos.Validacion(txtUsuario.Text, txtContraseña.Text) > 0)
            {
                this.Hide();
                frmDatos frmDatos = new frmDatos(txtUsuario.Text,txtContraseña.Text);
                limpiarL();
                frmDatos.Show();
            }
            else
            {
                MessageBox.Show("Contraseña y/o usuario incorrecto.");
            }
        }

        private void cmdRegistrarse_Click(object sender, EventArgs e)
        {
            plLogin.Visible = false;
            plRegisto.Visible = true;
            limpiarL();
        }

        private void cmdAtras_Click(object sender, EventArgs e)
        {
            plRegisto.Visible = false;
            plLogin.Visible = true;
            limpiarR();
        }

        private void cmdResgistrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario_r.Text == "")
            {
                MessageBox.Show("Ingrese un usuario.");
            }
            else if (txtContraseña_r.Text == "")
            {
                MessageBox.Show("Ingrese una contraseña.");
            }
            else if (txtCorreo.Text == "")
            {
                MessageBox.Show("Ingrese un correo.");
            }
            else if (txtTelefono.Text == "")
            {
                MessageBox.Show("Ingrese un telefono.");
            }
            else
            {
                if (Conexion.Tipos.validarNom(txtUsuario_r.Text) == 0)
                {
                    MessageBox.Show(Conexion.Tipos.Registrar(txtUsuario_r.Text, txtContraseña_r.Text, txtCorreo.Text, txtTelefono.Text)); 
                    limpiarR();
                    plRegisto.Visible = false;
                    limpiarL();
                    plLogin.Visible = true;
                }
                else
                {
                    MessageBox.Show("Ese nombre de usuario ya se encuentra registrado.");
                }
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar < 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("En el telefono solo se permiten numeros.");
                e.Handled = true;
                return;
            }
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        /*----------------------------------------------------------------------------------------------------------------*/
    }
}
