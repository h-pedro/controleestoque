using ExForms.DataAccess;
using ExForms.Models;
using System.Windows.Forms;

namespace ExForms.WinUI
{
    public partial class FormCadastroCategoria : Form
    {
        private Categoria Categoria { get; set; }

        public FormCadastroCategoria()
        {
            InitializeComponent();
        }

        public FormCadastroCategoria(Categoria obj)
        {
            InitializeComponent();
            this.Categoria = obj;
        }

        private void FormCadastroCategoria_Load(object sender, System.EventArgs e)
        {
            var obj = Categoria as Categoria;
            if (obj == null)
                return;
            txtNome.Text = obj.Nome;
            txtDescricao.Text = obj.Descricao;
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            if (!ValidarCampos())
                return;

            this.Categoria = this.Categoria ?? new Categoria();
            this.Categoria.Nome = txtNome.Text;
            this.Categoria.Descricao = txtDescricao.Text;

            if (this.Categoria != null && this.Categoria.Id > 0)
                new CategoriaDAO().Atualizar(this.Categoria);
            else
                new CategoriaDAO().Inserir(this.Categoria);

            DialogResult = DialogResult.OK;
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
            return aux;
        }
    }
}