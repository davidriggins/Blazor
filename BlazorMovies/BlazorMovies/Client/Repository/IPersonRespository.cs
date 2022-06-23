using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Client.Repository
{
    public interface IPersonRespository
    {
        Task<List<Person>> GetPeople();
        Task CreatePerson(Person person);
        Task<List<Person>> GetPeopleByName(string name);
    }
}
