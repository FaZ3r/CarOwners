using System.Collections.Generic;
using System.Threading.Tasks;
using CarOwners.Database.Entities;

namespace CarOwners.Infrastructure.Repositories
{
    public interface IProprietarRepository
    {
        Task<List<Proprietar>> GetAllWithMasiniAsync();
    }
}