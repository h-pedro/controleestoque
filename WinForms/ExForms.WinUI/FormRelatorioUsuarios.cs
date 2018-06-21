using ExForms.DataAccess;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ExForms.WinUI
{
    public partial class FormRelatorioUsuarios : Form
    {
        public FormRelatorioUsuarios()
        {
            InitializeComponent();
        }

        private void GerarRelatorio()
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

        private void btnGerar_Click(object sender, EventArgs e)
        {
            GerarRelatorio();
        }
    }
}
