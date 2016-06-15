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

namespace LoginDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Stream stream = new FileStream(@"Data\URLSource.txt", FileMode.Open);
            StreamReader sr = new StreamReader(stream);
            string str= sr.ReadToEnd();
            sr.Close();
            string[] ss = str.Split('\n');
            Console.WriteLine(ss.Length);
        }
    }
}
