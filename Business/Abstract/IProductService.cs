﻿using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetAllByCategoryId(int Id);
        List<Product> GetByUnitPrice(decimal min, decimal max);

    }
}
