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
    public partial class Bitacoras : Form
    {
        SqlCommand cmd;
        SqlConnection con = Conexion.ObtenerConexion();
        public Bitacoras()
        {
            InitializeComponent();
        }

        private void Bitacoras_Load(object sender, EventArgs e)
        {
            //--COLOR
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (textBox_bucar_usuario.Text == "'")
                {
                    MessageBox.Show("NO (')");
                    textBox_bucar_usuario.Clear();
                }
                else if (textBox_bucar_usuario.Text=="")
                {
                    textBox_total.Clear();
                }else
                {
                    con.Open();
                    cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from ventas where Nombre like '%" + textBox_bucar_usuario.Text + "%'and fecha ='" + dateTimePicker_fecha.Text + "'";
                    cmd.ExecuteNonQuery();

                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();

                    double total = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        total += Convert.ToDouble(row.Cells[3].Value);
                    }
                    textBox_total.Text = Convert.ToString(total);
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_mostrara_Click(object sender, EventArgs e)
        {
            try
            {
                //cnn = new SqlConnection("Data Source=DARCK;Initial Catalog=Tienda;Integrated Security=True");
                con.Open();
                DataTable datos = new DataTable();
                SqlDataAdapter sqldatos = new SqlDataAdapter("select * from ventas", con);
                sqldatos.Fill(datos);
                dataGridView1.DataSource = datos;
                con.Close();

                double total = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    total += Convert.ToDouble(row.Cells[3].Value);
                }
                textBox_total.Text = Convert.ToString(total);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dateTimePicker_fecha_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void dateTimePicker_fecha_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from ventas where fecha ='" + dateTimePicker_fecha.Text + "'";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
                
                    double total = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        total += Convert.ToDouble(row.Cells[3].Value);
                    }
                    textBox_total.Text = Convert.ToString(total);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_suma_Click(object sender, EventArgs e)
        {
            try {
                double total = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    total += Convert.ToDouble(row.Cells[3].Value);
                }
                textBox_total.Text = Convert.ToString(total);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
    }
}
