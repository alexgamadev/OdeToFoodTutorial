using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using OdeToFood.Core;
using OdeToFood.Data;

namespace OdeToFood.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        public IConfiguration Config { get; }
        public IRestaurantData RestaurantData { get; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string Message { get; set; }

        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            Config = config;
            RestaurantData = restaurantData;
        }
        public void OnGet()
        {
            Message = Config["Message"];
            Restaurants = RestaurantData.GetAll();
        }
    }
}