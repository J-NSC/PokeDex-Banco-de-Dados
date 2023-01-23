namespace Pokedex.Domain.Deck;

using Pokedex.Domain.pokemon;


public class Deck{
    public int Id { get; set; }
    public string NomeDeck { get; set; }

    // public Pokemon Pokemon {get; set;}
    public Usuario Usuario {get; set;}

    // public int PokemonId;
    public int UsuarioId;
}