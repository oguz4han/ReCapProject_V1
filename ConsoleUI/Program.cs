








using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

CarManager carManager = new CarManager(new InMemoryCarDal());

Console.WriteLine("Arabalar listeleniyor 1");
foreach (var car in carManager.GetAllCars())
{
    Console.WriteLine("Car ID:          " + car.Id);
    Console.WriteLine("Car BrandID:     " + car.BrandId);
    Console.WriteLine("Car ColorId:     " + car.ColorId);
    Console.WriteLine("Car DailyPrice:  " + car.DailyPrice);
    Console.WriteLine("Car ModelYear:   " + car.ModelYear);
    Console.WriteLine("Car DailyPrice:  " + car.DailyPrice);
    Console.WriteLine("Car Description: " + car.Description);
    Console.WriteLine("-----------");

}
Console.WriteLine("--------------------------------------------------------");

Console.WriteLine("Araba Ekleniyor.");
carManager.AddCar(new Car { Id = 6, BrandId = 2, ColorId = 3, DailyPrice = 154000, ModelYear = new DateTime(2000-2-2), Description = "Türkiye" });
Console.WriteLine("Eklendi...");

Console.WriteLine("--------------------------------------------------------");

Console.WriteLine("Arabalar listeleniyor 2");
foreach (var car in carManager.GetAllCars())
{
    Console.WriteLine("Car ID:          " + car.Id);
    Console.WriteLine("Car BrandID:     " + car.BrandId);
    Console.WriteLine("Car ColorId:     " + car.ColorId);
    Console.WriteLine("Car DailyPrice:  " + car.DailyPrice);
    Console.WriteLine("Car ModelYear:   " + car.ModelYear);
    Console.WriteLine("Car DailyPrice:  " + car.DailyPrice);
    Console.WriteLine("Car Description: " + car.Description);
    Console.WriteLine("-----------");

}

Console.WriteLine("--------------------------------------------------------");

Car deletCar = carManager.GetAllCars()[1];
carManager.DeleteCar(deletCar);

Console.WriteLine("Arabalar listeleniyor 3");
foreach (var car in carManager.GetAllCars())
{
    Console.WriteLine("Car ID:          " + car.Id);
    Console.WriteLine("Car BrandID:     " + car.BrandId);
    Console.WriteLine("Car ColorId:     " + car.ColorId);
    Console.WriteLine("Car DailyPrice:  " + car.DailyPrice);
    Console.WriteLine("Car ModelYear:   " + car.ModelYear);
    Console.WriteLine("Car DailyPrice:  " + car.DailyPrice);
    Console.WriteLine("Car Description: " + car.Description);
    Console.WriteLine("-----------");

}