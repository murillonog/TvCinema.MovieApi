using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using TvCinema.MovieApi.Service.CrossCutting.Mapping;

namespace TvCinema.MovieApi.Service.CrossCutting.IoC
{
    public static class MappingConfig
    {
        public static void AddMapper(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new DomainToDtoMappingProfile());
            });
            IMapper mapper = mappingConfig.CreateMapper();
            services.AddSingleton(mapper);
        }
    }
}
