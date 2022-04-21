﻿using System;
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
    public partial class T_HARD : Form
    {
        int aux = 1;
        string userL = "";
        string[] userR = new string[6];
        string[] passwordR = new string[6];
        int num, count, score;
        int[] vec = new int[24];
        bool visible = false;
        static bool Repe(int num, int[] vect)
        {
            for (int i = 0; i < 24; i++)
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
            for (int i = 0; i <= 25; i++)
            {
                if (i < 24)
                {
                    while (Repe(num, vec) == true)
                    {
                        num = Random.Next(1, 25);
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
            btn9.Text = Convert.ToString(vec[8]);
            btn10.Text = Convert.ToString(vec[9]);
            btn11.Text = Convert.ToString(vec[10]);
            btn12.Text = Convert.ToString(vec[11]);
            btn13.Text = Convert.ToString(vec[12]);
            btn14.Text = Convert.ToString(vec[13]);
            btn15.Text = Convert.ToString(vec[14]);
            btn16.Text = Convert.ToString(vec[15]);
            btn17.Text = Convert.ToString(vec[16]);
            btn18.Text = Convert.ToString(vec[17]);
            btn19.Text = Convert.ToString(vec[18]);
            btn20.Text = Convert.ToString(vec[19]);
            btn21.Text = Convert.ToString(vec[20]);
            btn22.Text = Convert.ToString(vec[21]);
            btn23.Text = Convert.ToString(vec[22]);
            btn24.Text = Convert.ToString(vec[23]);
            btn25.Text = "";
        }
        public T_HARD(string[] user, string[] password, string _userL, int aux2, int _score, int bandera = 0, bool _visible = false)
        {
            if (bandera == 1)
            {
                this.userR = user;
                this.passwordR = password;
                this.aux = aux2;
                this.userL = _userL;
                this.score = _score;
                this.visible = _visible;
            }

            InitializeComponent();
        }

        private void btnRei_Click(object sender, EventArgs e)
        {
            btn1.Text = Convert.ToString(vec[0]);
            btn2.Text = Convert.ToString(vec[1]);
            btn3.Text = Convert.ToString(vec[2]);
            btn4.Text = Convert.ToString(vec[3]);
            btn5.Text = Convert.ToString(vec[4]);
            btn6.Text = Convert.ToString(vec[5]);
            btn7.Text = Convert.ToString(vec[6]);
            btn8.Text = Convert.ToString(vec[7]);
            btn9.Text = Convert.ToString(vec[8]);
            btn10.Text = Convert.ToString(vec[9]);
            btn11.Text = Convert.ToString(vec[10]);
            btn12.Text = Convert.ToString(vec[11]);
            btn13.Text = Convert.ToString(vec[12]);
            btn14.Text = Convert.ToString(vec[13]);
            btn15.Text = Convert.ToString(vec[14]);
            btn16.Text = Convert.ToString(vec[15]);
            btn17.Text = Convert.ToString(vec[16]);
            btn18.Text = Convert.ToString(vec[17]);
            btn19.Text = Convert.ToString(vec[18]);
            btn20.Text = Convert.ToString(vec[19]);
            btn21.Text = Convert.ToString(vec[20]);
            btn22.Text = Convert.ToString(vec[21]);
            btn23.Text = Convert.ToString(vec[22]);
            btn24.Text = Convert.ToString(vec[23]);
            btn25.Text = "";
            count = 0;
            labelCount.Text = $"Numero de clicks: {count}";
        }
        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
            Difficulty difficulty = new Difficulty(userR, passwordR, userL, aux, score, 1,visible);
            difficulty.Show();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn2.Text == "")
            {
                btn2.Text = btn1.Text;
                btn1.Text = "";
                count += 1;
            }
            if (btn5.Text == "")
            {
                btn5.Text = btn1.Text;
                btn1.Text = "";
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
            if (btn7.Text == "")
            {
                btn7.Text = btn2.Text;
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
            if (btn4.Text == "")
            {
                btn4.Text = btn3.Text;
                btn3.Text = "";
                count += 1;
            }
            if (btn8.Text == "")
            {
                btn8.Text = btn3.Text;
                btn3.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn3.Text == "")
            {
                btn3.Text = btn4.Text;
                btn4.Text = "";
                count += 1;
            }
            if (btn5.Text == "")
            {
                btn5.Text = btn4.Text;
                btn4.Text = "";
                count += 1;
            }
            if (btn9.Text == "")
            {
                btn9.Text = btn4.Text;
                btn4.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn4.Text == "")
            {
                btn4.Text = btn5.Text;
                btn5.Text = "";
                count += 1;
            }
            if (btn10.Text == "")
            {
                btn10.Text = btn5.Text;
                btn5.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "")
            {
                btn1.Text = btn6.Text;
                btn6.Text = "";
                count += 1;
            }
            if (btn7.Text == "")
            {
                btn7.Text = btn6.Text;
                btn6.Text = "";
                count += 1;
            }
            if (btn11.Text == "")
            {
                btn11.Text = btn6.Text;
                btn6.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (btn6.Text == "")
            {
                btn6.Text = btn7.Text;
                btn7.Text = "";
                count += 1;
            }
            if (btn8.Text == "")
            {
                btn8.Text = btn7.Text;
                btn7.Text = "";
                count += 1;
            }
            if (btn2.Text == "")
            {
                btn2.Text = btn7.Text;
                btn7.Text = "";
                count += 1;
            }
            if (btn12.Text == "")
            {
                btn12.Text = btn7.Text;
                btn7.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn7.Text == "")
            {
                btn7.Text = btn8.Text;
                btn8.Text = "";
                count += 1;
            }
            if (btn9.Text == "")
            {
                btn9.Text = btn8.Text;
                btn8.Text = "";
                count += 1;
            }
            if (btn3.Text == "")
            {
                btn3.Text = btn8.Text;
                btn8.Text = "";
                count += 1;
            }
            if (btn13.Text == "")
            {
                btn13.Text = btn8.Text;
                btn8.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (btn8.Text == "")
            {
                btn8.Text = btn9.Text;
                btn9.Text = "";
                count += 1;
            }
            if (btn10.Text == "")
            {
                btn10.Text = btn9.Text;
                btn9.Text = "";
                count += 1;
            }
            if (btn4.Text == "")
            {
                btn4.Text = btn9.Text;
                btn9.Text = "";
                count += 1;
            }
            if (btn14.Text == "")
            {
                btn14.Text = btn9.Text;
                btn9.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (btn5.Text == "")
            {
                btn5.Text = btn10.Text;
                btn10.Text = "";
                count += 1;
            }
            if (btn9.Text == "")
            {
                btn9.Text = btn10.Text;
                btn10.Text = "";
                count += 1;
            }
            if (btn15.Text == "")
            {
                btn15.Text = btn10.Text;
                btn10.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn11_Click(object sender, EventArgs e)
        {
            if (btn6.Text == "")
            {
                btn6.Text = btn11.Text;
                btn11.Text = "";
                count += 1;
            }
            if (btn12.Text == "")
            {
                btn12.Text = btn11.Text;
                btn11.Text = "";
                count += 1;
            }
            if (btn16.Text == "")
            {
                btn16.Text = btn11.Text;
                btn11.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn12_Click(object sender, EventArgs e)
        {
            if (btn11.Text == "")
            {
                btn11.Text = btn12.Text;
                btn12.Text = "";
                count += 1;
            }
            if (btn13.Text == "")
            {
                btn13.Text = btn12.Text;
                btn12.Text = "";
                count += 1;
            }
            if (btn7.Text == "")
            {
                btn7.Text = btn12.Text;
                btn12.Text = "";
                count += 1;
            }
            if (btn17.Text == "")
            {
                btn17.Text = btn12.Text;
                btn12.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            if (btn12.Text == "")
            {
                btn12.Text = btn13.Text;
                btn13.Text = "";
                count += 1;
            }
            if (btn14.Text == "")
            {
                btn14.Text = btn13.Text;
                btn13.Text = "";
                count += 1;
            }
            if (btn8.Text == "")
            {
                btn8.Text = btn13.Text;
                btn13.Text = "";
                count += 1;
            }
            if (btn18.Text == "")
            {
                btn18.Text = btn13.Text;
                btn13.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            if (btn13.Text == "")
            {
                btn13.Text = btn14.Text;
                btn14.Text = "";
                count += 1;
            }
            if (btn15.Text == "")
            {
                btn15.Text = btn14.Text;
                btn14.Text = "";
                count += 1;
            }
            if (btn9.Text == "")
            {
                btn9.Text = btn14.Text;
                btn14.Text = "";
                count += 1;
            }
            if (btn19.Text == "")
            {
                btn19.Text = btn14.Text;
                btn14.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            if (btn10.Text == "")
            {
                btn10.Text = btn15.Text;
                btn15.Text = "";
                count += 1;
            }
            if (btn20.Text == "")
            {
                btn20.Text = btn15.Text;
                btn15.Text = "";
                count += 1;
            }
            if (btn14.Text == "")
            {
                btn14.Text = btn15.Text;
                btn15.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            if (btn11.Text == "")
            {
                btn11.Text = btn16.Text;
                btn16.Text = "";
                count += 1;
            }
            if (btn21.Text == "")
            {
                btn21.Text = btn16.Text;
                btn16.Text = "";
                count += 1;
            }
            if (btn17.Text == "")
            {
                btn17.Text = btn16.Text;
                btn16.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            if (btn12.Text == "")
            {
                btn12.Text = btn17.Text;
                btn17.Text = "";
                count += 1;
            }
            if (btn22.Text == "")
            {
                btn22.Text = btn17.Text;
                btn17.Text = "";
                count += 1;
            }
            if (btn18.Text == "")
            {
                btn18.Text = btn17.Text;
                btn17.Text = "";
                count += 1;
            }
            if (btn16.Text == "")
            {
                btn16.Text = btn17.Text;
                btn17.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn18_Click(object sender, EventArgs e)
        {
            if (btn19.Text == "")
            {
                btn19.Text = btn18.Text;
                btn18.Text = "";
                count += 1;
            }
            if (btn17.Text == "")
            {
                btn17.Text = btn18.Text;
                btn18.Text = "";
                count += 1;
            }
            if (btn13.Text == "")
            {
                btn13.Text = btn18.Text;
                btn18.Text = "";
                count += 1;
            }
            if (btn23.Text == "")
            {
                btn23.Text = btn18.Text;
                btn18.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn19_Click(object sender, EventArgs e)
        {
            if (btn14.Text == "")
            {
                btn14.Text = btn19.Text;
                btn19.Text = "";
                count += 1;
            }
            if (btn24.Text == "")
            {
                btn24.Text = btn19.Text;
                btn19.Text = "";
                count += 1;
            }
            if (btn20.Text == "")
            {
                btn20.Text = btn19.Text;
                btn19.Text = "";
                count += 1;
            }
            if (btn18.Text == "")
            {
                btn18.Text = btn19.Text;
                btn19.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (btn15.Text == "")
            {
                btn15.Text = btn20.Text;
                btn20.Text = "";
                count += 1;
            }
            if (btn19.Text == "")
            {
                btn19.Text = btn20.Text;
                btn20.Text = "";
                count += 1;
            }
            if (btn25.Text == "")
            {
                btn25.Text = btn20.Text;
                btn20.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            if (btn16.Text == "")
            {
                btn16.Text = btn21.Text;
                btn21.Text = "";
                count += 1;
            }
            if (btn22.Text == "")
            {
                btn22.Text = btn21.Text;
                btn21.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn22_Click(object sender, EventArgs e)
        {
            if (btn17.Text == "")
            {
                btn17.Text = btn22.Text;
                btn22.Text = "";
                count += 1;
            }
            if (btn21.Text == "")
            {
                btn21.Text = btn22.Text;
                btn22.Text = "";
                count += 1;
            }
            if (btn23.Text == "")
            {
                btn23.Text = btn22.Text;
                btn22.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            if (btn18.Text == "")
            {
                btn18.Text = btn23.Text;
                btn23.Text = "";
                count += 1;
            }
            if (btn22.Text == "")
            {
                btn22.Text = btn23.Text;
                btn23.Text = "";
                count += 1;
            }
            if (btn24.Text == "")
            {
                btn24.Text = btn23.Text;
                btn23.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn24_Click(object sender, EventArgs e)
        {
            if (btn19.Text == "")
            {
                btn19.Text = btn24.Text;
                btn24.Text = "";
                count += 1;
            }
            if (btn23.Text == "")
            {
                btn23.Text = btn24.Text;
                btn24.Text = "";
                count += 1;
            }
            if (btn25.Text == "")
            {
                btn25.Text = btn24.Text;
                btn24.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            if (btn20.Text == "")
            {
                btn20.Text = btn25.Text;
                btn25.Text = "";
                count += 1;
            }
            if (btn24.Text == "")
            {
                btn24.Text = btn25.Text;
                btn25.Text = "";
                count += 1;
            }
            labelCount.Text = $"Numero de clicks: {count}";
        }

        private void btn25_MouseMove(object sender, MouseEventArgs e)
        {
            if (btn1.Text == "1" && btn2.Text == "2" && btn3.Text == "3" && btn4.Text == "4" && btn5.Text == "5" && btn6.Text == "6" && btn7.Text == "7" && btn8.Text == "8" && btn9.Text == "9" && btn10.Text == "10"
                    && btn11.Text == "11" && btn12.Text == "12" && btn13.Text == "13" && btn14.Text == "14" && btn15.Text == "15" && btn16.Text == "16" && btn17.Text == "17" && btn18.Text == "18" && btn19.Text == "19"
                    && btn20.Text == "20" && btn21.Text == "21" && btn22.Text == "22" && btn23.Text == "23" && btn24.Text == "24" && btn25.Text == "")
            {
                score += 500;
                labelWin.Visible = true;
                labelCountF.Visible = true;
                labelScore.Visible = true;
                btn1back.Visible = true;
                pictureBox2.Visible = true;
                labelCountF.Text = $"NUMERO DE CLICKS: {count}";
                labelScore.Text = $"SCORE: {score}";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn1back_Click(object sender, EventArgs e)
        {
            this.Close();
            Difficulty difficulty = new Difficulty(userR, passwordR, userL, aux,score, 1,visible);
            difficulty.Show();
        }
    }
}
