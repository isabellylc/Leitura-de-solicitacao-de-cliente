namespace Leitura_de_solicitação_de_cliente
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            BtnEstoquefacil = new Label();
            BtnNomedoProduto = new Label();
            BtnCodigodoProduto = new Label();
            BtnQuantidadeemEstoque = new Label();
            BtnPrecodeVenda = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            BtnDescrecaodoProduto = new Label();
            BtnCategoria = new Label();
            textBox5 = new TextBox();
            BtnLimpar = new Button();
            BtnSalvar = new Button();
            textBox6 = new TextBox();
            SuspendLayout();
            // 
            // BtnEstoquefacil
            // 
            BtnEstoquefacil.AutoSize = true;
            BtnEstoquefacil.Font = new Font("Swis721 Cn BT", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEstoquefacil.Location = new Point(278, 0);
            BtnEstoquefacil.Name = "BtnEstoquefacil";
            BtnEstoquefacil.Size = new Size(145, 32);
            BtnEstoquefacil.TabIndex = 0;
            BtnEstoquefacil.Text = "Estoque fácil";
            // 
            // BtnNomedoProduto
            // 
            BtnNomedoProduto.AutoSize = true;
            BtnNomedoProduto.Font = new Font("Swis721 Cn BT", 14.25F);
            BtnNomedoProduto.Location = new Point(66, 29);
            BtnNomedoProduto.Name = "BtnNomedoProduto";
            BtnNomedoProduto.Size = new Size(142, 22);
            BtnNomedoProduto.TabIndex = 1;
            BtnNomedoProduto.Text = "Nome do Produto:";
            BtnNomedoProduto.Click += label2_Click;
            // 
            // BtnCodigodoProduto
            // 
            BtnCodigodoProduto.AutoSize = true;
            BtnCodigodoProduto.Font = new Font("Swis721 Cn BT", 14.25F);
            BtnCodigodoProduto.Location = new Point(66, 80);
            BtnCodigodoProduto.Name = "BtnCodigodoProduto";
            BtnCodigodoProduto.Size = new Size(151, 22);
            BtnCodigodoProduto.TabIndex = 2;
            BtnCodigodoProduto.Text = "Código do Produto:";
            // 
            // BtnQuantidadeemEstoque
            // 
            BtnQuantidadeemEstoque.AutoSize = true;
            BtnQuantidadeemEstoque.Font = new Font("Swis721 Cn BT", 14.25F);
            BtnQuantidadeemEstoque.Location = new Point(66, 131);
            BtnQuantidadeemEstoque.Name = "BtnQuantidadeemEstoque";
            BtnQuantidadeemEstoque.Size = new Size(184, 22);
            BtnQuantidadeemEstoque.TabIndex = 3;
            BtnQuantidadeemEstoque.Text = "Quantidade em Estoque:";
            // 
            // BtnPrecodeVenda
            // 
            BtnPrecodeVenda.AutoSize = true;
            BtnPrecodeVenda.Font = new Font("Swis721 Cn BT", 14.25F);
            BtnPrecodeVenda.Location = new Point(66, 182);
            BtnPrecodeVenda.Name = "BtnPrecodeVenda";
            BtnPrecodeVenda.Size = new Size(128, 22);
            BtnPrecodeVenda.TabIndex = 4;
            BtnPrecodeVenda.Text = "Preço de Venda:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(66, 207);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Inserir preço do produto:";
            textBox1.Size = new Size(593, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(66, 156);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Inserir numero do estoque disponivel do produto:";
            textBox2.Size = new Size(593, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(66, 105);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Inserir código do produto:";
            textBox3.Size = new Size(593, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(66, 54);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Inserir nome do produto:";
            textBox4.Size = new Size(593, 23);
            textBox4.TabIndex = 8;
            // 
            // BtnDescrecaodoProduto
            // 
            BtnDescrecaodoProduto.AutoSize = true;
            BtnDescrecaodoProduto.Font = new Font("Swis721 Cn BT", 14.25F);
            BtnDescrecaodoProduto.Location = new Point(66, 233);
            BtnDescrecaodoProduto.Name = "BtnDescrecaodoProduto";
            BtnDescrecaodoProduto.Size = new Size(176, 22);
            BtnDescrecaodoProduto.TabIndex = 9;
            BtnDescrecaodoProduto.Text = "Descreção do Produto:";
            // 
            // BtnCategoria
            // 
            BtnCategoria.AutoSize = true;
            BtnCategoria.Font = new Font("Swis721 Cn BT", 14.25F);
            BtnCategoria.Location = new Point(66, 284);
            BtnCategoria.Name = "BtnCategoria";
            BtnCategoria.Size = new Size(83, 22);
            BtnCategoria.TabIndex = 10;
            BtnCategoria.Text = "Categoria:";
            BtnCategoria.Click += label7_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(66, 258);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Descreva produto:";
            textBox5.Size = new Size(593, 23);
            textBox5.TabIndex = 11;
            // 
            // BtnLimpar
            // 
            BtnLimpar.BackColor = Color.Chartreuse;
            BtnLimpar.Location = new Point(677, 352);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(53, 23);
            BtnLimpar.TabIndex = 12;
            BtnLimpar.Text = "Limpar";
            BtnLimpar.UseVisualStyleBackColor = false;
            // 
            // BtnSalvar
            // 
            BtnSalvar.BackColor = Color.Chartreuse;
            BtnSalvar.Location = new Point(608, 352);
            BtnSalvar.Name = "BtnSalvar";
            BtnSalvar.Size = new Size(63, 23);
            BtnSalvar.TabIndex = 13;
            BtnSalvar.Text = "Salvar";
            BtnSalvar.UseVisualStyleBackColor = false;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(66, 309);
            textBox6.Name = "textBox6";
            textBox6.PlaceholderText = "Insira a categoria do produto:";
            textBox6.Size = new Size(593, 23);
            textBox6.TabIndex = 14;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(742, 387);
            Controls.Add(textBox6);
            Controls.Add(BtnSalvar);
            Controls.Add(BtnLimpar);
            Controls.Add(textBox5);
            Controls.Add(BtnCategoria);
            Controls.Add(BtnDescrecaodoProduto);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(BtnPrecodeVenda);
            Controls.Add(BtnQuantidadeemEstoque);
            Controls.Add(BtnCodigodoProduto);
            Controls.Add(BtnNomedoProduto);
            Controls.Add(BtnEstoquefacil);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BtnEstoquefacil;
        private Label BtnNomedoProduto;
        private Label BtnCodigodoProduto;
        private Label BtnQuantidadeemEstoque;
        private Label BtnPrecodeVenda;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label BtnDescrecaodoProduto;
        private Label BtnCategoria;
        private TextBox textBox5;
        private Button BtnLimpar;
        private Button BtnSalvar;
        private TextBox textBox6;
    }
}