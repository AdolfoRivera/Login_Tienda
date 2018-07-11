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
    public partial class Salidas : Form
    {
        SqlCommand cmd;
        SqlConnection con = Conexion.ObtenerConexion();
        public Salidas()
        {
            InitializeComponent();
            textBox_hora.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void Salidas_Load(object sender, EventArgs e)
        {

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

        private void textBox_cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololNumeros(e);
        }

        private void textBox_consepto_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololLetras(e);
        }
        public void ins_ent_y_sal(String Descripcion, String Cantidad, String Consepto, String Fecha)
        {

            //  cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
            con = Conexion.ObtenerConexion();
            SqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "ins_ent_y_sali";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
            cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
            cmd.Parameters.AddWithValue("@Consepto", Consepto);
            cmd.Parameters.AddWithValue("@fecha", Fecha);
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
                MessageBox.Show("Salida realizada con exito", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception er)
            {
                // throw;
                MessageBox.Show(er.Message + MessageBoxIcon.Error);
            }

        }

        private void button_aceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_cantidad.Text.Trim() == "" || textBox_consepto.Text.Trim() == "")
                {
                    MessageBox.Show("No Se Permiten Campos Vacios", "Llenar Registro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {

                    ins_ent_y_sal(textBox_descipcion.Text, textBox_cantidad.Text, textBox_consepto.Text, textBox_hora.Text);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

