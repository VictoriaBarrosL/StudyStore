using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudyStore.Business.Interfaces;
using StudyStore.Business.Models;

namespace StudyStore.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        public FornecedorRepository(StudyStoreDbContext context) : base(context)
        {

        }

        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(c => c.Endereco)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public Task<Fornecedor> ObterfornecedorEndereco(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(c => c.Produtos)
                .Include(c => c.Endereco)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public Task<Fornecedor> ObterfornecedorProdutosEndereco(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}