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
    public partial class T_ESAY : Form
    {
        int aux = 1;
        string userL = "";
        string[] userR = new string[5];
        string[] passwordR = new string[5];
        int num,count, score;
        int[] vec = new int[8];
        static bool Repe(int num, int[] vect)
        {
            for (int i = 0; i < 8; i++)
            {
                if (num == vect[i])
                {
                    return true;
                }              
            }
            return false;
        }
        public void ramdom()
        {
            Random Random = new Random();
            for (int i = 0; i <= 9; i++)
            {
                if (i < 8)
                {
                    while (Repe(num, vec) == true)
                    {
                        num = Random.Next(1,9);
                    }
                    vec[i] = num;
                }
            }
        }

        public void llenar()
        {
            ramdom();
            btn1.Text = Convert.ToString(vec[0]);
            btn2.Text = Convert.ToString(vec[1]);
            btn3.Text = Convert.ToString(vec[2]);
            btn4.Text = Convert.ToString(vec[3]);
            btn5.Text = Convert.ToString(vec[4]);
            btn6.Text = Convert.ToString(vec[5]);
            btn7.Text = Convert.ToString(vec[6]);
            btn8.Text = Convert.ToString(vec[7]);
            btn9.Text = "";
        }

        public T_ESAY(string[] user, string[] password,string _userL, int aux2,int _score, int bandera = 0)
        {
            if (bandera == 1)
            {
                this.userR = user;
                this.passwordR = password;
                this.aux = aux2;
                this.userL = _userL;
                this.score = _score;
            }

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btn2.Text == "")
            {
                btn2.Text = btn1.Text;
                btn1.Text = "";
                count += 1;
            }
            if (btn4.Text == "")
            {
                btn4.Text = btn1.Text;
                btn1.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn9.Text == "")
            {
                btn9.Text = btn8.Text;
                btn8.Text = "";
                count += 1;
            }
            if (btn7.Text == "")
            {
                btn7.Text = btn8.Text;
                btn8.Text = "";
                count += 1;
            }
            if (btn5.Text == "")
            {
                btn5.Text = btn8.Text;
                btn8.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn9.Text == "")
            {
                btn9.Text = btn6.Text;
                btn6.Text = "";
                count += 1;
            }
            if (btn3.Text == "")
            {
                btn3.Text = btn6.Text;
                btn6.Text = "";
                count += 1;
            }
            if (btn5.Text == "")
            {
                btn5.Text = btn6.Text;
                btn6.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "")
            {
                btn1.Text = btn2.Text;
                btn2.Text = "";
                count += 1;
            }
            if (btn3.Text == "")
            {
                btn3.Text = btn2.Text;
                btn2.Text = "";
                count += 1;
            }
            if (btn5.Text == "")
            {
                btn5.Text = btn2.Text;
                btn2.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn2.Text == "")
            {
                btn2.Text = btn3.Text;
                btn3.Text = "";
                count += 1;
            }
            if (btn6.Text == "")
            {
                btn6.Text = btn3.Text;
                btn3.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "")
            {
                btn1.Text = btn4.Text;
                btn4.Text = "";
                count += 1;
            }
            if (btn7.Text == "")
            {
                btn7.Text = btn4.Text;
                btn4.Text = "";
                count += 1;
            }
            if (btn5.Text == "")
            {
                btn5.Text = btn4.Text;
                btn4.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn2.Text == "")
            {
                btn2.Text = btn5.Text;
                btn5.Text = "";
                count += 1;
            }
            if (btn4.Text == "")
            {
                btn4.Text = btn5.Text;
                btn5.Text = "";
                count += 1;
            }
            if (btn6.Text == "")
            {
                btn6.Text = btn5.Text;
                btn5.Text = "";
                count += 1;
            }
            if (btn8.Text == "")
            {
                btn8.Text = btn5.Text;
                btn5.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn4.Text == "")
            {
                btn4.Text = btn7.Text;
                btn7.Text = "";
                count += 1;
            }
            if (btn8.Text == "")
            {
                btn8.Text = btn7.Text;
                btn7.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            btn1.Text = Convert.ToString(vec[0]);
            btn2.Text = Convert.ToString(vec[1]);
            btn3.Text = Convert.ToString(vec[2]);
            btn4.Text = Convert.ToString(vec[3]);
            btn5.Text = Convert.ToString(vec[4]);
            btn6.Text = Convert.ToString(vec[5]);
            btn7.Text = Convert.ToString(vec[6]);
            btn8.Text = Convert.ToString(vec[7]);
            btn9.Text = "";
            count = 0;
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            this.Close();
            Difficulty difficulty = new Difficulty(userR, passwordR, userL, aux, score, 1);
            difficulty.Show();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn6.Text == "")
            {
                btn6.Text = btn9.Text; 
                btn9.Text = "";
                count += 1;
            }
            if (btn8.Text == "")
            {
                btn8.Text = btn9.Text;
                btn9.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void labelWin_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn1back_Click(object sender, EventArgs e)
        {
            this.Close();
            Difficulty difficulty = new Difficulty(userR, passwordR, userL, aux, score, 1);
            difficulty.Show();
        }

        private void labelWin_Click_1(object sender, EventArgs e)
        {

        }

        public void MouseMoveWin(object sender, MouseEventArgs e)
        {
            if (btn1.Text == "1" && btn2.Text == "2" && btn3.Text == "3" && btn4.Text == "4" && btn5.Text == "5" && btn6.Text == "6" && btn7.Text == "7" && btn8.Text == "8" && btn9.Text == "")
            {
                score += 150;
                labelWin.Visible = true;
                labelCountF.Visible = true;
                labelScore.Visible = true;
                btn1back.Visible = true;
                pictureBox2.Visible = true;
                labelCountF.Text = $"NUMERO DE CLICKS: {count}";
                labelScore.Text = $"SCORE: {score}";
            }
        }
    }
}
