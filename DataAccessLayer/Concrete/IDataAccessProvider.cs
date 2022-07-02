using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public interface IDataAccessProvider
    {
            void AddUser(User user);
            void AddAccount(Account account);
            void AddSite(Site site);
            //void UpdateAccount(int accountid);
            //void DeleteAccount(int accountId);
            //List<Account> GetAccounts(); 
    }
}
