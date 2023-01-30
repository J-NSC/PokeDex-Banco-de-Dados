using AutoMapper;
using CL.Core.Shared.ModelViews;
using Pokedex.Domain.pokemon;
using Pokedex.Repository;

namespace Pokedex.Interface.Implementation;

public class PokemonManager : IPokemonManager
{
	private readonly IPokemonRepository IPokemonRepository;
    private readonly IMapper mapper;

    public PokemonManager(IPokemonRepository pokemonRepository, IMapper mapper)
    {
        this.IPokemonRepository = pokemonRepository;
        this.mapper = mapper;

    }

    public async Task<Pokemon> GetPokemonAsync(int id)
    {
        return await IPokemonRepository.GetPokemonAsync(id);
    }

    public async Task<IEnumerable<Pokemon>> GetPokemonsAsync()
    {
        return await IPokemonRepository.GetPokemonsAsync();
    }

    public async Task<Pokemon> UpdatePokemonAsync(Pokemon pokemon)
    {
        return await IPokemonRepository.UpdatePokemonAsync(pokemon); 
    }

    public async Task<Pokemon> CreatePokemonAsync(NewPokemon newPokemon)
    {
        var pokemon = mapper.Map<Pokemon>(newPokemon);
        return await IPokemonRepository.CreatePokemonAsync(pokemon);
    }

    public async Task DeletePokemonAsync(int id)
    {
        await IPokemonRepository.DeletePokemonAsync(id);
    }
}
