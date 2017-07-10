using System.Collections.Generic;
using AutoMapper;
using ExemploSeguros.Application.Interfaces;
using ExemploSeguros.Application.ViewModels;
using ExemploSeguros.Domain.Interfaces.Repository.ItemRepo;

namespace ExemploSeguros.Application.Services
{
    public class ProdutoAppService : IProdutoAppService
    {
        private readonly IMapper _mapper;
        private readonly IItemRepository _itemRepository;

        public ProdutoAppService(IMapper mapper, IItemRepository itemRepository)
        {
            _mapper = mapper;
            _itemRepository = itemRepository;
        }

        public IEnumerable<ProdutoViewModel> ObterProdutos()
        {
            return _mapper.Map<IEnumerable<ProdutoViewModel>>(_itemRepository.ObterProdutos());
        }

        public void Dispose()
        {
            _itemRepository.Dispose();
        }
    }
}