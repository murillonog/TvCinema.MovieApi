using AutoMapper;
using Microsoft.Extensions.Logging;
using TvCinema.MovieApi.Service.Application.DTOs;
using TvCinema.MovieApi.Service.Application.Filters;
using TvCinema.MovieApi.Service.Application.Interfaces;
using TvCinema.MovieApi.Service.Application.Util;
using TvCinema.MovieApi.Service.Domain.Interfaces;

namespace TvCinema.MovieApi.Service.Application.Services
{
    public class MovieService : IMovieService
    {
        private readonly ILogger<MovieService> _logger;
        private readonly IMapper _mapper;
        private readonly IMovieRepository _movieRepository;

        public MovieService(
            ILogger<MovieService> logger,
            IMapper mapper,
            IMovieRepository movieRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _movieRepository = movieRepository;
        }

        public async Task<Pagination<MovieDto>> Get(MovieFilters filter, int _page, int _size)
        {
            try
            {
                var list = await _movieRepository.GetMovies(filter.GetClause(), _page, _size);
                var totalItems = await _movieRepository.GetTotalItems(filter.GetClause());

                return new Pagination<MovieDto>()
                {
                    CurrentPage = _page,
                    TotalItems = totalItems,
                    TotalPages = totalItems % _size == 0 ? totalItems / _size : (totalItems / _size) + 1,
                    Filter = filter,
                    Data = _mapper.Map<IEnumerable<MovieDto>>(list)
                };
            }
            catch (Exception exception)
            {
                _logger.LogError(exception.Message);
                return new Pagination<MovieDto>();
            }
        }

        public async Task<IEnumerable<CarouselBannerDto>> GetCarouseBanner()
        {
            try
            {
                var list = await _movieRepository.GetCarouseBanner();
                return _mapper.Map<IEnumerable<CarouselBannerDto>>(list);
            }
            catch (Exception exception)
            {
                _logger.LogError(exception.Message);
                return new List<CarouselBannerDto>();
            }
        }
    }
}
