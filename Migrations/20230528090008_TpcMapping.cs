using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace TeacherEnglish.Migrations
{
    /// <inheritdoc />
    public partial class TpcMapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BaseEntities",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Infinitive",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "PastParticiple",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "PastSimple",
                table: "BaseEntities");

            migrationBuilder.DropColumn(
                name: "Translation",
                table: "BaseEntities");

            migrationBuilder.RenameTable(
                name: "BaseEntities",
                newName: "Users");

            migrationBuilder.CreateSequence(
                name: "BaseEntitySequence");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "ChatId",
                table: "Users",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Users",
                type: "bigint",
                nullable: false,
                defaultValueSql: "nextval('\"BaseEntitySequence\"')",
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "IrregularVerbs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "nextval('\"BaseEntitySequence\"')"),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Infinitive = table.Column<string>(type: "text", nullable: false),
                    PastSimple = table.Column<string>(type: "text", nullable: false),
                    PastParticiple = table.Column<string>(type: "text", nullable: false),
                    Translation = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IrregularVerbs", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IrregularVerbs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropSequence(
                name: "BaseEntitySequence");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "BaseEntities");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "BaseEntities",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<long>(
                name: "ChatId",
                table: "BaseEntities",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "BaseEntities",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "nextval('\"BaseEntitySequence\"')")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "BaseEntities",
                type: "character varying(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Infinitive",
                table: "BaseEntities",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PastParticiple",
                table: "BaseEntities",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PastSimple",
                table: "BaseEntities",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Translation",
                table: "BaseEntities",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BaseEntities",
                table: "BaseEntities",
                column: "Id");
        }
    }
}
