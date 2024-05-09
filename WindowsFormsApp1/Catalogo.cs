using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Catalogo
    {
        //Padrão de Projeto Singleton
        private static Catalogo Instance=null;
        public List<Produto> ListaProdutoDisponivel { get; }
        public List<Produto> ListaProdutoIndisponivel { get; }
        private Catalogo()
        {
            ListaProdutoDisponivel = new List<Produto>();
            ListaProdutoIndisponivel = new List<Produto>();
        }
        public static Catalogo getInstance()
        {
            if (Instance is null)
                Instance = new Catalogo();

                return Instance;
        }
    }
}
