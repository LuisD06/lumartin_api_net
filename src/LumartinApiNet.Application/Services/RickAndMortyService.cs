using LumartinApiNet.Application.Dto;
using LumartinApiNet.Domain.Repository;

namespace LumartinApiNet.Application.Services;

public class RickAndMortyService : IRickAndMortyService
{
    private readonly IRickAndMortyRepository repository;

    public RickAndMortyService(IRickAndMortyRepository repository)
    {
        this.repository = repository;
    }
    public async Task<ICollection<RickAndMortyDto>> GetAll()
    {
        var resultList = await repository.GetAll();

        // Mapeo Entidad -> Dto
        var entityDtoList = resultList.Select(i => new RickAndMortyDto() {
            id = i.id,
            name = i.name
        });

        return entityDtoList.ToList();
    }
}
