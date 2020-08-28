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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            prbarSplash.Maximum = 140;
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (prbarSplash.Value < 140)
            {
                prbarSplash.Value = prbarSplash.Value + 2;


            }
            else
            {
                timer1.Stop();
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }
    }
}
