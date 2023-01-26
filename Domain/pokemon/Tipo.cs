namespace Pokedex.Domain.pokemon;

public class Tipo
{
    //public Tipo()
    //{
    //    this.Pokemons = new HashSet<Pokemon>();
    //}

    public int Id { get; set; }
    public string NomeTipo { get; set; }
    public virtual ICollection<Pokemon> Pokemons { get; set; }
}
