using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity,TContext>:IEntityRepository<TEntity>
        where TEntity:class,IEntity,new()
        where TContext:DbContext,new()
    {
        public void Add(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);//yukarıda verilen referansı yakala
                addedEntity.State = EntityState.Added;//onu ekle 
                context.SaveChanges();//yukarıdaki işlemleri tut 
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);//yukarıda verilen referansı yakala
                deletedEntity.State = EntityState.Deleted;//onu ekle 
                context.SaveChanges();//yukarıdaki işlemleri tut 
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);//buradaki filtre yazacağımız lambda komutu

            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList() //car tablosunu döndür bana select*from products  (filtre var ise)
                    : context.Set<TEntity>().Where(filter).ToList(); //filtre varsa bu filtreleyip yolla demek

            }
        }

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);//yukarıda verilen referansı yakala
                updatedEntity.State = EntityState.Modified;//onu ekle 
                context.SaveChanges();//yukarıdaki işlemleri tut 
            }
        }
    }
}
