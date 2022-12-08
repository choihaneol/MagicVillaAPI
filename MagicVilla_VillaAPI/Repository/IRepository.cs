using System;
using MagicVilla_VillaAPI.Models;
using System.Linq.Expressions;


//for generic repository
namespace MagicVilla_VillaAPI.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null,
            int pageSize = 0, int pageNumber = 1); //? : can be null

        Task<T> GetAsync(Expression<Func<T, bool>> filter = null, bool tracked = true);

        Task CreateAsync(T entity);

        Task RemoveAsync(T entiry);

        Task SaveAsync();
    }
}

