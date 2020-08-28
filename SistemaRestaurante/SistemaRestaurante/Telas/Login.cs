using SistemaRestaurante.Telas;
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

namespace SistemaRestaurante
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LblSenha_Click(object sender, EventArgs e)
        {
            
        }

        private void TxtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            String conn_string = (@"Data Source=RAUL-PC;Initial Catalog=BDRESTAURANTE;Integrated Security=True");
            SqlConnection con = new SqlConnection(conn_string);
            con.Open();
            DataTable dados = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM USUARIO WHERE USUARIO=@USUARIO AND SENHA=@SENHA", con);
            da.SelectCommand.Parameters.AddWithValue("@USUARIO", TxtLogin.Text);
            da.SelectCommand.Parameters.AddWithValue("@SENHA", TxtSenha.Text);
            da.Fill(dados);
            con.Close();
            if (dados.Rows.Count == 0)
            {
                MessageBox.Show("Usuario/Senha invalidos");
            }
            else
            {
                MessageBox.Show("Seja bem vindo ao sistema!!!");
                Menuprincipal Menuprincipal = new Menuprincipal();
                Menuprincipal.Show();
                this.Hide();
            }
            TxtLogin.Text = "";
            TxtSenha.Text = "";
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                TxtSenha.UseSystemPasswordChar = false;
            }
            else
            {
                TxtSenha.UseSystemPasswordChar = true;
            }
          
        }

        private void TxtSenha_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
