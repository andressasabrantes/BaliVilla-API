using BaliVilla_VillaAPI.Models;
using System.Linq.Expressions;

namespace BaliVilla_VillaAPI.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa>
    {
        Task<Villa> UpdateAsync(Villa entity);
    }
}