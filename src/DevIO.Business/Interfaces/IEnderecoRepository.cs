using DevIO.Business.Models;
using System;
using System.Threading.Tasks;

namespace DevIO.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Produto>
    {
        Task<Endereco> ObterEnderecoProFornecedor(Guid fornecedorId);
    }
}
