namespace Leitura_de_solicitação_de_cliente
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            BtnEstoquefacil = new Label();
            Btnsair = new Button();
            BtnAdicionarProduto = new Button();
            BtnConsultarEstoque = new Button();
            Btnconfiguracoes = new Button();
            SuspendLayout();
            // 
            // BtnEstoquefacil
            // 
            BtnEstoquefacil.AutoSize = true;
            BtnEstoquefacil.Font = new Font("Swis721 Cn BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEstoquefacil.Location = new Point(294, 51);
            BtnEstoquefacil.Name = "BtnEstoquefacil";
            BtnEstoquefacil.Size = new Size(150, 32);
            BtnEstoquefacil.TabIndex = 0;
            BtnEstoquefacil.Text = "Estoque Fácil";
            // 
            // Btnsair
            // 
            Btnsair.BackColor = Color.MediumSeaGreen;
            Btnsair.Location = new Point(655, 352);
            Btnsair.Name = "Btnsair";
            Btnsair.Size = new Size(75, 23);
            Btnsair.TabIndex = 2;
            Btnsair.Text = "Sair";
            Btnsair.UseVisualStyleBackColor = false;
            Btnsair.Click += button1_Click;
            // 
            // BtnAdicionarProduto
            // 
            BtnAdicionarProduto.BackColor = Color.MediumSeaGreen;
            BtnAdicionarProduto.Location = new Point(22, 113);
            BtnAdicionarProduto.Name = "BtnAdicionarProduto";
            BtnAdicionarProduto.Size = new Size(193, 23);
            BtnAdicionarProduto.TabIndex = 3;
            BtnAdicionarProduto.Text = "Adicionar Produto";
            BtnAdicionarProduto.UseVisualStyleBackColor = false;
            // 
            // BtnConsultarEstoque
            // 
            BtnConsultarEstoque.BackColor = Color.MediumSeaGreen;
            BtnConsultarEstoque.Location = new Point(22, 156);
            BtnConsultarEstoque.Name = "BtnConsultarEstoque";
            BtnConsultarEstoque.Size = new Size(188, 23);
            BtnConsultarEstoque.TabIndex = 4;
            BtnConsultarEstoque.Text = "Consultar Estoque";
            BtnConsultarEstoque.UseVisualStyleBackColor = false;
            BtnConsultarEstoque.Click += button3_Click;
            // 
            // Btnconfiguracoes
            // 
            Btnconfiguracoes.BackColor = Color.MediumSeaGreen;
            Btnconfiguracoes.Location = new Point(528, 352);
            Btnconfiguracoes.Name = "Btnconfiguracoes";
            Btnconfiguracoes.Size = new Size(111, 23);
            Btnconfiguracoes.TabIndex = 5;
            Btnconfiguracoes.Text = "Configurações";
            Btnconfiguracoes.UseVisualStyleBackColor = false;
            Btnconfiguracoes.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(742, 387);
            Controls.Add(Btnconfiguracoes);
            Controls.Add(BtnConsultarEstoque);
            Controls.Add(BtnAdicionarProduto);
            Controls.Add(Btnsair);
            Controls.Add(BtnEstoquefacil);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BtnEstoquefacil;
        private Button Btnsair;
        private Button BtnAdicionarProduto;
        private Button BtnConsultarEstoque;
        private Button Btnconfiguracoes;
    }
}
