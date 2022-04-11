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
    public partial class T_HARD : Form
    {
        int num, count;
        int[] vec = new int[24];
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
        public T_HARD()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Difficulty difficulty = new Difficulty();
            difficulty.Show();
        }
    }
}
