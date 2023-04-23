using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeacherEnglish.Migrations
{
    /// <inheritdoc />
    public partial class EntityIrregularVerbDeleteTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Test",
                table: "IrregularVerbs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Test",
                table: "IrregularVerbs",
                type: "text",
                nullable: false,
                defaultValue: "");
        }
    }
}
