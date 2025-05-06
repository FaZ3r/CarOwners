using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarOwners.Database.Entities
{
    public class Proprietar
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nume { get; set; }

        [Required]
        [MaxLength(50)]
        public string Prenume { get; set; }

        public List<Masina> Masini { get; set; } = new List<Masina>();
    }
}