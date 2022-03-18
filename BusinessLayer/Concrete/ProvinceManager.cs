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
    public class ProvinceManager : IProvinceService
    {
        IProvinceDal _provinceDal;

        public ProvinceManager(IProvinceDal provinceDal)
        {
            _provinceDal = provinceDal;
        }

        public List<Province> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Province> GetProvinceListByCityId(int id)
        {
            return _provinceDal.GetListAll(x => x.CityId == id);
        }

        public void TAdd(Province t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Province t)
        {
            throw new NotImplementedException();
        }

        public Province TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Province t)
        {
            throw new NotImplementedException();
        }
    }
}
