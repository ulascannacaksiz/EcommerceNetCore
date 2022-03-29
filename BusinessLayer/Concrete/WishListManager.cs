using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WishListManager : IWishListService
    {
        IWishListDal _whisListDal;

        public WishListManager(IWishListDal whisListDal)
        {
            _whisListDal = whisListDal;
        }

        public List<WhisList> GetList()
        {
            return _whisListDal.GetAll();
        }

        public List<WhisList> GetListByUserId(int id)
        {
            return _whisListDal.GetWhisListWithProduct(id);
        }

        public void TAdd(WhisList t)
        {
            _whisListDal.Insert(t);
        }

        public void TDelete(WhisList t)
        {
            throw new NotImplementedException();
        }

        public WhisList TGetById(int id)
        {
            return _whisListDal.GetById(id);
        }

        public void TUpdate(WhisList t)
        {
            _whisListDal.Update(t);
        }
    }
}
