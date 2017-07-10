using System.Collections.Generic;
using AutoMapper;
using ExemploSeguros.Application.Interfaces;
using ExemploSeguros.Application.ViewModels;
using ExemploSeguros.Domain.Interfaces.Repository.ItemRepo;

namespace ExemploSeguros.Application.Services
{
    public class MarcaAppService : IMarcaAppService
    {
        private readonly IMapper _mapper;
        private readonly IItemRepository _itemRepository;

        public MarcaAppService(IMapper mapper, IItemRepository itemRepository)
        {
            _mapper = mapper;
            _itemRepository = itemRepository;
        }

        public MarcaViewModel ObterMarcaPorId(int marcaId)
        {
            return _mapper.Map<MarcaViewModel>(_itemRepository.ObterMarcaPorId(marcaId));
        }

        public IEnumerable<MarcaViewModel> ObterMarcas()
        {
            return _mapper.Map<IEnumerable<MarcaViewModel>>(_itemRepository.ObterMarcas());
        }

        public IEnumerable<MarcaViewModel> ObterMarcasOrdenadasAlfabeticamente()
        {
            return _mapper.Map<IEnumerable<MarcaViewModel>>(_itemRepository.ObterMarcasOrdenadasAlfabeticamente());
        }

        public void Dispose()
        {
            _itemRepository.Dispose();
        }
    }
}