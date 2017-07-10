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
    public class QuestionarioController : BaseController
    {
        private readonly IQuestionarioAppService _questionarioAppService;

        public QuestionarioController(IDomainNotificationHandler<DomainNotification> notifications,
                                      IUser user,
                                      IBus bus,
                                      IQuestionarioAppService questionarioAppService) 
            : base(notifications, user, bus)
        {
            _questionarioAppService = questionarioAppService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("questionarios/ObterAntiFurtos")]
        public IEnumerable<AntiFurtoViewModel> ObterAntiFurtos()
        {
            return _questionarioAppService.ObterAntiFurtos();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("questionarios/ObterGaragemFaculdades")]
        public IEnumerable<GararemFaculdadeViewModel> ObterGaragemFaculdades()
        {
            return _questionarioAppService.ObterGaragemFaculdades();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("questionarios/ObterGararemTrabalhos")]
        public IEnumerable<GararemTrabalhoViewModel> ObterGararemTrabalhos()
        {
            return _questionarioAppService.ObterGararemTrabalhos();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("questionarios/ObterGararemResidencias")]
        public IEnumerable<GararemResidenciaViewModel> ObterGararemResidencias()
        {
            return _questionarioAppService.ObterGararemResidencias();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("questionarios/ObterPropriedadeRastreadors")]
        public IEnumerable<PropriedadeRastreadorViewModel> ObterPropriedadeRastreadors()
        {
            return _questionarioAppService.ObterPropriedadeRastreadors();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("questionarios/ObterRastreadores")]
        public IEnumerable<RastreadorViewModel> ObterRastreadores()
        {
            return _questionarioAppService.ObterRastreadores();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("questionarios/ObterRelacaoSegurados")]
        public IEnumerable<RelacaoSeguradoViewModel> ObterRelacaoSegurados()
        {
            return _questionarioAppService.ObterRelacaoSegurados();
        }
    }
}