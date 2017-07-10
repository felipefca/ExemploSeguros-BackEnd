namespace ExemploSeguros.Domain.Models.ItemRoot
{
    public class Modelo
    {
        public int ModeloId { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string AnoFabricacao { get; set; }

        public string AnoModelo { get; set; }

        public bool FlagZeroKm { get; set; }

        public decimal Valor { get; set; }

        public decimal Franquia { get; set; }

        public int MarcaId { get; set; }

        public virtual Marca Marca { get; set; }
    }
}