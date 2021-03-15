using Business;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUII
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            //BrandTest();
            //ColorTest();

           
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "Siyah" });
            colorManager.Add(new Color { ColorName = "Kırmızı" });
            Console.WriteLine("---color---");

            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorId + " " + color.ColorName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //brandManager.Add(new Brand { BrandName = "Kia" });
            //brandManager.Add(new Brand { BrandName = "Volvo" });

            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandId + " " + brand.BrandName);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //carManager.Add(new Car { ColorId = 1, BrandId = 1, DailyPrice = 250, ModelYear = 2018, Description = "AudiA4" });
            //carManager.Add(new Car { ColorId = 2, BrandId = 2, DailyPrice = 191, ModelYear = 2020, Description = "BMW3.20" });
            //carManager.Add(new Car { ColorId = 13, BrandId = 1, DailyPrice = 350, ModelYear = 2019, Description = "Insignia" });

            foreach (var car1 in carManager.GetCarDetails())
            {
                Console.WriteLine(car1.Description + " " + car1.BrandName + " " + car1.ColorName + " " + car1.DailyPrice);
                
            }
        }
    }
}
