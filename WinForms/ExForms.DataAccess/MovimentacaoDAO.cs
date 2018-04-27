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
    public class MovimentacaoDAO
    {
        public void Inserir(Movimentacao obj)
        {
            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=ExWinForms; Data Source=localhost; Integrated Security=SSPI;"))
            {
                //Criando instrução sql para inserir na tabela de produtos
                string strSQL = @"INSERT INTO movimentacao (Id_Produto, Data, Tipo, Quantidade_Recebida) 
                                  VALUES ( @Id_Produto, @Data, @Tipo, @Quantidade_Recebida);";

                //Criando um comando sql que será executado na base de dados
                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    //Preenchendo os parâmetros da instrução sql
                    cmd.Parameters.Add("@Id_Produto", SqlDbType.Int).Value = obj.Id_Produto.Id;
                    cmd.Parameters.Add("@Data", SqlDbType.DateTime).Value = obj.Data;
                    cmd.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = obj.Tipo;
                    cmd.Parameters.Add("@Quantidade_Recebida", SqlDbType.Int).Value = obj.Quantidade_Recebida;

                    //Abrindo conexão com o banco de dados
                    conn.Open();
                    //Executando instrução sql
                    cmd.ExecuteNonQuery();
                    //Fechando conexão com o banco de dados
                    conn.Close();
                }
            }
        }
        public void Atualizar(Movimentacao obj)
        {
            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=ExWinForms; Data Source=localhost; Integrated Security=SSPI;"))
            {
                //Criando instrução sql para inserir na tabela de produtos
                string strSQL = @"UPDATE movimentacao SET 
                                   Id_Produto = @Id_Produto, 
                                   Data = @Data,
                                   Tipo = @Tipo, 
                                   Quanitdade_Recebida = @Quantidade_Recebida                                     
                                WHERE id = @id;";

                //Criando um comando sql que será executado na base de dados
                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    //Preenchendo os parâmetros da instrução sql
                    cmd.Parameters.Add("@Id_Produto", SqlDbType.Int).Value = obj.Id_Produto.Id;
                    cmd.Parameters.Add("@Data", SqlDbType.DateTime).Value = obj.Data;
                    cmd.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = obj.Tipo;
                    cmd.Parameters.Add("@Quantidade_Recebida", SqlDbType.Int).Value = obj.Quantidade_Recebida;
                    //Abrindo conexão com o banco de dados
                    conn.Open();
                    //Executando instrução sql
                    cmd.ExecuteNonQuery();
                    //Fechando conexão com o banco de dados
                    conn.Close();
                }
            }
        }
        public void Deletar(Movimentacao obj)
        {
            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=ExWinForms; Data Source=localhost; Integrated Security=SSPI;"))
            {
                //Criando instrução sql para inserir na tabela de produtos
                string strSQL = @"DELETE FROM movimentacao WHERE id = @id;";

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
        public Movimentacao BuscarPorId(int id)
        {
            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=ExWinForms; Data Source=localhost; Integrated Security=SSPI;"))
            {
                //Criando instrução sql para selecionar todos os registros na tabela de produtos
                string strSQL = @"SELECT * FROM movimentacao WHERE id = @id;";

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
                    var movimentacao = new Movimentacao()
                    {
                        Id_Produto = new Produto() { Id = Convert.ToInt32(row["id_Produto"]) },
                        Data = Convert.ToDateTime(row["Data"]),
                        Tipo = row["Tipo"].ToString(),
                        Quantidade_Recebida = row["Quantidade_Recebida"].ToString()
                    };

                    return movimentacao;
                }
            }
        }
        public List<Movimentacao> BuscarPorTexto(string texto)
        {
            var lst = new List<Movimentacao>();

            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=ExWinForms; Data Source=localhost; Integrated Security=SSPI;"))
            {
                //Criando instrução sql para selecionar todos os registros na tabela de Categorias
                string strSQL = string.Format(@"SELECT 
                                                    m.*, 
                                                    p.id_produto as Produto,
                                                    m.NomeCliente
                                                FROM movimentacao m
                                                INNER JOIN produto p on (p.id = iv.id_produto) 
                                                WHERE p.nome like '%{0}%';", texto);

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
                        var obj = new Movimentacao()
                        {

                            Id_Produto = new Produto()
                            {

                                Nome = row["nome"].ToString()
                            },
                            Data = Convert.ToDateTime(row["Data"])
                            //Tipo = row["Tipo"].ToString();
                            //Quantidade_Recebida = row["Quantidade_Recebida"]                  
                        };

                        lst.Add(obj);
                    }
                }
                return lst;
            }

        }
    }
}