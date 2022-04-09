using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Forms
{
    public partial class Form2 : Form
    {
        
        public class Datos
        {
            public string usuario { get; set; }
            public string contraseña { get; set; }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();

            datos.usuario = textBox1.Text;
            datos.contraseña = textBox2.Text;
            Form1 form1 = new Form1(datos.usuario,datos.contraseña);
            form1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
