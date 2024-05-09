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
    public partial class Form1 : Form
    {
        private Catalogo catalogoProduto;
        private FormProduto formProduto;
        public Form1()
        {
            InitializeComponent();
            catalogoProduto = Catalogo.getInstance();
        }

        private void Catalago_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            formProduto = new FormProduto();
            formProduto.Show();
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            List<String> ListaIds = new List<String>();
            foreach(Produto prod in catalogoProduto.ListaProdutoIndisponivel)
            {
                ListaIds.Add(prod.Id.ToString());
            }
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(ListaIds.ToArray());
            this.Refresh();
        }

        private void btn_Comprar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
           int index = Convert.ToInt32 (comboBox1.SelectedItem.ToString());
           if( catalogoProduto.ListaProdutoDisponivel.Exists(o => o.Id == index))
            {
                index = catalogoProduto.ListaProdutoDisponivel.FindIndex(o => o.Id == index);
                Produto prodEd = catalogoProduto.ListaProdutoDisponivel[index];
                formProduto = new FormProduto(prodEd);
                formProduto.Show();
            }
        }
    }
}
