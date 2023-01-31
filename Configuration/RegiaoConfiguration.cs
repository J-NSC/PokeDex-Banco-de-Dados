using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pokedex.Domain.pokemon;

namespace Pokedex.Configuration;

public class RegiaoConfiguration : IEntityTypeConfiguration<Pokemon>
{
    public void Configure(EntityTypeBuilder<Pokemon> builder)
    {
        builder
            .HasOne(t => t.Regiao)
            .WithOne(p => p.Pokemon)
            .HasForeignKey<Pokemon>(p => p.RegiaoId);
    }
}
