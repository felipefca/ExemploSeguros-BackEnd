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
    public class CoberturasController : BaseController
    {
        private readonly ICoberturasAppService _coberturasAppService;

        public CoberturasController(IDomainNotificationHandler<DomainNotification> notifications, IUser user, IBus bus, ICoberturasAppService coberturasAppService) 
            : base(notifications, user, bus)
        {
            _coberturasAppService = coberturasAppService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("coberturas/ObterCoberturasProdutos/{produtoId:int}")]
        public IEnumerable<CoberturasViewModel> ObterCoberturasProdutos(int produtoId)
        {
            return _coberturasAppService.ObterCoberturasProdutos(produtoId);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("coberturas/VerifyFlagBasic/{produtoId:int}")]
        public int VerifyFlagBasic(int produtoId)
        {
            return _coberturasAppService.ObterIdCoberturaBasica(produtoId);
        }
    }
}