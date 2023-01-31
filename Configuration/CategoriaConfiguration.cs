using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pokedex.Domain.pokemon;

namespace Pokedex.Configuration;

public class CategoriaConfiguration : IEntityTypeConfiguration<Pokemon>
{
    public void Configure(EntityTypeBuilder<Pokemon> builder)
    {
        builder
            .HasOne(c => c.Categoria)
            .WithOne(p => p.Pokemon)
            .HasForeignKey<Pokemon>(p=>p.CategoriaId);
    }
}
