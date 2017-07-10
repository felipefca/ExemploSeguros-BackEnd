using ExemploSeguros.Application.Interfaces;
using ExemploSeguros.Application.ViewModels;
using ExemploSeguros.Domain.Core.Interfaces;
using ExemploSeguros.Domain.Core.Notifications;
using ExemploSeguros.Domain.Interfaces.User;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;


namespace ExemploSeguros.Services.WebApi.Controllers
{
    public class PerfilController : BaseController
    {
        private readonly IPerfilAppService _perfilAppService;

        public PerfilController(IDomainNotificationHandler<DomainNotification> notifications, 
                                IUser user,
                                IBus bus,
                                IPerfilAppService perfilAppService) 
            : base(notifications, user, bus)
        {
            _perfilAppService = perfilAppService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("perfil/ObterDistancias")]
        public IEnumerable<DistanciaTrabalhoViewModel> ObterDistancias()
        {
            return _perfilAppService.ObterDistancias();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("perfil/ObterEstadoCivis")]
        public IEnumerable<EstadoCivilViewModel> ObterEstadoCivis()
        {
            return _perfilAppService.ObterEstadoCivis();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("perfil/ObterQuantidadeVeiculos")]
        public IEnumerable<QuantidadeVeiculosViewModel> ObterQuantidadeVeiculos()
        {
            return _perfilAppService.ObterQuantidadeVeiculos();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("perfil/ObterSexos")]
        public IEnumerable<SexoViewModel> ObterSexos()
        {
            return _perfilAppService.ObterSexos();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("perfil/ObterTempoHabilitacao")]
        public IEnumerable<TempoHabilitacaoViewModel> ObterTempoHabilitacao()
        {
            return _perfilAppService.ObterTempoHabilitacao();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("perfil/ObterTipoResidencia")]
        public IEnumerable<TipoResidenciaViewModel> ObterTipoResidencia()
        {
            return _perfilAppService.ObterTipoResidencia();
        }
    }
}