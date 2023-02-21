using System.ComponentModel.DataAnnotations;

namespace LocadoraApi.Models
{
    public class Jogo
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Estudio { get; set; }
        [Required]
        public int AnoLancamento { get; set; }
        [Required]
        public string Genero { get; set; }
        [Required]
        public int QuantidadeTotalDeEstoque { get; set; }
        [Required]
        public int QuantidadeAtualEmEstoque { get; set; }
    }
}
