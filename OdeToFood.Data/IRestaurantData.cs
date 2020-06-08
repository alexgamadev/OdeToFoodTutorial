using OdeToFood.Core;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetByName(string name);
        Restaurant GetById(int id);
        Restaurant Update(Restaurant updatedRestaurant);
        Restaurant Create(Restaurant newRestaurant);
        Restaurant Delete(int id);
        int Commit();
    }
}
