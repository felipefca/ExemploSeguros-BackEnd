using System;
using ExemploSeguros.Domain.Core.Commands;

namespace ExemploSeguros.Domain.Commands.ClienteCommand
{
    public class IncluirCoberturaEventoCommand : Command
    {
        public IncluirCoberturaEventoCommand(Guid id, Guid itemId, int coberturaId, double valor)
        {
            Id = id;
            ItemId = itemId;
            CoberturaId = coberturaId;
            Valor = valor;
        }

        public Guid Id { get; private set; }

        public Guid ItemId { get; private set; }

        public int CoberturaId { get; private set; }

        public double Valor { get; private set; }
    }
}