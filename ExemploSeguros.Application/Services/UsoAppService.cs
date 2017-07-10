using System.Collections.Generic;
using AutoMapper;
using ExemploSeguros.Application.Interfaces;
using ExemploSeguros.Application.ViewModels;
using ExemploSeguros.Domain.Interfaces.Repository.ItemRepo;

namespace ExemploSeguros.Application.Services
{
    public class UsoAppService : IUsoAppService
    {
        private readonly IMapper _mapper;
        private readonly IItemRepository _itemRepository;

        public UsoAppService(IMapper mapper, IItemRepository itemRepository)
        {
            _mapper = mapper;
            _itemRepository = itemRepository;
        }

        public IEnumerable<UsoViewModel> ObterUsos()
        {
            return _mapper.Map<IEnumerable<UsoViewModel>>(_itemRepository.ObterUsos());
        }

        public void Dispose()
        {
            _itemRepository.Dispose();
        }
    }
}