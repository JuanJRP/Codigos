using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL_ESTRUCTURA_DE_DATOS
{
    public partial class Profesores : Form
    {
        //Listas-------------------------------------------------------
        List<string> usuarios_Administradores = new List<string>();
        List<string> Contraseñas_Administradores = new List<string>();
        List<string> usuarios_Profesores = new List<string>();
        List<string> Contraseñas_Profesores = new List<string>();
        List<string> usuarios_Estudiantes = new List<string>();
        List<string> Contraseñas_Estudiantes = new List<string>();
        //-------------------------------------------------------------
        public Profesores(List<string> u_Administradores, List<string> C_Administradores,
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

        private void Pofesores_Load(object sender, EventArgs e)
        {

        }

        private void Profesores_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Profesores_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
