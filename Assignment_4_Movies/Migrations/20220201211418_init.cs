using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment_4_Movies.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Category_id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category_name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Category_id);
                });

            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    Movie_id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Lent_to = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true),
                    Category_id = table.Column<int>(nullable: false),
                    Category_id1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.Movie_id);
                    table.ForeignKey(
                        name: "FK_Responses_Categories_Category_id1",
                        column: x => x.Category_id1,
                        principalTable: "Categories",
                        principalColumn: "Category_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Category_id", "Category_name" },
                values: new object[] { 1, "Comedy" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Category_id", "Category_name" },
                values: new object[] { 2, "Action" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Category_id", "Category_name" },
                values: new object[] { 3, "Romance" });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Movie_id", "Category_id", "Category_id1", "Director", "Edited", "Lent_to", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, 1, null, "Smartest Man", false, "", "", "PG", "Hot Rod", 2000 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Movie_id", "Category_id", "Category_id1", "Director", "Edited", "Lent_to", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, 2, null, "Cute Girl", true, "", "", "G", "13 Going On 30", 2002 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "Movie_id", "Category_id", "Category_id1", "Director", "Edited", "Lent_to", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, 3, null, "Russo Brothers", false, "", "", "PG", "SpiderMan No Way Home", 2021 });

            migrationBuilder.CreateIndex(
                name: "IX_Responses_Category_id1",
                table: "Responses",
                column: "Category_id1");
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
