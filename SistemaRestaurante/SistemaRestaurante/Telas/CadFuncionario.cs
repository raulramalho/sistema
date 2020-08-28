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
    public partial class CadFuncionario : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=RAUL-PC;Initial Catalog=BDRESTAURANTE;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        public CadFuncionario()
        {
            InitializeComponent();
            command.Connection = con;
            
        }

        private void BtnVoltarfunc_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menuprincipal menu = new Menuprincipal();
            menu.Show();

        }

        private void CadFuncionario_Load(object sender, EventArgs e)
        {

        }

        private void BtnCadFunc_Click(object sender, EventArgs e)
        {
            if (TxtnomeFunc.Text == "")
            {
                MessageBox.Show("Um ou mais campos não foram preenchidos");
            }
            else
            {
                con.Open();
                command.CommandText = "INSERT INTO FUNCIONARIO(NOME_FUNCIONARIO, EMAIL, CPF) VALUES('" + TxtnomeFunc.Text + "','" + TxtemailFunc.Text + "','" + Txtcpffunc.Text + "')" +
                    "INSERT INTO USUARIO(USUARIO , SENHA) VALUES('" + TxtUsuariofunc.Text + "','" + TxtsenhaFunc.Text + "')";
                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Funcionario cadastrado com sucesso!!!");
                Txtcpffunc.Text = "";
                TxtemailFunc.Text = "";
                TxtnomeFunc.Text = "";
                TxtsenhaFunc.Text = "";
                TxtUsuariofunc.Text = "";
            }

        }

        private void TxtemailFunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblsenhaFunc_Click(object sender, EventArgs e)
        {

        }

        private void TxtsenhaFunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtUsuariofunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblemailFunc_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Txtcpfcli_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                TxtsenhaFunc.UseSystemPasswordChar = false;
            }
            else
            {
                TxtsenhaFunc.UseSystemPasswordChar = true;
            }
        }
    }
}
