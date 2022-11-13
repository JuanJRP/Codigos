using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System.Data;
using System.Collections;

namespace Conexion
{
    public class Tipos
    {
        static string conexion = "SERVER=127.0.0.1;PORT=3306;DATABASE=datacloud;UID=root;PASSWORDS=;";
        static public int creado = 0;
        static public string Registrar(string Usuario_r, string Contraseña_r, string Correo, string Telefono)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection(conexion);
                cn.Open();
                string Query = "INSERT INTO tblUsuario VALUES(@strNombre,@strContraseña,@strCorreo,@intTelefono)";
                MySqlCommand cmd = new MySqlCommand(Query, cn);
                cmd.Parameters.AddWithValue("@strNombre", Usuario_r);
                cmd.Parameters.AddWithValue("@strContraseña", Contraseña_r);
                cmd.Parameters.AddWithValue("@strCorreo", Correo);
                cmd.Parameters.AddWithValue("@intTelefono", Telefono);
                cmd.ExecuteNonQuery();
                cn.Close();
                return ("Registro Exitoso.");
            }
            catch (Exception)
            {
                return ("Error al regsitrarse.");
            }
        }

        static public int Validacion(string Usuario, string Contraseña)
        {
            int Result = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection(conexion);
                cn.Open();
                string query = "SELECT COUNT(*) FROM tblUsuario WHERE strnombre = @strUsuario AND strContraseña = @strContraseña";
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@strUsuario", Usuario);
                cmd.Parameters.AddWithValue("@strContraseña", Contraseña);
                Result = Convert.ToInt32(cmd.ExecuteScalar());
                cn.Close();
            }
            catch (Exception) { }
            return Result;
        }

        static public int validarNom(string Usuario_r)
        {
            int Result = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection(conexion);
                cn.Open();
                string query = "SELECT COUNT(*) FROM tblUsuario WHERE strUsuario = @strUsuario";
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@strUsuario", Usuario_r);
                Result = Convert.ToInt32(cmd.ExecuteScalar());
                cn.Close();
            }
            catch (Exception) { }
            return Result;
        }

        static public DataTable Archivos(string Usuario)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection(conexion);
                cn.Open();
                DataTable dT = new DataTable();
                string query = "SELECT strNombreArch FROM tblArchivo WHERE strUsuario = @strUsuario";
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@strUsuario", Usuario);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dT);
                cn.Close();
                return dT;
            }
            catch (Exception)
            {
                MySqlConnection cn = new MySqlConnection(conexion);
                cn.Open();
                DataTable dT = new DataTable(); 
                cn.Close();
                return dT;
            }
        }

        static public DataTable Importar(string archivo, string usuario)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection(conexion);
                cn.Open();
                DataTable dT = new DataTable();
                string query = $"SELECT * FROM {archivo}_{usuario};";
                MySqlCommand cmd = new MySqlCommand(query, cn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dT);
                cn.Close();
                return dT;
            }
            catch (Exception)
            {
                MySqlConnection cn = new MySqlConnection(conexion);
                cn.Open();
                DataTable dT = new DataTable();
                cn.Close();
                return dT;
            }
        }

        static public void llenarTabla(string archivo, string usuario)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection(conexion);
                cn.Open();
                string query = $"INSERT INTO tblArchivo VALUES(@archivo,@nombre,@tipo);";
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@archivo", archivo);
                cmd.Parameters.AddWithValue("@nombre", usuario);
                cmd.Parameters.AddWithValue("@tipo", "CSV");
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (Exception) { }
        }

        static public void borradoArch(string archivo, string Usuario)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection(conexion);
                cn.Open();
                string Query = $"DELETE FROM tblArchivo WHERE strNombreArch = @strArchivo AND strUsuario = @strUsuario";
                MySqlCommand cmd = new MySqlCommand(Query, cn);
                cmd.Parameters.AddWithValue("@strArchivo", archivo);
                cmd.Parameters.AddWithValue("@strUsuario", Usuario);
                cmd.ExecuteNonQuery();
                cn.Close();
                borradoTbla($"{archivo}_{Usuario}");
            }
            catch { }
        }

        static public void borradoTbla(string archivo)
        {
            try
            {
                MySqlConnection cn = new MySqlConnection(conexion);
                cn.Open();
                string Query = $"DROP TABLE `datacloud`.`{archivo}`;";
                MySqlCommand cmd = new MySqlCommand(Query, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch { }
        }

        static public int validarArchivo(string nombre, string usuario)
        {
            int Result = 0;
            try
            {
                MySqlConnection cn = new MySqlConnection(conexion);
                cn.Open();
                string query = "SELECT COUNT(*) FROM tblArchivo WHERE strNombreArch = @strNombreArch AND strUsuario = @strUsuario";
                MySqlCommand cmd = new MySqlCommand(query, cn);
                cmd.Parameters.AddWithValue("@strNombreArch", nombre);
                cmd.Parameters.AddWithValue("@strUsuario", usuario);
                Result = Convert.ToInt32(cmd.ExecuteScalar());
                cn.Close();
            }
            catch (Exception) { }
            return Result;
        }

        static public void exArchivoCsv(string Usuario, string archivo, int columnas, string[] fila)
        {
            if (validarArchivo(archivo, Usuario) == 0)
            {
                try
                {
                    MySqlConnection cn = new MySqlConnection(conexion);
                    cn.Open();
                    string query = $"CREATE TABLE {archivo}_{Usuario} ({fila[0]}  VARCHAR(50));";
                    MySqlCommand cmd = new MySqlCommand(query, cn);
                    cmd.ExecuteNonQuery();
                    cn.Close();
                    for (int i = 1; i < columnas; i++)
                    {
                        MySqlConnection cn2 = new MySqlConnection(conexion);
                        cn2.Open();
                        string query2 = $"ALTER TABLE {archivo}_{Usuario} ADD {fila[i]} VARCHAR (50);";
                        MySqlCommand cmd2 = new MySqlCommand(query2, cn2);
                        cmd2.ExecuteNonQuery();
                        cn2.Close();
                    }
                    llenarTabla(archivo, Usuario);
                    creado = 1;
                }
                catch { }
            }
            else
            {
                try
                {
                    if (creado == 0)
                    {
                        borradoArch(archivo, Usuario);
                        exArchivoCsv(Usuario, archivo, columnas, fila);
                    }
                    else
                    {
                        string constQuery = $"INSERT INTO {archivo}_{Usuario} VALUES(";
                        for (int i = 0; i < columnas; i++)
                        {
                            if (i == columnas - 1) { constQuery += $"'{fila[i]}');"; }
                            else { constQuery += $"'{fila[i]}',"; }
                        }
                        MySqlConnection cn = new MySqlConnection(conexion);
                        cn.Open();
                        MySqlCommand cmd = new MySqlCommand(constQuery, cn);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                }
                catch { }
            }

        }
    }
}