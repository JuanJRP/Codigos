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
        public Login(List<string> u_Administradores, List<string> C_Administradores, 
            List<string> u_Profesores, List<string> C_Profesores, 
            List<string> u_Estudiantes, List<string> C_Estudiantes)
        {
            this.usuarios_Administradores = u_Administradores;
            this.Contraseñas_Administradores = C_Administradores;
            this.usuarios_Profesores = u_Profesores;
            this.Contraseñas_Profesores = C_Profesores;
            this.usuarios_Estudiantes = u_Estudiantes;
            this.Contraseñas_Estudiantes = C_Estudiantes;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio(usuarios_Administradores, Contraseñas_Administradores,
                usuarios_Profesores, Contraseñas_Profesores,
                usuarios_Estudiantes, Contraseñas_Estudiantes);
            inicio.Show();
            this.Close();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            usuarios_Administradores.Add("admin");
            Contraseñas_Administradores.Add("admin");
            usuarios_Profesores.Add("leon");
            Contraseñas_Profesores.Add("leon");
            usuarios_Estudiantes.Add("yurany");
            Contraseñas_Estudiantes.Add("yurany");
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                validar = false;
                //Validar Administradores-------------------------------------------------------------------------------
                if (usuarios_Administradores.Count > 0)
                {
                    for (int i = 0; i < usuarios_Administradores.Count; i++)
                    {
                        if (textBox1.Text == usuarios_Administradores[i] && textBox2.Text == Contraseñas_Administradores[i])
                        {
                            Admin admin = new Admin(usuarios_Administradores, Contraseñas_Administradores,
                usuarios_Profesores, Contraseñas_Profesores,
                usuarios_Estudiantes, Contraseñas_Estudiantes);
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
                            Profesores profesores = new Profesores(usuarios_Administradores, Contraseñas_Administradores,
                usuarios_Profesores, Contraseñas_Profesores,
                usuarios_Estudiantes, Contraseñas_Estudiantes);
                            profesores.Show();
                            this.Close();
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
                            Estudiantes estudiantes = new Estudiantes(usuarios_Administradores, Contraseñas_Administradores,
                usuarios_Profesores, Contraseñas_Profesores,
                usuarios_Estudiantes, Contraseñas_Estudiantes);
                            estudiantes.Show();
                            this.Close();
                            validar = true;
                        }
                    }
                }
                //------------------------------------------------------------------------------------------------------
                if (validar != true) { MessageBox.Show("Usuario o contraseña incorrectos."); }
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}
