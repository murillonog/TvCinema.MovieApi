using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TvCinema.MovieApi.Service.Infrastructure.Migrations
{
    public partial class Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    ImdbId = table.Column<string>(type: "text", nullable: true),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Year = table.Column<string>(type: "text", nullable: true),
                    Genres = table.Column<string>(type: "text", nullable: true),
                    FirstGenre = table.Column<string>(type: "text", nullable: true),
                    ImdbRating = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    Poster = table.Column<string>(type: "text", nullable: true),
                    Watched = table.Column<bool>(type: "boolean", nullable: false),
                    Favorite = table.Column<bool>(type: "boolean", nullable: false),
                    List = table.Column<bool>(type: "boolean", nullable: false),
                    DateFile = table.Column<string>(type: "text", nullable: true),
                    OriginalTitle = table.Column<string>(type: "text", nullable: true),
                    FullTitle = table.Column<string>(type: "text", nullable: true),
                    Rated = table.Column<string>(type: "text", nullable: true),
                    ImdbVotes = table.Column<string>(type: "text", nullable: true),
                    ReleaseDate = table.Column<string>(type: "text", nullable: true),
                    RuntimeMins = table.Column<string>(type: "text", nullable: true),
                    RuntimeStr = table.Column<string>(type: "text", nullable: true),
                    Directors = table.Column<string>(type: "text", nullable: true),
                    Writer = table.Column<string>(type: "text", nullable: true),
                    Stars = table.Column<string>(type: "text", nullable: true),
                    CodeStars = table.Column<string>(type: "text", nullable: true),
                    Companies = table.Column<string>(type: "text", nullable: true),
                    Countries = table.Column<string>(type: "text", nullable: true),
                    Languages = table.Column<string>(type: "text", nullable: true),
                    Tagline = table.Column<string>(type: "text", nullable: true),
                    Awards = table.Column<string>(type: "text", nullable: true),
                    Plot = table.Column<string>(type: "text", nullable: true),
                    PlotLocal = table.Column<string>(type: "text", nullable: true),
                    Franchise = table.Column<string>(type: "text", nullable: true),
                    Theme = table.Column<string>(type: "text", nullable: true),
                    GenrePath = table.Column<string>(type: "text", nullable: true),
                    RootPath = table.Column<string>(type: "text", nullable: true),
                    MoviePath = table.Column<string>(type: "text", nullable: true),
                    SubtitlePath = table.Column<string>(type: "text", nullable: true),
                    TextImdb = table.Column<string>(type: "text", nullable: true),
                    Extension = table.Column<string>(type: "text", nullable: true),
                    Lenght = table.Column<int>(type: "integer", nullable: false),
                    ExistFile = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
