using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_7_F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string substr1 = substr1_t.Text;
            string substr2 = substr2_t.Text;
            StringBuilder t = new StringBuilder(text.Text.Replace(substr1, substr2));

            text.Text = t.ToString();
        }
    }
}
