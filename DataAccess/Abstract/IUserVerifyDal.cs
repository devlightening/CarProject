using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IUserVerifyDal : IEntityRepository<UserVerify>
    {
     
    }
}
