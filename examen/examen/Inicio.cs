namespace examen
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Preguntas preguntas = new Preguntas();
            preguntas.Show();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}