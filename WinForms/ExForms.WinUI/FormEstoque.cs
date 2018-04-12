using ExForms.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExForms.WinUI
{
    public partial class FormEstoque : Form
    {
        public FormEstoque()
        {
            InitializeComponent();
        }


        private void CarregarGridView()
        {
            var lst = new ProdutoDAO().BuscarPorTexto(dgvEstoque.Text);
            dgvEstoque.AutoGenerateColumns = false;
            dgvEstoque.DataSource = lst;
            dgvEstoque.ClearSelection();
        }
    }
}
