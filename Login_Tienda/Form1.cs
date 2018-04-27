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
    public partial class Form1 : Form
    {
        //SqlConnection cnn;
       // SqlConnection con;
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
         SqlConnection con = Conexion.ObtenerConexion();
        public Form1()
        {
            InitializeComponent();             //=./ vorrar DARCK
            // cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
           
        }

        private void button_rejistrarse_Click(object sender, EventArgs e)
        {
            clave clv = new clave();
            //clv.ShowDialog();
            
            clv.Visible = true;
            Visible = false;
            /*Registro obj = new Registro();
            obj.ShowDialog();*/
        }

        private void checkBox_mostrar_contraseña_CheckedChanged(object sender, EventArgs e)
        {
            string text = textBox_contraseña.Text;
            if (checkBox_mostrar_contraseña.Checked)
            {
                textBox_contraseña.UseSystemPasswordChar = false;
                textBox_contraseña.Text = text;
            }
            else
            {
                textBox_contraseña.UseSystemPasswordChar = true;
                textBox_contraseña.Text = text;
            }
        }

        private void button_aseptar_Click(object sender, EventArgs e)
        {
            Validacion();
            
        }

        private void textBox_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Validacion();
            }
            //Codogo Por SI No Funciona El Metodo Anterior

            /* if (checkBox_mostrar_contraseña.Checked == true)
             {
                 if (textBox_contraseña.PasswordChar == '*')
                 {
                     textBox_contraseña.PasswordChar = '\0';
                 }
             }
             else
             {
                 textBox_contraseña.PasswordChar = '*';
             }*/
        }

        private void button_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Validar Usuario En la Base De Datos

        public void Validacion()
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "select Nombre,Contraseña from Usuarios where Nombre ='" + textBox_usuario.Text + "'and Contraseña ='" + textBox_contraseña.Text + "' ";
                cmd.Connection = con;
                con.Open();

                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    MessageBox.Show("Bienvenido: " + textBox_usuario.Text, "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    menu obj = new menu();
                    //Mostrar Usuario Rejistrado-----
                    obj.label_usuario.Text = textBox_usuario.Text;
                    //-----
                    obj.Visible = true;
                    Visible = false;

                }
                else
                {
                    // MessageBox.Show("Datos Incorrectos");
                    MessageBox.Show("Datos Incorrectos", "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                dr.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Codigo Para Mover Ventana
        Point DragCursor;
        Point DragForm;
        bool Dragging;
        //Evento MouseUP
        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }
        //Evento MouseDown
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Dragging = true;
            DragCursor = Cursor.Position;
            DragForm = this.Location;
        }
        //Evento MouseMove
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Dragging == true)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(DragCursor));
                this.Location = Point.Add(DragForm, new Size(dif));
            }
            //StartPocition Pociocion De El Fromulario Poner CenterScen
            //FlatStyle Para Quitar Borde A Los Botones
        }

        private void checkBox_mostrar_contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Validacion(); 
            }

        }
        //Evento para poner marca de agua a USUARIO
        private void textBox_usuario_Enter(object sender, EventArgs e)
        {
            if (textBox_usuario.Text=="Nombre")
            {
                textBox_usuario.Text = "";
                textBox_usuario.ForeColor = Color.Black;
            }
        }
        //Evento para poner marca de agua a USUARIO
        private void textBox_usuario_Leave(object sender, EventArgs e)
        {
            if (textBox_usuario.Text == "")
            {
                textBox_usuario.Text = "Nombre";
                textBox_usuario.ForeColor = Color.Silver;
            }
        }
       // public bool IsBalloon { get; set;}
        private void textBox_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            sololLetras(e);

            /*
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)
                || e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {
               // ToolTip.IsBalloon = true;
                toolTip1.IsBalloon = true;
                toolTip1.Show("No se permiten caracteres locos",textBox_usuario,3000);
                e.Handled = true;
            }*/
        }

        private void textBox_usuario_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == '-' || e.KeyChar == '_' || e.KeyChar == ';' || e.KeyChar == ':' || e.KeyChar == '´' || e.KeyChar == 'ç' || e.KeyChar == '{' || e.KeyChar == '}' || e.KeyChar == '[' || e.KeyChar == ']' || e.KeyChar == '`' || e.KeyChar == '+' || e.KeyChar == '¡' || e.KeyChar == '¿' || e.KeyChar == '?' || e.KeyChar == '=' || e.KeyChar == ')' || e.KeyChar == '(' || e.KeyChar == '/' || e.KeyChar == '&' || e.KeyChar == '%' || e.KeyChar == '$' || e.KeyChar == '·' || e.KeyChar == '"' || e.KeyChar == '!' || e.KeyChar == 'ª' || e.KeyChar == 'º' || e.KeyChar == '<' || e.KeyChar == '>')
            try
            {
                if (textBox_usuario.Text == "'")
                {
                    MessageBox.Show("NO (')");
                    textBox_usuario.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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
        //metodo para poner solo letras
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
    }
}
