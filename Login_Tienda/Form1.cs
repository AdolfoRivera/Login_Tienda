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

        public static string nombre = "";

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
                    //metodo de varra de progreso
                    pruebabarra();
                    //---------------
                    MessageBox.Show("Bienvenido: " + textBox_usuario.Text, "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    menu obj = new menu();
                    
                    //Mostrar Usuario Rejistrado-----
                
                    obj.label_usuario.Text = textBox_usuario.Text;
                    //obtiene nombre de usuario
                    nombre = dr[0].ToString();

                    /*if (textBox_usuario.Text!="Vicente"&&textBox_contraseña.Text!="admin"&&textBox_usuario.Text!="Adolfo"&&textBox_contraseña.Text!="12345678")
                    {
                        obj.button_administrador.Enabled = false;
                    }   */    
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

            
           /* if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar)
                || e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == '-')
            {
                e.Handled = false;
            }
            else
            {*/
               // ToolTip.IsBalloon = true;
               // toolTip1.IsBalloon = true;
                //toolTip1.Show("No se permiten caracteres locos",label1,3000);
                //e.Handled = true;
          //  }
        }

        private void textBox_usuario_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == '-' || e.KeyChar == '_' || e.KeyChar == ';' || e.KeyChar == ':' || e.KeyChar == '´' || e.KeyChar == 'ç' || e.KeyChar == '{' || e.KeyChar == '}' || e.KeyChar == '[' || e.KeyChar == ']' || e.KeyChar == '`' || e.KeyChar == '+' || e.KeyChar == '¡' || e.KeyChar == '¿' || e.KeyChar == '?' || e.KeyChar == '=' || e.KeyChar == ')' || e.KeyChar == '(' || e.KeyChar == '/' || e.KeyChar == '&' || e.KeyChar == '%' || e.KeyChar == '$' || e.KeyChar == '·' || e.KeyChar == '"' || e.KeyChar == '!' || e.KeyChar == 'ª' || e.KeyChar == 'º' || e.KeyChar == '<' || e.KeyChar == '>')
            try
            {
                if (textBox_usuario.Text.Trim() == "'")
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
                  if (textBox_contraseña.Text.Trim() == "'")
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
        //evento barra de progreso
        private void Form1_Load(object sender, EventArgs e)
        {
           
//            lb_porciento.Parent = pictureBox1;
  //          lb_porciento.BackColor = Color.Transparent;

        }
        //metodo para la barra de progreso
        public void pruebabarra()
        {
            progressBar1.Increment(100);
            lb_porciento.Text = progressBar1.Value.ToString() + "%";
            if (progressBar1.Value==progressBar1.Maximum)
            {
                timer1.Stop();
               // this.Hide();
                // menu men = new menu();
                 //men.Show();
                
            }
        }

        private void button_preuba_Click(object sender, EventArgs e)
        {
             
        }
        //evento barra de progreso
        private void timer1_Tick(object sender, EventArgs e)
        {

           // pruebabarra(); 
        }
            //evento barra de progreso

            private void progressBar1_Click(object sender, EventArgs e)
        {
            //ProgressBar pb = new ProgressBar();
        }

        
    }
}
