using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio121
{
    public partial class Form1 : Form
    {
        float distancia = 0, velocidad = 0, tiempo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                tiempo = float.Parse(textBox2.Text);
                velocidad = float.Parse(textBox1.Text);
            }
            else
            {
                tiempo = 0;
                velocidad = 0;
            }
            distancia = velocidad * tiempo;
            textBox3.Text = distancia.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0"; textBox2.Text = "0"; textBox3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {}
    }
}
