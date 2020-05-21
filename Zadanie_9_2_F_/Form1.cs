using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_9_2_F_
{
    public partial class Form1 : Form
    {
        string file;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            res.Text = "";
            StreamReader fs = new StreamReader(file);
            string text = "";
            Console.WriteLine("В данном файле строки, имеющие пробел: ");
            while (true)
            {
                string temp = fs.ReadLine();
                if (temp == null) break;
                text += temp;
                if (temp.Contains(' '))
                {
                    res.Text += temp;
                    res.Text += Environment.NewLine;
                }
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file = openFileDialog1.FileName;
                filename.Text = openFileDialog1.FileName;
            }
        }
    }
}
