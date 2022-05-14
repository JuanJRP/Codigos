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
    public partial class Ingresar : Form
    {
        SqlConnection cn;
        string Conecxion = ConfigurationManager.ConnectionStrings["Colegio.Properties.Settings.Database1ConnectionString"].ConnectionString;
        string user = null, passwd = null, dato;
        int log = 0;
        public Ingresar()
        {
            InitializeComponent();
        }

        public DataTable Login(string dato)
        {
            cn = new SqlConnection(Conecxion);
            cn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand(dato, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.AllowUserToAddRows = false;
            if (dataGridView1.RowCount > 0)
            {
                user = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                passwd = Convert.ToString(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            }
            else
            {
                user = null;
                passwd = null;
            }
            return dt;
        }

        private void Ingresar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            log = 0;
            for(int i = 0; i < 4; i++)
            {
                if (i == 0)
                {
                    dato = $"SELECT Users,Passwords FROM Admins WHERE  Users = '{textBox1.Text}'";
                    Login(dato);
                    if (textBox1.Text == user && textBox2.Text == passwd)
                    {
                        Admins admins = new Admins();
                        admins.Show();
                        this.Close();
                        log = 1;
                    }
                }else if (i == 1)
                {
                    dato = $"SELECT Users,Passwords FROM Profesores WHERE  Users = '{textBox1.Text}'";
                    Login(dato);
                    if (textBox1.Text == user && textBox2.Text == passwd)
                    {
                        MessageBox.Show("yes teacher");
                        log = 1;
                    }
                }
                else if (i == 2)
                {
                    dato = $"SELECT Users,Passwords FROM Estudiantes WHERE  Users = '{textBox1.Text}'";
                    Login(dato);
                    if (textBox1.Text == user && textBox2.Text == passwd)
                    {
                        MessageBox.Show("yes estuden");
                        log = 1;
                    }
                }
                else if (i == 3 && log == 0)
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
            this.Close();
        }
    }
}
