using Pokedex.Domain.pokemon;

namespace Pokedex.Postgres.Seeder;

public class PokemonSeeder
{
    private readonly ApplicationContextDb context;

	public PokemonSeeder(ApplicationContextDb context)
	{
		this.context = context;
	}

	public void SeedDataContext()
	{
        if (!context.Tipos.Any())
        {
            var tipos = new List<Tipo>()
            {
                new Tipo()
                {
                    Id = 1,
                    NomeTipo = "Grama"
                },
                new Tipo()
                {
                    NomeTipo = "Venenoso"
                }
            };
            context.Tipos.AddRange(tipos);
            context.SaveChanges();
        }

        if (!context.Regiaos.Any())
        {
            var regiaos = new List<Regiao>()
            {
                new Regiao()
                {
                    Id = 1,
                    RegiaoPokemon = "Kanto"
                }
            };
        }

        if (!context.Usuarios.Any())
        {
            var usuario = new List<Usuario>()
            {
                new Usuario()
                {
                    Id = 1,
                    Nome = "Lorenzo",
                    Sobrenome = "Pinto"
                }
            };
        }
        if (!context.Pokemons.Any())
		{
			var pokemons = new List<Pokemon>()
			{
				new Pokemon()
				{
					Id = 1,
					NomePokemon = "Bulbasaur",
					Peso = 6.9f,
					Altura = 0.7f,
					Hp = 15f,
					Ataque = 3f,
					Defesa = 4f,
					SuperAtauqe = 5f,
					SuperDefesa = 5f,
					Speed = 5f,
					UsuarioId = 1,
					RegiaoId = 1,
				}
			};
			context.Pokemons.AddRange(pokemons);
			context.SaveChanges();
		}


	}
}
