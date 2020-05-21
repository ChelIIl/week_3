using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Zadanie_8_F
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double re = 0;
            string s = str.Text;

            Regex n = new Regex(@"\d\w*,\w*e\S*|\d\w*,\w*|\d\w*");
            MatchCollection num = n.Matches(s);
            string st;

            for (int i = 0; i < num.Count; i++)
            {
                st = num[i].ToString();
                re += double.Parse(st);
            }

            res.Text = re.ToString();
        }
    }
}
