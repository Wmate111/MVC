using katalogfilmowMVC.Data;
using katalogfilmowMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace katalogfilmowMVC.Controllers
{
    public class FilmsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public FilmsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Films
        public async Task<IActionResult> Index(string searchString, string gatunek)
        {
            var filmy = from f in _context.Filmy
                        select f;

            if (!string.IsNullOrWhiteSpace(searchString))
            {
                filmy = filmy.Where(f =>
                    f.Tytul.Contains(searchString) ||
                    f.Rezyser.Contains(searchString));
            }

            if (!string.IsNullOrWhiteSpace(gatunek))
            {
                filmy = filmy.Where(f => f.Gatunek.Contains(gatunek));
            }

            ViewData["CurrentSearch"] = searchString;
            ViewData["CurrentGatunek"] = gatunek;

            return View(await filmy.OrderBy(f => f.Tytul).ToListAsync());
        }

        // GET: Films/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Filmy
                .FirstOrDefaultAsync(m => m.Id == id);

            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        // GET: Films/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Films/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Tytul,Rezyser,Gatunek,RokProdukcji,Ocena,Opis")] Film film)
        {
            if (ModelState.IsValid)
            {
                _context.Add(film);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(film);
        }

        // GET: Films/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Filmy.FindAsync(id);

            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        // POST: Films/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Tytul,Rezyser,Gatunek,RokProdukcji,Ocena,Opis")] Film film)
        {
            if (id != film.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(film);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FilmExists(film.Id))
                    {
                        return NotFound();
                    }

                    throw;
                }

                return RedirectToAction(nameof(Index));
            }

            return View(film);
        }

        // GET: Films/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Filmy
                .FirstOrDefaultAsync(m => m.Id == id);

            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        // POST: Films/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var film = await _context.Filmy.FindAsync(id);

            if (film != null)
            {
                _context.Filmy.Remove(film);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        private bool FilmExists(int id)
        {
            return _context.Filmy.Any(e => e.Id == id);
        }
    }
}