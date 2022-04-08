using TvCinema.MovieApi.Service.Application.DTOs;
using TvCinema.MovieApi.Service.Application.Filters;
using TvCinema.MovieApi.Service.Application.Util;

namespace TvCinema.MovieApi.Service.Application.Interfaces
{
    public interface IMovieService
    {
        public Task<Pagination<MovieDto>> Get(MovieFilters filter, int _page, int _size);
        Task<IEnumerable<CarouselBannerDto>> GetCarouseBanner();
    }
}
