using Microsoft.EntityFrameworkCore;
using Pokedex.Domain.pokemon;
using Pokedex.Domain.Decks;
using Pokedex.Configuration;

namespace Pokedex.Postgres;



public class ApplicationContextDb : DbContext
{
    public ApplicationContextDb(DbContextOptions<ApplicationContextDb> options) : base(options){}

    public DbSet<Usuario> Usuarios{ get; set; }
    public DbSet<Regiao> Regiaos { get; set; }
    public DbSet<Pokemon> Pokemons { get; set; }
    public DbSet<Tipo> Tipos{get; set;}
    public DbSet<Habilidade> Habilidades { get; set; }
    public DbSet<Categoria> Categoria { get; set; }
    public DbSet<Deck> Decks { get; set; }



    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
        modelBuilder.ApplyConfiguration(new CategoriaConfiguration());
        modelBuilder.ApplyConfiguration(new RegiaoConfiguration());
        //modelBuilder.Entity<Pokemon>()
        //    .HasMany(t => t.Tipos)
        //    .WithMany(p => p.Pokemons)
        //    .UsingEntity(pt => pt.ToTable("PokemonTipo"));

        //modelBuilder.Entity<Pokemon>()
        //    .HasMany(h => h.Habilidades)
        //    .WithMany(p => p.Pokemons)
        //    .UsingEntity(hp => hp.ToTable("HabilidadePokemon"));

        //modelBuilder.Entity<Pokemon>()
        //    .HasMany(f => f.Fraquezas)
        //    .WithMany(p => p.Pokemons)
        //    .UsingEntity(fp => fp.ToTable("FraquezaPokemon"));

    }
}


