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
namespace Login_Tienda
{
    public partial class Fecha_de_reporte : Form
    {
        SqlConnection con;
        public Fecha_de_reporte()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Generar_Reporte _rep = new Generar_Reporte();
                 // SqlConnection con = new SqlConnection();
                //SqlConnection con2 = new SqlConnection("Data Source = DARCK; Initial Catalog = Tienda; Integrated Security = True");
                con = Conexion.ObtenerConexion();
                con.Open();
               // string parametro = textBox_fecha.Text;
            string parametro2 = dateTimePicker_fecha_reporte.Text;
                _rep.mostrar(con, parametro2, "Plantilla_Reporte.rpt");
            this.Close();

        }
    }
}
