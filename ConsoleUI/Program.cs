using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //GetAllMethod();

            //GetByBrandsMethod();

            //AddMethod();

            GetByColorsMethod();

        }

        private static void GetAllMethod()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine($"Araba: {car.CarName} Modeli: {car.Description}");
            }

        }

        private static void GetByBrandsMethod()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetByBrands(1))
            {
                Console.WriteLine($"Araba: {car.CarName} Modeli: {car.Description}");
            }
        }

        private static void AddMethod()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            carManager.Add(new Car { Id = 5, BrandId = 2, ColorId = 3, CarName = "Skoda", DailyPrice = 120000, Description = "Skoda Elektrikli", ModelYear = 2019, UnitInStock = 4 });

            //Console.WriteLine(carManager.GetAll().Count);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine($"Araba: {car.CarName} Modeli: {car.Description}");
            }
        }

        private static void GetByColorsMethod()
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetByColors(1))
            {
                Console.WriteLine($"Araba: {car.CarName} Modeli: {car.Description} Rengi: {car.ColorId}");
            }
        }
    }
}
