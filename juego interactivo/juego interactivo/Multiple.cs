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
    public partial class Multiple : Form
    {
        int pag = 1;
        int[] aux = new int[6];
        float puntaje = 0;
        public Multiple()
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
                textBox2.Text = "Es una colección de datos que permiten organizar y operar con fines determinados.";
                textBox3.Text = "Es una serie de números que me permite organizar para realizar distintas tareas.";
                textBox4.Text = "Ninguna de las anteriores.";

            }
            else if (pag == 2)
            {
                if (checkBox2.Checked == true) { aux[2] = 1; } else { aux[2] = 0; }
                pag += 1;
                labPag.Text = $"{pag}/5";
                txtbPregunta.Text = "¿A qué se refiere con operaciones algorítmicas?";
                textBox1.Text = "Permite desarrollar representaciones con elementos diferenciando de un indice y subindice."; ;
                textBox2.Text = "Es desarrollar representaciones los elementos diferenciando de un indice y subindice.";
                textBox3.Text = "Es realizar todo tipo de operaciones matemáticas y algebráicas.";
                textBox4.Text = "A y C son correctas.";
            }
            else if (pag == 3)
            {
                if (checkBox2.Checked == true) { aux[3] = 1; } else { aux[3] = 0; }
                pag += 1;
                labPag.Text = $"{pag}/5";
                txtbPregunta.Text = "¿Técnica para representar un algoritmo de manera gráfica?";
                textBox1.Text = "Estructuras de control."; ;
                textBox2.Text = "Pseudocodigo.";
                textBox3.Text = "Diagrama de flujo.";
                textBox4.Text = "Texto narrativo.";

            }
            else if (pag == 4)
            {
                if (checkBox3.Checked == true) { aux[4] = 1; } else { aux[4] = 0; }
                pag += 1;
                labPag.Text = $"{pag}/5";
                txtbPregunta.Text = "¿Enteros, reales, caracteres, cadenas y lógicos?";
                textBox1.Text = "Tipos de datos."; ;
                textBox2.Text = "Operadores de relacion.";
                textBox3.Text = "Estructuras de repeticion.";
                textBox4.Text = "Estructuras de relacion.";
                button2.Text = "Calificar";
            }
            else if (pag == 5)
            {
                pag += 1;
                if (checkBox1.Checked == true) { aux[5] = 1; } else { aux[5] = 0; }
                if (aux[1] == 1) { puntaje += 10; }
                if (aux[2] == 1) { puntaje += 28; }
                if (aux[3] == 1) { puntaje += 12; }
                if (aux[4] == 1) { puntaje += 14; }
                if (aux[5] == 1) { puntaje += 36; }
                txtbPregunta.Text = $"El puntaje obtenido es: {puntaje}/100";
                checkBox1.Visible = false;
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;
                button1.Visible = false;
                textBox1.Text = "1) Es una serie de pasos que permiten dar solución a un problema.";
                textBox2.Text = "2) Es una colección de datos que permiten organizar y operar con fines determinados.";
                textBox3.Text = "3) Es desarrollar representaciones los elementos diferenciando de un indice y subindice.";
                textBox4.Text = "4) Diagrama de flujo.                                                                                                                                " +
                    "5) Tipos de datos. ";
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
            checkBox3.Checked = false;
            checkBox4.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
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
            }
            if (pag == 4)
            {
                pag -= 1;
                labPag.Text = $"{pag}/5";
                txtbPregunta.Text = "¿A qué se refiere con operaciones algorítmicas?";
                textBox1.Text = "Permite desarrollar representaciones con elementos diferenciando de un indice y subindice."; ;
                textBox2.Text = "Es desarrollar representaciones los elementos diferenciando de un indice y subindice.";
                textBox3.Text = "Es realizar todo tipo de operaciones matemáticas y algebráicas.";
                textBox4.Text = "A y C son correctas.";
            }
            if (pag == 5)
            {
                pag -= 1;
                labPag.Text = $"{pag}/5";
                txtbPregunta.Text = "¿Técnica para representar un algoritmo de manera gráfica?";
                textBox1.Text = "Estructuras de control."; ;
                textBox2.Text = "Pseudocodigo.";
                textBox3.Text = "Diagrama de flujo.";
                textBox4.Text = "Texto narrativo.";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
