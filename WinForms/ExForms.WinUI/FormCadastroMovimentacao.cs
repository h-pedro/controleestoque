using ExForms.DataAccess;
using ExForms.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExForms.WinUI
{
    public partial class FormCadastroMovimentacao : Form
    {
        public Movimentacao Movimentacao { get; set; }

        public FormCadastroMovimentacao()
        {
            InitializeComponent();
        }

        public FormCadastroMovimentacao(Movimentacao obj)
        {
            InitializeComponent();
            this.Movimentacao = obj;
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

        private void FormCadastroMovimentacao_Load(object sender, System.EventArgs e)
        {
            CarregarProdutos();
            var obj = Movimentacao as Movimentacao;
            if (obj == null)
                return;
            cboProduto.SelectedValue = obj.Produto.Id;
            txtData.Value = obj.Data;
            rdbE.Checked = obj.Tipo == "E";
            rdbS.Checked = obj.Tipo == "S";
            txtQuantidade.Text = string.Format("{0:N0}", obj.Quantidade);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            this.Movimentacao = this.Movimentacao ?? new Movimentacao();
            this.Movimentacao.Produto = new Produto() { Id = (int)cboProduto.SelectedValue };
            this.Movimentacao.Data = txtData.Value;
            this.Movimentacao.Tipo = rdbE.Checked ? "E" : "S";
            this.Movimentacao.Quantidade = !string.IsNullOrWhiteSpace(txtQuantidade.Text) ? Convert.ToInt32(txtQuantidade.Text) : 0;

            if (this.Movimentacao != null && this.Movimentacao.Id > 0)
                new MovimentacaoDAO().Atualizar(this.Movimentacao);
            else
                new MovimentacaoDAO().Inserir(this.Movimentacao);

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

            return aux;
        }
    }
}
