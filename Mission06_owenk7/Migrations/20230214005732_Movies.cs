using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_owenk7.Migrations
{
    public partial class Movies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "recommendations",
                columns: table => new
                {
                    movieid = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    title = table.Column<string>(nullable: false),
                    year = table.Column<int>(nullable: false),
                    cat = table.Column<string>(nullable: false),
                    director = table.Column<string>(nullable: false),
                    rating = table.Column<string>(nullable: false),
                    edited = table.Column<bool>(nullable: false),
                    lent = table.Column<string>(nullable: true),
                    notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recommendations", x => x.movieid);
                });

            migrationBuilder.InsertData(
                table: "recommendations",
                columns: new[] { "movieid", "cat", "director", "edited", "lent", "notes", "rating", "title", "year" },
                values: new object[] { 1, "Action/Adventure", "John McTiernan", false, null, null, "R", "Die Hard", 1988 });

            migrationBuilder.InsertData(
                table: "recommendations",
                columns: new[] { "movieid", "cat", "director", "edited", "lent", "notes", "rating", "title", "year" },
                values: new object[] { 2, "Action/Adventure", "Renny Harlin", false, null, null, "R", "Die Hard 2", 1990 });

            migrationBuilder.InsertData(
                table: "recommendations",
                columns: new[] { "movieid", "cat", "director", "edited", "lent", "notes", "rating", "title", "year" },
                values: new object[] { 3, "Family", "Jennifer Lee, Chris Buck", true, null, null, "PG", "Frozen 2", 2019 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "recommendations");
        }
    }
}
