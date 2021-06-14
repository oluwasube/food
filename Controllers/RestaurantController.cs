using Microsoft.AspNetCore.Mvc;
using odetofood.web.Interface;
using odetofood.web.Services;

namespace odetofood.web.Controllers
{
    public class RestaurantController : Controller
    {
        IRestaurantData db;

        public RestaurantController()
    {
        db = new IRestaurantServices();
    }


    public ActionResult Index()
    {
            var model = db.GetAll();
            return View(model);
        }

    }
    
}
