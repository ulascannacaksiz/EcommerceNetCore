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
    public class RatingManager:IRatingService
    {
        IRatingDal _ratingDal;

        public RatingManager(IRatingDal ratingDal)
        {
            _ratingDal = ratingDal;
        }

        public List<Rating> GetList()
        {
            throw new NotImplementedException();
            
        }

        public List<Rating> GetListByProductId(int id)
        {
            return _ratingDal.GetListAll(x => x.ProductId == id).ToList();
        }

        public void TAdd(Rating t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Rating t)
        {
            throw new NotImplementedException();
        }

        public Rating TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Rating t)
        {
            throw new NotImplementedException();
        }
    }
}
