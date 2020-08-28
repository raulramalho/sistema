namespace SistemaRestaurante.Telas
{
    partial class ConsultaPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaPedido));
            this.BtnVoltarconsulta = new System.Windows.Forms.Button();
            this.DtgPedido = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnBuscarpedido = new System.Windows.Forms.Button();
            this.TxtCodPedido = new System.Windows.Forms.TextBox();
            this.Lblbuscar = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DtgPedido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnVoltarconsulta
            // 
            this.BtnVoltarconsulta.BackColor = System.Drawing.Color.Gold;
            this.BtnVoltarconsulta.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltarconsulta.ForeColor = System.Drawing.Color.White;
            this.BtnVoltarconsulta.Location = new System.Drawing.Point(476, 384);
            this.BtnVoltarconsulta.Name = "BtnVoltarconsulta";
            this.BtnVoltarconsulta.Size = new System.Drawing.Size(131, 46);
            this.BtnVoltarconsulta.TabIndex = 20;
            this.BtnVoltarconsulta.Text = "Voltar";
            this.BtnVoltarconsulta.UseVisualStyleBackColor = false;
            this.BtnVoltarconsulta.Click += new System.EventHandler(this.BtnVoltarconsulta_Click);
            // 
            // DtgPedido
            // 
            this.DtgPedido.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DtgPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgPedido.GridColor = System.Drawing.Color.Gold;
            this.DtgPedido.Location = new System.Drawing.Point(127, 208);
            this.DtgPedido.Name = "DtgPedido";
            this.DtgPedido.Size = new System.Drawing.Size(480, 167);
            this.DtgPedido.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(299, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "CONSULTA";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-5, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(812, 76);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // BtnBuscarpedido
            // 
            this.BtnBuscarpedido.BackColor = System.Drawing.Color.Gold;
            this.BtnBuscarpedido.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarpedido.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarpedido.Location = new System.Drawing.Point(472, 156);
            this.BtnBuscarpedido.Name = "BtnBuscarpedido";
            this.BtnBuscarpedido.Size = new System.Drawing.Size(131, 46);
            this.BtnBuscarpedido.TabIndex = 16;
            this.BtnBuscarpedido.Text = "Buscar";
            this.BtnBuscarpedido.UseVisualStyleBackColor = false;
            this.BtnBuscarpedido.Click += new System.EventHandler(this.BtnBuscarpedido_Click);
            // 
            // TxtCodPedido
            // 
            this.TxtCodPedido.Location = new System.Drawing.Point(244, 170);
            this.TxtCodPedido.Name = "TxtCodPedido";
            this.TxtCodPedido.Size = new System.Drawing.Size(208, 20);
            this.TxtCodPedido.TabIndex = 15;
            // 
            // Lblbuscar
            // 
            this.Lblbuscar.AutoSize = true;
            this.Lblbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblbuscar.Location = new System.Drawing.Point(115, 171);
            this.Lblbuscar.Name = "Lblbuscar";
            this.Lblbuscar.Size = new System.Drawing.Size(123, 17);
            this.Lblbuscar.TabIndex = 14;
            this.Lblbuscar.Text = "Codigo do pedido:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-82, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(907, 442);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // ConsultaPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVoltarconsulta);
            this.Controls.Add(this.DtgPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnBuscarpedido);
            this.Controls.Add(this.TxtCodPedido);
            this.Controls.Add(this.Lblbuscar);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ConsultaPedido";
            this.Text = "ConsultaPedido";
            ((System.ComponentModel.ISupportInitialize)(this.DtgPedido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVoltarconsulta;
        private System.Windows.Forms.DataGridView DtgPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnBuscarpedido;
        private System.Windows.Forms.TextBox TxtCodPedido;
        private System.Windows.Forms.Label Lblbuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}