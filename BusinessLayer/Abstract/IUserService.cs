using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IUserService:IGenericService<User>
    {
        User Signup(User oUser);
        //User Login(User oUser);
        //List<User> GetAllUsers();
    }
}
