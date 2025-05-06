using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarOwners.Core.Dtos;
using CarOwners.Infrastructure.Repositories;

namespace CarOwners.Core.Services
{
    public class ProprietarService : IProprietarService
    {
        private readonly IProprietarRepository _proprietarRepository;

        public ProprietarService(IProprietarRepository proprietarRepository)
        {
            _proprietarRepository = proprietarRepository;
        }

        public async Task<List<ProprietarDto>> GetAllProprietariWithMasiniAsync()
        {
            var proprietari = await _proprietarRepository.GetAllWithMasiniAsync();

            return proprietari.Select(p => new ProprietarDto
            {
                Id = p.Id,
                Nume = p.Nume,
                Prenume = p.Prenume,
                Masini = p.Masini.Select(m => new MasinaDto
                {
                    Id = m.Id,
                    Marca = m.Marca,
                    Model = m.Model
                }).ToList()
            }).ToList();
        }
    }
}