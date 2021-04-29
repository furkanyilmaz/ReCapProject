using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();

            Console.WriteLine("car id:");
            car1.Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("car brand id:");
            car1.BrandId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("car color id:");
            car1.ColorId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("car model year: ");
            car1.ModelYear = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("car daily price :");
            car1.DailyPrice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("car model name: ");
            car1.Description = (Console.ReadLine());

            CarTest(car1);

           // BrandTest();

        }

        //private static void BrandTest()
        //{
        //    BrandManager brandManager = new BrandManager(new EfBrandDal());
        //    foreach (var brand in brandManager.GetAll())
        //    {
        //        Console.WriteLine(brand.BrandName);
        //    }
        //}

        private static void CarTest(Car car1)
        {
            CarManager carManager = new CarManager(new EfCarDal());



            carManager.Add(car1);

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
        }
    }
}
