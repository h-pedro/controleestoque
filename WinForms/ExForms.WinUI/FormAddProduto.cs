using ExForms.DataAccess;
using ExForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExForms.WinUI
{
    public partial class FormAddProduto : Form
    {
        private Produto Produto { get; set; }

        public FormAddProduto()
        {
            InitializeComponent();
        }
        
        private void FormAddProduto_Load(object sender, System.EventArgs e)
        {
            var obj = Produto as Produto;
            if (obj == null)
                return;
            txtAddProduto.Text = obj.Nome;
            txtAddQTD.Text = string.Format("{0:N0}", obj.QtdEmEstoque);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            this.Produto = this.Produto ?? new Produto();
            this.Produto.Nome = txtAddProduto.Text;
            this.Produto.QtdEmEstoque = !string.IsNullOrWhiteSpace(txtAddQTD.Text) ? Convert.ToInt32(txtAddQTD.Text) : 0;
            if (this.Produto != null && this.Produto.Id > 0)
                new ProdutoDAO().Atualizar(this.Produto);
            else
                new ProdutoDAO().Inserir(this.Produto);

            DialogResult = DialogResult.OK;
        }

        private bool ValidarCampos()
        {
            error.Clear();
            var aux = true;
            if (string.IsNullOrWhiteSpace(txtAddProduto.Text))
            {
                aux = false;
                error.SetError(txtAddProduto, "Campo obrigatório!");
            }
            return aux;
        }
    }
}
