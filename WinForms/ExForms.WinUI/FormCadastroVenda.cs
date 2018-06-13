using ExForms.DataAccess;
using ExForms.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExForms.WinUI
{
    public partial class FormCadastroVenda : Form
    {
        private Venda Venda { get; set; }

        public FormCadastroVenda()
        {
            InitializeComponent();
        }

        public FormCadastroVenda(Venda obj)
        {
            InitializeComponent();
            this.Venda = obj;
        }

        private void FormCadastroVenda_Load(object sender, System.EventArgs e)
        {
            CarregarTipoDePagamento();
            var obj = Venda as Venda;
            if (obj == null)
                return;
            cboPagamento.SelectedValue = obj.TipoPagamento.Id;
            txtDataCadastroVenda.Value = obj.DataPagamento;
            txtClienteCadastroVenda.Text = obj.NomeCliente;
        }

        private void btnSalvarCadastroVenda_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            this.Venda = this.Venda ?? new Venda();
            this.Venda.TipoPagamento = new TipoPagamento() { Id = (int)cboPagamento.SelectedValue };
            this.Venda.DataPagamento = txtDataCadastroVenda.Value;
            this.Venda.NomeCliente = txtClienteCadastroVenda.Text;

            //gravando a venda no banco de dados
            if (this.Venda != null && this.Venda.Id > 0)
                new VendaDAO().Atualizar(this.Venda);
            else
                new VendaDAO().Inserir(this.Venda);

            //gravando todos os itens da venda no banco de dados
            foreach (var item in this.Venda.Itens)
            {
                if (item != null && item.Id > 0)
                    new ItemVendaDAO().Atualizar(item);
                else
                    new ItemVendaDAO().Inserir(item);

                //fazendo movimentação de estoque de saída do produto
                var movEstoque = new Movimentacao()
                {
                    Data = DateTime.Now,
                    Tipo = "S",
                    Produto = item.Produto,
                    Quantidade = item.Quantidade
                };

                new MovimentacaoDAO().Inserir(movEstoque);
            }

            DialogResult = DialogResult.OK;
        }

        private void btnCancelarCadastroVenda_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProduto_Click(object sender, EventArgs e)
        {
            var frm = new FormAddProduto();
            if (frm.ShowDialog() != DialogResult.OK)
                return;

            if (frm.Venda != null)
            {
                foreach (var item in frm.Venda.Itens)
                {
                    this.Venda = this.Venda ?? new Venda();
                    this.Venda.Itens.Add(new ItemVenda()
                    {
                        Produto = item.Produto,
                        Valor_Unitario = item.Produto.Preco,
                        Quantidade = item.Quantidade
                    });
                }
            }

            gridView.AutoGenerateColumns = false;
            gridView.DataSource = this.Venda.Itens;
            gridView.ClearSelection();
        }

        private void CarregarTipoDePagamento()
        {
            var lst = new List<TipoPagamento>() { new TipoPagamento() { Nome = "-- [SELECIONE] --" } };
            lst.AddRange(new TipoPagamentoDAO().BuscarTodos());
            cboPagamento.DataSource = lst;
            cboPagamento.DisplayMember = "Nome";
            cboPagamento.ValueMember = "Id";
            cboPagamento.SelectedIndex = 0;
        }

        private bool ValidarCampos()
        {
            error.Clear();
            var aux = true;

            if (!(Convert.ToInt32(cboPagamento.SelectedValue) > 0))
            {
                aux = false;
                error.SetError(cboPagamento, "Campo obrigatório!");
            }

            if (string.IsNullOrWhiteSpace(txtClienteCadastroVenda.Text))
            {
                aux = false;
                error.SetError(txtClienteCadastroVenda, "Campo obrigatório!");
            }

            return aux;
        }
    }
}
