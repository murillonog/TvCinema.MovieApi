namespace TvCinema.MovieApi.Service.Domain.Models
{
    public class CarouselBanner
    {
        public Guid Id { get; set; }
        public string? Title { get; set; }
        public string? Year { get; set; }
        public string? Rated { get; set; }
        public string? Poster { get; set; }
        public string? Plot { get; set; }
        public string? Stars { get; set; }
        public string? Directors { get; set; }
        public string? CodeStars { get; set; }
        public bool Watched { get; set; }
        public bool List { get; set; }
        public string? ImdbId { get; set; }
    }
}
