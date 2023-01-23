namespace Pokedex.Domain.pokemon;

public class Pokemon
{
    private int id;
    private string nomePokemon;
    private float peso;
    private float altura;
    private float hp;
    private float ataque;
    private float defesa;
    private float superAtauqe;
    private float superDefesa;
    private float speed;

    public int Id { get => id; set => id = value; }
    public string NomePokemon { get => nomePokemon; set => nomePokemon = value; }
    public float Peso { get => peso; set => peso = value; }
    public float Altura { get => altura; set => altura = value; }
    public float Hp { get => hp; set => hp = value; }
    public float Ataque { get => ataque; set => ataque = value; }
    public float Defesa { get => defesa; set => defesa = value; }
    public float SuperAtauqe { get => superAtauqe; set => superAtauqe = value; }
    public float SuperDefesa { get => superDefesa; set => superDefesa = value; }
    public float Speed { get => speed; set => speed = value; }

    //Foreign key 
    public TipoPokemon TipoPokemon {get; set;}
    public Regiao Regiao { get; set; }
    public Usuario Usuario { get; set; }

    public int TipoPokemonId;
    public int RegiaoId;
    public int UsuarioId;


}
