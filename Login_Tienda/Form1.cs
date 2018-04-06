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
        SqlConnection cnn;
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        
        public Form1()
        {
            InitializeComponent();             //=./ vorrar DARCK
             cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
            
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
            
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandText = "select Nombre,Contraseña from Usuarios where Nombre ='" + textBox_usuario.Text + "'and Contraseña ='" + textBox_contraseña.Text + "' ";
            cmd.Connection = cnn;
            cnn.Open(); 

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Bienvenido: " + textBox_usuario.Text,"Correcto",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
            cnn.Close();

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
    }
}
