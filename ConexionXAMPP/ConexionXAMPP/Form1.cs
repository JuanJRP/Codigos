using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ConexionXAMPP
{
    public partial class Form1 : Form
    {
        int num;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {           
            
        }

        static string conexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=biblioteca;UID=root;PASSWORDS=;";
        MySqlConnection cn = new MySqlConnection(conexion);
        public DataTable llenar_Empleados()
        {
            cn.Open();
            DataTable dt = new DataTable();
            string llenar = "select * from empleados";
            MySqlCommand cmd = new MySqlCommand(llenar, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            return dt;
        }
        public DataTable llenar_Libros()
        {
            cn.Open();
            DataTable dt = new DataTable();
            string llenar = "select * from libros";
            MySqlCommand cmd = new MySqlCommand(llenar, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            return dt;
        }
        public DataTable llenar_Prestamos()
        {
            cn.Open();
            DataTable dt = new DataTable();
            string llenar = "select * from prestamos";
            MySqlCommand cmd = new MySqlCommand(llenar, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            return dt;
        }
        public DataTable llenar_Computadores()
        {
            cn.Open();
            DataTable dt = new DataTable();
            string llenar = "select * from computadores";
            MySqlCommand cmd = new MySqlCommand(llenar, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            return dt;
        }
        public DataTable llenar_Socios()
        {
            cn.Open();
            DataTable dt = new DataTable();
            string llenar = "select * from socios";
            MySqlCommand cmd = new MySqlCommand(llenar, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            return dt;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
              
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenar_Empleados();
            dataGridView1.Visible = true;
            dataGridView1.Size = new Size(360, 345);
            label1.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            num = 1;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenar_Libros();
            dataGridView1.Visible = true;
            dataGridView1.Size = new Size(560, 345);
            label1.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            num = 2;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenar_Prestamos();
            dataGridView1.Visible = true;
            dataGridView1.Size = new Size(460, 395);
            label1.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            num = 3;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenar_Computadores();
            dataGridView1.Visible = true;
            dataGridView1.Size = new Size(460, 345);
            label1.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            num = 4;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = llenar_Socios();
            dataGridView1.Visible = true;
            dataGridView1.Size = new Size(360, 342);
            label1.Visible = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            num = 5;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(num == 1 || num == 5)
            {
                if (textBox1.Text == "")
                {
                    error1.SetError(textBox1, "El dato no puede ser nulo.");
                    textBox1.Focus();
                    return;
                }
                error1.SetError(textBox1, "");
                if (textBox2.Text == "")
                {
                    error1.SetError(textBox2, "El dato no puede ser nulo.");
                    textBox2.Focus();
                    return;
                }
                error1.SetError(textBox2, "");
                if (textBox3.Text == "")
                {
                    error1.SetError(textBox3, "El dato no puede ser nulo.");
                    textBox3.Focus();
                    return;
                }
                error1.SetError(textBox3, "");
            }
            if (num == 2)
            {
                if (textBox1.Text == "")
                {
                    error1.SetError(textBox1, "El dato no puede ser nulo.");
                    textBox1.Focus();
                    return;
                }
                error1.SetError(textBox1, "");
                if (textBox2.Text == "")
                {
                    error1.SetError(textBox2, "El dato no puede ser nulo.");
                    textBox2.Focus();
                    return;
                }
                error1.SetError(textBox2, "");
                if (textBox3.Text == "")
                {
                    error1.SetError(textBox3, "El dato no puede ser nulo.");
                    textBox3.Focus();
                    return;
                }
                error1.SetError(textBox3, "");
                if (textBox4.Text == "")
                {
                    error1.SetError(textBox4, "El dato no puede ser nulo.");
                    textBox4.Focus();
                    return;
                }
                error1.SetError(textBox4, "");
                if (textBox5.Text == "")
                {
                    error1.SetError(textBox5, "El dato no puede ser nulo.");
                    textBox5.Focus();
                    return;
                }
                error1.SetError(textBox5, "");
            }
            if (num == 3 || num==4)
            {
                if (textBox1.Text == "")
                {
                    error1.SetError(textBox1, "El dato no puede ser nulo.");
                    textBox1.Focus();
                    return;
                }
                error1.SetError(textBox1, "");
                if (textBox2.Text == "")
                {
                    error1.SetError(textBox2, "El dato no puede ser nulo.");
                    textBox2.Focus();
                    return;
                }
                error1.SetError(textBox2, "");
                if (textBox3.Text == "")
                {
                    error1.SetError(textBox3, "El dato no puede ser nulo.");
                    textBox3.Focus();
                    return;
                }
                error1.SetError(textBox3, "");
                if (textBox4.Text == "")
                {
                    error1.SetError(textBox4, "El dato no puede ser nulo.");
                    textBox4.Focus();
                    return;
                }
                error1.SetError(textBox4, "");
            }
            
            
            if (num == 1)
            {
                cn.Open();
                string insertar;
                insertar = "INSERT INTO empleados(documento,nombre,barrio)values(@documento,@nombre,@barrio)";
                MySqlCommand cmd = new MySqlCommand(insertar, cn);
                cmd.Parameters.AddWithValue("@documento", textBox1.Text);
                cmd.Parameters.AddWithValue("@nombre", textBox2.Text);
                cmd.Parameters.AddWithValue("@barrio", textBox3.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                dataGridView1.DataSource = llenar_Empleados();
            }
            if (num == 2)
            {
                cn.Open();
                string insertar;
                insertar = "INSERT INTO libros(codigo,titulo,autor,Genero,Tipo)values(@codigo,@titulo,@autor,@Genero,@Tipo)";
                MySqlCommand cmd = new MySqlCommand(insertar, cn);
                cmd.Parameters.AddWithValue("@codigo", textBox1.Text);
                cmd.Parameters.AddWithValue("@titulo", textBox2.Text);
                cmd.Parameters.AddWithValue("@autor", textBox3.Text);
                cmd.Parameters.AddWithValue("@Genero", textBox4.Text);
                cmd.Parameters.AddWithValue("@Tipo", textBox5.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                dataGridView1.DataSource = llenar_Libros();
            }
            if (num == 3)
            {
                cn.Open();
                string insertar;
                insertar = "INSERT INTO prestamos(codigo,documento,fechaprestamo,fechadevolucion)values(@codigo,@documento,@fechaprestamo,@fechadevolucion)";
                MySqlCommand cmd = new MySqlCommand(insertar, cn);
                cmd.Parameters.AddWithValue("@codigo", textBox1.Text);
                cmd.Parameters.AddWithValue("@documento", textBox2.Text);
                cmd.Parameters.AddWithValue("@fechaprestamo", textBox3.Text);
                cmd.Parameters.AddWithValue("@fechadevolucion", textBox4.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                dataGridView1.DataSource = llenar_Prestamos();
            }
            if (num == 4)
            {
                cn.Open();
                string insertar;
                insertar = "INSERT INTO computadores(documentos,nombres,hora_de_inicio,hora_de_finalizacion)values(@documentos,@nombres,@hora_de_inicio,@hora_de_finalizacion)";
                MySqlCommand cmd = new MySqlCommand(insertar, cn);
                cmd.Parameters.AddWithValue("@documentos", textBox1.Text);
                cmd.Parameters.AddWithValue("@nombres", textBox2.Text);
                cmd.Parameters.AddWithValue("@hora_de_inicio", textBox3.Text);
                cmd.Parameters.AddWithValue("@hora_de_finalizacion", textBox4.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                dataGridView1.DataSource = llenar_Computadores();
            }
            if (num == 5)
            {
                cn.Open();
                string insertar;
                insertar = "INSERT INTO socios(documento,nombre,barrio)values(@documento,@nombre,@barrio)";
                MySqlCommand cmd = new MySqlCommand(insertar, cn);
                cmd.Parameters.AddWithValue("@documento", textBox1.Text);
                cmd.Parameters.AddWithValue("@nombre", textBox2.Text);
                cmd.Parameters.AddWithValue("@barrio", textBox3.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                dataGridView1.DataSource = llenar_Socios();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (num == 1 || num == 5)
            {
                if (textBox1.Text == "")
                {
                    error1.SetError(textBox1, "El dato no puede ser nulo.");
                    textBox1.Focus();
                    return;
                }
                error1.SetError(textBox1, "");
                if (textBox2.Text == "")
                {
                    error1.SetError(textBox2, "El dato no puede ser nulo.");
                    textBox2.Focus();
                    return;
                }
                error1.SetError(textBox2, "");
                if (textBox3.Text == "")
                {
                    error1.SetError(textBox3, "El dato no puede ser nulo.");
                    textBox3.Focus();
                    return;
                }
                error1.SetError(textBox3, "");
            }
            if (num == 2)
            {
                if (textBox1.Text == "")
                {
                    error1.SetError(textBox1, "El dato no puede ser nulo.");
                    textBox1.Focus();
                    return;
                }
                error1.SetError(textBox1, "");
                if (textBox2.Text == "")
                {
                    error1.SetError(textBox2, "El dato no puede ser nulo.");
                    textBox2.Focus();
                    return;
                }
                error1.SetError(textBox2, "");
                if (textBox3.Text == "")
                {
                    error1.SetError(textBox3, "El dato no puede ser nulo.");
                    textBox3.Focus();
                    return;
                }
                error1.SetError(textBox3, "");
                if (textBox4.Text == "")
                {
                    error1.SetError(textBox4, "El dato no puede ser nulo.");
                    textBox4.Focus();
                    return;
                }
                error1.SetError(textBox4, "");
                if (textBox5.Text == "")
                {
                    error1.SetError(textBox5, "El dato no puede ser nulo.");
                    textBox5.Focus();
                    return;
                }
                error1.SetError(textBox5, "");
            }
            if (num == 3 || num == 4)
            {
                if (textBox1.Text == "")
                {
                    error1.SetError(textBox1, "El dato no puede ser nulo.");
                    textBox1.Focus();
                    return;
                }
                error1.SetError(textBox1, "");
                if (textBox2.Text == "")
                {
                    error1.SetError(textBox2, "El dato no puede ser nulo.");
                    textBox2.Focus();
                    return;
                }
                error1.SetError(textBox2, "");
                if (textBox3.Text == "")
                {
                    error1.SetError(textBox3, "El dato no puede ser nulo.");
                    textBox3.Focus();
                    return;
                }
                error1.SetError(textBox3, "");
                if (textBox4.Text == "")
                {
                    error1.SetError(textBox4, "El dato no puede ser nulo.");
                    textBox4.Focus();
                    return;
                }
                error1.SetError(textBox4, "");
            }
            if (num == 1)
            {
                cn.Open();
                string actualizar = "UPDATE empleados set documento=@documento, nombre=@nombre, barrio=@barrio WHERE documento=@documento";
                MySqlCommand cmd = new MySqlCommand(actualizar, cn);
                cmd.Parameters.AddWithValue("@documento", textBox1.Text);
                cmd.Parameters.AddWithValue("@nombre", textBox2.Text);
                cmd.Parameters.AddWithValue("@barrio", textBox3.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                dataGridView1.DataSource = llenar_Empleados();
            }
            if (num == 2)
            {
                cn.Open();
                string actualizar = "UPDATE libros set codigo=@codigo, titulo=@titulo, autor=@autor, Genero=@Genero, Tipo=@Tipo WHERE codigo=@codigo";
                MySqlCommand cmd = new MySqlCommand(actualizar, cn);
                cmd.Parameters.AddWithValue("@codigo", textBox1.Text);
                cmd.Parameters.AddWithValue("@titulo", textBox2.Text);
                cmd.Parameters.AddWithValue("@autor", textBox3.Text);
                cmd.Parameters.AddWithValue("@Genero", textBox4.Text);
                cmd.Parameters.AddWithValue("@Tipo", textBox5.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                dataGridView1.DataSource = llenar_Libros();
            }
            if (num == 3)
            {
                cn.Open();
                string actualizar = "UPDATE prestamos set codigo=@codigo, documento=@documento, fechaprestamo=@fechaprestamo, fechadevolucion=@fechadevolucion WHERE documento=@documento";
                MySqlCommand cmd = new MySqlCommand(actualizar, cn);
                cmd.Parameters.AddWithValue("@codigo", textBox1.Text);
                cmd.Parameters.AddWithValue("@documento", textBox2.Text);
                cmd.Parameters.AddWithValue("@fechaprestamo", textBox3.Text);
                cmd.Parameters.AddWithValue("@fechadevolucion", textBox4.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                dataGridView1.DataSource = llenar_Prestamos();
            }
            if (num == 4)
            {
                cn.Open();
                string actualizar = "UPDATE computadores set documentos=@documentos, nombres=@nombres, hora_de_inicio=@hora_de_inicio, hora_de_finalizacion=@hora_de_finalizacion WHERE documentos=@documentos";
                MySqlCommand cmd = new MySqlCommand(actualizar, cn);
                cmd.Parameters.AddWithValue("@documentos", textBox1.Text);
                cmd.Parameters.AddWithValue("@nombres", textBox2.Text);
                cmd.Parameters.AddWithValue("@hora_de_inicio", textBox3.Text);
                cmd.Parameters.AddWithValue("@hora_de_finalizacion", textBox4.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                dataGridView1.DataSource = llenar_Computadores();
            }
            if (num == 5)
            {
                cn.Open();
                string actualizar = "UPDATE socios set documento=@documento, nombre=@nombre, barrio=@barrio WHERE documento=@documento";
                MySqlCommand cmd = new MySqlCommand(actualizar, cn);
                cmd.Parameters.AddWithValue("@documento", textBox1.Text);
                cmd.Parameters.AddWithValue("@nombre", textBox2.Text);
                cmd.Parameters.AddWithValue("@barrio", textBox3.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                dataGridView1.DataSource = llenar_Socios();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (num == 1)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
            if (num == 2)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            }
            if (num == 3)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            if (num == 4)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }
            if (num == 5)
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (num == 1 || num == 5)
            {
                if (textBox1.Text == "")
                {
                    error1.SetError(textBox1, "El dato no puede ser nulo.");
                    textBox1.Focus();
                    return;
                }
                error1.SetError(textBox1, "");
                if (textBox2.Text == "")
                {
                    error1.SetError(textBox2, "El dato no puede ser nulo.");
                    textBox2.Focus();
                    return;
                }
                error1.SetError(textBox2, "");
                if (textBox3.Text == "")
                {
                    error1.SetError(textBox3, "El dato no puede ser nulo.");
                    textBox3.Focus();
                    return;
                }
                error1.SetError(textBox3, "");
            }
            if (num == 2)
            {
                if (textBox1.Text == "")
                {
                    error1.SetError(textBox1, "El dato no puede ser nulo.");
                    textBox1.Focus();
                    return;
                }
                error1.SetError(textBox1, "");
                if (textBox2.Text == "")
                {
                    error1.SetError(textBox2, "El dato no puede ser nulo.");
                    textBox2.Focus();
                    return;
                }
                error1.SetError(textBox2, "");
                if (textBox3.Text == "")
                {
                    error1.SetError(textBox3, "El dato no puede ser nulo.");
                    textBox3.Focus();
                    return;
                }
                error1.SetError(textBox3, "");
                if (textBox4.Text == "")
                {
                    error1.SetError(textBox4, "El dato no puede ser nulo.");
                    textBox4.Focus();
                    return;
                }
                error1.SetError(textBox4, "");
                if (textBox5.Text == "")
                {
                    error1.SetError(textBox5, "El dato no puede ser nulo.");
                    textBox5.Focus();
                    return;
                }
                error1.SetError(textBox5, "");
            }
            if (num == 3 || num == 4)
            {
                if (textBox1.Text == "")
                {
                    error1.SetError(textBox1, "El dato no puede ser nulo.");
                    textBox1.Focus();
                    return;
                }
                error1.SetError(textBox1, "");
                if (textBox2.Text == "")
                {
                    error1.SetError(textBox2, "El dato no puede ser nulo.");
                    textBox2.Focus();
                    return;
                }
                error1.SetError(textBox2, "");
                if (textBox3.Text == "")
                {
                    error1.SetError(textBox3, "El dato no puede ser nulo.");
                    textBox3.Focus();
                    return;
                }
                error1.SetError(textBox3, "");
                if (textBox4.Text == "")
                {
                    error1.SetError(textBox4, "El dato no puede ser nulo.");
                    textBox4.Focus();
                    return;
                }
                error1.SetError(textBox4, "");
            }
            if (num == 1)
            {
                cn.Open();
                string eliminar = "DELETE FROM empleados WHERE documento=@documento";
                MySqlCommand cmd = new MySqlCommand(eliminar, cn);
                cmd.Parameters.AddWithValue("@documento", textBox1.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                dataGridView1.DataSource = llenar_Empleados();
            }
            if (num == 2)
            {
                cn.Open();
                string eliminar = "DELETE FROM libros WHERE codigo=@codigo";
                MySqlCommand cmd = new MySqlCommand(eliminar, cn);
                cmd.Parameters.AddWithValue("@codigo", textBox1.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                dataGridView1.DataSource = llenar_Libros();
            }
            if (num == 3)
            {
                cn.Open();
                string eliminar = "DELETE FROM prestamos WHERE codigo=@codigo";
                MySqlCommand cmd = new MySqlCommand(eliminar, cn);
                cmd.Parameters.AddWithValue("@codigo", textBox1.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                dataGridView1.DataSource = llenar_Prestamos();
            }
            if (num == 4)
            {
                cn.Open();
                string eliminar = "DELETE FROM computadores WHERE documentos=@documentos";
                MySqlCommand cmd = new MySqlCommand(eliminar, cn);
                cmd.Parameters.AddWithValue("@documentos", textBox1.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                dataGridView1.DataSource = llenar_Computadores();
            }
            if (num == 5)
            {
                cn.Open();
                string eliminar = "DELETE FROM socios WHERE documento=@documento";
                MySqlCommand cmd = new MySqlCommand(eliminar, cn);
                cmd.Parameters.AddWithValue("@documento", textBox1.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                dataGridView1.DataSource = llenar_Socios();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}