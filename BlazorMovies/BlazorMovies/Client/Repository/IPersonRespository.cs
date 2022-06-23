using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Client.Repository
{
    public interface IPersonRespository
    {
        Task<List<Person>> GetPeople();
        Task<Person> GetPersonById(int id);
        Task CreatePerson(Person person);
        Task<List<Person>> GetPeopleByName(string name);
        Task UpdatePerson(Person person);
    }
}
