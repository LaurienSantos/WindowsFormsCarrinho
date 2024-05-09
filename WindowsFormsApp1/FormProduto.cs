using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormProduto : Form
    {
        private bool IsDisponivel;
        private Catalogo catalogo;
        public Produto ProdutoEdicao { get; set; }
        public FormProduto()
        {
            InitializeComponent();
            catalogo = Catalogo.getInstance();
            ProdutoEdicao = new Produto();
            this.textBoxID.Enabled = false; // para não deixar editar o campo id
            this.AtualizarProduto();
        
        }

        public FormProduto(Produto prod)
        {
            InitializeComponent();
            catalogo = Catalogo.getInstance();
            ProdutoEdicao = prod;
            this.IsDisponivel = prod.Disponivel;
            this.textBoxID.Enabled = false; // para não deixar editar o campo id
            this.AtualizarProduto();
           
        }
        public void AtualizaDados()
        {
            this.textBoxID.Text = ""+ProdutoEdicao.Id; //textBoxID
            this.textBoxNome.Text = ProdutoEdicao.Nome;
            this.textBoxDescricao.Text = ProdutoEdicao.Descricao;
            this.textBoxCategoria.Text = ProdutoEdicao.Categoria;
            this.textBoxPreco.Text = ProdutoEdicao.Preco.ToString();
            if (ProdutoEdicao.Disponivel)
                this.checkBox1.Checked = true;
            else
                this.checkBox1.Checked = false;
        }

        public void AtualizarProduto()
        {
            ProdutoEdicao.Nome = textBoxNome.Text;
            ProdutoEdicao.Preco = Convert.ToDouble(textBoxPreco.Text);
            ProdutoEdicao.Descricao = textBoxDescricao.Text;
            ProdutoEdicao.Categoria = textBoxCategoria.Text;
            if (checkBox1.Checked)
                ProdutoEdicao.Disponivel = true;
            else
                ProdutoEdicao.Disponivel = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormProduto_Load(object sender, EventArgs e)
        {

        }

        private void btn_CadastrarProduto_Click(object sender, EventArgs e)
        {
            AtualizarProduto();
            if (ProdutoEdicao.Disponivel)
            {
                catalogo.ListaProdutoDisponivel.Add(ProdutoEdicao);
                MessageBox.Show("Produto Cadastrado com Sucesso");
                this.Close();
            }
            else
            {
                int index = catalogo.ListaProdutoDisponivel.FindIndex(o => o.Id == ProdutoEdicao.Id);
                    if (index >= 0)
                    catalogo.ListaProdutoDisponivel.RemoveAt(index);

                catalogo.ListaProdutoIndisponivel.Add(ProdutoEdicao);
                MessageBox.Show("Produto Marcado como Ondisponivel");
                this.Close();
            }
        }

        private void btn_Carrinho_Click(object sender, EventArgs e)
        {

        }

        private void Atualizar_Click(object sender, EventArgs e)
        {
            AtualizarProduto();
            if(this.IsDisponivel != ProdutoEdicao.Disponivel)
            {
                if (ProdutoEdicao.Disponivel)
                {
                    int index = catalogo.ListaProdutoDisponivel.FindIndex(o => o.Id == ProdutoEdicao.Id);
                    if (index >= 0)
                        catalogo.ListaProdutoDisponivel.RemoveAt(index);

                    catalogo.ListaProdutoIndisponivel.Add(ProdutoEdicao);
                
                }
                else
                {
                    int index = catalogo.ListaProdutoIndisponivel.FindIndex(o => o.Id == ProdutoEdicao.Id);
                    if (index >= 0)
                        catalogo.ListaProdutoIndisponivel.RemoveAt(index);

                    catalogo.ListaProdutoDisponivel.Add(ProdutoEdicao);
                  
                }
                MessageBox.Show("Produto Atualizado");
                this.Close();
            }
        }
    }
}
