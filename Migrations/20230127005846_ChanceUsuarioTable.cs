using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex.Migrations
{
    /// <inheritdoc />
    public partial class ChanceUsuarioTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Decks_Usuarios_UsuarioId1",
                table: "Decks");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Usuarios_UsuarioId1",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_UsuarioId1",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Decks_UsuarioId1",
                table: "Decks");

            migrationBuilder.DropColumn(
                name: "UsuarioId1",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "UsuarioId1",
                table: "Decks");

            migrationBuilder.AddColumn<int>(
                name: "DeckId",
                table: "Usuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DecksId",
                table: "Usuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PokemonId",
                table: "Usuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_DeckId",
                table: "Usuarios",
                column: "DeckId");

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_PokemonId",
                table: "Usuarios",
                column: "PokemonId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Decks_DeckId",
                table: "Usuarios",
                column: "DeckId",
                principalTable: "Decks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Pokemons_PokemonId",
                table: "Usuarios",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Decks_DeckId",
                table: "Usuarios");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Pokemons_PokemonId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_DeckId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_PokemonId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "DeckId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "DecksId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "PokemonId",
                table: "Usuarios");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId1",
                table: "Pokemons",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId1",
                table: "Decks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_UsuarioId1",
                table: "Pokemons",
                column: "UsuarioId1");

            migrationBuilder.CreateIndex(
                name: "IX_Decks_UsuarioId1",
                table: "Decks",
                column: "UsuarioId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Decks_Usuarios_UsuarioId1",
                table: "Decks",
                column: "UsuarioId1",
                principalTable: "Usuarios",
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
