using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen
{
    public partial class Preguntas : Form
    {
        int pag = 1;
        int[] aux = new int[10];
        float puntaje = 0;

        public Preguntas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pag == 1)
            {
                if (checkBox2.Checked == true) { aux[1] = 1; } else { aux[1] = 0; }
                pag += 1;
                labPag.Text = $"{pag}/5";
                txtbPregunta.Text = "¿Qué son estructuras de datos?";
                textBox1.Text = "Es un programa que me permite hacer algoritmos.";
                textBox2.Text = "Ninguna de las anteriores.";
                textBox3.Text = "Es una serie de números que me permite organizar para realizar distintas tareas.";
                textBox4.Text = "Es una colección de datos que permiten organizar y operar con fines determinados."; 

            }
            else if (pag == 2)
            {

                if (checkBox4.Checked == true) { aux[2] = 1; } else { aux[2] = 0; }
                pag += 1;
                labPag.Text = $"{pag}/5";
                txtbPregunta.Text = "¿En Visual estudio no se pueden crear programas para todas las plataformas?";
                textBox1.Text = "Verdadero.";
                textBox2.Text = "Falso.";
                textBox3.Visible = false;
                textBox4.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;
            }
            else if (pag == 3)
            {
                if (checkBox2.Checked == true) { aux[3] = 1; } else { aux[3] = 0; }
                pag += 1;
                labPag.Text = $"{pag}/5";
                txtbPregunta.Text = "¿Visual estudio no esta para celular?";
                textBox1.Text = "Verdadero.";
                textBox2.Text = "Falso.";

            }
            else if (pag == 4)
            {
                if (checkBox1.Checked == true) { aux[4] = 1; } else { aux[4] = 0; }
                pag += 1;
                labPag.Text = $"{pag}/5";
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;
                textBox9.Visible = true;
                textBox6.Visible = true;
                textBox7.Visible = true;
                textBox5.Visible = true;
                label2.Text = "Palabras";
                txtbPregunta.Text = "El lenguaje, Sistema operativo, Android.";
                button2.Text = "Calificar";
            }
            else if (pag == 5)
            {
                pag += 1;
                if (textBox5.Text.ToLower().Replace(" ", String.Empty) == "ellenguaje") { aux[5] = 1; } else { aux[5] = 0; }
                if (textBox7.Text.ToLower().Replace(" ", String.Empty) == "sistemaoperativo") { aux[6] = 1; } else { aux[6] = 0; }
                if (textBox6.Text.ToLower().Replace(" ", String.Empty) == "android") { aux[7] = 1; } else { aux[7] = 0; }
                if (aux[1] == 1) { puntaje += 10; }
                if (aux[2] == 1) { puntaje += 27; }
                if (aux[3] == 1) { puntaje += 12; }
                if (aux[4] == 1) { puntaje += 15; }
                if (aux[5] == 1) { puntaje += 9; }
                if (aux[6] == 1) { puntaje += 14; }
                if (aux[7] == 1) { puntaje += 13; }
                txtbPregunta.Text = $"El puntaje obtenido es: {puntaje}/100";
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox9.Visible = false;
                button1.Visible = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox1.Text = "1) Es una serie de pasos que permiten dar solución a un problema.";
                textBox2.Text = "2) Es una colección de datos que permiten organizar y operar con fines determinados.";
                textBox3.Text = "3) Falso.";
                textBox4.Text = "4) Verdadero.                                                                                                                                              " +
                    "5) El lenguaje, Android, Sistema Operativo . ";
                button2.Text = "Salir";
            }
            else if (pag == 6)
            {
                this.Close();
                Inicio inicio = new Inicio();
                inicio.Show();
            }
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pag == 1)
            {
                this.Close();
                Inicio inicio = new Inicio();
                inicio.Show();
            }
            if (pag == 2)
            {
                pag -= 1;
                labPag.Text = $"{pag}/5";
                txtbPregunta.Text = "¿Qué es un algoritmo?";
                textBox1.Text = "Es un programa que me permite hacer algoritmos.";
                textBox2.Text = "Es una serie de pasos que permiten dar solución a un problema.";
                textBox3.Text = "Los algoritmos nos permiten desarrollar una taréa específica.";
                textBox4.Text = "Todas las anteriores";
            }
            if (pag == 3)
            {
                pag -= 1;
                labPag.Text = $"{pag}/5";
                txtbPregunta.Text = "¿Qué son estructuras de datos?";
                textBox1.Text = "Es un programa que me permite hacer algoritmos.";
                textBox2.Text = "Es una colección de datos que permiten organizar y operar con fines determinados.";
                textBox3.Text = "Es una serie de números que me permite organizar para realizar distintas tareas.";
                textBox4.Text = "Ninguna de las anteriores.";
                textBox1.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                checkBox3.Visible = true;
                checkBox4.Visible = true;
            }
            if (pag == 4)
            {
                pag -= 1;
                labPag.Text = $"{pag}/5";
                txtbPregunta.Text = "¿En Visual estudio no se pueden crear programas para todas las plataformas?";
                textBox1.Text = "Verdadero.";
                textBox2.Text = "Falso.";
                textBox1.Visible = true;
                textBox3.Visible = false;
                textBox4.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;

            }
            if (pag == 5)
            {
                pag -= 1;
                labPag.Text = $"{pag}/5";
                txtbPregunta.Text = "¿Visual estudio no esta para celular?";
                textBox1.Text = "Verdadero.";
                textBox2.Text = "Falso.";
                label2.Text = "Preguntas";
                button2.Text = "Siguiente";
                textBox1.Visible = true;
                textBox2.Visible = true;
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                textBox3.Visible = false;
                textBox4.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;
                textBox5.Visible = false;
                textBox6.Visible = false;
                textBox7.Visible = false;
                textBox9.Visible = false;
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox4.Checked = false;
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }
    }
}
