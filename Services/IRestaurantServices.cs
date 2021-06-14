using System;
using System.Collections.Generic;
using System.Linq;
using odetofood.web.Interface;
using odetofood.web.Models;



namespace odetofood.web.Services
{
    public class IRestaurantServices : IRestaurantData
    {
        List<Restaurant> Restaurants;
        public IRestaurantServices()
        {
            Restaurants = new List<Restaurant>()
            {
             new Restaurant  {Id = 1, Name = "HardRock Cafe", Cuisine = CuisineType.Italian},
             new Restaurant {Id = 2, Name = "Rainbow Cafe", Cuisine = CuisineType.Chinese},
             new Restaurant {Id = 3, Name = "Cerelle Cafe", Cuisine = CuisineType.French},

            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return Restaurants.OrderBy(r => r.Name);
        }

    }
}