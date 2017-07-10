using ExemploSeguros.Domain.Models.CotacaoRoot;

namespace ExemploSeguros.Domain.Interfaces.Business
{
    public interface ICalculoService
    {
        decimal CalcularPremio(Cotacao cotacao);
    }
}