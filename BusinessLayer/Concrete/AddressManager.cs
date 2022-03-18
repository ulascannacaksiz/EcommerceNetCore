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
    public class AddressManager : IAddressService
    {
        IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public List<Address> GetList()
        {
            return _addressDal.GetAll();
        }

        public List<Address> GetListAddressesByParameter(int person_id)
        {
            return _addressDal.GetAddressesWithCityAndProvince(person_id);
        }

        public void TAdd(Address t)
        {
            _addressDal.Insert(t);
        }

        public void TDelete(Address t)
        {
            throw new NotImplementedException();
        }

        public Address TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Address t)
        {
            throw new NotImplementedException();
        }
    }
}
