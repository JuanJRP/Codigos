using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_FINAL_ESTRUCTURA_DE_DATOS;
namespace PROYECTO_FINAL_ESTRUCTURA_DE_DATOS
{
    public partial class Login : Form
    {
        //Variables----------------------------------------------------
        bool validar = false;
        //-------------------------------------------------------------

        //Listas-------------------------------------------------------
        List<string> usuarios_Administradores = new List<string>();
        List<string> Contraseñas_Administradores = new List<string>();
        List<string> usuarios_Profesores = new List<string>();
        List<string> Contraseñas_Profesores = new List<string>();
        List<string> usuarios_Estudiantes = new List<string>();
        List<string> Contraseñas_Estudiantes = new List<string>();
        //-------------------------------------------------------------
        public Login()
        {
            usuarios_Administradores.Add("admin");
            Contraseñas_Administradores.Add("admin");
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                validar = false;
                //Validar Administradores-------------------------------------------------------------------------------
                if (usuarios_Administradores.Count > 0)
                {
                    for (int i = 0; i < usuarios_Administradores.Count; i++)
                    {
                        if (textBox1.Text == usuarios_Administradores[i] && textBox2.Text == Contraseñas_Administradores[i])
                        {
                            Admin admin = new Admin();
                            admin.Show();
                            this.Close();
                            validar = true;
                        }
                    }
                }
                //------------------------------------------------------------------------------------------------------

                //validar Profesores------------------------------------------------------------------------------------
                if (usuarios_Profesores.Count > 0)
                {
                    for (int i = 0; i < usuarios_Profesores.Count; i++)
                    {
                        if (textBox1.Text == usuarios_Profesores[i] && textBox2.Text == Contraseñas_Profesores[i])
                        {
                            MessageBox.Show("profesor");
                            validar = true;
                        }
                    }
                }
                //------------------------------------------------------------------------------------------------------

                //validar Estudiantes-----------------------------------------------------------------------------------
                if (usuarios_Estudiantes.Count > 0)
                {
                    for (int i = 0; i < usuarios_Estudiantes.Count; i++)
                    {
                        if (textBox1.Text == usuarios_Estudiantes[i] && textBox2.Text == Contraseñas_Estudiantes[i])
                        {
                            MessageBox.Show("estudiante");
                            validar = true;
                        }
                    }
                }
                //------------------------------------------------------------------------------------------------------
                if (validar != true) { MessageBox.Show("Usuario o contraseña incorrectos."); }
            }
        }
    }
}
