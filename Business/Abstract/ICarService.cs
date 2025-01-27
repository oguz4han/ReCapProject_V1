﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        void AddCar(Car car);
        void UpdateCar(Car car);
        void DeleteCar(Car car);
        Car GetCarById(int id);
        List<Car> GetAllCars();
    }
}
