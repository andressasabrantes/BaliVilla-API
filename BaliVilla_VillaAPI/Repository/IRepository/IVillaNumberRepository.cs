using BaliVilla_VillaAPI.Models;
using System.Linq.Expressions;

namespace BaliVilla_VillaAPI.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber>
    {
        Task<VillaNumber> UpdateAsync(VillaNumber entity);
    }
}