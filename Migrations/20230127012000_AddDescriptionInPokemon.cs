using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Pokedex.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptionInPokemon : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SuperDefesa",
                table: "Pokemons",
                type: "text",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<string>(
                name: "SuperAtauqe",
                table: "Pokemons",
                type: "text",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<string>(
                name: "Speed",
                table: "Pokemons",
                type: "text",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<string>(
                name: "Peso",
                table: "Pokemons",
                type: "text",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<string>(
                name: "Defesa",
                table: "Pokemons",
                type: "text",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<string>(
                name: "Ataque",
                table: "Pokemons",
                type: "text",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<string>(
                name: "Altura",
                table: "Pokemons",
                type: "text",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AddColumn<int>(
                name: "CategoriaId",
                table: "Pokemons",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Pokemons",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId1",
                table: "Decks",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Categoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoriaPokemon = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_CategoriaId",
                table: "Pokemons",
                column: "CategoriaId");

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
                name: "FK_Pokemons_Categoria_CategoriaId",
                table: "Pokemons",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Decks_Usuarios_UsuarioId1",
                table: "Decks");

            migrationBuilder.DropForeignKey(
                name: "FK_Pokemons_Categoria_CategoriaId",
                table: "Pokemons");

            migrationBuilder.DropTable(
                name: "Categoria");

            migrationBuilder.DropIndex(
                name: "IX_Pokemons_CategoriaId",
                table: "Pokemons");

            migrationBuilder.DropIndex(
                name: "IX_Decks_UsuarioId1",
                table: "Decks");

            migrationBuilder.DropColumn(
                name: "CategoriaId",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Pokemons");

            migrationBuilder.DropColumn(
                name: "UsuarioId1",
                table: "Decks");

            migrationBuilder.AlterColumn<float>(
                name: "SuperDefesa",
                table: "Pokemons",
                type: "real",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<float>(
                name: "SuperAtauqe",
                table: "Pokemons",
                type: "real",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<float>(
                name: "Speed",
                table: "Pokemons",
                type: "real",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<float>(
                name: "Peso",
                table: "Pokemons",
                type: "real",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<float>(
                name: "Defesa",
                table: "Pokemons",
                type: "real",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<float>(
                name: "Ataque",
                table: "Pokemons",
                type: "real",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<float>(
                name: "Altura",
                table: "Pokemons",
                type: "real",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
