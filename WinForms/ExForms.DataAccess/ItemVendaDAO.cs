using ExForms.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ExForms.DataAccess
{
    public class ItemVendaDAO
    {
        public void Inserir(ItemVenda obj)
        {
            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                //Criando instrução sql para inserir na tabela de produtos
                string strSQL = @"INSERT INTO Item_Venda (Id_Produto, Quantidade, Valor_Unitario, Id_Venda) 
                                  VALUES ( @Id_Produto, @Quantidade, @Valor_Unitario, @Id_Venda);";

                //Criando um comando sql que será executado na base de dados
                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    //Preenchendo os parâmetros da instrução sql
                    cmd.Parameters.Add("@Id_Produto", SqlDbType.Int).Value = obj.Produto.Id;
                    cmd.Parameters.Add("@Quantidade", SqlDbType.VarChar).Value = obj.Quantidade;
                    cmd.Parameters.Add("@Valor_Unitario", SqlDbType.Decimal).Value = obj.Valor_Unitario;
                    cmd.Parameters.Add("@Id_Venda", SqlDbType.Int).Value = obj.Venda.Id;

                    foreach (SqlParameter parameter in cmd.Parameters)
                    {
                        if (parameter.Value == null)
                        {
                            parameter.Value = DBNull.Value;
                        }
                    }

                    //Abrindo conexão com o banco de dados
                    conn.Open();
                    //Executando instrução sql
                    cmd.ExecuteNonQuery();
                    //Fechando conexão com o banco de dados
                    conn.Close();
                }
            }
        }

        public void Atualizar(ItemVenda obj)
        {
            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                //Criando instrução sql para inserir na tabela de produtos
                string strSQL = @"UPDATE ITEM_VENDA SET 
                                      ID_PRODUTO = @ID_PRODUTO, 
                                      QUANTIDADE = @QUANTIDADE,
                                      VALOR_UNITARIO = @VALOR_UNITARIO
                                  WHERE ID = @ID;";

                //Criando um comando sql que será executado na base de dados
                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    //Preenchendo os parâmetros da instrução sql
                    cmd.Parameters.Add("@ID_PRODUTO", SqlDbType.Int).Value = obj.Produto.Id;
                    cmd.Parameters.Add("@QUANTIDADE", SqlDbType.VarChar).Value = obj.Quantidade;
                    cmd.Parameters.Add("@VALOR_UNITARIO", SqlDbType.Decimal).Value = obj.Valor_Unitario;
                    cmd.Parameters.Add("@ID", SqlDbType.Int).Value = obj.Id;

                    foreach (SqlParameter parameter in cmd.Parameters)
                    {
                        if (parameter.Value == null)
                        {
                            parameter.Value = DBNull.Value;
                        }
                    }

                    //Abrindo conexão com o banco de dados
                    conn.Open();
                    //Executando instrução sql
                    cmd.ExecuteNonQuery();
                    //Fechando conexão com o banco de dados
                    conn.Close();
                }
            }
        }

        public void Excluir(ItemVenda obj)
        {
            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                //Criando instrução sql para inserir na tabela de produtos
                string strSQL = @"DELETE FROM ITEM_VENDA WHERE ID = @ID;";

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

        public ItemVenda BuscarPorId(int id)
        {
            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                //Criando instrução sql para selecionar todos os registros na tabela de produtos
                string strSQL = @"SELECT * FROM Item_Venda WHERE id = @id;";

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
                    var itemVenda = new ItemVenda()
                    {
                        Id = Convert.ToInt32(row["id"]),
                        Venda = new Venda() { Id = Convert.ToInt32(row["id_venda"]) },
                        Produto = new Produto() { Id = Convert.ToInt32(row["id_Produto"]) },
                        Quantidade = Convert.ToInt32(row["Quantidade"]),
                        Valor_Unitario = Convert.ToDecimal(row["VALOR_UNITARIO"])
                    };

                    return itemVenda;
                }
            }
        }

        public List<ItemVenda> BuscarPorTexto(string texto)
        {
            var lst = new List<ItemVenda>();

            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                //Criando instrução sql para selecionar todos os registros na tabela de Categorias
                string strSQL = string.Format(@"SELECT 
                                                    IV.*, 
                                                    P.NOME AS NOME_PRODUTO,
                                                    V.NOMECLIENTE
                                                FROM ITEM_VENDA IV
                                                INNER JOIN PRODUTO P ON (P.ID = IV.ID_PRODUTO) 
                                                INNER JOIN VENDA   V ON (V.ID = IV.ID_VENDA)
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
                        var obj = new ItemVenda()
                        {
                            Id = Convert.ToInt32(row["id"]),
                            Venda = new Venda()
                            {
                                Id = Convert.ToInt32(row["id_venda"]),
                                NomeCliente = row["NomeCliente"].ToString()
                            },
                            Produto = new Produto()
                            {
                                Id = Convert.ToInt32(row["id_produto"]),
                                Nome = row["NOME_PRODUTO"].ToString()
                            },
                            Quantidade = Convert.ToInt32(row["Quantidade"]),
                            Valor_Unitario = Convert.ToDecimal(row["Valor_Unitario"])
                        };

                        lst.Add(obj);
                    }
                }
            }

            return lst;
        }

        public List<ItemVenda> BuscarPorVenda(int idVenda)
        {
            var lst = new List<ItemVenda>();

            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                //Criando instrução sql para selecionar todos os registros na tabela de Categorias
                string strSQL = @"SELECT 
                                      IV.*, 
                                      P.NOME AS NOME_PRODUTO,
                                      V.NOMECLIENTE
                                  FROM ITEM_VENDA IV
                                  INNER JOIN PRODUTO P ON (P.ID = IV.ID_PRODUTO) 
                                  INNER JOIN VENDA   V ON (V.ID = IV.ID_VENDA)
                                  WHERE IV.ID_VENDA = @ID_VENDA;";

                //Criando um comando sql que será executado na base de dados
                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    //Abrindo conexão com o banco de dados
                    conn.Open();
                    cmd.Connection = conn;
                    cmd.Parameters.Add("@ID_VENDA", SqlDbType.Int).Value = idVenda;
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
                        var itemVenda = new ItemVenda()
                        {
                            Id = Convert.ToInt32(row["id"]),
                            Venda = new Venda()
                            {
                                Id = Convert.ToInt32(row["id_venda"]),
                                NomeCliente = row["NomeCliente"].ToString()
                            },
                            Produto = new Produto()
                            {
                                Id = Convert.ToInt32(row["id_produto"]),
                                Nome = row["NOME_PRODUTO"].ToString()
                            },
                            Quantidade = Convert.ToInt32(row["Quantidade"]),
                            Valor_Unitario = Convert.ToDecimal(row["Valor_Unitario"])
                        };

                        lst.Add(itemVenda);
                    }
                }
            }

            return lst;
        }
    }
}
