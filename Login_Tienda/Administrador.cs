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
    public partial class Administrador : Form
    {
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlDataReader drr;
        SqlConnection con = Conexion.ObtenerConexion();
        public Administrador()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Fecha_de_reporte obj = new Fecha_de_reporte();
            obj.ShowDialog();
        }
        //INSERTAR USUARIOS
        public void ins_Usuario(String Nombre, String Apellido, String Telefono, String Contraseña)
        {
            if (textBox_nombre.Text.Equals(" ") == true)
            {
                MessageBox.Show("Campos Bacios");
            }
            else if (textBox_apellido.Text.Equals(" ") == true)
            {
                MessageBox.Show("Campos Bacios");
            }
            else if (textBox_telefono.Text.Equals(" ") == true)
            {
                MessageBox.Show("Campos Bacios");
            }
            else if (textBox_contraseña.Text.Equals(" ") == true)
            {
                MessageBox.Show("Campos Bacios");
            }
            else
            {
                //  cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
                con = Conexion.ObtenerConexion();
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "Incertar_Usuarios";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", textBox_nombre.Text);
                cmd.Parameters.AddWithValue("@Apellido", textBox_apellido.Text);
                cmd.Parameters.AddWithValue("@Telefono", textBox_telefono.Text);
                cmd.Parameters.AddWithValue("@contraseña", textBox_contraseña.Text);

                textBox_nombre.Clear();
                textBox_apellido.Clear();
                textBox_telefono.Clear();
                textBox_contraseña.Clear();

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Usuario Agregado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception er)
                {
                    // throw;
                    MessageBox.Show(er.Message + MessageBoxIcon.Error);
                }

            }

        }
        //ACTUALIZAR USUARIO
        public void act_usuario(String Nombre, String Apellido, String Telefono, String Contraseña)
        {
            if (textBox_nombre.Text.Trim() == "")
            {
                MessageBox.Show("Campos Bacios");
            }
            else if (textBox_apellido.Text.Trim() == "")
            {
                MessageBox.Show("Campos Bacios");
            }
            else if (textBox_telefono.Text.Trim() == "")
            {
                MessageBox.Show("Campos Bacios");
            }
            else if (textBox_contraseña.Text.Trim() == "")
            {
                MessageBox.Show("Campos Bacios");
            }
            else
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "act_usuario";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", textBox_nombre.Text);
                cmd.Parameters.AddWithValue("@Apellido", textBox_apellido.Text);
                cmd.Parameters.AddWithValue("@Telefono", textBox_telefono.Text);
                cmd.Parameters.AddWithValue("@Contraseña", textBox_contraseña.Text);


                textBox_nombre.Clear();
                textBox_apellido.Clear();
                textBox_telefono.Clear();
                textBox_contraseña.Clear();

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Usuario Actuaizado");

                }
                catch (Exception er)
                {
                    // throw;
                    MessageBox.Show(er.Message);
                }
            }
        }
        //BORRAR USUARIO
        public void bor_usuario(String Nombre, String Apellido, String Telefono, String Contraseña)
        {
            if (textBox_nombre.Text.Trim() == "")
            {
                MessageBox.Show("Campos Bacios");
            }
            else if (textBox_apellido.Text.Trim() == "")
            {
                MessageBox.Show("Campos Bacios");
            }
            else if (textBox_telefono.Text.Trim() == "")
            {
                MessageBox.Show("Campos Bacios");
            }
            else if (textBox_contraseña.Text.Trim() == "")
            {
                MessageBox.Show("Campos Bacios");
            }
            else
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "bor_Usuario";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", textBox_nombre.Text);
                cmd.Parameters.AddWithValue("@Apellido", textBox_apellido.Text);
                cmd.Parameters.AddWithValue("@Telefono", textBox_telefono.Text);
                cmd.Parameters.AddWithValue("@Contraseña", textBox_contraseña.Text);


                textBox_nombre.Clear();
                textBox_apellido.Clear();
                textBox_telefono.Clear();
                textBox_contraseña.Clear();

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Usuario Borrado");

                }
                catch (Exception er)
                {
                    // throw;
                    MessageBox.Show(er.Message);
                }
            }
        }
        private void button_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int clave_ant = Convert.ToInt32(textBox_pin.Text);
                int clave_nuev = Convert.ToInt32(textBox_nueva_clave.Text);
                act_clave(clave_ant, clave_nuev);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Campo Bacios");
            }
        }
        public void act_clave(int clave_anterior, int clave_nueva)
        {
            SqlConnection con;
            con = Conexion.ObtenerConexion();
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "act_clave";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@clave_anteriar", textBox_pin.Text);
            cmd.Parameters.AddWithValue("@clave_nueva", textBox_nueva_clave.Text);

            textBox_telefono.Clear();
            textBox_pin.Clear();
            textBox_nueva_clave.Clear();

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Clave actualizada");

            }
            catch (Exception er)
            {
                // throw;
                MessageBox.Show(er.Message);
            }
        }
        public void ins_productos(String Categoria, String Codigo, String Descripcion, String Presentacion, float Costo, float Venta, int Cantidad, String Caducidad, string fecha)//, String Excistencia)
        {
            //  if (comboBox_categorias.Text.Equals("") == true)
            if (comboBox_categoria.Text.Equals("") == true)
            {

                MessageBox.Show("Seleccione la Categoria");
            }
            else if (textBox_codigo.Text.Equals("") == true)
            {
                MessageBox.Show("Campos Bacios");
            }
            else if (textBox_descripcion.Text.Equals("") == true)
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
            else if (dateTimePicker_caducidad.Text.Equals("") == true)
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
                cmd.Parameters.AddWithValue("@Categoria", comboBox_categoria.Text);
                cmd.Parameters.AddWithValue("@Codigo", textBox_codigo.Text);
                cmd.Parameters.AddWithValue("@Descripcion", textBox_descripcion.Text);
                cmd.Parameters.AddWithValue("@Presentacion", textBox_presentacion.Text);
                cmd.Parameters.AddWithValue("@costo", textBox_costo.Text);
                cmd.Parameters.AddWithValue("@venta", textBox_venta.Text);
                cmd.Parameters.AddWithValue("@Cantidad", textBox_cantidad.Text);
                cmd.Parameters.AddWithValue("@Caducidad", dateTimePicker_caducidad.Text);
                cmd.Parameters.AddWithValue("@fecha", dateTimePicker_fecha.Text);
                // cmd.Parameters.AddWithValue("@Excistencia", textBox_en_excistencia.Text);


                textBox_codigo.Clear();
                textBox_descripcion.Clear();
                textBox_presentacion.Clear();
                textBox_costo.Clear();
                textBox_venta.Clear();
                textBox_cantidad.Clear();
                textBox_excistencia.Clear();


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
        public void act_prod(String Categoria, String Codigo, String Descripcion, String Presentacion, float Costo, float Venta, int Cantidad, String Caducidad, string fecha)
        {
            //cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
            //cnn
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "act_productos";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Categoria", comboBox_categoria.Text);
            cmd.Parameters.AddWithValue("@Codigo", textBox_codigo.Text);
            cmd.Parameters.AddWithValue("@Descripcion", textBox_descripcion.Text);
            cmd.Parameters.AddWithValue("@Presentacion", textBox_presentacion.Text);
            cmd.Parameters.AddWithValue("@costo", textBox_costo.Text);
            cmd.Parameters.AddWithValue("@venta", textBox_venta.Text);
            cmd.Parameters.AddWithValue("@Cantidad", textBox_cantidad.Text);
            cmd.Parameters.AddWithValue("@Caducidad", dateTimePicker_caducidad.Text);
            cmd.Parameters.AddWithValue("@fecha", dateTimePicker_fecha.Text);

            textBox_codigo.Clear();
            textBox_descripcion.Clear();
            textBox_presentacion.Clear();
            textBox_costo.Clear();
            textBox_venta.Clear();
            textBox_cantidad.Clear();
            textBox_excistencia.Clear();
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
        public void bor_prod(String Categoria, String Codigo, String Descripcion, String Presentacion, float Costo, float Venta, int Cantidad, String Caducidad, string fecha)
        {
            // cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
            //cnn
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "bor_prd";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Categoria", comboBox_categoria.Text);
            cmd.Parameters.AddWithValue("@Codigo", textBox_codigo.Text);
            cmd.Parameters.AddWithValue("@Descripcion", textBox_descripcion.Text);
            cmd.Parameters.AddWithValue("@Presentacion", textBox_presentacion.Text);
            cmd.Parameters.AddWithValue("@costo", textBox_costo.Text);
            cmd.Parameters.AddWithValue("@venta", textBox_venta.Text);
            cmd.Parameters.AddWithValue("@Cantidad", textBox_cantidad.Text);
            cmd.Parameters.AddWithValue("@Caducidad", dateTimePicker_caducidad.Text);
            cmd.Parameters.AddWithValue("@fecha", dateTimePicker_fecha.Text);

            textBox_codigo.Clear();
            textBox_descripcion.Clear();
            textBox_presentacion.Clear();
            textBox_costo.Clear();
            textBox_venta.Clear();
            textBox_cantidad.Clear();
            textBox_excistencia.Clear();
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

        private void button_agregar_productos_Click(object sender, EventArgs e)
        {
            try
            {
                string cadsql = "select * from Productos where Codigo ='" + textBox_codigo.Text + "'";
                SqlCommand comando = new SqlCommand(cadsql, con);
                con.Open();
                SqlDataReader leer1 = comando.ExecuteReader();

                if (leer1.Read() == true)
                {
                    MessageBox.Show("El Registro ya exciste");
                }
                else if (comboBox_categoria.Text.Trim() == "" || textBox_codigo.Text.Trim() == "" || textBox_descripcion.Text.Trim() == "" || textBox_costo.Text.Trim() == "" || textBox_venta.Text.Trim() == "" || textBox_cantidad.Text.Trim() == "" || textBox_presentacion.Text.Trim() == "")
                {

                    MessageBox.Show("No Se Permiten Productos en Blanco", "LLenar Registro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {

                    int costo = Convert.ToInt32(textBox_costo.Text);
                    int venta = Convert.ToInt32(textBox_venta.Text);
                    int cantidad = Convert.ToInt32(textBox_cantidad.Text);
                    ins_productos(comboBox_categoria.Text, textBox_codigo.Text, textBox_descripcion.Text, textBox_presentacion.Text, costo, venta, cantidad, dateTimePicker_caducidad.Text, dateTimePicker_fecha.Text);//, textBox_en_excistencia.Text);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_actualizar_productos_Click(object sender, EventArgs e)
        {
            try
            {
                int costo = Convert.ToInt32(textBox_costo.Text);
                int venta = Convert.ToInt32(textBox_venta.Text);
                int cantidad = Convert.ToInt32(textBox_cantidad.Text);
                act_prod(comboBox_categoria.Text, textBox_codigo.Text, textBox_descripcion.Text, textBox_presentacion.Text, costo, venta, cantidad, dateTimePicker_caducidad.Text, dateTimePicker_fecha.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Campos Bacios");
            }
        }

        private void button_borrar_procuctos_Click(object sender, EventArgs e)
        {
            try
            {
                int costo = Convert.ToInt32(textBox_costo.Text);
                int venta = Convert.ToInt32(textBox_venta.Text);
                int cantidad = Convert.ToInt32(textBox_cantidad.Text);
                bor_prod(comboBox_categoria.Text, textBox_codigo.Text, textBox_descripcion.Text, textBox_presentacion.Text, costo, venta, cantidad, dateTimePicker_caducidad.Text, dateTimePicker_fecha.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Campos bacios");
            }
        }
        //EVENTO PARA AUTOLLENAR LOS TEXBOX CHIDO
        private void textBox_codigo_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                string cadsql = "select * from Productos where  Codigo LIKE ('" + textBox_codigo.Text + "')";

                SqlCommand comando = new SqlCommand(cadsql, con);
                con.Open();
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    comboBox_categoria.Text = leer["Categoria"].ToString();
                    textBox_codigo.Text = leer["Codigo"].ToString();
                    textBox_descripcion.Text = leer["Descripcion"].ToString();
                    textBox_costo.Text = leer["costo"].ToString();
                    textBox_venta.Text = leer["venta"].ToString();
                    textBox_cantidad.Text = leer["Cantidad"].ToString();
                    textBox_presentacion.Text = leer["Presentacion"].ToString();
                    dateTimePicker_fecha.Text = leer["fecha"].ToString();
                    dateTimePicker_caducidad.Text = leer["Caducidad"].ToString();
                    //lab_existencia.Text = textBox_cantidad.Text;
                    textBox_excistencia.Text = textBox_cantidad.Text;


                }
                else if (leer.Read() == false)
                {
                    comboBox_categoria.Text = "";
                    // textBox_codigo_de_barras.Text = "";
                    textBox_descripcion.Text = "";
                    textBox_costo.Text = "";
                    textBox_venta.Text = "";
                    textBox_cantidad.Text = "";
                    textBox_excistencia.Text = "";
                    textBox_presentacion.Text = "";
                    dateTimePicker_fecha.Text = "";
                    textBox_presentacion.Text = string.Empty;
                }
                else if (textBox_codigo.Text.Equals("") == true)
                {


                    //-->Es lo mismo que 
                    //-->textBox_codigo_de_barras.clear();

                    comboBox_categoria.Text = "";
                    textBox_codigo.Text = "";
                    textBox_descripcion.Text = "";
                    textBox_costo.Text = "";
                    textBox_venta.Text = "";
                    textBox_cantidad.Text = "";
                    textBox_excistencia.Text = "";
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

        private void button_mostrar_Click(object sender, EventArgs e)
        {
            try
            {
                //cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
                con.Open();
                DataTable datos = new DataTable();
                SqlDataAdapter sqldatos = new SqlDataAdapter("select * from Productos", con);
                sqldatos.Fill(datos);
                dataGridView_productos.DataSource = datos;
                //--COLOR
                dataGridView_productos.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
                dataGridView_productos.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_mostrar_usuarios_Click(object sender, EventArgs e)
        {
            try
            {
                //cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
                con.Open();
                DataTable datos = new DataTable();
                SqlDataAdapter sqldatos = new SqlDataAdapter("select * from Usuarios", con);
                sqldatos.Fill(datos);
                dataGridView_usuarios.DataSource = datos;
                //--COLOR
                dataGridView_usuarios.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
                dataGridView_usuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            comboBox_categoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button_agregar_usuario_Click(object sender, EventArgs e)
        {
            try
            {
                string cadsql = "select * from Usuarios where Nombre ='" + textBox_nombre.Text + "'";
                SqlCommand comando = new SqlCommand(cadsql, con);
                con.Open();
                SqlDataReader leer1 = comando.ExecuteReader();

                if (leer1.Read() == true)
                {
                    MessageBox.Show("El Registro ya exciste", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                //else if (textBox1_nombre.Text != " "||textBox_apellido.Text!=" "||textBox_telefono.Text!=" "||textBox_contraseña.Text!=" ")
                else if (textBox_nombre.Text.Trim() == "" || textBox_apellido.Text.Trim() == "" || textBox_telefono.Text.Trim() == "" || textBox_contraseña.Text.Trim() == "")

                {
                    MessageBox.Show("No Se Permiten Usuarios En Blanco", "Llenar Registro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    //int telefono = Convert.ToInt32(textBox_telefono.Text);
                    ins_Usuario(textBox_nombre.Text, textBox_apellido.Text, textBox_telefono.Text, textBox_contraseña.Text);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_actualizar_usuario_Click(object sender, EventArgs e)
        {
            try
            {
                act_usuario(textBox_nombre.Text, textBox_apellido.Text, textBox_telefono.Text, textBox_contraseña.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Campos Bacios");
            }
        }

        private void button_borrar_usuario_Click(object sender, EventArgs e)
        {
            try
            {
                bor_usuario(textBox_nombre.Text, textBox_apellido.Text, textBox_telefono.Text, textBox_contraseña.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Campos Bacios");
            }
        }
        //EVENTO AUTOLLENAR USUARIO
        private void textBox_nombre_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string cadsql = "select * from Usuarios where  Nombre LIKE ('" + textBox_nombre.Text + "')";

                SqlCommand comando = new SqlCommand(cadsql, con);
                con.Open();
                SqlDataReader leer = comando.ExecuteReader();
                if (leer.Read() == true)
                {
                    textBox_nombre.Text = leer["Nombre"].ToString();
                    textBox_apellido.Text = leer["Apellido"].ToString();
                    textBox_telefono.Text = leer["Telefono"].ToString();
                    textBox_contraseña.Text = leer["Contraseña"].ToString();
                }
                else if (leer.Read() == false)
                {

                    //textBox_nombre.Text = "";
                    textBox_apellido.Text = "";
                    textBox_telefono.Text = "";
                    textBox_contraseña.Text = "";
                    textBox_contraseña.Text = string.Empty;
                }
                else if (textBox_nombre.Text.Equals("") == true)
                {
                    textBox_nombre.Text = "";
                    textBox_apellido.Text = "";
                    textBox_telefono.Text = "";
                    textBox_contraseña.Text = "";
                    textBox_contraseña.Text = string.Empty;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_generar_bitacora_Click(object sender, EventArgs e)
        {
            Bitacoras bi = new Bitacoras();
            bi.ShowDialog();
        }
    }
}

