using System;

namespace DevIO.Business.Models
{
    public class Produto : Entity
    {
        /* Informação dizendo que o produto pertence a um fornecedor */
        public Guid FornecedorId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string Imagem { get; set; }

        public decimal Valor { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

        /*EF Relation relacao com fornecedor 1 fornecedor tem varios produtos*/
        public Fornecedor Fornecedor { get; set; }
    }
}
