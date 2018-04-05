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
    public partial class FormCadastroProduto : Form
    {
        public Produto Produto { get; set; }

        public FormCadastroProduto()
        {
            InitializeComponent();
        }

        public FormCadastroProduto(Produto obj)
        {
            InitializeComponent();
            this.Produto = obj;
        }

        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {
            CarregarCategorias();
            var obj = Produto as Produto;
            if (obj == null)
                return;
            txtNome.Text = obj.Nome;
            cboCategoria.SelectedValue = obj.Categoria.Id;
            txtPreco.Text = string.Format("{0:N2}", obj.Preco);
            txtDescricao.Text = obj.Descricao;
        }

        private void CarregarCategorias()
        {
            var lst = new List<Categoria>() { new Categoria() { Nome = "-- [SELECIONE] --" } };
            lst.AddRange(new CategoriaDAO().BuscarTodos());
            cboCategoria.DataSource = lst;
            cboCategoria.DisplayMember = "Nome";
            cboCategoria.ValueMember = "Id";
            cboCategoria.SelectedIndex = 0;
        }

        private bool ValidarCampos()
        {
            error.Clear();
            var aux = true;

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                aux = false;
                error.SetError(txtNome, "Campo obrigatório!");
            }

            if (string.IsNullOrWhiteSpace(txtPreco.Text))
            {
                aux = false;
                error.SetError(txtPreco, "Campo obrigatório!");
            }

            if (!(Convert.ToInt32(cboCategoria.SelectedValue) > 0))
            {
                aux = false;
                error.SetError(cboCategoria, "Campo obrigatório!");
            }

            return aux;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
                return;

            this.Produto = this.Produto ?? new Produto();
            this.Produto.Nome = txtNome.Text;
            this.Produto.Categoria = new Categoria() { Id = Convert.ToInt32(cboCategoria.SelectedValue) };
            this.Produto.Preco = Convert.ToDecimal(txtPreco.Text);
            this.Produto.Descricao = txtDescricao.Text;

            if (this.Produto != null && this.Produto.Id > 0)
                new ProdutoDAO().Atualizar(this.Produto);
            else
                new ProdutoDAO().Inserir(this.Produto);

            DialogResult = DialogResult.OK;
        }
    }
}
