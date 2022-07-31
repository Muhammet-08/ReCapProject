using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory_sahte_veritabanı_
{
    public class InMemoryCarDal : ICarDal
    {
        //ürünVarmış gibi davranacağımız için bir ürün listesi oluşturuyoruz.
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=200,Description="Orta seviye",ModelYear=2020},
                new Car{CarId=2,BrandId=2,ColorId=2,DailyPrice=300,Description="Düşük seviye",ModelYear=2020},
                new Car{CarId=3,BrandId=3,ColorId=3,DailyPrice=200,Description="Alt seviye",ModelYear=2020},
                new Car{CarId=4,BrandId=4,ColorId=4,DailyPrice=200,Description="Kötü seviye",ModelYear=2020},
                new Car{CarId=5,BrandId=5,ColorId=5,DailyPrice=200,Description="Çok İyi seviye",ModelYear=2020}
            };
        }


        public void Add(Car car) //ürün newlemek
        {
            _cars.Add(car);
        }

        public void Delete(Car car) //üstteli liste elemanlarının referansıyla uymadığı için LİNQ kullanırız
        {
            Car carToDelete;
            carToDelete = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate;
            carToUpdate = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            car.ModelYear = car.ModelYear;
        }
    }
}
