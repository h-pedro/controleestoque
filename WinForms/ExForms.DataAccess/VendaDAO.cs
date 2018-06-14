using ExForms.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ExForms.DataAccess
{
    public class VendaDAO
    {
        public void Inserir(Venda obj)
        {
            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                //Criando instrução sql para inserir na tabela de categorias
                string strSQL = @"INSERT INTO VENDA (DATAPAGAMENTO, NOMECLIENTE, ID_PAGAMENTO) VALUES (@DATAPAGAMENTO, @NOMECLIENTE, @ID_PAGAMENTO);
                                  SELECT SCOPE_IDENTITY();";

                //Criando um comando sql que será executado na base de dados
                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    //Preenchendo os parâmetros da instrução sql
                    cmd.Parameters.Add("@DATAPAGAMENTO", SqlDbType.DateTime).Value = obj.DataPagamento;
                    cmd.Parameters.Add("@NOMECLIENTE", SqlDbType.VarChar).Value = obj.NomeCliente;
                    cmd.Parameters.Add("@ID_PAGAMENTO", SqlDbType.Int).Value = obj.TipoPagamento.Id;

                    //Abrindo conexão com o banco de dados
                    conn.Open();
                    //Executando instrução sql
                    obj.Id = Convert.ToInt32(cmd.ExecuteScalar());
                    //Fechando conexão com o banco de dados
                    conn.Close();
                }
            }
        }

        public void Atualizar(Venda obj)
        {
            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                //Criando instrução sql para inserir na tabela de categorias
                string strSQL = @"UPDATE VENDA SET DATAPAGAMENTO = @DATAPAGAMENTO, NOMECLIENTE = @NOMECLIENTE, ID_PAGAMENTO = @ID_PAGAMENTO WHERE ID = @ID;";

                //Criando um comando sql que será executado na base de dados
                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    //Preenchendo os parâmetros da instrução sql
                    cmd.Parameters.Add("@DATAPAGAMENTO", SqlDbType.DateTime).Value = obj.DataPagamento;
                    cmd.Parameters.Add("@NOMECLIENTE", SqlDbType.VarChar).Value = obj.NomeCliente;
                    cmd.Parameters.Add("@ID_PAGAMENTO", SqlDbType.Int).Value = obj.TipoPagamento.Id;
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = obj.Id;

                    //Abrindo conexão com o banco de dados
                    conn.Open();
                    //Executando instrução sql
                    cmd.ExecuteNonQuery();
                    //Fechando conexão com o banco de dados
                    conn.Close();
                }
            }
        }

        public void Excluir(Venda obj)
        {
            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                //Criando instrução sql para excluir vendas
                string strSQL = @"DELETE FROM MOVIMENTACAO WHERE ID_VENDA = @ID;
                                  DELETE FROM ITEM_VENDA WHERE ID_VENDA = @ID;
                                  DELETE FROM VENDA WHERE ID = @ID;";

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
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                //Criando instrução sql para selecionar todos os registros na tabela de Categorias
                string strSQL = @"SELECT 
                                      V.*,
                                      T.NOME_PAGAMENTO
                                  FROM VENDA V 
                                  INNER JOIN TIPOPAGAMENTO T ON (T.ID = V.ID_PAGAMENTO);";

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
                        Id = Convert.ToInt32(row["ID"]),
                        DataPagamento = Convert.ToDateTime(row["DATAPAGAMENTO"]),
                        NomeCliente = row["NOMECLIENTE"].ToString(),
                        TipoPagamento = new TipoPagamento()
                        {
                            Id = Convert.ToInt32(row["ID_PAGAMENTO"]),
                            Nome = row["NOME_PAGAMENTO"].ToString()
                        }
                    };

                    return obj;
                }
            }
        }

        public List<Venda> BuscarTodos()
        {
            var lst = new List<Venda>();

            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                //Criando instrução sql para selecionar todos os registros na tabela de Categorias
                string strSQL = @"SELECT 
                                     V.*,
                                     T.NOME_PAGAMENTO,
                                  FROM VENDA V 
                                  INNER JOIN TIPOPAGAMENTO T ON (T.ID = V.ID_PAGAMENTO);";


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
                            Id = Convert.ToInt32(row["ID"]),
                            DataPagamento = Convert.ToDateTime(row["DATAPAGAMENTO"]),
                            NomeCliente = row["NOMECLIENTE"].ToString(),
                            TipoPagamento = new TipoPagamento()
                            {
                                Id = Convert.ToInt32(row["ID_PAGAMENTO"]),
                                Nome = row["NOME_PAGAMENTO"].ToString()
                            }
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
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                //Criando instrução sql para selecionar todos os registros na tabela de Categorias
                string strSQL = string.Format(@"SELECT 
                                                    V.*,
                                                    T.NOME_PAGAMENTO 
                                                FROM VENDA V
                                                INNER JOIN TIPOPAGAMENTO T ON (T.ID = V.ID_PAGAMENTO)
                                                WHERE V.NOMECLIENTE LIKE '%{0}%';", texto);

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
                            Id = Convert.ToInt32(row["ID"]),
                            DataPagamento = Convert.ToDateTime(row["DATAPAGAMENTO"]),
                            NomeCliente = row["NOMECLIENTE"].ToString(),
                            TipoPagamento = new TipoPagamento()
                            {
                                Id = Convert.ToInt32(row["ID_PAGAMENTO"]),
                                Nome = row["NOME_PAGAMENTO"].ToString()
                            }
                        };

                        lst.Add(obj);
                    }
                }
            }

            return lst;
        }
    }
}
