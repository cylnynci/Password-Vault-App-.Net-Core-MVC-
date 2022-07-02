using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;                                   //Dependency Injection 
        public UserManager(IUserDal userDal)                 //Dependency Injection
        {
            _userDal = userDal;                              //Dependency Injection
        }

        public User Signup(User oUser)
        {
            throw new NotImplementedException();
        }
    }
}
