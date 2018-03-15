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
    public partial class ventas : Form
    {
        SqlConnection cnn;
        SqlCommand cmd;
        public ventas()
        {
            InitializeComponent();
            cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            buscar obj = new buscar();
            obj.ShowDialog();

        }

        private void button_entradas_Click(object sender, EventArgs e)
        {
            entradas obj = new entradas();
            obj.ShowDialog();
        }

        private void button_salidas_Click(object sender, EventArgs e)
        {
            Salidas obj = new Salidas();
            obj.ShowDialog();
        }

        private void button_hacer_venta_Click(object sender, EventArgs e)
        {
            enter_cobrar obj = new enter_cobrar();
            obj.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cadsql = "select * from Productos where Codigo ='" + textBox_codigo_de_varrras.Text + "'";
                SqlCommand comando = new SqlCommand(cadsql, cnn);
                cnn.Open();
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    ListViewItem lista = new ListViewItem(leer["Codigo"].ToString());
                    lista.SubItems.Add(leer["Descripcion"].ToString());
                    lista.SubItems.Add(leer["Venta"].ToString());
                    //lista.SubItems.Add(leer["venta"].ToString());
                    lista.SubItems.Add(leer[0].ToString());
                    lista.SubItems.Add(leer["venta"].ToString());
                    lista.SubItems.Add(leer["Cantidad"].ToString());
                    listView_venta.Items.Add(lista);
                    
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            /*ListViewItem lista = new ListViewItem(textBox_codigo_de_varrras.Text);
            listView_venta.Items.Add(lista);*/

        }
        
        private void label_TOTAL_Click(object sender, EventArgs e)
        {
            
            //item.SubItems[2]) hace referencia a la 3 columna, ten en cuenta que empiezan en 0.
        }
    }
}
