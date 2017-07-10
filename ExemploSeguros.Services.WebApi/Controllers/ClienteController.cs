using ExemploSeguros.Application.Interfaces;
using ExemploSeguros.Application.ViewModels;
using ExemploSeguros.Domain.Core.Interfaces;
using ExemploSeguros.Domain.Core.Notifications;
using ExemploSeguros.Domain.Interfaces.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ExemploSeguros.Services.WebApi.Controllers
{
    public class ClienteController : BaseController
    {
        private readonly IClienteAppService _clienteAppService;
        private readonly IPaisResidenciaAppService _paisResidenciaAppService;
        private readonly IProfissaoAppService _profissaoAppService;

        public ClienteController(IDomainNotificationHandler<DomainNotification> notifications, 
                                 IUser user, 
                                 IBus bus, 
                                 IClienteAppService clienteAppService, 
                                 IPaisResidenciaAppService paisResidenciaAppService, 
                                 IProfissaoAppService profissaoAppService)
            : base(notifications, user, bus)
        {
            _clienteAppService = clienteAppService;
            _paisResidenciaAppService = paisResidenciaAppService;
            _profissaoAppService = profissaoAppService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("clientes/ObterProfissoes")]
        public IEnumerable<ProfissaoViewModel> ObterProfissoes()
        {
            return _profissaoAppService.ObterTodasProfissoes();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("clientes/ObterPaises")]
        public IEnumerable<PaisResidenciaViewModel> ObterPaises()
        {
            return _paisResidenciaAppService.ObterTodosPaises();
        }
    }
}