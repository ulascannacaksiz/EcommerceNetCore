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
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetList()
        {
            throw new NotImplementedException();
        }
        public List<Product> GetProductById(int id)
        {
            return _productDal.GetListAll(x => x.Id == id);
        }

        public List<Product> GetProductDetailWithCategory(int id)
        {
           return _productDal.GetProductDetailWithCategory(id);
        }

        public void TAdd(Product t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Product t)
        {
            throw new NotImplementedException();
        }

        public Product TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Product t)
        {
            throw new NotImplementedException();
        }
    }
}
