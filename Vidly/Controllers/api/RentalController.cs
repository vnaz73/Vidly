using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Vidly.Data;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class RentalController : ControllerBase
    {
        ApplicationDbContext _context;
        public RentalController(ApplicationDbContext context)
        {
            _context = context;

        }
        [HttpGet]
        public IEnumerable<Rental> GetRentals()
        {
            return _context.Rentals.ToList();
        }
        [HttpPost]
        public async Task<IActionResult> Create(RentalFormViewModel rental)
        {

            if (rental.MovieIds.Count == 0)
            {
                return BadRequest("No movies");
            }
            var customer = _context.Customers.SingleOrDefault(c => c.Id == rental.CustomerId);

            if(customer == null)
            {
                return BadRequest("Неверный CustomerID");
            }

           
            var movies = _context.Movies.Where(m => rental.MovieIds.Contains(m.Id)).ToList();
            if (rental.MovieIds.Count != movies.Count)
            {
                return BadRequest("One or more movie is invalid");
            }
            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                {
                    return BadRequest(movie.Name + " is unavailable");
                }
                movie.NumberAvailable--;
                var newRental = new Rental();
                newRental.Movie = movie;
                newRental.Customer = customer;
                newRental.DateRented = DateTime.Now;

                _context.Rentals.Add(newRental);
            }

            _context.SaveChanges();
           
            return Ok();
        }
    }
}