using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OdeToFood.Core
{
    public class Restaurant
    {
        [Required]
        public int Id { get; set; }

        [Required, StringLength(50, MinimumLength = 6)]
        public string Name { get; set; }

        [Required, StringLength(50, MinimumLength = 6)]
        public string Location { get; set; }

        public CuisineType Cuisine { get; set; }
    }
}
