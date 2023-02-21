using System.ComponentModel.DataAnnotations;

namespace LocadoraApi.Data.Dtos.Jogo
{
    public class CriaJogoDto
    {
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Estudio { get; set; }
        [Required]
        public int AnoLancamento { get; set; }
        public string Genero { get; set; }
        [Required]
        public int QuantidadeTotalDeEstoque { get; set; }
        public int QuantidadeAtualEmEstoque { get; set; }
    }
}
