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
    public partial class estado_de_cuenta : Form
    {
        public estado_de_cuenta()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_avonar_Click(object sender, EventArgs e)
        {
            Abonar obj = new Abonar();
            obj.ShowDialog();
        }

        private void button_liquidar_Click(object sender, EventArgs e)
        {
            liquidar obj = new liquidar();
            obj.ShowDialog();
        }
    }
}
