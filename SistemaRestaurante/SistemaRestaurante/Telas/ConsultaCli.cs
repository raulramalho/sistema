using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRestaurante.Telas
{
    public partial class ConsultaCli : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=RAUL-PC;Initial Catalog=BDRESTAURANTE;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        public ConsultaCli()
        {
            InitializeComponent();
            command.Connection = con;
        }

        private void Btnbuscar_Click(object sender, EventArgs e)
        {

        }

        private void Consulta_Load(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("", con);
            if (TxtnomeBuscar.Text == "")
            {
                da.SelectCommand.CommandText = "SELECT * FROM CLIENTE";
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            else
            {
                da.SelectCommand.CommandText = "SELECT * FROM CLIENTE WHERE NOME_CLIENTE='" + TxtnomeBuscar.Text + "'";
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
        }

        private void TxtnomeBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lblbuscar_Click(object sender, EventArgs e)
        {
          
        }

        private void BtnVoltarconsulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menuprincipal menu = new Menuprincipal();
            menu.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
