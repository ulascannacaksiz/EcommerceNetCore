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
    public class CityManager : ICityService
    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public List<City> GetList()
        {
            return _cityDal.GetAll();
        }

        public void TAdd(City t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(City t)
        {
            throw new NotImplementedException();
        }

        public City TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(City t)
        {
            throw new NotImplementedException();
        }
    }
}
