using Pokedex.Domain.pokemon;
using Pokedex.Repository;

namespace Pokedex.Interface;

public interface IPokemonManager
{
    Task<Pokemon> GetPokemonAsync(int id);
    Task<IEnumerable<Pokemon>> GetPokemonsAsync();
}
