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
    public partial class ConsultaProduto : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=RAUL-PC;Initial Catalog=BDRESTAURANTE;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        public ConsultaProduto()
        {
            InitializeComponent();
            command.Connection = con;
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

        private void BtnBuscarProduto_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("", con);
            if (TxtBuscarProduto.Text == "")
            {                
                da.SelectCommand.CommandText = "SELECT * FROM PRODUTO";
                DataTable dt = new DataTable();
                da.Fill(dt);
                DtgProduto.DataSource = dt;
                con.Close();
            }
            else
            {
                da.SelectCommand.CommandText = "SELECT * FROM PRODUTO WHERE NOME_PRODUTO='" + TxtBuscarProduto.Text + "'";
                DataTable dt = new DataTable();
                da.Fill(dt);
                DtgProduto.DataSource = dt;
                con.Close();
            }
        }
    }
}
