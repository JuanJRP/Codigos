using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Timer : Form
    {
        int contador1 = 0, contador2 = 0, contador3 = 0;
        int bandera1 = 0, bandera2 = 0, bandera3 = 0;
        public Timer()
        {
            InitializeComponent();
        }

        private void Timer_Load(object sender, EventArgs e)
        {

        }

        private void cmdiniciar_Click(object sender, EventArgs e)
        {
            tmr1.Enabled = true;
            tmr2.Enabled = true;
            tmr3.Enabled = true;
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            if(bandera1 == 0 && contador1 < 100)
            {
                contador1++;
                lbl1.Text = contador1.ToString();
                if(contador1 == 100)
                {
                    bandera1 = 1;
                }
            }
            else if (bandera1 == 1)
            {
                contador1--;
                lbl1.Text = contador1.ToString();
                if(contador1 == 0)
                {
                    bandera1 = 0;
                }
            }
        }

        private void tmr2_Tick(object sender, EventArgs e)
        {
            if (bandera2 == 0 && contador2 < 20)
            {
                contador2++;
                lbl2.Text = contador2.ToString();
                if (contador2 == 20)
                {
                    bandera2 = 1;
                }
            }
            else if (bandera2 == 1)
            {
                contador2--;
                lbl2.Text = contador2.ToString();
                if (contador2 == 0)
                {
                    bandera2 = 0;
                }
            }
        }

        private void tmr3_Tick(object sender, EventArgs e)
        {
            if (bandera3 == 0 && contador3 < 50)
            {
                contador3++;
                lbl3.Text = contador3.ToString();
                if (contador3 == 50)
                {
                    bandera3 = 1;
                }
            }
            else if (bandera3 == 1)
            {
                contador3--;
                lbl3.Text = contador3.ToString();
                if (contador3 == 0)
                {
                    bandera3 = 0;
                }
            }
        }
    }
}
