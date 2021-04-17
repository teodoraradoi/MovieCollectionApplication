using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieCollectionApplication.Models
{
    public class Review
    {
        public int Id { get; set; }

        public Movie Movie { get; set; }

        public string Name { get; set; }

        public string ReviewText { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReviewDate { get; set; }
    }
}
