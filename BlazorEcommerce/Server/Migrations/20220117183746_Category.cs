using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorEcommerce.Server.Migrations
{
    public partial class Category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 1, "Books", "books" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 2, "Movies", "movies" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[] { 3, "Video Games", "video-games" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, 1, "Burmese Days is the first novel by English writer George Orwell, published in 1934. Set in British Burma during the waning days of empire, when Burma was ruled from Delhi as part of British India, the novel serves as", "https://upload.wikimedia.org/wikipedia/en/a/a3/Burmese_days.jpg", 9.95m, "Burmese Days " });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, 1, "A Clergyman's Daughter is a 1935 novel by English author George Orwell. It tells the story of Dorothy Hare, the clergyman's daughter of the title, whose life is turned upside down when she suffers an attack of amnesia. It is Orwell's most formally experimental novel, featuring a chapter written entirely in dramatic form, but he was never satisfied with it and he left instructions that after his death it was not to be reprinted", "https://upload.wikimedia.org/wikipedia/en/a/ac/A_Clergyman%27s_Daughter_%281st_US_edition_-_cover_art%29.jpg", 7.3m, "A Clergyman's Daughter" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, 1, "Keep the Aspidistra Flying, first published in 1936, is a socially critical novel by George Orwell. It is set in 1930s London. The main theme is Gordon Comstock's romantic ambition to defy worship of the money-god and status, and the dismal life that results.", "https://upload.wikimedia.org/wikipedia/en/b/b8/KeepTheAspidistraFlying.jpg", 12.34m, "Keep the Aspidistra Flying" });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
