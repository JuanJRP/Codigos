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
    public partial class Admins : Form
    {
        SqlConnection cn;
        string Conecxion = ConfigurationManager.ConnectionStrings["Colegio.Properties.Settings.Database1ConnectionString"].ConnectionString;
        string dato, insertar;
        int opcion;
        public Admins()
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            dato = $"SELECT Users,Passwords FROM Admins";
            llenar(dato);
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button7.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dato = $"SELECT Users,Passwords FROM Profesores";
            llenar(dato);
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            textBox1.Visible = false;
            textBox2.Visible = false;
            button7.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void button6_Click(object sender, EventArgs e)
        {
            Ingresar ingresar = new Ingresar();
            ingresar.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (opcion == 1)
            {
                dato = $"SELECT Users,Passwords FROM Admins";
                insertar = "INSERT INTO Admins(Users, Passwords)values(@Users, @Passwords)";
                cn.Open();
                SqlCommand cmd = new SqlCommand(insertar, cn);
                cmd.Parameters.AddWithValue("@Users", textBox1.Text);
                cmd.Parameters.AddWithValue("@Passwords", textBox2.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                dataGridView1.DataSource = llenar(dato);
                textBox1.Clear();
                textBox2.Clear();

            }else if (opcion == 2)
            {
                dato = $"SELECT Users,Passwords FROM Admins";
                insertar = "UPDATE Admins set Users=@Users, Passwords=@Passwords WHERE Users=@Users";
                cn.Open();
                SqlCommand cmd = new SqlCommand(insertar, cn);
                cmd.Parameters.AddWithValue("@Users", textBox1.Text);
                cmd.Parameters.AddWithValue("@Passwords", textBox2.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                dataGridView1.DataSource = llenar(dato);
                textBox1.Clear();
                textBox2.Clear();
            }
            else if (opcion == 3)
            {
                dato = $"SELECT Users,Passwords FROM Admins";
                insertar = "DELETE FROM Admins WHERE Users=@Users";
                cn.Open();
                SqlCommand cmd = new SqlCommand(insertar, cn);
                cmd.Parameters.AddWithValue("@Users", textBox1.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                dataGridView1.DataSource = llenar(dato);
                textBox1.Clear();
                textBox2.Clear();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            button7.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            button7.Text = "Insertar";
            opcion = 1;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            button7.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            button7.Text = "Modificar";
            opcion = 2;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            button7.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            button7.Text = "Borrar";
            opcion = 3;
        }

        private void Admins_Load(object sender, EventArgs e)
        {

        }
    }
}
