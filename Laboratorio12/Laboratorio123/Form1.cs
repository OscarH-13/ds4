using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio123
{
    public partial class Form1 : Form
    {
        float n1, n2, n3, semiperimetro = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0"; textBox2.Text = "0"; textBox3.Text = "0"; textBox4.Text = "0"; textBox5.Text ="0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (semiperimetro == 0) 
            {
                MessageBox.Show("Primero calcule el semiperimetro");
            }
            else 
            {
                
                double area = Math.Sqrt(semiperimetro * (semiperimetro - n1) * (semiperimetro - n2) * (semiperimetro - n3));
                textBox5.Text= area.ToString();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox4.Text = "";
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                n1 = float.Parse(textBox1.Text); n2 = float.Parse(textBox2.Text); n3 = float.Parse(textBox3.Text);
                if (n1 + n2 <= n3 || n1 + n3 <= n2 || n2 + n3 <= n1)
                {
                    MessageBox.Show("Los valores no forman un triángulo válido.");
                    n1 = 0; n2 = 0; n3 = 0;
                    semiperimetro = 0;
                }
                else 
                {
                    semiperimetro = (n1 + n2 + n3) / 2;
                    textBox4.Text = semiperimetro.ToString();
                }
            }
        }
    }
}
