using System.Collections.Generic;
using System.Threading.Tasks;
using CarOwners.Core.Dtos;
using CarOwners.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarOwners.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProprietariController : ControllerBase
    {
        private readonly IProprietarService _proprietarService;

        public ProprietariController(IProprietarService proprietarService)
        {
            _proprietarService = proprietarService;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProprietarDto>>> GetAllProprietari()
        {
            var proprietari = await _proprietarService.GetAllProprietariWithMasiniAsync();
            return Ok(proprietari);
        }
    }
}