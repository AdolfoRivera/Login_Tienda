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
    public partial class prueba_de_venta : Form
    {
        SqlConnection cnn;
        public prueba_de_venta()
        {
            InitializeComponent();
            SqlConnection cnn;
        }

        private void eliminar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tiendaDataSet1.ventas_pruebas' Puede moverla o quitarla según sea necesario.
            this.ventas_pruebasTableAdapter.Fill(this.tiendaDataSet1.ventas_pruebas);
            eliminar_registros();
        }
        public void Limpiarcontroles()
        {
            foreach (Control caja in this.Controls)
            {
                txtcodigo.Text = "";
                txtdescripcion.Text = "";
                txtcantidad.Text = "";
                txtimporte.Text = "";
                txtprecio.Text = "";

            }
        }
            private void BTN_AGREGAR_Click(object sender, EventArgs e)
        {


            if (txtcantidad.Text == "")
            {
                MessageBox.Show("falta cantidad");
                txtcantidad.Focus();


            }
            else
            {
                txtc.Text = txtcantidad.Text;
                ///////////////////////////////////////////////////////////////////////////////////
                int a;
                int b;
                int c = 0;
                a = int.Parse(txtexistencia.Text);
                b = int.Parse(txtc.Text);
                c = a - b;
                txtexistencia.Text = c.ToString();



                SqlConnection cnx2 = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
                SqlCommand cmd2 = new SqlCommand("suaryrestaeproductos", cnx2);
                cmd2.CommandType = System.Data.CommandType.StoredProcedure;
                cmd2.Parameters.Add(new SqlParameter("@Bandera", 2));
                cmd2.Parameters.Add(new SqlParameter("@Descripcion", ""));
              //  cmd2.Parameters.Add(new SqlParameter("@Costo", ""));
                cmd2.Parameters.Add(new SqlParameter("@venta", ""));
              //  cmd2.Parameters.Add(new SqlParameter("@Precio_Mayoreo", ""));
              //  cmd2.Parameters.Add(new SqlParameter("@Marca", ""));
                cmd2.Parameters.Add(new SqlParameter("@Cantidad", ""));
              //  cmd2.Parameters.Add(new SqlParameter("@Existencia", txtexistencia.Text));
                cmd2.Parameters.Add(new SqlParameter("@Codigo", txtcodigo.Text));
                cnx2.Open();
                cmd2.ExecuteNonQuery();
                cnx2.Close();




                ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                a = int.Parse(txtimporte.Text);

                b = a + b;
                txtsubtotal.Text = b.ToString();
                /*----------------------------aqui termina la operacion subtotal----------------*/



                /*----------------------------aqui empíeza la operacion total con iva----------------*/




                double subtotal = double.Parse(txtsubtotal.Text);
                double iva;
                iva = (subtotal * 16 / 100);
                txtiva.Text = iva.ToString();


                //TOTAL YA CON IVA
                double suma;
                double numtxtsubtotal = double.Parse(txtsubtotal.Text);
                double numtxtiva = double.Parse(txtiva.Text);
                suma = (numtxtsubtotal + numtxtiva);
                txttotal.Text = suma.ToString();

                /*----------------------------aqui termina la operacion total con iva----------------*/
             /*   SqlConnection cnx = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("VentaActual", cnx);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Bandera", 1));
                cmd.Parameters.Add(new SqlParameter("@Codigo", txtcodigo.Text));
                cmd.Parameters.Add(new SqlParameter("@Cantidad", txtcantidad.Text));
                cmd.Parameters.Add(new SqlParameter("@Descripcion", txtdescripcion.Text));
                cmd.Parameters.Add(new SqlParameter("@Precio", txtprecio.Text));
                cmd.Parameters.Add(new SqlParameter("@Importe", txtimporte.Text));
                cmd.Parameters.Add(new SqlParameter("@Subtotal", txtsubtotal.Text));
                cmd.Parameters.Add(new SqlParameter("@Iva", txtiva.Text));
                cmd.Parameters.Add(new SqlParameter("@Total", txttotal.Text));

                cnx.Open();
                cmd.ExecuteNonQuery();
                cargardatos();
                cnx.Close();


                Limpiarcontroles();
                */

                /*=================================================================================*/


                /*==================================================================================*/
            }
        }
        private void cargardatos()
        {
            //this.venta_TableAdapter.Fill(this.dataSet1.Venta);
            this.ventas_pruebasTableAdapter.Fill(this.tiendaDataSet1.ventas_pruebas);
        }
        private void importe()
        {
            if (txtcantidad.Text == "" || txtprecio.Text == "")
            {

            }
            else
            {
                // TODO: esta línea de código carga datos en la tabla 'pV3TICSIEDataSet5.Venta' Puede moverla o quitarla según sea necesario.
//                this.ventaTableAdapter.Fill(this.tiendaDataSet1.Venta);
                // TODO: esta línea de código carga datos en la tabla 'pV3TICSIEDataSet4.Venta' Puede moverla o quitarla según sea necesario.
                /*--------------------------------------BOTON AGREGAR PASAS LOS DATOS  CON EL PRECIO Y HACE LA OPERACION-------------------------*/


                double NUM1 = double.Parse(txtcantidad.Text);
                double NUM2 = double.Parse(txtprecio.Text);

                double mult;
                mult = NUM1 * NUM2;
                txtimporte.Text = mult.ToString();


            }

        }
        private void BTN_PAGAR_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*  FrmInventarios x = new FrmInventarios();

                x.StartPosition = FormStartPosition.CenterScreen;
                x.Show();*/
            productos obj = new productos();
            obj.StartPosition = FormStartPosition.CenterScreen;
            obj.Show();
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            importe();
        }
        private void eliminar_registros()
        {
           /* SqlConnection cnx = new SqlConnection("Data Source=DEVELOPER;Initial Catalog=PV3TICSIE;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("VentaActual", cnx);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@Bandera", 2));
            cmd.Parameters.Add(new SqlParameter("@Codigo", ""));
            cmd.Parameters.Add(new SqlParameter("@Cantidad", ""));
            cmd.Parameters.Add(new SqlParameter("@Descripcion", ""));
            cmd.Parameters.Add(new SqlParameter("@Precio", ""));
            cmd.Parameters.Add(new SqlParameter("@Importe", ""));
            cmd.Parameters.Add(new SqlParameter("@Subtotal", ""));
            cmd.Parameters.Add(new SqlParameter("@Iva", ""));
            cmd.Parameters.Add(new SqlParameter("@Total", ""));

            cnx.Open();
            cmd.ExecuteNonQuery();
            cnx.Close();*/
        }
        private void limpiar_grupbox()
        {
            txtsubtotal.Text = "";
            txtiva.Text = "";
            txttotal.Text = "";

        }

        private void CANCELAR_VENTA_Click(object sender, EventArgs e)
        {
            eliminar_registros();
         //   limpiar_grupbox();
            cargardatos();
            Limpiarcontroles();
        }

        private void txtcodigo_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                string cadsql = "select * from Productos where Codigo ='" + txtcodigo.Text + "'";
                SqlCommand comando = new SqlCommand(cadsql, cnn);
                cnn.Open();
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {

                    txtcodigo.Text = leer["Codigo"].ToString();
                    txtcantidad.Text = leer["Cantidad"].ToString();
                    txtdescripcion.Text = leer["Descripcion"].ToString();
                    txtprecio.Text = leer["venta"].ToString();
                    txtimporte.Text = leer["importe"].ToString();
                    txtc.Text = leer["Cantidad"].ToString();
                    txtcantidad.Text = leer["Cantidad_que_hay"].ToString();
                    //lab_existencia.Text = textBox_cantidad.Text;
                   // textBox_en_excistencia.Text = textBox_cantidad.Text;
                }
                else if (txtcodigo.Text.Equals("") == true)
                {
                    //-->Es lo mismo que 
                    //-->textBox_codigo_de_barras.clear();
               /*     textBox_codigo_de_barras.Text = "";
                    textBox_descrpcion.Text = "";
                    textBox_costo.Text = "";
                    textBox_venta.Text = "";
                    textBox_cantidad.Text = "";
                    textBox_en_excistencia.Text = "";
                    textBox_presentacion.Text = "";
                    textBox_presentacion.Text = string.Empty;*/
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
