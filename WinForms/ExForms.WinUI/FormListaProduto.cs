﻿using ExForms.DataAccess;
using ExForms.Models;
using System;
using System.Windows.Forms;

namespace ExForms.WinUI
{
    public partial class FormListaProduto : Form
    {
        public FormListaProduto()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            var frm = new FormCadastroProduto();
            if (frm.ShowDialog() != DialogResult.OK)
                return;
            CarregarGridView();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregarGridView();
        }

        private void mnuNovo_Click(object sender, EventArgs e)
        {
            var frm = new FormCadastroProduto();
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

        private void FormListaProduto_Load(object sender, EventArgs e)
        {
            CarregarGridView();
        }

        private void txtBusca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CarregarGridView();
            }
        }

        private void gridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridView.Rows[e.RowIndex].ReadOnly = true;
        }

        private void gridView_DoubleClick(object sender, EventArgs e)
        {
            Editar();
        }

        private void gridView_SelectionChanged(object sender, EventArgs e)
        {
            HabilitarBotoes((gridView.SelectedRows.Count == 1), (gridView.SelectedRows.Count > 1));
        }

        private void HabilitarBotoes(bool oneItemSelected, bool manyItemsSelected)
        {
            btnEditar.Enabled = mnuEditar.Enabled = oneItemSelected;
            btnExcluir.Enabled = mnuExcluir.Enabled = (oneItemSelected || manyItemsSelected);
        }

        private void CarregarGridView()
        {
            var lst = new ProdutoDAO().BuscarPorTexto(txtBusca.Text);
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
                var obj = new ProdutoDAO().BuscarPorId(id);
                var frm = new FormCadastroProduto(obj);
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
                new ProdutoDAO().Deletar(new Produto() { Id = id });
                CarregarGridView();
            }
        }

     
    }
}
