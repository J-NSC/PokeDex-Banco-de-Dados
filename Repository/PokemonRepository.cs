using Microsoft.EntityFrameworkCore;
using Pokedex.Domain.pokemon;
using Pokedex.Interface;
using Pokedex.Postgres;

namespace Pokedex.Repository;

public class PokemonRepository :IPokemonRepository
{
	ApplicationContextDb context;

    public PokemonRepository(ApplicationContextDb context)
	{
		this.context = context;
	}

	//pega todos os pokemons do banco
	public async Task<IEnumerable<Pokemon>> GetPokemonsAsync()
	{
		return await context.Pokemons.AsNoTracking().ToListAsync();
	}

	//retornar um pokemon expecifico de acordo com o ID
	public async Task<Pokemon> GetPokemonAsync(int id)
	{
		//return await context.Pokemons.FirstOrDefaultAsync(p => p.Id == id);
		return await context.Pokemons.FindAsync(id);
	}

	//Insert
	public async Task<Pokemon>CreatePokemonAsync(Pokemon pokemon)
	{
		await context.Pokemons.AddAsync(pokemon);
		await context.SaveChangesAsync();

        return pokemon;

    }

	//Update
	public async Task<Pokemon> UpdatePokemonAsync(Pokemon pokemon)
	{
		var pokemonContext = await context.Pokemons.FindAsync(pokemon.Id);
		if (pokemonContext == null)
		{
			return null;
		}

		context.Entry(pokemonContext).CurrentValues.SetValues(pokemon);

		await context.SaveChangesAsync();
		return pokemonContext;
	}
	//Delete

	public async Task DeletePokemonAsync(int id)
	{
        var pokemonContext = await context.Pokemons.FindAsync(id);
		context.Pokemons.Remove(pokemonContext);
		await context.SaveChangesAsync();
    }
}
