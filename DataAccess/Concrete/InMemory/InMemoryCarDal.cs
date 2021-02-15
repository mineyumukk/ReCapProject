using DataAccess.Absract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars; //Ürün listesi varmış gibi
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId = 1, BrandId = 1, ColorId = 1, ModelYear = 2017, DailyPrice = 409000, Description = "MERCEDES C 200" },
                new Car{CarId = 2, BrandId = 2, ColorId = 1, ModelYear = 2016, DailyPrice = 129500, Description = "FIAT EGEA" },
                new Car{CarId = 3, BrandId = 3, ColorId = 2, ModelYear = 2016, DailyPrice = 145500, Description = "RENAULT FLUENCE" },
                new Car{CarId = 4, BrandId = 4, ColorId = 2, ModelYear = 2013, DailyPrice = 161500, Description = "VOLKSWAGEN GOLF" },
                new Car{CarId = 5, BrandId = 5, ColorId = 2, ModelYear = 2015, DailyPrice = 473500, Description = "VOLVO XC 60" },
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId==car.CarId);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByBrandId(int brandId)
        {
           return _cars.Where(c => c.BrandId == brandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}