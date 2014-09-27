using DAL.Model;
using DAL.Persistence;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL.Persistence
{
    public class FornecedorDal : Conexao
    {
        //Método para listar todos os Fornecedores do BD: SelectAll
        public List<Fornecedor> SelectAll()
        {
            try
            {
                AbrirConexao();
                Cmd = new SqlCommand("select * from Fornecedor", Con);
                Dr = Cmd.ExecuteReader();

                var lista = new List<Fornecedor>();

                while (Dr.Read())
                {
                    var f = new Fornecedor
                    {
                        IdFornecedor    = Convert.ToInt32(Dr["IdFornecedor"]),
                        Nome            = Convert.ToString(Dr["Nome"])
                    };

                    lista.Add(f);
                }
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception("\tErro ao listar os Fornecedores do BD " + e.Message);
            }
            finally
            {
                FecharConexao();
            }
        }

    }
}
