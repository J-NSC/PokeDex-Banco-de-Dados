namespace Pokedex.Domain.Decks;

using Pokedex.Domain.pokemon;


public class Deck{
    public int Id { get; set; }
    public string NomeDeck { get; set; }
    public Usuario Usuario {get; set;}
    public int UsuarioId;

    public ICollection<Pokemon> Pokemon { get; set; }
}