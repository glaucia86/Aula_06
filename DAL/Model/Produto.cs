using System;

namespace DAL.Model
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataCompra { get; set; }
        public int IdFornecedor { get; set; }

        //Relacionamento de Associação (TER):
        public Fornecedor Fornecedor { get; set; }
    }
}
