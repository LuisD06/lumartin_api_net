using LumartinApiNet.Domain.Models;
using LumartinApiNet.Domain.Repository;
using RestSharp;

namespace LumartinApiNet.Infraestructure.Repository
{
    public class RickAndMortyRepository : IRickAndMortyRepository
    {
        public ICollection<RickAndMorty> GetAll()
        {
            var client = new RestClient("https://rickandmortyapi.com/api/character");
            client.Timeout = -1;
            var request = new RestRequest(Method.Get);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}