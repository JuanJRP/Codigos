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
    public partial class Completar : Form
    {
        int pag = 1;
        int[] aux = new int[20];
        float puntaje = 0;
        public Completar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pag == 1)
            {
                
                if (textBox2.Text.ToLower().Replace(" ", String.Empty) == "ellenguaje") { aux[1] = 1; } else { aux[1] = 0; }
                if (textBox3.Text.ToLower().Replace(" ", String.Empty) == "sistemaoperativo") { aux[2] = 1; } else { aux[2] = 0; }
                if (textBox4.Text.ToLower().Replace(" ", String.Empty) == "android") { aux[3] = 1; } else { aux[3] = 0; }
                txtbPregunta.Text = "un         se representa por medio de una               o entidad que este           por sus atributos y           correspondientes.";
                textBox1.Text = "objeto,funciones, compuesta, tabla.";
                textBox2.Location = new Point(43, 175);
                textBox4.Location = new Point(21, 195);
                pag += 1;
                labPag.Text = $"{pag}/5";

            }
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
                textBox2.Location = new Point(187, 175);
                textBox3.Location = new Point(70, 213);
                textBox4.Location = new Point(219, 195);
                pag -= 1;
                labPag.Text = $"{pag}/5";
                textBox1.Text = "el lenguaje, sistema operativo, android.";
                txtbPregunta.Text = "Java fue elegido como                    para el entorno de desarrollo de                   , el                              movil lider en smartphones y tablets.";

            }
        }

        private void txtbPregunta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
