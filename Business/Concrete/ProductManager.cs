using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{

    //İş katmanının somut sınıfı, operasyonlar yapılır.
    public class ProductManager : IProductService
    {
        //BUsinessın bildiği tek şey IProductDal, Bu ilerde her şey olabilir.
        IProductDal _productDal;

        //ProductManager newlendiğinde, bu constructor çalışır. 
        //burada IproductDal referansı ver diyor.
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()
        {
            //iş kodları
            //yetkisi var mı?

            //Bir iş sınıfı başka sınıfları new lemez.. İNJECTİON YAP.

            return _productDal.GetAll();

        }

        public List<Product> GetAllCategoryId(int id)
        {
            return _productDal.GetAll(p => p.CategoryId == id);

        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }
    }
}
