using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeEstoque
{
    public partial class s : Form
    {
        public s()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Shown(object sender, EventArgs e)
        {
            var frm = new FormLogin();
            if (frm.ShowDialog() != DialogResult.OK)
                return;
        }

        private void consultaDeEstoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormProduto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnVisualizarEstoque_Click(object sender, EventArgs e)
        {
            var frm = new FormProduto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnInserirProduto_Click(object sender, EventArgs e)
        {
            var frm = new FormAddP();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnAlterarProduto_Click(object sender, EventArgs e)
        {
            var frm = new FormProduto();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnExcluirProduto_Click(object sender, EventArgs e)
        {

        }
    }
}
