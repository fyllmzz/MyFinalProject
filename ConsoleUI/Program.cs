using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Princible : Yaptığın yazılıma yeni bir özellik ekliyorsan, 
    //mevcuttaki hiç bir koduna dokunamazsın


    class Program
    {
        static void Main(string[] args)
        {
            //Hangi veri yöntemiyle çalışıldığını söylemek lazım.
            // ProductManager productManager = new ProductManager(new InMemoryProductDal());
            //InMemory çalışacağım diyor.
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetByUnitPrice(30,60))
            {
                Console.WriteLine(product.ProductName);

            }



            
        }
    }
}
