using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorEcommerce.Server.Migrations
{
    public partial class removeProductId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "A Clergyman's Daughter is a 1935 novel by English author George Orwell. It tells the story of Dorothy Hare, the clergyman's daughter of the title, whose life is turned upside down when she suffers an attack of amnesia. It is Orwell's most formally experimental novel, featuring a chapter written entirely in dramatic form, but he was never satisfied with it and he left instructions that after his death it was not to be reprinted", "https://upload.wikimedia.org/wikipedia/en/a/ac/A_Clergyman%27s_Daughter_%281st_US_edition_-_cover_art%29.jpg", 7.3m, "A Clergyman's Daughter" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "A Clergyman's Daughter is a 1935 novel by English author George Orwell. It tells the story of Dorothy Hare, the clergyman's daughter of the title, whose life is turned upside down when she suffers an attack of amnesia. It is Orwell's most formally experimental novel, featuring a chapter written entirely in dramatic form, but he was never satisfied with it and he left instructions that after his death it was not to be reprinted", "https://upload.wikimedia.org/wikipedia/en/a/ac/A_Clergyman%27s_Daughter_%281st_US_edition_-_cover_art%29.jpg", 7.3m, "A Clergyman's Daughter" });
        }
    }
}
