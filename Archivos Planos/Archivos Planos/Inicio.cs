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
        bool leer = false;
        string direccion;
        int opcion;
        string folderPath = @Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Archivos Planos";
        public Inicio()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (leer == true)
            {
                txtInfo.ReadOnly = false;
                cmdGuardar.Visible = true;
            }
            else
            {
                MessageBox.Show("Primero debe abrir o crear un archivo.");
            }
            cmdOpcion.Visible = false;
            lblNombre.Visible = false;
            txtNombre.Visible = false;
        }

        private void cmdCrear_Click(object sender, EventArgs e)
        {
            txtInfo.Clear();
            cmdOpcion.Visible = true;
            lblNombre.Visible = true;
            txtNombre.Visible = true;
            cmdGuardar.Visible = false;
            cmdOpcion.Text = "Generar";
            opcion = 0;
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            txtInfo.Clear();
            cmdOpcion.Visible = true;
            lblNombre.Visible = true;
            txtNombre.Visible = true;
            cmdGuardar.Visible = false;
            cmdOpcion.Text = "Borrar";
            opcion = 1;
        }

        private void cmdLeer_Click(object sender, EventArgs e)
        {
            txtInfo.ReadOnly = true;
            cmdGuardar.Visible = false;
            cmdOpcion.Visible = false;
            lblNombre.Visible = false;
            txtNombre.Visible = false;
            txtInfo.Clear();
            try
            {
                openFile.Title = "";
                openFile.ShowDialog();
                direccion = openFile.FileName;
                using (StreamReader reader = new StreamReader(direccion))
                {
                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        txtInfo.Text += line + "\r\n";
                    }
                }
                leer = true;
            }
            catch (Exception exp)
            {
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(direccion))
                {
                    foreach (string linea in txtInfo.Lines)
                    {
                        if (linea == null)
                        {
                            writer.WriteLine("\n");
                        }
                        else
                        {
                            writer.WriteLine(linea);
                        }
                    }
                }
                MessageBox.Show("Archivo guardado correctamente.");
            }
            catch (Exception exp)
            {
                Console.Write(exp.Message);
            }
        }

        private void cmdOpcion_Click(object sender, EventArgs e)
        {
            txtInfo.ReadOnly = true;
            leer = true;
            if (opcion == 0)
            {
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Ingrese un nombre.");
                }
                else if(!File.Exists(folderPath + $"\\{txtNombre.Text}.txt"))
                {
                    try
                    {
                        using (StreamWriter sw = File.CreateText(folderPath + $"\\{txtNombre.Text}.txt")) 
                        {
                            MessageBox.Show("Archivo generado correctamente.");
                        }
                    }
                    catch (Exception exp)
                    {
                        Console.Write(exp.Message);
                    }

                    try
                    {
                        direccion = folderPath + $"\\{txtNombre.Text}.txt";
                        using (StreamReader reader = new StreamReader(direccion))
                        {
                            string line;
                            while ((line = reader.ReadLine()) != null)
                            {
                                txtInfo.Text += line + "\r\n";
                            }
                        }
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe un archivo con ese nombre.");
                }
            }
            else if(opcion == 1)
            {
                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Ingrese un nombre.");
                }else if (!File.Exists(folderPath + $"\\{txtNombre.Text}.txt"))
                {
                    MessageBox.Show("El archivo no existe.");
                }
                else
                {
                    File.Delete(folderPath + $"\\{txtNombre.Text}.txt");
                    MessageBox.Show("Archivo borrado correctamente.");
                    txtInfo.Clear();
                }
            }
            txtNombre.Clear();
        }
    }
}