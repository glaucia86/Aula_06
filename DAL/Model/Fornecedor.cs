using System.Collections.Generic;

namespace DAL.Model
{
    public class Fornecedor
    {
        public int IdFornecedor { get; set; }
        public string Nome { get; set; }

        //Relacionamento 1 para n
        public List<Produto> Produtos { get; set; }
    }
}
