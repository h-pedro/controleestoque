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
        private Usuario Usuario { get; set; }

        public FormCadastroVenda(Usuario obj)
        {
            InitializeComponent();
            this.Usuario = obj;
        }

        public FormCadastroVenda(Venda obj, Usuario usu)
        {
            InitializeComponent();
            this.Venda = obj;
            this.Usuario = usu;
        }

        private void FormCadastroVenda_Load(object sender, EventArgs e)
        {
            CarregarTipoDePagamento();
            var obj = Venda as Venda;
            if (obj == null)
                return;
            CarregarTipoDePagamento();
            cboPagamento.SelectedValue = obj.TipoPagamento.Id;
            txtDataCadastroVenda.Value = obj.DataPagamento;
            txtClienteCadastroVenda.Text = obj.NomeCliente;
            CarregarGridView();
        }

        private void btnSalvarCadastroVenda_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            this.Venda = this.Venda ?? new Venda();
            this.Venda.TipoPagamento = new TipoPagamento() { Id = (int)cboPagamento.SelectedValue };
            this.Venda.DataPagamento = txtDataCadastroVenda.Value;
            this.Venda.NomeCliente = txtClienteCadastroVenda.Text;
            this.Venda.Usuario = this.Usuario;

            if (this.Venda != null && this.Venda.Id > 0)
            {
                //atualizando a venda no banco de dados
                new VendaDAO().Atualizar(this.Venda);

                //excluindo movimentações antigas para inserir as novas
                new MovimentacaoDAO().ExcluirPorVenda(this.Venda.Id);

                //gravando todos os itens da venda no banco de dados
                foreach (var item in this.Venda.Itens)
                {
                    item.Venda = this.Venda;

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
                        Quantidade = item.Quantidade,
                        Venda = this.Venda
                    };

                    //gravando movimentação de saída no banco de dados
                    new MovimentacaoDAO().Inserir(movEstoque);
                }
            }
            else
            {
                //gravando a venda no banco de dados
                new VendaDAO().Inserir(this.Venda);

                //gravando todos os itens da venda no banco de dados
                foreach (var item in this.Venda.Itens)
                {
                    item.Venda = this.Venda;

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
                        Quantidade = item.Quantidade,
                        Venda = this.Venda
                    };

                    //gravando movimentação de saída no banco de dados
                    new MovimentacaoDAO().Inserir(movEstoque);
                }
            }

            DialogResult = DialogResult.OK;
        }

        private void btnCancelarCadastroVenda_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var frm = new FormAddProduto();
            if (frm.ShowDialog() != DialogResult.OK)
                return;

            if (frm.Venda != null)
            {
                this.Venda = this.Venda ?? new Venda();
                foreach (var item in frm.Venda.Itens)
                {
                    var produto = new ProdutoDAO().BuscarPorId(item.Produto.Id);
                    if (item.Quantidade > produto.QtdEmEstoque)
                    {
                        MessageBox.Show(
                            string.Format("Este produto possui quantidade {0:N0} em estoque. Não é possivel adicionar este produto na quantidade {1:N0} desejada!", produto.QtdEmEstoque, item.Quantidade),
                            "Alerta",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                        continue;
                    }

                    this.Venda.Itens.Add(new ItemVenda()
                    {
                        Produto = item.Produto,
                        Valor_Unitario = item.Produto.Preco,
                        Quantidade = item.Quantidade
                    });
                }
                CarregarGridView();
            }
        }

        private void CarregarGridView()
        {
            gridView.Columns.Clear();
            AdicionarColunas();
            gridView.Rows.Clear();
            foreach (var itemVenda in this.Venda.Itens)
                InserirLinha(itemVenda);
            gridView.ClearSelection();
        }

        private void AdicionarColunas()
        {
            gridView.Columns.Add("colId", "ID", "Id", 10, true);
            gridView.Columns.Add("colProduto", "Produto", "Produto.Nome", 40, true);
            gridView.Columns.Add("colQuantidade", "Qtd", "Quantidade", 10, true);
            gridView.Columns.Add("colUnitario", "Vlr Unitário", "ValorUnitario", 20, true);
            gridView.Columns.Add("colTotal", "Total", "ValorUnitario", 20, true);

            gridView.Columns["colId"].FillWeight = 10;
            gridView.Columns["colProduto"].FillWeight = 40;
            gridView.Columns["colQuantidade"].FillWeight = 10;
            gridView.Columns["colUnitario"].FillWeight = 20;
            gridView.Columns["colTotal"].FillWeight = 20;

            gridView.Columns["colQuantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridView.Columns["colUnitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            gridView.Columns["colTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            foreach (DataGridViewColumn col in gridView.Columns)
                gridView.Columns[col.Index].ReadOnly = true;
        }

        private void InserirLinha(ItemVenda itemVenda)
        {
            gridView.EndEdit();
            gridView.Rows.Add(1);
            InserirLinha(itemVenda, gridView.Rows[gridView.Rows.Count - 1].Index);
        }

        private void InserirLinha(ItemVenda itemVenda, int rowIndex)
        {
            if (itemVenda == null)
                return;
            gridView["colId", rowIndex].Value = Venda.Id;
            gridView["colProduto", rowIndex].Value = itemVenda.Produto.Nome;
            gridView["colQuantidade", rowIndex].Value = itemVenda.Quantidade.ToString("N0");
            gridView["colUnitario", rowIndex].Value = itemVenda.Valor_Unitario.ToString("C2");
            gridView["colTotal", rowIndex].Value = (itemVenda.Quantidade * itemVenda.Valor_Unitario).ToString("C2");
            gridView.Rows[rowIndex].Tag = itemVenda;
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

            if (txtDataCadastroVenda.Value > DateTime.Now)
            {
                aux = false;
                error.SetError(txtDataCadastroVenda, "Data inválida!");
            }

            return aux;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void Excluir()
        {
            if (gridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente remover o registro selecionado?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
                var id = Convert.ToInt32(gridView.SelectedRows[0].Cells[0].Value);
                new VendaDAO().Excluir(new Venda() { Id = id });
                CarregarGridView();
            }
        }
    }
}
