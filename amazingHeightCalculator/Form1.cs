using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amazingHeightCalculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        public void button1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.label4.Text = textBox1.Text.ToString();
            frm2.Show();
        }
    }
}
