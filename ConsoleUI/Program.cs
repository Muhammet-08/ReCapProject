using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory_sahte_veritabanı_;
using Entities;
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
            //UserDeleted();
            //CustomerEvent();
            //RentalEvent();

        }

        private static void RentalEvent()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            foreach (var rental in rentalManager.GetDetailRental().Data)
            {
                Console.WriteLine("Kiralanan Araç: " + rental.CarName);
            }
        }

        private static void CustomerEvent()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Update(new Customer { CustomerId = 5, UserId = 5, CompanyName = "Trendyol" });

            foreach (var customer in customerManager.GetAll().Data)
            {
                Console.WriteLine(customer.CompanyName);
            }
        }

        private static void UserDeleted()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Delete(new User { UserId = 6 });
            userManager.Delete(new User { UserId = 7 });
            userManager.Delete(new User { UserId = 8 });
            userManager.Delete(new User { UserId = 9 });
            userManager.Delete(new User { UserId = 10 });

            foreach (var user in userManager.GetAll().Data)
            {
                Console.WriteLine("Kullanıcı Adı Soyadı:{0} {1} {2}", user.FirstName, user.LastName, user.UserId);
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
