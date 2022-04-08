using Microsoft.Extensions.DependencyInjection;
using TvCinema.MovieApi.Service.Application.Interfaces;
using TvCinema.MovieApi.Service.Application.Services;

namespace TvCinema.MovieApi.Service.CrossCutting.IoC
{
    public static class ServiceConfig
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<IMovieService, MovieService>();
        }
    }
}
