using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context : Db tabloları ile proje claslarını bağlamak
   public  class NorthwindContext:DbContext
    {

        //override on 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //sql server a nasıl bağlanacağını belirt.
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=Northwind; Trusted_Connection=true");
        }//Context hangi veri tabanına bağlanacağını buldu

        public DbSet<Product> Products { get; set; }//hangi clas hangi tabloya karşılık gelir.
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
