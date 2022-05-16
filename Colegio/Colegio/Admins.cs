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
        int opcion,btn = 0,Btn2 = 0;

        public void Borrar()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }
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
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            dato = $"SELECT * FROM Admins";
            llenar(dato);
            button7.Visible = false;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = false;
            button12.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            btn = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            dato = $"SELECT * FROM auxAsignaturas";
            llenar(dato);
            button7.Visible = false;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = false;
            button12.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            btn = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            button11.Visible = true;
            button12.Visible = true;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            button11.Text = "Añadir Profesor";
            button12.Text = "Asignar materia a un Profesor";
            btn = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            button11.Text = "Añadir Estudiante";
            button12.Text = "Asignar materia a un Estudiante";
            button11.Visible = true;
            button12.Visible = true;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button10.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            btn = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt;
            dato = $"SELECT * FROM Padres";
            llenar(dato);
            button7.Visible = false;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = false;
            button12.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            btn = 5;
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

                    dato = $"SELECT * FROM Admins";
                    insertar = "INSERT INTO Admins(Users, Passwords)values(@Users, @Passwords)";
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(insertar, cn);
                    cmd.Parameters.AddWithValue("@Users", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Passwords", textBox2.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    dataGridView1.DataSource = llenar(dato);
                    Borrar();

                }
                else if (opcion == 2)
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
                    dato = $"SELECT * Admins";
                    insertar = "UPDATE Admins set Users=@Users, Passwords=@Passwords WHERE Users=@Users";
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(insertar, cn);
                    cmd.Parameters.AddWithValue("@Users", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Passwords", textBox2.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    dataGridView1.DataSource = llenar(dato);
                    Borrar();
                }
                else if (opcion == 3)
                {
                    if (textBox1.Text == "")
                    {
                        error1.SetError(textBox1, "El dato no puede ser nulo.");
                        textBox1.Focus();
                        return;
                    }
                    error1.SetError(textBox1, "");
                    error1.SetError(textBox2, "");
                    dato = $"SELECT * FROM Admins";
                    insertar = "DELETE FROM Admins WHERE Users=@Users";
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(insertar, cn);
                    cmd.Parameters.AddWithValue("@Users", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    dataGridView1.DataSource = llenar(dato);
                    Borrar();
                }
            }
            else if (btn == 2)
            {
                if (opcion == 1)
                {
                    if (textBox1.Text == "")
                    {
                        error1.SetError(textBox1, "El dato no puede ser nulo.");
                        textBox1.Focus();
                        return;
                    }
                    error1.SetError(textBox1, "");
                    if (textBox3.Text == "")
                    {
                        error1.SetError(textBox3, "El dato no puede ser nulo.");
                        textBox3.Focus();
                        return;
                    }
                    error1.SetError(textBox3, "");
                    dato = $"SELECT * FROM auxAsignaturas";
                    insertar = "INSERT INTO auxAsignaturas(Asignatura)values(@Asignatura)";
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(insertar, cn);
                    string grado = $"{textBox1.Text}_{textBox3.Text}";
                    cmd.Parameters.AddWithValue("@Asignatura", grado);
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
                    insertar = $"INSERT INTO {textBox1.Text}_{textBox3.Text}(Nombre)values('Valor Nota')";
                    cn.Open();
                    SqlCommand cmd3 = new SqlCommand(insertar, cn);
                    cmd3.ExecuteNonQuery();
                    cn.Close();
                    Borrar();
                }
                else if (opcion == 2)
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
                    dato = $"SELECT * FROM auxAsignaturas";
                    insertar = "UPDATE auxAsignaturas set Asignatura=@Asignatura2 WHERE Asignatura=@Asignatura";
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(insertar, cn);
                    cmd.Parameters.AddWithValue("@Asignatura", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Asignatura2", textBox2.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    dataGridView1.DataSource = llenar(dato);
                    Borrar();
                }
                else if (opcion == 3)
                {
                    if (textBox1.Text == "")
                    {
                        error1.SetError(textBox1, "El dato no puede ser nulo.");
                        textBox1.Focus();
                        return;
                    }
                    error1.SetError(textBox1, "");
                    dato = $"SELECT * FROM auxAsignaturas";
                    insertar = "DELETE FROM auxAsignaturas WHERE Asignatura=@Asignatura";
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(insertar, cn);
                    cmd.Parameters.AddWithValue("@Asignatura", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    dataGridView1.DataSource = llenar(dato);
                    Borrar();
                }
            }
            else if (btn == 3)
            {
                if (opcion == 1)
                {
                    if (Btn2 == 0)
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
                        dato = $"SELECT * FROM Profesores";
                        insertar = "INSERT INTO Profesores(Users, Passwords)values(@Users, @Passwords)";
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(insertar, cn);
                        cmd.Parameters.AddWithValue("@Users", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Passwords", textBox2.Text);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        dataGridView1.DataSource = llenar(dato);
                        Borrar();
                    }
                    else if (Btn2 == 1)
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
                        dato = $"SELECT * FROM Clases";
                        insertar = "INSERT INTO Clases(Nombre, Asignatura)values(@Users, @Asignatura)";
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(insertar, cn);
                        cmd.Parameters.AddWithValue("@Users", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Asignatura", textBox2.Text);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        dataGridView1.DataSource = llenar(dato);
                        Borrar();
                    }
                }
                else if (opcion == 2)
                {
                    if (Btn2 == 0)
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
                        if (textBox5.Text == "")
                        {
                            error1.SetError(textBox5, "El dato no puede ser nulo.");
                            textBox5.Focus();
                            return;
                        }
                        error1.SetError(textBox5, "");
                        dato = $"SELECT * FROM Profesores";
                        insertar = "UPDATE Profesores set Users=@Users, Passwords=@Passwords WHERE Id=@Id";
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(insertar, cn);
                        cmd.Parameters.AddWithValue("@Users", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Passwords", textBox2.Text);
                        cmd.Parameters.AddWithValue("@Id", textBox5.Text);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        dataGridView1.DataSource = llenar(dato);
                        Borrar();
                    }
                    else if (Btn2 == 1)
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
                        if (textBox5.Text == "")
                        {
                            error1.SetError(textBox5, "El dato no puede ser nulo.");
                            textBox5.Focus();
                            return;
                        }
                        error1.SetError(textBox5, "");
                        dato = $"SELECT * FROM Clases";
                        insertar = "UPDATE Clases set Nombre=@Nombre, Asignatura=@Asignatura WHERE Id=@Id";
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(insertar, cn);
                        cmd.Parameters.AddWithValue("@Nombre", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Asignatura", textBox2.Text);
                        cmd.Parameters.AddWithValue("@Id", textBox5.Text);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        dataGridView1.DataSource = llenar(dato);
                        Borrar();
                    }
                }
                else if (opcion == 3)
                {
                    if (Btn2 == 0)
                    {
                        if (textBox1.Text == "")
                        {
                            error1.SetError(textBox1, "El dato no puede ser nulo.");
                            textBox1.Focus();
                            return;
                        }
                        error1.SetError(textBox1, "");
                        dato = $"SELECT * FROM Profesores";
                        insertar = "DELETE FROM Profesores WHERE Users=@Users";
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(insertar, cn);
                        cmd.Parameters.AddWithValue("@Users", textBox1.Text);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        dataGridView1.DataSource = llenar(dato);
                        Borrar();
                    }
                    else if (Btn2 == 1)
                    {
                        if (textBox1.Text == "")
                        {
                            error1.SetError(textBox1, "El dato no puede ser nulo.");
                            textBox1.Focus();
                            return;
                        }
                        error1.SetError(textBox1, "");
                        dato = $"SELECT * FROM Clases";
                        insertar = "DELETE FROM Clases WHERE Nombre=@Nombre";
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(insertar, cn);
                        cmd.Parameters.AddWithValue("@Nombre", textBox1.Text);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        dataGridView1.DataSource = llenar(dato);
                        Borrar();
                    }
                }
            }
            else if (btn == 4)
            {
                if (opcion == 1)
                {
                    if (Btn2 == 0)
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
                        dato = $"SELECT * FROM Estudiantes";
                        insertar = "INSERT INTO Estudiantes(Users, Passwords)values(@Users, @Passwords)";
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(insertar, cn);
                        cmd.Parameters.AddWithValue("@Users", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Passwords", textBox2.Text);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        dataGridView1.DataSource = llenar(dato);
                        Borrar();
                    }
                    else if (Btn2 == 1)
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
                        dato = $"SELECT * FROM Materia";
                        insertar = "INSERT INTO Materia(Nombre, Asignatura)values(@Users, @Asignatura)";
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(insertar, cn);
                        cmd.Parameters.AddWithValue("@Users", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Asignatura", textBox2.Text);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        dataGridView1.DataSource = llenar(dato);
                        Borrar();
                    }
                }
                else if (opcion == 2)
                {
                    if (Btn2 == 0)
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
                        if (textBox5.Text == "")
                        {
                            error1.SetError(textBox5, "El dato no puede ser nulo.");
                            textBox5.Focus();
                            return;
                        }
                        error1.SetError(textBox5, "");
                        dato = $"SELECT * FROM Estudiantes";
                        insertar = "UPDATE Estudiantes set Users=@Users, Passwords=@Passwords WHERE Id=@Id";
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(insertar, cn);
                        cmd.Parameters.AddWithValue("@Users", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Passwords", textBox2.Text);
                        cmd.Parameters.AddWithValue("@Id", textBox5.Text);
                        MessageBox.Show(textBox5.Text);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        dataGridView1.DataSource = llenar(dato);
                        Borrar();
                    }
                    else if (Btn2 == 1)
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
                        if (textBox5.Text == "")
                        {
                            error1.SetError(textBox5, "El dato no puede ser nulo.");
                            textBox5.Focus();
                            return;
                        }
                        error1.SetError(textBox5, "");
                        dato = $"SELECT * FROM Materia";
                        insertar = "UPDATE Materia set Nombre=@Nombre, Asignatura=@Asignatura WHERE Id=@Id";
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(insertar, cn);
                        cmd.Parameters.AddWithValue("@Nombre", textBox1.Text);
                        cmd.Parameters.AddWithValue("@Asignatura", textBox2.Text);
                        cmd.Parameters.AddWithValue("@Id", textBox5.Text);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        dataGridView1.DataSource = llenar(dato);
                        Borrar();
                    }
                }
                else if (opcion == 3)
                {
                    if (Btn2 == 0)
                    {
                        if (textBox1.Text == "")
                        {
                            error1.SetError(textBox1, "El dato no puede ser nulo.");
                            textBox1.Focus();
                            return;
                        }
                        error1.SetError(textBox1, "");
                        dato = $"SELECT * FROM Estudiantes";
                        insertar = "DELETE FROM Estudiantes WHERE Users=@Users";
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(insertar, cn);
                        cmd.Parameters.AddWithValue("@Users", textBox1.Text);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        dataGridView1.DataSource = llenar(dato);
                        Borrar();
                    }
                    else if (Btn2 == 1)
                    {
                        if (textBox1.Text == "")
                        {
                            error1.SetError(textBox1, "El dato no puede ser nulo.");
                            textBox1.Focus();
                            return;
                        }
                        error1.SetError(textBox1, "");
                        dato = $"SELECT * FROM Materia";
                        insertar = "DELETE FROM Materia WHERE Nombre=@Nombre";
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(insertar, cn);
                        cmd.Parameters.AddWithValue("@Nombre", textBox1.Text);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                        dataGridView1.DataSource = llenar(dato);
                        Borrar();
                    }
                }
            }
            else if (btn == 5)
            {
                if (opcion == 1)
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
                    dato = $"SELECT * FROM Padres";
                    insertar = "INSERT INTO Padres(Estudiante, Padre, Telefono, Celular)values(@Estudiante, @Padre, @Telefono, @Celular)";
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(insertar, cn);
                    cmd.Parameters.AddWithValue("@Estudiante", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Padre", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Telefono", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Celular", textBox4.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    dataGridView1.DataSource = llenar(dato);
                    Borrar();
                }
                else if (opcion == 2)
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
                    dato = $"SELECT * FROM Padres";
                    insertar = "UPDATE Padres set Estudiante=@Estudiante, Padre=@Padre, Telefono=@Telefono,Celular=@Celular WHERE Id=@Id";
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(insertar, cn);
                    cmd.Parameters.AddWithValue("@Estudiante", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Padre", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Telefono", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Celular", textBox4.Text);
                    cmd.Parameters.AddWithValue("@Id", textBox5.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    dataGridView1.DataSource = llenar(dato);
                    Borrar();
                }
                else if (opcion == 3)
                {
                    if (textBox1.Text == "")
                    {
                        error1.SetError(textBox1, "El dato no puede ser nulo.");
                        textBox1.Focus();
                        return;
                    }
                    error1.SetError(textBox1, "");
                    dato = $"SELECT * FROM Padres";
                    insertar = "DELETE FROM Padres WHERE Padre=@Padre";
                    cn.Open();
                    SqlCommand cmd = new SqlCommand(insertar, cn);
                    cmd.Parameters.AddWithValue("@Padre", textBox1.Text);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    dataGridView1.DataSource = llenar(dato);
                    Borrar();
                }
            }
        }

        public void button8_Click(object sender, EventArgs e)
        {
            if (btn == 1)
            {
                Borrar();
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
                Borrar();
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
                if (Btn2 == 0)
                {
                    dato = $"SELECT * FROM Profesores";
                    llenar(dato);
                    Borrar();
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    button7.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    textBox5.Visible = false;
                    label1.Text = "Usuario";
                    label2.Text = "Contraseña";
                    button7.Text = "Añadir Datos";
                    opcion = 1;
                }
                else if(Btn2 == 1)
                {
                    dato = $"SELECT * FROM Clases";
                    llenar(dato);
                    Borrar();
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    button7.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    textBox5.Visible = false;
                    label1.Text = "Nombre";
                    label2.Text = "Asignatura";
                    button7.Text = "Añadir Datos";
                    opcion = 1;
                }
            }
            else if (btn == 4)
            {
                if (Btn2 == 0)
                {
                    dato = $"SELECT * FROM Estudiantes";
                    llenar(dato);
                    Borrar();
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    button7.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    textBox5.Visible = false;
                    label1.Text = "Usuario";
                    label2.Text = "Contraseña";
                    button7.Text = "Añadir Datos";
                    opcion = 1;
                }
                else if (Btn2 == 1)
                {
                    dato = $"SELECT * FROM Materia";
                    llenar(dato);
                    Borrar();
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    button7.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = false;
                    textBox5.Visible = false;
                    label1.Text = "Nombre";
                    label2.Text = "Asignatura";
                    button7.Text = "Añadir Datos";
                    opcion = 1;
                }
            }
            else if (btn == 5)
            {
                dato = $"SELECT * FROM Padres";
                llenar(dato);
                Borrar();
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
                label1.Text = "Estudiante";
                label2.Text = "Padre";
                label3.Text = "Telefono";
                label4.Text = "Celular";
                opcion = 1;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (btn == 1)
            {
                Borrar();
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
                Borrar();
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
                if (Btn2 == 0)
                {
                    dato = $"SELECT * FROM Profesores";
                    llenar(dato);
                    Borrar();
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    button7.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = true;
                    textBox5.Visible = true;
                    label1.Text = "Usuario";
                    label2.Text = "Contraseña";
                    label5.Text = "Id A Modificar";
                    button7.Text = "Modificar Datos";
                    opcion = 2;
                }
                else if (Btn2 == 1)
                {
                    dato = $"SELECT * FROM Clases";
                    llenar(dato);
                    Borrar();
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    button7.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = true;
                    textBox5.Visible = true;
                    label1.Text = "Nombre";
                    label2.Text = "Asignatura";
                    label5.Text = "Id A Modificar";
                    button7.Text = "Modificar Datos";
                    opcion = 2;
                }
            }
            else if (btn == 4)
            {
                if (Btn2 == 0)
                {
                    dato = $"SELECT * FROM Estudiantes";
                    llenar(dato);
                    Borrar();
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    button7.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = true;
                    textBox5.Visible = true;
                    label1.Text = "Usuario";
                    label2.Text = "Contraseña";
                    label5.Text = "Id A Modificar";
                    button7.Text = "Modificar Datos";
                    opcion = 2;
                }
                else if (Btn2 == 1)
                {
                    dato = $"SELECT * FROM Materia";
                    llenar(dato);
                    Borrar();
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    button7.Visible = true;
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = false;
                    label4.Visible = false;
                    label5.Visible = true;
                    textBox5.Visible = true;
                    label1.Text = "Nombre";
                    label2.Text = "Asignatura";
                    label5.Text = "Id A Modificar";
                    button7.Text = "Modificar Datos";
                    opcion = 2;
                }
            }
            else if (btn == 5)
            {
                dato = $"SELECT * FROM Padres";
                llenar(dato);
                Borrar();
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
                label5.Text = "Id A Modificar";
                label1.Text = "Estudiante";
                label2.Text = "Padre";
                label3.Text = "Telefono";
                label4.Text = "Celular";
                opcion = 2;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Visible = false;
            button12.Visible = false;
            button7.Visible = false;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            Btn2 = 0;
            button8_Click(sender, e);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Btn2 = 1;
            button11.Visible = false;
            button12.Visible = false;
            button7.Visible = false;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            button8_Click(sender, e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (btn == 1)
            {
                Borrar();
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
                Borrar();
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
                if (Btn2 == 0)
                {
                    dato = $"SELECT * FROM Profesores";
                    llenar(dato);
                    Borrar();
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
                    label1.Text = "Usuario";
                    label2.Text = "Asignatura";
                    label3.Text = "Usuario";
                    label4.Text = "Contraseña";
                    button7.Text = "Borrar Datos";
                    opcion = 3;
                }
                else if (Btn2 == 1)
                {
                    dato = $"SELECT * FROM Clases";
                    llenar(dato);
                    Borrar();
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
            else if (btn == 4)
            {
                if (Btn2 == 0)
                {
                    dato = $"SELECT * FROM Estudiantes";
                    llenar(dato);
                    Borrar();
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
                    label1.Text = "Usuario";
                    label2.Text = "Asignatura";
                    label3.Text = "Usuario";
                    label4.Text = "Contraseña";
                    button7.Text = "Borrar Datos";
                    opcion = 3;
                }
                else if (Btn2 == 1)
                {
                    dato = $"SELECT * FROM Materia";
                    llenar(dato);
                    Borrar();
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
            else if (btn == 5)
            {
                dato = $"SELECT * FROM Padres";
                llenar(dato);
                Borrar();
                textBox1.Visible = true;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                button7.Visible = true;
                label1.Visible = true;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                textBox5.Visible = false;
                label5.Text = "Id A Modificar";
                label1.Text = "Padre";
                label2.Text = "Telefono";
                label3.Text = "Celular";
                opcion = 3;
            }
        }

        private void Admins_Load(object sender, EventArgs e)
        {

        }
    }
}