using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollectionApplication.Models
{
    public class ViewModel
    {
        public Movie Movie { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
        public Review Review { get; set; }

        public ViewModel(Movie movie, IEnumerable<Review> reviews)
        {
            Movie = movie;
            Reviews = reviews;
        }
    }
}
