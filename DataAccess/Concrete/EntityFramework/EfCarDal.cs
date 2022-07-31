using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                var addedEntity = context.Entry(entity);//yukarıda verilen referansı yakala
                addedEntity.State = EntityState.Added;//onu ekle 
                context.SaveChanges();//yukarıdaki işlemleri tut 
            }
        }

        public void Delete(Car entity)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var deletedEntity = context.Entry(entity);//yukarıda verilen referansı yakala
                deletedEntity.State = EntityState.Deleted;//onu ekle 
                context.SaveChanges();//yukarıdaki işlemleri tut 
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);//buradaki filtre yazacağımız lambda komutu

            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                return filter == null
                    ? context.Set<Car>().ToList() //car tablosunu döndür bana select*from products  (filtre var ise)
                    : context.Set<Car>().Where(filter).ToList(); //filtre varsa bu filtreleyip yolla demek
                    
            }
        }

        public void Update(Car entity)
        {
            using (ReCapProjectContext context = new ReCapProjectContext())
            {
                var updatedEntity = context.Entry(entity);//yukarıda verilen referansı yakala
                updatedEntity.State = EntityState.Modified;//onu ekle 
                context.SaveChanges();//yukarıdaki işlemleri tut 
            }
        }
    }
}
