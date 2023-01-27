﻿using Pokedex.Domain.pokemon;

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
        if (!context.Pokemons.Any())
		{
			var pokemons = new List<Pokemon>()
			{
                // 25 
				new Pokemon()
				{
					Id = 1,
					NomePokemon = "Bulbasaur",
                    Descricao = "pokemon foda",
					Peso = "6.9",
					Altura = "0.7",
					Hp = 15f,
					Ataque = "3",
					Defesa = "4",
					SuperAtauqe = "5",
					SuperDefesa = "5",
					Speed = "5",
                    Regiao = new Regiao(){
                        Id = 1,
                        RegiaoPokemon = "Kanto"
                    },
                    Usuario = new Usuario(){
                        Id = 1,
                        Nome = "lorenzo",
                        Sobrenome = "Gato"
                    },
                    Categoria = new Categoria(){
                        Id = 1,
                        CategoriaPokemon = "Planta"
                    }
				}
			};
			context.Pokemons.AddRange(pokemons);
			context.SaveChanges();
		}


	}
}
