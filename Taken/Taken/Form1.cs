namespace Taken
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSing_Click(object sender, EventArgs e)
        {
            this.Hide();
            singUp singup = new singUp();
            singup.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Difficulty difficulty = new Difficulty();
            difficulty.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}