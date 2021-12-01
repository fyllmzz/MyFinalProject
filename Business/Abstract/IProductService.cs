using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public interface IProductService
    {

        List<Product> GetAll();
        List<Product> GetAllCategoryId(int id); //categoryId sine göre getiren operasyon yazılır.

        List<Product> GetByUnitPrice(decimal min, decimal max);//şu fiyat aralığında olanları getir.



    }
}
