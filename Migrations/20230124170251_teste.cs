using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Pokedex.Migrations
{
    /// <inheritdoc />
    public partial class teste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_TipoPokemon_TipoPokemonid",
                table: "Pokemons");

            migrationBuilder.DropForeignKey(
                name: "FK_Tipo_TipoPokemon_TipoPokemonid",
                table: "Tipo");

            migrationBuilder.DropTable(
                name: "TipoPokemon");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_TipoPokemonid",
                table: "Pokemons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipo",
                table: "Tipo");

            migrationBuilder.DropIndex(
                name: "IX_Tipo_TipoPokemonid",
                table: "Tipo");

            migrationBuilder.DropColumn(
                name: "TipoPokemonid",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "TipoPokemonid",
                table: "Tipo");

            migrationBuilder.RenameTable(
                name: "Tipo",
                newName: "Tipos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipos",
                table: "Tipos",
                column: "Id");

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

            migrationBuilder.CreateIndex(
                name: "IX_PokemonTipo_TiposId",
                table: "PokemonTipo",
                column: "TiposId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PokemonTipo");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tipos",
                table: "Tipos");

            migrationBuilder.RenameTable(
                name: "Tipos",
                newName: "Tipo");

            migrationBuilder.AddColumn<int>(
                name: "TipoPokemonid",
                table: "Pokemons",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TipoPokemonid",
                table: "Tipo",
                type: "integer",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tipo",
                table: "Tipo",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "TipoPokemon",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPokemon", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_TipoPokemonid",
                table: "Pokemons",
                column: "TipoPokemonid");

            migrationBuilder.CreateIndex(
                name: "IX_Tipo_TipoPokemonid",
                table: "Tipo",
                column: "TipoPokemonid");

            migrationBuilder.AddForeignKey(
                name: "FK_Pokemons_TipoPokemon_TipoPokemonid",
                table: "Pokemons",
                column: "TipoPokemonid",
                principalTable: "TipoPokemon",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tipo_TipoPokemon_TipoPokemonid",
                table: "Tipo",
                column: "TipoPokemonid",
                principalTable: "TipoPokemon",
                principalColumn: "id");
        }
    }
}
