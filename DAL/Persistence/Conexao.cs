using System.Data.SqlClient;
using System.Configuration;

namespace DAL.Persistence
{
    public class Conexao
    {
        protected SqlConnection Con;
        protected SqlCommand Cmd;
        protected SqlDataReader Dr;

        //Método para Abrir Conexão:
        public void AbrirConexao()
        {
            try
            {
                Con = new SqlConnection(ConfigurationManager.ConnectionStrings["Banco"].ConnectionString);
                Con.Open();
            }
            catch 
            {
                throw;
            }
        }

        //Método para Fechar Conexão:
        public void FecharConexao()
        {
            try
            {
                if (Con != null)
                    Con.Close();
            }
            catch
            {
                throw;
            }
        }
    }
}
