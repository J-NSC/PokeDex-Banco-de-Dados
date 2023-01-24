namespace Pokedex.Domain.pokemon;

public class Fraqueza
{
    public int Id { get; set; }
    public string FraquezaName { get; set; }

    public ICollection<Pokemon> Pokemons { get; set; }
}
