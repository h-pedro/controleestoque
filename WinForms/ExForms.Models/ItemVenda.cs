using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExForms.Models
{
    public class ItemVenda
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor_Unitario { get; set; }
        public Venda Venda { get; set; }

        public string NomeProduto
        {
            get
            {
                if (this.Produto != null)
                    return this.Produto.Nome;
                return string.Empty;
            }
        }
    }
}
