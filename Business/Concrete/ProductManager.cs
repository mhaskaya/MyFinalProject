
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _produtDal;

        public ProductManager(IProductDal productDal)
        {
            _produtDal = productDal;
        }
        public List<Product> GetAll()
        {
            return _produtDal.GetAll();
        }
    }
}
