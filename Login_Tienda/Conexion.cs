using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------agregado para conexion-------
using System.Data.SqlClient;
using Login_Tienda.Properties;
using System.Configuration;
namespace Login_Tienda

{
    public class Conexion
    {
        public static string obtenerstring()
        {
            return Settings.Default.TiendaConnectionString;
        }

        public static SqlConnection ObtenerConexion() { 
        SqlConnection con = new SqlConnection(obtenerstring());
            //con.Open();
            return con;
    }
    }
}
