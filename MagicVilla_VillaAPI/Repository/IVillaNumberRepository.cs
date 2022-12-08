using System;
using System.Linq.Expressions;
using MagicVilla_VillaAPI.Models;

namespace MagicVilla_VillaAPI.Repository.IRepository
{
    public interface IVillaNumberRepository : IRepository<VillaNumber> //T = Villa class로 IRepository interface 상속. 
    {

        Task<VillaNumber> UpdateAsync(VillaNumber entiry);

    }
}

