using System;
using ExemploSeguros.Domain.Core.Models;
using ExemploSeguros.Domain.Models.CotacaoRoot;
using ExemploSeguros.Domain.Validations;

namespace ExemploSeguros.Domain.Models.PerfilRoot
{
    public class Perfil : Entity<Perfil>
    {
        public Perfil(string cpfPrincipalCondutor, string nomePrincipalCondutor, DateTime dataNascPrincipalCondutor, bool flagResideMenorIdade, bool flagSegPrincipalCondutor, bool flagPontosCarteira, int estadoCivilId, int tipoResidenciaId, int sexoId, int tempoHabilitacaoId, int distanciaTrabalhoId, int quantidadeVeiculoId, Guid cotacaoId)
        {
            Id = Guid.NewGuid();
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

        protected Perfil() { }

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

        public virtual QuantidadeVeiculos QuantidadeVeiculos { get; private set; }

        public virtual DistanciaTrabalho DistanciaTrabalho { get; private set; }

        public virtual Sexo Sexo { get; private set; }

        public virtual TempoHabilitacao TempoHabilitacao { get; private set; }

        public virtual EstadoCivil EstadoCivil { get; private set; }

        public virtual TipoResidencia TipoResidencia { get; private set; }

        public virtual Cotacao Cotacao { get; private set; }

        public override bool IsValid()
        {
            ValidationResult = new PerfilEstaConsistenteValidation().Validate(this);
            return ValidationResult.IsValid;
        }

        #region Factory
        public class PerfilFactory
        {
            public Perfil NewPerfil(Guid id, string cpfPrincipalCondutor, string nomePrincipalCondutor, DateTime dataNascPrincipalCondutor, bool flagResideMenorIdade, bool flagSegPrincipalCondutor, bool flagPontosCarteira, int estadoCivilId, 
                int tipoResidenciaId, int sexoId, int tempoHabilitacaoId, int distanciaTrabalhoId, int quantidadeVeiculoId, Guid cotacaoId)
            {
                var perfil = new Perfil
                {
                    Id = id,
                    CpfPrincipalCondutor = cpfPrincipalCondutor,
                    NomePrincipalCondutor = nomePrincipalCondutor,
                    DataNascPrincipalCondutor = dataNascPrincipalCondutor,
                    FlagResideMenorIdade = flagResideMenorIdade,
                    FlagSegPrincipalCondutor = flagSegPrincipalCondutor,
                    FlagPontosCarteira = flagPontosCarteira,
                    EstadoCivilId = estadoCivilId,
                    TipoResidenciaId = tipoResidenciaId,
                    SexoId = sexoId,
                    TempoHabilitacaoId = tempoHabilitacaoId,
                    DistanciaTrabalhoId = distanciaTrabalhoId,
                    QuantidadeVeiculoId = quantidadeVeiculoId,
                    CotacaoId = cotacaoId
                };

                return perfil;
            }
        }
        #endregion
    }
}