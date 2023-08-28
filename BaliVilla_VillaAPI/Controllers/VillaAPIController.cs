using BaliVilla_VillaAPI.Data;
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
            return VillaStore.villaList;
        }

    }
}
