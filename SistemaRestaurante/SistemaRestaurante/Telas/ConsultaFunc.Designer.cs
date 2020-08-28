namespace SistemaRestaurante.Telas
{
    partial class ConsultaFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaFunc));
            this.BtnVoltarconsulta = new System.Windows.Forms.Button();
            this.dataGridViewfunc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnBuscarfunc = new System.Windows.Forms.Button();
            this.TxtnomeBuscarfunc = new System.Windows.Forms.TextBox();
            this.Lblbuscar = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfunc)).BeginInit();
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
            // dataGridViewfunc
            // 
            this.dataGridViewfunc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridViewfunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewfunc.GridColor = System.Drawing.Color.Gold;
            this.dataGridViewfunc.Location = new System.Drawing.Point(132, 187);
            this.dataGridViewfunc.Name = "dataGridViewfunc";
            this.dataGridViewfunc.Size = new System.Drawing.Size(480, 167);
            this.dataGridViewfunc.TabIndex = 12;
            this.dataGridViewfunc.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewfunc_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(303, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "CONSULTA";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(812, 76);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BtnBuscarfunc
            // 
            this.BtnBuscarfunc.BackColor = System.Drawing.Color.Gold;
            this.BtnBuscarfunc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarfunc.ForeColor = System.Drawing.Color.White;
            this.BtnBuscarfunc.Location = new System.Drawing.Point(477, 135);
            this.BtnBuscarfunc.Name = "BtnBuscarfunc";
            this.BtnBuscarfunc.Size = new System.Drawing.Size(131, 46);
            this.BtnBuscarfunc.TabIndex = 9;
            this.BtnBuscarfunc.Text = "Buscar";
            this.BtnBuscarfunc.UseVisualStyleBackColor = false;
            this.BtnBuscarfunc.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // TxtnomeBuscarfunc
            // 
            this.TxtnomeBuscarfunc.Location = new System.Drawing.Point(249, 149);
            this.TxtnomeBuscarfunc.Name = "TxtnomeBuscarfunc";
            this.TxtnomeBuscarfunc.Size = new System.Drawing.Size(208, 20);
            this.TxtnomeBuscarfunc.TabIndex = 8;
            this.TxtnomeBuscarfunc.TextChanged += new System.EventHandler(this.TxtnomeBuscarfunc_TextChanged);
            // 
            // Lblbuscar
            // 
            this.Lblbuscar.AutoSize = true;
            this.Lblbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lblbuscar.Location = new System.Drawing.Point(92, 149);
            this.Lblbuscar.Name = "Lblbuscar";
            this.Lblbuscar.Size = new System.Drawing.Size(151, 17);
            this.Lblbuscar.TabIndex = 7;
            this.Lblbuscar.Text = "NOME FUNCIONARIO:";
            this.Lblbuscar.Click += new System.EventHandler(this.Lblbuscar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-73, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(907, 442);
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // ConsultaFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVoltarconsulta);
            this.Controls.Add(this.dataGridViewfunc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnBuscarfunc);
            this.Controls.Add(this.TxtnomeBuscarfunc);
            this.Controls.Add(this.Lblbuscar);
            this.Controls.Add(this.pictureBox2);
            this.Name = "ConsultaFunc";
            this.Text = "ConsultaFunc";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnVoltarconsulta;
        private System.Windows.Forms.DataGridView dataGridViewfunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnBuscarfunc;
        private System.Windows.Forms.TextBox TxtnomeBuscarfunc;
        private System.Windows.Forms.Label Lblbuscar;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}