using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class CarrinhoCompra
    {
        public double PorcentagemDesconto { get; set; }
        public double TotalCompra
        {
            get
            {
                return CalcularTotal();
            }
        }
        private List<Produto> ListaItens { get; set; }
        public bool AdicionarItem ( Produto prod )
        {
            if(prod.Disponivel == true)
            {
                ListaItens.Add(prod);
                return true;
            }
            return false;
        }
        public Boolean RemoverItem(int indexLista) 
        {
            if((indexLista < ListaItens.Count) && (indexLista >=0))
            {
                ListaItens.RemoveAt(indexLista);
                return true;
            }
            return false;
        }
        public bool RemoverItem(Produto prod) 
        {
           int index = ListaItens.FindIndex(o => o.Id == prod.Id);
            if(index >= 0)
            {
                ListaItens.RemoveAt(index);
                return true;
            }
            return false;
        }
        private double CalcularTotal()
        {
            return 0;
        }

        public CarrinhoCompra()
        {
            this.PorcentagemDesconto = 0;
            this.ListaItens = new List<Produto>();
        }
    }
}
