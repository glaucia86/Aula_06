using DAL.Model;
using DAL.Persistence;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL.Persistence
{
    public class ProdutoDal : Conexao
    {
        //Método para listar todos os Produtos pelo Fornecedor:
        public List<Produto> SelectByFornecedor(int idFornecedor)
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Produto where IdFornecedor=@id_fornecedor", Con);
                Cmd.Parameters.AddWithValue("@id_fornecedor", idFornecedor);
                Dr = Cmd.ExecuteReader();


                var lista = new List<Produto>();

                while (Dr.Read())
                {
                    var p = new Produto
                    {
                        IdProduto   = Convert.ToInt32(Dr["IdProduto"]),
                        Nome        = Convert.ToString(Dr["Nome"]),
                        Preco       = Convert.ToDecimal(Dr["Preco"]),
                        DataCompra  = Convert.ToDateTime(Dr["DataCompra"]),
                        IdFornecedor = Convert.ToInt32(Dr["IdFornecedor"])
                    };

                    lista.Add(p);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("\tErro ao listar os Produtos pelo Fornecedor. " + ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}
