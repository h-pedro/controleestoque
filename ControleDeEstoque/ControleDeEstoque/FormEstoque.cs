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
    public partial class FormEstoque : Form
    {
        public FormEstoque()
        {
            InitializeComponent();
        }

        private void FormEstoque_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_estoque_Click(object sender, EventArgs e)
        {
            var frm = new btnVoltar02();
            frm.Show();
            this.Hide();
        }


        private void btnTela_Inicial_Click(object sender, EventArgs e)
        {
            var frm = new FormPrincipal();
            frm.Show();
            this.Hide();
        }
    }
}
