using OdeToFood.Core;
using System.Linq;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using Microsoft.EntityFrameworkCore;

namespace OdeToFood.Data
{
    public class SqlRestaurantData : IRestaurantData
    {
        private readonly ApplicationDbContext _db;

        public SqlRestaurantData(ApplicationDbContext db)
        {
            _db = db;
        }

        public int Commit()
        {
            return _db.SaveChanges();
        }

        public Restaurant Create(Restaurant newRestaurant)
        {
            _db.Restaurants.Add(newRestaurant);
            return newRestaurant;
        }

        public Restaurant Delete(int id)
        {
            var restaurant = GetById(id);
            if(restaurant != null)
            {
                _db.Restaurants.Remove(restaurant);
            }
            return restaurant;
        }

        public Restaurant GetById(int id)
        {
            return _db.Restaurants.Find(id);
        }

        public IEnumerable<Restaurant> GetByName(string name)
        {
            var query = from r in _db.Restaurants
                        where r.Name.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby r.Name
                        select r;

            return query;
        }

        public int GetTotalCount()
        {
            return _db.Restaurants.Count();
        }

        public Restaurant Update(Restaurant updatedRestaurant)
        {
            var entity = _db.Restaurants.Attach(updatedRestaurant);
            entity.State = EntityState.Modified;
            return updatedRestaurant;
        }
    }
}
