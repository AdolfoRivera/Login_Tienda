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
            /*enter_cobrar obj = new enter_cobrar();
            obj.ShowDialog();*/
            enter_cobrar obj = new enter_cobrar();
            obj.label_total_a_pagar.Text = label_TOTAL.Text;
          //Ocultar anterior  this.Hide();
            obj.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            validacion();
        }
        //Operacion alternar colores de listview
        public void Alternarcolor()
        {
            for (int i=0;i<=listView_venta.Items.Count-1;i++)
            {
                if (listView_venta.Items[i].Index % 2 == 0)
                {
                    listView_venta.Items[i].BackColor = Color.LightBlue;
                }
                else
                {
                    listView_venta.Items[i].BackColor = Color.LightGreen;
                }
            }
        }
        public void validacion() {
            try
            {
                string cadsql = "select * from Productos where Codigo ='" + textBox_codigo_de_varrras.Text + "'";
                SqlCommand comando = new SqlCommand(cadsql, cnn);
                cnn.Open();
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == false)
                {
                    MessageBox.Show("Producto No Encontrado");
                    textBox_codigo_de_varrras.Clear();
                }
                else { 

                    ListViewItem lista = new ListViewItem(leer["venta"].ToString());
                    lista.SubItems.Add(leer["Codigo"].ToString());
                    lista.SubItems.Add(leer["Descripcion"].ToString());
                    //lista.SubItems.Add(leer["venta"].ToString());
                    lista.SubItems.Add(leer[4].ToString());
                    lista.SubItems.Add(leer["venta"].ToString());
                    lista.SubItems.Add(leer["Cantidad"].ToString());
                    listView_venta.Items.Add(lista);

                    textBox_codigo_de_varrras.Clear();
                

                    //if (listView_venta.SubItems.Count == 4)

                    double suma = 0;
                    for (int i = 0; i < listView_venta.Items.Count; i++)
                    {

                        if (listView_venta.Items[i].SubItems[0].Text != "")
                        {
                            suma += Convert.ToInt32(listView_venta.Items[i].SubItems[0].Text);
                        }
                        }
                        //Operacion subtotal
                        //  label_TOTAL.Text = suma.ToString();
                        label_subtotal.Text = suma.ToString();
                        //Operacion iva
                        double subtotal = double.Parse(label_subtotal.Text);
                        double iva;
                        iva = (subtotal * 16 / 100);
                        label_iva.Text = iva.ToString();
                        //Operacion total con iva
                        double suma2;
                        double numtxtsubtotal = double.Parse(label_subtotal.Text);
                        double numtxtiva = double.Parse(label_iva.Text);
                        suma2 = (numtxtsubtotal + numtxtiva);
                        label_total2.Text = suma2.ToString();
                    label_total_abajo.Text = suma2.ToString();
                    //_--------------------------
                        label_TOTAL.Text = suma2.ToString();
                        //Operacion numero de productos en venta
                        ListViewItem color = new ListViewItem(textBox_codigo_de_varrras.Text);
                        listView_venta.Items.Add(color);
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
    


        
        private void label_TOTAL_Click(object sender, EventArgs e)
        {
            
            //item.SubItems[2]) hace referencia a la 3 columna, ten en cuenta que empiezan en 0.
        }

        private void listView_venta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView_venta_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        
        }

        private void textBox_codigo_de_varrras_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox_codigo_de_varrras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                validacion();
            }
        }
        //Boton Borrar Todo
        private void button5_borrar_Click(object sender, EventArgs e)
        {
            listView_venta.Items.Clear();
            label_subtotal.Text = "0.00";
            label_iva.Text = "0.00";
            label_total2.Text = "0.00";
            label_TOTAL.Text = "0.00";
            label_total_abajo.Text = "0.00";
            
        }

        private void button_borrar_seleccionado_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lista in listView_venta.SelectedItems)
            {
                lista.Remove();
                //Operaciones Para Restar Lo Que Se Elimnte
                double sumaR = 0;
                for (int i = 0; i < listView_venta.Items.Count; i++)
                {

                    if (listView_venta.Items[i].SubItems[0].Text != "")
                    {
                        sumaR += Convert.ToInt32(listView_venta.Items[i].SubItems[0].Text);
                    }
                }
                //Operacion subtotal
                //  label_TOTAL.Text = suma.ToString();
                label_subtotal.Text = sumaR.ToString();
                //Operacion iva
                double subtotal = double.Parse(label_subtotal.Text);
                double iva;
                iva = (subtotal * 16 / 100);
                label_iva.Text = iva.ToString();
                //Operacion total con iva
                double suma2;
                double numtxtsubtotal = double.Parse(label_subtotal.Text);
                double numtxtiva = double.Parse(label_iva.Text);
                suma2 = (numtxtsubtotal + numtxtiva);
                label_total2.Text = suma2.ToString();

                label_TOTAL.Text = suma2.ToString();
                label_total_abajo.Text = suma2.ToString();
            }
        }
        private void listView_venta_KeyUp(object sender, KeyEventArgs e)
        {       
        }
        //Evento para poner marca de agua
        private void textBox_codigo_de_varrras_Enter(object sender, EventArgs e)
        {
            if (textBox_codigo_de_varrras.Text=="Codigo de barras")
            {
                textBox_codigo_de_varrras.Text = "";
                textBox_codigo_de_varrras.ForeColor = Color.Black;
            }
        }
        //Evento para poner marca de agua
        private void textBox_codigo_de_varrras_Leave(object sender, EventArgs e)
        {
            if (textBox_codigo_de_varrras.Text == "")
            {
                textBox_codigo_de_varrras.Text = "Codigo de barras";
                textBox_codigo_de_varrras.ForeColor = Color.Silver;
            }
        }
    }
}

