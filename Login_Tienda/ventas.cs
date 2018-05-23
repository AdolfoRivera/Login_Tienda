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
        //SqlConnection cnn;
        SqlCommand cmd;
        SqlConnection con = Conexion.ObtenerConexion();
        public ventas()
        {

            InitializeComponent();
            //HORA
           // label_hora_venta.Text = DateTime.Now.ToString("dd-MM-yyyy");
            textBox_hora_actual.Text = DateTime.Now.ToString("yyyy-MM-dd");

            //cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            try
            {

                buscar obj_b = new buscar();
                obj_b.ShowDialog();
                string cadsql2 = "select * from Productos where Codigo ='" + obj_b.textBox_buscar.Text + "'or Descripcion='" +obj_b.textBox_buscar.Text + "'"; //"'";

                //string cadsql2 = "select * from Productos where Codigo like'%" + obj_b.textBox_buscar.Text + "%'or Descripcion like'%" + obj_b.textBox_buscar.Text + "%'";// + "'";
                SqlCommand comando = new SqlCommand(cadsql2, con);
                con.Open();
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == false)
                {
                    //MessageBox.Show("Producto No Encontrado");
                    // obj_b.textBox_buscar.Clear();
                }
                else
                {
                    MessageBox.Show("Producto agregado");
                    //validacion();
                    ListViewItem lista2 = new ListViewItem(leer["venta"].ToString());
                    lista2.SubItems.Add(leer["Codigo"].ToString());
                    lista2.SubItems.Add(leer["Descripcion"].ToString());
                    //lista.SubItems.Add(leer["venta"].ToString());
                    lista2.SubItems.Add(leer[4].ToString());
                    lista2.SubItems.Add(leer["venta"].ToString());
                    lista2.SubItems.Add(leer["Cantidad"].ToString());
                    listView_venta.Items.Add(lista2);

                    obj_b.textBox_buscar.Clear();

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
                    label_total2.Text = suma2.ToString("F2");
                    label_total_abajo.Text = suma2.ToString("F2");
                    //_--------------------------
                    label_TOTAL.Text = suma2.ToString("F2");//.Replace(",", ".");
                    
                   // textBox_total.Text = suma2.ToString().Replace(",", ".");

                    //Operacion alternar color
                    // ListViewItem color = new ListViewItem(obj_b.textBox_buscar.Text);
                    //listView_venta.Items.Add(color);
                    //Alternarcolor();
                    //operacion sumar numero de productos en venta
                    string TP = listView_venta.Items.Count.ToString();
                    //label_num_prod_en_venta.Text = listView_venta.Items.Count.ToString();
                    int TP2 = Convert.ToInt32(TP);
                    int TP3 = TP2 - 1;
                    label_num_prod_en_venta.Text = TP3.ToString();

                }
                con.Close();
                /*if (obj_b.textBox_buscar.Text.Trim()== "")
                {

                 //   MessageBox.Show("Producto no encontrado");

                }
                else
                {
                     validacion();
                     MessageBox.Show("Producto encontrado");
                }*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


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
        

            try
            {
                //if (listView_venta.Items.Count <= 0)
                if (label_TOTAL.Text == "0,00" || label_TOTAL.Text == "0")
                {

                    MessageBox.Show("No hay nada que vender");
                }
                else
                {
                    enter_cobrar obj = new enter_cobrar();
                    obj.label_total_a_pagar.Text = label_TOTAL.Text;
                    //-----prueba
                    //obj.textBox_nombre_cobrear.Text = textBox_nombre.Text;

                    obj.textBox_fecha_cobrar.Text = textBox_hora_actual.Text;
                    obj.textBox_total_cobrar.Text = label_TOTAL.Text;
                  //  obj.textBox_total_cobrar.Text = textBox_total.Text;

                    //obj.textBox_codigo_cobrar.Text = textBox_codigo_de_varrras.Text;
               

                    //Ocultar anterior  this.Hide();
                    obj.ShowDialog();
                    double L_C;
                    L_C = double.Parse(obj.label_cambio_pago.Text);


                    if (L_C <= 0)
                    {
                        //  MessageBox.Show("La Cantidad Especificada No Es Suficiente");
                    }
                    else
                    {

                        listView_venta.Items.Clear();
                        label_subtotal.Text = "0,00";
                        label_iva.Text = "0,00";
                        label_total2.Text = "0,00";
                        label_TOTAL.Text = "0,00";
                        label_num_prod_en_venta.Text = "0";
                       // textBox_total.Text = "0";
                        //label_total_abajo.Text = "0.00";
                        label_total_abajo.Text = obj.label_total_a_pagar.Text;
                        label_pago_con.Text = obj.textBox_pago.Text;// .Text = suma2.ToString();
                        label_cambio.Text = obj.label_cambio_pago.Text;

                        //--------INS VENTA----------------
                        menu me = new menu();
                       
                        // float total = Convert.ToInt32(label_TOTAL.Text);
                         //ins_venta(textBox_nombre.Text,textBox_hora_actual.Text,total);
                       
//                        MessageBox.Show("Gracias por su compra");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      /*  public void ins_venta(String Nombre, String fecha, float total)
        {
            menu me = new menu();

            if (me.label_usuario.Text.Equals("") == true)
            {
                MessageBox.Show("Campos vacios");
            }
            else if (textBox_hora_actual.Text.Equals("") == true)
            {
                MessageBox.Show("Campos vacios");
            }
            else if (textBox_total.Text.Equals("") == true)
            {
                MessageBox.Show("Campos vacios");
            }
            else
            {
                //  cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
                con = Conexion.ObtenerConexion();
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "ins_venta";
                cmd.CommandType = CommandType.StoredProcedure;

           
                cmd.Parameters.AddWithValue("@Nombre", textBox_nombre.Text);
                cmd.Parameters.AddWithValue("@fecha", textBox_hora_actual.Text);
                cmd.Parameters.AddWithValue("@total", textBox_total.Text);


                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Venta realizada", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception er)
                {
                    // throw;
                    MessageBox.Show(er.Message + MessageBoxIcon.Error);
                }

            }
        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int c = Convert.ToInt32(textBox_cantidad.Text);
                dis_Stock(textBox_codigo_de_varrras.Text, c);
                validacion();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Operacion alternar colores de listview
        public void Alternarcolor()
        {
            for (int i = 0; i <= listView_venta.Items.Count - 1; i++)

            {                                  //%2 ==0
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
        public void validacion()
        {
            try
            {
              

                string cadsql = "select * from Productos where Codigo ='" + textBox_codigo_de_varrras.Text + "'";
                SqlCommand comando = new SqlCommand(cadsql, con);
                con.Open();
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == false)
                {
                    MessageBox.Show("Producto No Encontrado");
                    textBox_codigo_de_varrras.Clear();
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
                    label_total2.Text = suma2.ToString("F2");
                    label_total_abajo.Text = suma2.ToString("F2");
                    //_--------------------------
                    label_TOTAL.Text = suma2.ToString("F2");//.Replace(",", ".");
                  //  textBox_total.Text = suma2.ToString().Replace(",", ".");

                    //Operacion alternar color
                   // ListViewItem color = new ListViewItem(textBox_codigo_de_varrras.Text);
                   // listView_venta.Items.Add(color);
                   // Alternarcolor();

                    //operacion sumar numero de productos en venta
                    //label_num_prod_en_venta.Text = listView_venta.Items.Count.ToString();
                    string TP = listView_venta.Items.Count.ToString();
                    
                    int TP2 = Convert.ToInt32(TP);
                    int TP3 = TP2 - 1;
                    label_num_prod_en_venta.Text = TP3.ToString();

                }
                con.Close();
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
            try
            {
                if (textBox_codigo_de_varrras.Text == "'")
                {
                    MessageBox.Show("NO (')");
                    textBox_codigo_de_varrras.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void sololNumeros(KeyPressEventArgs pe)
        {

            if (char.IsDigit(pe.KeyChar))
            {
                pe.Handled = false;
            }
            else if (char.IsControl(pe.KeyChar))
            {
                pe.Handled = false;
            }
            else
            {
                pe.Handled = true;
            }
        }
        private void textBox_codigo_de_varrras_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                sololNumeros(e);
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    int c = Convert.ToInt32(textBox_cantidad.Text);
                    dis_Stock(textBox_codigo_de_varrras.Text, c);
                    validacion();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Boton Borrar Todo
        private void button5_borrar_Click(object sender, EventArgs e)
        {
            listView_venta.Items.Clear();
            label_subtotal.Text = "0,00";
            label_iva.Text = "0,00";
            label_total2.Text = "0,00";
            label_TOTAL.Text = "0,00";
           // textBox_total.Text = "0,00";
            label_total_abajo.Text = "0,00";
            label_num_prod_en_venta.Text = "0";

        }

        private void button_borrar_seleccionado_Click(object sender, EventArgs e)
        {
            try
            {
                int c = Convert.ToInt32(textBox_cantidad.Text);
                aum_Stock(textBox2.Text, c);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //-----------------------------

            foreach (ListViewItem lista in listView_venta.SelectedItems)
            {
                lista.Remove();
                //Operaciones Para Restar Lo Que Se Eliminte
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
                label_total2.Text = suma2.ToString("F2");

                label_TOTAL.Text = suma2.ToString("F2");
               // textBox_total.Text = suma2.ToString();
                label_total_abajo.Text = suma2.ToString("F2");

                //operacion sumar numero de productos en venta
                //label_num_prod_en_venta.Text = listView_venta.Items.Count.ToString();
                string TP = listView_venta.Items.Count.ToString();
               
                int TP2 = Convert.ToInt32(TP);
                int TP3 = TP2 - 1;
                label_num_prod_en_venta.Text = TP3.ToString();
            }
        }
        private void listView_venta_KeyUp(object sender, KeyEventArgs e)
        {
            //int c = Convert.ToInt32(textBox_cantidad.Text);
            //dis_Stock(textBox_codigo_de_varrras.Text, c);
            
        }

        public void dis_Stock(String Codigo, int cantidad)
        {
        
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "dis_Stock";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Codigo", textBox_codigo_de_varrras.Text);

          // textBox_codigo_de_varrras.Clear();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@Cantidad";
            p1.SqlDbType = SqlDbType.Int;
            p1.Value = cantidad;
            cmd.Parameters.Add(p1);

            try
            {
                con.Open();

                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        //Evento para poner marca de agua
    
        private void textBox_codigo_de_varrras_Enter(object sender, EventArgs e)
        {
            if (textBox_codigo_de_varrras.Text == "Codigo de barras")
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

        private void button_hacer_venta_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void ventas_KeyUp(object sender, KeyEventArgs e)
        {
            

            if (e.KeyCode == Keys.Space)
            {
           
                try
                {

                    if (label_TOTAL.Text == "0,00" || label_TOTAL.Text == "0")
                    {

                        MessageBox.Show("No hay nada que vender");
                    }

                    else
                    {
                         

                        enter_cobrar obj = new enter_cobrar();
                        obj.label_total_a_pagar.Text = label_TOTAL.Text;
                        //-----prueba
                        //obj.textBox_nombre_cobrear.Text = textBox_nombre.Text;
                        obj.textBox_fecha_cobrar.Text = textBox_hora_actual.Text;
                        //obj.textBox_total_cobrar.Text = textBox_total.Text;
                        obj.textBox_total_cobrar.Text = label_TOTAL.Text;
                        // obj.textBox_codigo_cobrar.Text = textBox_codigo_de_varrras.Text;
                        //Ocultar anterior  this.Hide();
                        obj.ShowDialog();
                        double L_C;
                        L_C = double.Parse(obj.label_cambio_pago.Text);

                        if (L_C <= 0)
                        {
                            //  MessageBox.Show("La Cantidad Especificada No Es Suficiente");
                        }
                        else
                        {

                            listView_venta.Items.Clear();
                            label_subtotal.Text = "0,00";
                            label_iva.Text = "0,00";
                            label_total2.Text = "0,00";
                            label_TOTAL.Text = "0,00";
                            label_num_prod_en_venta.Text = "0";
                           // textBox_total.Text = "0";
                            //label_total_abajo.Text = "0.00";
                            label_total_abajo.Text = obj.label_total_a_pagar.Text;
                            label_pago_con.Text = obj.textBox_pago.Text;// .Text = suma2.ToString();
                            label_cambio.Text = obj.label_cambio_pago.Text;
                            
                            /*menu me = new menu();
                            enter_cobrar ec = new enter_cobrar();
                            float total = Convert.ToInt32(label_TOTAL.Text);
                            ins_venta(me.label_usuario.Text, me.label_hora_actual.Text, total);*/

                          //  MessageBox.Show("Gracias por su compra");

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ventas_Load(object sender, EventArgs e)
        {
           
                //--COLOR
                //  int i=0;

                //  listView_venta.Items[i].BackColor = Color.LightBlue;
                listView_venta.BackColor = Color.AliceBlue;
                /*Form1 f = new Form1();
                menu me1 = new menu();
                string userr = f.textBox_usuario.Text;
                label_user.Text = userr;*/
                //label_user.Text = me1.label_usuario.Text;

            }
        
        private void listView_venta_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            ListViewItem item = listView_venta.GetItemAt(e.X, e.Y);
            if (item != null)
            {
               // textBox1.Text = item.Text;
                textBox2.Text = item.SubItems[1].Text;
                //txtPrecio.Text = item.SubItems[2].Text;
            }
        }
        //PROCEDIMIENTO AUMENTAR
        public void aum_Stock(String nombre, int cant)
        {
            //string rpta = "";
            //con = new SqlConnection("Data Source=DARCK;Initial Catalog=BTA;Integrated Security=True");
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "aum_Stock";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Codigo", textBox2.Text);

            textBox2 .Clear();

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@Cantidad";
            p1.SqlDbType = SqlDbType.Int;
            p1.Value = cant;
            cmd.Parameters.Add(p1);

            try
            {
                con.Open();
                MessageBox.Show("Canselacion existosa");
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }
    }
}
