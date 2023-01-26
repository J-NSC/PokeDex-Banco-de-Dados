using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Pokedex.Migrations
{
    /// <inheritdoc />
    public partial class RevertingChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Regiaos_Pokemons_PokemonId",
                table: "Regiaos");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Pokemons_PokemonId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_PokemonId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Regiaos_PokemonId",
                table: "Regiaos");

            migrationBuilder.DropColumn(
                name: "PokemonId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "PokemonId",
                table: "Regiaos");

            migrationBuilder.AddColumn<int>(
                name: "RegiaoId1",
                table: "Pokemons",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId1",
                table: "Pokemons",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DeckPokemon",
                columns: table => new
                {
                    DecksId = table.Column<int>(type: "integer", nullable: false),
                    PokemonId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeckPokemon", x => new { x.DecksId, x.PokemonId });
                    table.ForeignKey(
                        name: "FK_DeckPokemon_Decks_DecksId",
                        column: x => x.DecksId,
                        principalTable: "Decks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DeckPokemon_Pokemons_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fraqueza",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FraquezaName = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fraqueza", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HabilidadePokemon",
                columns: table => new
                {
                    HabilidadesId = table.Column<int>(type: "integer", nullable: false),
                    PokemonsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HabilidadePokemon", x => new { x.HabilidadesId, x.PokemonsId });
                    table.ForeignKey(
                        name: "FK_HabilidadePokemon_Habilidades_HabilidadesId",
                        column: x => x.HabilidadesId,
                        principalTable: "Habilidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HabilidadePokemon_Pokemons_PokemonsId",
                        column: x => x.PokemonsId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonTipo",
                columns: table => new
                {
                    PokemonsId = table.Column<int>(type: "integer", nullable: false),
                    TiposId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonTipo", x => new { x.PokemonsId, x.TiposId });
                    table.ForeignKey(
                        name: "FK_PokemonTipo_Pokemons_PokemonsId",
                        column: x => x.PokemonsId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonTipo_Tipos_TiposId",
                        column: x => x.TiposId,
                        principalTable: "Tipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FraquezaPokemon",
                columns: table => new
                {
                    FraquezasId = table.Column<int>(type: "integer", nullable: false),
                    PokemonsId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FraquezaPokemon", x => new { x.FraquezasId, x.PokemonsId });
                    table.ForeignKey(
                        name: "FK_FraquezaPokemon_Fraqueza_FraquezasId",
                        column: x => x.FraquezasId,
                        principalTable: "Fraqueza",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FraquezaPokemon_Pokemons_PokemonsId",
                        column: x => x.PokemonsId,
                        principalTable: "Pokemons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_RegiaoId1",
                table: "Pokemons",
                column: "RegiaoId1");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_UsuarioId1",
                table: "Pokemons",
                column: "UsuarioId1");

            migrationBuilder.CreateIndex(
                name: "IX_DeckPokemon_PokemonId",
                table: "DeckPokemon",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_FraquezaPokemon_PokemonsId",
                table: "FraquezaPokemon",
                column: "PokemonsId");

            migrationBuilder.CreateIndex(
                name: "IX_HabilidadePokemon_PokemonsId",
                table: "HabilidadePokemon",
                column: "PokemonsId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonTipo_TiposId",
                table: "PokemonTipo",
                column: "TiposId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Regiaos_RegiaoId1",
                table: "Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Usuarios_UsuarioId1",
                table: "Pokemons");

            migrationBuilder.DropTable(
                name: "DeckPokemon");

            migrationBuilder.DropTable(
                name: "FraquezaPokemon");

            migrationBuilder.DropTable(
                name: "HabilidadePokemon");

            migrationBuilder.DropTable(
                name: "PokemonTipo");

            migrationBuilder.DropTable(
                name: "Fraqueza");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_RegiaoId1",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_UsuarioId1",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "RegiaoId1",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "UsuarioId1",
                table: "Pokemons");

            migrationBuilder.AddColumn<int>(
                name: "PokemonId",
                table: "Usuarios",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PokemonId",
                table: "Regiaos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_PokemonId",
                table: "Usuarios",
                column: "PokemonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Regiaos_PokemonId",
                table: "Regiaos",
                column: "PokemonId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Regiaos_Pokemons_PokemonId",
                table: "Regiaos",
                column: "PokemonId",
                principalTable: "Pokemons",
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
    }
}
