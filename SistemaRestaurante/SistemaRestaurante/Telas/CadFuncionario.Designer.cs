namespace SistemaRestaurante.Telas
{
    partial class CadFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadFuncionario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbltextocadfunc = new System.Windows.Forms.Label();
            this.LblnomeFunc = new System.Windows.Forms.Label();
            this.LblemailFunc = new System.Windows.Forms.Label();
            this.LblsenhaFunc = new System.Windows.Forms.Label();
            this.TxtnomeFunc = new System.Windows.Forms.TextBox();
            this.TxtsenhaFunc = new System.Windows.Forms.TextBox();
            this.TxtemailFunc = new System.Windows.Forms.TextBox();
            this.BtnCadFunc = new System.Windows.Forms.Button();
            this.BtnVoltarfunc = new System.Windows.Forms.Button();
            this.LblUsuariofunc = new System.Windows.Forms.Label();
            this.TxtUsuariofunc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txtcpffunc = new System.Windows.Forms.MaskedTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlText;
            this.pictureBox1.Location = new System.Drawing.Point(-6, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(811, 87);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Lbltextocadfunc
            // 
            this.Lbltextocadfunc.AutoSize = true;
            this.Lbltextocadfunc.BackColor = System.Drawing.SystemColors.ControlText;
            this.Lbltextocadfunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltextocadfunc.ForeColor = System.Drawing.Color.Gold;
            this.Lbltextocadfunc.Location = new System.Drawing.Point(226, 23);
            this.Lbltextocadfunc.Name = "Lbltextocadfunc";
            this.Lbltextocadfunc.Size = new System.Drawing.Size(366, 31);
            this.Lbltextocadfunc.TabIndex = 1;
            this.Lbltextocadfunc.Text = "CADASTRO FUNCIONARIO";
            // 
            // LblnomeFunc
            // 
            this.LblnomeFunc.AutoSize = true;
            this.LblnomeFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblnomeFunc.Location = new System.Drawing.Point(192, 140);
            this.LblnomeFunc.Name = "LblnomeFunc";
            this.LblnomeFunc.Size = new System.Drawing.Size(55, 20);
            this.LblnomeFunc.TabIndex = 2;
            this.LblnomeFunc.Text = "Nome:";
            // 
            // LblemailFunc
            // 
            this.LblemailFunc.AutoSize = true;
            this.LblemailFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblemailFunc.Location = new System.Drawing.Point(195, 166);
            this.LblemailFunc.Name = "LblemailFunc";
            this.LblemailFunc.Size = new System.Drawing.Size(52, 20);
            this.LblemailFunc.TabIndex = 3;
            this.LblemailFunc.Text = "Email:";
            this.LblemailFunc.Click += new System.EventHandler(this.LblemailFunc_Click);
            // 
            // LblsenhaFunc
            // 
            this.LblsenhaFunc.AutoSize = true;
            this.LblsenhaFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblsenhaFunc.Location = new System.Drawing.Point(187, 253);
            this.LblsenhaFunc.Name = "LblsenhaFunc";
            this.LblsenhaFunc.Size = new System.Drawing.Size(60, 20);
            this.LblsenhaFunc.TabIndex = 4;
            this.LblsenhaFunc.Text = "Senha:";
            this.LblsenhaFunc.Click += new System.EventHandler(this.LblsenhaFunc_Click);
            // 
            // TxtnomeFunc
            // 
            this.TxtnomeFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtnomeFunc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtnomeFunc.Location = new System.Drawing.Point(253, 140);
            this.TxtnomeFunc.Name = "TxtnomeFunc";
            this.TxtnomeFunc.Size = new System.Drawing.Size(188, 20);
            this.TxtnomeFunc.TabIndex = 5;
            // 
            // TxtsenhaFunc
            // 
            this.TxtsenhaFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtsenhaFunc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtsenhaFunc.Location = new System.Drawing.Point(253, 255);
            this.TxtsenhaFunc.Name = "TxtsenhaFunc";
            this.TxtsenhaFunc.Size = new System.Drawing.Size(148, 20);
            this.TxtsenhaFunc.TabIndex = 6;
            this.TxtsenhaFunc.UseSystemPasswordChar = true;
            this.TxtsenhaFunc.TextChanged += new System.EventHandler(this.TxtsenhaFunc_TextChanged);
            // 
            // TxtemailFunc
            // 
            this.TxtemailFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtemailFunc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtemailFunc.Location = new System.Drawing.Point(253, 166);
            this.TxtemailFunc.Name = "TxtemailFunc";
            this.TxtemailFunc.Size = new System.Drawing.Size(212, 20);
            this.TxtemailFunc.TabIndex = 7;
            this.TxtemailFunc.TextChanged += new System.EventHandler(this.TxtemailFunc_TextChanged);
            // 
            // BtnCadFunc
            // 
            this.BtnCadFunc.BackColor = System.Drawing.Color.Gold;
            this.BtnCadFunc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCadFunc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnCadFunc.Location = new System.Drawing.Point(189, 358);
            this.BtnCadFunc.Name = "BtnCadFunc";
            this.BtnCadFunc.Size = new System.Drawing.Size(151, 56);
            this.BtnCadFunc.TabIndex = 8;
            this.BtnCadFunc.Text = "CADASTRAR";
            this.BtnCadFunc.UseVisualStyleBackColor = false;
            this.BtnCadFunc.Click += new System.EventHandler(this.BtnCadFunc_Click);
            // 
            // BtnVoltarfunc
            // 
            this.BtnVoltarfunc.BackColor = System.Drawing.Color.Gold;
            this.BtnVoltarfunc.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltarfunc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnVoltarfunc.Location = new System.Drawing.Point(400, 358);
            this.BtnVoltarfunc.Name = "BtnVoltarfunc";
            this.BtnVoltarfunc.Size = new System.Drawing.Size(151, 56);
            this.BtnVoltarfunc.TabIndex = 9;
            this.BtnVoltarfunc.Text = "VOLTAR";
            this.BtnVoltarfunc.UseVisualStyleBackColor = false;
            this.BtnVoltarfunc.Click += new System.EventHandler(this.BtnVoltarfunc_Click);
            // 
            // LblUsuariofunc
            // 
            this.LblUsuariofunc.AutoSize = true;
            this.LblUsuariofunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuariofunc.Location = new System.Drawing.Point(179, 224);
            this.LblUsuariofunc.Name = "LblUsuariofunc";
            this.LblUsuariofunc.Size = new System.Drawing.Size(68, 20);
            this.LblUsuariofunc.TabIndex = 10;
            this.LblUsuariofunc.Text = "Usuario:";
            // 
            // TxtUsuariofunc
            // 
            this.TxtUsuariofunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtUsuariofunc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtUsuariofunc.Location = new System.Drawing.Point(253, 224);
            this.TxtUsuariofunc.Name = "TxtUsuariofunc";
            this.TxtUsuariofunc.Size = new System.Drawing.Size(188, 20);
            this.TxtUsuariofunc.TabIndex = 11;
            this.TxtUsuariofunc.TextChanged += new System.EventHandler(this.TxtUsuariofunc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "CPF:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txtcpffunc
            // 
            this.Txtcpffunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Txtcpffunc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Txtcpffunc.Location = new System.Drawing.Point(253, 198);
            this.Txtcpffunc.Mask = "000.000.000-00";
            this.Txtcpffunc.Name = "Txtcpffunc";
            this.Txtcpffunc.Size = new System.Drawing.Size(100, 20);
            this.Txtcpffunc.TabIndex = 13;
            this.Txtcpffunc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Txtcpfcli_MaskInputRejected);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(407, 258);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-82, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(887, 442);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // CadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Txtcpffunc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtUsuariofunc);
            this.Controls.Add(this.LblUsuariofunc);
            this.Controls.Add(this.BtnVoltarfunc);
            this.Controls.Add(this.BtnCadFunc);
            this.Controls.Add(this.TxtemailFunc);
            this.Controls.Add(this.TxtsenhaFunc);
            this.Controls.Add(this.TxtnomeFunc);
            this.Controls.Add(this.LblsenhaFunc);
            this.Controls.Add(this.LblemailFunc);
            this.Controls.Add(this.LblnomeFunc);
            this.Controls.Add(this.Lbltextocadfunc);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.MaximumSize = new System.Drawing.Size(808, 477);
            this.MinimumSize = new System.Drawing.Size(808, 477);
            this.Name = "CadFuncionario";
            this.Text = "CadFuncionario";
            this.Load += new System.EventHandler(this.CadFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbltextocadfunc;
        private System.Windows.Forms.Label LblnomeFunc;
        private System.Windows.Forms.Label LblemailFunc;
        private System.Windows.Forms.Label LblsenhaFunc;
        private System.Windows.Forms.TextBox TxtnomeFunc;
        private System.Windows.Forms.TextBox TxtsenhaFunc;
        private System.Windows.Forms.TextBox TxtemailFunc;
        private System.Windows.Forms.Button BtnCadFunc;
        private System.Windows.Forms.Button BtnVoltarfunc;
        private System.Windows.Forms.Label LblUsuariofunc;
        private System.Windows.Forms.TextBox TxtUsuariofunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox Txtcpffunc;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}