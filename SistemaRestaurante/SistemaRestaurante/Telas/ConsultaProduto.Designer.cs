namespace SistemaRestaurante.Telas
{
    partial class ConsultaProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaProduto));
            this.BtnVoltarconsulta = new System.Windows.Forms.Button();
            this.DtgProduto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnBuscarProduto = new System.Windows.Forms.Button();
            this.TxtBuscarProduto = new System.Windows.Forms.TextBox();
            this.Lblbuscar = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVoltarconsulta
            // 
            this.BtnVoltarconsulta.BackColor = System.Drawing.Color.Gold;
            this.BtnVoltarconsulta.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltarconsulta.ForeColor = System.Drawing.Color.White;
            this.BtnVoltarconsulta.Location = new System.Drawing.Point(481, 363);
            this.BtnVoltarconsulta.Name = "BtnVoltarconsulta";
            this.BtnVoltarconsulta.Size = new System.Drawing.Size(131, 46);
            this.BtnVoltarconsulta.TabIndex = 13;
            this.BtnVoltarconsulta.Text = "Voltar";
            this.BtnVoltarconsulta.UseVisualStyleBackColor = false;
            this.BtnVoltarconsulta.Click += new System.EventHandler(this.BtnVoltarconsulta_Click);
            // 
            // DtgProduto
            // 
            this.DtgProduto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DtgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgProduto.GridColor = System.Drawing.Color.Gold;
            this.DtgProduto.Location = new System.Drawing.Point(132, 187);
            this.DtgProduto.Name = "DtgProduto";
            this.DtgProduto.Size = new System.Drawing.Size(480, 167);
            this.DtgProduto.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(311, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "CONSULTA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-7, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(812, 76);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // BtnBuscarProduto
            // 
            this.BtnBuscarProduto.BackColor = System.Drawing.Color.Gold;
            this.BtnBuscarProduto.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarProduto.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarProduto.Location = new System.Drawing.Point(477, 135);
            this.BtnBuscarProduto.Name = "BtnBuscarProduto";
            this.BtnBuscarProduto.Size = new System.Drawing.Size(131, 46);
            this.BtnBuscarProduto.TabIndex = 9;
            this.BtnBuscarProduto.Text = "Buscar";
            this.BtnBuscarProduto.UseVisualStyleBackColor = false;
            this.BtnBuscarProduto.Click += new System.EventHandler(this.BtnBuscarProduto_Click);
            // 
            // TxtBuscarProduto
            // 
            this.TxtBuscarProduto.Location = new System.Drawing.Point(249, 149);
            this.TxtBuscarProduto.Name = "TxtBuscarProduto";
            this.TxtBuscarProduto.Size = new System.Drawing.Size(208, 20);
            this.TxtBuscarProduto.TabIndex = 8;
            // 
            // Lblbuscar
            // 
            this.Lblbuscar.AutoSize = true;
            this.Lblbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblbuscar.Location = new System.Drawing.Point(91, 150);
            this.Lblbuscar.Name = "Lblbuscar";
            this.Lblbuscar.Size = new System.Drawing.Size(152, 17);
            this.Lblbuscar.TabIndex = 7;
            this.Lblbuscar.Text = "NOME DO PRODUTO:";
            this.Lblbuscar.Click += new System.EventHandler(this.Lblbuscar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-87, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(907, 442);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // ConsultaProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVoltarconsulta);
            this.Controls.Add(this.DtgProduto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnBuscarProduto);
            this.Controls.Add(this.TxtBuscarProduto);
            this.Controls.Add(this.Lblbuscar);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ConsultaProduto";
            this.Text = "ConsultaProduto";
            ((System.ComponentModel.ISupportInitialize)(this.DtgProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVoltarconsulta;
        private System.Windows.Forms.DataGridView DtgProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnBuscarProduto;
        private System.Windows.Forms.TextBox TxtBuscarProduto;
        private System.Windows.Forms.Label Lblbuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}