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
        public Usuario Usuario { get; set; }
        public List<ItemVenda> Itens { get; set; }

        public string TipoDePagamento
        {
            get
            {
                if (this.TipoPagamento != null)
                    return this.TipoPagamento.Nome;
                return string.Empty;
            }
        }

        public int QuantidadeDeItens
        {
            get
            {
                return this.Itens.Count;
            }
        }

        public decimal ValorTotal
        {
            get
            {
                return this.Itens.Sum(item => item.Valor_Unitario * item.Quantidade);
            }
        }

        public Venda()
        {
            this.Itens = new List<ItemVenda>();
        }
    }
}
