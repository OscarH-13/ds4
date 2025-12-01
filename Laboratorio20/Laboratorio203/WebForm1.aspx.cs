using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace Laboratorio203
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        // MISMA cadena de conexión que en Laboratorio14
        string connectionString = @"Server=localhost;Database=Productos;Trusted_Connection=True;";

        // En WebForms necesitamos conservar este valor entre postbacks
        bool Nuevo
        {
            get { return (bool?)ViewState["Nuevo"] ?? false; }
            set { ViewState["Nuevo"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                InicializarControles();
            }
        }

        private void InicializarControles()
        {
            // Equivalente a frmProductos_Load
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEliminar.Enabled = false;

            txtId.Enabled = false;
            btnBuscar.Enabled = true;
            txtBuscarId.Enabled = true;

            txtNombre.Enabled = false;
            txtPrecio.Enabled = false;
            txtStock.Enabled = false;

            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            txtBuscarId.Text = "";
            lblMensaje.Text = "";

            Nuevo = false;
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            // Equivalente a tsbNuevo_Click
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEliminar.Enabled = false;

            txtBuscarId.Enabled = false;
            btnBuscar.Enabled = false;

            txtId.Enabled = false;
            txtNombre.Enabled = true;
            txtPrecio.Enabled = true;
            txtStock.Enabled = true;

            txtId.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtStock.Text = "";
            lblMensaje.Text = "";

            Nuevo = true;
            txtNombre.Focus();
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "";

            if (Nuevo)
            {
                // INSERT
                string sql = "INSERT INTO LAPTOPS (NOMBRE, PRECIO, STOCK) " +
                             "VALUES (@nombre, @precio, @stock)";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@precio", txtPrecio.Text);
                    cmd.Parameters.AddWithValue("@stock", txtStock.Text);

                    con.Open();
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0) lblMensaje.Text = "Registro ingresado correctamente!";
                    }
                    catch (Exception ex)
                    {
                        lblMensaje.Text = "Error: " + ex.Message;
                    }
                }
            }
            else
            {
                // UPDATE
                string sql = "UPDATE LAPTOPS SET NOMBRE=@nombre, PRECIO=@precio, STOCK=@stock WHERE ID=@id";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                    cmd.Parameters.AddWithValue("@precio", txtPrecio.Text);
                    cmd.Parameters.AddWithValue("@stock", txtStock.Text);
                    cmd.Parameters.AddWithValue("@id", txtId.Text);

                    con.Open();
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0) lblMensaje.Text = "Registro actualizado correctamente!";
                    }
                    catch (Exception ex)
                    {
                        lblMensaje.Text = "Error: " + ex.Message;
                    }
                }
            }

            // Volvemos al estado inicial
            InicializarControles();
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            // Equivalente a tsbCancelar_Click
            InicializarControles();
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "";

            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                lblMensaje.Text = "No hay registro cargado para eliminar.";
                return;
            }

            string sql = "DELETE FROM LAPTOPS WHERE ID=@id";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", txtId.Text);

                con.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0) lblMensaje.Text = "Registro eliminado correctamente!";
                }
                catch (Exception ex)
                {
                    lblMensaje.Text = "Error: " + ex.Message;
                }
            }

            InicializarControles();
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "";

            if (string.IsNullOrWhiteSpace(txtBuscarId.Text))
            {
                lblMensaje.Text = "Ingrese un Id para buscar.";
                return;
            }

            string sql = "SELECT * FROM LAPTOPS WHERE ID=@id";

            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id", txtBuscarId.Text);

                con.Open();
                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Estado de edición (equivalente a cuando encuentras registro en tsbBuscar_Click)
                            btnNuevo.Enabled = false;
                            btnGuardar.Enabled = true;
                            btnCancelar.Enabled = true;
                            btnEliminar.Enabled = true;

                            txtId.Enabled = false;
                            btnBuscar.Enabled = false;
                            txtBuscarId.Enabled = false;

                            txtNombre.Enabled = true;
                            txtPrecio.Enabled = true;
                            txtStock.Enabled = true;

                            txtId.Text = reader[0].ToString();
                            txtNombre.Text = reader[1].ToString();
                            txtPrecio.Text = reader[2].ToString();
                            txtStock.Text = reader[3].ToString();

                            Nuevo = false;
                            txtNombre.Focus();
                        }
                        else
                        {
                            lblMensaje.Text = "Ningún registro encontrado con el Id ingresado!";
                        }
                    }
                }
                catch (Exception ex)
                {
                    lblMensaje.Text = "Error: " + ex.Message;
                }
            }

            txtBuscarId.Text = "";
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            // En Web no se "cierra" la ventana como en WinForms.
            // Puedes redirigir, por ejemplo, a otra página del sitio:
            Response.Redirect("~/");
        }
    }
}
