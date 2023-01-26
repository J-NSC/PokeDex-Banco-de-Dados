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
}
