using System.ComponentModel.DataAnnotations;

namespace LocadoraApi.Data.Dtos.Jogo
{
    public class LeJogoDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Estudio { get; set; }
        public int AnoLancamento { get; set; }
        public string Genero { get; set; }
        public int QuantidadeTotalDeEstoque { get; set; }
        public int QuantidadeAtualEmEstoque { get; set; }
    }
}
