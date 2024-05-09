using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Produto
    {
        private static int next_id = 1;
        public int Id { get; set; }

        private string _Nome = "";
        public string Nome
        {
            get
            {
                return _Nome;
            }
            set
            {
                _Nome = value;
            }
        }
        public string Descricao { get; set; } = "";
        public string Categoria { get; set; } = "";
        public bool Disponivel { get; set; } = true;
        private double _Preco;
        public double Preco {
            get
            {
                return _Preco;
            }
            set //set(double value)
            {
                if (value > 0)
                    _Preco = Math.Round(value, 2);
            }
        }
        public Produto()
        {
            this.Id = Produto.next_id;
            next_id++;
        }
    }
}
