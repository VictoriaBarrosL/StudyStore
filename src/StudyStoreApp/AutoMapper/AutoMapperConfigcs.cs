using AutoMapper;
using StudyStore.Business.Models;
using StudyStoreApp.ViewModels;

namespace StudyStoreApp.AutoMapper
{
    public class AutoMapperConfigcs : Profile
    {
        public AutoMapperConfigcs()
        {
            CreateMap<Fornecedor, FornecedorViewModel>().ReverseMap();
            CreateMap<Endereco, EnderecoViewModel>().ReverseMap();
            CreateMap<Produto, ProdutoViewModel>().ReverseMap();
        }
    }
}
