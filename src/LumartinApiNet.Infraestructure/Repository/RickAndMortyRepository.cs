using System.Text.Json;
using LumartinApiNet.Domain.Models;
using LumartinApiNet.Domain.Repository;
using RestSharp;

namespace LumartinApiNet.Infraestructure.Repository
{
    public class RickAndMortyRepository : IRickAndMortyRepository
    {
        public async Task<ICollection<RickAndMorty>> GetAll()
        {
            var client = new RestSharp.RestClient("https://rickandmortyapi.com/api");
            var request = new RestSharp.RestRequest("/character");
            var response = await client.GetAsync(request);
            var responseContent = response.Content;
            var list = new List<RickAndMorty>();
            var resultEntity = JsonSerializer.Deserialize<Root>(responseContent);


            return resultEntity.results;
        }
    }
}