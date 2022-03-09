using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfProductRepository:GenericRepository<Product>,IProductDal
    {
        public List<Product> GetProductAllWithImage()
        {
            using (var c= new Context())
            {
                return c.Products.Include(p => p.Image).Where(c=>c.Image.CoverStatus==true).Include(y=>y.Category).ToList();

                //var pro = c.Products.FromSqlRaw("Select Products.Id,Products.Brand,Products.CategoryId,Products.Title,Products.Price,Images.ImageUrl,Images.CoverStatus,Products.Color,Products.Date,Products.Description,Products.Information,Products.SizeId,Products.Status,Products.Stock From Products inner join Images on Products.Id = Images.ProductId").ToList();
                //return pro;

            }
        }

        public List<Product> GetProductDetailWithCategory(int id)
        {
            using (var c = new Context())
            {
                return c.Products.Include(u => u.Category).Where(x=> x.Id==id).ToList(); 
            }
        }
    }
}
