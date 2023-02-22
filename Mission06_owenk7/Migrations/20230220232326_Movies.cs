using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission06_owenk7.Migrations
{
    public partial class Movies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "recommendations",
                columns: table => new
                {
                    movieid = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    title = table.Column<string>(nullable: false),
                    year = table.Column<int>(nullable: false),
                    director = table.Column<string>(nullable: false),
                    rating = table.Column<string>(nullable: false),
                    edited = table.Column<bool>(nullable: false),
                    lent = table.Column<string>(nullable: true),
                    notes = table.Column<string>(maxLength: 25, nullable: true),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_recommendations", x => x.movieid);
                    table.ForeignKey(
                        name: "FK_recommendations_categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 1, "Action/Adventure" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 2, "Comedy" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 3, "Drama" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 4, "Family" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 5, "Horror/Suspense" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 6, "Miscellaneous" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 7, "Television" });

            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[] { 8, "VHS" });

            migrationBuilder.InsertData(
                table: "recommendations",
                columns: new[] { "movieid", "CategoryId", "director", "edited", "lent", "notes", "rating", "title", "year" },
                values: new object[] { 1, 1, "John McTiernan", false, null, null, "R", "Die Hard", 1988 });

            migrationBuilder.InsertData(
                table: "recommendations",
                columns: new[] { "movieid", "CategoryId", "director", "edited", "lent", "notes", "rating", "title", "year" },
                values: new object[] { 2, 1, "Renny Harlin", false, null, null, "R", "Die Hard 2", 1990 });

            migrationBuilder.InsertData(
                table: "recommendations",
                columns: new[] { "movieid", "CategoryId", "director", "edited", "lent", "notes", "rating", "title", "year" },
                values: new object[] { 3, 4, "Jennifer Lee, Chris Buck", true, null, null, "PG", "Frozen 2", 2019 });

            migrationBuilder.CreateIndex(
                name: "IX_recommendations_CategoryId",
                table: "recommendations",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "recommendations");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
