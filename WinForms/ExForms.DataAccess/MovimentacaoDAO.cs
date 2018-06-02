using ExForms.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ExForms.DataAccess
{
    public class MovimentacaoDAO
    {
        public void Inserir(Movimentacao obj)
        {
            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                //Criando instrução sql para inserir na tabela de produtos
                string strSQL = @"INSERT INTO MOVIMENTACAO ( ID_PRODUTO, DATA, TIPO, QUANTIDADE) 
                                  VALUES (@ID_PRODUTO, @DATA, @TIPO, @QUANTIDADE);";

                //Criando um comando sql que será executado na base de dados
                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    //Preenchendo os parâmetros da instrução sql
                    cmd.Parameters.Add("@Id_Produto", SqlDbType.Int).Value = obj.Produto.Id;
                    cmd.Parameters.Add("@Data", SqlDbType.DateTime).Value = obj.Data;
                    cmd.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = obj.Tipo;
                    cmd.Parameters.Add("@QUANTIDADE", SqlDbType.Int).Value = obj.Quantidade;

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
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                //Criando instrução sql para inserir na tabela de produtos
                string strSQL = @"UPDATE MOVIMENTACAO SET 
                                     ID_PRODUTO = @ID_PRODUTO, 
                                     DATA = @DATA,
                                     TIPO = @TIPO, 
                                     QUANTIDADE = @QUANTIDADE                                     
                                  WHERE ID = @ID;";

                //Criando um comando sql que será executado na base de dados
                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    //Preenchendo os parâmetros da instrução sql
                    cmd.Parameters.Add("@Id", SqlDbType.Int).Value = obj.Id;
                    cmd.Parameters.Add("@Id_Produto", SqlDbType.Int).Value = obj.Produto.Id;
                    cmd.Parameters.Add("@Data", SqlDbType.DateTime).Value = obj.Data;
                    cmd.Parameters.Add("@Tipo", SqlDbType.VarChar).Value = obj.Tipo;
                    cmd.Parameters.Add("@QUANTIDADE", SqlDbType.Int).Value = obj.Quantidade;
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
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                //Criando instrução sql para inserir na tabela de produtos
                string strSQL = @"DELETE FROM MOVIMENTACAO WHERE ID = @ID;";

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
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                //Criando instrução sql para selecionar todos os registros na tabela de produtos
                string strSQL = @"SELECT * FROM MOVIMENTACAO WHERE ID = @ID;";

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
                        Id = Convert.ToInt32(row["Id"]),
                        Produto = new Produto() { Id = Convert.ToInt32(row["ID_PRODUTO"]) },
                        Data = Convert.ToDateTime(row["DATA"]),
                        Tipo = row["TIPO"].ToString(),
                        Quantidade = Convert.ToInt32(row["QUANTIDADE"])
                    };

                    return movimentacao;
                }
            }
        }

        public List<Movimentacao> BuscarPorTexto(string texto)
        {
            var lst = new List<Movimentacao>();

            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                //Criando instrução sql para selecionar todos os registros na tabela de Categorias
                string strSQL = string.Format(@"SELECT 
                                                    M.*, 
                                                    P.NOME AS PRODUTO
                                                FROM MOVIMENTACAO M
                                                INNER JOIN PRODUTO P ON (P.ID = M.ID_PRODUTO) 
                                                WHERE P.NOME LIKE '%{0}%';", texto);

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
                            Id = Convert.ToInt32(row["Id"]),
                            Produto = new Produto()
                            {
                                Id = Convert.ToInt32(row["ID_PRODUTO"]),
                                Nome = row["PRODUTO"].ToString()
                            },
                            Data = Convert.ToDateTime(row["DATA"]),
                            Tipo = row["TIPO"].ToString(),
                            Quantidade = Convert.ToInt32(row["QUANTIDADE"])
                        };

                        lst.Add(obj);
                    }
                }
                return lst;
            }

        }
    }
}