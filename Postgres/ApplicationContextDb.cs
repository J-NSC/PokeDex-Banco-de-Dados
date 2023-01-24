using Microsoft.EntityFrameworkCore;
using Pokedex.Domain.pokemon;
using Pokedex.Domain.Deck;

namespace Pokedex.Postgres;



public class ApplicationContextDb : DbContext
{
    public ApplicationContextDb(DbContextOptions<ApplicationContextDb> options) : base(options){}

    public DbSet<Usuario> Usuarios{ get; set; }
    public DbSet<Regiao> Regiaos { get; set; }
    public DbSet<Pokemon> Pokemons { get; set; }
    public DbSet<Tipo> Tipos{get; set;}
    public DbSet<Habilidade> Habilidades { get; set; }
    // public DbSet<Deck> Decks {get; set;}


}


