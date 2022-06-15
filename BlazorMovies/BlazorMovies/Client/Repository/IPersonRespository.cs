using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Client.Repository
{
    public interface IPersonRespository
    {
        Task CreatePerson(Person person);
    }
}
