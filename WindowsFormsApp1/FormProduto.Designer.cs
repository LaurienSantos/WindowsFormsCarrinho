
namespace WindowsFormsApp1
{
    partial class FormProduto
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_CadastrarProduto = new System.Windows.Forms.Button();
            this.btn_Carrinho = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxDescricao = new System.Windows.Forms.TextBox();
            this.textBoxCategoria = new System.Windows.Forms.TextBox();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.Atualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(67, 241);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(75, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Dropdown";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn_CadastrarProduto
            // 
            this.btn_CadastrarProduto.Location = new System.Drawing.Point(53, 300);
            this.btn_CadastrarProduto.Name = "btn_CadastrarProduto";
            this.btn_CadastrarProduto.Size = new System.Drawing.Size(593, 33);
            this.btn_CadastrarProduto.TabIndex = 3;
            this.btn_CadastrarProduto.Text = "Cadastrar Produto";
            this.btn_CadastrarProduto.UseVisualStyleBackColor = true;
            this.btn_CadastrarProduto.Click += new System.EventHandler(this.btn_CadastrarProduto_Click);
            // 
            // btn_Carrinho
            // 
            this.btn_Carrinho.Location = new System.Drawing.Point(53, 381);
            this.btn_Carrinho.Name = "btn_Carrinho";
            this.btn_Carrinho.Size = new System.Drawing.Size(593, 32);
            this.btn_Carrinho.TabIndex = 4;
            this.btn_Carrinho.Text = "Carrinho";
            this.btn_Carrinho.UseVisualStyleBackColor = true;
            this.btn_Carrinho.Click += new System.EventHandler(this.btn_Carrinho_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Descrição";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(97, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Preço";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(195, 53);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(405, 20);
            this.textBoxID.TabIndex = 9;
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(195, 88);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(405, 20);
            this.textBoxNome.TabIndex = 10;
            // 
            // textBoxDescricao
            // 
            this.textBoxDescricao.Location = new System.Drawing.Point(195, 124);
            this.textBoxDescricao.Name = "textBoxDescricao";
            this.textBoxDescricao.Size = new System.Drawing.Size(405, 20);
            this.textBoxDescricao.TabIndex = 11;
            // 
            // textBoxCategoria
            // 
            this.textBoxCategoria.Location = new System.Drawing.Point(195, 159);
            this.textBoxCategoria.Name = "textBoxCategoria";
            this.textBoxCategoria.Size = new System.Drawing.Size(405, 20);
            this.textBoxCategoria.TabIndex = 12;
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Location = new System.Drawing.Point(195, 200);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.Size = new System.Drawing.Size(405, 20);
            this.textBoxPreco.TabIndex = 13;
            this.textBoxPreco.Text = "0";
            // 
            // Atualizar
            // 
            this.Atualizar.Location = new System.Drawing.Point(53, 339);
            this.Atualizar.Name = "Atualizar";
            this.Atualizar.Size = new System.Drawing.Size(593, 23);
            this.Atualizar.TabIndex = 14;
            this.Atualizar.Text = "Salvar Alterações";
            this.Atualizar.UseVisualStyleBackColor = true;
            this.Atualizar.Click += new System.EventHandler(this.Atualizar_Click);
            // 
            // FormProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.Atualizar);
            this.Controls.Add(this.textBoxPreco);
            this.Controls.Add(this.textBoxCategoria);
            this.Controls.Add(this.textBoxDescricao);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Carrinho);
            this.Controls.Add(this.btn_CadastrarProduto);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Name = "FormProduto";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormProduto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btn_CadastrarProduto;
        private System.Windows.Forms.Button btn_Carrinho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxDescricao;
        private System.Windows.Forms.TextBox textBoxCategoria;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.Button Atualizar;
    }
}

