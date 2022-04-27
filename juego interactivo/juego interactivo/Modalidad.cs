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
    public partial class MODALIDAD : Form
    {
        public MODALIDAD()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            INICIO inicio = new INICIO();
            inicio.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Multiple multiple = new Multiple();
            multiple.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Verd_Fals V_F = new Verd_Fals();
            V_F.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Completar completar = new Completar();
            completar.Show();
        }
    }
}
