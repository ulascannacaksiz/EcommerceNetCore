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
    public class WhisListManager : IWhisListService
    {
        IWhisListDal _whisListDal;

        public WhisListManager(IWhisListDal whisListDal)
        {
            _whisListDal = whisListDal;
        }

        public List<WhisList> GetList()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public void TUpdate(WhisList t)
        {
            throw new NotImplementedException();
        }
    }
}
