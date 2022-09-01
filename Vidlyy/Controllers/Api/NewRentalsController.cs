using System;
using System.Linq;
using System.Web.Http;
using Vidlyy.Dtos;
using Vidlyy.Models;

namespace Vidlyy.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;
        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            if (newRental.MovieIds.Count == 0)    // Defensive edge case
                return BadRequest("No Movie Ids have been given.");

            var customer = _context.Customers.SingleOrDefault(c => c.Id == newRental.CustomerId);

            if (customer == null)   // Defensive edge case
                return BadRequest("CustomerId is not valid.");

            var movies = _context.Movies.Where(m => newRental.MovieIds.Contains(m.Id)).ToList();//Select *from Movies Where Id In(,3,4,5)

            if (movies.Count != newRental.MovieIds.Count)   // Defensive edge case
                return BadRequest("One or more movieIds are invalid");

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not Available");

                movie.NumberAvailable--;
                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };
                _context.Rentals.Add(rental);
            }
            _context.SaveChanges();
            return Ok();
        }
    }
}
