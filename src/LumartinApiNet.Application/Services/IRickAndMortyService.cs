using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LumartinApiNet.Application.Dto;
using LumartinApiNet.Domain.Repository;

namespace LumartinApiNet.Application.Services
{
    public interface IRickAndMortyService
    {
        ICollection<RickAndMortyDto> GetAll();
    }
}