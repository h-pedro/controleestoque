using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExForms.Models
{
    public class Movimentacao
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public DateTime Data { get; set; }
        public string Tipo { get; set; }
        public int Quantidade { get; set; }

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
