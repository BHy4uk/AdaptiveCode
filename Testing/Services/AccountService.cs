using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing.Interfaces;

namespace Testing.Services
{
    public class AccountService : IAccountService
    {
        public AccountService(IAccountRepository repository)
        {
            this.repository = repository;
        }
        public void AddTransactionToAccount(string uniqueAccountName,
        decimal transactionAmount)
        {
        }
        private readonly IAccountRepository repository;
    }
}
