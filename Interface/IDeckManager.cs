using Pokedex.Domain.Decks;

namespace Pokedex.Interface;

public interface IDeckManager
{
    Task DeleteDeckAsync(int id);
    Task<Deck> GetDeckAsync(int id);
    Task<IEnumerable<Deck>> GetDeckAsyncs();
    Task<Deck> CreateDeckAsync(Deck deck);
    Task<Deck> UpdateDeckAsync(Deck deck);
}
