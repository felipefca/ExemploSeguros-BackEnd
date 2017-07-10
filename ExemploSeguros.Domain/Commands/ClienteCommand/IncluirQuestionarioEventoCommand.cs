using System;
using ExemploSeguros.Domain.Core.Commands;

namespace ExemploSeguros.Domain.Commands.ClienteCommand
{
    public class IncluirQuestionarioEventoCommand : Command
    {
        public IncluirQuestionarioEventoCommand(Guid id, string cepPernoite, bool flagBlindado, bool flagAdaptadoDeficiente, bool flagKitGas, bool flagAlienado, bool flagAntiFurto, bool flagGararem, int? rastreadorId, int? antiFurtoId, int relacaoSeguradoId, int? gararemResidenciaId, int? gararemTrabalhoId, int? garagemFaculdadeId, int? propriedadeRastreadorId, Guid cotacaoId)
        {
            Id = id;
            CepPernoite = cepPernoite;
            FlagBlindado = flagBlindado;
            FlagAdaptadoDeficiente = flagAdaptadoDeficiente;
            FlagKitGas = flagKitGas;
            FlagAlienado = flagAlienado;
            FlagAntiFurto = flagAntiFurto;
            FlagGararem = flagGararem;
            RastreadorId = rastreadorId;
            AntiFurtoId = antiFurtoId;
            RelacaoSeguradoId = relacaoSeguradoId;
            GararemResidenciaId = gararemResidenciaId;
            GararemTrabalhoId = gararemTrabalhoId;
            GaragemFaculdadeId = garagemFaculdadeId;
            PropriedadeRastreadorId = propriedadeRastreadorId;
            CotacaoId = cotacaoId;
        }

        public Guid Id { get; private set; }
        public string CepPernoite { get; private set; }
        public bool FlagBlindado { get; private set; }
        public bool FlagAdaptadoDeficiente { get; private set; }
        public bool FlagKitGas { get; private set; }
        public bool FlagAlienado { get; private set; }
        public bool FlagAntiFurto { get; private set; }
        public bool FlagGararem { get; private set; }
        public int? RastreadorId { get; private set; }
        public int? AntiFurtoId { get; private set; }
        public int RelacaoSeguradoId { get; private set; }
        public int? GararemResidenciaId { get; private set; }
        public int? GararemTrabalhoId { get; private set; }
        public int? GaragemFaculdadeId { get; private set; }
        public int? PropriedadeRastreadorId { get; private set; }
        public Guid CotacaoId { get; private set; }
    }
}