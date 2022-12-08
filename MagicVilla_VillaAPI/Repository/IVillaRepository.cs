using System;
using System.Linq.Expressions;
using MagicVilla_VillaAPI.Models;

namespace MagicVilla_VillaAPI.Repository.IRepository
{
    public interface IVillaRepository : IRepository<Villa> //T = Villa class로 IRepository interface 상속. 
    {

        Task<Villa> UpdateAsync(Villa entiry);

    }
}

