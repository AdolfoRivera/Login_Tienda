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
    public partial class clave : Form
    {
        SqlConnection con;
        SqlDataReader dr;
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
                validar_clave();
             /*  if (textBox2.Text == "12345")
              
               {
            //       validar_clave();
                    MessageBox.Show("Correcto");
                    Registro obj = new Registro();
                     //obj.ShowDialog();
                    //Cerrar Ventanas anterirores*/
/*
                    obj.Visible = true;
                    Visible = false;
                }
                else
                {
                    MessageBox.Show("Incorecto");
                }*/

            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);

            }

        }

        private void clave_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBox2;
            textBox2.Focus();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    validar_clave();
                    /*if (textBox2.Text == "12345")
                    {
                    //    validar_clave();
                        MessageBox.Show("Correcto");
                        Registro obj = new Registro();
                      //  obj.ShowDialog();
                    //    Cerrar Vntana anterior
                        obj.Visible = true;
                        Visible = false;
                    }
                    else
                    {
                       MessageBox.Show("Incorecto");
                    }*/
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}
       
        public void validar_clave()
        {
            con = Conexion.ObtenerConexion();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select clave_nueva from tabla_clave where clave_nueva ='" + textBox2.Text + "' ";
            cmd.Connection = con;
            con.Open();

            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Registro obj = new Registro();

                    string adm = "ADMIN";
               MessageBox.Show("Bienvenido: "/* + textBox2.Text, */+adm , "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            con.Close();

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (textBox2.Text == "'")
                {
                    MessageBox.Show("NO (')");
                    textBox2.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
            
    }

