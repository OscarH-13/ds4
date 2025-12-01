using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Laboratorio202
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnGenerar_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            litTabla.Text = "";

            int n;
            if (!int.TryParse(txtN.Text, out n) || n <= 0)
            {
                lblError.Text = "Por favor ingrese un número entero positivo.";
                return;
            }

            // Generar la tabla HTML
            StringBuilder sb = new StringBuilder();
            sb.Append("<table border='1' cellpadding='5' cellspacing='0'>");

            for (int i = 0; i < n; i++)
            {
                sb.Append("<tr>");
                for (int j = 0; j < n; j++)
                {
                    int valor = (i == j) ? 1 : 0;
                    sb.AppendFormat("<td style='text-align:center; width:30px;'>{0}</td>", valor);
                }
                sb.Append("</tr>");
            }

            sb.Append("</table>");

            // Mostrar la tabla en el Literal
            litTabla.Text = sb.ToString();
        }
    }
}