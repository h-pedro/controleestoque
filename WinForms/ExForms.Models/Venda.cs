using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExForms.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime DataPagamento { get; set; }
        public string NomeCliente { get; set; }
        public TipoPagamento TipoPagamento { get; set; }
        public List<ItemVenda> Itens { get; set; }

        public Venda()
        {
            this.Itens = new List<ItemVenda>();
        }
    }
}
