using ExForms.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace ExForms.DataAccess
{
    public class ItemVendaDAO
    {
        public void Inserir(ItemVenda obj)
        {
            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=ExWinForms; Data Source=localhost; Integrated Security=SSPI;"))
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
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=ExWinForms; Data Source=localhost; Integrated Security=SSPI;"))
            {
                //Criando instrução sql para inserir na tabela de produtos
                string strSQL = @"UPDATE Item_Venda SET 
                                   Id_Produto = @Id_Produto, 
                                    Quantidade = @Quantidade,
                                    Valor_Unitario = @Valor_Unitario, 
                                    Id_Venda = @Id_Venda                                     
                                WHERE id = @id;";

                //Criando um comando sql que será executado na base de dados
                using (SqlCommand cmd = new SqlCommand(strSQL))
                {
                    cmd.Connection = conn;
                    //Preenchendo os parâmetros da instrução sql
                    cmd.Parameters.Add("@Id_Produto", SqlDbType.Int).Value = obj.Produto.Id;
                    cmd.Parameters.Add("@Quantidade", SqlDbType.VarChar).Value = obj.Quantidade;
                    cmd.Parameters.Add("@Valor_Unitario", SqlDbType.Decimal).Value = obj.Valor_Unitario;
                    cmd.Parameters.Add("@Id_Venda", SqlDbType.Int).Value = obj.Venda.Id;
                    //Abrindo conexão com o banco de dados
                    conn.Open();
                    //Executando instrução sql
                    cmd.ExecuteNonQuery();
                    //Fechando conexão com o banco de dados
                    conn.Close();
                }
            }
        }

        public void Deletar(ItemVenda obj)
        {
            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=ExWinForms; Data Source=localhost; Integrated Security=SSPI;"))
            {
                //Criando instrução sql para inserir na tabela de produtos
                string strSQL = @"DELETE FROM Item_Venda WHERE id = @id;";

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
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=ExWinForms; Data Source=localhost; Integrated Security=SSPI;"))
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
                    var item_Venda = new ItemVenda()
                    {
                        Id = Convert.ToInt32(row["id"]),
                        Produto = new Produto() { Id = Convert.ToInt32(row["id_Produto"]) },
                        Quantidade = Convert.ToInt32(row["Quantidade"]),
                        Valor_Unitario = Convert.ToDecimal(row["ValorUnitario"]),
                        Venda = new Venda() { Id = Convert.ToInt32(row["id_venda"]) }
                    };

                    return item_Venda;
                }
            }
        }

        public List<ItemVenda> BuscarPorTexto(string texto)
        {
            var lst = new List<ItemVenda>();

            //Criando uma conexão com o banco de dados
            using (SqlConnection conn = new SqlConnection(@"Initial Catalog=ExWinForms; Data Source=localhost; Integrated Security=SSPI;"))
            {
                //Criando instrução sql para selecionar todos os registros na tabela de Categorias
                string strSQL = string.Format(@"SELECT 
                                                    iv.*, 
                                                    p.nome as Nome_Produto,
                                                    v.NomeCliente
                                                FROM Item_Venda iv
                                                INNER JOIN produto p on (p.id = iv.id_produto) 
                                                INNER JOIN venda   v on (v.id = iv.id_venda)
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
                        var obj = new ItemVenda()
                        {
                            Id = Convert.ToInt32(row["id"]),
                            Produto = new Produto()
                            {

                                Nome = row["nome"].ToString()
                            },
                            Quantidade = Convert.ToInt32(row["Quantidade"]),
                            Valor_Unitario = Convert.ToDecimal(row["Valor_Unitario"]),

                            Venda = new Venda()
                            {

                                NomeCliente = row["Nome_Cliente"].ToString()
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
