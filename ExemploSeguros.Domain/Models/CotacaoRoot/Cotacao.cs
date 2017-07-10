using System;
using System.Linq;
using ExemploSeguros.Domain.Core.Models;
using ExemploSeguros.Domain.Models.ClienteRoot;
using ExemploSeguros.Domain.Models.ItemRoot;
using ExemploSeguros.Domain.Models.PerfilRoot;
using ExemploSeguros.Domain.Models.QuestionarioRoot;
using ExemploSeguros.Domain.Validations;

namespace ExemploSeguros.Domain.Models.CotacaoRoot
{
    public class Cotacao : Entity<Cotacao>
    {
        public Cotacao(DateTime dataCalculo, DateTime dataCadastro, DateTime dataVigenciaInicial, DateTime dataVigenciaFinal, Guid userId, decimal premioTotal, int tipoCalculoId, int tipoSeguroId)
        {
            Id = Guid.NewGuid();
            NumCotacao = int.Parse(GeneratorNumber());
            DataCalculo = dataCalculo;
            DataCadastro = dataCadastro;
            DataVigenciaInicial = dataVigenciaInicial;
            DataVigenciaFinal = dataVigenciaFinal;
            UserId = userId;
            PremioTotal = premioTotal;
            TipoCalculoId = tipoCalculoId;
            TipoSeguroId = tipoSeguroId;
        }

        private Cotacao() { }

        public int NumCotacao { get; private set; }

        public DateTime DataCalculo { get; private set; }

        public DateTime DataCadastro { get; private set; }

        public DateTime DataVigenciaInicial { get; private set; }

        public DateTime DataVigenciaFinal { get; private set; }

        public Guid UserId { get; private set; }

        public decimal PremioTotal { get; private set; }

        public int TipoCalculoId { get; private set; }   

        public int TipoSeguroId { get; private set; }

        public virtual TipoCalculo TipoCalculo { get; private set; }

        public virtual TipoSeguro TipoSeguro { get; private set; }

        public virtual Cliente Cliente { get; private set; }

        public virtual Item Item { get; private set; }

        public virtual Questionario Questionario { get; private set; }

        public virtual Perfil Perfil { get; private set; }

        #region Validações
        public static string GeneratorNumber()
        {
            const string chars = "0123456789";
            const int tamanho = 8;
            var random = new Random();
            var result = new string(
                Enumerable.Repeat(chars, tamanho)
                          .Select(s => s[random.Next(s.Length)])
                          .ToArray());

            return result;
        }

        public override bool IsValid()
        {
            ValidationResult = new CotacaoEstaConsistenteValidation().Validate(this);

            ValidarCliente();
            ValidarItem();
            ValidarQuestionario();
            ValidarPerfil();

            return ValidationResult.IsValid;
        }

        public bool Calcular(Cotacao cotacao, decimal valor)
        {
            cotacao.PremioTotal = valor;

            return true;
        }

        private void ValidarCliente()
        {
            if (Cliente.IsValid()) return;

            foreach (var error in Cliente.ValidationResult.Errors)
            {
                ValidationResult.Errors.Add(error);
            }
        }

        private void ValidarItem()
        {
            if (Item.IsValid()) return;

            foreach (var error in Item.ValidationResult.Errors)
            {
                ValidationResult.Errors.Add(error);
            }
        }

        private void ValidarQuestionario()
        {
            if (Questionario.IsValid()) return;

            foreach (var error in Questionario.ValidationResult.Errors)
            {
                ValidationResult.Errors.Add(error);
            }
        }

        private void ValidarPerfil()
        {
            if (Perfil.IsValid()) return;

            foreach (var error in Perfil.ValidationResult.Errors)
            {
                ValidationResult.Errors.Add(error);
            }
        }

        #endregion

        #region Atribuições
        public void AtribuirCliente(Cliente cliente)
        {
            Cliente = cliente;
        }

        public void AtribuirItem(Item item)
        {
            Item = item;
        }

        public void AtribuirPerfil(Perfil perfil)
        {
            Perfil = perfil;
        }

        public void AtribuirQuestioario(Questionario questionario)
        {
            Questionario = questionario;
        }
        #endregion

        #region Factory

        public class CotacaoFactory
        {
            public static Cotacao NewCotacao(Guid id, int numCotacao, DateTime dataCalculo, DateTime dataCadastro,
                DateTime dataVigenciaInicial, DateTime dataVigenciaFinal, Guid userId, decimal premioTotal,
                int tipoCalculoId, int tipoSeguroId, Cliente cliente, Item item, Questionario questionario, Perfil perfil)
            {
                var cotacao = new Cotacao
                {
                    Id = id,
                    NumCotacao = numCotacao,
                    DataCalculo = dataCalculo,
                    DataCadastro = dataCadastro,
                    DataVigenciaInicial = dataVigenciaInicial,
                    DataVigenciaFinal = dataVigenciaFinal,
                    UserId = userId,
                    PremioTotal = premioTotal,
                    TipoCalculoId = tipoCalculoId,
                    TipoSeguroId = tipoSeguroId,
                    Cliente = cliente,
                    Item = item,
                    Questionario = questionario,
                    Perfil = perfil
                };

                return cotacao;
            }
        }

        #endregion
    }
}
