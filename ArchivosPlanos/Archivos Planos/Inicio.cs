using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Archivos_Planos
{
    public partial class Inicio : Form
    {
        /*---------------------------------------------Variables--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        bool leer = false;
        int opcion;
        string caracterSeparadorCampos = ";", caracterSeparadorValores = "", direccion, tipo, borrar, folderPath = @Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Archivos Planos";

        /*---------------------------------------------Funciones--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
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

        public void Leer(string direccion, string line = "")
        {
            switch (tipo)
            {
                case "txt":
                    try
                    {
                        using (StreamReader reader = new StreamReader(direccion))
                        {
                            while ((line = reader.ReadLine()) != null) { txtInfo.Text += line + "\r\n"; }
                        }
                        leer = true;
                        txtInfo.ReadOnly = true;
                    }
                    catch (Exception) { leer = false; }
                    break;
            }
        }

        /*---------------------------------------------Inicio--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        public Inicio()
        {
            InitializeComponent();
        }

        /*---------------------------------------------Modificar--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        private void tsmModificar_Click(object sender, EventArgs e)
        {
            if (leer == true)
            {
                switch (tipo)
                {
                    case "txt":
                        txtInfo.ReadOnly = false;
                        break;

                    case "csv":
                        dtgInfo.ReadOnly = false;
                        break;
                }
            }
            else 
            { 
                MessageBox.Show("Primero debe abrir o crear un archivo."); 
            }
        }

        /*---------------------------------------------Borrar--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        private void tsmBorrar_txt_Click(object sender, EventArgs e)
        {
            txtInfo.Clear();
            txtNombre.Clear();
            txtColumnas.Clear();
            tsmModificar.Enabled = false;
            opcion = 1;
            borrar = "txt";
            cmdCrear.Visible = true;
            cmdCrear.Text = "Borrar TXT";
            lblNombre.Visible = true;
            txtNombre.Visible = true;
            txtInfo.Visible = false;
            dtgInfo.Visible = false;
            lblLogo.Visible = false;
        }

        private void tsmBorrar_csv_Click(object sender, EventArgs e)
        {
            txtInfo.Clear();
            txtNombre.Clear();
            txtColumnas.Clear();
            tsmModificar.Enabled = false;
            opcion = 1;
            borrar = "csv";
            cmdCrear.Visible = true;
            cmdCrear.Text = "Borrar CSV";
            lblNombre.Visible = true;
            txtNombre.Visible = true;
            txtInfo.Visible = false;
            dtgInfo.Visible = false;
            lblLogo.Visible = false;
        }

        /*---------------------------------------------Nuevo--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/

        private void tsmNuevo_txt_Click(object sender, EventArgs e)
        {
            txtInfo.Clear();
            txtNombre.Clear();
            txtColumnas.Clear();
            tsmModificar.Enabled = false;
            opcion = 0;
            tipo = "txt";
            cmdCrear.Visible = true;
            cmdCrear.Text = "Crear TXT";
            lblNombre.Visible = true;
            txtNombre.Visible = true;
            txtInfo.Visible = false;
            dtgInfo.Visible = false;
            lblLogo.Visible = false;
            txtColumnas.Visible = false;
            lblColumnas.Visible = false;
            leer = true;
        }

        private void tsmNuevo_csv_Click(object sender, EventArgs e)
        {
            txtInfo.Clear();
            txtNombre.Clear();
            txtColumnas.Clear();
            tsmModificar.Enabled = false;
            opcion = 0;
            tipo = "csv";
            cmdCrear.Visible = true;
            cmdCrear.Text = "Crear CSV";
            lblNombre.Visible = true;
            txtNombre.Visible = true;
            txtInfo.Visible = false;
            dtgInfo.Visible = false;
            lblLogo.Visible = false;
            txtColumnas.Visible = true;
            lblColumnas.Visible = true;
            leer = true;
        }

        private void cmdCrear_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(folderPath)) { Directory.CreateDirectory(folderPath); }

            if (opcion == 0)
            {
                switch (tipo)
                {
                    case "txt":
                        if (txtNombre.Text == "") { MessageBox.Show("Ingrese un nombre."); }
                        else if (!File.Exists(folderPath + $"\\{txtNombre.Text}.txt"))
                        {
                            try
                            {
                                using (StreamWriter sw = File.CreateText(folderPath + $"\\{txtNombre.Text}.txt"))
                                {
                                    MessageBox.Show("Archivo generado correctamente.");
                                }
                            }
                            catch (Exception exp) { Console.Write(exp.Message); }
                            leer = true;
                            direccion = folderPath + $"\\{txtNombre.Text}.txt";
                            Leer(direccion);
                            tsmModificar.Enabled = true;
                            txtInfo.Visible = true;
                            dtgInfo.Visible = false;
                            cmdCrear.Visible = false;
                            lblNombre.Visible = false;
                            txtNombre.Visible = false;
                        }
                        else { MessageBox.Show("Ya existe un archivo con ese nombre."); }
                        break;

                    case "csv":
                        if (txtNombre.Text == "") { MessageBox.Show("Ingrese un nombre."); }
                        if (txtColumnas.Text == "") { MessageBox.Show("Ingrese el numero de columnas."); }
                        else if (!File.Exists(folderPath + $"\\{txtNombre.Text}.csv"))
                        {
                            leer = true;
                            StringBuilder csvMemoria = new StringBuilder();

                            for (int j = 0; j < 1; j++)
                            {
                                for (int k = 0; k < Convert.ToInt32(txtColumnas.Text); k++)
                                {
                                    if (k == Convert.ToInt32(txtColumnas.Text) - 1)
                                    {
                                        csvMemoria.Append(String.Format(caracterSeparadorValores + " " + caracterSeparadorValores));
                                    }
                                    else
                                    {
                                        csvMemoria.Append(String.Format(caracterSeparadorValores + " " + caracterSeparadorValores + caracterSeparadorCampos));
                                    }
                                }
                                csvMemoria.AppendLine();
                            }
                            try
                            {
                                System.IO.StreamWriter sw = new System.IO.StreamWriter((folderPath + $"\\{txtNombre.Text}.csv"), false, System.Text.Encoding.Default);
                                sw.Write(csvMemoria.ToString(), Encoding.Default);
                                sw.Close();
                            }
                            catch (Exception) { }
                            direccion = (folderPath + $"\\{txtNombre.Text}.csv");
                            
                            try
                            {
                                CargarDatosCSV(direccion, Convert.ToChar(caracterSeparadorCampos), caracterSeparadorValores);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message.ToString(), "Error al leer CSV");
                            }
                            tsmModificar.Enabled = true;
                            txtInfo.Visible = false;
                            dtgInfo.Visible = true;
                        }
                        else { MessageBox.Show("Ya existe un archivo con ese nombre."); }

                        txtInfo.Visible = false;
                        dtgInfo.Visible = true;
                        cmdCrear.Visible = false;
                        lblNombre.Visible = false;
                        txtNombre.Visible = false;
                        txtColumnas.Visible = false;
                        lblColumnas.Visible = false;
                        break;
                }
            }
            else if (opcion == 1)
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Ingrese un nombre.");
                }
                else if (!File.Exists(folderPath + $"\\{txtNombre.Text}.{borrar}")) { MessageBox.Show("El archivo no existe."); }
                else
                {
                    File.Delete(folderPath + $"\\{txtNombre.Text}.{borrar}");
                    MessageBox.Show("Archivo borrado correctamente.");
                    txtInfo.Clear();
                }
                txtNombre.Clear();
            }
        }

        /*---------------------------------------------Salir--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        private void tsmSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /*---------------------------------------------Guardar--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        private void tsmGuardar_Click(object sender, EventArgs e)
        {
            switch (tipo)
            {
                case "txt":
                    try
                    {
                        using (StreamWriter writer = new StreamWriter(direccion))
                        {
                            foreach (string linea in txtInfo.Lines)
                            {
                                if (linea == null) { writer.WriteLine("\n"); }
                                else { writer.WriteLine(linea); }
                            }
                        }
                        MessageBox.Show("Archivo guardado correctamente.");
                    }
                    catch (Exception exp) { Console.Write(exp.Message); }
                    break;

                case "csv":

                    if (direccion == "")
                    {
                        MessageBox.Show("Primero debe abrir o crear un archivo.");
                    }
                    else
                    {
                        if (Directory.Exists(Path.GetDirectoryName(direccion)))
                        {
                            StringBuilder csvMemoria = new StringBuilder();
                            for (int m = 0; m < dtgInfo.Rows.Count - 1; m++)
                            {
                                for (int n = 0; n < dtgInfo.Columns.Count; n++)
                                {
                                    if (n == dtgInfo.Columns.Count - 1)
                                    {
                                        csvMemoria.Append(String.Format(caracterSeparadorValores + "{0}" + caracterSeparadorValores, dtgInfo.Rows[m].Cells[n].Value));
                                    }
                                    else
                                    {
                                        csvMemoria.Append(String.Format(caracterSeparadorValores + "{0}" + caracterSeparadorValores + caracterSeparadorCampos, dtgInfo.Rows[m].Cells[n].Value));
                                    }
                                }
                                csvMemoria.AppendLine();
                            }
                            try
                            {
                                System.IO.StreamWriter sw = new System.IO.StreamWriter(direccion, false, System.Text.Encoding.Default);
                                sw.Write(csvMemoria.ToString(), Encoding.Default);
                                sw.Close();
                                MessageBox.Show("Se ha exportado el contenido del grid al fichero CSV correctamente.", "Exportado a fichero CSV...");
                            }
                            catch (Exception) { }
                        }
                        else
                        {
                            MessageBox.Show("La carpeta indicada para el fichero de exportación CSV no existe.");
                        }
                    }
                    break;
            }
        }

        /*---------------------------------------------Abrir--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------*/
        private void tsmAbrir_Click(object sender, EventArgs e)
        {
            tsmModificar.Enabled = false;
            try
            {
                txtInfo.ReadOnly = true;
                txtInfo.Clear();
                openFile.Title = "";
                openFile.Filter = "Todos los archivos (*.*)|*.*|Archivos txt (*.txt)|*.txt|Archivos csv (*.csv*)|*.csv*";
                openFile.ShowDialog();
                direccion = openFile.FileName;
                tipo = String.Empty;
                switch (direccion)
                {
                    case string info when direccion.ToLower().Contains("txt"): tipo = "txt"; break;
                    case string info when direccion.ToLower().Contains("csv"): tipo = "csv"; break;
                    default: break;
                }
                switch (tipo)
                {
                    case "txt":
                        Leer(direccion);
                        txtInfo.Visible = true;
                        dtgInfo.Visible = false;
                        tsmModificar.Enabled = true;
                        leer = true;
                        break;

                    case "csv":
                        try
                        {
                            CargarDatosCSV(direccion, Convert.ToChar(caracterSeparadorCampos), caracterSeparadorValores);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), "Error al leer CSV...");
                        }
                        txtInfo.Visible = false;
                        dtgInfo.Visible = true;
                        tsmModificar.Enabled = true;
                        leer = true;
                        break;
                }
            }
            catch (Exception) { }
        }
    }
}