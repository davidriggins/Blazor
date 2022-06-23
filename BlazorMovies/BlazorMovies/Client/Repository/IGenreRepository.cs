using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Client.Repository
{
    public interface IGenreRepository
    {
        Task CreateGenre(Genre genre);
        Task<List<Genre>> GetGenres();
        Task<Genre> GetGenres(int Id);
        Task UpdateGenre(Genre genre);
    }
}
