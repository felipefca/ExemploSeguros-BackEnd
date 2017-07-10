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
    public class ItemController : BaseController
    {
        private readonly IItemAppService _itemAppService;
        private readonly IImpostoAppService _impostoAppService;
        private readonly IUsoAppService _usoAppService;
        private readonly IProdutoAppService _produtoAppService;
        private readonly IMarcaAppService _marcaAppService;
        private readonly IModeloAppService _modeloAppService;

        public ItemController(IDomainNotificationHandler<DomainNotification> notifications, 
                              IUser user,
                              IBus bus,
                              IItemAppService itemAppService,
                              IImpostoAppService impostoAppService,
                              IUsoAppService usoAppService,
                              IProdutoAppService produtoAppService,
                              IMarcaAppService marcaAppService,
                              IModeloAppService modeloAppService) 
            : base(notifications, user, bus)
        {
            _itemAppService = itemAppService;
            _impostoAppService = impostoAppService;
            _usoAppService = usoAppService;
            _produtoAppService = produtoAppService;
            _marcaAppService = marcaAppService;
            _modeloAppService = modeloAppService;
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("itens/ObterImpostos")]
        public IEnumerable<ImpostoViewModel> ObterImpostos()
        {
            return _impostoAppService.ObterImpostos();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("itens/ObterUsos")]
        public IEnumerable<UsoViewModel> ObterUsos()
        {
            return _usoAppService.ObterUsos();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("itens/ObterMarcas")]
        public IEnumerable<MarcaViewModel> ObterMarcas()
        {
            return _marcaAppService.ObterMarcas();
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("itens/ObterModelosMarca/{marcaId}/{nomeModelo}/{anoFabricacao}/{anoModelo}/{zeroKm}")]
        public IEnumerable<ModeloViewModel> ObterTodosModelosSelecionadosOrdenadamente(int marcaId, string nomeModelo, string anoFabricacao, string anoModelo, string zeroKm)
        {
            return _modeloAppService.ObterTodosModelosSelecionadosOrdenadamente(marcaId, nomeModelo, anoFabricacao, anoModelo, zeroKm);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("itens/ObterNomeModelosMarca/{marcaId:int}")]
        public List<string> ObterNomeModelosPorMarca(int marcaId)
        {
            return _modeloAppService.ObterNomeModelosPorMarca(marcaId);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("itens/ObterDadosModelo/{modeloId:int}")]
        public ModeloViewModel ObterDadosModelo(int modeloId)
        {
            return _modeloAppService.ObterModeloPorId(modeloId);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("itens/ObterValorModelo/{modeloId:int}")]
        public decimal ObterValorModelo(int modeloId)
        {
            return _modeloAppService.ObterValorModelo(modeloId);
        }

        [HttpGet]
        [AllowAnonymous]
        [Route("itens/ObterFranquiaModelo/{modeloId:int}")]
        public decimal ObterFranquiaModelo(int modeloId)
        {
            return _modeloAppService.ObterFranquiaModelo(modeloId);
        }
    }
}