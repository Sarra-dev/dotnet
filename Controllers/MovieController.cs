using Microsoft.AspNetCore.Mvc;
using MyFirstApp.Models;

namespace MyFirstApp.Controllers
{
    public class MovieController : Controller
    {
        private readonly ApplicationDbContext _db;

        // Inject the database context
        public MovieController(ApplicationDbContext db)
        {
            _db = db;
        }

        // Option 1: Hardcoded movies
        /*public IActionResult Index()
        {
            var movies = new List<Movie>() 
            {
                new Movie{Id=1, name="Name1"},
                new Movie{Id=2, name="Name2"},
            };

            return View(movies);
        }*/

        // Option 2: Fetch movies from the database
        public IActionResult index()
        {
            var movies = _db.movies.ToList();
            return View("Index", movies); // reuse the same view
        }
    }
}
