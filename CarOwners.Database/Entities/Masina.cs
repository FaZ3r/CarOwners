using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarOwners.Database.Entities
{
    public class Masina
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Marca { get; set; }

        [Required]
        [MaxLength(50)]
        public string Model { get; set; }

        [ForeignKey("Proprietar")]
        public int ProprietarId { get; set; }

        public Proprietar Proprietar { get; set; }
    }
}