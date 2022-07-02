using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAccountService:IGenericService<Account>
    {
        Account Signup(Account oAccount);
        //List<Account> GetAllAccounts();
        //Account TDelete(int accountId);
        //Account TUpdate(Account account);
       
    }
}
