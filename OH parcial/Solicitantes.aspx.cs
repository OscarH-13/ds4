using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Solicitantes : System.Web.UI.Page
{
    string conexion = ConfigurationManager.ConnectionStrings["ConexionPasaportes"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            CargarSolicitantes();
    }

    void CargarSolicitantes()
    {
        using (SqlConnection con = new SqlConnection(conexion))
        {
            string sql = "SELECT * FROM Solicitantes";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            gvSolicitantes.DataSource = dt;
            gvSolicitantes.DataBind();
        }
    }

    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        Response.Redirect("SolicitantesNuevo.aspx");
    }
}
