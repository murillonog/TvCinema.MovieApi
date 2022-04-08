using Dapper;
using Microsoft.EntityFrameworkCore;
using TvCinema.MovieApi.Service.Domain.Entities;
using TvCinema.MovieApi.Service.Domain.Interfaces;
using TvCinema.MovieApi.Service.Domain.Models;
using TvCinema.MovieApi.Service.Infrastructure.Context;

namespace TvCinema.MovieApi.Service.Infrastructure.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        protected ApplicationDbContext Db;
        protected DbSet<Movie> DbSet;
        public MovieRepository(ApplicationDbContext context)
        {
            Db = context;
            DbSet = Db.Set<Movie>();
        }

        public async Task<IEnumerable<CarouselBanner>> GetCarouseBanner()
        {
            return await DbSet
                .Select(m => new CarouselBanner
                {
                    Id = m.Id,
                    Title = m.Title,
                    Year = m.Year,
                    Rated = m.Rated,
                    Poster = m.Poster,
                    Plot = m.PlotLocal,
                    Stars = m.Stars,
                    Directors = m.Directors,
                    CodeStars = m.CodeStars,
                    Watched = m.Watched,
                    List = m.List,
                    ImdbId = m.ImdbId,
                })
                .Take(5).ToListAsync();
        }

        public async Task<Movie?> GetMovieByImdbId(string imdbId)
        {
            return await DbSet
                .FirstOrDefaultAsync(x => x.ImdbId == imdbId);
        }

        public async Task<IEnumerable<Movie>> GetMovies(string clause, int _page, int _size)
        {
            var list = await Db.Database.GetDbConnection()
                .QueryAsync<Movie>($"SELECT * FROM \"Movie\" {clause};");

            return list.Skip(_page * _size).Take(_size);
        }

        public async Task<int> GetTotalItems(string clause)
        {
            var list = await Db.Database.GetDbConnection()
                .QueryAsync<Movie>($"SELECT * FROM \"Movie\" {clause}");

            return list.Count();
        }
    }
}
