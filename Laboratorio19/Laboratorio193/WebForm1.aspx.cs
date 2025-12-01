using System;
using System.IO;
using System.Net;

public partial class WebForm1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetItem();
        }
    }

    private void GetItem()
    {
        var url = $"https://localhost:44395/api/values/get/2";
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
                        // Mostrar la respuesta en el TextBox
                        txtRespuesta.Text = responseBody;
                    }
                }
            }
        }
        catch (WebException ex)
        {
            txtRespuesta.Text = "Error al consumir la API: " + ex.Message;
        }
    }
}
