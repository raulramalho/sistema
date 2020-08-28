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
    public partial class Pedido : Form
    {
        float total = 0;
        SqlConnection con = new SqlConnection(@"Data Source=RAUL-PC;Initial Catalog=BDRESTAURANTE;Integrated Security=True");
        SqlCommand command = new SqlCommand();
        public Pedido()
        {
            InitializeComponent();
            command.Connection = con;
        }

#pragma warning disable IDE1006 // Estilos de Nomenclatura
        private void label1_Click(object sender, EventArgs e)
#pragma warning restore IDE1006 // Estilos de Nomenclatura
        {

        }

        private void LblCodProduto_Click(object sender, EventArgs e)
        {

        }

        private void BtnVoltarpedido_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menuprincipal menu = new Menuprincipal();
            menu.Show();


        }

        private void BtnVoltarpedido_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Menuprincipal menu = new Menuprincipal();
            menu.Show();

        }

        private void BtnConcluirpedido_Click(object sender, EventArgs e)
        {
            int cod_pedido, cod_cli;            
            cod_cli = int.Parse(TxtCodCliente.Text);
            con.Open();
            command.CommandText = "INSERT INTO DELIVERY(CODIGO_CLIENTE ,VALOR_TOTAL) VALUES('" + cod_cli + "','" + total + "')";
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Pedido Realizado com sucesso!!!");
        }

        private void LblCodCliente_Click(object sender, EventArgs e)
        {

        }

        private void TxtCodCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtQuantidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void LblValorPedido_Click(object sender, EventArgs e)
        {

        }

        private void CheckListProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Checkboxguacamole_CheckedChanged(object sender, EventArgs e)
        {
            if (Checkboxguacamole.Checked == true)
            {
                total += 30;
                LblTotal.Text = total.ToString();
            }
            else
            {
                total -= 30;
                LblTotal.Text = total.ToString();
            }

        }

        private void LblTotal_Click(object sender, EventArgs e)
        {
            
           
          
         
         

        }

        private void CheckboxTortillas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckboxTortillas.Checked == true)
            {
                total += 30;
                LblTotal.Text = total.ToString();
            }
            else
            {
                total -= 30;
                LblTotal.Text = total.ToString();
            }

        }

        private void CheckboxBurrito_CheckedChanged(object sender, EventArgs e)
        {
            LblTotal.Text="";
            if (CheckboxBurrito.Checked == true)
            {
                total += 15;
                LblTotal.Text = total.ToString();
            }
            else
            {
                
                total -= 15;                
                LblTotal.Text = total.ToString();
            }
        }

        private void CheckBoxCochinita_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxCochinita.Checked == true)
            {
                total += 50;
                LblTotal.Text = total.ToString();
            }
            else
            {
                total -= 50;
                LblTotal.Text = total.ToString();
            }
        }

        private void CheckboxTaco_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckboxTaco.Checked == true)
            {
                total +=7;
                LblTotal.Text = total.ToString();
            }
            else
            {
                total -= 7;
                LblTotal.Text = total.ToString();
            }
        }

        private void QtdTortilla_TextChanged(object sender, EventArgs e)
        {
            float tortilla = 0;

            tortilla = float.Parse(QtdTortilla.Text);
            total = total * tortilla;
            LblTotal.Text = total.ToString();
        }

        private void QtdBurrito_TextChanged(object sender, EventArgs e)
        {
            float burrito = 0;

            burrito = float.Parse(QtdBurrito.Text);
            total = total * burrito;
            LblTotal.Text = total.ToString();
        }

        private void QtdTaco_TextChanged(object sender, EventArgs e)
        {
            float taco = 0;

            taco = float.Parse(QtdTaco.Text);
            total = total * taco;
            LblTotal.Text = total.ToString();
        }

        private void QtdCochinita_TextChanged(object sender, EventArgs e)
        {
            float cochinita = 0;
            cochinita = float.Parse(QtdCochinita.Text);
            total = total * cochinita;
            LblTotal.Text = total.ToString();
        }

        private void QtdGuacamole_TextChanged(object sender, EventArgs e)
        {
            float guacamole = 0;

            guacamole = float.Parse(QtdGuacamole.Text);
            total = total * guacamole;
            LblTotal.Text = total.ToString();
        }

        private void TxtCodpedido_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
