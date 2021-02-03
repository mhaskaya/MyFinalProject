using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        //List<Category> GetAll();
        //void Add(Category product);
        //void Update(Category product);
        //void Delete(Category product);

        //List<Category> GetAllByCategory(int categoryId);
    }
}
