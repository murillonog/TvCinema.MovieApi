using AutoMapper;
using TvCinema.MovieApi.Service.Application.DTOs;
using TvCinema.MovieApi.Service.Domain.Entities;
using TvCinema.MovieApi.Service.Domain.Models;

namespace TvCinema.MovieApi.Service.CrossCutting.Mapping
{
    internal class DomainToDtoMappingProfile : Profile
    {
        public DomainToDtoMappingProfile()
        {
            CreateMap<Movie, MovieDto>().ReverseMap();
            CreateMap<CarouselBanner, CarouselBannerDto>().ReverseMap();
        }
    }
}
