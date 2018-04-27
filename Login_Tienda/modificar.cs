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
using System.Data.OleDb;

namespace Login_Tienda
{
    public partial class modificar : Form
    {
        //conexon con otro form
        productos co = new productos();

        SqlConnection cnn;
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
          public modificar()
        {
            InitializeComponent();
            cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");


        }
        //public class productos
        // {
        /* public String textBox_codigo_de_barras { get; set; }
         public string textBox_descrpcion { get; set; }
         public float textBox_costo { get; set; }
         public float textBox_venta { get; set; }
         public string textBox_cantidad { get; set; }
         public string textBox_presentacion { get; set; }*/

        public object textBox_codigo_de_barras { get; private set; }
        public object textBox_descrpcion { get; private set; }
        public object textBox_costo { get; private set; }
        public object textBox_venta { get; private set; }
        public object textBox_cantidad { get; private set; }
        public object textBox_presentacion { get; private set; }
        //}


        private void button_aceptar_modificacion_Click(object sender, EventArgs e)
        {
/*
            if (textBox_codigo_de_barras_modificar.Text != "")
            {
                
                cmd = new SqlCommand("select Codigo,Descripcion,Presentacion,costo,venta,Cantidad,Caducidad,Excistencia from Abarrote where Codigo ='" + textBox_codigo_de_barras_modificar.Text + "'", cnn);
                cnn.Open();
                try
                {

                    dr = cmd.ExecuteReader();

                    if (dr.Read() == true)
                    {
                        MessageBox.Show("El Registro Se Ha Encontrado");
                        
                        DataTable dt;
                        Int64 var = Int64.Parse(textBox_codigo_de_barras_modificar.Text.ToString());
                        dt = co.tabla_abarrote(var);
                        if (dt.Rows.Count > 0)
                        {
                            textBox_codigo_de_barras = dt.Rows[0][0].ToString();
                            textBox_descrpcion = dt.Rows[0][1].ToString();
                            textBox_costo = dt.Rows[0][2].ToString();
                            textBox_venta = dt.Rows[0][3].ToString();
                            textBox_cantidad = dt.Rows[0][4].ToString();
                            textBox_presentacion = dt.Rows[0][5].ToString();
                        }*/
                        /* textBox_codigo_de_barras = dr["Codigo"].ToString();
                         textBox_descrpcion = dr["Descripcion"].ToString();
                         textBox_costo = dr["costo"].ToString();
                         textBox_venta = dr["venta"].ToString();
                         textBox_cantidad = dr["Cantidad"].ToString();
                         textBox_presentacion = dr["Presentacion"].ToString();
                         */
                  /*  }
                    else
                    {
                        MessageBox.Show("Invalido");
                        textBox_codigo_de_barras = "";
                        textBox_descrpcion = "";
                        textBox_costo = "";
                        textBox_venta = "";
                        textBox_cantidad = "";
                        textBox_presentacion = "";
                        textBox_presentacion = string.Empty;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cnn.Close();
                }
            }
            else
            {
                MessageBox.Show("El Campo Esta Bacio");
            }*/
        }


        private void textBox_codigo_de_barras_modificar_KeyUp(object sender, KeyEventArgs e)
        {
            /*
                if (textBox_codigo_de_barras_modificar.Text != "")
                {
                    cmd = new SqlCommand("select Codigo,Descripcion,Presentacion,costo,venta,Cantidad,Caducidad,Excistencia from Abarrote where Codigo ='" + textBox_codigo_de_barras_modificar.Text + "'", cnn);

                    cnn.Open();


                    try
                    {

                        dr = cmd.ExecuteReader();


                        if (dr.Read() == true)
                        {
                            MessageBox.Show("El Registro Se Ha Encontrado");
                            DataTable dt;
                            Int64 var = Int64.Parse(textBox_codigo_de_barras_modificar.Text.ToString());
                            dt = co.tabla_abarrote(var);
                            if (dt.Rows.Count > 0)
                            {
                                textBox_codigo_de_barras = dt.Rows[0][0].ToString();
                                textBox_descrpcion = dt.Rows[0][1].ToString();
                                textBox_costo = dt.Rows[0][2].ToString();
                                textBox_venta = dt.Rows[0][3].ToString();
                                textBox_cantidad = dt.Rows[0][4].ToString();
                                textBox_presentacion = dt.Rows[0][5].ToString();
                            }

                        }
                        else
                        {
                            MessageBox.Show("Invalido");
                            textBox_codigo_de_barras = "";
                            textBox_descrpcion = "";
                            textBox_costo = "";
                            textBox_venta = "";
                            textBox_cantidad = "";
                            textBox_presentacion = "";
                            textBox_presentacion = string.Empty;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        cnn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("El Campo Esta Bacio");
                }
            }

        */
        }
    }

}