using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, ReCapProjectContext>, ICustomerDal
    {
        //public List<Customer> GetCustomertDetail()
        //{
        //    using (ReCapProjectContext context = new ReCapProjectContext())
        //    {
        //        var result = from u in context.Users
        //                     join cm in context.Customers
        //                     on u.UserId equals cm.UserId
        //                     select new CustomerDetailDto
        //                     {
        //                         CustomerId = cm.CustomerId,
        //                         UserId = u.UserId,
        //                         Password = u.Password,
        //                         UserName = u.FirstName

        //                     };
        //        return result.ToList();

        //    }
        //}
    }
}
