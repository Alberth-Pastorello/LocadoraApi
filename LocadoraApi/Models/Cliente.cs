using System.ComponentModel.DataAnnotations;

namespace LocadoraApi.Models
{
    public class Cliente
    {
        [Key]
        [Required] 
        public string Id { get; set; }
        [Required]
        public string Nome { get; set; }
        [Required]
        public string Endereco { get; set; }
        [Required]
        public string Cpf { get; set; }
    }
}
