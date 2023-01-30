using CL.Core.Shared.ModelViews;
using Pokedex.Domain.pokemon;
using Pokedex.Repository;

namespace Pokedex.Interface;

public interface IPokemonManager
{
    Task DeletePokemonAsync(int id);
    Task<Pokemon> GetPokemonAsync(int id);
    Task<IEnumerable<Pokemon>> GetPokemonsAsync();
    Task<Pokemon> CreatePokemonAsync(NewPokemon pokemon);
    Task<Pokemon> UpdatePokemonAsync(Pokemon pokemon);

}
