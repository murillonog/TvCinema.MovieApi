namespace TvCinema.MovieApi.Service.Domain.Entities
{
    public class Movie
    {
        public Movie()
        {
            Id = Guid.NewGuid();
        }

        //Main
        public Guid Id { get; set; }
        public string? ImdbId { get; set; }
        public string? Title { get; set; }
        public string? Year { get; set; }
        public string? Genres { get; set; }
        public string? FirstGenre { get; set; }
        public string? ImdbRating { get; set; }
        public string? Image { get; set; }
        public string? Poster { get; set; }
        public bool Watched { get; set; }
        public bool Favorite { get; set; }
        public bool List { get; set; }
        public string? DateFile { get; set; }

        //Details
        public string? OriginalTitle { get; set; }
        public string? FullTitle { get; set; }
        public string? Rated { get; set; }
        public string? ImdbVotes { get; set; }
        public string? ReleaseDate { get; set; }
        public string? RuntimeMins { get; set; }
        public string? RuntimeStr { get; set; }
        public string? Directors { get; set; }
        public string? Writer { get; set; }
        public string? Stars { get; set; }
        public string? CodeStars { get; set; }
        public string? Companies { get; set; }
        public string? Countries { get; set; }
        public string? Languages { get; set; }
        public string? Tagline { get; set; }
        public string? Awards { get; set; }
        public string? Plot { get; set; }
        public string? PlotLocal { get; set; }
        public string? Franchise { get; set; }
        public string? Theme { get; set; }

        //Directory
        public string? GenrePath { get; set; }
        public string? RootPath { get; set; }
        public string? MoviePath { get; set; }
        public string? SubtitlePath { get; set; }
        public string? TextImdb { get; set; }
        public string? Extension { get; set; }
        public int Lenght { get; set; }
        public bool ExistFile { get; set; }
    }
}
