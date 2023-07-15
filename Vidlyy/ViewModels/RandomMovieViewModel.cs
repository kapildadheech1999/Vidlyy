using System.Collections.Generic;
using Vidlyy.Models;

namespace Vidlyy.Controllers
{
    internal class RandomMovieViewModel
    {
        public RandomMovieViewModel()
        {
        }

        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}