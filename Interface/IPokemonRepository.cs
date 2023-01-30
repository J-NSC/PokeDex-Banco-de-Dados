using CL.Core.Shared.ModelViews;
using Pokedex.Domain.pokemon;

namespace Pokedex.Interface;

public interface IPokemonRepository
{
    Task DeletePokemonAsync(int id);
    Task<Pokemon> GetPokemonAsync(int id);
    Task<IEnumerable<Pokemon>> GetPokemonsAsync();
    Task<Pokemon> CreatePokemonAsync(Pokemon pokemon);
    Task<Pokemon> UpdatePokemonAsync(Pokemon pokemon);
}
