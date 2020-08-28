namespace SistemaRestaurante.Telas
{
    partial class Menuprincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menuprincipal));
            this.LblTextomenu = new System.Windows.Forms.Label();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.cADASTRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnsFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.MnsCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.MnsProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.MnsConsulta = new System.Windows.Forms.ToolStripMenuItem();
            this.Mnsconsultacli = new System.Windows.Forms.ToolStripMenuItem();
            this.MnsConsultafunc = new System.Windows.Forms.ToolStripMenuItem();
            this.MnsConsultaproduto = new System.Windows.Forms.ToolStripMenuItem();
            this.MnsConsultapedido = new System.Windows.Forms.ToolStripMenuItem();
            this.MnsPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Lbltextosistema = new System.Windows.Forms.Label();
            this.LbltextoDesenvolvido = new System.Windows.Forms.Label();
            this.LblVersao = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblTextomenu
            // 
            this.LblTextomenu.AutoSize = true;
            this.LblTextomenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblTextomenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTextomenu.ForeColor = System.Drawing.Color.Gold;
            this.LblTextomenu.Location = new System.Drawing.Point(611, 2);
            this.LblTextomenu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblTextomenu.Name = "LblTextomenu";
            this.LblTextomenu.Size = new System.Drawing.Size(70, 25);
            this.LblTextomenu.TabIndex = 1;
            this.LblTextomenu.Text = "MENU";
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.ForeColor = System.Drawing.Color.Gold;
            this.BtnLogout.Location = new System.Drawing.Point(967, 0);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(100, 28);
            this.BtnLogout.TabIndex = 2;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // cADASTRARToolStripMenuItem
            // 
            this.cADASTRARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnsFuncionario,
            this.MnsCliente,
            this.MnsProduto});
            this.cADASTRARToolStripMenuItem.ForeColor = System.Drawing.Color.Gold;
            this.cADASTRARToolStripMenuItem.Name = "cADASTRARToolStripMenuItem";
            this.cADASTRARToolStripMenuItem.Size = new System.Drawing.Size(114, 23);
            this.cADASTRARToolStripMenuItem.Text = "CADASTRAR";
            // 
            // MnsFuncionario
            // 
            this.MnsFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MnsFuncionario.ForeColor = System.Drawing.Color.Gold;
            this.MnsFuncionario.Name = "MnsFuncionario";
            this.MnsFuncionario.Size = new System.Drawing.Size(186, 24);
            this.MnsFuncionario.Text = "FUNCIONARIO";
            this.MnsFuncionario.Click += new System.EventHandler(this.MnsFuncionario_Click);
            // 
            // MnsCliente
            // 
            this.MnsCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MnsCliente.ForeColor = System.Drawing.Color.Gold;
            this.MnsCliente.Name = "MnsCliente";
            this.MnsCliente.Size = new System.Drawing.Size(186, 24);
            this.MnsCliente.Text = "CLIENTE";
            this.MnsCliente.Click += new System.EventHandler(this.MnsCliente_Click);
            // 
            // MnsProduto
            // 
            this.MnsProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MnsProduto.ForeColor = System.Drawing.Color.Gold;
            this.MnsProduto.Name = "MnsProduto";
            this.MnsProduto.Size = new System.Drawing.Size(186, 24);
            this.MnsProduto.Text = "PRODUTO";
            this.MnsProduto.Click += new System.EventHandler(this.MnsProduto_Click);
            // 
            // MnsConsulta
            // 
            this.MnsConsulta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mnsconsultacli,
            this.MnsConsultafunc,
            this.MnsConsultaproduto,
            this.MnsConsultapedido});
            this.MnsConsulta.ForeColor = System.Drawing.Color.Gold;
            this.MnsConsulta.Name = "MnsConsulta";
            this.MnsConsulta.Size = new System.Drawing.Size(113, 23);
            this.MnsConsulta.Text = "CONSULTAR";
            this.MnsConsulta.Click += new System.EventHandler(this.MnsConsulta_Click);
            // 
            // Mnsconsultacli
            // 
            this.Mnsconsultacli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Mnsconsultacli.ForeColor = System.Drawing.Color.Gold;
            this.Mnsconsultacli.Name = "Mnsconsultacli";
            this.Mnsconsultacli.Size = new System.Drawing.Size(195, 24);
            this.Mnsconsultacli.Text = "CLIENTE";
            this.Mnsconsultacli.Click += new System.EventHandler(this.Mnsconsultacli_Click);
            // 
            // MnsConsultafunc
            // 
            this.MnsConsultafunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MnsConsultafunc.ForeColor = System.Drawing.Color.Gold;
            this.MnsConsultafunc.Name = "MnsConsultafunc";
            this.MnsConsultafunc.Size = new System.Drawing.Size(195, 24);
            this.MnsConsultafunc.Text = "FUNCIONARIOS";
            this.MnsConsultafunc.Click += new System.EventHandler(this.MnsConsultafunc_Click);
            // 
            // MnsConsultaproduto
            // 
            this.MnsConsultaproduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MnsConsultaproduto.ForeColor = System.Drawing.Color.Gold;
            this.MnsConsultaproduto.Name = "MnsConsultaproduto";
            this.MnsConsultaproduto.Size = new System.Drawing.Size(195, 24);
            this.MnsConsultaproduto.Text = "PRODUTOS";
            this.MnsConsultaproduto.Click += new System.EventHandler(this.MnsConsultaproduto_Click);
            // 
            // MnsConsultapedido
            // 
            this.MnsConsultapedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MnsConsultapedido.ForeColor = System.Drawing.Color.Gold;
            this.MnsConsultapedido.Name = "MnsConsultapedido";
            this.MnsConsultapedido.Size = new System.Drawing.Size(195, 24);
            this.MnsConsultapedido.Text = "PEDIDOS";
            this.MnsConsultapedido.Click += new System.EventHandler(this.MnsConsultapedido_Click);
            // 
            // MnsPedido
            // 
            this.MnsPedido.ForeColor = System.Drawing.Color.Gold;
            this.MnsPedido.Name = "MnsPedido";
            this.MnsPedido.Size = new System.Drawing.Size(94, 23);
            this.MnsPedido.Text = "DELIVERY";
            this.MnsPedido.Click += new System.EventHandler(this.MnsPedido_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cADASTRARToolStripMenuItem,
            this.MnsConsulta,
            this.MnsPedido});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Lbltextosistema
            // 
            this.Lbltextosistema.AutoSize = true;
            this.Lbltextosistema.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Lbltextosistema.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltextosistema.Location = new System.Drawing.Point(336, 382);
            this.Lbltextosistema.Name = "Lbltextosistema";
            this.Lbltextosistema.Size = new System.Drawing.Size(731, 31);
            this.Lbltextosistema.TabIndex = 3;
            this.Lbltextosistema.Text = "SISTEMA DE GERENCIAMENTO DE UM RESTAURANTE";
            // 
            // LbltextoDesenvolvido
            // 
            this.LbltextoDesenvolvido.AutoSize = true;
            this.LbltextoDesenvolvido.BackColor = System.Drawing.Color.White;
            this.LbltextoDesenvolvido.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbltextoDesenvolvido.Location = new System.Drawing.Point(705, 413);
            this.LbltextoDesenvolvido.Name = "LbltextoDesenvolvido";
            this.LbltextoDesenvolvido.Size = new System.Drawing.Size(362, 29);
            this.LbltextoDesenvolvido.TabIndex = 4;
            this.LbltextoDesenvolvido.Text = "Desenvolvido por: Web Program";
            // 
            // LblVersao
            // 
            this.LblVersao.AutoSize = true;
            this.LblVersao.Location = new System.Drawing.Point(974, 493);
            this.LblVersao.Name = "LblVersao";
            this.LblVersao.Size = new System.Drawing.Size(81, 17);
            this.LblVersao.TabIndex = 5;
            this.LblVersao.Text = "Versão: 1.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(986, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Versão: 1.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-13, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1101, 478);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Menuprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1067, 468);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblVersao);
            this.Controls.Add(this.LbltextoDesenvolvido);
            this.Controls.Add(this.Lbltextosistema);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.LblTextomenu);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximumSize = new System.Drawing.Size(1075, 495);
            this.MinimumSize = new System.Drawing.Size(1075, 495);
            this.Name = "Menuprincipal";
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.Menuprincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblTextomenu;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.ToolStripMenuItem cADASTRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnsFuncionario;
        private System.Windows.Forms.ToolStripMenuItem MnsCliente;
        private System.Windows.Forms.ToolStripMenuItem MnsProduto;
        private System.Windows.Forms.ToolStripMenuItem MnsConsulta;
        private System.Windows.Forms.ToolStripMenuItem MnsPedido;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label Lbltextosistema;
        private System.Windows.Forms.Label LbltextoDesenvolvido;
        private System.Windows.Forms.Label LblVersao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem Mnsconsultacli;
        private System.Windows.Forms.ToolStripMenuItem MnsConsultafunc;
        private System.Windows.Forms.ToolStripMenuItem MnsConsultaproduto;
        private System.Windows.Forms.ToolStripMenuItem MnsConsultapedido;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}