using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Pokedex.Migrations
{
    /// <inheritdoc />
    public partial class AddTipo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TipoPokemonid",
                table: "Pokemons",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateTable(
                name: "Tipo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeTipo = table.Column<string>(type: "text", nullable: false),
                    TipoPokemonid = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tipo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tipo_TipoPokemon_TipoPokemonid",
                        column: x => x.TipoPokemonid,
                        principalTable: "TipoPokemon",
                        principalColumn: "id");
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_TipoPokemon_TipoPokemonid",
                table: "Pokemons");

            migrationBuilder.DropTable(
                name: "Tipo");

            migrationBuilder.DropTable(
                name: "TipoPokemon");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_TipoPokemonid",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "TipoPokemonid",
                table: "Pokemons");
        }
    }
}
