using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderManagement.Data.Common;
using OrderManagement.Data.Repositories;
using OrderManagement.Model;

namespace OrderManagement.Services
{
    public class AccountServices : IAccountService
    {
        private readonly IRepository<Account> _accountRepository;

        public AccountServices()
        {
            _accountRepository = new AccountRepository();
        }

        public string AddAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public string DeleteAccount(Account account)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAllAccounts()
        {
            throw new NotImplementedException();
        }

        public string UpdateAccount(Account account)
        {
            throw new NotImplementedException();
        }
    }

    public interface IAccountService
    {
        string AddAccount(Account account);
        string DeleteAccount(Account account);
        string UpdateAccount(Account account);
        IEnumerable<Order> GetAllAccounts();
    }
}
