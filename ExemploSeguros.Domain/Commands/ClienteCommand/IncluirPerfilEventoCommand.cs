using System;

namespace ExemploSeguros.Domain.Commands.ClienteCommand
{
    public class IncluirPerfilEventoCommand
    {
        public IncluirPerfilEventoCommand(Guid id, string cpfPrincipalCondutor, string nomePrincipalCondutor, DateTime dataNascPrincipalCondutor, bool flagResideMenorIdade, bool flagSegPrincipalCondutor, bool flagPontosCarteira, int estadoCivilId, int tipoResidenciaId, int sexoId, int tempoHabilitacaoId, int distanciaTrabalhoId, int quantidadeVeiculoId, Guid cotacaoId)
        {
            Id = id;
            CpfPrincipalCondutor = cpfPrincipalCondutor;
            NomePrincipalCondutor = nomePrincipalCondutor;
            DataNascPrincipalCondutor = dataNascPrincipalCondutor;
            FlagResideMenorIdade = flagResideMenorIdade;
            FlagSegPrincipalCondutor = flagSegPrincipalCondutor;
            FlagPontosCarteira = flagPontosCarteira;
            EstadoCivilId = estadoCivilId;
            TipoResidenciaId = tipoResidenciaId;
            SexoId = sexoId;
            TempoHabilitacaoId = tempoHabilitacaoId;
            DistanciaTrabalhoId = distanciaTrabalhoId;
            QuantidadeVeiculoId = quantidadeVeiculoId;
            CotacaoId = cotacaoId;
        }

        public Guid Id { get; private set; }
        public string CpfPrincipalCondutor { get; private set; }
        public string NomePrincipalCondutor { get; private set; }
        public DateTime DataNascPrincipalCondutor { get; private set; }
        public bool FlagResideMenorIdade { get; private set; }
        public bool FlagSegPrincipalCondutor { get; private set; }
        public bool FlagPontosCarteira { get; private set; }
        public int EstadoCivilId { get; private set; }
        public int TipoResidenciaId { get; private set; }
        public int SexoId { get; private set; }
        public int TempoHabilitacaoId { get; private set; }
        public int DistanciaTrabalhoId { get; private set; }
        public int QuantidadeVeiculoId { get; private set; }
        public Guid CotacaoId { get; private set; }
    }
}