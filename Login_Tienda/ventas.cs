﻿using System;
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
            //cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                buscar obj_b = new buscar();
                obj_b.ShowDialog();
                string cadsql2 = "select * from Productos where Codigo like'%" + obj_b.textBox_buscar.Text + "%'or Descripcion like'%" + obj_b.textBox_buscar.Text + "%'";// + "'";
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
                    label_total2.Text = suma2.ToString();
                    label_total_abajo.Text = suma2.ToString();
                    //_--------------------------
                    label_TOTAL.Text = suma2.ToString();
                    //Operacion alternar color
                    ListViewItem color = new ListViewItem(obj_b.textBox_buscar.Text);
                    listView_venta.Items.Add(color);
                    Alternarcolor();
                    //operacion sumar numero de productos en venta
                    label_num_prod_en_venta.Text = listView_venta.Items.Count.ToString();

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
            /*enter_cobrar obj = new enter_cobrar();
            obj.ShowDialog();*/


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
                        //label_total_abajo.Text = "0.00";
                        label_total_abajo.Text = obj.label_total_a_pagar.Text;
                        label_pago_con.Text = obj.textBox_pago.Text;// .Text = suma2.ToString();
                        label_cambio.Text = obj.label_cambio_pago.Text;

                          menu me = new menu();
                          enter_cobrar ec = new enter_cobrar();
                          float total = Convert.ToInt32(label_TOTAL.Text);
                          ins_venta(me.label_usuario.Text,me.label_hora_actual.Text, total); 
                        MessageBox.Show("Gracias por su compra");

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        menu me = new menu();
        public void ins_venta(String Nombre, String fecha, float total)
        {
            if (me.label_usuario.Text.Equals(" ") == true)
            {
                MessageBox.Show("Campos Bacios");
            }
            else if (label_TOTAL.Text.Equals(" ") == true)
            {
                MessageBox.Show("Campos Bacios");
            }
            else if (me.label_hora_actual.Text.Equals(" ") == true)
            {
                MessageBox.Show("Campos Bacios");
            }
            else
            {
                //  cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
                con = Conexion.ObtenerConexion();
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "ins_venta";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", me.label_hora_actual.Text);
                cmd.Parameters.AddWithValue("@fecha", label_TOTAL.Text);
                cmd.Parameters.AddWithValue("@total", me.label_hora_actual.Text);

                /*me.label_usuario.Clear();
                ve.label_TOTAL.Clear();
                me.label_hora_actual.Clear();*/

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
        }
            private void button1_Click(object sender, EventArgs e)
        {
            validacion();
        }
        //Operacion alternar colores de listview
        public void Alternarcolor()
        {
            for (int i=0;i<=listView_venta.Items.Count-1;i++)
           
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
        public void validacion() {
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
                        //Operacion alternar color
                        ListViewItem color = new ListViewItem(textBox_codigo_de_varrras.Text);
                        listView_venta.Items.Add(color);
                        Alternarcolor();

                    //operacion sumar numero de productos en venta
                    label_num_prod_en_venta.Text = listView_venta.Items.Count.ToString();

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
            sololNumeros(e);   
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
            label_num_prod_en_venta.Text = "0";
            
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

                //operacion sumar numero de productos en venta
                label_num_prod_en_venta.Text = listView_venta.Items.Count.ToString();
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
                            label_subtotal.Text = "0.00";
                            label_iva.Text = "0.00";
                            label_total2.Text = "0.00";
                            label_TOTAL.Text = "0.00";
                            //label_total_abajo.Text = "0.00";
                            label_total_abajo.Text = obj.label_total_a_pagar.Text;
                            label_pago_con.Text = obj.textBox_pago.Text;// .Text = suma2.ToString();
                            label_cambio.Text = obj.label_cambio_pago.Text;
                            MessageBox.Show("Gracias por su compra");

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

