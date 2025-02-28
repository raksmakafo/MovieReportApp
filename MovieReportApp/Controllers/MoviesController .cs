using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieReportApp.Data;
using MovieReportApp.Models; // Імпорт моделей

namespace MovieReportApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/movies (Отримати всі фільми)
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Movie>>> GetMovies()
        {
            return await _context.Movie.ToListAsync();
        }

        // GET api/movies/5 (Отримати конкретний фільм)
        [HttpGet("{id}")]
        public async Task<ActionResult<Movie>> GetMovie(int id)
        {
            var movies = await _context.Movie.FindAsync(id);
            if (movies == null)
                return NotFound();
            return movies;
        }

        // POST api/movies (Створити новий фільм)
        [HttpPost]
        public async Task<ActionResult<Movie>> CreateMovie(Movie movies)
        {
            _context.Movie.Add(movies);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetMovie), new { id = movies.Id }, movies);
        }

        // PUT api/movies/5 (Оновити фільм)
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMovie(int id, Movie movies)
        {
            if (id != movies.Id)
                return BadRequest();

            _context.Entry(movies).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/movies/5 (Видалити фільм)
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            var movies = await _context.Movie.FindAsync(id);
            if (movies == null)
                return NotFound();

            _context.Movie.Remove(movies);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
