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

    public partial class Registro : Form
    {
        SqlConnection cnn;
        SqlCommand cmd;
        public Registro()
        {
            InitializeComponent();
        }
        public void ins_Usuario(String Nombre, String Apellido, int Telefono, String Contraseña)
        {
            if (textBox1_nombre.Text.Equals("") == true)
            {
                MessageBox.Show("Campos Bacios");
            }
            else if (textBox_apellido.Text.Equals("") == true)
            {
                MessageBox.Show("Campos Bacios");
            }
            else if (textBox_telefono.Text.Equals("") == true)
            {
                MessageBox.Show("Campos Bacios");
            }
            else if (textBox_contraseña.Text.Equals("") == true)
            {
                MessageBox.Show("Campos Bacios");
            }
            else
            {
                cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
                SqlCommand cmd = cnn.CreateCommand();

                cmd.CommandText = "Incertar_Usuarios";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre", textBox1_nombre.Text);
                cmd.Parameters.AddWithValue("@Apellido", textBox_apellido.Text);
                cmd.Parameters.AddWithValue("@Telefono", textBox_telefono.Text);
                cmd.Parameters.AddWithValue("@contraseña", textBox_contraseña.Text);

                textBox1_nombre.Clear();
                textBox_apellido.Clear();
                textBox_telefono.Clear();
                textBox_contraseña.Clear();

                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("Usuario Agregado Correctamente");

                }
                catch (Exception er)
                {
                    // throw;
                    MessageBox.Show(er.Message + MessageBoxIcon.Error);
                }

            }

        }
        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void button_aseptar_Click(object sender, EventArgs e)
        {
            try
            {
                int telefono = Convert.ToInt32(textBox_telefono.Text);
                ins_Usuario(textBox1_nombre.Text, textBox_apellido.Text, telefono, textBox_contraseña.Text);
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
        private void textBox1_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololLetras(e);
        }

        private void textBox_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololLetras(e);
        }

        private void textBox_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololNumeros(e);
        }
        //Ejecutar Con EL Boton Enter
        private void textBox_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    int telefono = Convert.ToInt32(textBox_telefono.Text);
                    ins_Usuario(textBox1_nombre.Text, textBox_apellido.Text, telefono, textBox_contraseña.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button_canselar_Click(object sender, EventArgs e)
        {
            // Registro.ActiveForm.Close();
            Form1 obj = new Form1();
            obj.Visible = true;
            Visible = false;
        }
    }
}