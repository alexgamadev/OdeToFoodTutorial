using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;
using System.Linq;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant {Id = 1, Name = "Kez's Pizza", Location = "Derby", Cuisine = CuisineType.Italian},
                new Restaurant {Id = 2, Name = "Alex's Chinese", Location = "King's Hill", Cuisine = CuisineType.Chinese},
                new Restaurant {Id = 3, Name = "Bill's Burritos", Location = "London", Cuisine = CuisineType.Mexican},
                new Restaurant {Id = 4, Name = "Ihilia's Indian", Location = "Nottingham", Cuisine = CuisineType.Indian}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
