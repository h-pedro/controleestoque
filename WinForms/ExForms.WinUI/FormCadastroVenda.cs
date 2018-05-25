
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
    public partial class FormCadastroVenda : Form
    {
        public Venda Venda { get; set; }

        public FormCadastroVenda()
        {
            InitializeComponent();
        }

        public FormCadastroVenda(Venda obj)
        {
            InitializeComponent();
            this.Venda = obj;
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

            if (this.Venda != null && this.Venda.Id > 0)
                new VendaDAO().Atualizar(this.Venda);
            else
                new VendaDAO().Inserir(this.Venda);

            DialogResult = DialogResult.OK;
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
