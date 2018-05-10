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
    public partial class FormCadastroUnidadeMedida : Form
    {
        private UnidadeMedida UnidadeMedida { get; set; }

        public FormCadastroUnidadeMedida()
        {
            InitializeComponent();
        }

        public FormCadastroUnidadeMedida(UnidadeMedida obj)
        {
            InitializeComponent();
            this.UnidadeMedida = obj;
        }

        private void FormCadastroUnidadeMedida_Load(object sender, System.EventArgs e)
        {
            var obj =  UnidadeMedida as UnidadeMedida;
            if (obj == null)
                return;
            txtNome.Text = obj.Nome;
            txtSigla.Text = obj.Sigla;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            {
                if (!ValidarCampos())
                    return;

                this.UnidadeMedida = this.UnidadeMedida ?? new UnidadeMedida();
                this.UnidadeMedida.Nome = txtNome.Text;
                this.UnidadeMedida.Sigla = txtSigla.Text;

                if (this.UnidadeMedida != null && this.UnidadeMedida.Id > 0)
                    new UnidadeMedidaDAO().Atualizar(this.UnidadeMedida);
                else
                    new UnidadeMedidaDAO().Inserir(this.UnidadeMedida);

                DialogResult = DialogResult.OK;
            }
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

            if (string.IsNullOrWhiteSpace(txtSigla.Text))
            {
                aux = false;
                error.SetError(txtNome, "Campo obrigatório!");
            }
            return aux;
        }

    }
}
