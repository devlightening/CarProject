using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal 
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1,BrandId=2,ColorId=3,DailyPrice=600,ModelYear=2022,Description="This car brand is : Hyundai Sonata ,it is a speed car."},
                new Car{CarId=1,BrandId=3,ColorId=3,DailyPrice=500,ModelYear=2000,Description="This car brand is : Hyundai i20 ,it is a speed car."},
                new Car{CarId=2,BrandId=4,ColorId=3,DailyPrice=450,ModelYear=2023,Description="This car brand is : Volvo XC40 ,it is a speed car."},
                new Car{CarId=2,BrandId=2,ColorId=3,DailyPrice=200,ModelYear=2021,Description="This car brand is : Mercedes E250 ,it is a speed car."},
                new Car{CarId=3,BrandId=4,ColorId=3,DailyPrice=325,ModelYear=2008,Description="This car brand is : Ford Focus ,it is a speed car."},
                new Car{CarId=3,BrandId=1,ColorId=3,DailyPrice=520,ModelYear=2009,Description="This car brand is : Hyundai i30 ,it is a speed car."},
                new Car{CarId=4,BrandId=2,ColorId=3,DailyPrice=900,ModelYear=2015,Description="This car brand is : Audi Q7 ,it is a speed car."},
                new Car{CarId=4,BrandId=4,ColorId=3,DailyPrice=1560,ModelYear=2019,Description="This car brand is : BMW M3 ,it is a speed car."},

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //LINQ - Language Integrated Query
            //Lambda
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);

            _cars.Remove(carToDelete);
        }
        public List<Car> GetAll()
        {
            return _cars;
        }
        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
            carToUpdate.CarId= car.CarId;
            carToUpdate.BrandId= car.BrandId;
            carToUpdate.ColorId= car.ColorId;
            carToUpdate.DailyPrice= car.DailyPrice;
            carToUpdate.ModelYear= car.ModelYear;
            carToUpdate.Description= car.Description;
            
        }
    }
}
