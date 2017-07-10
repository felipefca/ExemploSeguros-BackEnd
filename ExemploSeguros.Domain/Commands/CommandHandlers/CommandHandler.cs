using ExemploSeguros.Domain.Core.Interfaces;
using ExemploSeguros.Domain.Core.Notifications;
using ExemploSeguros.Domain.Interfaces.Uow;
using FluentValidation.Results;

namespace ExemploSeguros.Domain.Commands.CommandHandlers
{
    public abstract class CommandHandler
    {
        private readonly IUnitOfWork _uow;
        private readonly IBus _bus;
        private readonly IDomainNotificationHandler<DomainNotification> _notifications;

        protected CommandHandler(IUnitOfWork uow, IBus bus, IDomainNotificationHandler<DomainNotification> notifications)
        {
            _uow = uow;
            _bus = bus;
            _notifications = notifications;
        }

        protected void NotificarValidacoesError(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                _bus.RaiseEvent(new DomainNotification(error.PropertyName, error.ErrorMessage));
            }
        }

        protected bool Commit()
        {
            if (_notifications.HasNotification())
                return false;

            var commandResponse = _uow.Commit();

            if (commandResponse.Success)
                return true;

            _bus.RaiseEvent(new DomainNotification("Commit", "Ocorreu um erro ao Salvar os dados no banco!"));

            return false;
        }
    }
}