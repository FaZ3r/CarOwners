using System.Collections.Generic;
using System.Threading.Tasks;
using CarOwners.Database;
using CarOwners.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace CarOwners.Infrastructure.Repositories
{
    public class ProprietarRepository : IProprietarRepository
    {
        private readonly CarOwnersDbContext _context;

        public ProprietarRepository(CarOwnersDbContext context)
        {
            _context = context;
        }

        public async Task<List<Proprietar>> GetAllWithMasiniAsync()
        {
            return await _context.Proprietari
                .Include(p => p.Masini)
                .ToListAsync();
        }
    }
}