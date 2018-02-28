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
            ventas obj = new ventas();
            obj.ShowDialog();
        }
    }
}
