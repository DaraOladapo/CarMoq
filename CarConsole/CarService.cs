﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CarConsole
{
    public class CarService
    {
        private ICarService carService;
        public CarService(ICarService _carService)
        {
            carService = _carService;
        }
        //C
        public Car AddCar(AddCar addCar)
        {
            return new Car() { ID = Guid.NewGuid(), Make = addCar.Make, Model = addCar.Model, Year = addCar.Year };
        }
        //R
        public List<Car> GetCars()
        {
            return new List<Car>() {
                new Car { ID=Guid.NewGuid(), Make = "Toyota", Model = "CH-R", Year = 2020 },
                new Car { ID=Guid.NewGuid(), Make = "Honda", Model = "CR-V", Year = 2019 },
                new Car { ID=Guid.NewGuid(), Make = "Ford", Model = "Mustang Mach E", Year = 2020 },
                new Car { ID=Guid.NewGuid(), Make = "Vauxhaul", Model = "Insigna", Year = 2020 },
            };
        }
        public Car GetCar(Guid guid)
        {
            return new Car() { ID = guid, Make = "Toyota", Model = "CH-R", Year = 2020 };
        }
        //U
        public Car UpdateCar(UpdateCar updateCar, Guid guid)
        {
            return new Car() { ID = guid, Make = "Toyota", Model = "CH-R", Year = 2020 };
        }
        //D
        public void DeleteCar(Guid guid)
        {
            Console.WriteLine($"Item with ID: {guid} deleted.");
        }
    }
}
