using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio201
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        int num;
        int[] numeros = new int[25];
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label3.Text = "";
            int num = Convert.ToInt32(TextBox1.Text);
            for (int i = 0; i < 25; i++)
            {
                numeros[i] = num * (i + 1);
                Label3.Text = Label3.Text + numeros[i].ToString() + " ";
            }
            
        }
    }
}