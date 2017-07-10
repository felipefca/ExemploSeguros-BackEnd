using System;
using System.Linq;
using ExemploSeguros.Domain.Interfaces.Business;
using ExemploSeguros.Domain.Interfaces.Repository.CoberturasRepo;
using ExemploSeguros.Domain.Models.CotacaoRoot;

namespace ExemploSeguros.Domain.Business
{
    public class CalculoService : ICalculoService
    {
        private readonly ICoberturasRepository _coberturasProdutoRepository;

        public CalculoService(ICoberturasRepository coberturasProdutoRepository)
        {
            _coberturasProdutoRepository = coberturasProdutoRepository;
        }

        public decimal CalcularPremio(Cotacao cotacao)
        {
            double premio = 0;
            const double premioMinimo = 1000;

            var coberturas = _coberturasProdutoRepository.ObterCoberturas(cotacao.Item.ProdutoId);

            foreach (var cob in cotacao.Item.Coberturas)
            {
                if (!(Math.Abs(cob.Valor) > 0))
                    continue;

                double taxa = 0;

                // ReSharper disable once PossibleMultipleEnumeration
                foreach (var registro in coberturas.Where(c => c.CoberturaId == cob.CoberturaId))
                {
                    taxa = registro.Taxa;
                }

                var valor = cob.Valor * taxa;
                premio = premio + valor;
            }

            premio = premio + premioMinimo;

            return new decimal(premio);
        }
    }
}