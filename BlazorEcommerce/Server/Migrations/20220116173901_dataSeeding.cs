using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorEcommerce.Server.Migrations
{
    public partial class dataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Burmese Days is the first novel by English writer George Orwell, published in 1934. Set in British Burma during the waning days of empire, when Burma was ruled from Delhi as part of British India, the novel serves as", "https://upload.wikimedia.org/wikipedia/en/a/a3/Burmese_days.jpg", 9.95m, "Burmese Days " });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "A Clergyman's Daughter is a 1935 novel by English author George Orwell. It tells the story of Dorothy Hare, the clergyman's daughter of the title, whose life is turned upside down when she suffers an attack of amnesia. It is Orwell's most formally experimental novel, featuring a chapter written entirely in dramatic form, but he was never satisfied with it and he left instructions that after his death it was not to be reprinted", "https://upload.wikimedia.org/wikipedia/en/a/ac/A_Clergyman%27s_Daughter_%281st_US_edition_-_cover_art%29.jpg", 7.3m, "A Clergyman's Daughter" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Keep the Aspidistra Flying, first published in 1936, is a socially critical novel by George Orwell. It is set in 1930s London. The main theme is Gordon Comstock's romantic ambition to defy worship of the money-god and status, and the dismal life that results.", "https://upload.wikimedia.org/wikipedia/en/b/b8/KeepTheAspidistraFlying.jpg", 12.34m, "Keep the Aspidistra Flying" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);
        }
    }
}
