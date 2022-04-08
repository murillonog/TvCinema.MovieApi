using TvCinema.MovieApi.Service.Domain.Entities;
using TvCinema.MovieApi.Service.Domain.Models;

namespace TvCinema.MovieApi.Service.Domain.Interfaces
{
    public interface IMovieRepository
    {
        public Task<IEnumerable<Movie>> GetMovies(string clause, int _page, int _size);
        public Task<IEnumerable<CarouselBanner>> GetCarouseBanner();
        public Task<Movie?> GetMovieByImdbId(string imdbId);
        public Task<int> GetTotalItems(string clause);
    }
}
