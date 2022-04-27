using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juego_interactivo
{
    public partial class Verd_Fals : Form
    {
        int pag = 1;
        int[] aux = new int[6]; 
        float puntaje = 0;
        public Verd_Fals()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pag == 1)
            {
                if (checkBox1.Checked == true) { aux[1] = 1; } else { aux[1] = 0; }
                pag += 1;
                labPag.Text = $"{pag}/5";
                txtbPregunta.Text = "¿El lenguaje de programacion de Java fue adquirido por Oracle?";
                textBox1.Text = "Verdadero.";
                textBox2.Text = "Falso.";

            }
            else if (pag == 2)
            {
                if (checkBox1.Checked == true) { aux[2] = 1; } else { aux[2] = 0; }
                pag += 1;
                labPag.Text = $"{pag}/5";
                txtbPregunta.Text = "¿En Visual estudio no se pueden crear programas para todas las plataformas?";
                textBox1.Text = "Verdadero.";
                textBox2.Text = "Falso.";
            }
            else if (pag == 3)
            {
                if (checkBox2.Checked == true) { aux[3] = 1; } else { aux[3] = 0; }
                pag += 1;
                labPag.Text = $"{pag}/5";
                txtbPregunta.Text = "¿Visual estudio esta para celular?";
                textBox1.Text = "Verdadero.";
                textBox2.Text = "Falso.";
            }
            else if (pag == 4)
            {
                if (checkBox2.Checked == true) { aux[4] = 1; } else { aux[4] = 0; }
                pag += 1;
                labPag.Text = $"{pag}/5";
                txtbPregunta.Text = "¿Windows Froms tiene mayor libertad de diseño que ASP.NET?";
                textBox1.Text = "Verdadero.";
                textBox2.Text = "Falso.";
                button2.Text = "Calificar";
            }
            else if (pag == 5)
            {
                pag += 1;
                if (checkBox1.Checked == true) { aux[5] = 1; } else { aux[5] = 0; }
                if (aux[1] == 1){puntaje += 14;}
                if (aux[2] == 1){puntaje += 28;}
                if (aux[3] == 1){puntaje += 36;}
                if (aux[4] == 1){puntaje += 10;}
                if (aux[5] == 1){puntaje += 12;}
                txtbPregunta.Text = $"El puntaje obtenido es: {puntaje}/100";
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                textBox1.Text = 
                    "1) Verdadero.                                                           " +
                    "2) Verdadero.                                                           " +
                    "3) Falso.                                                                  " +
                    "4) Falso.                                                           " + 
                    "5)Verdadero.";
                textBox2.Visible = false;
                button1.Visible = false;
                button2.Text = "Salir";
            }
            else if (pag == 6)
            {
                this.Close();
                MODALIDAD modalidad = new MODALIDAD();
                modalidad.Show();
            }
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (pag == 1)
            {
                this.Close();
                MODALIDAD modalidad = new MODALIDAD();
                modalidad.Show();
            }
            if (pag == 2)
            {
                pag -= 1;
                labPag.Text = $"{pag}/5";
                txtbPregunta.Text = "¿Son herramientas de evaluacion: Mapa conceptual, Resumen, Analogias, Etc...?";
                textBox1.Text = "Verdadero.";
                textBox2.Text = "Falso.";
            }
            if (pag == 3)
            {
                pag -= 1;
                labPag.Text = $"{pag}/5";
                txtbPregunta.Text = "¿El lenguaje de programacion de Java fue adquirido por Oracle?";
                textBox1.Text = "Verdadero.";
                textBox2.Text = "Falso.";
            }
            if (pag == 4)
            {
                pag -= 1;
                labPag.Text = $"{pag}/5";
                txtbPregunta.Text = "¿En Visual estudio no se pueden crear programas para todas las plataformas?";
                textBox1.Text = "Verdadero.";
                textBox2.Text = "Falso.";
            }
            if (pag == 5)
            {
                pag -= 1;
                labPag.Text = $"{pag}/5";
                txtbPregunta.Text = "¿Visual estudio esta para celular?";
                textBox1.Text = "Verdadero.";
                textBox2.Text = "Falso.";
            }
        }


        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
        }
    }
}
