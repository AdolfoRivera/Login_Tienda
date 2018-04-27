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

       // SqlConnection cnn;
        SqlCommand cmd;
        SqlConnection con = Conexion.ObtenerConexion();
        public Registro()
        {
            //cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
            InitializeComponent();
            
        }
        public void ins_Usuario(String Nombre, String Apellido, String Telefono, String Contraseña)
        {
            if (textBox1_nombre.Text.Equals(" ") == true)
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
        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void button_aseptar_Click(object sender, EventArgs e)
        {
            try
            {
                string cadsql = "select * from Usuarios where Nombre ='" + textBox1_nombre.Text + "'";
                SqlCommand comando = new SqlCommand(cadsql, con);
                con.Open();
                SqlDataReader leer1 = comando.ExecuteReader();

                if (leer1.Read() == true)
                {
                    MessageBox.Show("El Registro ya exciste", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                //else if (textBox1_nombre.Text != " "||textBox_apellido.Text!=" "||textBox_telefono.Text!=" "||textBox_contraseña.Text!=" ")
                else if (textBox1_nombre.Text.Trim() == "" || textBox_apellido.Text.Trim() == "" || textBox_telefono.Text.Trim() == "" || textBox_contraseña.Text.Trim() == "")

                {
                    MessageBox.Show("No Se Permiten Usuarios En Blanco", "Llenar Registro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }else
                {
                    //int telefono = Convert.ToInt32(textBox_telefono.Text);
                    ins_Usuario(textBox1_nombre.Text, textBox_apellido.Text, textBox_telefono.Text, textBox_contraseña.Text);
                }
                con.Close();
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
         
           /* if (e.KeyChar == Convert.ToChar(Keys.Space))
            {
                MessageBox.Show("No se permiten espacios");
            }*/
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

                    string cadsql = "select * from Usuarios where Nombre ='" + textBox1_nombre.Text + "'";
                    SqlCommand comando = new SqlCommand(cadsql, con);
                    con.Open();
                    SqlDataReader leer1 = comando.ExecuteReader();

                    if (leer1.Read() == true)
                    {
                        MessageBox.Show("El Registro ya exciste", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                      
                    }
                    // else if (textBox1_nombre.Text != " " || textBox_apellido.Text != " " || textBox_telefono.Text != " " || textBox_contraseña.Text != " ")
                    else if (textBox1_nombre.Text.Trim()=="" || textBox_apellido.Text.Trim()=="" || textBox_telefono.Text.Trim()=="" || textBox_contraseña.Text.Trim()=="")
                    {
                         
                        MessageBox.Show("No Se Permiten Usuarios En Blanco", "LLenar Registro", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }else
                    {
                       // int telefono = Convert.ToInt32(textBox_telefono.Text);
                        ins_Usuario(textBox1_nombre.Text, textBox_apellido.Text, textBox_telefono.Text, textBox_contraseña.Text);
                    }
                    con.Close();
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
        //Codigo Para Mover Ventana
        Point DragCursor;
        Point DragForm;
        bool Dragging;
        private void Registro_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void Registro_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }

        private void Registro_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
        }

        private void textBox1_nombre_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void textBox_contraseña_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (textBox_contraseña.Text == "'")
                {
                    MessageBox.Show("NO (')");
                    textBox_contraseña.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}