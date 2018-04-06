using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Tienda
{
    public partial class enter_cobrar : Form
    {
        public enter_cobrar()
        {
            InitializeComponent();
        }


        //Boton Cobrar
        private void button_cobrar_Click(object sender, EventArgs e)
        {
            try { 
            ventas obj = new ventas();
                //L_C es la variable label_cambio parceada para tomar los valores
            double L_C;
            L_C = double.Parse(label_cambio.Text);
            if (L_C >= 0)
            {
                MessageBox.Show("La Cantidad Especificada No Es Suficiente");
            }
            else
            {

                obj.listView_venta.Items.Clear();
                obj.label_subtotal.Text = "0.00";
                obj.label_iva.Text = "0.00";
                obj.label_total2.Text = "0.00";
                obj.label_TOTAL.Text = "0.00";
                obj.label_total_abajo.Text = "0.00";
                MessageBox.Show("Gracias por su compra");
                    //Cerrar formulario activo
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
               // label_cambio.Text =" " +cambio;//.ToString();
                    label_cambio.Text = cambio.ToString();
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
    }
}
