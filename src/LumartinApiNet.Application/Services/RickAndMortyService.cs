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
    public ICollection<RickAndMortyDto> GetAll()
    {
        var resultList = repository.GetAll();

        // Mapeo Entidad -> Dto
        var entityDtoList = resultList.Select(i => new RickAndMortyDto() {
            id = i.id,
            name = i.name
        });

        return entityDtoList.ToList();
    }
}
