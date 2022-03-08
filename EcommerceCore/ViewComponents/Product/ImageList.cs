using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EcommerceCore.ViewComponents.Product
{
    public class ImageList:ViewComponent
    {
        ImageManager ım = new ImageManager(new EfImageRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = ım.GetListByProductId(id);
            ViewBag.cover = values.ToList().Where(x => x.CoverStatus == true).FirstOrDefault().ImageUrl;
            return View(values);
        }
    }
}
