using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Pokedex.Migrations
{
    /// <inheritdoc />
    public partial class AddHabilidadesPokemon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Habilidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeHabilidade = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidades", x => x.Id);
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

            migrationBuilder.CreateIndex(
                name: "IX_HabilidadePokemon_PokemonsId",
                table: "HabilidadePokemon",
                column: "PokemonsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HabilidadePokemon");

            migrationBuilder.DropTable(
                name: "Habilidades");
        }
    }
}
