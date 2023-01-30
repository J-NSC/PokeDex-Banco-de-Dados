using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pokedex.Domain.Decks;
using Pokedex.Interface;
using Pokedex.Postgres;

namespace Pokedex.Controllers
{
    public class DecksController : Controller
    {
        private readonly ApplicationContextDb _context;
        private readonly IDeckManager deckManager;

        public DecksController(ApplicationContextDb context, IDeckManager deckManager)
        {
            _context = context;
            this.deckManager = deckManager;
        }

        // GET: Decks
        [HttpGet]
        [Route("get All decks")]
        public async Task<IActionResult> Index()
        {
            return Ok(await deckManager.GetDeckAsyncs());
        }

        // GET: Decks/Details/5
        [HttpGet]
        [Route("getById")]
        public async Task<IActionResult> Details(int id)
        {
            if (_context.Decks == null)
            {
                return NotFound();
            }

            return Ok(await deckManager.GetDeckAsync(id));
        }

        // GET: Decks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Decks/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("CreadDeck")]
        public async Task<IActionResult> Create(Deck deck)
        {
            var deckContext = await deckManager.CreateDeckAsync(deck);
            return CreatedAtAction(nameof(Details), new {id = deck.Id}, deck);
        }

        // GET: Decks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Decks == null)
            {
                return NotFound();
            }

            var deck = await _context.Decks.FindAsync(id);
            if (deck == null)
            {
                return NotFound();
            }
            return View(deck);
        }

        // POST: Decks/Edit/5
        [HttpPut]
        [ValidateAntiForgeryToken]
        [Route("Edit deck")]
        public async Task<IActionResult> Edit(Deck deck)
        {
            var deckContext = await deckManager.UpdateDeckAsync(deck);
            if (deckContext == null)
            {
                return NotFound();
            }
            return Ok();
        }

        // GET: Decks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Decks == null)
            {
                return NotFound();
            }

            var deck = await _context.Decks
                .FirstOrDefaultAsync(m => m.Id == id);
            if (deck == null)
            {
                return NotFound();
            }

            return View(deck);
        }

        // POST: Decks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Route("DeleteDeck")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await deckManager.DeleteDeckAsync(id);
            return NoContent();
        }

        private bool DeckExists(int id)
        {
          return _context.Decks.Any(e => e.Id == id);
        }
    }
}
