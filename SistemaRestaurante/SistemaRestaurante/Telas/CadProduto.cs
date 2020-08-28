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
    public partial class CadProduto : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=RAUL-PC;Initial Catalog=BDRESTAURANTE;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        public CadProduto()
        {
            InitializeComponent();
            command.Connection = con;
        }

        private void BtnVoltarProduto_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menuprincipal menu = new Menuprincipal();
            menu.Show();

        }

        private void BtnCadproduto_Click(object sender, EventArgs e)
        {
            con.Open();
            float valorproduto = float.Parse(TxtValorProduto.Text);
            command.CommandText = "INSERT INTO PRODUTO (NOME_PRODUTO , VALOR_PRODUTO) VALUES ('" + TxtNomeproduto.Text + "','" + valorproduto + "')";
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Produto Cadastrado com sucesso");
            TxtNomeproduto.Text = "";
            TxtValorProduto.Text = "";
        }

        private void CadProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
