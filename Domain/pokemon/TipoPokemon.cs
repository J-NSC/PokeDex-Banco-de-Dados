namespace Pokedex.Domain.pokemon;

public class TipoPokemon
{
    public int id { get; set; }
    public Tipo Tipo { get; set; }
    public Pokemon Pokemon { get; set; }
    public int TipoId { get; set; }
    public int PokemonId { get; set; }

}
