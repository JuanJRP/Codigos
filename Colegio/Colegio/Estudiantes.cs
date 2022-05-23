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
    public partial class Estudiantes : Form
    {
        SqlConnection cn;
        string Conecxion = ConfigurationManager.ConnectionStrings["Colegio.Properties.Settings.Database1ConnectionString"].ConnectionString;
        string Nestudiante,dato;
        public Estudiantes(string estudiante)
        {
            this.Nestudiante = estudiante;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            button1.Visible = true;
            button2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ingresar ingresar = new Ingresar();
            ingresar.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dato = $"SELECT * FROM {textBox1.Text} WHERE Nombre = '{Nestudiante}'";
            llenar2(dato);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dato = $"SELECT * FROM {textBox1.Text}_Asistencia WHERE Nombre = '{Nestudiante}'";
            llenar2(dato);
        }

        private void Estudiantes_Load(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            dato = $"SELECT Asignatura FROM Materia WHERE Nombre = '{Nestudiante}'";
            llenar(dato);
        }
    }
}
