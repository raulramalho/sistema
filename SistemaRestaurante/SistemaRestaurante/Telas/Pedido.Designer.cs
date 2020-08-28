namespace SistemaRestaurante.Telas
{
    partial class Pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedido));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LblCodCliente = new System.Windows.Forms.Label();
            this.LblValorPedido = new System.Windows.Forms.Label();
            this.TxtCodCliente = new System.Windows.Forms.TextBox();
            this.BtnConcluirpedido = new System.Windows.Forms.Button();
            this.BtnVoltarpedido = new System.Windows.Forms.Button();
            this.LblTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckboxTortillas = new System.Windows.Forms.CheckBox();
            this.CheckboxBurrito = new System.Windows.Forms.CheckBox();
            this.Checkboxguacamole = new System.Windows.Forms.CheckBox();
            this.CheckBoxCochinita = new System.Windows.Forms.CheckBox();
            this.CheckboxTaco = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.QtdTortilla = new System.Windows.Forms.TextBox();
            this.QtdBurrito = new System.Windows.Forms.TextBox();
            this.QtdTaco = new System.Windows.Forms.TextBox();
            this.QtdCochinita = new System.Windows.Forms.TextBox();
            this.QtdGuacamole = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(-4, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(806, 73);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(314, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "PEDIDO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblCodCliente
            // 
            this.LblCodCliente.AutoSize = true;
            this.LblCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodCliente.Location = new System.Drawing.Point(211, 96);
            this.LblCodCliente.Name = "LblCodCliente";
            this.LblCodCliente.Size = new System.Drawing.Size(103, 17);
            this.LblCodCliente.TabIndex = 4;
            this.LblCodCliente.Text = "Codigo Cliente:";
            this.LblCodCliente.Click += new System.EventHandler(this.LblCodCliente_Click);
            // 
            // LblValorPedido
            // 
            this.LblValorPedido.AutoSize = true;
            this.LblValorPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorPedido.Location = new System.Drawing.Point(211, 269);
            this.LblValorPedido.Name = "LblValorPedido";
            this.LblValorPedido.Size = new System.Drawing.Size(93, 17);
            this.LblValorPedido.TabIndex = 5;
            this.LblValorPedido.Text = "Valor Pedido:";
            this.LblValorPedido.Click += new System.EventHandler(this.LblValorPedido_Click);
            // 
            // TxtCodCliente
            // 
            this.TxtCodCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtCodCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtCodCliente.Location = new System.Drawing.Point(320, 96);
            this.TxtCodCliente.Name = "TxtCodCliente";
            this.TxtCodCliente.Size = new System.Drawing.Size(152, 20);
            this.TxtCodCliente.TabIndex = 9;
            this.TxtCodCliente.TextChanged += new System.EventHandler(this.TxtCodCliente_TextChanged);
            // 
            // BtnConcluirpedido
            // 
            this.BtnConcluirpedido.BackColor = System.Drawing.Color.Gold;
            this.BtnConcluirpedido.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConcluirpedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnConcluirpedido.Location = new System.Drawing.Point(131, 301);
            this.BtnConcluirpedido.Name = "BtnConcluirpedido";
            this.BtnConcluirpedido.Size = new System.Drawing.Size(134, 49);
            this.BtnConcluirpedido.TabIndex = 15;
            this.BtnConcluirpedido.Text = "CONCLUIR";
            this.BtnConcluirpedido.UseVisualStyleBackColor = false;
            this.BtnConcluirpedido.Click += new System.EventHandler(this.BtnConcluirpedido_Click);
            // 
            // BtnVoltarpedido
            // 
            this.BtnVoltarpedido.BackColor = System.Drawing.Color.Gold;
            this.BtnVoltarpedido.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltarpedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnVoltarpedido.Location = new System.Drawing.Point(501, 301);
            this.BtnVoltarpedido.Name = "BtnVoltarpedido";
            this.BtnVoltarpedido.Size = new System.Drawing.Size(134, 49);
            this.BtnVoltarpedido.TabIndex = 16;
            this.BtnVoltarpedido.Text = "VOLTAR";
            this.BtnVoltarpedido.UseVisualStyleBackColor = false;
            this.BtnVoltarpedido.Click += new System.EventHandler(this.BtnVoltarpedido_Click_1);
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblTotal.ForeColor = System.Drawing.Color.Gold;
            this.LblTotal.Location = new System.Drawing.Point(310, 271);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(61, 13);
            this.LblTotal.TabIndex = 18;
            this.LblTotal.Text = "                  ";
            this.LblTotal.Click += new System.EventHandler(this.LblTotal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(498, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Selecione os produtos desejados:";
            // 
            // CheckboxTortillas
            // 
            this.CheckboxTortillas.AutoSize = true;
            this.CheckboxTortillas.Location = new System.Drawing.Point(514, 122);
            this.CheckboxTortillas.Name = "CheckboxTortillas";
            this.CheckboxTortillas.Size = new System.Drawing.Size(106, 17);
            this.CheckboxTortillas.TabIndex = 20;
            this.CheckboxTortillas.Text = "Tortillas R$30,00";
            this.CheckboxTortillas.UseVisualStyleBackColor = true;
            this.CheckboxTortillas.CheckedChanged += new System.EventHandler(this.CheckboxTortillas_CheckedChanged);
            // 
            // CheckboxBurrito
            // 
            this.CheckboxBurrito.AutoSize = true;
            this.CheckboxBurrito.Location = new System.Drawing.Point(514, 145);
            this.CheckboxBurrito.Name = "CheckboxBurrito";
            this.CheckboxBurrito.Size = new System.Drawing.Size(100, 17);
            this.CheckboxBurrito.TabIndex = 21;
            this.CheckboxBurrito.Text = "Burrito R$15,00";
            this.CheckboxBurrito.UseVisualStyleBackColor = true;
            this.CheckboxBurrito.CheckedChanged += new System.EventHandler(this.CheckboxBurrito_CheckedChanged);
            // 
            // Checkboxguacamole
            // 
            this.Checkboxguacamole.AutoSize = true;
            this.Checkboxguacamole.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Checkboxguacamole.Location = new System.Drawing.Point(514, 214);
            this.Checkboxguacamole.Name = "Checkboxguacamole";
            this.Checkboxguacamole.Size = new System.Drawing.Size(124, 17);
            this.Checkboxguacamole.TabIndex = 22;
            this.Checkboxguacamole.Text = "Guacamole R$30,00";
            this.Checkboxguacamole.UseVisualStyleBackColor = false;
            this.Checkboxguacamole.CheckedChanged += new System.EventHandler(this.Checkboxguacamole_CheckedChanged);
            // 
            // CheckBoxCochinita
            // 
            this.CheckBoxCochinita.AutoSize = true;
            this.CheckBoxCochinita.Location = new System.Drawing.Point(514, 191);
            this.CheckBoxCochinita.Name = "CheckBoxCochinita";
            this.CheckBoxCochinita.Size = new System.Drawing.Size(136, 17);
            this.CheckBoxCochinita.TabIndex = 23;
            this.CheckBoxCochinita.Text = "Cochinita Pibil R$50,00";
            this.CheckBoxCochinita.UseVisualStyleBackColor = true;
            this.CheckBoxCochinita.CheckedChanged += new System.EventHandler(this.CheckBoxCochinita_CheckedChanged);
            // 
            // CheckboxTaco
            // 
            this.CheckboxTaco.AutoSize = true;
            this.CheckboxTaco.Location = new System.Drawing.Point(514, 168);
            this.CheckboxTaco.Name = "CheckboxTaco";
            this.CheckboxTaco.Size = new System.Drawing.Size(89, 17);
            this.CheckboxTaco.TabIndex = 24;
            this.CheckboxTaco.Text = "Taco R$7,00";
            this.CheckboxTaco.UseVisualStyleBackColor = true;
            this.CheckboxTaco.CheckedChanged += new System.EventHandler(this.CheckboxTaco_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(684, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Digite a Quantidade:";
            // 
            // QtdTortilla
            // 
            this.QtdTortilla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QtdTortilla.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.QtdTortilla.Location = new System.Drawing.Point(687, 122);
            this.QtdTortilla.Name = "QtdTortilla";
            this.QtdTortilla.Size = new System.Drawing.Size(21, 20);
            this.QtdTortilla.TabIndex = 28;
            this.QtdTortilla.TextChanged += new System.EventHandler(this.QtdTortilla_TextChanged);
            // 
            // QtdBurrito
            // 
            this.QtdBurrito.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QtdBurrito.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.QtdBurrito.Location = new System.Drawing.Point(687, 143);
            this.QtdBurrito.Name = "QtdBurrito";
            this.QtdBurrito.Size = new System.Drawing.Size(21, 20);
            this.QtdBurrito.TabIndex = 29;
            this.QtdBurrito.TextChanged += new System.EventHandler(this.QtdBurrito_TextChanged);
            // 
            // QtdTaco
            // 
            this.QtdTaco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QtdTaco.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.QtdTaco.Location = new System.Drawing.Point(687, 165);
            this.QtdTaco.Name = "QtdTaco";
            this.QtdTaco.Size = new System.Drawing.Size(21, 20);
            this.QtdTaco.TabIndex = 30;
            this.QtdTaco.TextChanged += new System.EventHandler(this.QtdTaco_TextChanged);
            // 
            // QtdCochinita
            // 
            this.QtdCochinita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QtdCochinita.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.QtdCochinita.Location = new System.Drawing.Point(687, 188);
            this.QtdCochinita.Name = "QtdCochinita";
            this.QtdCochinita.Size = new System.Drawing.Size(21, 20);
            this.QtdCochinita.TabIndex = 31;
            this.QtdCochinita.TextChanged += new System.EventHandler(this.QtdCochinita_TextChanged);
            // 
            // QtdGuacamole
            // 
            this.QtdGuacamole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.QtdGuacamole.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.QtdGuacamole.Location = new System.Drawing.Point(687, 214);
            this.QtdGuacamole.Name = "QtdGuacamole";
            this.QtdGuacamole.Size = new System.Drawing.Size(21, 20);
            this.QtdGuacamole.TabIndex = 32;
            this.QtdGuacamole.TextChanged += new System.EventHandler(this.QtdGuacamole_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-414, -414);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1323, 923);
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 380);
            this.Controls.Add(this.QtdGuacamole);
            this.Controls.Add(this.QtdCochinita);
            this.Controls.Add(this.QtdTaco);
            this.Controls.Add(this.QtdBurrito);
            this.Controls.Add(this.QtdTortilla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CheckboxTaco);
            this.Controls.Add(this.CheckBoxCochinita);
            this.Controls.Add(this.Checkboxguacamole);
            this.Controls.Add(this.CheckboxBurrito);
            this.Controls.Add(this.CheckboxTortillas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.BtnVoltarpedido);
            this.Controls.Add(this.BtnConcluirpedido);
            this.Controls.Add(this.TxtCodCliente);
            this.Controls.Add(this.LblValorPedido);
            this.Controls.Add(this.LblCodCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.MaximumSize = new System.Drawing.Size(808, 407);
            this.MinimumSize = new System.Drawing.Size(808, 407);
            this.Name = "Pedido";
            this.Text = "Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblCodCliente;
        private System.Windows.Forms.Label LblValorPedido;
        private System.Windows.Forms.TextBox TxtCodCliente;
        private System.Windows.Forms.Button BtnConcluirpedido;
        private System.Windows.Forms.Button BtnVoltarpedido;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CheckboxTortillas;
        private System.Windows.Forms.CheckBox CheckboxBurrito;
        private System.Windows.Forms.CheckBox Checkboxguacamole;
        private System.Windows.Forms.CheckBox CheckBoxCochinita;
        private System.Windows.Forms.CheckBox CheckboxTaco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox QtdTortilla;
        private System.Windows.Forms.TextBox QtdBurrito;
        private System.Windows.Forms.TextBox QtdTaco;
        private System.Windows.Forms.TextBox QtdCochinita;
        private System.Windows.Forms.TextBox QtdGuacamole;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}