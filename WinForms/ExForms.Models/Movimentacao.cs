using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExForms.Models
{
    class Movimentacao
    {
        public int Id_Produto { get; set; } 
        public DateTime Data { get; set; }
        public string Tipo { get; set; }
        public string Quantidade_Recebida { get; set; }
    }
}
