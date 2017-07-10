using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using ExemploSeguros.Application.Interfaces;
using ExemploSeguros.Application.ViewModels;
using ExemploSeguros.Domain.Interfaces.Repository.CoberturasRepo;

namespace ExemploSeguros.Application.Services
{
    public class CoberturasAppService : ICoberturasAppService
    {
        private readonly IMapper _mapper;
        private readonly ICoberturasRepository _coberturasRepository;

        public CoberturasAppService(IMapper mapper, ICoberturasRepository coberturasRepository)
        {
            _mapper = mapper;
            _coberturasRepository = coberturasRepository;
        }

        #region CoberturasProduto
        public IEnumerable<CoberturasViewModel> ObterCoberturasProdutos(int produto)
        {
            return _mapper.Map<IEnumerable<CoberturasViewModel>>(_coberturasRepository.ObterCoberturasProdutos(produto));
        }

        public CoberturasViewModel ObterCoberturaProdutos(int produto, int coberturaId)
        {
            return _mapper.Map<CoberturasViewModel>(_coberturasRepository.ObterCoberturaProdutos(produto, coberturaId));
        }

        public int ObterIdCoberturaBasica(int produto)
        {
            var coberturas = _coberturasRepository.ObterCoberturas(produto);
            var coberturaBasicaId = 0;

            foreach (var cob in coberturas.Where(cob => cob.FlagBasica))
            {
                coberturaBasicaId = cob.CoberturaId;
            }

            return coberturaBasicaId;
        }
        #endregion

        #region Coberturasitem
        public IEnumerable<CoberturaItemViewModel> ObterCoberturasItems(Guid itemId)
        {
            return _mapper.Map<IEnumerable<CoberturaItemViewModel>>(_coberturasRepository.ObterCoberturasItems(itemId));
        }
        #endregion

        public void Dispose()
        {
            _coberturasRepository.Dispose();
        }
    }
}