using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pokedex.Domain.pokemon;

namespace Pokedex.Configuration;

public class UsuarioConfiguration : IEntityTypeConfiguration<Pokemon>
{
    public void Configure(EntityTypeBuilder<Pokemon> builder)
    {
        builder.HasOne(u => u.Usuario)
            .WithOne(p => p.Pokemon)
            .HasForeignKey<Pokemon>(p => p.UsuarioId);
    }
}
