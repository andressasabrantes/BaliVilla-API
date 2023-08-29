using BaliVilla_VillaAPI.Models.Dto;

namespace BaliVilla_VillaAPI.Data
{
    public class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>
        {
            new VillaDTO {Id=1, Name="Ocean View", Sqft=100, Occupancy=4},
            new VillaDTO {Id=2, Name="Pool View", Sqft=300, Occupancy=6}
        };
    }
}
