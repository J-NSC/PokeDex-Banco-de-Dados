using Pokedex.Domain.Decks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pokedex.Domain.pokemon;

public class Pokemon
{

    //public Pokemon()
    //{
    //    this.Tipos = new HashSet<Tipo>();
    //}

    private int id;
    private string nomePokemon;
    private string descricao;
    private string peso;
    private string altura;
    private float hp;
    private string ataque;
    private string defesa;
    private string superAtauqe;
    private string superDefesa;
    private string speed;

    public int Id { get => id; set => id = value; }
    public string NomePokemon { get => nomePokemon; set => nomePokemon = value; }
    public string Descricao { get => descricao; set => descricao = value; }
    public string Peso { get => peso; set => peso = value; }
    public string Altura { get => altura; set => altura = value; }
    public float Hp { get => hp; set => hp = value; }
    public string Ataque { get => ataque; set => ataque = value; }
    public string Defesa { get => defesa; set => defesa = value; }
    public string SuperAtauqe { get => superAtauqe; set => superAtauqe = value; }
    public string SuperDefesa { get => superDefesa; set => superDefesa = value; }
    public string Speed { get => speed; set => speed = value; }

    public Regiao Regiao { get; set; }
    public Usuario Usuario { get; set; }
    public Categoria Categoria { get; set; }

    public int RegiaoId { get; set; }
    public int UsuarioId { get; set; }
    public int CategoriaId{get; set;}

    public virtual ICollection<Tipo> Tipos { get; set; }
    public virtual ICollection<Habilidade> Habilidades { get; set; }
    public virtual ICollection<Fraqueza> Fraquezas { get; set; }
    public virtual ICollection<Deck> Decks { get; set; }
}
