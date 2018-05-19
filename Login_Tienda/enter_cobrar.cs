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
        ventas ve = new ventas();
        menu me1 = new menu();
        public enter_cobrar()
        {
            InitializeComponent();
        }
        

        //Boton Cobrar
        private void button_cobrar_Click(object sender, EventArgs e)
        {
            
            try { 
           
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

                  /*  float total2 = float.Parse(textBox_total_cobrar.Text );
                   float total = Convert.ToInt32(textBox_total_cobrar.Text); */   
                   ins_venta(textBox_nombre_cobrear.Text,textBox_fecha_cobrar.Text,textBox_total_cobrar.Text);
                        
                    
                    //ins_venta(me1.textBox_USUARIO.Text, textBox_fecha_cobrar .Text, total);
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
            textBox_nombre_cobrear.Text = Form1.nombre;

            //------

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
                  
                    Double total_a_pagar = Convert.ToDouble(label_total_a_pagar.Text), pago = Convert.ToDouble(textBox_pago.Text), cambio = 0;
                         cambio = total_a_pagar - pago;
                     if (cambio>=0)
                     {
                        label_cambio_pago.Text = "0.00";
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
      
       

        public void ins_venta(String Nombre, String fecha, String total)
        {
        

            if (textBox_nombre_cobrear.Text.Equals(" ") == true)
            {
                MessageBox.Show("Campos vacios");
            }
            else if (textBox_fecha_cobrar.Text.Equals(" ") == true)
            {
                MessageBox.Show("Campos vacios");
            }
            else if (textBox_total_cobrar.Text.Equals(" ") == true)
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

                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@fecha", fecha);
                cmd.Parameters.AddWithValue("@total", total);
                /*
                cmd.Parameters.AddWithValue("@Nombre", textBox_nombre_cobrear.Text);
                cmd.Parameters.AddWithValue("@fecha", textBox_fecha_cobrar.Text);
                cmd.Parameters.AddWithValue("@total", textBox_total_cobrar.Text);
                */
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
           
                enter_cobrar.ActiveForm.Close();
            
            
        }

        private void label_total_a_pagar_Click(object sender, EventArgs e)
        {

        }
    }
}
