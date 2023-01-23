namespace Pokedex.Domain.pokemon;

public class TipoPokemon
{
    public int id { get; set; }
    public List<Tipo> Tipo { get; set; }
    public List<Pokemon> Pokemon { get; set; }
}
