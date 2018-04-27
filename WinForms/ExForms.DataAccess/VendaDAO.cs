using ExForms.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExForms.DataAccess
{
    public class VendaDAO
    {
        public void Inserir(Venda obj)
        {
            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=ExWinForms; Data Source=localhost; Integrated Security=SSPI;"))
            {
                //Criando instrução sql para inserir na tabela de categorias
                string strSQL = @"INSERT INTO Venda (DataPagamento, NomeCliente, Id_Pagamento) VALUES (@Data_Pagamento, @NomeCliente, @Id_Pagamento);";

                //Criando um comando sql que será executado na base de dados
                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    //Preenchendo os parâmetros da instrução sql
                    cmd.Parameters.Add("@DataPagamento", SqlDbType.VarChar).Value = obj.DataPagamento;
                    cmd.Parameters.Add("@NomeCliente", SqlDbType.VarChar).Value = obj.NomeCliente;
                    cmd.Parameters.Add("@Id_Pagamento", SqlDbType.Int).Value = obj.TipoPagamento;

                    //Abrindo conexão com o banco de dados
                    conn.Open();
                    //Executando instrução sql
                    cmd.ExecuteNonQuery();
                    //Fechando conexão com o banco de dados
                    conn.Close();
                }
            }
        }

        public void Atualizar(Venda obj)
        {
            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=ExWinForms; Data Source=localhost; Integrated Security=SSPI;"))
            {
                //Criando instrução sql para inserir na tabela de categorias
                string strSQL = @"UPDATE categoria SET DataPagamento = @DataPagamento, NomeCliente = @NomeCliente, Id_Pagamento = @Id_Pagamento WHERE id = @id;";

                //Criando um comando sql que será executado na base de dados
                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    //Preenchendo os parâmetros da instrução sql
                    cmd.Parameters.Add("@DataPagamento", SqlDbType.VarChar).Value = obj.DataPagamento;
                    cmd.Parameters.Add("@NomeCliente", SqlDbType.VarChar).Value = obj.NomeCliente;
                    cmd.Parameters.Add("@Id_Pagamento", SqlDbType.VarChar).Value = obj.TipoPagamento.Id;

                    //Abrindo conexão com o banco de dados
                    conn.Open();
                    //Executando instrução sql
                    cmd.ExecuteNonQuery();
                    //Fechando conexão com o banco de dados
                    conn.Close();
                }
            }
        }

        public void Deletar(Venda obj)
        {
            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=ExWinForms; Data Source=localhost; Integrated Security=SSPI;"))
            {
                //Criando instrução sql para inserir na tabela de categorias
                string strSQL = @"DELETE FROM Venda WHERE id = @id;";

                //Criando um comando sql que será executado na base de dados
                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    //Preenchendo os parâmetros da instrução sql
                    cmd.Parameters.Add("@id", SqlDbType.VarChar).Value = obj.Id;

                    //Abrindo conexão com o banco de dados
                    conn.Open();
                    //Executando instrução sql
                    cmd.ExecuteNonQuery();
                    //Fechando conexão com o banco de dados
                    conn.Close();
                }
            }
        }

        public Venda BuscarPorId(int id)
        {
            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=ExWinForms; Data Source=localhost; Integrated Security=SSPI;"))
            {
                //Criando instrução sql para selecionar todos os registros na tabela de Categorias
                string strSQL = @"SELECT * FROM Venda WHERE id = @id;";

                //Criando um comando sql que será executado na base de dados
                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    //Abrindo conexão com o banco de dados
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                    cmd.CommandText = strSQL;
                    //Executando instrução sql
                    var dataReader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dataReader);
                    //Fechando conexão com o banco de dados
                    conn.Close();

                    if (!(dt != null && dt.Rows.Count > 0))
                        return null;

                    var row = dt.Rows[0];
                    var obj = new Venda()
                    {
                        Id = Convert.ToInt32(row["id"]),
                        DataPagamento = Convert.ToDateTime(row["DataPagamento"]),
                        NomeCliente = row["NomeCliente"].ToString()
                    };

                    return obj;
                }
            }
        }

        public List<Venda> BuscarTodos()
        {
            var lst = new List<Venda>();

            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=ExWinForms; Data Source=localhost; Integrated Security=SSPI;"))
            {
                //Criando instrução sql para selecionar todos os registros na tabela de Categorias
                string strSQL = @"SELECT * FROM Venda;";

                //Criando um comando sql que será executado na base de dados
                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    //Abrindo conexão com o banco de dados
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = strSQL;
                    //Executando instrução sql
                    var dataReader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dataReader);
                    //Fechando conexão com o banco de dados
                    conn.Close();

                    //Percorrendo todos os registros encontrados na base de dados e adicionando em uma lista
                    foreach (DataRow row in dt.Rows)
                    {
                        var obj = new Venda()
                        {
                            Id = Convert.ToInt32(row["id"]),
                            DataPagamento = Convert.ToDateTime(row["DataPagamento"]),
                            NomeCliente = row["NomeCliente"].ToString()
                        };

                        lst.Add(obj);
                    }
                }
            }

            return lst;
        }

        public List<Venda> BuscarPorTexto(string texto)
        {
            var lst = new List<Venda>();

            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=ExWinForms; Data Source=localhost; Integrated Security=SSPI;"))
            {
                //Criando instrução sql para selecionar todos os registros na tabela de Categorias
                string strSQL = string.Format(@"SELECT * FROM Venda WHERE nome like '%{0}%';", texto);

                //Criando um comando sql que será executado na base de dados
                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    //Abrindo conexão com o banco de dados
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.CommandText = strSQL;
                    //Executando instrução sql
                    var dataReader = cmd.ExecuteReader();
                    var dt = new DataTable();
                    dt.Load(dataReader);
                    //Fechando conexão com o banco de dados
                    conn.Close();

                    //Percorrendo todos os registros encontrados na base de dados e adicionando em uma lista
                    foreach (DataRow row in dt.Rows)
                    {
                        var obj = new Venda()
                        {
                            Id = Convert.ToInt32(row["id"]),
                            DataPagamento = Convert.ToDateTime(row["DataPagamento"]),
                            NomeCliente = row["NomeCliente"].ToString()
                        };

                        lst.Add(obj);
                    }
                }
            }

            return lst;
        }
    }
}
