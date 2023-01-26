namespace Pokedex.Domain.pokemon
{
    public class Usuario
    {
        private int id;
        private string nome;
        private string sobrenome;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Sobrenome { get => sobrenome; set => sobrenome = value; }


    }
}
