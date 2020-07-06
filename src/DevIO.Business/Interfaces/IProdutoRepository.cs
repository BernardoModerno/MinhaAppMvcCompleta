using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DevIO.Business.Models;

namespace DevIO.Business.Intefaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId); /*Obter produtos por fornecedor*/
        Task<IEnumerable<Produto>> ObterProdutosFornecedores(); /*Obter produtos e fornecedores desse produto*/
        Task<Produto> ObterProdutoFornecedor(Guid id); /*Obter apenas um produto do fornecedor*/
    }
}