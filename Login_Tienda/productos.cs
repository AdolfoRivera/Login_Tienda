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
    public partial class productos : Form
    {
        //pasar metodos de un form a otro
        // modificar coneccion_modificar = new modificar();

        SqlConnection cnn;
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlDataReader drr;
        public productos()
        {
            cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
            //cnn.Open();
            InitializeComponent();

        }

        public void bor_prod(String Categoria, String Codigo, String Descripcion, String Presentacion, float Costo, float Venta, int Cantidad, String Caducidad)
        {
            cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
            SqlCommand cmd = cnn.CreateCommand();

            cmd.CommandText = "bor_prd";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Categoria", comboBox_categorias.Text);
            cmd.Parameters.AddWithValue("@Codigo", textBox_codigo_de_barras.Text);
            cmd.Parameters.AddWithValue("@Descripcion", textBox_descrpcion.Text);
            cmd.Parameters.AddWithValue("@Presentacion", textBox_presentacion.Text);
            cmd.Parameters.AddWithValue("@costo", textBox_costo.Text);
            cmd.Parameters.AddWithValue("@venta", textBox_venta.Text);
            cmd.Parameters.AddWithValue("@Cantidad", textBox_cantidad.Text);
            cmd.Parameters.AddWithValue("@Caducidad", dateTimePicker_fecha.Text);

            textBox_codigo_de_barras.Clear();
            textBox_descrpcion.Clear();
            textBox_presentacion.Clear();
            textBox_costo.Clear();
            textBox_venta.Clear();
            textBox_cantidad.Clear();
            textBox_en_excistencia.Clear();
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Producto Borrado");

            }
            catch (Exception er)
            {
                // throw;
                MessageBox.Show(er.Message);
            }
        }
        public void act_prod(String Categoria, String Codigo, String Descripcion, String Presentacion, float Costo, float Venta, int Cantidad, String Caducidad)
        {
            cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
            SqlCommand cmd = cnn.CreateCommand();

            cmd.CommandText = "act_productos";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Categoria", comboBox_categorias.Text);
            cmd.Parameters.AddWithValue("@Codigo", textBox_codigo_de_barras.Text);
            cmd.Parameters.AddWithValue("@Descripcion", textBox_descrpcion.Text);
            cmd.Parameters.AddWithValue("@Presentacion", textBox_presentacion.Text);
            cmd.Parameters.AddWithValue("@costo", textBox_costo.Text);
            cmd.Parameters.AddWithValue("@venta", textBox_venta.Text);
            cmd.Parameters.AddWithValue("@Cantidad", textBox_cantidad.Text);
            cmd.Parameters.AddWithValue("@Caducidad", dateTimePicker_fecha.Text);

            textBox_codigo_de_barras.Clear();
            textBox_descrpcion.Clear();
            textBox_presentacion.Clear();
            textBox_costo.Clear();
            textBox_venta.Clear();
            textBox_cantidad.Clear();
            textBox_en_excistencia.Clear();
            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("Producto actuaizado");

            }
            catch (Exception er)
            {
                // throw;
                MessageBox.Show(er.Message);
            }
        }
            private void button_modificar_Click(object sender, EventArgs e)
        {
            /* modificar obj = new modificar();
             obj.ShowDialog();*/
            try
            {
                int costo = Convert.ToInt32(textBox_costo.Text);
                int venta = Convert.ToInt32(textBox_venta.Text);
                int cantidad = Convert.ToInt32(textBox_cantidad.Text);
                act_prod(comboBox_categorias.Text, textBox_codigo_de_barras.Text, textBox_descrpcion.Text, textBox_presentacion.Text, costo, venta, cantidad, dateTimePicker_fecha.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Campos Bacios");
            }
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            /*eliminar obj = new eliminar();
            obj.ShowDialog();*/
            try
            {
                int costo = Convert.ToInt32(textBox_costo.Text);
                int venta = Convert.ToInt32(textBox_venta.Text);
                int cantidad = Convert.ToInt32(textBox_cantidad.Text);
                bor_prod(comboBox_categorias.Text, textBox_codigo_de_barras.Text, textBox_descrpcion.Text, textBox_presentacion.Text, costo, venta, cantidad, dateTimePicker_fecha.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Campos bacios");
            }
        }

        private void productos_Load(object sender, EventArgs e)
        {

        }
        public void ins_productos(String Categoria,String Codigo, String Descripcion, String Presentacion, float Costo, float Venta, int Cantidad, String Caducidad)//, String Excistencia)
        {
            if (comboBox_categorias.Text.Equals("") == true)
            {
                MessageBox.Show("Campos Bacios");
            }
            else if (textBox_codigo_de_barras.Text.Equals("") == true)
            {
                MessageBox.Show("Campos Bacios");
            }
            else if (textBox_descrpcion.Text.Equals("") == true)
            {
                MessageBox.Show("Campos Bacios");
            }
            else if (textBox_presentacion.Text.Equals("") == true)
            {
                MessageBox.Show("Campos Bacios");
            }
            else if (textBox_costo.Text.Equals("") == true)
            {
                MessageBox.Show("Campos Bacios");
            }
            else if (textBox_venta.Text.Equals("") == true)
            {
                MessageBox.Show("Campos Bacios");
            }
            else if (textBox_cantidad.Text.Equals("") == true)
            {
                MessageBox.Show("Campos Bacios");
            }
            else if (dateTimePicker_fecha.Text.Equals("") == true)
            {
                MessageBox.Show("Campos Bacios");
            }
           else /*if (textBox_en_excistencia.Text.Equals("") == true)
            {
                MessageBox.Show("Campos Bacios");
            }
            else*/
            {
                cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
                SqlCommand cmd = cnn.CreateCommand();

                cmd.CommandText = "ins_productos";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Categoria", comboBox_categorias.Text);
                cmd.Parameters.AddWithValue("@Codigo", textBox_codigo_de_barras.Text);
                cmd.Parameters.AddWithValue("@Descripcion", textBox_descrpcion.Text);
                cmd.Parameters.AddWithValue("@Presentacion", textBox_presentacion.Text);
                cmd.Parameters.AddWithValue("@costo", textBox_costo.Text);
                cmd.Parameters.AddWithValue("@venta", textBox_venta.Text);
                cmd.Parameters.AddWithValue("@Cantidad", textBox_cantidad.Text);
                cmd.Parameters.AddWithValue("@Caducidad", dateTimePicker_fecha.Text);
               // cmd.Parameters.AddWithValue("@Excistencia", textBox_en_excistencia.Text);


                textBox_codigo_de_barras.Clear();
                textBox_descrpcion.Clear();
                textBox_presentacion.Clear();
                textBox_costo.Clear();
                textBox_venta.Clear();
                textBox_cantidad.Clear();
                textBox_en_excistencia.Clear();


                try
                {
                    
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("Produto agregado correctamente");

                }
                catch (Exception er)
                {
                    // throw;
                    MessageBox.Show(er.Message);
                }

            }
        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                string cadsql = "select * from Productos where Codigo ='" + textBox_codigo_de_barras.Text + "'";
                SqlCommand comando = new SqlCommand(cadsql, cnn);
                cnn.Open();
                SqlDataReader leer1 = comando.ExecuteReader();

                if (leer1.Read() == true)
                {
                    MessageBox.Show("El Registro ya exciste");
                }
                else
                {

                    
                    int costo = Convert.ToInt32(textBox_costo.Text);
                    int venta = Convert.ToInt32(textBox_venta.Text);
                    int cantidad = Convert.ToInt32(textBox_cantidad.Text);
                    ins_productos(comboBox_categorias.Text, textBox_codigo_de_barras.Text, textBox_descrpcion.Text, textBox_presentacion.Text, costo, venta, cantidad, dateTimePicker_fecha.Text);//, textBox_en_excistencia.Text);
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            /*try
        {
            if (comboBox_categorias.SelectedIndex == 0)
            {
                int costo = Convert.ToInt32(textBox_costo.Text);
                int venta = Convert.ToInt32(textBox_venta.Text);
                ins_Abarrotes(textBox_codigo_de_barras.Text, textBox_descrpcion.Text, textBox_presentacion.Text, costo, venta, textBox_cantidad.Text, dateTimePicker_fecha.Text, textBox_en_excistencia.Text);
            }*/
        }
        
        private void textBox_codigo_de_barras_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string cadsql = "select * from Productos where Codigo ='" + textBox_codigo_de_barras.Text + "'";
                SqlCommand comando = new SqlCommand(cadsql, cnn);
                cnn.Open();
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    comboBox_categorias.Text = leer["Categoria"].ToString();
                    textBox_codigo_de_barras.Text = leer["Codigo"].ToString();
                    textBox_descrpcion.Text = leer["Descripcion"].ToString();
                    textBox_costo.Text = leer["costo"].ToString();
                    textBox_venta.Text = leer["venta"].ToString();
                    textBox_cantidad.Text = leer["Cantidad"].ToString();
                    textBox_presentacion.Text = leer["Presentacion"].ToString();
                    //lab_existencia.Text = textBox_cantidad.Text;
                    textBox_en_excistencia.Text = textBox_cantidad.Text;
                }
                else if (textBox_codigo_de_barras.Text.Equals("") == true)
                {
                    //-->Es lo mismo que 
                    //-->textBox_codigo_de_barras.clear();
                    comboBox_categorias.Text = "";
                    textBox_codigo_de_barras.Text = "";
                    textBox_descrpcion.Text = "";
                    textBox_costo.Text = "";
                    textBox_venta.Text = "";
                    textBox_cantidad.Text = "";
                    textBox_en_excistencia.Text = "";
                    textBox_presentacion.Text = "";
                    textBox_presentacion.Text = string.Empty;
                }
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //preuba de auto llenado jalo al 100
        private void button_imporatr_base_de_datos_Click(object sender, EventArgs e)
        {
            try
            {
                cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
                cnn.Open();
                DataTable datos = new DataTable();
                SqlDataAdapter sqldatos = new SqlDataAdapter("select * from Productos", cnn);
                sqldatos.Fill(datos);
                datos_data.DataSource = datos;
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_en_excistencia_TextChanged(object sender, EventArgs e)
        {
           // textBox_en_excistencia.Text = "select Cantidad from Productos";
        }

        private void textBox_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            cnn.Open();
            cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Productos where Codigo ='" + textBox_buscar.Text+ "'";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            datos_data.DataSource = dt;
            cnn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
         

        }

        private void textBox_buscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}