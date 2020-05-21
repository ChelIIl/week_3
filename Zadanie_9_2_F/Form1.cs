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

namespace Zadanie_9_2_F
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
            int n = int.Parse(N.Text);
            double r;
            string[] s = num_t.Text.Split(' ');

            FileStream f = new FileStream(file, FileMode.Open);
            BinaryWriter Ofile = new BinaryWriter(f);

            for (int i = 0; i < n; i++)
            {
                r = double.Parse(s[i]);
                Ofile.Write(r);
            }

            Ofile.Close();

            f = new FileStream(file, FileMode.Open);
            BinaryReader Rfile = new BinaryReader(f);

            long l = f.Length;

            Console.Write("Меньше числа:");
            double num = double.Parse(s_t.Text);

            for (long i = 8; i < l; i += 16)
            {
                f.Seek(i, SeekOrigin.Begin);
                r = Rfile.ReadDouble();
                if (r < num)
                    res.Text += r + " ";
            }

            Rfile.Close();
            f.Close();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                file = openFileDialog1.FileName;
                filename.Text = openFileDialog1.FileName;
            }
        }

        private void filename_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
