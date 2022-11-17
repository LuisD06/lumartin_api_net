using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LumartinApiNet.Domain.Models;

namespace LumartinApiNet.Domain.Repository
{
    public interface IRickAndMortyRepository
    {
        Task<ICollection<RickAndMorty>> GetAll();
    }
}