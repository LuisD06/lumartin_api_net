using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LumartinApiNet.Application.Dto;
using LumartinApiNet.Application.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace LumartinApiNet.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RickAndMortyController : ControllerBase
    {
        private readonly IRickAndMortyService service;
        public RickAndMortyController(IRickAndMortyService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ICollection<RickAndMortyDto>> GetAll()
        {
            return await service.GetAll();
        }
    }
}