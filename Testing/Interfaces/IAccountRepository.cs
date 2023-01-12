using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing.Interfaces
{
    public interface IAccountRepository
    {
        public Account GetByName(string uniqueAccountName);

        public void AddTransaction(decimal transactionAmount);
    }
}
