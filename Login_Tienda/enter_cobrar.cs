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
    public partial class enter_cobrar : Form
    {
        SqlCommand cmd;
        SqlConnection con = Conexion.ObtenerConexion();
        public enter_cobrar()
        {
            InitializeComponent();
        }
        

        //Boton Cobrar
        private void button_cobrar_Click(object sender, EventArgs e)
        {
            try { 
            ventas obj_ven = new ventas();
                //L_C es la variable label_cambio parceada para tomar los valores
            double L_C;
            L_C = double.Parse(label_cambio_pago.Text);
                
            if (L_C <= 0)
            {
                MessageBox.Show("La Cantidad Especificada No Es Suficiente");
            }
            else
            {
                    /* obj_ven.listView_venta.Items.Clear();
                     obj_ven.label_subtotal.Text = "0.00";
                     obj_ven.label_iva.Text = "0.00";
                     obj_ven.label_total2.Text = "0.00";
                     obj_ven.label_TOTAL.Text = "0.00";
                     obj_ven.label_total_abajo.Text = "0.00";  
                     MessageBox.Show("Gracias por su compra");*/
                    //Cerrar formulario activo

                    /*float total = Convert.ToInt32(ve.label_TOTAL.Text);
                    ins_venta(me.label_usuario.Text,me.label_hora_actual.Text, total); */
                    this.Close();
                   
                }
          /*  enter_cobrar obj1 = new enter_cobrar();
            obj1.Visible = false;
            Visible = true;*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void enter_cobrar_Load(object sender, EventArgs e)
        {
            //EVENTO PARA PONER EL CURSOR EN EL TEXBOX
            this.ActiveControl = textBox_pago;
            textBox_pago.Focus();

        }
       
        private void textBox_pago_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (textBox_pago.TextLength<=0)
                {
                   // MessageBox.Show("Ponga Dinero");
                }
                else { 
            
                double total_a_pagar = Convert.ToDouble(label_total_a_pagar.Text), pago = Convert.ToDouble(textBox_pago.Text), cambio = 0;
                cambio = total_a_pagar - pago;
                     if (cambio>=0)
                     {
                        label_cambio_pago.Text = "0,00";
                    }
                     else if(cambio<=0)
                     {
                        double C = cambio * -1;
                        label_cambio_pago.Text = C.ToString("F2");
                        
                     }
                   // double C = cambio * -1;
                   // label_cambio_pago.Text = C.ToString();
                    
             
                    
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
        public static void sololLetras(KeyPressEventArgs pe)
        {
            if (char.IsLetter(pe.KeyChar))
            {
                pe.Handled = false;
            }
            else if (char.IsControl(pe.KeyChar))
            {
                pe.Handled = false;
            }
            else if (char.IsSeparator(pe.KeyChar))
            {
                pe.Handled = false;
            }
            else
            {
                pe.Handled = true;
            }
        }
        private void textBox_pago_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololNumeros(e);
        }
        //EVENTO PARA PONER CURSOR EN EL TEXBOX DESDE EL INICIO
        private void textBox_pago_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.End)
            {
                textBox_pago.Focus();
            }
        }
        menu me = new menu();
        ventas ve = new ventas();

        public void ins_venta(String Nombre, String fecha, float total)
        {
            if (me.label_usuario.Text.Equals(" ") == true)
            {
                MessageBox.Show("Campos Bacios");
            }
            else if (ve.label_TOTAL.Text.Equals(" ") == true)
            {
                MessageBox.Show("Campos Bacios");
            }
            else if (me.label_hora_actual.Text.Equals(" ") == true)
            {
                MessageBox.Show("Campos Bacios");
            }
            else { 
                //  cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
                con = Conexion.ObtenerConexion();
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "ins_venta";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", me.label_hora_actual.Text);
                cmd.Parameters.AddWithValue("@fecha", ve.label_TOTAL.Text);
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
    }
}
