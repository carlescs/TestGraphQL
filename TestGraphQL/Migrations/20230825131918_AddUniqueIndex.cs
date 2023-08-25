using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestGraphQL.Migrations
{
    /// <inheritdoc />
    public partial class AddUniqueIndex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "UniqueTitle",
                table: "Book",
                column: "Title",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UniqueName",
                table: "Author",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UniqueTitle",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "UniqueName",
                table: "Author");
        }
    }
}
