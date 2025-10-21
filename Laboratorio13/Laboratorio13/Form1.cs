using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Laboratorio13
{
    public partial class Form1 : Form
    {
        string connectionString = @"Server=localhost;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";
        bool conectadoABaseDeDato = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(connectionString);
            conexion.Open();
            MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");
            using (var cmd = new SqlCommand("SELECT ProductName FROM dbo.Products ORDER BY ProductName;", conexion))
            using (var rd = cmd.ExecuteReader())
            {
                listBox1.Items.Clear();
                while (rd.Read())
                {
                    listBox1.Items.Add(rd["ProductName"].ToString());
                }
            }
            conexion.Close();
            MessageBox.Show("Se cerró la conexión");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {}
    }
}
