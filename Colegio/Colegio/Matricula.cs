using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Colegio
{
    public partial class Matricula : Form
    {
        SqlConnection cn;
        string Conecxion = ConfigurationManager.ConnectionStrings["Colegio.Properties.Settings.Database1ConnectionString"].ConnectionString;
        string dato;
        public Matricula()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public DataTable llenar(string dato)
        {
            cn = new SqlConnection(Conecxion);
            cn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(dato, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            return dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" ||
                textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("Datos Incompletos");
            }
            else
            {
                dato = $"INSERT INTO [dbo].Estudiantes(Users,Nombre_Completo,Acudiente,Padre,Madre,Correo,Telefono,Celular,Grado,Estracto) Values('None','{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{textBox4.Text}','{textBox5.Text}','{textBox6.Text}','{textBox7.Text}','{textBox8.Text}','{textBox9.Text}')";
                llenar(dato);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                MessageBox.Show("Matricula Exitosa");
            }
        }
    }
}
