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
    public class EfWishListRepository : GenericRepository<WhisList>, IWishListDal
    {
        public List<WhisList> GetWhisListWithProduct(int userid)
        {
           using (var c = new Context())
           {
               return c.WhisLists.Include(x=>x.Product).Include(h=>h.Product.Image).Where(j=>j.Product.Image.CoverStatus== true).Where(y=>y.UserId == userid).ToList();
           }
        }
    }
}
