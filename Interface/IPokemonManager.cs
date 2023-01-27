using Pokedex.Domain.pokemon;
using Pokedex.Repository;

namespace Pokedex.Interface;

public interface IPokemonManager
{
    Task DeletePokemonAsync(int id);
    Task<Pokemon> GetPokemonAsync(int id);
    Task<IEnumerable<Pokemon>> GetPokemonsAsync();
    Task<Pokemon> CreatePokemonAsync(Pokemon pokemon);
    Task<Pokemon> UpdatePokemonAsync(Pokemon pokemon);

    
    
}
