using System.Collections.Generic;

namespace CarOwners.Core.Dtos
{
    public class ProprietarDto
    {
        public int Id { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public List<MasinaDto> Masini { get; set; }
    }
}