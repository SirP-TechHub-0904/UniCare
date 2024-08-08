using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniCare.Data.Migrations
{
    /// <inheritdoc />
    public partial class klsd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "OneToOne",
                table: "UserTimeSheets",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OneToOne",
                table: "UserTimeSheets");
        }
    }
}
