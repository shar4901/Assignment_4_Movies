using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment_4_Movies.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Responses",
                columns: table => new
                {
                    movid_id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category = table.Column<string>(nullable: false),
                    title = table.Column<string>(nullable: false),
                    year = table.Column<int>(nullable: false),
                    director = table.Column<string>(nullable: false),
                    rating = table.Column<string>(nullable: false),
                    edited = table.Column<bool>(nullable: false),
                    lent_to = table.Column<string>(nullable: true),
                    notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responses", x => x.movid_id);
                });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "movid_id", "category", "director", "edited", "lent_to", "notes", "rating", "title", "year" },
                values: new object[] { 1, "Comedy", "Smartest Man", false, "", "", "PG", "Hot Rod", 2000 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "movid_id", "category", "director", "edited", "lent_to", "notes", "rating", "title", "year" },
                values: new object[] { 2, "Rom/Com", "Cute Girl", true, "", "", "G", "13 Going On 30", 2002 });

            migrationBuilder.InsertData(
                table: "Responses",
                columns: new[] { "movid_id", "category", "director", "edited", "lent_to", "notes", "rating", "title", "year" },
                values: new object[] { 3, "Action", "Russo Brothers", false, "", "", "PG", "SpiderMan No Way Home", 2021 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Responses");
        }
    }
}
