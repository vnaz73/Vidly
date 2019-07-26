using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class RentalFormViewModel
    {
        public int CustomerId { get; set; }
        public List<int> MovieIds { get; set; }

        public DateTime DateRented { get; set; }
        public DateTime DateReturned { get; set; }
    }
}
