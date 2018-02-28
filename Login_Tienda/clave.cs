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
    public partial class clave : Form
    {
        public clave()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    if (textBox1.Text == "12345")
                    {
                        MessageBox.Show("Correcto");
                        Registro obj = new Registro();
                        //obj.ShowDialog();
                        //Cerrar Vntana anterior
                        obj.Visible = true;
                        Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Incorecto");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void button_enter_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox2.Text == "12345")
                {
                    MessageBox.Show("Correcto");
                    Registro obj = new Registro();
                    // obj.ShowDialog();
                    //Cerrar Ventanas anterirores
                    obj.Visible = true;
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Incorecto");
                }

            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);

            }

        }

        private void clave_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    if (textBox2.Text == "12345")
                    {
                        MessageBox.Show("Correcto");
                        Registro obj = new Registro();
                        //obj.ShowDialog();
                        //Cerrar Vntana anterior
                        obj.Visible = true;
                        Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Incorecto");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
            
    }
}
            
