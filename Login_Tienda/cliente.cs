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
    public partial class cliente : Form
    {
        public cliente()
        {
            InitializeComponent();
        }
        private void agr_clientes(object F_agregar_cliente)
        {//pregunta si hay algo en el contenedor
            if (this.panel_contenedor_cleintes.Controls.Count > 0)
                this.panel_contenedor_cleintes.Controls.RemoveAt(0);
            //creacion de formulario
            Form fh = F_agregar_cliente as Form;
            //instruccion que le indica que no es un form superior si no inferior
            fh.TopLevel = false;
            //para que se acuple a todo el panel contenedor
            fh.Dock = DockStyle.Fill;
            //lo agregamos al panel
            this.panel_contenedor_cleintes.Controls.Add(fh);
            //estableser u¡instancia como contenedor de datos de panel
            this.panel_contenedor_cleintes.Tag = fh;
            //se muestra
            fh.Show();


        }
        private void esrtado_de_cuennta(object F_est_de_cunt)
        {//pregunta si hay algo en el contenedor
            if (this.panel_contenedor_cleintes.Controls.Count > 0)
                this.panel_contenedor_cleintes.Controls.RemoveAt(0);
            //creacion de formulario
            Form fh = F_est_de_cunt as Form;
            //instruccion que le indica que no es un form superior si no inferior
            fh.TopLevel = false;
            //para que se acuple a todo el panel contenedor
            fh.Dock = DockStyle.Fill;
            //lo agregamos al panel
            this.panel_contenedor_cleintes.Controls.Add(fh);
            //estableser u¡instancia como contenedor de datos de panel
            this.panel_contenedor_cleintes.Tag = fh;
            //se muestra
            fh.Show();


        }
        private void button_nevo_cliente_Click(object sender, EventArgs e)
        {
            agr_clientes(new agregar_cliente());
        }

        private void button_modificar_cliente_Click(object sender, EventArgs e)
        {
            modificar_cliente obj = new modificar_cliente();
            obj.ShowDialog();
        }

        private void button_eliminar_cliente_Click(object sender, EventArgs e)
        {
            eliminar_cliente obj = new eliminar_cliente();
            obj.ShowDialog();
        }

        private void button_estado_de_cta_cliente_Click(object sender, EventArgs e)
        {
            esrtado_de_cuennta(new estado_de_cuenta());
        }
    }
}
