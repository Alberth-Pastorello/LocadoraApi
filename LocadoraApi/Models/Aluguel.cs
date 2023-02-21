using System.ComponentModel.DataAnnotations;

namespace LocadoraApi.Models
{
    public class Aluguel
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual Jogo Jogo { get; set; }
        public static int totalRegistro { get; set; }
        public string Estado { get; set; }
    }
}
