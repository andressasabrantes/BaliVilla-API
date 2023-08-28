using BaliVilla_VillaAPI.Models;
using BaliVilla_VillaAPI.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace BaliVilla_VillaAPI.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return new List<VillaDTO>
            {
                new VillaDTO {Id=1, Name="Ocean View"},
                new VillaDTO {Id=2, Name="Pool View"}
            };
        }

    }
}
