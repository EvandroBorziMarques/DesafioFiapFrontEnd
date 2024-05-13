using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Interface.Models
{
    public class Turma
    {
        public int Id { get; set; }

        public int? Course { get; set; }
        [MaxLength(45)]
        public string? Class { get; set; }

        public int? Year { get; set; }
    }
}
