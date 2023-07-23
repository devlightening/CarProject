using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<Car> GetById(int carId);
        IResult Add(Car car);   
        IResult Update(Car car);    
        IResult Delete(Car car);
        IDataResult<List<Car>> GetCarsByColorId();
        IDataResult<List<Car>> GetCarsByBrandId();
        IDataResult<List<Car>> GetAll();
        IDataResult<List<CarDetailDto>> CarDetails();


    }
}
