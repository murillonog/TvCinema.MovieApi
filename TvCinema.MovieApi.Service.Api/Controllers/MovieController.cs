using Microsoft.AspNetCore.Mvc;
using TvCinema.MovieApi.Service.Application.DTOs;
using TvCinema.MovieApi.Service.Application.Filters;
using TvCinema.MovieApi.Service.Application.Interfaces;
using TvCinema.MovieApi.Service.Application.Util;

namespace TvCinema.MovieApi.Service.Api.Controllers
{
    [ApiController]
    [Route("api/movie")]
    public class MovieController : ControllerBase
    {
        private readonly IMovieService _movieService;
        private readonly ILogger<MovieController> _logger;

        public MovieController(IMovieService movieService, 
            ILogger<MovieController> logger)
        {
            _movieService = movieService;
            _logger = logger;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Pagination<MovieDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(List<string>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(List<string>))]
        public async Task<IActionResult> Get([FromQuery] MovieFilters filter, int _page = 0, int _size = 25)
        {
            try
            {
                _logger.LogInformation($"*****Init Get Movie List*****");
                var result = await _movieService.Get(filter, _page, _size);
                _logger.LogInformation($"*****End Get Movie List*****");
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message, null, null, null, null);
            }
        }

        [HttpGet("carousel-banner")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IEnumerable<CarouselBannerDto>))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(List<string>))]
        [ProducesResponseType(StatusCodes.Status500InternalServerError, Type = typeof(List<string>))]
        public async Task<IActionResult> GetCarouseBanner()
        {
            try
            {
                var result = await _movieService.GetCarouseBanner();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message, null, null, null, null);
            }
        }
    }
}
