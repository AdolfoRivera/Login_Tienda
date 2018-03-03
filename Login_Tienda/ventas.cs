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
    public partial class ventas : Form
    {
        public ventas()
        {
            InitializeComponent();
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            buscar obj = new buscar();
            obj.ShowDialog();

        }

        private void button_entradas_Click(object sender, EventArgs e)
        {
            entradas obj = new entradas();
            obj.ShowDialog();
        }

        private void button_salidas_Click(object sender, EventArgs e)
        {
            Salidas obj = new Salidas();
            obj.ShowDialog();
        }

        private void button_hacer_venta_Click(object sender, EventArgs e)
        {
            enter_cobrar obj = new enter_cobrar();
            obj.ShowDialog();
        }
    }
}
