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
    public partial class btnVoltar02 : Form
    {
        public btnVoltar02()
        {
            InitializeComponent();
        }

        private void btnTela_inical02_Click(object sender, EventArgs e)
        {
            var frm = new FormProduto();
            frm.Show();
            this.Hide();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            var frm = new FormAddP();
            frm.Show();
            this.Hide();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {

        }
    }
}
