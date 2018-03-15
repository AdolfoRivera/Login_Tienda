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
    public partial class buscar : Form
    {
        SqlConnection cnn;
        SqlCommand cmd = new SqlCommand();
        public buscar()
        {
            InitializeComponent();
            cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Productos where Codigo ='" + textBox1.Text + "'or Descripcion='"+textBox1.Text+"'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            datos.DataSource = dt;
            cnn.Close();
        }

        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
