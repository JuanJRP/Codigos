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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string miConexion = ConfigurationManager.ConnectionStrings["WindowsFormsApp1.Properties.Settings.Database2ConnectionString"].ConnectionString;
            cn = new SqlConnection(miConexion);
            cn.Open();
            DataTable dt = new DataTable();
            string llenar = "SELECT * FROM Admins";
            SqlCommand cmd = new SqlCommand(llenar, cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            dataGridView1.DataSource = dt;
            dataGridView1.Size = new Size(460, 345);
        }
    }
}
