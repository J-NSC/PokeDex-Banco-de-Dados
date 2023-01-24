using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Pokedex.Migrations
{
    /// <inheritdoc />
    public partial class AddFraquezaPokemon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "IX_FraquezaPokemon_PokemonsId",
                table: "FraquezaPokemon",
                column: "PokemonsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FraquezaPokemon");

            migrationBuilder.DropTable(
                name: "Fraqueza");
        }
    }
}
