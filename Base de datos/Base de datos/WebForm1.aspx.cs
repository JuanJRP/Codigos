using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Web;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace Base_de_datos
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int num;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        //CONECXION---------------------------------------------------------------------------------------------
        static string conexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=biblioteca;UID=root;PASSWORDS=;";
        MySqlConnection cn = new MySqlConnection(conexion);
        //------------------------------------------------------------------------------------------------------

        //LLENADO DE TABLAS-------------------------------------------------------------------------------------
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
        public DataTable llenar_Dele()
        {
            cn.Open();
            DataTable dt = new DataTable();
            string llenar = "delete  from computadores where documentos = '10014701'";
            MySqlCommand cmd = new MySqlCommand(llenar, cn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            cn.Close();
            return dt;
        }
        //--------------------------------------------------------------------------------------------------------------
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        //INSERTAR DATOS-------------------------------------------------------------------------------------------------
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (TextBox6.Text == "1")
            {
                cn.Open();
                string insertar;
                insertar = "INSERT INTO empleados(documento,nombre,barrio)values(@documento,@nombre,@barrio)";
                MySqlCommand cmd = new MySqlCommand(insertar, cn);
                cmd.Parameters.AddWithValue("@documento", TextBox1.Text);
                cmd.Parameters.AddWithValue("@nombre", TextBox2.Text);
                cmd.Parameters.AddWithValue("@barrio", TextBox3.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                GridView1.DataSource = llenar_Empleados();
                GridView1.DataBind();
            }
            if (TextBox6.Text == "2")
            {
                cn.Open();
                string insertar;
                insertar = "INSERT INTO libros(codigo,titulo,autor,Genero,Tipo)values(@codigo,@titulo,@autor,@Genero,@Tipo)";
                MySqlCommand cmd = new MySqlCommand(insertar, cn);
                cmd.Parameters.AddWithValue("@codigo", TextBox1.Text);
                cmd.Parameters.AddWithValue("@titulo", TextBox2.Text);
                cmd.Parameters.AddWithValue("@autor", TextBox3.Text);
                cmd.Parameters.AddWithValue("@Genero", TextBox4.Text);
                cmd.Parameters.AddWithValue("@Tipo", TextBox5.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                GridView1.DataSource = llenar_Libros();
                GridView1.DataBind();
            }
            if (TextBox6.Text == "3")
            {
                cn.Open();
                string insertar;
                insertar = "INSERT INTO prestamos(codigo,documento,fechaprestamo,fechadevolucion)values(@codigo,@documento,@fechaprestamo,@fechadevolucion)";
                MySqlCommand cmd = new MySqlCommand(insertar, cn);
                cmd.Parameters.AddWithValue("@codigo", TextBox1.Text);
                cmd.Parameters.AddWithValue("@documento", TextBox2.Text);
                cmd.Parameters.AddWithValue("@fechaprestamo", TextBox3.Text);
                cmd.Parameters.AddWithValue("@fechadevolucion", TextBox4.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                GridView1.DataSource = llenar_Prestamos();
                GridView1.DataBind();
            }
            if (TextBox6.Text == "4")
            {
                cn.Open();
                string insertar;
                insertar = "INSERT INTO computadores(documentos,nombres,hora_de_inicio,hora_de_finalizacion)values(@documentos,@nombres,@hora_de_inicio,@hora_de_finalizacion)";
                MySqlCommand cmd = new MySqlCommand(insertar, cn);
                cmd.Parameters.AddWithValue("@documentos", TextBox1.Text);
                cmd.Parameters.AddWithValue("@nombres", TextBox2.Text);
                cmd.Parameters.AddWithValue("@hora_de_inicio", TextBox3.Text);
                cmd.Parameters.AddWithValue("@hora_de_finalizacion", TextBox4.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                GridView1.DataSource = llenar_Computadores();
                GridView1.DataBind();
            }
            if (TextBox6.Text == "5")
            {
                cn.Open();
                string insertar;
                insertar = "INSERT INTO socios(documento,nombre,barrio)values(@documento,@nombre,@barrio)";
                MySqlCommand cmd = new MySqlCommand(insertar, cn);
                cmd.Parameters.AddWithValue("@documento", TextBox1.Text);
                cmd.Parameters.AddWithValue("@nombre", TextBox2.Text);
                cmd.Parameters.AddWithValue("@barrio", TextBox3.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                GridView1.DataSource = llenar_Socios();
                GridView1.DataBind();
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //MODIFICAR DATOS--------------------------------------------------------------------------------------------------------
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (TextBox6.Text == "1")
            {
                cn.Open();
                string actualizar = "UPDATE empleados set documento=@documento, nombre=@nombre, barrio=@barrio WHERE documento=@documento";
                MySqlCommand cmd = new MySqlCommand(actualizar, cn);
                cmd.Parameters.AddWithValue("@documento", TextBox1.Text);
                cmd.Parameters.AddWithValue("@nombre", TextBox2.Text);
                cmd.Parameters.AddWithValue("@barrio", TextBox3.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                GridView1.DataSource = llenar_Empleados();
                GridView1.DataBind();
            }
            if (TextBox6.Text == "2")
            {
                cn.Open();
                string actualizar = "UPDATE libros set codigo=@codigo, titulo=@titulo, autor=@autor, Genero=@Genero, Tipo=@Tipo WHERE codigo=@codigo";
                MySqlCommand cmd = new MySqlCommand(actualizar, cn);
                cmd.Parameters.AddWithValue("@codigo", TextBox1.Text);
                cmd.Parameters.AddWithValue("@titulo", TextBox2.Text);
                cmd.Parameters.AddWithValue("@autor", TextBox3.Text);
                cmd.Parameters.AddWithValue("@Genero", TextBox4.Text);
                cmd.Parameters.AddWithValue("@Tipo", TextBox5.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                GridView1.DataSource = llenar_Libros();
                GridView1.DataBind();
            }
            if (TextBox6.Text == "3")
            {
                cn.Open();
                string actualizar = "UPDATE prestamos set codigo=@codigo, documento=@documento, fechaprestamo=@fechaprestamo, fechadevolucion=@fechadevolucion WHERE documento=@documento";
                MySqlCommand cmd = new MySqlCommand(actualizar, cn);
                cmd.Parameters.AddWithValue("@codigo", TextBox1.Text);
                cmd.Parameters.AddWithValue("@documento", TextBox2.Text);
                cmd.Parameters.AddWithValue("@fechaprestamo", TextBox3.Text);
                cmd.Parameters.AddWithValue("@fechadevolucion", TextBox4.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                GridView1.DataSource = llenar_Prestamos();
                GridView1.DataBind();
            }
            if (TextBox6.Text == "4")
            {
                cn.Open();
                string actualizar = "UPDATE computadores set documentos=@documentos, nombres=@nombres, hora_de_inicio=@hora_de_inicio, hora_de_finalizacion=@hora_de_finalizacion WHERE documentos=@documentos";
                MySqlCommand cmd = new MySqlCommand(actualizar, cn);
                cmd.Parameters.AddWithValue("@documentos", TextBox1.Text);
                cmd.Parameters.AddWithValue("@nombres", TextBox2.Text);
                cmd.Parameters.AddWithValue("@hora_de_inicio", TextBox3.Text);
                cmd.Parameters.AddWithValue("@hora_de_finalizacion", TextBox4.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                GridView1.DataSource = llenar_Computadores();
                GridView1.DataBind();
            }
            if (TextBox6.Text == "5")
            {
                cn.Open();
                string actualizar = "UPDATE socios set documento=@documento, nombre=@nombre, barrio=@barrio WHERE documento=@documento";
                MySqlCommand cmd = new MySqlCommand(actualizar, cn);
                cmd.Parameters.AddWithValue("@documento", TextBox1.Text);
                cmd.Parameters.AddWithValue("@nombre", TextBox2.Text);
                cmd.Parameters.AddWithValue("@barrio", TextBox3.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                GridView1.DataSource = llenar_Socios();
                GridView1.DataBind();
            }
        }
        //------------------------------------------------------------------------------------------------------------------------
        
        //BORRAR DATOS----------------------------------------------------------------------------------------------------------
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (TextBox6.Text == "1")
            {
                cn.Open();
                string eliminar = "DELETE FROM empleados WHERE documento=@documento";
                MySqlCommand cmd = new MySqlCommand(eliminar, cn);
                cmd.Parameters.AddWithValue("@documento", TextBox1.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                GridView1.DataSource = llenar_Empleados();
                GridView1.DataBind();
            }
            if (TextBox6.Text == "2")
            {
                cn.Open();
                string eliminar = "DELETE FROM libros WHERE codigo=@codigo";
                MySqlCommand cmd = new MySqlCommand(eliminar, cn);
                cmd.Parameters.AddWithValue("@codigo", TextBox1.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                GridView1.DataSource = llenar_Libros();
                GridView1.DataBind();
            }
            if (TextBox6.Text == "3")
            {
                cn.Open();
                string eliminar = "DELETE FROM prestamos WHERE codigo=@codigo";
                MySqlCommand cmd = new MySqlCommand(eliminar, cn);
                cmd.Parameters.AddWithValue("@codigo", TextBox1.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                GridView1.DataSource = llenar_Prestamos();
                GridView1.DataBind();
            }
            if (TextBox6.Text == "4")
            {
                cn.Open();
                string eliminar = "DELETE FROM computadores WHERE documentos=@documentos";
                MySqlCommand cmd = new MySqlCommand(eliminar, cn);
                cmd.Parameters.AddWithValue("@documentos", TextBox1.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                GridView1.DataSource = llenar_Computadores();
            }
            if (TextBox6.Text == "5")
            {
                cn.Open();
                string eliminar = "DELETE FROM socios WHERE documento=@documento";
                MySqlCommand cmd = new MySqlCommand(eliminar, cn);
                cmd.Parameters.AddWithValue("@documento", TextBox1.Text);
                cmd.ExecuteNonQuery();
                cn.Close();
                GridView1.DataSource = llenar_Socios();
                GridView1.DataBind();
            }
        }
        //----------------------------------------------------------------------------------------------------------------------
        
        //MOSTRAR TABLAS--------------------------------------------------------------------------------------------------------
        protected void Button4_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = llenar_Empleados();
            GridView1.DataBind();
            TextBox1.Visible = true;
            TextBox2.Visible = true;
            TextBox3.Visible = true;
            TextBox4.Visible = false;
            TextBox5.Visible = false;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = Convert.ToString(1);
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = llenar_Libros();
            GridView1.DataBind();
            TextBox1.Visible = true;
            TextBox2.Visible = true;
            TextBox3.Visible = true;
            TextBox4.Visible = true;
            TextBox5.Visible = true;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = Convert.ToString(2);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = llenar_Prestamos();
            GridView1.DataBind();
            TextBox1.Visible = true;
            TextBox2.Visible = true;
            TextBox3.Visible = true;
            TextBox4.Visible = true;
            TextBox5.Visible = false;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = Convert.ToString(3);
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = llenar_Computadores();
            GridView1.DataBind();
            TextBox1.Visible = true;
            TextBox2.Visible = true;
            TextBox3.Visible = true;
            TextBox4.Visible = true;
            TextBox5.Visible = false;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = Convert.ToString(4);
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            GridView1.DataSource = llenar_Socios();
            GridView1.DataBind();
            TextBox1.Visible = true;
            TextBox2.Visible = true;
            TextBox3.Visible = true;
            TextBox4.Visible = false;
            TextBox5.Visible = false;
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
            TextBox5.Text = "";
            TextBox6.Text = Convert.ToString(5);
        }
        //----------------------------------------------------------------------------------------------------------------------------
    }
}