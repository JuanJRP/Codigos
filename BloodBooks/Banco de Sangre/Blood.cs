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

namespace Banco_de_Sangre
{
    public partial class Blood : Form
    {
        SqlConnection cn;
        string Tabla;
        string Conecxion = ConfigurationManager.ConnectionStrings["Banco_de_Sangre.Properties.Settings.BaseConnectionString"].ConnectionString;
        
        public Blood()
        {
            InitializeComponent();
        }

        public void opcion(string Tabla, int Tipo)
        {
            switch (Tabla)
            {
                case "Donacion":
                    switch (Tipo)
                    {
                        case 1:
                            SqlCommand Guardar = new SqlCommand($"INSERT INTO Donante VALUES(@Nombre, @Cedula, @Telefono, @Edad, @Donacion, @Codigo)", cn);
                            cn.Open();
                            Guardar.Parameters.AddWithValue("@Nombre", dgrivTablas.CurrentRow.Cells[0].Value.ToString());
                            Guardar.Parameters.AddWithValue("@Cedula", dgrivTablas.CurrentRow.Cells[1].Value.ToString());
                            Guardar.Parameters.AddWithValue("@Telefono", dgrivTablas.CurrentRow.Cells[2].Value.ToString());
                            Guardar.Parameters.AddWithValue("@Edad", dgrivTablas.CurrentRow.Cells[3].Value.ToString());
                            Guardar.Parameters.AddWithValue("@Donacion", dgrivTablas.CurrentRow.Cells[4].Value.ToString());
                            Guardar.Parameters.AddWithValue("@Codigo", dgrivTablas.CurrentRow.Cells[5].Value.ToString());
                            Guardar.ExecuteNonQuery();
                            cn.Close();
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                    }
                    break;

                case "Donante":
                    switch (Tipo)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                    }
                    break;

                case "Entregas":
                    switch (Tipo)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                    }
                    break;

                case "Peticion":
                    switch (Tipo)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                    }
                    break;

                case "Usuario":
                    switch (Tipo)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                    }
                    break;
            }
        }

        public void Tablas(int opc = 0)
        {
            if (opc == 1)
            {
                lblAp.Visible = true;lblAn.Visible = true;lblBp.Visible = true;lblBn.Visible = true;lblOp.Visible = true;lblOn.Visible = true;
                lblABp.Visible = true;lblABn.Visible = true;lblInfo.Visible = true;picWhite.Visible = true;dgrivTablas.Visible = false;
                cmdAñadir.Visible = false;cmdBorrar.Visible = false;cmdBuscar.Visible = false;cmdModificar.Visible = false;
            }
            else
            {
                lblAp.Visible = false;lblAn.Visible = false;lblBp.Visible = false;lblBn.Visible = false;lblOp.Visible = false;
                lblOn.Visible = false;lblABp.Visible = false;lblABn.Visible = false;lblInfo.Visible = false;picWhite.Visible = false;
                dgrivTablas.Visible = true;
            }
        }
        public void Botones()
        {
            cmdAñadir.Visible = true;cmdBorrar.Visible = true;cmdBuscar.Visible = true;cmdModificar.Visible = true;
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
            dgrivTablas.DataSource = dt;
            return dt;
        }

        private void cmdInicio_Click(object sender, EventArgs e)
        {
            Tablas(1);
        }

        private void cmdDonantes_Click(object sender, EventArgs e)
        {
            Tablas();Botones();Tabla = "Donante";llenar($"SELECT * FROM {Tabla}");
        }

        private void cmdDonaciones_Click(object sender, EventArgs e)
        {
            Tablas();Botones();Tabla = "Donacion";llenar($"SELECT * FROM {Tabla}");
        }

        private void cmdPeticiones_Click(object sender, EventArgs e)
        {
            Tablas();Botones();Tabla = "Peticion";llenar($"SELECT * FROM {Tabla}");
        }

        private void cmdEntregados_Click(object sender, EventArgs e)
        {
            Tablas();Botones();Tabla = "Entregas";llenar($"SELECT * FROM {Tabla}");
        }
        private void cmdUsuarios_Click(object sender, EventArgs e)
        {
            Tablas();Botones();Tabla = "Usuario";llenar($"SELECT * FROM {Tabla}");
        }

        private void cmdAñadir_Click(object sender, EventArgs e)
        {
            opcion(Tabla,1);
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            opcion(Tabla,2);
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            opcion(Tabla,3);
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            opcion(Tabla,4);
        }
        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
