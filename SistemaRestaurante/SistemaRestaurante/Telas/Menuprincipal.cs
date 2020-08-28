using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaRestaurante.Telas
{
    public partial class Menuprincipal : Form
    {
        public Menuprincipal()
        {
            InitializeComponent();
        }

        private void MnsCliente_Click(object sender, EventArgs e)
        {
            CadCliente cadcliente = new CadCliente();
            cadcliente.Show();
            this.Hide();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            
            if
                (MessageBox.Show("Deseja sair do sistema ?", "Mensagem do sistema",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login = new Login();
                this.Hide();
                login.Show();
            }


        }

        private void MnsFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadFuncionario funcionario = new CadFuncionario();
            funcionario.Show();

        }

        private void MnsProduto_Click(object sender, EventArgs e)
        {
            CadProduto produto = new CadProduto();
            produto.Show();
            this.Hide();

        }

        private void MnsPedido_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.Show();
            this.Hide();

        }

        private void Menuprincipal_Load(object sender, EventArgs e)
        {

        }

        private void MnsConsulta_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadFuncionario funcionario = new CadFuncionario();
            funcionario.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CadFuncionario funcionario = new CadFuncionario();
            funcionario.Show();
        }

        private void Mnsconsultacli_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaCli consulta = new ConsultaCli();
            consulta.Show();
        }

        private void MnsConsultaproduto_Click(object sender, EventArgs e)
        {
            this.Hide();
            ConsultaProduto produto = new ConsultaProduto();
            produto.Show();

        }

        private void MnsConsultafunc_Click(object sender, EventArgs e)
        {
            ConsultaFunc consultaFunc = new ConsultaFunc();
            consultaFunc.Show();
            this.Hide();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                    }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void MnsConsultapedido_Click(object sender, EventArgs e)
        {
            ConsultaPedido pedido = new ConsultaPedido();
            pedido.Show();
            this.Hide();

        }
    }
}
