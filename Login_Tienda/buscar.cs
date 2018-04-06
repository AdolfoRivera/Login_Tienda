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
        ventas ven = new ventas();
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
            cmd.CommandText = "select * from Productos where Codigo ='" + textBox_buscar.Text + "'or Descripcion='"+textBox_buscar.Text+"'";
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
        //Operacion alternar colores de listview
        
        public void Alternarcolor()
        {
            for (int i = 0; i <= ven.listView_venta.Items.Count - 1; i++)
            {
                if (ven.listView_venta.Items[i].Index % 2 == 0)
                {
                    ven.listView_venta.Items[i].BackColor = Color.LightBlue;
                }
                else
                {
                    ven.listView_venta.Items[i].BackColor = Color.LightGreen;
                }
            }
        }
        public void validacion_buscar()
        {
            try
            {
                string cadsql = "select * from Productos where Codigo ='" + textBox_buscar.Text + "'";
                SqlCommand comando = new SqlCommand(cadsql, cnn);
                cnn.Open();
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == false)
                {
                    MessageBox.Show("Producto No Encontrado");
                    textBox_buscar.Clear();
                }
                else
                {

                    ListViewItem lista = new ListViewItem(leer["venta"].ToString());
                    lista.SubItems.Add(leer["Codigo"].ToString());
                    lista.SubItems.Add(leer["Descripcion"].ToString());
                    //lista.SubItems.Add(leer["venta"].ToString());
                    lista.SubItems.Add(leer[4].ToString());
                    lista.SubItems.Add(leer["venta"].ToString());
                    lista.SubItems.Add(leer["Cantidad"].ToString());
                    ven.listView_venta.Items.Add(lista);

                    textBox_buscar.Clear();


                    //if (listView_venta.SubItems.Count == 4)

                    double suma = 0;
                    for (int i = 0; i < ven.listView_venta.Items.Count; i++)
                    {

                        if (ven.listView_venta.Items[i].SubItems[0].Text != "")
                        {
                            suma += Convert.ToInt32(ven.listView_venta.Items[i].SubItems[0].Text);
                        }
                    }
                    //Operacion subtotal
                    //  label_TOTAL.Text = suma.ToString();
                    ven.label_subtotal.Text = suma.ToString();
                    //Operacion iva
                    double subtotal = double.Parse(ven.label_subtotal.Text);
                    double iva;
                    iva = (subtotal * 16 / 100);
                    ven.label_iva.Text = iva.ToString();
                    //Operacion total con iva
                    double suma2;
                    double numtxtsubtotal = double.Parse(ven.label_subtotal.Text);
                    double numtxtiva = double.Parse(ven.label_iva.Text);
                    suma2 = (numtxtsubtotal + numtxtiva);
                    ven.label_total2.Text = suma2.ToString();
                    ven.label_total_abajo.Text = suma2.ToString();
                    //_--------------------------
                    ven.label_TOTAL.Text = suma2.ToString();
                    //Operacion numero de productos en venta
                    ListViewItem color = new ListViewItem(textBox_buscar.Text);
                    ven.listView_venta.Items.Add(color);
                    Alternarcolor();

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




        private void button_aceptar_Click(object sender, EventArgs e)
        {
                    // ventas ob = new ventas();
            try {
                if (textBox_buscar.Text!="") {
                    //if (textBox_buscar.TextLength!=0) {

                    validacion_buscar();
                    MessageBox.Show("Producto Agregado");
                }
                else
                {
                    MessageBox.Show("No Hay Nada En Escrito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
       
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
