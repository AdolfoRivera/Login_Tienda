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
    public partial class clave_adm : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        public clave_adm()
        {
            InitializeComponent();
        }

        private void clave_adm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    validacion();
                  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_enter_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        public void validacion()
        {
            con = Conexion.ObtenerConexion();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select clave_nueva from tabla_clave where clave_nueva ='" + textBox2.Text + "' ";
            cmd.Connection = con;
            con.Open();

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
               // Administrador obj = new Administrador();

                string adm = "ADMIN";
                MessageBox.Show("Bienvenido: "/* + textBox2.Text, */+ adm, "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
               //obj.Visible = true;
                //Visible = false;
              // abrirfromulario_administrador(new Administrador());

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

        private void button_enter_Click(object sender, EventArgs e)
        {
            validacion();
        }
        menu me2 = new menu();
        private void abrirfromulario_administrador(object F_ADM)
        {//pregunta si hay algo en el contenedor
            if (this.me2.panel_contenedor.Controls.Count > 0)
                this.me2.panel_contenedor.Controls.RemoveAt(0);
            //creacion de formulario
            Administrador fh = F_ADM as Administrador;
            //instruccion que le indica que no es un form superior si no inferior
            fh.TopLevel = false;
            //para que se acuple a todo el panel contenedor
            fh.Dock = DockStyle.Fill;
            //lo agregamos al panel
            this.me2.panel_contenedor.Controls.Add(fh);
            //estableser u¡instancia como contenedor de datos de panel
            this.me2.panel_contenedor.Tag = fh;
            //se muestra
            fh.Show();


        }
    }
}
