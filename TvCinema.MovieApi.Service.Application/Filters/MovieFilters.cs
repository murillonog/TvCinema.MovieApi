namespace TvCinema.MovieApi.Service.Application.Filters
{
    public class MovieFilters
    {
        public string? Title { get; set; }
        public string? Year { get; set; }
        public string? Genre { get; set; }
        public string? Rating { get; set; }
        public string? Director { get; set; }
        public string? Company { get; set; }
        public string? Country { get; set; }
        public string? Star { get; set; }
        public string? Order { get; set; }


        public string GetClause()
        {
            string clause = string.Empty;

            clause += GetTitle(clause);

            clause += GetYear(clause);

            clause += GetGenre(clause);

            clause += GetDirector(clause);

            clause += GetCompanie(clause);

            clause += GetRating(clause);

            clause += GerStar(clause);

            clause += GerOrder(clause);

            return clause;
        }

        private string GerOrder(string clause)
        {
            if (!string.IsNullOrEmpty(Order))
                return $" ORDER BY \"{Order.Split(" ")[0]}\" {Order.Split(" ")[1]}";

            return $" ORDER BY \"DateFile\" DESC";
        }

        private string GerStar(string clause)
        {
            if (!string.IsNullOrEmpty(Star))
                return clause.Contains("WHERE") ? $" AND \"Stars\" LIKE '%{Star}%'" : $"WHERE \"Stars\" LIKE '%{Star}%'";

            return string.Empty;
        }

        private string GetRating(string clause)
        {
            if (!string.IsNullOrEmpty(Rating))
                return clause.Contains("WHERE") ? $" AND \"ImdbRating\" {Rating}" : $"WHERE \"ImdbRating\" {Rating}";

            return string.Empty;
        }

        private string GetCompanie(string clause)
        {
            if (!string.IsNullOrEmpty(Company))
                return clause.Contains("WHERE") ? $" AND \"Companies\" LIKE '%{Company}%'" : $"WHERE \"Companies\" LIKE '%{Company}%'";

            return string.Empty;
        }

        private string GetDirector(string clause)
        {
            if (!string.IsNullOrEmpty(Director))
                return clause.Contains("WHERE") ? $" AND \"Director\" LIKE '%{Director}%'" : $"WHERE \"Director\" LIKE '%{Director}%'";

            return string.Empty;
        }

        private string GetGenre(string clause)
        {
            if (!string.IsNullOrEmpty(Genre))
                return clause.Contains("WHERE") ? $" AND \"Genres\" LIKE '%{Genre}%'" : $"WHERE \"Genres\" LIKE '%{Genre}%'";

            return string.Empty;
        }

        private string GetYear(string clause)
        {
            if (!string.IsNullOrEmpty(Year))
                return clause.Contains("WHERE") ? $" AND \"Year\" {Year}" : $"WHERE \"Year\" {Year}";

            return string.Empty;
        }

        private string GetTitle(string clause)
        {
            if (!string.IsNullOrEmpty(Title))
                return clause.Contains("WHERE") ? $" AND \"Title\" LIKE '%{Title}%'" : $"WHERE \"Title\" LIKE '%{Title}%'";

            return string.Empty;
        }
    }
}
