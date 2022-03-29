using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWishListService:IGenericService<WhisList>
    {
        List<WhisList> GetListByUserId(int id);
    }
}
