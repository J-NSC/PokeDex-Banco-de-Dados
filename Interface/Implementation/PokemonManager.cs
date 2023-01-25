using Pokedex.Domain.pokemon;
using Pokedex.Repository;

namespace Pokedex.Interface.Implementation;

public class PokemonManager : IPokemonManager
{
	private readonly IPokemonRepository IPokemonRepository;

    public PokemonManager(IPokemonRepository pokemonRepository)
    {
        this.IPokemonRepository = pokemonRepository;

    }

    public async Task<Pokemon> GetPokemonAsync(int id)
    {
        return await IPokemonRepository.GetPokemonAsync(id);
    }

    public async Task<IEnumerable<Pokemon>> GetPokemonsAsync()
    {
        return await IPokemonRepository.GetPokemonsAsync();
    }


}
