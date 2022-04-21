namespace Taken
{
    public partial class Inicio : Form
    {
        int aux = 1;
        int score;
        string userL= "";
        string[] userR = new string[5];
        string[] passwordR = new string[5];
        public Inicio(string[] user, string[] password, int aux2,int _score = 0, int bandera = 0)
        {
            if (bandera == 1)
            {
                this.userR = user;
                this.passwordR = password;
                this.aux = aux2;
                this.score = _score;
            }

            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSing_Click(object sender, EventArgs e)
        {
            this.Hide();
            singUp singup = new singUp(userR, passwordR, aux,score, 1);
            singup.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            singUp singup = new singUp(userR, passwordR, aux, score,1);
            singup.btnplay_Click(sender, e);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            Difficulty difficulty = new Difficulty(userR,passwordR,userL,aux,score,1);
            difficulty.Show();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}