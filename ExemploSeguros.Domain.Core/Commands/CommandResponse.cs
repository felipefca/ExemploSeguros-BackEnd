namespace ExemploSeguros.Domain.Core.Commands
{
    public class CommandResponse
    {
        public CommandResponse(bool suscess = false)
        {
            Success = suscess;
        }

        public static CommandResponse Ok = new CommandResponse { Success = true};

        public static CommandResponse Fail = new CommandResponse { Success = false };

        public bool Success { get; private set; }
    }
}