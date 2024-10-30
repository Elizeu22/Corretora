using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroCorretora.Migrations
{
    /// <inheritdoc />
    public partial class CadastroCorretora1 : Migration
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
                name: "IdUsuario",
                table: "Corretoras",
                newName: "IDUsuario");

            migrationBuilder.AlterColumn<long>(
                name: "IDUsuario",
                table: "Corretoras",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AddColumn<int>(
                name: "corretorID",
                table: "Corretoras",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Corretoras_corretorID",
                table: "Corretoras",
                column: "corretorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Corretoras_Corretores_corretorID",
                table: "Corretoras",
                column: "corretorID",
                principalTable: "Corretores",
                principalColumn: "idCorretor",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Corretoras_Corretores_corretorID",
                table: "Corretoras");

            migrationBuilder.DropIndex(
                name: "IX_Corretoras_corretorID",
                table: "Corretoras");

            migrationBuilder.DropColumn(
                name: "corretorID",
                table: "Corretoras");

            migrationBuilder.RenameColumn(
                name: "IDUsuario",
                table: "Corretoras",
                newName: "IdUsuario");

            migrationBuilder.AlterColumn<int>(
                name: "IdUsuario",
                table: "Corretoras",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .OldAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn);

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
