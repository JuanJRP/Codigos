namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Empleado empleado = new Empleado();
        Nomina nomina = new Nomina();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("hola");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textTotalDeven.Text = nomina.CalcularNomina(Convert.ToInt32(nomina.DiasLaborados), Convert.ToDecimal(empleado.AsignacionDia)).ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();        
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            //Validar Texto

            if (textNomb.Text == "")
            {
                error1.SetError(textNomb, "Debe ingresar un nombre");
                textNomb.Focus();
                return ;
            }
            error1.SetError(textNomb, "");


            //Validar Numeros

            Decimal AsignacionDia;
            if (!Decimal.TryParse(textSal.Text, out AsignacionDia))
            {
                error1.SetError(textSal, "Debe ingresar un numero");
                textNomb.Focus();
                return;
            }
            error1.SetError(textSal, "");

            int Identificacion;
            if (!int.TryParse(textIdent.Text, out Identificacion))
            {
                error1.SetError(textIdent, "Debe ingresar un numero");
                textIdent.Focus();
                return;
            }
            error1.SetError(textIdent, "");

            int DiasLobrados;
            if (!int.TryParse(textDia.Text, out DiasLobrados))
            {
                error1.SetError(textDia, "Debe ingresar un numero");
                textDia.Focus();
                return;
            }
            error1.SetError(textDia, "");

            empleado.Nombre = textNomb.Text;
            empleado.Identificacion = int.Parse(textIdent.Text);
            empleado.AsignacionDia = decimal.Parse(textSal.Text);
            nomina.DiasLaborados = int.Parse(textDia.Text);
            MessageBox.Show("El Registro Se Guardo Correctamente.");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            textNomb.Clear();
            textIdent.Clear();
            textSal.Clear();
            textDia.Clear();
            textTotalDeven.Clear();

        }
    }
}