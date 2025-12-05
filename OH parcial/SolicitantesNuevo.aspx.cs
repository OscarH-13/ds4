using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.ConstrainedExecution;

public partial class SolicitantesNuevo : System.Web.UI.Page
{
    string conexion = ConfigurationManager.ConnectionStrings["ConexionPasaportes"].ConnectionString;

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        using (SqlConnection con = new SqlConnection(conexion))
        {
            string sql = "INSERT INTO Solicitantes (NOMBRE, APELLIDO, CEDULA, ESTADO) VALUES(@nom, @ape, @ced, @est)";

            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("@nom", txtNombre.Text);
            cmd.Parameters.AddWithValue("@ape", txtApellido.Text);
            cmd.Parameters.AddWithValue("@ced", txtCedula.Text);
            cmd.Parameters.AddWithValue("@est", ddlEstado.SelectedValue);


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }

        Response.Redirect("Solicitantes.aspx");
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("Solicitantes.aspx");
    }
}
