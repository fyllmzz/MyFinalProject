using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{

    //Generic constraint= Generic kısıt
    //class : referans tip olabilir.
    //IEntity : IEntity olabilir veya IEntity implement eden bir nesne olabilir.
    //new() : Newlenebilir olmalı (Ientitydevre dışı kalır. o interface oldupundan dolayı new lenemez.)


   public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null); //ürünlerin hepsini al getir listele.
        //Filtre vermeyedebilirsin demek. eğer verirsen ona göre filtreleyip getirir.
        
        T Get(Expression<Func<T,bool>> filter);//kredi detay , hesap detayı 
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
      //  List<T> GetAllByCategory(int categoryId); //Ürünleri Kategoriye göre filtrele
    }
}
