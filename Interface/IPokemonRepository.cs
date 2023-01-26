using Pokedex.Domain.pokemon;

namespace Pokedex.Interface;

public interface IPokemonRepository
{
    Task<Pokemon> GetPokemonAsync(int id);
    Task<IEnumerable<Pokemon>> GetPokemonsAsync();
}
