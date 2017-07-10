using System;
using ExemploSeguros.Domain.Commands.ClienteCommand;

namespace ExemploSeguros.Domain.Commands.CotacaoCommand
{
    public class RegistrarCotacaoCommand : BaseCotacaoCommand
    {
        public RegistrarCotacaoCommand(int numCotacao, DateTime dataCalculo, DateTime dataCadastro, DateTime dataVigenciaInicial, DateTime dataVigenciaFinal, 
            Guid userId, decimal premioTotal, int tipoCalculoId, int tipoSeguroId, IncluirClienteEventoCommand cliente, IncluirItemEventoCommand item,
            IncluirQuestionarioEventoCommand questionario, IncluirPerfilEventoCommand perfil)
        {
            NumCotacao = numCotacao;
            DataCalculo = dataCalculo;
            DataCadastro = dataCadastro;
            DataVigenciaInicial = dataVigenciaInicial;
            DataVigenciaFinal = dataVigenciaFinal;
            UserId = userId;
            PremioTotal = premioTotal;
            TipoCalculoId = tipoCalculoId;
            TipoSeguroId = tipoSeguroId;
            Cliente = cliente;
            Item = item;
            Questionario = questionario;
            Perfil = perfil;
        }

        public IncluirClienteEventoCommand Cliente { get; private set; }
        public IncluirItemEventoCommand Item { get; private set; }
        public IncluirQuestionarioEventoCommand Questionario { get; private set; }
        public IncluirPerfilEventoCommand Perfil { get; private set; }
    }
}
