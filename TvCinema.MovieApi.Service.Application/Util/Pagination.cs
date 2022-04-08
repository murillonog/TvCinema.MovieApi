using TvCinema.MovieApi.Service.Application.Filters;

namespace TvCinema.MovieApi.Service.Application.Util
{
    public class Pagination<T>
    {
        public int CurrentPage { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages { get; set; }
        public MovieFilters? Filter { get; set; }
        public IEnumerable<T>? Data { get; set; }
    }
}
