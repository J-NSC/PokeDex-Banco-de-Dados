namespace Pokedex.Domain.Deck;

using Pokedex.Domain.pokemon;


public class Deck{
    public int Id { get; set; }
    public string NomeDeck { get; set; }
    public List<Pokemon> Pokemons{ get; set; }
    public Usuario Usuario {get; set;}
    public int UsuarioId;
}