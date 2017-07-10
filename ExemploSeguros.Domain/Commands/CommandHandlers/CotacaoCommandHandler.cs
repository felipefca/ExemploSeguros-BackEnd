using System;
using ExemploSeguros.Domain.Commands.CotacaoCommand;
using ExemploSeguros.Domain.Core.Interfaces;
using ExemploSeguros.Domain.Core.Notifications;
using ExemploSeguros.Domain.Events;
using ExemploSeguros.Domain.Interfaces.Repository.CotacaoRepo;
using ExemploSeguros.Domain.Interfaces.Uow;
using ExemploSeguros.Domain.Interfaces.User;
using ExemploSeguros.Domain.Models.ClienteRoot;
using ExemploSeguros.Domain.Models.CotacaoRoot;
using ExemploSeguros.Domain.Models.ItemRoot;
using ExemploSeguros.Domain.Models.PerfilRoot;
using ExemploSeguros.Domain.Models.QuestionarioRoot;
using System.Linq;
using ExemploSeguros.Domain.Interfaces.Business;
using ExemploSeguros.Domain.Models.CoberturasRoot;

namespace ExemploSeguros.Domain.Commands.CommandHandlers
{
    public class CotacaoCommandHandler : CommandHandler,
        IHandler<RegistrarCotacaoCommand>,
        IHandler<AtualizarCotacaoCommand>,
        IHandler<RemoverCotacaoCommand>
    {
        private readonly ICotacaoRepository _cotacaoRepository;
        private readonly IBus _bus;
        private readonly IUser _user;
        private readonly ICalculoService _calculoService;

        public CotacaoCommandHandler(ICotacaoRepository cotacaoRepository,
            IUnitOfWork uow, IBus bus, IDomainNotificationHandler<DomainNotification> notifications, IUser user, ICalculoService calculoService)
            : base(uow, bus, notifications)
        {
            _cotacaoRepository = cotacaoRepository;
            _bus = bus;
            _user = user;
            _calculoService = calculoService;
        }

        public void Handle(RegistrarCotacaoCommand message)
        {
            var endereco = new Endereco(message.Cliente.Endereco.Logradouro, message.Cliente.Endereco.Numero, message.Cliente.Endereco.Complemento, message.Cliente.Endereco.Bairro,
                message.Cliente.Endereco.Cep, message.Cliente.Endereco.Cidade, message.Cliente.Endereco.Estado);

            var cliente = new Cliente.ClienteFactory().NewCliente(message.Cliente.Id, message.Cliente.Nome,
                message.Cliente.SobreNome, message.Cliente.Cpf, message.Cliente.Telefone, message.Cliente.Rg,
                message.Cliente.Email, message.Cliente.DataNascimento, message.Cliente.ProfissaoId,
                message.Cliente.PaisResidenciaId, message.Id, endereco);

            var coberturas = message.Item.Cobertura
                .Select(itemCobertura => new CoberturasItem.CoberturasItemFactory().NewCoberturasItem(itemCobertura.Id,
                    message.Item.Id, itemCobertura.CoberturaId, itemCobertura.Valor))
                .ToList();

            var item = new Item.ItemFactory().NewItem(message.Item.Id, message.Item.ProdutoId, message.Item.ModeloId,
                message.Item.NumChassi, message.Item.FlagRemarcado, message.Item.DataSaida,
                message.Item.Odometro, message.Item.UsoId, message.Item.ImpostoId, message.Id, coberturas);

            var questionario = new Questionario.QuestionarioFactory().NewQuestionario(message.Questionario.Id,
                message.Questionario.CepPernoite, message.Questionario.FlagBlindado,
                message.Questionario.FlagAdaptadoDeficiente, message.Questionario.FlagKitGas,
                message.Questionario.FlagAlienado, message.Questionario.FlagAntiFurto, message.Questionario.FlagGararem,
                message.Questionario.RastreadorId, message.Questionario.AntiFurtoId,
                message.Questionario.RelacaoSeguradoId, message.Questionario.GararemResidenciaId,
                message.Questionario.GararemTrabalhoId, message.Questionario.GaragemFaculdadeId,
                message.Questionario.PropriedadeRastreadorId, message.Id);

            var perfil = new Perfil.PerfilFactory().NewPerfil(message.Perfil.Id, message.Perfil.CpfPrincipalCondutor,
                message.Perfil.NomePrincipalCondutor, message.Perfil.DataNascPrincipalCondutor,
                message.Perfil.FlagResideMenorIdade, message.Perfil.FlagSegPrincipalCondutor,
                message.Perfil.FlagPontosCarteira, message.Perfil.EstadoCivilId, message.Perfil.TipoResidenciaId,
                message.Perfil.SexoId, message.Perfil.TempoHabilitacaoId, message.Perfil.DistanciaTrabalhoId,
                message.Perfil.QuantidadeVeiculoId, message.Id);

            var cotacao = Cotacao.CotacaoFactory.NewCotacao(message.Id, message.NumCotacao, message.DataCalculo,
                message.DataCadastro, message.DataVigenciaInicial, message.DataVigenciaFinal, message.UserId,
                message.PremioTotal, message.TipoCalculoId, message.TipoSeguroId, cliente, item, questionario, perfil);

            if (!VerificarCotacaoValida(cotacao))
                return;

            //Validações de Negócios
            //cotacao.Calcular(cotacao, _calculoService.CalcularPremio(cotacao));

            //Persistencia
            _cotacaoRepository.Adicionar(cotacao);

            if (Commit())
            {
                _bus.RaiseEvent(new CotacaoRegistradoEvent(cotacao.Id, cotacao.NumCotacao,
                    cotacao.DataCalculo, cotacao.DataCadastro, cotacao.DataVigenciaInicial,
                    cotacao.DataVigenciaFinal, cotacao.UserId, cotacao.PremioTotal,
                    cotacao.TipoCalculoId, cotacao.TipoSeguroId));
            }
        }

        public void Handle(AtualizarCotacaoCommand message)
        {
            var cotacaoAtual = _cotacaoRepository.ObterPorId(message.Id);

            if (!VerificarCotacaoExistente(message.Id, message.MessageType))
                return;

            if (cotacaoAtual.UserId != _user.GetUserId())
            {
                _bus.RaiseEvent(new DomainNotification(message.MessageType, "Cotação não pertencente ao Usuário"));
                return;
            }

            var cotacao = Cotacao.CotacaoFactory.NewCotacao(message.Id, message.NumCotacao, message.DataCalculo,
                message.DataCadastro, message.DataVigenciaInicial, message.DataVigenciaFinal, message.UserId,
                message.PremioTotal, message.TipoCalculoId, message.TipoSeguroId, cotacaoAtual.Cliente,
                cotacaoAtual.Item, cotacaoAtual.Questionario, cotacaoAtual.Perfil);
            
            if (!VerificarCotacaoValida(cotacao))
                return;

            _cotacaoRepository.Atualizar(cotacao);

            if (Commit())
            {
                _bus.RaiseEvent(new CotacaoAtualizadoEvent(cotacao.Id, cotacao.NumCotacao,
                    cotacao.DataCalculo, cotacao.DataCadastro, cotacao.DataVigenciaInicial,
                    cotacao.DataVigenciaFinal, cotacao.UserId, cotacao.PremioTotal,
                    cotacao.TipoCalculoId, cotacao.TipoSeguroId));
            }
        }

        public void Handle(RemoverCotacaoCommand message)
        {
            if (!VerificarCotacaoExistente(message.Id, message.MessageType))
                return;

            _cotacaoRepository.Remover(message.Id);

            if (Commit())
            {
                _bus.RaiseEvent(new CotacaoRemoverEvent(message.Id));
            }
        }

        private bool VerificarCotacaoValida(Cotacao cotacao)
        {
            if (cotacao.IsValid())
                return true;

            NotificarValidacoesError(cotacao.ValidationResult);
            return false;
        } 

        private bool VerificarCotacaoExistente(Guid id, string messageType)
        {
            var cotacao = _cotacaoRepository.ObterPorId(id);

            if (cotacao != null)
                return true;

            _bus.RaiseEvent(new DomainNotification(messageType, "Cotacao não encontrada"));
            return false;
        }
    }
}