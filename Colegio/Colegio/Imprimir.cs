using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Data.SqlClient;

namespace Colegio
{
    public partial class Imprimir : Form
    {
        SqlConnection cn;
        string Conecxion = ConfigurationManager.ConnectionStrings["Colegio.Properties.Settings.Database1ConnectionString"].ConnectionString;
        string dato;
        public DataTable llenar(string dato)
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
        public DataTable llenar2(string dato)
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
        public Imprimir()
        {   
            InitializeComponent();
        }

        private void Imprimir_Load(object sender, EventArgs e)
        {
            dataGridView2.AllowUserToAddRows = false;
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            dato = $"SELECT Nombre FROM Materia GROUP BY Nombre";
            llenar(dato);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            textBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            dato = $"SELECT Asignatura FROM Materia WHERE Nombre = '{textBox1.Text}'";
            llenar2(dato);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            dato = $"SELECT * FROM {textBox2.Text} WHERE Nombre = '{textBox1.Text}'";
            llenar2(dato);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentDir = Path.GetDirectoryName(Environment.CurrentDirectory);
            using (TextWriter tw = new StreamWriter($"{currentDir}\\{textBox1.Text}_{textBox2.Text}.txt"))
            {
                tw.WriteLine($"El estudiante {textBox1.Text} ");
                tw.WriteLine($"En la materia de {textBox2.Text} Tiene las siguientes notas:");
                
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 1; j < dataGridView1.Columns.Count; j++)
                    {
                        tw.Write($"{dataGridView1.Rows[i].Cells[j].Value.ToString()} | ");

                        if (j == dataGridView1.Columns.Count - 1)
                        {
                            tw.WriteLine("");
                        }
                    }
                    tw.WriteLine("Institucion Educativa LE ROSEY");
                }
            }
            MessageBox.Show("Impresion Completada");
            MessageBox.Show($"Ruta donde se guardo: {currentDir}\\{textBox1.Text}_{textBox2.Text}.txt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admins admins = new Admins();
            admins.Show();
            this.Close();
        }
    }
}
