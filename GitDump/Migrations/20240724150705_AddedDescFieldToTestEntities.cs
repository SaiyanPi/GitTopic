using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GitDump.Migrations
{
    /// <inheritdoc />
    public partial class AddedDescFieldToTestEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "TestEntities",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "TestEntities");
        }
    }
}
