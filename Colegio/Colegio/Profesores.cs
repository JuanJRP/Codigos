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
    public partial class Profesores : Form
    {
        SqlConnection cn;
        string Conecxion = ConfigurationManager.ConnectionStrings["Colegio.Properties.Settings.Database1ConnectionString"].ConnectionString;
        string dato, Nprofesor;
        int Opcion = 0, i = 0, R = 100;
        public Profesores(string profesor)
        {
            this.Nprofesor = profesor;
            InitializeComponent();
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
            dataGridView1.DataSource = dt;
            return dt;
        }
        public DataTable llenar2(string dato)
        {
            cn = new SqlConnection(Conecxion);
            cn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(dato, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            dataGridView2.DataSource = dt;
            return dt;
        }
        private void Profesores_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            dato = $"SELECT Asignatura FROM Clases WHERE Nombre = '{Nprofesor}'";
            llenar(dato);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Opcion == 0)
            {
                label2.Visible = true;
                label3.Visible = true;
                textBox2.Visible = true;
                button4.Visible = true;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
            }
            else
            {
                MessageBox.Show("La configuracion ya se ha realizado");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Opcion == 0)
            {
                MessageBox.Show("Primero se debe configurar la materia");
            }
            else
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Opcion == 0)
            {
                MessageBox.Show("Primero se debe configurar la materia");
            }
            else
            {

            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textBox2.Text) <= R)
            {
                dato = $"ALTER TABLE [dbo].{textBox1.Text} ADD [Nota {i += 1}] VARCHAR (150) NULL;";
                llenar2(dato);
                dato = $"UPDATE [dbo].{textBox1.Text} set [Nota {i}]={textBox2.Text}";
                llenar2(dato);
                dato = $"SELECT * FROM {textBox1.Text}";
                llenar2(dato);
                label2.Text = $"Valor Nota {i + 1}";
                label3.Text = $"Restante: {R -= Convert.ToInt32(textBox2.Text)}%";
                textBox2.Clear();
                if(R == 0)
                {
                    label2.Visible = false;
                    label3.Visible = false;
                    textBox2.Visible = false;
                    button4.Visible = false;
                    button1.Visible = true;
                    button2.Visible = true;
                    button3.Visible = true;
                    MessageBox.Show("Configuracion exitosa.");
                    Opcion = 1;
                }
            }
            else
            {
                MessageBox.Show("El porcentaje ingresado supera los limites");
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            button4.Visible = false;
            textBox2.Visible = false;
            DataTable dt = new DataTable();
            dataGridView2.Visible = true;
            dataGridView2.DataSource = dt;
            dato = $"SELECT * FROM {textBox1.Text}";
            llenar2(dato);
        }
    }
}
