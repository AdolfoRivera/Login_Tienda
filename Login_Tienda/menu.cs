using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Tienda
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
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
        {//pregunta si hay algo en el contenedor
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




        private void button_productos_Click(object sender, EventArgs e)
        {
            agregar_productos(new productos());
        }

        private void button_clientes_Click(object sender, EventArgs e)
        {
            agregar_clientes(new cliente());
        }
    }
}
