using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex.Migrations
{
    /// <inheritdoc />
    public partial class ChangeIdPokemon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Regiaos_RegiaoId1",
                table: "Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Usuarios_UsuarioId1",
                table: "Pokemons");

            migrationBuilder.RenameColumn(
                name: "UsuarioId1",
                table: "Pokemons",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "RegiaoId1",
                table: "Pokemons",
                newName: "RegiaoId");

            migrationBuilder.RenameIndex(
                name: "IX_Pokemons_UsuarioId1",
                table: "Pokemons",
                newName: "IX_Pokemons_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Pokemons_RegiaoId1",
                table: "Pokemons",
                newName: "IX_Pokemons_RegiaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Regiaos_RegiaoId",
                table: "Pokemons",
                column: "RegiaoId",
                principalTable: "Regiaos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Usuarios_UsuarioId",
                table: "Pokemons",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Regiaos_RegiaoId",
                table: "Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Usuarios_UsuarioId",
                table: "Pokemons");

            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Pokemons",
                newName: "UsuarioId1");

            migrationBuilder.RenameColumn(
                name: "RegiaoId",
                table: "Pokemons",
                newName: "RegiaoId1");

            migrationBuilder.RenameIndex(
                name: "IX_Pokemons_UsuarioId",
                table: "Pokemons",
                newName: "IX_Pokemons_UsuarioId1");

            migrationBuilder.RenameIndex(
                name: "IX_Pokemons_RegiaoId",
                table: "Pokemons",
                newName: "IX_Pokemons_RegiaoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Regiaos_RegiaoId1",
                table: "Pokemons",
                column: "RegiaoId1",
                principalTable: "Regiaos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_Usuarios_UsuarioId1",
                table: "Pokemons",
                column: "UsuarioId1",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
