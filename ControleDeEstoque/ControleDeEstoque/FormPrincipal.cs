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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
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
            var frm = new FormEstoque();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
