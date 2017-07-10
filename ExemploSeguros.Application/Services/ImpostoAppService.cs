using System.Collections.Generic;
using AutoMapper;
using ExemploSeguros.Application.Interfaces;
using ExemploSeguros.Application.ViewModels;
using ExemploSeguros.Domain.Interfaces.Repository.ItemRepo;

namespace ExemploSeguros.Application.Services
{
    public class ImpostoAppService : IImpostoAppService
    {
        private readonly IMapper _mapper;
        private readonly IItemRepository _itemRepository;

        public ImpostoAppService(IMapper mapper, IItemRepository itemRepository)
        {
            _mapper = mapper;
            _itemRepository = itemRepository;
        }

        public IEnumerable<ImpostoViewModel> ObterImpostos()
        {
            return _mapper.Map<IEnumerable<ImpostoViewModel>>(_itemRepository.ObterImpostos());
        }

        public void Dispose()
        {
            _itemRepository.Dispose();
        }
    }
}