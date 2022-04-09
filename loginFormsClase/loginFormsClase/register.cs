using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginFormsClase
{
    public partial class register : Form
    {
        
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass="";
            string User="";
            Form1 form1 = new Form1(User,pass);
        }
    }
}
