using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCapProjectContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCapProjectContext context=new ReCapProjectContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands
                             on c.BrandId equals b.BrandId
                             join cc in context.Colors
                             on c.ColorId equals cc.ColorId
                             select new CarDetailDto {BrandName=b.BrandName,CarName=c.CarName,
                                 ColorName=cc.ColorName,DailyPrice=c.DailyPrice,Description=c.Description };
                return result.ToList();
            }
        }
    }
}
