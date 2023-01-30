using Pokedex.Domain.Decks;

namespace Pokedex.Interface;

public interface IDeckRepository
{
    Task DeleteDeckAsync(int id);
    Task<Deck> GetDeckAsync(int id);
    Task<Deck> CreateDeckAsync(Deck deck);
    Task<Deck> UpdateDeckAsync(Deck deck);
    Task<IEnumerable<Deck>> GetDeckAsyncs();
}
