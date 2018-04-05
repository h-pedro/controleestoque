using ExForms.DataAccess;
using ExForms.Models;
using System.Windows.Forms;

namespace ExForms.WinUI
{
    public partial class FormCadastroUsuario : Form
    {
        private Usuario Usuario { get; set; }

        public FormCadastroUsuario()
        {
            InitializeComponent();
        }

        public FormCadastroUsuario(Usuario obj)
        {
            InitializeComponent();
            this.Usuario = obj;
        }

        private void FormCadastroUsuario_Load(object sender, System.EventArgs e)
        {
            var obj = Usuario as Usuario;
            if (obj == null)
                return;
            txtNome.Text = obj.Nome;
            txtLogin.Text = obj.Login;
            txtSenha.Text = obj.Senha;
            txtEmail.Text = obj.Email;
        }

        private void btnCancelar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, System.EventArgs e)
        {
            if (!ValidarCampos())
                return;

            this.Usuario = this.Usuario ?? new Usuario();
            this.Usuario.Nome = txtNome.Text;
            this.Usuario.Login = txtLogin.Text;
            this.Usuario.Senha = txtSenha.Text;
            this.Usuario.Email = txtEmail.Text;

            if (this.Usuario != null && this.Usuario.Id > 0)
                new UsuarioDAO().Atualizar(this.Usuario);
            else
                new UsuarioDAO().Inserir(this.Usuario);

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

            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                aux = false;
                error.SetError(txtLogin, "Campo obrigatório!");
            }

            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                aux = false;
                error.SetError(txtSenha, "Campo obrigatório!");
            }

            return aux;
        }
    }
}
