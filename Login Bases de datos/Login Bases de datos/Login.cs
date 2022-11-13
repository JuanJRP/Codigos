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

namespace Login_Bases_de_datos
{
    public partial class frmLogin : Form
    {
        /*------------------------------------------VARIABLES-------------------------------------------------------------*/
        static string conexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=login;UID=root;PASSWORDS=;";
        MySqlConnection cn = new MySqlConnection(conexion);
        /*----------------------------------------------------------------------------------------------------------------*/

        /*-------------------------------------------FUNCIONES------------------------------------------------------------*/
        public void Registrar()
        {
            try
            {
                cn.Open();
                string Query = "INSERT INTO tblRegistro VALUES(@strUsuario,@strContraseña,@strCorreo,@intTelefono)";
                MySqlCommand cmd = new MySqlCommand(Query, cn);
                cmd.Parameters.AddWithValue("@strUsuario", txtUsuario_r.Text);
                cmd.Parameters.AddWithValue("@strContraseña", txtContraseña_r.Text);
                cmd.Parameters.AddWithValue("@strCorreo", txtCorreo.Text);
                cmd.Parameters.AddWithValue("@intTelefono", txtTelefono.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("Registro Exitoso.");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al regsitrarse.");
            }
        }

        public int Validacion()
        {
            int Result = 0;
            try
            {
                cn.Open();
                string query = "SELECT COUNT(*) FROM tblRegistro WHERE strUsuario = @strUsuario AND strContraseña = @strContraseña";
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@strUsuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@strContraseña", txtContraseña.Text);
                Result = Convert.ToInt32(cmd.ExecuteScalar());
                cn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la conexion.");
            }
            return Result;
        }

        public int validarNom()
        {
            int Result = 0;
            try
            {
                cn.Open();
                string query = "SELECT COUNT(*) FROM tblRegistro WHERE strUsuario = @strUsuario";
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@strUsuario", txtUsuario_r.Text);
                Result = Convert.ToInt32(cmd.ExecuteScalar());
                cn.Close();
            }
            catch(Exception)
            {
                MessageBox.Show("Error en la conexion.");
            }
            return Result;
        }

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
            if(txtUsuario.Text == "")
            {
                MessageBox.Show("Ingrese un usuario.");
            }else if (txtContraseña.Text == "")
            {
                MessageBox.Show("Ingrese una contraseña.");
            }else if (Validacion() > 0)
            {
                limpiarL();
                MessageBox.Show("Ha ingresado a su cuenta correctamente.");
            }else 
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
            }else if (txtContraseña_r.Text == "")
            {
                MessageBox.Show("Ingrese una contraseña.");
            }else if (txtCorreo.Text == "")
            {
                MessageBox.Show("Ingrese un correo.");
            }else if (txtTelefono.Text == "")
            {
                MessageBox.Show("Ingrese un telefono.");
            }else
            {
                if (validarNom() == 0)
                {
                    Registrar();
                    limpiarR();
                    plRegisto.Visible = false;
                    limpiarL();
                    plLogin.Visible = true;
                }else
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

        /*----------------------------------------------------------------------------------------------------------------*/
    }
}
