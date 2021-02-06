
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
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

        public List<Product> GetAllByCategoryId(int Id)
        {
            return _produtDal.GetAll(p => p.CategoryId == Id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _produtDal.GetAll(p => p.UnitPrice <= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _produtDal.GetProductDetails();
        }
    }
}
