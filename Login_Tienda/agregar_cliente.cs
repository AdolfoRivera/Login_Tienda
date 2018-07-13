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
    public partial class agregar_cliente : Form
    {
        // SqlConnection cnn;
        SqlCommand cmd;
        SqlConnection con = Conexion.ObtenerConexion();
        public agregar_cliente()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void mostrar()
        {
            try
            {

                //cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
                con.Open();
                DataTable datos = new DataTable();
                SqlDataAdapter sqldatos = new SqlDataAdapter("select * from clientes", con);
                sqldatos.Fill(datos);
                dataGridView1.DataSource = datos;
                //--COLOR
                dataGridView1.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void agregar_cliente_Load(object sender, EventArgs e)
        {
            try
            {

                //cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
                con.Open();
                DataTable datos = new DataTable();
                SqlDataAdapter sqldatos = new SqlDataAdapter("select * from clientes", con);
                sqldatos.Fill(datos);
                dataGridView1.DataSource = datos;
                //--COLOR
                dataGridView1.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
                dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ins_cliente(String Nombre, String Direccion, string Telefono, float limite_de_credito)
        {
            if (textBox_nombre_agregar_cliente.Text.Equals(" ") == true)
            {
                MessageBox.Show("Campos Vacios");
            }
            else if (textBox_direccion_agregar_ciente.Text.Equals(" ") == true)
            {
                MessageBox.Show("Campos Vacios");
            }
            else if (textBox_telefono_agregar_cliente.Text.Equals(" ") == true)
            {
                MessageBox.Show("Campos Vacios");
            }
            else if (textBox_limite_agregar_cliente.Text.Equals(" ") == true)
            {
                MessageBox.Show("Campos Vacios");
            }
            else
            {
                //  cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
                con = Conexion.ObtenerConexion();
                SqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "ins_cliente";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.Parameters.AddWithValue("@direccion", Direccion);
                cmd.Parameters.AddWithValue("@telefono", Telefono);
                cmd.Parameters.AddWithValue("@limite_de_credito", limite_de_credito);

                textBox_nombre_agregar_cliente.Clear();
                textBox_direccion_agregar_ciente.Clear();
                textBox_telefono_agregar_cliente.Clear();
                textBox_limite_agregar_cliente.Clear();

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Cliente Agregado Correctamente", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception er)
                {
                    // throw;
                    MessageBox.Show(er.Message + MessageBoxIcon.Error);
                }

            }

        }
        public void act_cliente(String Nombre, String Direccion, String Telefono, float limite_de_credito)
        {
            if (textBox_nombre_agregar_cliente.Text.Equals(" ") == true)
            {
                MessageBox.Show("Campos Vacios");
            }
            else if (textBox_direccion_agregar_ciente.Text.Equals(" ") == true)
            {
                MessageBox.Show("Campos Vacios");
            }
            else if (textBox_telefono_agregar_cliente.Text.Equals(" ") == true)
            {
                MessageBox.Show("Campos Vacios");
            }
            else if (textBox_limite_agregar_cliente.Text.Equals(" ") == true)
            {
                MessageBox.Show("Campos Vacios");
            }
            else
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "act_cliente";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.Parameters.AddWithValue("@direccion", Direccion);
                cmd.Parameters.AddWithValue("@telefono", Telefono);
                cmd.Parameters.AddWithValue("@limite_de_credito", limite_de_credito);


                textBox_nombre_agregar_cliente.Clear();
                textBox_direccion_agregar_ciente.Clear();
                textBox_telefono_agregar_cliente.Clear();
                textBox_limite_agregar_cliente.Clear();

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Cliente Actuaizado");

                }
                catch (Exception er)
                {
                    // throw;
                    MessageBox.Show(er.Message);
                }
            }
        }
        public void bor_cliente(String Nombre, String Direccion, String Telefono, float limite_de_credito)
        {
            if (textBox_nombre_agregar_cliente.Text.Equals(" ") == true)
            {
                MessageBox.Show("Campos Vacios");
            }
            else if (textBox_direccion_agregar_ciente.Text.Equals(" ") == true)
            {
                MessageBox.Show("Campos Vacios");
            }
            else if (textBox_telefono_agregar_cliente.Text.Equals(" ") == true)
            {
                MessageBox.Show("Campos Vacios");
            }
            else if (textBox_limite_agregar_cliente.Text.Equals(" ") == true)
            {
                MessageBox.Show("Campos Vacios");
            }
            else
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "bor_cliente";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@nombre", Nombre);
                cmd.Parameters.AddWithValue("@direccion", Direccion);
                cmd.Parameters.AddWithValue("@telefono", Telefono);
                cmd.Parameters.AddWithValue("@limite_de_credito", limite_de_credito);


                textBox_nombre_agregar_cliente.Clear();
                textBox_direccion_agregar_ciente.Clear();
                textBox_telefono_agregar_cliente.Clear();
                textBox_limite_agregar_cliente.Clear();

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Cliente Borrado");

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
                string cadsql = "select * from clientes where Nombre ='" + textBox_nombre_agregar_cliente.Text + "'";
                SqlCommand comando = new SqlCommand(cadsql, con);
                con.Open();
                SqlDataReader leer1 = comando.ExecuteReader();

                if (leer1.Read() == true)
                {
                    MessageBox.Show("El Registro ya exciste", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                //else if (textBox1_nombre.Text != " "||textBox_apellido.Text!=" "||textBox_telefono.Text!=" "||textBox_contraseña.Text!=" ")
                else if (textBox_nombre_agregar_cliente.Text.Trim() == "" || textBox_direccion_agregar_ciente.Text.Trim() == "" || textBox_telefono_agregar_cliente.Text.Trim() == "" || textBox_limite_agregar_cliente.Text.Trim() == "")

                {
                    MessageBox.Show("No Se Permiten Usuarios En Blanco", "Llenar Registro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {

                    // int tel = Convert.ToInt32(textBox_telefono_agregar_cliente.Text);
                    float l_c = float.Parse(textBox_limite_agregar_cliente.Text);
                    ins_cliente(textBox_nombre_agregar_cliente.Text, textBox_direccion_agregar_ciente.Text, textBox_telefono_agregar_cliente.Text, l_c);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /* textBox_nombre_agregar_cliente.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[1].Value;
             textBox_direccion_agregar_ciente.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[2].Value;
             textBox_telefono_agregar_cliente.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[3].Value;
             textBox_limite_agregar_cliente.Text = (string)dataGridView1.Rows[e.RowIndex].Cells[4].Value;*/
            textBox_nombre_agregar_cliente.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            textBox_direccion_agregar_ciente.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            textBox_telefono_agregar_cliente.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            textBox_limite_agregar_cliente.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*textBox_nombre_agregar_cliente.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
            textBox_direccion_agregar_ciente.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
            textBox_telefono_agregar_cliente.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[3].Value.ToString();
            textBox_limite_agregar_cliente.Text = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value.ToString();
            */
            /*
            textBox_nombre_agregar_cliente.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[1].Value);
            textBox_direccion_agregar_ciente.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[2].Value);
            textBox_telefono_agregar_cliente.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[3].Value);
            textBox_limite_agregar_cliente.Text = Convert.ToString(this.dataGridView1.CurrentRow.Cells[4].Value);
            */

        }

        private void button_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                float l_c = float.Parse(textBox_limite_agregar_cliente.Text);
                act_cliente(textBox_nombre_agregar_cliente.Text, textBox_direccion_agregar_ciente.Text, textBox_telefono_agregar_cliente.Text, l_c);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_borrar_Click(object sender, EventArgs e)
        {
            try
            {
                float l_c = float.Parse(textBox_limite_agregar_cliente.Text);
                bor_cliente(textBox_nombre_agregar_cliente.Text, textBox_direccion_agregar_ciente.Text, textBox_telefono_agregar_cliente.Text, l_c);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void agregar_cliente_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void agregar_cliente_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void agregar_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            mostrar();
        }
    }
}
