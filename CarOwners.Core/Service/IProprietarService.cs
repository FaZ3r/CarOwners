using System.Collections.Generic;
using System.Threading.Tasks;
using CarOwners.Core.Dtos;

namespace CarOwners.Core.Services
{
    public interface IProprietarService
    {
        Task<List<ProprietarDto>> GetAllProprietariWithMasiniAsync();
    }
}