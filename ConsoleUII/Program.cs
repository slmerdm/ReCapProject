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
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car {ColorId=1, BrandId=1, DailyPrice=250, ModelYear=2018, Description="Audi" });

            foreach (var car1 in carManager.GetAll())
            {
                Console.WriteLine(car1.Description);
            }
            
        }
    }
}
