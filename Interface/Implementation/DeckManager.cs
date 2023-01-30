using Pokedex.Domain.Decks;

namespace Pokedex.Interface.Implementation;

public class DeckManager : IDeckManager
{
    private readonly IDeckRepository iDeckRepository;

    public DeckManager(IDeckRepository iDeckRepository)
    {
        this.iDeckRepository = iDeckRepository;

    }

    public async Task<IEnumerable<Deck>> GetDeckAsyncs()
    {
        return await iDeckRepository.GetDeckAsyncs();
    }


    public async Task<Deck> GetDeckAsync(int id)
    {
        return await iDeckRepository.GetDeckAsync(id);
    }

    public async Task<Deck> CreateDeckAsync(Deck deck)
    {
        return await iDeckRepository.CreateDeckAsync(deck);
    }

    

    public async Task<Deck> UpdateDeckAsync(Deck deck)
    {
        return await iDeckRepository.UpdateDeckAsync(deck);
    }

    public async Task DeleteDeckAsync(int id)
    {
       await iDeckRepository.DeleteDeckAsync(id);
    }
}
