using Conexion;
using Login_Bases_de_datos;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cloud_Data
{
    public partial class frmDatos : Form
    {
        /*------------------------------------------VARIABLES-------------------------------------------------------------*/
        int valor = 0;
        string Nombre, Contraseña, direccion = "", tipo,archivoNombre, Seleccion;
        /*----------------------------------------------------------------------------------------------------------------*/

        /*------------------------------------------Funciones-------------------------------------------------------------*/
        private void CargarDatosCSV(string ficheroCSV, char separador, string separadorCampos, bool primeraLineaTitulo = false)
        {
            dtgInfo.DataSource = null;
            dtgInfo.Rows.Clear();
            DataTable tablaDatos = new DataTable();
            string[] lineas = File.ReadAllLines(ficheroCSV, Encoding.Default);
            if (lineas.Length > 0)
            {
                string[] etiquetaTitulosFinal;
                if (primeraLineaTitulo)
                {
                    string primelaLinea = lineas[0];
                    string[] etiquetaTitulos = primelaLinea.Split(separador);
                    List<string> lista = new List<string>();
                    foreach (string campoActual in etiquetaTitulos)
                    {
                        string valor = campoActual;
                        if (separadorCampos != "")
                        {
                            valor = valor.TrimEnd(Convert.ToChar(separadorCampos));
                            valor = valor.TrimStart(Convert.ToChar(separadorCampos));
                        }
                        tablaDatos.Columns.Add(new DataColumn(valor));
                        lista.Add(valor);
                    }
                    etiquetaTitulosFinal = lista.ToArray();
                }
                else
                {
                    string primelaLinea = lineas[0];
                    string[] etiquetaTitulos = primelaLinea.Split(separador);
                    int numero = 0;
                    List<string> lista = new List<string>();
                    foreach (string campoActual in etiquetaTitulos)
                    {
                        string valor = "C" + Convert.ToString(numero);
                        if (separadorCampos != "")
                        {
                            valor = valor.TrimEnd(Convert.ToChar(separadorCampos));
                            valor = valor.TrimStart(Convert.ToChar(separadorCampos));
                        }

                        tablaDatos.Columns.Add(new DataColumn(valor));
                        lista.Add(valor);
                        numero++;
                    }
                    etiquetaTitulosFinal = lista.ToArray();
                }

                int inicioFila = 0;
                if (primeraLineaTitulo)
                    inicioFila = 1;

                for (int i = inicioFila; i < lineas.Length; i++)
                {
                    string[] filasDatos = lineas[i].Split(separador);
                    DataRow dataGridS = tablaDatos.NewRow();
                    int columnIndex = 0;
                    foreach (string campoActual in etiquetaTitulosFinal)
                    {
                        string valor = filasDatos[columnIndex++];
                        if (separadorCampos != "")
                        {
                            valor = valor.TrimEnd(Convert.ToChar(separadorCampos));
                            valor = valor.TrimStart(Convert.ToChar(separadorCampos));
                        }
                        dataGridS[campoActual] = valor;
                    }
                    tablaDatos.Rows.Add(dataGridS);
                }
            }
            if (tablaDatos.Rows.Count > 0)
            {
                dtgInfo.DataSource = tablaDatos;
            }
        }
        /*----------------------------------------------------------------------------------------------------------------*/
        public frmDatos(string Nombre_, string Contraseña_)
        {
            this.Nombre = Nombre_;
            this.Contraseña = Contraseña_;
            InitializeComponent();
        }

        /*----------------------------------------------------botones------------------------------------------------------*/
        private void frmDatos_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(valor == 0)
            {
                Application.Exit();
            }
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            dtgInfo.ReadOnly = false;
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            string dato = Seleccion + "_" + Nombre;
            Conexion.Tipos.borradoArch(Seleccion, Nombre);
            dtgArchivos.DataSource = Conexion.Tipos.Archivos(Nombre);
            MessageBox.Show(dato);
        }

        private void dtgArchivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            dtgInfo.DataSource = dt;
            Seleccion = dtgArchivos.CurrentRow.Cells[0].Value.ToString();
            archivoNombre = dtgArchivos.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show(Seleccion);
            dtgInfo.DataSource = Conexion.Tipos.Importar(Seleccion,Nombre);
            tipo = "csv";
        }

        private void cmdExportar_Click(object sender, EventArgs e)
        {
            switch (tipo)
            {
                case "csv":
                    string[] fila = new string[dtgInfo.Columns.Count];
                    for (int i = 0; i < dtgInfo.Rows.Count; i++)
                    {
                        for (int n = 0; n < dtgInfo.Columns.Count; n++)
                        {
                            fila[n] = Convert.ToString(dtgInfo.Rows[i].Cells[n].Value);
                        }
                        Conexion.Tipos.exArchivoCsv(Nombre, archivoNombre, dtgInfo.Columns.Count, fila);
                    }
                    dtgArchivos.DataSource = Conexion.Tipos.Archivos(Nombre);
                    Conexion.Tipos.creado = 0;
                    break;
            }
        }

        private void frmDatos_Load(object sender, EventArgs e)
        {
            lblBienvenida.Text += $" {Nombre}";
            dtgArchivos.DataSource = Conexion.Tipos.Archivos(Nombre);
            dtgArchivos.Columns[0].HeaderText = "Archivos en la nube";
        }

        private void cmdAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                openFile.Title = "Abrir";
                openFile.Filter = "Archivos csv (*.csv*)|*.csv*";
                openFile.ShowDialog();
                direccion = openFile.FileName;
                archivoNombre = openFile.SafeFileName.Substring(0, openFile.SafeFileName.Length - 4);
                Seleccion = archivoNombre.Substring(0, archivoNombre.Length - 4);
                tipo = String.Empty;
                switch (direccion)
                {
                    case string info when direccion.ToLower().Contains("csv"): tipo = "csv"; break;
                    default: break;
                }
                switch (tipo)
                {
                    case "csv":
                        try
                        {
                            CargarDatosCSV(direccion, Convert.ToChar(';'), "");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), "Error al leer CSV.");
                        }
                        break;
                }
            }
            catch (Exception) { }
        }

        private void cmdCerrar_sesion_Click(object sender, EventArgs e)
        {
            valor = 1;
            this.Close();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            valor = 0;
        }
        /*----------------------------------------------------------------------------------------------------------------*/
    }
}
