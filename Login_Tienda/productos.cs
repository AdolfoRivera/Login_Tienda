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
    public partial class productos : Form
    {
        public productos()
        {
            InitializeComponent();
        }

        private void button_modificar_Click(object sender, EventArgs e)
        {
            modificar obj = new modificar();
            obj.ShowDialog();
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            eliminar obj = new eliminar();
            obj.ShowDialog();
        }
    }
}
