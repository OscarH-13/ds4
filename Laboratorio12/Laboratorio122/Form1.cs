using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio122
{
    public partial class Form1 : Form
    {
        float n1, n2, n3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0"; textBox2.Text = "0"; textBox3.Text = "0"; textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text!="")
            {
                n1 = float.Parse(textBox1.Text); n2 = float.Parse(textBox2.Text); n3 = float.Parse(textBox3.Text);
            }
            else
            {
                n1 = 0; n2 = 0; n3 = 0;
            }
            float promedio = (n1 + n2 + n3) / 3;
            textBox4.Text = promedio.ToString();
        }
    }
}
