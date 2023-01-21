using Microsoft.EntityFrameworkCore;
using Pokedex.Domain.pokemon;

namespace Pokedex.Postgres;



public class ApplicationContextDb : DbContext
{
    public ApplicationContextDb(DbContextOptions<ApplicationContextDb> options) : base(options){}

    public DbSet<Usuario> Usuarios{ get; set; }
    public DbSet<Regiao> Regiaos { get; set; }
    public DbSet<Pokemon> Pokemons { get; set; }
}
