using DevIO.Business.Interfaces;
using DevIO.Business.Models;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace DevIO.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext context) : base(context) { }

        public async Task<Endereco> ObterEnderecoProFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking().FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId);
        }

        public Task Adicionar(Produto entity)
        {
            return null;
        }

        public Task Atualizar(Produto entity)
        {
            return null;
        }

        public Task<IEnumerable<Produto>> Busca(Expression<Func<Produto, bool>> predicate)
        {
            return null;
        }

        Task<Produto> IRepository<Produto>.ObterPorId(Guid id)
        {
            return null;
        }

        Task<List<Produto>> IRepository<Produto>.ObterTodos()
        {
            return null;
        }
    }
}
