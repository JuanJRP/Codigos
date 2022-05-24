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
        string dato, Nprofesor, insertar;
        int Opcion = 0, i = 0, R = 100;
        string[] vec = new string[100];

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
        public DataTable llenar3(string dato)
        {
            cn = new SqlConnection(Conecxion);
            cn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(dato, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            dataGridView3.DataSource = dt;
            return dt;
        }
        public DataTable llenar4(string dato)
        {
            cn = new SqlConnection(Conecxion);
            cn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(dato, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            dataGridView4.DataSource = dt;
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
            DataTable dt = new DataTable();
            dataGridView2.Visible = true;
            dataGridView2.DataSource = dt;
            if (textBox6.Text == "0")
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
                MessageBox.Show("La configuracion ya se ha realizado.");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dataGridView2.Visible = true;
            dataGridView2.DataSource = dt;
            if (textBox6.Text == "0")
            {
                MessageBox.Show("Primero se debe configurar la materia");
            }
            else
            {
                groupBox1.Visible = false;
                groupBox3.Visible = false;
                groupBox2.Visible = true;
                dato = $"SELECT * FROM {textBox1.Text} WHERE Id != 1";
                llenar2(dato);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Ingresar ingresar = new Ingresar();
            ingresar.Show();
            this.Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se reciben numeros", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se reciben numeros", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label9.Text = Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value.ToString());
            textBox5.Text = Convert.ToString(dataGridView2.CurrentRow.Cells[0].Value.ToString());
            label8.Text = Convert.ToString(dataGridView2.CurrentRow.Cells[1].Value.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                MessageBox.Show("No se permiten datos nulos");
            }
            else
            {
                for(int j = 1; j <= Convert.ToInt32(textBox8.Text); j++)
                {
                    insertar = $"ALTER TABLE [dbo].{textBox1.Text}_Asistencia ADD [Clase N° {j}] VARCHAR (150) NULL;";
                    cn.Open();
                    SqlCommand cmd5 = new SqlCommand(insertar, cn);
                    cmd5.ExecuteNonQuery();
                    cn.Close();
                }
                insertar = $"UPDATE VARIABLE set Dato2 = '1' WHERE Nombre = '{textBox1.Text}'";
                cn.Open();
                SqlCommand cmd2 = new SqlCommand(insertar, cn);
                cmd2.ExecuteNonQuery();
                cn.Close();
                dato = $"SELECT * FROM VARIABLE WHERE Nombre = '{textBox1.Text}'";
                llenar3(dato);
                textBox7.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
                MessageBox.Show("Configuracion exitosa.");
                label6.Visible = true;
                button8.Visible = true;
                button9.Visible = true;
                textBox8.Visible = false;
                button7.Visible = false;
                textBox9.Visible = true;
                label10.Visible = true;
                label7.Text = "Nombre";
                dato = $"SELECT * FROM {textBox1.Text}_Asistencia";
                llenar2(dato);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dato = $"SELECT * FROM {textBox1.Text}_Asistencia";
            insertar = $"UPDATE {textBox1.Text}_Asistencia set [Clase N° {textBox9.Text}] = @asis WHERE Id=@Id";
            cn.Open();
            SqlCommand cmd = new SqlCommand(insertar, cn);
            cmd.Parameters.AddWithValue("@asis", button9.Text);
            cmd.Parameters.AddWithValue("@Id", textBox5.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
            dataGridView2.DataSource = llenar2(dato);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            dato = $"SELECT * FROM {textBox1.Text}_Asistencia";
            insertar = $"UPDATE {textBox1.Text}_Asistencia set [Clase N° {textBox9.Text}] = @asis WHERE Id=@Id";
            cn.Open();
            SqlCommand cmd = new SqlCommand(insertar, cn);
            cmd.Parameters.AddWithValue("@asis", button8.Text);
            cmd.Parameters.AddWithValue("@Id", textBox5.Text);
            cmd.ExecuteNonQuery();
            cn.Close();
            dataGridView2.DataSource = llenar2(dato);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox4.Text) > 5 || Convert.ToDouble(textBox4.Text) < 0)
            {
                MessageBox.Show("Valor fuera de los parametros");
            }
            else
            {
                dato = $"SELECT * FROM {textBox1.Text} WHERE Id != 1";
                insertar = $"UPDATE {textBox1.Text} set [Nota {textBox3.Text}]=@Nota WHERE Id=@Id";
                cn.Open();
                SqlCommand cmd = new SqlCommand(insertar, cn);
                cmd.Parameters.AddWithValue("@Nota", textBox4.Text);
                cmd.Parameters.AddWithValue("@Id", textBox5.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                dataGridView2.DataSource = llenar2(dato);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dataGridView2.Visible = true;
            dataGridView2.DataSource = dt;
            if (textBox6.Text == "0")
            {
                MessageBox.Show("Primero se debe configurar la materia");
            }
            else
            {
                if (textBox7.Text != "0")
                {
                    groupBox1.Visible = false;
                    groupBox2.Visible = false;
                    groupBox3.Visible = true;
                    label7.Text = "Nombre";
                    label6.Visible = true;
                    button8.Visible = true;
                    button9.Visible = true;
                    button7.Visible = false;
                    textBox9.Visible = true;
                    dato = $"SELECT * FROM {textBox1.Text}_Asistencia";
                    llenar2(dato);
                }
                else
                {
                    groupBox1.Visible = false;
                    groupBox2.Visible = false;
                    groupBox3.Visible = true;
                    label6.Visible = false;
                    button8.Visible = false;
                    button9.Visible = false;
                    textBox8.Visible = true;
                    textBox9.Visible = false;
                    label10.Visible = false;
                    label7.Text = "Ingrese la cantidad de clases";
                }
                
                
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
                dato = $"SELECT * FROM {textBox1.Text} WHERE Id != 1";
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
                    Opcion = 1;
                    MessageBox.Show("Configuracion exitosa.");
                    insertar = $"UPDATE VARIABLE set Dato = {Opcion} WHERE Nombre = '{textBox1.Text}'";
                    cn.Open();
                    SqlCommand cmd2 = new SqlCommand(insertar, cn);
                    cmd2.ExecuteNonQuery();
                    cn.Close();
                    dato = $"SELECT * FROM VARIABLE WHERE Nombre = '{textBox1.Text}'";
                    llenar3(dato);
                    textBox6.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
                    dato = $"INSERT INTO [dbo].{textBox1.Text}_Asistencia(Nombre) SELECT Materia.Nombre AS Nombre FROM auxAsignaturas, Clases, Materia where Clases.Asignatura = Materia.Asignatura and Clases.Nombre = '{Nprofesor}' GROUP BY Materia.Nombre;";
                    llenar2(dato);
                    dato = $"INSERT INTO [dbo].{textBox1.Text}(Nombre) SELECT Materia.Nombre AS Nombre FROM auxAsignaturas, Clases, Materia where Clases.Asignatura = Materia.Asignatura and Clases.Nombre = '{Nprofesor}' GROUP BY Materia.Nombre;";
                    llenar2(dato);
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
            dato = $"SELECT * FROM VARIABLE WHERE Nombre = '{textBox1.Text}'";
            llenar3(dato);
            textBox6.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            textBox7.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView2.AllowUserToAddRows = false;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            label2.Visible = false;
            label3.Visible = false;
            button4.Visible = false;
            textBox2.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            DataTable dt = new DataTable();
            dataGridView2.Visible = true;
            dataGridView2.DataSource = dt;
            dato = $"SELECT * FROM {textBox1.Text} WHERE Id != 1";
            llenar2(dato);
        }
    }
}
