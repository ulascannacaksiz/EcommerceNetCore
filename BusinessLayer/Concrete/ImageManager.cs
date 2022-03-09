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
    public class ImageManager : IImageService
    {
        IImageDal _ımageDal;

        public ImageManager(IImageDal ımageDal)
        {
            _ımageDal = ımageDal;
        }

        public List<Image> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Image> GetListByProductId(int id)
        {
            return _ımageDal.GetListAll(x => x.ProductId == id);
        }

        public void TAdd(Image t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Image t)
        {
            throw new NotImplementedException();
        }

        public Image TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Image t)
        {
            throw new NotImplementedException();
        }
    }
}
