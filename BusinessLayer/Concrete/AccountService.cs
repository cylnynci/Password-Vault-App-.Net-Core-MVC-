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
    public class AccountService : IAccountService
    {
        DataAccessProvider data = new DataAccessProvider(new Context());

        public Account Signup(Account oAccount)
        {
            oAccount.SitePassword = EncryptDecrypt.EncryptString("1234567890123456", oAccount.SitePassword);
            data.AddAccount(oAccount);
            return oAccount;
        }

     

     
       
    
     

       
    }
}
