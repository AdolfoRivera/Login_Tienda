using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Data.SqlClient;
namespace Login_Tienda
{
    public partial class menu : Form
    {
        SqlConnection con = Conexion.ObtenerConexion();
        public menu()
        {
            InitializeComponent();
            timer1.Enabled = true;
            
    }

       /* private void button_regresar_Click(object sender, EventArgs e)
        {
            //Cierra El Menu Y Abre El Ligin
            Form1 obj = new Form1();
            obj.Visible = true;
            Visible = false;
        }*/

        private void button_regersar_2_Click(object sender, EventArgs e)
        {
            //Cierra El Menu Y Abre El Ligin
            Form1 obj = new Form1();
            obj.Visible = true;
            Visible = false;
            //
            //prueba de cambio
       
        }

        private void menu_Load(object sender, EventArgs e)
        {
           

        }

        private void button_ventas_Click(object sender, EventArgs e)
        {
            /*ventas obj = new ventas();
            obj.ShowDialog();*/

            abrirfromulario_ventas(new ventas());
         



        }
        private void abrirfromulario_ventas(object F_ventas)

        {
            
            //pregunta si hay algo en el contenedor
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);
            //creacion de formulario
            Form fh = F_ventas as Form;
            //instruccion que le indica que no es un form superior si no inferior
            fh.TopLevel = false;
            //para que se acuple a todo el panel contenedor
            fh.Dock = DockStyle.Fill;
            //lo agregamos al panel
            this.panel_contenedor.Controls.Add(fh);
            //estableser u¡instancia como contenedor de datos de panel
            this.panel_contenedor.Tag = fh;
            //se muestra
            fh.Show();
         

        }
        private void agregar_productos(object F_producto)
        {//pregunta si hay algo en el contenedor
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);
            //creacion de formulario
            Form fh = F_producto as Form;
            //instruccion que le indica que no es un form superior si no inferior
            fh.TopLevel = false;
            //para que se acuple a todo el panel contenedor
            fh.Dock = DockStyle.Fill;
            //lo agregamos al panel
            this.panel_contenedor.Controls.Add(fh);
            //estableser u¡instancia como contenedor de datos de panel
            this.panel_contenedor.Tag = fh;
            //se muestra
            fh.Show();


        }

        private void agregar_clientes(object F_cliente)
        {//pregunta si hay algo en el contenedor
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);
            //creacion de formulario
            Form fh = F_cliente as Form;
            //instruccion que le indica que no es un form superior si no inferior
            fh.TopLevel = false;
            //para que se acuple a todo el panel contenedor
            fh.Dock = DockStyle.Fill;
            //lo agregamos al panel
            this.panel_contenedor.Controls.Add(fh);
            //estableser u¡instancia como contenedor de datos de panel
            this.panel_contenedor.Tag = fh;
            //se muestra
            fh.Show();


        }
        private void abrirfromulario_administrador(object F_ADM)
        {//pregunta si hay algo en el contenedor
            if (this.panel_contenedor.Controls.Count > 0)
                this.panel_contenedor.Controls.RemoveAt(0);
            //creacion de formulario
            Administrador fh = F_ADM as Administrador;
            //instruccion que le indica que no es un form superior si no inferior
            fh.TopLevel = false;
            //para que se acuple a todo el panel contenedor
            fh.Dock = DockStyle.Fill;
            //lo agregamos al panel
            this.panel_contenedor.Controls.Add(fh);
            //estableser u¡instancia como contenedor de datos de panel
            this.panel_contenedor.Tag = fh;
            //se muestra
            fh.Show();


        }



        private void button_productos_Click(object sender, EventArgs e)
        {
            agregar_productos(new productos());
        }


        private void button_clientes_Click(object sender, EventArgs e)
        {
            agregar_clientes(new cliente());
        }

        private void venta2_Click(object sender, EventArgs e)
        {
         
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void button_minimizar_Click(object sender, EventArgs e)
        {   //Minimizar
              this.WindowState = FormWindowState.Minimized;

                /*    //Maximizar
                    this.WindowState = FormWindowState.Maximized;
                    //Restaurar
                    this.WindowState = FormWindowState.Normal;
                    //Cerrar formulario activo
                    this.Close();
                    //Salir completamente de la aplicación
                    Application.Exit();  */

            }

            private void menu_Resize(object sender, EventArgs e)
        {
            //Si el estado actual de la ventana es "minimizado"...
         /*   if (this.WindowState == FormWindowState.Minimized)
            {
                //Ocultamos el formulario
                this.Visible = false;
                //Hacemos visible el icono de la bandeja del sistema
                notifyIcon1.Visible = true;
            }*/
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
               
                notifyIcon1.Visible = true;
                notifyIcon1.BalloonTipText = "Minimizado al area de notificaciones";//BalloonTiptext = "Minimizando a area de notificaciones";
                notifyIcon1.BalloonTipTitle = "Minimizado";
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
                notifyIcon1.ShowBalloonTip(5000);
                
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //Hacemos visible el formulario
            this.Show();
            this.WindowState = FormWindowState.Maximized;
            //Ocultamos el icono de la bandeja de sistema
            notifyIcon1.Visible = false;
        }

        private void button_administrador_Click(object sender, EventArgs e)
        {
            abrirfromulario_administrador(new Administrador());
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            label_hora_actual.Text = DateTime.Now.ToString();
        }

        private void button_ventas_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void button_ventas_TextChanged(object sender, EventArgs e)
        {
           
            
        }

        private void button_salir_Click(object sender, EventArgs e)
        {

        }
    }
    }
