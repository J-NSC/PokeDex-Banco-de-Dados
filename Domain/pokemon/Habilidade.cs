namespace Pokedex.Domain.pokemon;

public class Habilidade
{
    public int Id { get; set; }
    public string NomeHabilidade { get; set; }

    public ICollection<Pokemon> Pokemons { get; set; }
}
