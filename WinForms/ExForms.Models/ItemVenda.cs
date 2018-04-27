using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExForms.Models
{
    public class ItemVenda
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor_Unitáio { get; set; }
        public Venda Venda { get; set; }
         
    }
}
