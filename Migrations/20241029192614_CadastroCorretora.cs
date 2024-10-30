using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroCorretora.Migrations
{
    /// <inheritdoc />
    public partial class CadastroCorretora : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Corretoras_Corretores_CorretorId",
                table: "Corretoras");

            migrationBuilder.DropIndex(
                name: "IX_Corretoras_CorretorId",
                table: "Corretoras");

            migrationBuilder.DropColumn(
                name: "CorretorId",
                table: "Corretoras");

            migrationBuilder.AddColumn<int>(
                name: "CorretoridCorretor",
                table: "Corretoras",
                type: "int",
                nullable: true);

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

            migrationBuilder.DropIndex(
                name: "IX_Corretoras_CorretoridCorretor",
                table: "Corretoras");

            migrationBuilder.DropColumn(
                name: "CorretoridCorretor",
                table: "Corretoras");

            migrationBuilder.AddColumn<int>(
                name: "CorretorId",
                table: "Corretoras",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
