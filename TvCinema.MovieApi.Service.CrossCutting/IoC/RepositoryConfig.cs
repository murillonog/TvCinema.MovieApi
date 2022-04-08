using Microsoft.Extensions.DependencyInjection;
using TvCinema.MovieApi.Service.Domain.Interfaces;
using TvCinema.MovieApi.Service.Infrastructure.Repositories;

namespace TvCinema.MovieApi.Service.CrossCutting.IoC
{
    public static class RepositoryConfig
    {
        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IMovieRepository, MovieRepository>();
        }
    }
}
