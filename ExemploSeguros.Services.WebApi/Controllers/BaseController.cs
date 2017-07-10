using ExemploSeguros.Domain.Core.Interfaces;
using ExemploSeguros.Domain.Core.Notifications;
using ExemploSeguros.Domain.Interfaces.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace ExemploSeguros.Services.WebApi.Controllers
{
    [Produces("application/json")]
    public abstract class BaseController : Controller
    {
        private readonly IDomainNotificationHandler<DomainNotification> _notifications;
        private readonly IBus _bus;

        protected Guid UsuarioId { get; set; }

        protected BaseController(IDomainNotificationHandler<DomainNotification> notifications,
                                 IUser user,
                                 IBus bus)
        {
            _notifications = notifications;
            _bus = bus;

            if (user.IsAuthenticated())
            {
                UsuarioId = user.GetUserId();
            }
        }

        protected new IActionResult Response(object result = null)
        {
            if (OperacaoValida())
            {
                return Ok(new
                {
                    success = true,
                    data = result
                });
            }

            return BadRequest(new
            {
                success = false,
                errors = _notifications.GetNotification().Select(n => n.Value)
            });
        }

        protected bool OperacaoValida()
        {
            return (!_notifications.HasNotification());
        }

        protected void NotificarErroModelInvalida()
        {
            var erros = ModelState.Values.SelectMany(v => v.Errors);
            foreach (var erro in erros)
            {
                var erroMsg = erro.Exception == null ? erro.ErrorMessage : erro.Exception.Message;
                NotificarErro(string.Empty, erroMsg);
            }
        }

        protected void NotificarErro(string codigo, string mensagem)
        {
            _bus.RaiseEvent(new DomainNotification(codigo, mensagem));
        }

        protected void AdicionarErrosIdentity(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                NotificarErro(result.ToString(), error.Description);
            }
        }
    }
}