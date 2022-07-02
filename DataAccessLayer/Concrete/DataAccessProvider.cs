using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class DataAccessProvider : IDataAccessProvider
    {
        private readonly Context _context;

        public DataAccessProvider(Context context)
        {
            _context = context;
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void AddAccount(Account account)
        {
            _context.Accounts.Add(account);
            _context.SaveChanges();
        }

        //public void UpdateAccount(Account account)
        //{
        //    _context.Accounts.Update(account);
        //    _context.SaveChanges();
        //}

        //public void DeleteAccount(int accountId)
        //{
        //    var entity = _context.Accounts.FirstOrDefault(t => t.AccountId == accountId);
        //    _context.Accounts.Remove(entity);
        //    _context.SaveChanges();
        //}

        //public List<Account> GetAccounts()
        //{
        //    return _context.Accounts.ToList();
        //}

        //public List<Account> GetAccounts(string p)
        //{
        //    return _context.Accounts.Include(p).ToList();
        //}


        public void AddSite(Site site)
        {
            _context.Sites.Add(site);
            _context.SaveChanges();
        }

        public static List<User> Users { get; set; } = new List<User>();
        public static List<Account> Accounts { get; set; } = new List<Account>();
        public static List<Site> Sites { get; set; } = new List<Site>();
    }
}
