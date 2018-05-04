using ExForms.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ExForms.DataAccess
{
    public class ProdutoDAO
    {
        public void Inserir(Produto obj)
        {
            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=ExWinForms; Data Source=localhost; Integrated Security=SSPI;"))
            {
                //Criando instrução sql para inserir na tabela de produtos
<<<<<<< HEAD
                string strSQL = @"INSERT INTO produto (nome,id_categoria, preco, descricao) 
=======
                string strSQL = @"INSERT INTO produto (nome, id_categoria, preco, descricao) 
>>>>>>> 939daf2d6304ad1ed7d2d3d8992cd8c8397852c1
                                  VALUES (@nome, @id_categoria, @preco, @descricao);";

                //Criando um comando sql que será executado na base de dados
                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    //Preenchendo os parâmetros da instrução sql
                    cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = obj.Nome;
                    cmd.Parameters.Add("@id_categoria", SqlDbType.Int).Value = obj.Categoria.Id;
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
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=ExWinForms; Data Source=localhost; Integrated Security=SSPI;"))
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

        public void Deletar(Produto obj)
        {
            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=ExWinForms; Data Source=localhost; Integrated Security=SSPI;"))
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
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=ExWinForms; Data Source=localhost; Integrated Security=SSPI;"))
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
                        Preco = Convert.ToDecimal(row["preco"]),
                        Descricao = row["descricao"].ToString()
                    };

                    return produto;
                }
            }
        }

        public List<Produto> BuscarTodos()
        {
            var lst = new List<Produto>();

            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=ExWinForms; Data Source=localhost; Integrated Security=SSPI;"))
            {
                //Criando instrução sql para selecionar todos os registros na tabela de produtos
                string strSQL = @"SELECT 
                                      p.*, 
                                      c.nome as categoria 
                                  FROM produto p
                                  INNER JOIN categoria c on (c.id = p.id_categoria);";

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
                            Preco = Convert.ToDecimal(row["preco"]),
                            Descricao = row["descricao"].ToString()
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
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=ExWinForms; Data Source=localhost; Integrated Security=SSPI;"))
            {
                //Criando instrução sql para selecionar todos os registros na tabela de Categorias
                string strSQL = string.Format(@"SELECT 
                                                    p.*, 
                                                    c.nome as categoria 
                                                FROM produto p
                                                INNER JOIN categoria c on (c.id = p.id_categoria) 
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
<<<<<<< HEAD
                            Nome = row["nome"].ToString(),                    
=======
                            Nome = row["nome"].ToString(),
>>>>>>> 939daf2d6304ad1ed7d2d3d8992cd8c8397852c1
                            Categoria = new Categoria()
                            {
                                Id = Convert.ToInt32(row["id_categoria"]),
                                Nome = row["categoria"].ToString()
                            },
                            Preco = Convert.ToDecimal(row["preco"]),
                            Descricao = row["descricao"].ToString()
                        };

                        lst.Add(produto);
                    }
                }
            }

            return lst;
        }
    }
}
