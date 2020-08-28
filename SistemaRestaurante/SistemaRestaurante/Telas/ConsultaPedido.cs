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
    

    public partial class ConsultaPedido : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=RAUL-PC;Initial Catalog=BDRESTAURANTE;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        public ConsultaPedido()
        {
            InitializeComponent();
            command.Connection = con;
        }

        private void BtnBuscarpedido_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("",con);
            if (TxtCodPedido.Text == "")
            {
                da.SelectCommand.CommandText = "SELECT * FROM DELIVERY";
                DataTable dt = new DataTable();
                da.Fill(dt);
                DtgPedido.DataSource = dt;
                con.Close();
            }

            else
            {
                da.SelectCommand.CommandText = "SELECT * FROM DELIVERY WHERE CODIGO_DELIVERY='" + TxtCodPedido.Text + "'";
                DataTable dt = new DataTable();
                da.Fill(dt);
                DtgPedido.DataSource = dt;
                con.Close();
            }


        }

        private void BtnVoltarconsulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menuprincipal menu = new Menuprincipal();
            menu.Show();
        }
    }
}
