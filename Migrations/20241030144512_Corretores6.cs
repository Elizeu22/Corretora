using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroCorretora.Migrations
{
    /// <inheritdoc />
    public partial class Corretores6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Corretoras_Corretores_CorretorId",
                table: "Corretoras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Corretoras",
                table: "Corretoras");

            migrationBuilder.DropIndex(
                name: "IX_Corretoras_CorretorId",
                table: "Corretoras");

            migrationBuilder.DropColumn(
                name: "IdUsuario",
                table: "Corretoras");

            migrationBuilder.RenameColumn(
                name: "CorretorId",
                table: "Corretoras",
                newName: "Id");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Corretoras",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "CorretoridCorretor",
                table: "Corretoras",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Corretoras",
                table: "Corretoras",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Corretoras_CorretoridCorretor",
                table: "Corretoras",
                column: "CorretoridCorretor");

            migrationBuilder.AddForeignKey(
                name: "FK_Corretoras_Corretores_CorretoridCorretor",
                table: "Corretoras",
                column: "CorretoridCorretor",
                principalTable: "Corretores",
                principalColumn: "idCorretor");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Corretoras_Corretores_CorretoridCorretor",
                table: "Corretoras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Corretoras",
                table: "Corretoras");

            migrationBuilder.DropIndex(
                name: "IX_Corretoras_CorretoridCorretor",
                table: "Corretoras");

            migrationBuilder.DropColumn(
                name: "CorretoridCorretor",
                table: "Corretoras");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Corretoras",
                newName: "CorretorId");

            migrationBuilder.AlterColumn<int>(
                name: "CorretorId",
                table: "Corretoras",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "IdUsuario",
                table: "Corretoras",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Corretoras",
                table: "Corretoras",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Corretoras_CorretorId",
                table: "Corretoras",
                column: "CorretorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Corretoras_Corretores_CorretorId",
                table: "Corretoras",
                column: "CorretorId",
                principalTable: "Corretores",
                principalColumn: "idCorretor",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
