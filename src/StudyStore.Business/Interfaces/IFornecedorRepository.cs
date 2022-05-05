using StudyStore.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyStore.Business.Interfaces
{
    public interface IFornecedorRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterfornecedorEndereco(Guid id);
        Task<Fornecedor> ObterfornecedorProdutosEndereco(Guid id);
        Task<object> ObterFornecedorEndereco(Guid id);
        Task<object> ObterFornecedorProdutosEndereco(Guid id);
    }
}
