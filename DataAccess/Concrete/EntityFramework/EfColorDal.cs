using Core.DataAccess.EntityFramework;
using Core.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFremework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color, CarsDBContext>, IColorDal
    {

    }
}
