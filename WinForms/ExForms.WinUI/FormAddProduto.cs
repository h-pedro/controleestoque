using ExForms.DataAccess;
using ExForms.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExForms.WinUI
{
    public partial class FormAddProduto : Form
    {
        public Venda Venda { get; set; }

        public FormAddProduto()
        {
            InitializeComponent();
        }

        private void FormAddProduto_Load(object sender, System.EventArgs e)
        {
            CarregarProdutos();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            var p = new ProdutoDAO().BuscarPorId(Convert.ToInt32(cboProduto.SelectedValue));

            this.Venda = this.Venda ?? new Venda();
            this.Venda.Itens.Add(new ItemVenda()
            {
                Produto = p,
                Valor_Unitario = p.Preco,
                Quantidade = Convert.ToInt32(txtQuantidade.Text)
            });

            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarCampos()
        {
            error.Clear();
            var aux = true;

            if (!(Convert.ToInt32(cboProduto.SelectedValue) > 0))
            {
                aux = false;
                error.SetError(cboProduto, "Campo obrigatório!");
            }

            if (string.IsNullOrWhiteSpace(txtQuantidade.Text))
            {
                aux = false;
                error.SetError(txtQuantidade, "Campo obrigatório!");
            }

            if (!(Convert.ToInt32(txtQuantidade.Text) > 0))
            {
                aux = false;
                error.SetError(txtQuantidade, "Campo quantidade deve ser maior que zero!");
            }

            return aux;
        }

        private void CarregarProdutos()
        {
            var lst = new List<Produto>() { new Produto() { Nome = "-- [SELECIONE] --" } };
            lst.AddRange(new ProdutoDAO().BuscarTodos());
            cboProduto.DataSource = lst;
            cboProduto.DisplayMember = "Nome";
            cboProduto.ValueMember = "Id";
            cboProduto.SelectedIndex = 0;
        }
    }
}
