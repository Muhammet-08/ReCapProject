using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory_sahte_veritabanı_;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarIdInsert();
            //ColorIdInsert();
            //BrandIdInsert();
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(new Car {CarId= 10});
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarName+"/"+car.Description);
            }
        }

        private static void BrandIdInsert()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            foreach (var brand in brandManager.GetById(2).Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void ColorIdInsert()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetById(5).Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void CarIdInsert()
        {
            Console.WriteLine("CAR");
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 3, DailyPrice = 0, CarName = "Mercedes araba" });

            foreach (var car in carManager.GetById(1).Data)
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
