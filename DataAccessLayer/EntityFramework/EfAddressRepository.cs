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
    public class EfAddressRepository : GenericRepository<Address>, IAddressDal
    {
        public List<Address> GetAddressesWithCityAndProvince(int id)
        {
            using (var c = new Context())
            {
                return c.Addresses.Include(u => u.City).Include(x =>x.Province).Where(p=>p.UserId == id).ToList();
            }
        }
    }
}
