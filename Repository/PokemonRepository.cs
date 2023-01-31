using CL.Core.Shared.ModelViews;
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
		return await context.Pokemons
			.Include(p => p.Usuario)
            .Include(p => p.Regiao)
            .Include(p => p.Categoria)
			.Include(p => p.Tipos)
            .AsNoTracking().ToListAsync();
	}

	//retornar um pokemon expecifico de acordo com o ID
	public async Task<Pokemon> GetPokemonAsync(int id)
	{
		
		return await context.Pokemons
			.Include(p=>p.Usuario)
            .Include(p => p.Regiao)
            .Include(p => p.Categoria)
            .SingleOrDefaultAsync(p => p.Id == id);
	}

	//Insert
	public async Task<Pokemon>CreatePokemonAsync(Pokemon pokemon)
	{
		await context.Pokemons.AddAsync(pokemon);
		await InsertTipoPokemon(pokemon);
		await context.SaveChangesAsync();

        return pokemon;

    }

	public async Task InsertTipoPokemon(Pokemon pokemon) {
        foreach (var tipoPokemon in pokemon.Tipos)
        {
            var tipoPokemonContext = await context.Tipos.AsNoTracking().FirstAsync(p => p.Id == tipoPokemon.Id);
            context.Entry(tipoPokemon).CurrentValues.SetValues(tipoPokemonContext);
        }
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
