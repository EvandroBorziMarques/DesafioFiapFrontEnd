using System.ComponentModel.DataAnnotations;

namespace Interface.Models
{
    public class Aluno
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [MaxLength(45)]
        public string User { get; set; }

        [Required]
        [MaxLength(60)]
        public string Password { get; set; }
    }
}
