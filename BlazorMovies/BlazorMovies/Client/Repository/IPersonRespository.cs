using BlazorMovies.Shared.DTOs;
using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Client.Repository
{
    public interface IPersonRespository
    {
        Task<PaginatedResponse<List<Person>>> GetPeople(PaginationDTO paginationDTO);
        Task<Person> GetPersonById(int id);
        Task CreatePerson(Person person);
        Task<List<Person>> GetPeopleByName(string name);
        Task UpdatePerson(Person person);
        Task DeletePerson(int Id);
    }
}
