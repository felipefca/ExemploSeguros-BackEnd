using ExemploSeguros.Application.Interfaces;
using ExemploSeguros.Application.ViewModels;
using ExemploSeguros.Domain.Core.Interfaces;
using ExemploSeguros.Domain.Core.Notifications;
using ExemploSeguros.Domain.Interfaces.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace ExemploSeguros.Services.WebApi.Controllers
{
    public class CotacaoController : BaseController
    {
        private readonly ICotacaoAppService _cotacaoAppService;
        private readonly ITipoCalculoAppService _tipoCalculoAppService;
        private readonly ITipoSeguroAppService _tipoSeguroAppService;

        public CotacaoController(IDomainNotificationHandler<DomainNotification> notifications, 
                                 IUser user, IBus bus, 
                                 ICotacaoAppService cotacaoAppService, 
                                 ITipoCalculoAppService tipoCalculoAppService,
                                 ITipoSeguroAppService tipoSeguroAppService)
            : base(notifications, user, bus)
        {
            _cotacaoAppService = cotacaoAppService;
            _tipoCalculoAppService = tipoCalculoAppService;
            _tipoSeguroAppService = tipoSeguroAppService;
        }

        [HttpGet]
        [Route("cotacoes/minhas-cotacoes/{userId}")]
        [AllowAnonymous]
        public IEnumerable<CotacaoViewModel> ObterCotacoesUsuario(Guid userId)
        {
            return _cotacaoAppService.ObterCotacoesPorUsuario(userId);
        }

        [HttpGet]
        [Route("cotacoes/ObterCotacao/{cotacaoId}")]
        [AllowAnonymous]
        public CotacaoViewModel ObterCotacaoPorId(Guid cotacaoId)
        {
            return _cotacaoAppService.ObterCotacaoPorId(cotacaoId);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("cotacoes/tiposcalculo")]
        public IEnumerable<TipoCalculoViewModel> ObterTiposCalculo()
        {
            return _tipoCalculoAppService.ObterTiposCalculo();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("cotacoes/tiposcalculo/{id:int}")]
        public TipoCalculoViewModel ObterTipoCalculoPorId(int tipoCalculoId)
        {
            return _tipoCalculoAppService.ObterTipoCalculoPorId(tipoCalculoId);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("cotacoes/tiposseguro")]
        public IEnumerable<TipoSeguroViewModel> ObterTiposSeguro()
        {
            return _tipoSeguroAppService.ObterTiposSeguro();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("cotacoes/ObterNumeroCotacao")]
        public string ObterNumeroCotacao()
        {
            return _cotacaoAppService.GeneratorNumber();
        }

        [HttpPost]
        [Route("cotacoes")]
        [AllowAnonymous]
        //[Authorize(Policy = "PodeGravar")]
        public IActionResult AdicionarCotacao([FromBody]CotacaoViewModel cotacaoViewModel)
        {
            if (!ModelState.IsValid)
            {
                NotificarErroModelInvalida();
                return Response();
            }

            var registroCommand = _cotacaoAppService.Adicionar(cotacaoViewModel);
            return Response(registroCommand);
        }

        [HttpPut]
        [Route("cotacoes")]
        [AllowAnonymous]
        //[Authorize(Policy = "PodeGravar")]
        public IActionResult AtualizarCotacoes([FromBody]CotacaoViewModel cotacaoViewModel)
        {
            if (!ModelState.IsValid)
            {
                NotificarErroModelInvalida();
                return Response();
            }

            _cotacaoAppService.Atualizar(cotacaoViewModel);
            return Response(cotacaoViewModel);
        }

        [HttpDelete]
        [Route("cotacoes/{id:guid}")]
        [Authorize(Policy = "PodeGravar")]
        public IActionResult RemoverCotacoes(Guid id)
        {
            _cotacaoAppService.Remover(id);
            return Response();
        }
    }
}