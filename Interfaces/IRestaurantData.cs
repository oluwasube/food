using System.Collections.Generic;
using odetofood.web.Models;

namespace odetofood.web.Interface
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}