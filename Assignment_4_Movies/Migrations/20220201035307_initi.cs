using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment_4_Movies.Migrations
{
    public partial class initi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    category_id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category_name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.category_id);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    movie_id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    title = table.Column<string>(nullable: false),
                    year = table.Column<int>(nullable: false),
                    director = table.Column<string>(nullable: false),
                    rating = table.Column<string>(nullable: false),
                    edited = table.Column<bool>(nullable: false),
                    lent_to = table.Column<string>(nullable: true),
                    notes = table.Column<string>(maxLength: 25, nullable: true),
                    category_id = table.Column<int>(nullable: false),
                    category_id1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.movie_id);
                    table.ForeignKey(
                        name: "FK_Responses_Categories_category_id1",
                        column: x => x.category_id1,
                        principalTable: "Categories",
                        principalColumn: "category_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_id", "category_name" },
                values: new object[] { 1, "Comedy" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_id", "category_name" },
                values: new object[] { 2, "Action" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "category_id", "category_name" },
                values: new object[] { 3, "Romance" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "movie_id", "category_id", "category_id1", "director", "edited", "lent_to", "notes", "rating", "title", "year" },
                values: new object[] { 1, 1, null, "Smartest Man", false, "", "", "PG", "Hot Rod", 2000 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "movie_id", "category_id", "category_id1", "director", "edited", "lent_to", "notes", "rating", "title", "year" },
                values: new object[] { 2, 2, null, "Cute Girl", true, "", "", "G", "13 Going On 30", 2002 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "movie_id", "category_id", "category_id1", "director", "edited", "lent_to", "notes", "rating", "title", "year" },
                values: new object[] { 3, 3, null, "Russo Brothers", false, "", "", "PG", "SpiderMan No Way Home", 2021 });

            migrationBuilder.CreateIndex(
                name: "IX_Responses_category_id1",
                table: "Responses",
                column: "category_id1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
