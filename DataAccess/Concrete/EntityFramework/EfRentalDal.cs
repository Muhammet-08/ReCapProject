using Core.DataAccess;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Linq;


namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, ReCapProjectContext>, IEntityRepository<Rental>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                var result = from c in context.Customers
                             join r in context.Rentals
                             on c.CustomerId equals r.CustomerId
                             join cc in context.Cars
                             on r.CarId equals cc.CarId
                             select new RentalDetailDto
                             {
                                 CarId = cc.CarId,
                                 CustomerId = c.CustomerId,
                                 RentalId = r.RentalId,
                                 RentDate = r.RentDate,
                                 ReturnDate = r.ReturnDate,
                                 CarName=cc.CarName
                                
                                 
                             };
                             return result.ToList();
            }
        }
    }
}
