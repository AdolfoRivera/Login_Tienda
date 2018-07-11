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

       // SqlConnection cnn;
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlDataReader drr;
        SqlConnection con = Conexion.ObtenerConexion();
        public productos()
        {
           // cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
            //cnn.Open();
            InitializeComponent();

        }

        public void bor_prod(String Categoria, String Codigo, String Descripcion, String Presentacion, float Costo, float Venta, int Cantidad, String Caducidad, string fecha)
        {
            // cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
                           //cnn
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "bor_prd";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Categoria", comboBox_categorias.Text);
            cmd.Parameters.AddWithValue("@Codigo", textBox_codigo_de_barras.Text);
            cmd.Parameters.AddWithValue("@Descripcion", textBox_descrpcion.Text);
            cmd.Parameters.AddWithValue("@Presentacion", textBox_presentacion.Text);
            cmd.Parameters.AddWithValue("@costo", textBox_costo.Text);
            cmd.Parameters.AddWithValue("@venta", textBox_venta.Text);
            cmd.Parameters.AddWithValue("@Cantidad", textBox_cantidad.Text);
            cmd.Parameters.AddWithValue("@Caducidad", dateTimePicker1_caducidad.Text);
            cmd.Parameters.AddWithValue("@fecha", dateTimePicker_fecha.Text);

            textBox_codigo_de_barras.Clear();
            textBox_descrpcion.Clear();
            textBox_presentacion.Clear();
            textBox_costo.Clear();
            textBox_venta.Clear();
            textBox_cantidad.Clear();
            textBox_en_excistencia.Clear();
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Producto Borrado");

            }
            catch (Exception er)
            {
                // throw;
                MessageBox.Show(er.Message);
            }
        }
        public void act_prod(String Categoria, String Codigo, String Descripcion, String Presentacion, float Costo, float Venta, int Cantidad, String Caducidad, string fecha)
        {
            //cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
                           //cnn
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "act_productos";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Categoria", comboBox_categorias.Text);
            cmd.Parameters.AddWithValue("@Codigo", textBox_codigo_de_barras.Text);
            cmd.Parameters.AddWithValue("@Descripcion", textBox_descrpcion.Text);
            cmd.Parameters.AddWithValue("@Presentacion", textBox_presentacion.Text);
            cmd.Parameters.AddWithValue("@costo", textBox_costo.Text);
            cmd.Parameters.AddWithValue("@venta", textBox_venta.Text);
            cmd.Parameters.AddWithValue("@Cantidad", textBox_cantidad.Text);
            cmd.Parameters.AddWithValue("@Caducidad", dateTimePicker1_caducidad.Text);
            cmd.Parameters.AddWithValue("@fecha", dateTimePicker_fecha.Text);
            textBox_codigo_de_barras.Clear();
            textBox_descrpcion.Clear();
            textBox_presentacion.Clear();
            textBox_costo.Clear();
            textBox_venta.Clear();
            textBox_cantidad.Clear();
            textBox_en_excistencia.Clear();
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
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
                act_prod(comboBox_categorias.Text, textBox_codigo_de_barras.Text, textBox_descrpcion.Text, textBox_presentacion.Text, costo, venta, cantidad, dateTimePicker1_caducidad.Text,dateTimePicker_fecha.Text);

                this.ActiveControl = textBox_codigo_de_barras;
                textBox_codigo_de_barras.Focus();
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
                bor_prod(comboBox_categorias.Text, textBox_codigo_de_barras.Text, textBox_descrpcion.Text, textBox_presentacion.Text, costo, venta, cantidad, dateTimePicker1_caducidad.Text,dateTimePicker_fecha.Text);

                this.ActiveControl = textBox_codigo_de_barras;
                textBox_codigo_de_barras.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Campos bacios");
            }
        }

        private void productos_Load(object sender, EventArgs e)
        {
            //EVENTO PARA BLOQUEAR COMBOBOX
            comboBox_categorias.DropDownStyle = ComboBoxStyle.DropDownList;

            //evento para desabilitar el boton desde el inicio
            button_aceptar.Enabled = false;

            //evento para poner el cursor desde el inicio en el texbox codigo de varras
           this.ActiveControl = textBox_codigo_de_barras;
           textBox_codigo_de_barras.Focus();
        }
        public void ins_productos(String Categoria,String Codigo, String Descripcion, String Presentacion, float Costo, float Venta, int Cantidad, String Caducidad, string fecha)//, String Excistencia)
        {
          //  if (comboBox_categorias.Text.Equals("") == true)
                if (comboBox_categorias.Text.Equals("") == true) { 
            
                MessageBox.Show("Seleccione la Categoria");
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
           else if (dateTimePicker1_caducidad.Text.Equals("") == true)
            {
                MessageBox.Show("Campos Bacios");
            }
            else
            {
                //cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
                //cnn
                con = Conexion.ObtenerConexion();
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "ins_productos";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Categoria", comboBox_categorias.Text);
                cmd.Parameters.AddWithValue("@Codigo", textBox_codigo_de_barras.Text);
                cmd.Parameters.AddWithValue("@Descripcion", textBox_descrpcion.Text);
                cmd.Parameters.AddWithValue("@Presentacion", textBox_presentacion.Text);
                cmd.Parameters.AddWithValue("@costo", textBox_costo.Text);
                cmd.Parameters.AddWithValue("@venta", textBox_venta.Text);
                cmd.Parameters.AddWithValue("@Cantidad", textBox_cantidad.Text);
                cmd.Parameters.AddWithValue("@Caducidad", dateTimePicker1_caducidad.Text);
                cmd.Parameters.AddWithValue("@fecha",dateTimePicker_fecha.Text);
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
                    
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
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
                //poner foco en texbox codigo
                this.ActiveControl = textBox_codigo_de_barras;
                textBox_codigo_de_barras.Focus();

                string cadsql = "select * from Productos where Codigo ='" + textBox_codigo_de_barras.Text + "'";
                SqlCommand comando = new SqlCommand(cadsql, con);
                con.Open();
                SqlDataReader leer1 = comando.ExecuteReader();

                if (leer1.Read() == true)
                {
                    MessageBox.Show("El Registro ya exciste");
                }
                else if (comboBox_categorias.Text.Trim() == "" || textBox_codigo_de_barras.Text.Trim() == "" || textBox_descrpcion.Text.Trim() == "" || textBox_costo.Text.Trim() == "" || textBox_venta.Text.Trim() == "" || textBox_cantidad.Text.Trim() == "" || textBox_presentacion.Text.Trim() == "")
                {

                    MessageBox.Show("No Se Permiten Productos en Blanco", "LLenar Registro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else { 

                    int costo = Convert.ToInt32(textBox_costo.Text);
                    int venta = Convert.ToInt32(textBox_venta.Text);
                    int cantidad = Convert.ToInt32(textBox_cantidad.Text);
                    ins_productos(comboBox_categorias.Text, textBox_codigo_de_barras.Text, textBox_descrpcion.Text, textBox_presentacion.Text, costo, venta, cantidad, dateTimePicker1_caducidad.Text,dateTimePicker_fecha.Text);//, textBox_en_excistencia.Text);
                }
                con.Close();
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
                // string cadsql2 = "select * from Productos where  Codigo like '%" + textBox_codigo_de_barras.Text + "%'";

                //string cadsql = "select * from Productos where  Codigo = '" + textBox_codigo_de_barras.Text + "'";
                string cadsql = "select * from Productos where  Codigo LIKE ('" + textBox_codigo_de_barras.Text + "')";

                SqlCommand comando = new SqlCommand(cadsql, con);
                con.Open();
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
                    dateTimePicker_fecha.Text = leer["fecha"].ToString();
                    dateTimePicker1_caducidad.Text = leer["Caducidad"].ToString();
                    //lab_existencia.Text = textBox_cantidad.Text;
                    textBox_en_excistencia.Text = textBox_cantidad.Text;


                }else if (leer.Read() == false)
                {
                    comboBox_categorias.Text = "";
                   // textBox_codigo_de_barras.Text = "";
                    textBox_descrpcion.Text = "";
                    textBox_costo.Text = "";
                    textBox_venta.Text = "";
                    textBox_cantidad.Text = "";
                    textBox_en_excistencia.Text = "";
                    textBox_presentacion.Text = "";
                    dateTimePicker_fecha.Text = "";
                    textBox_presentacion.Text = string.Empty;
                }
                else if (textBox_codigo_de_barras.Text.Equals("") == true) { 


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
                    dateTimePicker_fecha.Text = "";
                    textBox_presentacion.Text = string.Empty;

                    


                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //preuba de auto llenado jalo al 100
        //btn mostrar
        private void button_imporatr_base_de_datos_Click(object sender, EventArgs e)
        {
            try
            {
                //EVENTO PONER FOCO EN TEXBOX CODIGO DESPUES DE DARLE CLIC A ACTUALIZAR
                this.ActiveControl = textBox_codigo_de_barras;
                textBox_codigo_de_barras.Focus();

                //cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
                con.Open();
                DataTable datos = new DataTable();
                SqlDataAdapter sqldatos = new SqlDataAdapter("select * from Productos", con);
                sqldatos.Fill(datos);
                datos_data.DataSource = datos;
                //--COLOR
                datos_data.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
                datos_data.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

                con.Close();
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
            try
            {

                if (textBox_buscar.Text == "'")
                {
                    MessageBox.Show("NO (')");
                    textBox_buscar.Clear();

                }
                else
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from Productos where Codigo like '%" + textBox_buscar.Text + "%'or Descripcion like '%" + textBox_buscar.Text + "%'";
                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    datos_data.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
         

        }

        private void textBox_buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_categorias.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void textBox_codigo_de_barras_Validated(object sender, EventArgs e)
        {

           /* if (textBox_codigo_de_barras.Text.Trim() == "")
            {
                ep1.SetError(textBox_codigo_de_barras, "Codigo");
                textBox_codigo_de_barras.Focus();
            }
            else
            {
                ep1.Clear();
            }*/
        }

        private void textBox_descrpcion_Validated(object sender, EventArgs e)
        {

           if (textBox_descrpcion.Text.Trim() == "")
            {
                ep1.SetError(textBox_descrpcion, "Descripcion");
                textBox_descrpcion.Focus();
            }
            else
            {
                ep1.Clear();
            }
        }

        private void textBox_costo_Validated(object sender, EventArgs e)
        {

            if (textBox_costo.Text.Trim() == "")
            {
                ep1.SetError(textBox_costo, "Costo");
                textBox_costo.Focus();
            }
            else
            {
                ep1.Clear();
            }
        }

        private void textBox_venta_Validated(object sender, EventArgs e)
        {

            if (textBox_venta.Text.Trim() == "")
            {
                ep1.SetError(textBox_venta, "Venta");
                textBox_venta.Focus();
            }
            else
            {
                ep1.Clear();
            }
        }

        private void textBox_cantidad_Validated(object sender, EventArgs e)
        {

            if (textBox_cantidad.Text.Trim() == "")
            {
                ep1.SetError(textBox_cantidad, "Cantidad");
                textBox_cantidad.Focus();
            }
            else
            {
                ep1.Clear();
            }
        }

        private void textBox_presentacion_Validated(object sender, EventArgs e)
        {

           if (textBox_presentacion.Text.Trim() == "")
            {
                ep1.SetError(textBox_presentacion, "Presentacion");
                textBox_presentacion.Focus();
            }
            else
            {
                ep1.Clear();
            }
        }

        private void textBox_costo_TextChanged(object sender, EventArgs e)
        {
            if ((textBox_costo.Text != "") && (textBox_venta.Text != "")&&(textBox_cantidad.Text != "") && (textBox_presentacion.Text != "")) button_aceptar.Enabled = true;
            else button_aceptar.Enabled = false;
        }

        private void textBox_venta_TextChanged(object sender, EventArgs e)
        {
            if ((textBox_costo.Text != "") && (textBox_venta.Text != "") && (textBox_cantidad.Text != "") && (textBox_presentacion.Text != "")) button_aceptar.Enabled = true;
            else button_aceptar.Enabled = false;
        }

        private void textBox_cantidad_TextChanged(object sender, EventArgs e)
        {
           if ((textBox_costo.Text != "") && (textBox_venta.Text != "") && (textBox_cantidad.Text != "") && (textBox_presentacion.Text != "")) button_aceptar.Enabled = true;
            else button_aceptar.Enabled = false;
        }

        private void button_aceptar_KeyUp(object sender, KeyEventArgs e)
        {
           /* if ((textBox_costo.Text != "") && (textBox_venta.Text != "") && (textBox_cantidad.Text != "")) button_aceptar.Enabled =true;
            else button_aceptar.Enabled = false;*/
        }

        private void textBox_presentacion_TextChanged(object sender, EventArgs e)
        {
            if ((textBox_costo.Text != "") && (textBox_venta.Text != "") && (textBox_cantidad.Text != "")&&(textBox_presentacion.Text != "")) button_aceptar.Enabled = true;
            else button_aceptar.Enabled = false;
        }
        //----------------------------------------------------------------------
        //Metodos para solo aceptar numeros y letras----------------------------
        //_---------------------------------------------------------------------
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

        private void textBox_codigo_de_barras_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_codigo_de_barras_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololNumeros(e);
        }

        private void textBox_descrpcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololLetras(e);
        }

        private void textBox_costo_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololNumeros(e);
        }

        private void textBox_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololNumeros(e);
        }

        private void textBox_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololNumeros(e);
        }

        private void textBox_en_excistencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*sololNumeros(e);
            sololLetras(e);*/
        }
        //EVENTO PARA PONER CURSOR DESDE EL INICIO EN EL TEXBOX
        private void textBox_codigo_de_barras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox_codigo_de_barras.Focus();
            }
        }

        private void textBox_descrpcion_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Enter)
            {
                textBox_descrpcion.Focus();
            }*/
        }

        private void textBox_costo_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Enter)
            {
                textBox_costo.Focus();
            }*/
        }

        private void textBox_venta_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Enter)
            {
                textBox_venta.Focus();
            }*/
        }

        private void textBox_cantidad_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Enter)
            {
                textBox_cantidad.Focus();
            }*/
        }

        private void textBox_presentacion_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Enter)
            {
                textBox_presentacion.Focus();
            }*/
        }

        private void dateTimePicker_fecha_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Enter)
            {
                dateTimePicker_fecha.Focus();
            }*/
        }

        private void dateTimePicker1_caducidad_KeyDown(object sender, KeyEventArgs e)
        {
            /*if (e.KeyCode == Keys.Enter)
            {
                dateTimePicker1_caducidad.Focus();
            }*/
        }

        private void textBox_presentacion_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (textBox_presentacion.Text == "'")
                {
                    MessageBox.Show("NO (')");
                    textBox_presentacion.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void datos_data_CellClick(object sender, DataGridViewCellEventArgs e)
        {/*
            try
            {
                //comboBox_categorias.Text = (string)datos_data.Rows[e.RowIndex].Cells[0].Value;
                textBox_codigo_de_barras.Text = (string)datos_data.Rows[e.RowIndex].Cells[2].Value;
               // textBox_descrpcion.Text = (string)datos_data.Rows[e.RowIndex].Cells[3].Value;
               // textBox_costo.Text = (string)datos_data.Rows[e.RowIndex].Cells[3].Value;
                //textBox_venta.Text = (string)datos_data.Rows[e.RowIndex].Cells[4].Value;
               // textBox_cantidad.Text = (string)datos_data.Rows[e.RowIndex].Cells[5].Value;
               // textBox_presentacion.Text = (string)datos_data.Rows[e.RowIndex].Cells[6].Value;
                //dateTimePicker1_caducidad.Text = (string)datos_data.Rows[e.RowIndex].Cells[7].Value;
                //dateTimePicker_fecha.Text = (string)datos_data.Rows[e.RowIndex].Cells[8].Value;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
    }
}