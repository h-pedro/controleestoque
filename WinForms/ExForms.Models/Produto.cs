using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExForms.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Categoria Categoria { get; set; }
        public decimal Preco { get; set; }
        public string Descricao { get; set; }
        public UnidadeMedida UnidadeMedida { get; set; }

        public string NomeCategoria
        {
            get
            {
                if (this.Categoria != null)
                    return this.Categoria.Nome;
                return string.Empty;
            }
        }

        public string SiglaUM
        {
            get
            {
                if (this.UnidadeMedida != null)
                    return this.UnidadeMedida.Sigla;
                return string.Empty;
            }
        }
    }
}