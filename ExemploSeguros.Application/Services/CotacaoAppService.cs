using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using ExemploSeguros.Application.Interfaces;
using ExemploSeguros.Application.ViewModels;
using ExemploSeguros.Domain.Commands.ClienteCommand;
using ExemploSeguros.Domain.Commands.CotacaoCommand;
using ExemploSeguros.Domain.Core.Interfaces;
using ExemploSeguros.Domain.Interfaces.Repository.CotacaoRepo;

namespace ExemploSeguros.Application.Services
{
    public class CotacaoAppService : ICotacaoAppService
    {
        private readonly IBus _bus;
        private readonly IMapper _mapper;
        private readonly ICotacaoRepository _cotacaoRepository;

        public CotacaoAppService(IBus bus, IMapper mapper, ICotacaoRepository cotacaoRepository)
        {
            _bus = bus;
            _mapper = mapper;
            _cotacaoRepository = cotacaoRepository;
        }

        public RegistrarCotacaoCommand Adicionar(CotacaoViewModel cotacaoViewModel)
        {
            var registroCommand = _mapper.Map<RegistrarCotacaoCommand>(cotacaoViewModel);

            foreach (var cobertura in cotacaoViewModel.Item.ListCoberturasItem)
            {
                registroCommand.Item.Cobertura.Add(new IncluirCoberturaEventoCommand(cobertura.Id, cobertura.ItemId, cobertura.CoberturaId, cobertura.Valor));
            }

            _bus.SendCommand(registroCommand);

            return registroCommand;
        }

        public void Atualizar(CotacaoViewModel cotacaoViewModel)
        {
            var atualizarCommand = _mapper.Map<AtualizarCotacaoCommand>(cotacaoViewModel);
            _bus.SendCommand(atualizarCommand);
        }

        public CotacaoViewModel ObterCotacaoPorId(Guid cotacaoId)
        {
            return _mapper.Map<CotacaoViewModel>(_cotacaoRepository.ObterCotacaoPorId(cotacaoId));
        }

        public IEnumerable<CotacaoViewModel> ObterCotacoesPorUsuario(Guid userId)
        {
            return _mapper.Map<IEnumerable<CotacaoViewModel>>(_cotacaoRepository.ObterCotacoesPorUsuario(userId));
        }

        public string GeneratorNumber()
        {
            var chars = "0123456789";
            int tamanho = 8;
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, tamanho)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            return result;
        }

        public CotacaoViewModel Validar(CotacaoViewModel cotacaoViewModel)
        {
            throw new NotImplementedException();
        }

        public void Remover(Guid id)
        {
            _bus.SendCommand(new RemoverCotacaoCommand(id));
        }

        public void Dispose()
        {
            _cotacaoRepository.Dispose();
        }
    }
}