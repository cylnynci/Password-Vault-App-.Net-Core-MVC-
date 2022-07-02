using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserService : IUserService
    {
        DataAccessProvider data = new DataAccessProvider(new Context());
      
        public User Signup(User oUser)
        {

            oUser.Password = MD5Encrypt.Encrypt(oUser.Password);
            data.AddUser(oUser);
            return oUser;
        }
   
    }
}
