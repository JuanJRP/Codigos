using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taken
{
    public partial class Difficulty : Form
    {
        public Difficulty()
        {
            InitializeComponent();
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            this.Hide();
            T_HARD t_HARD = new T_HARD();
            t_HARD.llenar();
            t_HARD.Show();
        }
        private void btnHard_MouseMove(object sender, MouseEventArgs e)
        {
            textInfo.Text = "THIS DIFFICULTY CONTAINS A 5X5 PUZZLE, IT IS FOCUSED ON PLAYERS WITH PREVIOUS EXPERIENCE AND TIME.";
        }
        
        private void btnModerate_Click(object sender, EventArgs e)
        {
            this.Hide();
            T_MODERATE t_MODERATE = new T_MODERATE();
            t_MODERATE.llenar();
            t_MODERATE.Show();
        }
        private void btnModerate_MouseMove(object sender, MouseEventArgs e)
        {
            textInfo.Text = "THIS DIFFICULTY CONTAINS A 4X4 PUZZLE, PERFECT FOR A FULL GAME AND EXPERIENCED PLAYERS. ";
        }

        private void btnEASY_Click(object sender, EventArgs e)
        {
            this.Hide();
            T_ESAY t_ESAY = new T_ESAY();
            t_ESAY.llenar();
            t_ESAY.Show();
        }
        private void btnEASY_MouseMove(object sender, MouseEventArgs e)
        {
            textInfo.Text = "THIS DIFFICULTY CONTAINS A 3X3 PUZZLE, PERFECT FOR FAST GAMES AND BEGINNERS. ";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicio inicio = new Inicio();
            inicio.Show();
        }

        private void textInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelName_Click(object sender, EventArgs e)
        {
            
        }

        private void Difficulty_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (User.R == true)
            {
                User.score = 0;
                labelName.Visible = true;
                labelName.Text = "User: " + User.userR;
                labelScore.Visible = true;
                labelScore.Text = "Score: " + User.score;
            }
        }

        private void labelScore_Click(object sender, EventArgs e)
        {

        }
    }
}
