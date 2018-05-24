using System;
using System.Windows.Forms;

namespace ExForms.WinUI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            bool _found = false;
            foreach (Form _openForm in Application.OpenForms)
            {
                if (_openForm is FormLogin)
                {
                    _openForm.Focus();
                    _found = true;
                }
            }

            if (!_found)
            {
                var frm = new FormLogin();
                if (frm.ShowDialog() != DialogResult.OK)
                    return;
            }
        }

        private void mnuCategorias_Click(object sender, EventArgs e)
        {
            bool _found = false;
            foreach (Form _openForm in Application.OpenForms)
            {
                if (_openForm is FormListaCategoria)
                {
                    _openForm.Focus();
                    _found = true;
                }
            }

            if (!_found)
            {
                var frm = new FormListaCategoria();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuProdutos_Click(object sender, EventArgs e)
        {
            bool _found = false;
            foreach (Form _openForm in Application.OpenForms)
            {
                if (_openForm is FormListaProduto)
                {
                    _openForm.Focus();
                    _found = true;
                }
            }

            if (!_found)
            {
                var frm = new FormListaProduto();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuUsuarios_Click(object sender, EventArgs e)
        {
            bool _found = false;
            foreach (Form _openForm in Application.OpenForms)
            {
                if (_openForm is FormListaCategoria)
                {
                    _openForm.Focus();
                    _found = true;
                }
            }

            if (!_found)
            {
                var frm = new FormListaUsuario();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuLogoff_Click(object sender, EventArgs e)
        {
            bool _found = false;
            foreach (Form _openForm in Application.OpenForms)
            {
                if (_openForm is FormLogin)
                {
                    _openForm.Focus();
                    _found = true;
                }
            }

            if (!_found)
            {
                var frm = new FormLogin();
                if (frm.ShowDialog() != DialogResult.OK)
                    return;
            }
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do sistema?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            Application.Exit();
        }

        private void mnuPagamento_Click(object sender, EventArgs e)
        {
            bool _found = false;
            foreach (Form _openForm in Application.OpenForms)
            {
                if (_openForm is FormListaTipoPagamento)
                {
                    _openForm.Focus();
                    _found = true;
                }
            }

            if (!_found)
            {
                var frm = new FormListaTipoPagamento();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void unidadeDeMedidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool _found = false;
            foreach (Form _openForm in Application.OpenForms)
            {
                if (_openForm is FormListaUnidadeMedida)
                {
                    _openForm.Focus();
                    _found = true;
                }
            }

            if (!_found)
            {
                var frm = new FormListaUnidadeMedida();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void movimentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool _found = false;
            foreach (Form _openForm in Application.OpenForms)
            {
                if (_openForm is FormListaMovimentacao)
                {
                    _openForm.Focus();
                    _found = true;
                }
            }

            if (!_found)
            {
                var frm = new FormListaMovimentacao();
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void mnuVendas_Click(object sender, EventArgs e)
        {
            bool _found = false;
            foreach (Form _openForm in Application.OpenForms)
            {
                if (_openForm is FormListaVenda)
                {
                    _openForm.Focus();
                    _found = true;
                }
            }

            if (!_found)
            {
                var frm = new FormListaVenda();
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}