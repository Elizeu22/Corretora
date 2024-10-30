using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroCorretora.Migrations
{
    /// <inheritdoc />
    public partial class Corretores4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.RenameColumn(
                name: "IDUsuario",
                table: "Corretoras",
                newName: "IdUsuario");

            migrationBuilder.RenameColumn(
                name: "corretor",
                table: "Corretoras",
                newName: "CorretorId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Corretoras_Corretores_CorretorId",
                table: "Corretoras");

            migrationBuilder.DropIndex(
                name: "IX_Corretoras_CorretorId",
                table: "Corretoras");

            migrationBuilder.RenameColumn(
                name: "IdUsuario",
                table: "Corretoras",
                newName: "IDUsuario");

            migrationBuilder.RenameColumn(
                name: "CorretorId",
                table: "Corretoras",
                newName: "corretor");

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
    }
}
