using DevIO.Business.Models;
using System;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        //Obter Fornecedor e o endereço
        Task<Fornecedor> ObterFornecedorEndereco(Guid id);

        //Obter Fornecedor, produtos e endereço
        Task<Fornecedor> ObterFornecedorProdutosEnderecos(Guid id);
    }
}
