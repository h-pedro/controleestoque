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
    public partial class FormTipoPagameno : Form
    {
        public FormTipoPagameno()
        {
            InitializeComponent();
        }
        private void btnNovo_Click(object sender, EventArgs e)
        {
            var frm = new FormCadastroPagamento();
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            CarregarGridViewP();
        }

        private void CarregarGridViewP()
        {
            throw new NotImplementedException();
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregarGridViewP();
        }

    }
}
