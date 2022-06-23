using BlazorMovies.Shared.DTOs;
using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Client.Repository
{
    public interface IMoviesRepository
    {
        Task<int> CreateMovie(Movie movie);
        Task<MovieUpdateDTO> GetMovieForUpdate(int id);
        Task<IndexPageDTO> GetIndexPageDTO();

        Task<DetailsMovieDTO> GetDetailsMovieDTO(int id);
        Task UpdateMovie(Movie movie);
        Task DeleteMovie(int Id);
    }
}
