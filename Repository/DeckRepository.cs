using Microsoft.EntityFrameworkCore;
using Pokedex.Domain.Decks;
using Pokedex.Interface;
using Pokedex.Postgres;

namespace Pokedex.Repository;

public class DeckRepository : IDeckRepository
{
    ApplicationContextDb context;

    public DeckRepository(ApplicationContextDb context)
    {
        this.context = context;
    }

    public async Task<IEnumerable<Deck>> GetDeckAsyncs()
    {
        return await context.Decks.AsNoTracking().ToListAsync();
    }

    public async Task<Deck> GetDeckAsync(int id)
    {
        return await context.Decks.FindAsync(id);
    }

    public async Task<Deck> CreateDeckAsync(Deck deck)
    {
        await context.Decks.AddAsync(deck);
        await context.SaveChangesAsync();

        return deck;
    }

    public async Task<Deck> UpdateDeckAsync(Deck deck)
    {
        var deckContext = await context.Decks.FindAsync(deck.Id);

        if(deckContext == null)
        {
            return null;
        }

        context.Entry(deckContext).CurrentValues.SetValues(deck);
        await context.SaveChangesAsync();
        return deckContext;
    }

    public async Task DeleteDeckAsync(int id)
    {
        var deckContext = await context.Decks.FindAsync(id);
        context.Decks.Remove(deckContext);
        await context.SaveChangesAsync();
    }
}
