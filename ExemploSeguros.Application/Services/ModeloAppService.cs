using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using ExemploSeguros.Application.Interfaces;
using ExemploSeguros.Application.ViewModels;
using ExemploSeguros.Domain.Interfaces.Repository.ItemRepo;

namespace ExemploSeguros.Application.Services
{
    public class ModeloAppService : IModeloAppService
    {
        private readonly IMapper _mapper;
        private readonly IItemRepository _itemRepository;

        public ModeloAppService(IMapper mapper, IItemRepository itemRepository)
        {
            _mapper = mapper;
            _itemRepository = itemRepository;
        }

        public IEnumerable<ModeloViewModel> ObterModelos()
        {
            return _mapper.Map<IEnumerable<ModeloViewModel>>(_itemRepository.ObterModelos());
        }

        public IEnumerable<ModeloViewModel> ObterTodosModelosporMarca(int marcaId)
        {
            return _mapper.Map<IEnumerable<ModeloViewModel>>(_itemRepository.ObterTodosModelosporMarca(marcaId));
        }

        public IEnumerable<ModeloViewModel> ObterTodosModelosSelecionados(int marcaId, string modelo, string anoFabricao, string anoModelo,
            string zeroKm)
        {
            return _mapper.Map<IEnumerable<ModeloViewModel>>(_itemRepository.ObterTodosModelosSelecionados(marcaId, modelo, anoFabricao, anoModelo, zeroKm));
        }

        public IEnumerable<ModeloViewModel> ObterTodosModelosSelecionadosOrdenadamente(int marcaId, string modelo,
            string anoFabricao, string anoModelo,
            string zeroKm)
        {
            var modelos = ObterTodosModelosSelecionados(marcaId, modelo, anoFabricao, anoModelo, zeroKm);

            return modelos.OrderBy(m => m.Valor);
        }

        public ModeloViewModel ObterModeloPorId(int modeloId)
        {
            return _mapper.Map<ModeloViewModel>(_itemRepository.ObterModeloPorId(modeloId));
        }

        public decimal ObterValorModelo(int modeloId)
        {
            return ObterModeloPorId(modeloId).Valor;
        }

        public List<string> ObterNomeModelosPorMarca(int marcaId)
        {
            var modelosPorMarca = ObterTodosModelosporMarca(marcaId); 

            return modelosPorMarca.Select(item => item.Nome).Distinct().ToList();
        }

        public decimal ObterFranquiaModelo(int modeloId)
        {
            return _itemRepository.ObterFranquiaModelo(modeloId);
        }

        public void Dispose()
        {
            _itemRepository.Dispose();
        }
    }
}