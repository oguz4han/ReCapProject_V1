using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{

    /*
      _cars = new List<Car> {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=150200,ModelYear=new DateTime(2017-2-7),Description="ABD Üretim"},
                new Car{Id=2,BrandId=1,ColorId=2,DailyPrice=120200,ModelYear=new DateTime(2020-2-7),Description="ABD Üretim"},
                new Car{Id=3,BrandId=2,ColorId=2,DailyPrice=180200,ModelYear=new DateTime(2015-2-7),Description="İtalya Üretim"},
                new Car{Id=4,BrandId=2,ColorId=1,DailyPrice=160200,ModelYear=new DateTime(2019-2-7),Description="İtalya Üretim"},
                new Car{Id=5,BrandId=3,ColorId=1,DailyPrice=190200,ModelYear=new DateTime(2024-2-7),Description="Türkiye Üretim"},
            };
     * */

    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
                new Car{Id=1,BrandId=1,ColorId=1,DailyPrice=150200,ModelYear=new DateTime(2017-2-7),Description="ABD Üretim"},
                new Car{Id=2,BrandId=1,ColorId=2,DailyPrice=120200,ModelYear=new DateTime(2020-2-7),Description="ABD Üretim"},
                new Car{Id=3,BrandId=2,ColorId=2,DailyPrice=180200,ModelYear=new DateTime(2015-2-7),Description="İtalya Üretim"},
                new Car{Id=4,BrandId=2,ColorId=1,DailyPrice=160200,ModelYear=new DateTime(2019-2-7),Description="İtalya Üretim"},
                new Car{Id=5,BrandId=3,ColorId=1,DailyPrice=190200,ModelYear=new DateTime(2024-2-7),Description="Türkiye Üretim"},
            };
        }
        public void Add(Car car)
        {
            if (_cars.Contains(car))
            {
                Console.WriteLine("Sistemde ");
            }
            else
            {
                _cars.Add(car);
            }

        }

        public void Delete(Car car)
        {

            var deletedCar = _cars.SingleOrDefault(x => x.Id == car.Id);
            _cars.Remove(deletedCar);

        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public Car GetByID(int id)
        {
            var selectedCar = _cars.SingleOrDefault(c => c.Id == id);
            return selectedCar;
        }

        public void Update(Car car)
        {
            var updatedCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            int i = _cars.IndexOf(updatedCar);
            updatedCar.Id = car.Id;
            updatedCar.BrandId = car.BrandId;
            updatedCar.ColorId = car.ColorId;
            updatedCar.DailyPrice = car.DailyPrice;
            updatedCar.Description = car.Description;
            updatedCar.ModelYear = car.ModelYear;
            _cars[i] = updatedCar;
        }

    }
}
