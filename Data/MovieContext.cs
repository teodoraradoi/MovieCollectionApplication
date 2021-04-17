using Microsoft.EntityFrameworkCore;
using MovieCollectionApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollectionApplication.Data
{
    public class MovieContext: DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options): base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Review> Review { get; set; }

    }
}
