using ExForms.DataAccess;
using ExForms.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ExForms.WinUI
{
    public partial class FormMain : Form
    {
        public Usuario Usuario { get; set; }

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
                this.Usuario = frm.Usuario;
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
                var frm = new FormListaVenda(this.Usuario);
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void relatórioDeUsuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ExcelPackage package = new ExcelPackage())
            {
                //1) NOME DO RELATÓRIO
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Relatório de Usuários");
                worksheet.View.ShowGridLines = false;

                //COMEÇA AQUI A MONTAGEM DO EXCEL
                var rowIndex = 1;

                //2) COLOCAR AS COLUNAS DO RELATÓRIO
                var lstColunas = new List<string>()
                {
                    "Nome",
                    "E-mail",
                    "Login"
                };

                //adicionando cabeçalho do relatório
                EPPlusHelper.AdicionarColunas(worksheet, lstColunas);
                rowIndex++;

                //buscando registros no banco de dados (no caso desse relatório é uma lista de usuários)
                //3) CHAMAR A CLASSE DAO DO RESPECTIVO RELATORIO
                var lst = new UsuarioDAO().BuscarTodos();
                foreach (var usuario in lst)
                {
                    EPPlusHelper.AdicionarLinha(worksheet, rowIndex, usuario.Nome, usuario.Email, usuario.Login);
                    rowIndex++;
                }
                //TERMINA AQUI A MONTAGEM DO EXCEL

                worksheet.Cells.AutoFitColumns(100);
                worksheet.View.ShowHeaders = true;
                worksheet.PrinterSettings.PaperSize = ePaperSize.A4;
                worksheet.PrinterSettings.FitToPage = true;

                var caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format("Arquivos/{0:yyyyMMdd}", DateTime.Now));

                if (!Directory.Exists(caminhoArquivo))
                    Directory.CreateDirectory(caminhoArquivo);

                //salvando o arquivo
                var fileName = Path.Combine(caminhoArquivo, string.Format("{0:ddMMyyyyHHmmss}.xlsx", DateTime.Now));
                var fi = new FileInfo(fileName);
                package.SaveAs(fi);

                //mandando abrir o arquivo
                Process.Start(fileName);
            }
        }

        private void relatórioDeCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ExcelPackage package = new ExcelPackage())
            {
                //1) NOME DO RELATÓRIO
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Relatório de Vendas");
                worksheet.View.ShowGridLines = false;

                //COMEÇA AQUI A MONTAGEM DO EXCEL
                var rowIndex = 1;

                //2) COLOCAR AS COLUNAS DO RELATÓRIO
                var lstColunas = new List<string>()
                {
                    "Cliente",
                    "Data",
                    "Tipo dePagamento",
                    "Quantidade de Itens",
                    "Valor Total (R$)"
                };

                //adicionando cabeçalho do relatório
                EPPlusHelper.AdicionarColunas(worksheet, lstColunas);
                rowIndex++;

                //buscando registros no banco de dados (no caso desse relatório é uma lista de vendas)
                //3) CHAMAR A CLASSE DAO DO RESPECTIVO RELATORIO
                var lst = new VendaDAO().BuscarTodos();
                foreach (var venda in lst)
                {
                    venda.Itens = new ItemVendaDAO().BuscarPorVenda(venda.Id);

                    EPPlusHelper.AdicionarLinha(
                        worksheet,
                        rowIndex,
                        venda.NomeCliente,
                        venda.DataPagamento.ToShortDateString(),
                        venda.TipoPagamento.Nome,
                        venda.Itens.Count.ToString("N0"),
                        venda.Itens.Sum(item => item.Quantidade * item.Valor_Unitario).ToString("C2")
                    );
                    rowIndex++;
                }
                //TERMINA AQUI A MONTAGEM DO EXCEL

                worksheet.Cells.AutoFitColumns(100);
                worksheet.View.ShowHeaders = true;
                worksheet.PrinterSettings.PaperSize = ePaperSize.A4;
                worksheet.PrinterSettings.FitToPage = true;

                var caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format("Arquivos/{0:yyyyMMdd}", DateTime.Now));

                if (!Directory.Exists(caminhoArquivo))
                    Directory.CreateDirectory(caminhoArquivo);

                //salvando o arquivo
                var fileName = Path.Combine(caminhoArquivo, string.Format("{0:ddMMyyyyHHmmss}.xlsx", DateTime.Now));
                var fi = new FileInfo(fileName);
                package.SaveAs(fi);

                //mandando abrir o arquivo
                Process.Start(fileName);
            }
        }

        private void relatórioDeProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ExcelPackage package = new ExcelPackage())
            {
                //1) NOME DO RELATÓRIO
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Relatório de Produtos");
                worksheet.View.ShowGridLines = false;

                //COMEÇA AQUI A MONTAGEM DO EXCEL
                var rowIndex = 1;

                //2) COLOCAR AS COLUNAS DO RELATÓRIO
                var lstColunas = new List<string>()
                {
                    "Nome do produto",
                    "Categoria do produto",
                    "Valor Unitário (R$)",
                    "Quantidade em Estoque",
                    "Unidade de Medida"
                };

                //adicionando cabeçalho do relatório
                EPPlusHelper.AdicionarColunas(worksheet, lstColunas);
                rowIndex++;

                //buscando registros no banco de dados (no caso desse relatório é uma lista de usuários)
                //3) CHAMAR A CLASSE DAO DO RESPECTIVO RELATORIO
                var lst = new ProdutoDAO().BuscarTodos();

                foreach (var produto in lst)
                {
                    EPPlusHelper.AdicionarLinha(
                        worksheet,
                        rowIndex,
                        produto.Nome,
                        produto.Categoria.Nome,
                        produto.Preco.ToString("C2"),
                        produto.QtdEmEstoque.ToString("N0"),
                        produto.UnidadeMedida.Sigla
                    );
                    rowIndex++;
                }
                //TERMINA AQUI A MONTAGEM DO EXCEL

                worksheet.Cells.AutoFitColumns(100);
                worksheet.View.ShowHeaders = true;
                worksheet.PrinterSettings.PaperSize = ePaperSize.A4;
                worksheet.PrinterSettings.FitToPage = true;

                var caminhoArquivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format("Arquivos/{0:yyyyMMdd}", DateTime.Now));

                if (!Directory.Exists(caminhoArquivo))
                    Directory.CreateDirectory(caminhoArquivo);

                //salvando o arquivo
                var fileName = Path.Combine(caminhoArquivo, string.Format("{0:ddMMyyyyHHmmss}.xlsx", DateTime.Now));
                var fi = new FileInfo(fileName);
                package.SaveAs(fi);

                //mandando abrir o arquivo
                Process.Start(fileName);
            }
        }
    }
}