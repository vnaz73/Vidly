using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Vidly.Data;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        private ApplicationDbContext _context;

        public MoviesController()
        {
            var builder = new ConfigurationBuilder();
            // установка пути к текущему каталогу
            builder.SetBasePath(Directory.GetCurrentDirectory());
            // получаем конфигурацию из файла appsettings.json
            builder.AddJsonFile("appsettings.json");
            // создаем конфигурацию
            var config = builder.Build();
            // получаем строку подключения
            string connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            var options = optionsBuilder
                .UseSqlServer(connectionString)
                .Options;

            _context = new ApplicationDbContext(options);
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();

            base.Dispose(disposing);
        }

       

        public IActionResult Index()
        {

            var movies = _context.Movies.Include(c => c.Genre).ToList();

            
            return View(movies);
        }
        [Route("movies/details/{id}")]
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);
            if (movie == null) return NotFound();
            return View(movie);
        }

        public IActionResult New()
        {

            var genres = _context.Genres.ToList();
            var viewModel = new MovieFormViewModel
            {
                Movie = new Movie(),
                Genres = genres
            };

            return View("MovieForm", viewModel);
        }

        [HttpPost]
        public IActionResult Save(Movie movie)
        {

            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel
                {
                    Movie = movie,
                    Genres = _context.Genres.ToList()

                };
                return View("MovieForm", viewModel);
            }
            if (movie.Id == 0)
                _context.Movies.Add(movie);
            else
            {
                var movieInDb = _context.Movies.Single(c => c.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.AddedDate = movie.AddedDate;
                movieInDb.GenreId = movie.GenreId;
                movieInDb.NumberInStock = movie.NumberInStock;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }

        public IActionResult Edit(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null) return NotFound();

            var viewModel = new MovieFormViewModel
            {
                Movie = movie,
                Genres = _context.Genres.ToList()

            };

            return View("MovieForm", viewModel);
        }
    }

}