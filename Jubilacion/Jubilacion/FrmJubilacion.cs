using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jubilacion
{
    public partial class FrmJubilacion : Form
    {
        public FrmJubilacion()
        {
            InitializeComponent();
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                erpInfo.SetError(txtNombre, "El dato no puede ser nulo.");
                txtNombre.Focus();
                return;
            }

            if (txtEdad.Text == "")
            {
                erpInfo.SetError(txtEdad, "El dato no puede ser nulo.");
                txtEdad.Focus();
                return;
            }

            if (Convert.ToInt32(txtEdad.Text) >= 18 && chkMasculino.Checked)
            {
                lblInformacion.Text = $"Nombre: {txtNombre.Text}\nEdad: {txtEdad.Text}\n";
                lblInformacion.Text += $"\nEl señor {txtNombre.Text} es mayor de edad \ny le falta {62 - Convert.ToInt32(txtEdad.Text)} años para jubilarse";
            }

            if (Convert.ToInt32(txtEdad.Text) >= 18 && chkFemenino.Checked)
            {
                lblInformacion.Text = $"Nombre: {txtNombre.Text}\nEdad: {txtEdad.Text}\n";
                lblInformacion.Text += $"\nLa Señora {txtNombre.Text} es mayor de edad \ny le falta {57 - Convert.ToInt32(txtEdad.Text)} años para jubilarse";
            }

            if (Convert.ToInt32(txtEdad.Text) < 18 && chkMasculino.Checked)
            {
                lblInformacion.Text = $"Nombre: {txtNombre.Text}\nEdad: {txtEdad.Text}\n";
                lblInformacion.Text += $"\nEl señor {txtNombre.Text} es menor de edad \ny le falta {62 - Convert.ToInt32(txtEdad.Text)} años para jubilarse";
            }

            if (Convert.ToInt32(txtEdad.Text) < 18 && chkFemenino.Checked)
            {
                lblInformacion.Text = $"Nombre: {txtNombre.Text}\nEdad: {txtEdad.Text}\n";
                lblInformacion.Text += $"\nLa Señora {txtNombre.Text} es menor de edad \ny le falta {57 - Convert.ToInt32(txtEdad.Text)} años para jubilarse";
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se reciben numeros", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void chkFemenino_Click(object sender, EventArgs e)
        {
            chkMasculino.Checked = false;
        }

        private void chkMasculino_Click(object sender, EventArgs e)
        {
            chkFemenino.Checked = false;
        }
    }
}
