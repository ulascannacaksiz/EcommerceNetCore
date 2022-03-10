using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceCore.ViewComponents.Product
{
    public class ReviewList:ViewComponent
    {
        RatingManager rm = new RatingManager(new EfRatingRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = rm.GetListByProductId(id);
            return View(values);
        }
    }
}
