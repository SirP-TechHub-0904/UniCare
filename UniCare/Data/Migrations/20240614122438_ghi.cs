using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniCare.Data.Migrations
{
    /// <inheritdoc />
    public partial class ghi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "NewsBlogs",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "NewsBlogs");
        }
    }
}
