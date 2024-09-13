using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiStands.Data;
using ApiStands.Models;

namespace ApiStands.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StandsController : ControllerBase
    {
        private readonly DBStandsContext _context;

        public StandsController(DBStandsContext context)
        {
            _context = context;
        }

        // GET: api/Stands
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Stand>>> GetStand()
        {
          if (_context.Stand == null)
          {
              return NotFound();
          }
            return await _context.Stand.ToListAsync();
        }

        // GET: api/Stands/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Stand>> GetStand(int id)
        {
          if (_context.Stand == null)
          {
              return NotFound();
          }
            var stand = await _context.Stand.FindAsync(id);

            if (stand == null)
            {
                return NotFound();
            }

            return stand;
        }

        // PUT: api/Stands/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStand(int id, Stand stand)
        {
            if (id != stand.Id)
            {
                return BadRequest();
            }

            _context.Entry(stand).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StandExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Stands
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Stand>> PostStand(Stand stand)
        {
          if (_context.Stand == null)
          {
              return Problem("Entity set 'DBStandsContext.Stand'  is null.");
          }
            _context.Stand.Add(stand);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStand", new { id = stand.Id }, stand);
        }

        // DELETE: api/Stands/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStand(int id)
        {
            if (_context.Stand == null)
            {
                return NotFound();
            }
            var stand = await _context.Stand.FindAsync(id);
            if (stand == null)
            {
                return NotFound();
            }

            _context.Stand.Remove(stand);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StandExists(int id)
        {
            return (_context.Stand?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
