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
    public partial class CadCliente : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=RAUL-PC;Initial Catalog=BDRESTAURANTE;Integrated Security=True");
        SqlCommand command = new SqlCommand();

        public CadCliente()
        {
            InitializeComponent();
            command.Connection=con;
        }

        private void Lbltextocadcli_Click(object sender, EventArgs e)
        {

        }

        private void BtnVoltaCli_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menuprincipal menuprincipal = new Menuprincipal();
            menuprincipal.Show();
        }

        private void BtnCadcli_Click(object sender, EventArgs e)
        {
            con.Open();
            command.CommandText = "INSERT INTO CLIENTE (NOME_CLIENTE, EMAIL, CPF) VALUES('" + Txtnomecli.Text + "','" + Txtemailcli.Text + "','" + Txtcpfcli.Text + "') " +
                "INSERT INTO ENDERECO (RUA, BAIRRO, NUMERO) VALUES('" + Txtrua.Text + "','" + Txtbairro.Text + "','" + Txtnumeroresidencial.Text + "') " +
                "INSERT INTO TELEFONE (NUMERO_CELULAR) VALUES('" + Txttelefonecli.Text + "')";            
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Cliente cadastrado com sucesso!!!");
            MessageBox.Show("Um codigo de cliente foi gerado automaticamente vá em consultar e digite o nome para conferir");
            Txtbairro.Text = "";
            Txtcpfcli.Text = "";
            Txtemailcli.Text = "";
            Txtnomecli.Text = "";
            Txtnumeroresidencial.Text = "";
            Txtrua.Text = "";
            Txttelefonecli.Text = "";





        }

        private void CadCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
