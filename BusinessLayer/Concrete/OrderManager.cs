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
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public List<Order> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Order> GetOrderListByUser(int id)
        {
            return _orderDal.GetListWithProductByUserId(id);
        }

        public void TAdd(Order t)
        {
            _orderDal.Insert(t);
        }

        public void TDelete(Order t)
        {
            throw new NotImplementedException();
        }

        public Order TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Order t)
        {
            throw new NotImplementedException();
        }
    }
}
