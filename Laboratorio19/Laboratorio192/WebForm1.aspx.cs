using System;
using System.IO;
using System.Net;

public partial class WebForm1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Llamamos a la API cuando se carga la página por primera vez
        if (!IsPostBack)
        {
            GetItems();
        }
    }

    private void GetItems()
    {
        var url = "https://localhost:44395/api/values/get";
        var request = (HttpWebRequest)WebRequest.Create(url);

        request.Method = "GET";
        request.ContentType = "application/json";
        request.Accept = "application/json";

        try
        {
            using (WebResponse response = request.GetResponse())
            {
                using (Stream strReader = response.GetResponseStream())
                {
                    if (strReader == null) return;

                    using (StreamReader objReader = new StreamReader(strReader))
                    {
                        string responseBody = objReader.ReadToEnd();

                        // En vez de Console.WriteLine, mostramos en el WebForm
                        txtRespuesta.Text = responseBody;
                    }
                }
            }
        }
        catch (WebException ex)
        {
            // Manejo sencillo de error
            txtRespuesta.Text = "Error al consumir la API: " + ex.Message;
        }
    }
}
