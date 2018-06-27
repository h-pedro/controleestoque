using ExForms.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ExForms.DataAccess
{
    public class ProdutoDAO
    {
        public void Inserir(Produto obj)
        {
            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                //Criando instrução sql para inserir na tabela de produtos
                string strSQL = @"INSERT INTO produto (nome, id_categoria, id_unidade_medida, preco, descricao) 
                                  VALUES (@nome, @id_categoria, @id_unidade_medida, @preco, @descricao);";

                //Criando um comando sql que será executado na base de dados
                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    //Preenchendo os parâmetros da instrução sql
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = obj.Nome;
                    cmd.Parameters.Add("@id_categoria", SqlDbType.Int, 18).Value = obj.Categoria.Id;
                    cmd.Parameters.Add("@id_unidade_medida", SqlDbType.Int).Value = obj.UnidadeMedida.Id;
                    cmd.Parameters.Add("@preco", SqlDbType.Decimal).Value = obj.Preco;
                    cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = obj.Descricao;

                    //Abrindo conexão com o banco de dados
                    conn.Open();
                    //Executando instrução sql
                    cmd.ExecuteNonQuery();
                    //Fechando conexão com o banco de dados
                    conn.Close();
                }

            }
        }

        public void Atualizar(Produto obj)
        {
            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                //Criando instrução sql para inserir na tabela de produtos
                string strSQL = @"UPDATE produto SET 
                                    nome = @nome, 
                                    id_categoria = @id_categoria, 
                                    preco = @preco, 
                                    descricao = @descricao 
                                WHERE id = @id;";

                //Criando um comando sql que será executado na base de dados
                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    //Preenchendo os parâmetros da instrução sql
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = obj.Nome;
                    cmd.Parameters.Add("@id_categoria", SqlDbType.Int).Value = obj.Categoria.Id;
                    cmd.Parameters.Add("@preco", SqlDbType.Decimal).Value = obj.Preco;
                    cmd.Parameters.Add("@descricao", SqlDbType.VarChar).Value = obj.Descricao;
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

        public void Excluir(Produto obj)
        {
            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                //Criando instrução sql para inserir na tabela de produtos
                string strSQL = @"DELETE FROM produto WHERE id = @id;";

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

        public Produto BuscarPorId(int id)
        {
            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                //Criando instrução sql para selecionar todos os registros na tabela de produtos
                string strSQL = @"SELECT * FROM produto WHERE id = @id;";

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
                    var produto = new Produto()
                    {
                        Id = Convert.ToInt32(row["id"]),
                        Nome = row["nome"].ToString(),
                        Categoria = new Categoria() { Id = Convert.ToInt32(row["id_categoria"]) },
                        UnidadeMedida = new UnidadeMedida() { Id = Convert.ToInt32(row["id_unidade_medida"]) },
                        Preco = Convert.ToDecimal(row["preco"]),
                        Descricao = row["descricao"].ToString(),
                        QtdEmEstoque = Convert.ToInt32(row["qtd_estoque"])
                    };

                    return produto;
                }
            }
        }

        public List<Produto> BuscarTodos()
        {
            var lst = new List<Produto>();

            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                //Criando instrução sql para selecionar todos os registros na tabela de produtos
                string strSQL = @"SELECT 
                                      p.*, 
                                      c.nome as categoria,
                                      u.nome as unidade_medida,
                                      u.sigla
                                  FROM produto p
                                  INNER JOIN categoria c on (c.id = p.id_categoria)
                                  INNER JOIN unidade_medida u on (p.id_unidade_medida = u.id);";

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
                        var produto = new Produto()
                        {
                            Id = Convert.ToInt32(row["id"]),
                            Nome = row["nome"].ToString(),
                            Categoria = new Categoria()
                            {
                                Id = Convert.ToInt32(row["id_categoria"]),
                                Nome = row["categoria"].ToString()
                            },
                            UnidadeMedida = new UnidadeMedida()
                            {
                                Id = Convert.ToInt32(row["id_unidade_medida"]),
                                Nome = row["unidade_medida"].ToString(),
                                Sigla = row["sigla"].ToString()
                            },
                            Preco = Convert.ToDecimal(row["preco"]),
                            Descricao = row["descricao"].ToString(),
                            QtdEmEstoque = Convert.ToInt32(row["qtd_estoque"])
                        };

                        lst.Add(produto);
                    }
                }
            }

            return lst;
        }

        public List<Produto> BuscarPorTexto(string texto)
        {
            var lst = new List<Produto>();

            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Db"].ConnectionString))
            {
                //Criando instrução sql para selecionar todos os registros na tabela de Categorias
                string strSQL = string.Format(@"SELECT 
                                                    p.*, 
                                                    c.nome as categoria,
                                                    u.nome as unidade_medida,
                                                    u.sigla
                                                FROM produto p
                                                INNER JOIN categoria c on (c.id = p.id_categoria) 
                                                INNER JOIN unidade_medida u on (p.id_unidade_medida = u.id)
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
                        var produto = new Produto()
                        {
                            Id = Convert.ToInt32(row["id"]),
                            Nome = row["nome"].ToString(),
                            Categoria = new Categoria()
                            {
                                Id = Convert.ToInt32(row["id_categoria"]),
                                Nome = row["categoria"].ToString()
                            },
                            UnidadeMedida = new UnidadeMedida()
                            {
                                Id = Convert.ToInt32(row["id_unidade_medida"]),
                                Nome = row["unidade_medida"].ToString(),
                                Sigla = row["sigla"].ToString()
                            },
                            Preco = Convert.ToDecimal(row["preco"]),
                            Descricao = row["descricao"].ToString(),
                            QtdEmEstoque = Convert.ToInt32(row["qtd_estoque"])
                        };

                        lst.Add(produto);
                    }
                }
            }

            return lst;
        }
    }
}