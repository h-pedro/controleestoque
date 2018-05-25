using ExForms.DataAccess;
using ExForms.Models;
using System.Windows.Forms;

namespace ExForms.WinUI
{
    public partial class FormCadastroPagamento : Form
    {
        private TipoPagamento TipoPagamento { get; set; }

        public FormCadastroPagamento()
        {
            InitializeComponent();
        }

        public FormCadastroPagamento(TipoPagamento obj)
        {
            InitializeComponent();
            this.TipoPagamento = obj;
        }

        private void FormCadastroPagamento_Load(object sender, System.EventArgs e)
        {
            var obj = TipoPagamento as TipoPagamento;
            if (obj == null)
                return;
            txtNome.Text = obj.Nome;
            txtDescricao.Text = obj.Descricao;
        }

        private void btnCancelarr_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            if (!ValidarCampos())
                return;

            this.TipoPagamento = this.TipoPagamento ?? new TipoPagamento();
            this.TipoPagamento.Nome = txtNome.Text;
            this.TipoPagamento.Descricao = txtDescricao.Text;

            if (this.TipoPagamento != null && this.TipoPagamento.Id > 0)
                new TipoPagamentoDAO().Atualizar(this.TipoPagamento);
            else
                new TipoPagamentoDAO().Inserir(this.TipoPagamento);

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
