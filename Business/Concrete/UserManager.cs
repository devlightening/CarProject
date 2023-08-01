using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);

        }
        public void Update(User user)
        {
            _userDal.Update(user);
        }

        public User GetByEmail(string email)
        {
            return _userDal.Get(u=>u.Email==email);

        }

        public User GetById(int id)
        {
            return _userDal.Get(u=>u.Id==id);
        }

        public User GetByMail(string email)
        {
            return _userDal.Get(u=>u.Email==email);
        }
        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

    
    }
}
