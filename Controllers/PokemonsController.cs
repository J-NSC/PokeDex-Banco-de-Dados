using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Pokedex.Domain.pokemon;
using Pokedex.Interface;
using Pokedex.Interface.Implementation;
using Pokedex.Postgres;

namespace Pokedex.Controllers
{
    public class PokemonsController : Controller
    {
        private readonly ApplicationContextDb _context;
        private readonly IPokemonManager pokemonManager;

        public PokemonsController(ApplicationContextDb context, IPokemonManager pokemonManager)
        {
            _context = context;
            this.pokemonManager = pokemonManager;
        }

        // GET: Pokemons
        public async Task<IActionResult> Index()
        {
            //return View(await _context.Pokemons.ToListAsync());
            return Ok(await pokemonManager.GetPokemonsAsync());
        }

        // GET: Pokemons/Details/5
        public async Task<IActionResult> Details(int id)
        {

            return Ok(await pokemonManager.GetPokemonAsync(id));
        }

        //// GET: Pokemons/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        // POST: Pokemons/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Pokemon pokemon)
        {

            var pokemonContext = await pokemonManager.CreatePokemonAsync(pokemon);
            return CreatedAtAction(nameof(Details), new {id = pokemon.Id}, pokemon);
        }

        // GET: Pokemons/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.Pokemons == null)
        //    {
        //        return NotFound();
        //    }

        //    var pokemon = await _context.Pokemons.FindAsync(id);
        //    if (pokemon == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(pokemon);
        //}

        // POST: Pokemons/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Pokemon pokemon)
        {
            var pokemonContext = await pokemonManager.CreatePokemonAsync(pokemon);
            if (pokemonContext == null)
            {
                return NotFound();
            }

            return Ok(pokemonContext);
        }

        // GET: Pokemons/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.Pokemons == null)
        //    {
        //        return NotFound();
        //    }

        //    var pokemon = await _context.Pokemons
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (pokemon == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(pokemon);
        //}

        // POST: Pokemons/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
           await pokemonManager.DeletePokemonAsync(id);
            
           return NoContent();
        }

        //private bool PokemonExists(int id)
        //{
        //  return _context.Pokemons.Any(e => e.Id == id);
        //}
    }
}
