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
        int opcion,btn = 0;

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
            dato = $"SELECT * FROM Admins";
            llenar(dato);
            button7.Visible = false;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            label5.Visible = false;
            textBox5.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            btn = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dato = $"SELECT * FROM auxAsignaturas";
            llenar(dato);
            button7.Visible = false;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            label5.Visible = false;
            textBox5.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            btn = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dato = $"SELECT * FROM Profesores";
            llenar(dato);
            button7.Visible = false;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            label5.Visible = false;
            textBox5.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            btn = 3;
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
            if (btn == 1)
            {
                if (opcion == 1)
                {
                    dato = $"SELECT * FROM Admins";
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
                    textBox3.Clear();
                    textBox4.Clear();

                }
                else if (opcion == 2)
                {
                    dato = $"SELECT * Admins";
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
                    textBox3.Clear();
                    textBox4.Clear();
                }
                else if (opcion == 3)
                {
                    dato = $"SELECT * FROM Admins";
                    insertar = "DELETE FROM Admins WHERE Users=@Users";
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(insertar, cn);
                    cmd.Parameters.AddWithValue("@Users", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    dataGridView1.DataSource = llenar(dato);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
            }
            else if (btn == 2)
            {
                if (opcion == 1)
                {
                    dato = $"SELECT * FROM auxAsignaturas";
                    insertar = "INSERT INTO auxAsignaturas(Asignatura, Grado)values(@Asignatura, @Grado)";
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(insertar, cn);
                    cmd.Parameters.AddWithValue("@Asignatura", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Grado", textBox3.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    dataGridView1.DataSource = llenar(dato);
                    insertar = $"CREATE TABLE [dbo].[{textBox1.Text}_{textBox3.Text}] ([Id] INT IDENTITY(1, 1) NOT NULL, [Nombre]     VARCHAR (150) NOT NULL,); ";
                    cn.Open();
                    SqlCommand cmd2 = new SqlCommand(insertar, cn);
                    cmd2.Parameters.AddWithValue("@Asignatura", textBox1.Text);
                    cmd2.Parameters.AddWithValue("@Grado", textBox3.Text);
                    cmd2.ExecuteNonQuery();
                    cn.Close();
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();

                }
                else if (opcion == 2)
                {
                    dato = $"SELECT * FROM auxAsignaturas";
                    insertar = "UPDATE auxAsignaturas set Asignatura=@Asignatura2 WHERE Asignatura=@Asignatura";
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(insertar, cn);
                    cmd.Parameters.AddWithValue("@Asignatura", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Asignatura2", textBox2.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    dataGridView1.DataSource = llenar(dato);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
                else if (opcion == 3)
                {
                    dato = $"SELECT * FROM auxAsignaturas";
                    insertar = "DELETE FROM auxAsignaturas WHERE Asignatura=@Asignatura";
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(insertar, cn);
                    cmd.Parameters.AddWithValue("@Asignatura", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    dataGridView1.DataSource = llenar(dato);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
            }
            else if (btn == 3)
            {
                if (opcion == 1)
                {
                    dato = $"SELECT * FROM Profesores";
                    insertar = "INSERT INTO Profesores(Nombre, Asignatura, Users, Passwords)values(@Nombre, @Asignatura, @Users, @Passwords)";
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(insertar, cn);
                    cmd.Parameters.AddWithValue("@Nombre", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Asignatura", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Users", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Passwords", textBox4.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    dataGridView1.DataSource = llenar(dato);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();

                }
                else if (opcion == 2)
                {
                    dato = $"SELECT * FROM Profesores";
                    insertar = "UPDATE Profesores set @Nombre=@Nombre, @Asignatura=@Asignatura, @Users=@Users, @Passwords=@Passwords WHERE Id=@Id";
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(insertar, cn);
                    cmd.Parameters.AddWithValue("@Nombre", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Asignatura", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Users", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Passwords", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Id", textBox5.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    dataGridView1.DataSource = llenar(dato);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
                else if (opcion == 3)
                {
                    dato = $"SELECT * FROM Profesores";
                    insertar = "DELETE FROM Profesores WHERE Nombre=@Nombre";
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(insertar, cn);
                    cmd.Parameters.AddWithValue("@Nombre", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    dataGridView1.DataSource = llenar(dato);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (btn == 1)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Visible = true;
                textBox2.Visible = true;
                button7.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label5.Visible = false;
                textBox5.Visible = false;
                button7.Text = "Añadir Datos";
                opcion = 1;
            }
            else if (btn == 2)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = true;
                button7.Visible = true;
                label1.Visible = true;
                label2.Visible = false;
                label3.Visible = true;
                label5.Visible = false;
                textBox5.Visible = false;
                label1.Text = "Materia";
                label3.Text = "Grado";
                button7.Text = "Añadir Datos";
                opcion = 1;
            }
            else if (btn == 3)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                button7.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = false;
                textBox5.Visible = false;
                label1.Text = "Nombre";
                label2.Text = "Asignatura";
                label3.Text = "Usuario";
                label4.Text = "Contraseña";
                button7.Text = "Añadir Datos";
                opcion = 1;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (btn == 1)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Visible = true;
                textBox2.Visible = true;
                button7.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label5.Visible = false;
                textBox5.Visible = false;
                button7.Text = "Modificar Datos";
                opcion = 2;
            }
            else if (btn == 2)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Visible = true;
                textBox2.Visible = true;
                button7.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label5.Visible = false;
                textBox5.Visible = false;
                label1.Text = "Antigua Materia";
                label2.Text = "Nueva Materia";
                button7.Text = "Modificar Datos";
                opcion = 2;
            }
            else if (btn == 3)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                button7.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                textBox5.Visible = true;
                label1.Text = "Nombre";
                label2.Text = "Asignatura";
                label3.Text = "Usuario";
                label4.Text = "Contraseña";
                label5.Text = "Id A Modificar";
                button7.Text = "Modificar Datos";
                opcion = 2;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (btn == 1)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Visible = true;
                textBox2.Visible = true;
                button7.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                label5.Visible = false;
                textBox5.Visible = false;
                button7.Text = "Borrar Datos";
                opcion = 3;
            }
            else if (btn == 2)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Visible = true;
                textBox2.Visible = false;
                button7.Visible = true;
                label1.Visible = true;
                label2.Visible = false;
                label5.Visible = false;
                textBox5.Visible = false;
                label1.Text = "Materia";
                button7.Text = "Borrar Datos";
                opcion = 3;
            }
            else if (btn == 3)
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                button7.Visible = true;
                label1.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label1.Text = "Nombre";
                label2.Text = "Asignatura";
                label3.Text = "Usuario";
                label4.Text = "Contraseña";
                button7.Text = "Borrar Datos";
                opcion = 3;
            }
        }

        private void Admins_Load(object sender, EventArgs e)
        {

        }
    }
}