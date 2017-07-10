using System;
using System.Collections.Generic;
using ExemploSeguros.Domain.Core.Commands;

namespace ExemploSeguros.Domain.Commands.ClienteCommand
{
    public class IncluirItemEventoCommand : Command
    {
        public IncluirItemEventoCommand(Guid id, int produtoId, int modeloId, long? numChassi, bool flagRemarcado, string dataSaida, int? odometro, 
            int usoId, int impostoId, Guid cotacaoId, List<IncluirCoberturaEventoCommand> listCoberturasItem)
        {
            Id = id;
            ProdutoId = produtoId;
            ModeloId = modeloId;
            NumChassi = numChassi;
            FlagRemarcado = flagRemarcado;
            DataSaida = dataSaida;
            Odometro = odometro;
            UsoId = usoId;
            ImpostoId = impostoId;
            CotacaoId = cotacaoId;
            Cobertura = listCoberturasItem;
        }

        public Guid Id { get; private set; }
        public int ProdutoId { get; private set; }
        public int ModeloId { get; private set; }
        public long? NumChassi { get; private set; }
        public bool FlagRemarcado { get; private set; }
        public string DataSaida { get; private set; }
        public int? Odometro { get; private set; }
        public int UsoId { get; private set; }
        public int ImpostoId { get; private set; }
        public Guid CotacaoId { get; private set; }
        public List<IncluirCoberturaEventoCommand> Cobertura { get; private set; }
    }
}