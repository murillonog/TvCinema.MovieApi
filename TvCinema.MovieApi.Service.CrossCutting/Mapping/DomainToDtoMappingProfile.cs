using AutoMapper;
using TvCinema.MovieApi.Service.Application.DTOs;
using TvCinema.MovieApi.Service.Domain.Entities;

namespace TvCinema.MovieApi.Service.CrossCutting.Mapping
{
    internal class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<Movie, MovieDto>().ReverseMap();
            CreateMap<MovieDto, Movie>().ReverseMap();
        }
    }
}
