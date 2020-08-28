namespace SistemaRestaurante.Telas
{
    partial class CadProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadProduto));
            this.LblNomeProduto = new System.Windows.Forms.Label();
            this.LblValorProduto = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNomeproduto = new System.Windows.Forms.TextBox();
            this.TxtValorProduto = new System.Windows.Forms.TextBox();
            this.BtnCadproduto = new System.Windows.Forms.Button();
            this.BtnVoltarProduto = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LblNomeProduto
            // 
            this.LblNomeProduto.AutoSize = true;
            this.LblNomeProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeProduto.Location = new System.Drawing.Point(158, 192);
            this.LblNomeProduto.Name = "LblNomeProduto";
            this.LblNomeProduto.Size = new System.Drawing.Size(115, 20);
            this.LblNomeProduto.TabIndex = 0;
            this.LblNomeProduto.Text = "Nome Produto:";
            // 
            // LblValorProduto
            // 
            this.LblValorProduto.AutoSize = true;
            this.LblValorProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorProduto.Location = new System.Drawing.Point(163, 229);
            this.LblValorProduto.Name = "LblValorProduto";
            this.LblValorProduto.Size = new System.Drawing.Size(110, 20);
            this.LblValorProduto.TabIndex = 1;
            this.LblValorProduto.Text = "Valor Produto:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(812, 84);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(232, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "CADASTRO PRODUTO";
            // 
            // TxtNomeproduto
            // 
            this.TxtNomeproduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtNomeproduto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtNomeproduto.Location = new System.Drawing.Point(278, 192);
            this.TxtNomeproduto.Name = "TxtNomeproduto";
            this.TxtNomeproduto.Size = new System.Drawing.Size(229, 20);
            this.TxtNomeproduto.TabIndex = 4;
            // 
            // TxtValorProduto
            // 
            this.TxtValorProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtValorProduto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtValorProduto.Location = new System.Drawing.Point(279, 229);
            this.TxtValorProduto.Name = "TxtValorProduto";
            this.TxtValorProduto.Size = new System.Drawing.Size(229, 20);
            this.TxtValorProduto.TabIndex = 5;
            // 
            // BtnCadproduto
            // 
            this.BtnCadproduto.BackColor = System.Drawing.Color.Gold;
            this.BtnCadproduto.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadproduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCadproduto.Location = new System.Drawing.Point(212, 306);
            this.BtnCadproduto.Name = "BtnCadproduto";
            this.BtnCadproduto.Size = new System.Drawing.Size(134, 49);
            this.BtnCadproduto.TabIndex = 14;
            this.BtnCadproduto.Text = "CADASTRAR";
            this.BtnCadproduto.UseVisualStyleBackColor = false;
            this.BtnCadproduto.Click += new System.EventHandler(this.BtnCadproduto_Click);
            // 
            // BtnVoltarProduto
            // 
            this.BtnVoltarProduto.BackColor = System.Drawing.Color.Gold;
            this.BtnVoltarProduto.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltarProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnVoltarProduto.Location = new System.Drawing.Point(406, 306);
            this.BtnVoltarProduto.Name = "BtnVoltarProduto";
            this.BtnVoltarProduto.Size = new System.Drawing.Size(134, 49);
            this.BtnVoltarProduto.TabIndex = 15;
            this.BtnVoltarProduto.Text = "Voltar";
            this.BtnVoltarProduto.UseVisualStyleBackColor = false;
            this.BtnVoltarProduto.Click += new System.EventHandler(this.BtnVoltarProduto_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-69, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(887, 442);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // CadProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 380);
            this.Controls.Add(this.BtnVoltarProduto);
            this.Controls.Add(this.BtnCadproduto);
            this.Controls.Add(this.TxtValorProduto);
            this.Controls.Add(this.TxtNomeproduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LblValorProduto);
            this.Controls.Add(this.LblNomeProduto);
            this.Controls.Add(this.pictureBox2);
            this.MaximumSize = new System.Drawing.Size(808, 407);
            this.MinimumSize = new System.Drawing.Size(808, 407);
            this.Name = "CadProduto";
            this.Text = "CadProduto";
            this.Load += new System.EventHandler(this.CadProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNomeProduto;
        private System.Windows.Forms.Label LblValorProduto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNomeproduto;
        private System.Windows.Forms.TextBox TxtValorProduto;
        private System.Windows.Forms.Button BtnCadproduto;
        private System.Windows.Forms.Button BtnVoltarProduto;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}