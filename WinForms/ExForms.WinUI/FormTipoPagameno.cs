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
    public partial class FormTipoPagameno : Form
    {
        public FormTipoPagameno()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var frm = new FormCadastroPagamento();
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            CarregarGridView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (gridView.SelectedRows.Count > 0)
            {
                var id = Convert.ToInt32(gridView.SelectedRows[0].Cells[0].Value);
                var obj = new TipoPagamentoDAO().BuscarPorId(id);
                var frm = new FormCadastroPagamento(obj);
                if (frm.ShowDialog() != DialogResult.OK)
                    return;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregarGridView();
        }

        private void FormTipoPagameno_Load(object sender, EventArgs e)
        {
            CarregarGridView();
        }

        private void mnuNovo_Click(object sender, EventArgs e)
        {
            var frm = new FormCadastroPagamento();
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            CarregarGridView();
        }

        private void mnuEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void mnuExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            Editar();
        }

        private void gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridView.Rows[e.RowIndex].ReadOnly = true;
        }

        private void txtBusca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CarregarGridView();
            }
        }

        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            HabilitarBotoes((gridView.SelectedRows.Count == 1), (gridView.SelectedRows.Count > 1));
        }

        private void HabilitarBotoes(bool oneItemSelected, bool manyItemsSelected)
        {
            btnEditar.Enabled = btnEditar.Enabled = oneItemSelected;
            btnExcluir.Enabled = btnExcluir.Enabled = (oneItemSelected || manyItemsSelected);
        }

        private void CarregarGridView()
        {
            var lst = new TipoPagamentoDAO().BuscarPorTexto(txtBusca.Text);
            gridView.AutoGenerateColumns = false;
            gridView.DataSource = lst;
            HabilitarBotoes((gridView.SelectedRows.Count == 1), (gridView.SelectedRows.Count > 1));
            gridView.ClearSelection();
        }

        private void Editar()
        {
            if (gridView.SelectedRows.Count > 0)
            {
                var id = Convert.ToInt32(gridView.SelectedRows[0].Cells[0].Value);
                var obj = new TipoPagamentoDAO().BuscarPorId(id);
                var frm = new FormCadastroPagamento(obj);
                if (frm.ShowDialog() != DialogResult.OK)
                    return;
                CarregarGridView();
            }
        }

        private void Excluir()
        {
            if (gridView.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Deseja realmente remover o registro selecionado?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
                var id = Convert.ToInt32(gridView.SelectedRows[0].Cells[0].Value);
                new TipoPagamentoDAO().Deletar(new TipoPagamento() { Id = id });
                CarregarGridView();
            }
        }

        private void mnuAcoes_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFechar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
