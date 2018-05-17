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
            dtpData.Value = obj.Data;
            rdbE.Checked = obj.Tipo == "E";
            rdbS.Checked = obj.Tipo == "S";
            txtQtd.Text = obj.Quantidade_Recebida;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
