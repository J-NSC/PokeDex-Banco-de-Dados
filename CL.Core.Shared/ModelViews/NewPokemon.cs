using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL.Core.Shared.ModelViews;

public class NewPokemon
{
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

    public int RegiaoId { get; set; }
    public int UsuarioId { get; set; }
    public int CategoriaId { get; set; }
}
