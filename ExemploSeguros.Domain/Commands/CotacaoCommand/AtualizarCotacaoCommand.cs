﻿ using System;

namespace ExemploSeguros.Domain.Commands.CotacaoCommand
{
    public class AtualizarCotacaoCommand : BaseCotacaoCommand
    {
        public AtualizarCotacaoCommand(Guid id, int numCotacao, DateTime dataCalculo, DateTime dataCadastro, DateTime dataVigenciaInicial, DateTime dataVigenciaFinal, Guid userId, decimal premioTotal, int tipoCalculoId, int tipoSeguroId)
        {
            Id = id;
            NumCotacao = numCotacao;
            DataCalculo = dataCalculo;
            DataCadastro = dataCadastro;
            DataVigenciaInicial = dataVigenciaInicial;
            DataVigenciaFinal = dataVigenciaFinal;
            UserId = userId;
            PremioTotal = premioTotal;
            TipoCalculoId = tipoCalculoId;
            TipoSeguroId = tipoSeguroId;
        }
    }
}
