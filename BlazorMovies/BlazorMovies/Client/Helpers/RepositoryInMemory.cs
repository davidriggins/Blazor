using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Client.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
        {
            new Movie(){Title = "Spider-Man: Far From Home", 
                ReleaseDate = new DateTime(2019, 7, 2), 
                Poster = "https://themify.me/demo/themes/ptb-movies/files/2020/06/Spider-Man-Far-From-Home.jpg"},
            new Movie(){Title = "Moana", 
                ReleaseDate = new DateTime(2016, 11, 23), 
                Poster = "https://lumiere-a.akamaihd.net/v1/images/p_moana_20530_214883e3.jpeg"},
            new Movie(){Title = "Inception", 
                ReleaseDate = new DateTime(2010, 7, 16), 
                Poster = "https://thenationroar.com/wp-content/uploads/2020/01/inceptionmovieposter-frombreaknenter.org_-1200x879.png"},
        };
        }
    }
}
