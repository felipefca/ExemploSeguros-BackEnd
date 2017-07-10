using System;
using AutoMapper;
using ExemploSeguros.Application.Interfaces;
using ExemploSeguros.Application.ViewModels;
using ExemploSeguros.Domain.Interfaces.Repository.ItemRepo;

namespace ExemploSeguros.Application.Services
{
    public class ItemAppService : IItemAppService
    {
        private readonly IMapper _mapper;
        private readonly IItemRepository _itemRepository;

        public ItemAppService(IMapper mapper, IItemRepository itemRepository)
        {
            _mapper = mapper;
            _itemRepository = itemRepository;
        }

        public ItemViewModel ObterItemCotacao(Guid cotacaoId)
        {
            return _mapper.Map<ItemViewModel>(_itemRepository.ObterItemCotacao(cotacaoId));
        }

        public void Dispose()
        {
            _itemRepository.Dispose();
        }
    }
}