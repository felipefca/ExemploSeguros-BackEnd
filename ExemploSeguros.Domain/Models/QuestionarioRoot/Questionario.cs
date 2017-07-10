using System;
using ExemploSeguros.Domain.Core.Models;
using ExemploSeguros.Domain.Models.CotacaoRoot;
using ExemploSeguros.Domain.Validations;

namespace ExemploSeguros.Domain.Models.QuestionarioRoot
{
    public class Questionario : Entity<Questionario>
    {
        public Questionario(string cepPernoite, bool flagBlindado, bool flagAdaptadoDeficiente, bool flagKitGas, bool flagAlienado, bool flagAntiFurto, bool flagGararem, int? rastreadorId, int? antiFurtoId, int relacaoSeguradoId, int? gararemResidenciaId, int? gararemTrabalhoId, int? garagemFaculdadeId, int? propriedadeRastreadorId, Guid cotacaoId)
        {
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

        protected Questionario() { }

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

        public virtual Rastreador Rastreador { get; private set; }

        public virtual AntiFurto AntiFurto { get; private set; }

        public virtual RelacaoSegurado RelacaoSegurado { get; private set; }

        public virtual GararemResidencia GararemResidencia { get; private set; }

        public virtual GararemTrabalho GararemTrabalho { get; private set; }

        public virtual GararemFaculdade GararemFaculdade { get; private set; }

        public virtual PropriedadeRastreador PropriedadeRastreador { get; private set; }

        public virtual Cotacao Cotacao { get; private set; }

        public override bool IsValid()
        {
            ValidationResult = new QuestionarioEstaConsitenteValidation().Validate(this);
            return ValidationResult.IsValid;
        }

        #region Factory

        public class QuestionarioFactory
        {
            public Questionario NewQuestionario(Guid id, string cepPernoite, bool flagBlindado,
                bool flagAdaptadoDeficiente, bool flagKitGas, bool flagAlienado, bool flagAntiFurto, bool flagGararem,
                int? rastreadorId, int? antiFurtoId,
                int relacaoSeguradoId, int? gararemResidenciaId, int? gararemTrabalhoId, int? garagemFaculdadeId,
                int? propriedadeRastreadorId, Guid cotacaoId)
            {
                var questionario = new Questionario
                {
                    Id = id,
                    CepPernoite = cepPernoite,
                    FlagBlindado = flagBlindado,
                    FlagAdaptadoDeficiente = flagAdaptadoDeficiente,
                    FlagKitGas = flagKitGas,
                    FlagAntiFurto = flagAntiFurto,
                    FlagGararem = flagGararem,
                    RelacaoSeguradoId = relacaoSeguradoId,
                    CotacaoId = cotacaoId
                };

                if (rastreadorId.HasValue)
                    questionario.RastreadorId = rastreadorId.Value;

                if (antiFurtoId.HasValue)
                    questionario.AntiFurtoId = antiFurtoId.Value;

                if (gararemResidenciaId.HasValue)
                    questionario.GararemResidenciaId = gararemResidenciaId.Value;

                if (gararemTrabalhoId.HasValue)
                    questionario.GararemTrabalhoId = gararemTrabalhoId.Value;

                if (garagemFaculdadeId.HasValue)
                    questionario.GaragemFaculdadeId = garagemFaculdadeId.Value;

                if (propriedadeRastreadorId.HasValue)
                    questionario.PropriedadeRastreadorId = propriedadeRastreadorId.Value;

                return questionario;
            }
        }

        #endregion 
    }
}