﻿namespace BETA___BOXBALANCER
{
    partial class FrmIncluir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIncluir));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.CbParcelamento = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CbPagamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CbVendedor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CbTipo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::BETA___BOXBALANCER.Properties.Resources.BoxBalancer_removebg_preview__2_;
            this.pictureBox1.Location = new System.Drawing.Point(181, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.CbTipo);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.CbParcelamento);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CbPagamento);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CbVendedor);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TxtValor);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(107, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 469);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CbParcelamento
            // 
            this.CbParcelamento.FormattingEnabled = true;
            this.CbParcelamento.Location = new System.Drawing.Point(407, 327);
            this.CbParcelamento.Name = "CbParcelamento";
            this.CbParcelamento.Size = new System.Drawing.Size(166, 21);
            this.CbParcelamento.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(404, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 27;
            this.label5.Text = "Parcelamento";
            // 
            // CbPagamento
            // 
            this.CbPagamento.FormattingEnabled = true;
            this.CbPagamento.Location = new System.Drawing.Point(407, 275);
            this.CbPagamento.Name = "CbPagamento";
            this.CbPagamento.Size = new System.Drawing.Size(166, 21);
            this.CbPagamento.TabIndex = 26;
            this.CbPagamento.SelectedIndexChanged += new System.EventHandler(this.CbPagamento_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(404, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Forma de pagamento:";
            // 
            // CbVendedor
            // 
            this.CbVendedor.FormattingEnabled = true;
            this.CbVendedor.Location = new System.Drawing.Point(76, 215);
            this.CbVendedor.Name = "CbVendedor";
            this.CbVendedor.Size = new System.Drawing.Size(166, 21);
            this.CbVendedor.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(73, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Vendedor:";
            // 
            // TxtValor
            // 
            this.TxtValor.Font = new System.Drawing.Font("Arial", 10F);
            this.TxtValor.ForeColor = System.Drawing.Color.Black;
            this.TxtValor.Location = new System.Drawing.Point(407, 215);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(166, 23);
            this.TxtValor.TabIndex = 14;
            this.TxtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(404, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Valor:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lbl1.Location = new System.Drawing.Point(73, 256);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(125, 16);
            this.lbl1.TabIndex = 11;
            this.lbl1.Text = "Selecione o tipo:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(107, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(669, 34);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(216, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRO DE VENDAS";
            // 
            // CbTipo
            // 
            this.CbTipo.FormattingEnabled = true;
            this.CbTipo.Location = new System.Drawing.Point(76, 275);
            this.CbTipo.Name = "CbTipo";
            this.CbTipo.Size = new System.Drawing.Size(166, 21);
            this.CbTipo.TabIndex = 29;
            // 
            // FrmIncluir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 559);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIncluir";
            this.Text = "BOX BALANCER";
            this.Load += new System.EventHandler(this.FrmIncluir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbVendedor;
        private System.Windows.Forms.ComboBox CbParcelamento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CbPagamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox CbTipo;
    }
}