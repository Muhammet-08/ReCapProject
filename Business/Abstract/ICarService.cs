using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetById(int id);
        List<Car> GetAll();
        public void Add(Car car);
        public void Delete(Car car);
        public void Update(Car car);
        List<CarDetailDto> GetCarDetails();
    }
}
